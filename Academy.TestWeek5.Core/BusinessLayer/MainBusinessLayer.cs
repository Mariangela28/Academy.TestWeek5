using Academy.TestWeek5.Core.Interfaces;
using Academy.TestWeek5.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.TestWeek5.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IPiattoRepository piattoRepository;
        private readonly IAccountRepository accRepository;

        public MainBusinessLayer(IPiattoRepository piattoRepo, IAccountRepository accRepository)
        {
            this.piattoRepository = piattoRepo;
            this.accRepository = accRepository;
        }
        public PiattoResult AddNewPiatto(Piatto newPiatto)
        {
            if (newPiatto == null)
            {
                throw new ArgumentNullException("Invalid item");
            }

            var result = piattoRepository.AddItem(newPiatto);

            if (result)
            {
                return new PiattoResult
                {
                    Success = true,
                    Message = "Ok"
                };
            }
            return new PiattoResult
            {
                Success = false,
                Message = $"Piatto {newPiatto.Nome} - {newPiatto.Descrizione} - {newPiatto.Tipologia} cannot be saved"
            };
        }

        public PiattoResult DeletePiatto(Piatto data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Invalid data");
            }
            var result = piattoRepository.Delete(data.Id);
            if (result)
            {
                return new PiattoResult
                {
                    Success = true,
                    Message = ""
                };
            }
            return new PiattoResult
            {
                Success = false,
                Message = "Cannot delete"
            };
        }

        public PiattoResult EditPiatto(Piatto data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Invalid info");
            }

            var result = piattoRepository.EditItem(data);
            if (result)
            {
                return new PiattoResult
                {
                    Success = true,
                    Message = ""
                };
            }

            return new PiattoResult
            {
                Success = false,
                Message = "Cannot to edit"
            };
        }

        public IEnumerable<Piatto> FetchPiatti()
        {
            return piattoRepository.FetchAll();
        }

        public Account GetAccount(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Invalid username");
            }
            return accRepository.GetByUsername(username);
        }

        public Piatto GetPiattoById(int id)
        {
            //Guardia
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return piattoRepository.GetById(id);
        }
    }
}
