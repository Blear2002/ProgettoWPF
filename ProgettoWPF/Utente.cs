using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoWPF.Classi
{
    class Utente
    {
        private string _username, _password, _nomeCompleto, _nome, _cognome;

        public string UserName
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        public string NomeCompleto
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                this._cognome = value;
            }
        }

        public Utente(string nome, string cognome, string username, string password)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.UserName = username;
            this.Password = password;
        }

    }
}
