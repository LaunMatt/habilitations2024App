using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests
    {
        [TestMethod()]
        public void DeveloppeurAccessTest()
        {

        }

        [TestMethod()]
        public void ControleAuthentificationTest()
        {

        }

        /// <summary>
        /// Méthode de test de la méthode GetLesDeveloppeurs()
        /// </summary>
        [TestMethod()]
        public void GetLesDeveloppeursTest()
        {
            DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();
            int nbAttendu = 20; // Nombre total de développeurs dans la BDD "habilitations"

            List<Developpeur> liste = developpeurAccess.GetLesDeveloppeurs();

            Assert.AreEqual(nbAttendu, liste.Count, $"Le nombre total de développeurs attendu est {nbAttendu}.");
        }

        /// <summary>
        /// Méthode de test de la méthode de surcharge GetLesDeveloppeurs()
        /// </summary>
        [TestMethod()]
        public void GetLesDeveloppeursTest1()
        {
            DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();
            Profil profilFiltre = new Profil(1, "stagiaire"); // id de profil 1 correspondant au profil "stagiaire" dans la BDD "habilitations"
            int nbAttendu = 6; // le nombre de développeurs ayant comme profil "stagiaire" dans la BDD "habilitations"

            List<Developpeur> liste = DeveloppeurAccess.GetLesDeveloppeurs(profilFiltre);

            Assert.AreEqual(nbAttendu, liste.Count, $"Le nombre de développeurs pour le profil '{profilFiltre.Nom}' devrait être {nbAttendu}.");
        }

        [TestMethod()]
        public void DelDepveloppeurTest()
        {

        }

        [TestMethod()]
        public void AddDeveloppeurTest()
        {

        }

        [TestMethod()]
        public void UpdateDeveloppeurTest()
        {

        }

        [TestMethod()]
        public void UpdatePwdTest()
        {

        }
    }
}