﻿using EasyManage.Models;

namespace EasyManage.Services;

public interface IClientService
{
    void AddClient(Client client);
    List<Client> GetAllClients();
    Client GetClientById(string id);
    void ClientUpdate(string cpf, Client clientUpdate);
    void DeleteClientById(string cpf);
}