using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// <para>Aquest <font color="#00FF40">namespace</font> conté les classes principals
/// del Model</para>
/// <para><img src="DiagramaClassesModel.cd"/></para>
/// <para></para>
/// </summary>
namespace DemoUnitTesting.Model
{

    /// <summary>
    ///  La classe persona conté les dades personals de tots els empleats,
    ///  treballadors externs i d'altres entitats personals del món mundial.
    ///  
    /// </summary>
    public class Persona
    {

        /// <summary>
        /// Creació de la persona. Si manca qualsevol camp o hi ha errors es llança una
        /// excepció.
        /// </summary>
        /// <param name="pNIF">(Camp obligatori) NIF amb lletra inclosa, sense espais al
        /// voltant. Es valida la lletra del NIF !</param>
        /// <param name="pNom">(Camp obligatori) No pot ser null ni cadena buida, el mínim
        /// número de caràcters és 3.</param>
        /// <param name="pCognoms">(Camp obligatori) No pot ser null ni cadena buida, el
        /// mínim número de caràcters és 3.</param>
        /// <param name="pDataNaix">(Camp obligatori) No pot ser futura, ni anterior al
        /// 1900.</param>
        /// <example>
        ///   <para></para>
        ///   <para>Un exemple d'ús del constructor podria ser:</para>
        /// <code source="Persona.cs" region="comentaris"></code>   
        /// <code lang="C#"><![CDATA[
        ///     Persona p = new Persona( "12345678H", "Paco", "Maroto", DateTime.Now-4 );
        ///     string nif = p.NIF;
        /// ]]></code>
        ///   <para> </para>
        /// </example>
        /// <exception cref="NIFInvalidException">Es llança si el NIF no és
        /// vàlid.</exception>
        public Persona(string pNIF, string pNom, string pCognoms, DateTime pDataNaix)
        {
            NIF = pNIF;
            Nom = pNom;
            Cognoms = pCognoms;
            DataNaix = pDataNaix;
            mAdreces = new List<Adreca>();
        }

        private List<Adreca> mAdreces;

        /// <summary>
        ///  Afegir una nova adreça a la persona ( evita duplicats )
        /// </summary>
        /// <see cref="Adreca"/>
        /// <param name="novaAdreca"> Si és null, s'ignora.</param>
        /// <returns>si la novaAdreca no existia a les adreces actuals, s'afegeix
        /// i es retorna true. Si l'adreça existia retorna false.
        /// En cas de novaAdreça nul·la, retorna false.</returns>
        public bool addAdreca(Adreca novaAdreca)
        {
            if (novaAdreca == null) throw new Exception();
            if (mAdreces.Contains(novaAdreca)) return false;

            mAdreces.Add(novaAdreca);
            return true;
        }
        #region comentaris
        public Adreca getAdreca(int i)
        {
            if (i < mAdreces.Count)
            {
                return mAdreces[i];
            }
            else
            {
                return null;
            }
        }
        #endregion
        public int getNumAdreces()
        {
            return mAdreces.Count;
        }


        /// <summary>
        ///   <para>El NIF de la persona (lletra inclosa! ) El camp valida longitud i lletra
        /// No admet nuls.</para>
        ///   <para>
        ///     <img src="nif.png" />
        ///   </para>
        ///   <list type="table">
        ///     <listheader>
        ///       <term>0</term>
        ///       <description>0</description>
        ///       <description>0</description>
        ///       <description>0</description>
        ///       <description>0</description>
        ///       <description>0</description>
        ///       <description>0</description>
        ///       <description>0</description>
        ///       <description>A</description>
        ///     </listheader>
        ///   </list>
        ///   <para></para>
        ///   <para>El NIF admet varis format:</para>
        ///   <list type="bullet">
        ///     <item>
        ///       <description>NIF estàndard ( 8+dígit de control)</description>
        ///     </item>
        ///     <item>
        ///       <description>CIF estàndard</description>
        ///     </item>
        ///     <item>
        ///       <description>NIE</description>
        ///     </item>
        ///   </list>
        /// </summary>
        public string NIF { get; set; }

        public string Nom { get; set; }

        public string Cognoms { get; set; }

        public DateTime DataNaix { get; set; }
    }
}
