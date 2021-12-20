using desafio2.Usuários;
using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> essesUsuarios = new List<Usuario>();
            {
                int i = 0;
                int j = 0;
                int k = 1;
                while (true)
                {
                    i++;

                    Usuario _usuario = new Usuario();
                    Console.Write("Informe o modelo do " + i + " veiculo do " + i + " usuario: ");
                    _usuario.Modelo = Convert.ToString(Console.ReadLine());
                    if (_usuario.Modelo == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe a versão do " + i + " veículo do " + i + " usuario: ");
                    _usuario.Versão = Convert.ToString(Console.ReadLine());
                    if (_usuario.Versão == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe o ano-modelo do " + i + " veículo do " + i + " usuario: ");
                    _usuario.AnoModelo = Convert.ToString(Console.ReadLine());
                    if (_usuario.AnoModelo == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe a cor do " + i + " veículo do " + i + " usuario: ");
                    _usuario.Cor = Convert.ToString(Console.ReadLine());
                    if (_usuario.Cor == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe a combustível do " + i + " veículo do " + i + " usuario: ");
                    _usuario.Combustivel = Convert.ToString(Console.ReadLine());
                    if (_usuario.Combustivel == string.Empty)
                    {
                        break;
                    }
                    
                        essesUsuarios.Add(_usuario);
                }


                foreach (Usuario _u in essesUsuarios.OrderBy(n => n.Modelo))
                {
                    Console.WriteLine(_u.Modelo);
                    Console.WriteLine(_u.Versão);
                    Console.WriteLine(_u.AnoModelo);
                    Console.WriteLine(_u.Cor);
                    Console.WriteLine(_u.Combustivel);
                }
                while (true)
                {
                    j++;
                    k++;

                    Usuario _usuario = new Usuario();
                    Console.Write("Informe o modelo do " + j + " veiculo do " + k + " usuario: ");
                    _usuario.Modelo = Convert.ToString(Console.ReadLine());
                    if (_usuario.Modelo == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe a versão do " + j + " veículo do " + k + " usuario: ");
                    _usuario.Versão = Convert.ToString(Console.ReadLine());
                    if (_usuario.Versão == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe o ano-modelo do " + j + " veículo do " + k + " usuario: ");
                    _usuario.AnoModelo = Convert.ToString(Console.ReadLine());
                    if (_usuario.AnoModelo == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe a cor do " + j + " veículo do " + k + " usuario: ");
                    _usuario.Cor = Convert.ToString(Console.ReadLine());
                    if (_usuario.Cor == string.Empty)
                    {
                        break;
                    }
                    Console.Write("Informe a combustível do " + j + " veículo do " + k + " usuario: ");
                    _usuario.Combustivel = Convert.ToString(Console.ReadLine());
                    if (_usuario.Combustivel == string.Empty)
                    {
                        break;
                    }

                    essesUsuarios.Add(_usuario);
                }


                foreach (Usuario _p in essesUsuarios.OrderBy(n => n.Modelo))
                {
                    Console.WriteLine(_p.Modelo);
                    Console.WriteLine(_p.Versão);
                    Console.WriteLine(_p.AnoModelo);
                    Console.WriteLine(_p.Cor);
                    Console.WriteLine(_p.Combustivel);
                }
                    Console.ReadKey();

            }

        }

    }
}