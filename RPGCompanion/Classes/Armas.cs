using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCompanion.Classes
{

    public class Armas
    {
        private Utilitarios util = new Utilitarios();

        public string Nome { get; set; }
        public TipoArma Tipo { get; set; }
        public object Efeito { get; set; }
        public DadosRolagem AtqBasico { get; set; }


        //Arco Recurvo
        //Tipo: Arco;
        //Ataque Básico: (1d6*2) + (Mod.de Des.) de dano físico;
        //Acerto Crítico: Cause Ataque Básico*2 de dano físico;
        //Equipamento Inicial do Atirador.

    }
    public class DadosRolagem
    {
        public int Quanti { get; set; }
        public int Dado { get; set; }
        public int Multi { get; set; }
    }
    public enum TipoArma
    {
        Anel,
        Arco,
        ArmaduraDeCouro,
        PergaminhoSupremo,
        BastãoDeDuasMaos,
        Grimorio,
        Rapieira,
        Escudo,
        EspadaDeUmaMao,
        EspadaDeDuasMaos,
        Lanca,
        MachadoDeDuasMaos,
        Adagas,
        Manto,
        Botas,
        FoiceDeDuasMaos,
        Cajado,
        Colar,
        Maça,
        Bandagem
    }
}
