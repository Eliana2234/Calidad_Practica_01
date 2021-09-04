using NUnit.Framework;
using HelloWorldTesting20212;

namespace PruebasUnitarias
{
    public class Tests
    {
        //test para primer ejeercicio
        [Test]
        public void insertar94retornaXCIV() {
            var programa = new Program();
            var numero = 94;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("XCIV", result);
        }
        [Test]
        public void insertar670retornaDCLXX() {
            var programa = new Program();
            var numero = 670;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("DCLXX", result);
        }
        [Test]
        public void insertar11retornaXI() {
            var programa = new Program();
            var numero = 11;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("XI", result);
        }
        [Test]
        public void insertar75retornaLXXV() {
            var programa = new Program();
            var numero = 75;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("LXXV", result);
        }
        [Test]
        public void insertar100retornaC() {
            var programa = new Program();
            var numero = 100;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("C", result);
        }
        [Test]
        public void insertar58retornaLVIII() {
            var programa = new Program();
            var numero = 58;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("LVIII", result);
        }
        [Test]
        public void insertar48retornaXLVIII() {
            var programa = new Program();
            var numero = 48;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("XLVIII", result);
        }
        [Test]
        public void insertar65retornaLXV() {
            var programa = new Program();
            var numero = 65;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("LXV", result);
        }
        [Test]
        public void insertar1000retornaM() {
            var programa = new Program();
            var numero = 1000;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("M", result);
        }
        [Test]
        public void insertar530retornaDXXX() {
            var programa = new Program();
            var numero = 530;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("DXXX", result);
        }
        [Test]
        public void insertar780retornaDCCLXXX() {
            var programa = new Program();
            var numero = 780;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("DCCLXXX", result);
        }
        [Test]
        public void insertar492retornaCDXCII() {
            var programa = new Program();
            var numero = 492;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("CDXCII", result);
        }
        [Test]
        public void insertar320retornaCCCXX() {
            var programa = new Program();
            var numero = 320;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("CCCXX", result);
        }
        [Test]
        public void insertar202retornaCCII() {
            var programa = new Program();
            var numero = 202;
            var result = programa.NumerosRomanos(numero);
            Assert.AreEqual("CCII", result);
        }


        //Test para piedra papel o tijeras
        [Test]
        public void J1PiedraJ2PiedraEmpate()
        {
            var jugador1 = new Jugador("J1", 0);
            var jugador2 = new Jugador("J1", 0);
            var programa = new Program();
            var result = programa.PiedraPapelyTijera(jugador1,jugador2);
            Assert.AreEqual("Empate",result);
        }

        [Test]
        public void J1PapelJ2PapelEmpate()
        {

        }

        [Test]
        public void J1TijeraJ2TijeraEmpate()
        {

        }

        [Test]
        public void J1PiedraJ2PapelGanaJ2()
        {

        }

        [Test]
        public void J1PiedraJ2TijeraGanaJ2()
        {

        }

        [Test]
        public void J1PapelJ2PiedraGanaJ1()
        {

        }
        [Test]
        public void J1TijeraJ2PapelGanaJ1()
        {

        }
        [Test]
        public void J1TijeraJ2PiedraGanaJ2()
        {

        }

        //------
        [Test]
        public void J1PapelJ2TijeraGanaJ2()
        {

        }









        [Test]
        public void J1PapelJ2PiedraGanaJ2()
        {

        }

        [Test]
        public void J1TijeraJ2PapelGanaJ2()
        {

        }

        [Test]
        public void J1TijeraJ2TijeraGanaJ2()
        {

        }

        [Test]
        public void J1papelJ2TijeraGanaJ2()
        {

        }

        [Test]
        public void J1papelJ2TijeraGanaJ2()
        {

        }

        [Test]
        public void J1papelJ2TijeraGanaJ2()
        {

        }

    }
}