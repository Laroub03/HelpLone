using System;

namespace CharacterGame
{
public interface ICharacter
{
    void Heal();
    void Die();
    void Fight();

}

public interface Ispecialattacks
{
    void Bash();
    void Cleave();
    void Slash();
}
public interface Idefence
{
    void RaiseShield();
    void ShieldGlare();
}

public interface Imagicattacks
{
    void ThrowFrostNova();
    void ThrowMagicMisile();
}
public interface Imagicdefence
{
    void Teleport(int x, int y);
}
    public class Program
    {
        public static void Main(string[] args)
        {
            Wizard wizard = new Wizard();
            Barbarian barbarian = new Barbarian();
            Knight knight = new Knight();
            Witch witch = new Witch();

            Console.WriteLine("Wizard actions:");
            wizard.Fight();
            wizard.Heal();
            wizard.Die();
            wizard.ThrowFrostNova();
            wizard.ThrowMagicMisile();
            wizard.Teleport(5, 10);

            Console.WriteLine("\nBarbarian actions:");
            barbarian.Fight();
            barbarian.Heal();
            barbarian.Die();
            barbarian.Bash();
            barbarian.Cleave();
            barbarian.Slash();

            Console.WriteLine("\nKnight actions:");
            knight.Fight();
            knight.Heal();
            knight.Die();
            knight.Bash();
            knight.Cleave();
            knight.Slash();
            knight.RaiseShield();
            knight.ShieldGlare();

            Console.WriteLine("\nWitch actions:");
            witch.Fight();
            witch.Heal();
            witch.Die();
            witch.RaiseShield();
            witch.ShieldGlare();
            witch.Teleport(3, 7);

            Console.ReadKey();
        }
    }
}








