
using System;
using System.Collections.Generic;
using System.Linq;

public class CombatEncounter : IEncounter
{
    private const int MaxRondas = 1000; // evita bucle infinito si nadie puede hacer daño

    private readonly List<Heroe> heroes;
    private readonly List<Enemigo> enemigos;

    public CombatEncounter(List<Heroe> heroes, List<Enemigo> enemigos)
    {
        if (heroes == null || heroes.Count == 0)
            throw new ArgumentException("Debe haber al menos un héroe");
        if (enemigos == null || enemigos.Count == 0)
            throw new ArgumentException("Debe haber al menos un enemigo");

        this.heroes = heroes;
        this.enemigos = enemigos;
    }

    public void DoEncounter()
    {
        int ronda = 0;

        while (HayHeroesVivos() && HayEnemigosVivos() && ronda++ < MaxRondas)
        {
            EnemigosAtacan();

            if (!HayHeroesVivos()) break;

            HeroesAtacan();
        }

        CurarHeroesConSuficientesVP();
    }

    private bool HayHeroesVivos() => heroes.Any(h => h.EstaVivo);

    private bool HayEnemigosVivos() => enemigos.Any(e => e.EstaVivo);

    private void EnemigosAtacan()
    {
        List<Heroe> heroesVivos = heroes.Where(h => h.EstaVivo).ToList();
        List<Enemigo> enemigosVivos = enemigos.Where(e => e.EstaVivo).ToList();

        for (int i = 0; i < enemigosVivos.Count; i++)
        {
            Heroe objetivo = heroesVivos[i % heroesVivos.Count];
            enemigosVivos[i].Atacar(objetivo);
        }
    }

    private void HeroesAtacan()
    {
        foreach (Heroe heroe in heroes.Where(h => h.EstaVivo).ToList())
        {
            foreach (Enemigo enemigo in enemigos.Where(e => e.EstaVivo).ToList())
            {
                heroe.Atacar(enemigo);

                if (!enemigo.EstaVivo)
                {
                    heroe.GanarVP(enemigo.VP);
                }
            }
        }
    }

    private void CurarHeroesConSuficientesVP()
    {
        foreach (Heroe heroe in heroes.Where(h => h.EstaVivo && h.VP >= 5))
        {
            heroe.Curar();
        }
    }
}