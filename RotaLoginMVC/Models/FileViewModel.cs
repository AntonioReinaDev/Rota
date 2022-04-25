﻿using System;

namespace RotaLoginMVC.Models
{
    public class FileViewModel
    {
        public DateTime? Data { get; set; }

        public string? Status { get; set; }

        public string? Auditado { get; set; }

        public string? CopReverteu { get; set; }

        public string? Log { get; set; }

        public string? Pdf { get; set; }

        public string? Foto { get; set; }

        public string? Contrato { get; set; }

        public string? Wo { get; set; }

        public string? Os { get; set; }

        public string? Assinante { get; set; }

        public string? Tecnicos { get; set; }

        public string? Login { get; set; }

        public string? Matricula { get; set; }

        public string? Cop { get; set; }

        public string? UltimoAlterar { get; set; }

        public string? Local { get; set; }

        public string? PontoCasaApt { get; set; }

        public string? Cidade { get; set; }

        public string? Base { get; set; }

        public DateTime? Horario { get; set; }

        public string? Segmento { get; set; }

        public string? Servico { get; set; }

        public string? TipoDeServico { get; set; }

        public string? TipoOs { get; set; }

        public string? GrupoDeServico { get; set; }

        public string? Endereco { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Cep { get; set; }

        public string? Node { get; set; }

        public string? Bairro { get; set; }

        public string? Pacote { get; set; }

        public string? Cod { get; set; }

        public string? Telefone1 { get; set; }

        public string? Telefone2 { get; set; }

        public string? Obs { get; set; }

        public string? ObsTecnico { get; set; }

        public string? Equipamento { get; set; }

        public FileViewModel() { }

        public FileViewModel(
           DateTime? data,
           string? status,
           string? auditado,
           string? copReverteu,
           string? log,
           string? pdf,
           string? foto,
           string? contrato,
           string? wo,
           string? os,
           string? assinante,
           string? tecnicos,
           string? login,
           string? matricula,
           string? cop,
           string? ultimoAlterar,
           string? local,
           string? pontoCasaApt,
           string? cidade,
           string? @base,
           DateTime? horario,
           string? segmento,
           string? servico,
           string? tipoDeServico,
           string? tipoOs,
           string? grupoDeServico,
           string? endereco,
           string? numero,
           string? complemento,
           string? cep,
           string? node,
           string? bairro,
           string? pacote,
           string? cod,
           string? telefone1,
           string? telefone2,
           string? obs,
           string? obsTecnico,
           string? equipamento)
        {
            Data = data;
            Status = status;
            Auditado = auditado;
            CopReverteu = copReverteu;
            Log = log;
            Pdf = pdf;
            Foto = foto;
            Contrato = contrato;
            Wo = wo;
            Os = os;
            Assinante = assinante;
            Tecnicos = tecnicos;
            Login = login;
            Matricula = matricula;
            Cop = cop;
            UltimoAlterar = ultimoAlterar;
            Local = local;
            PontoCasaApt = pontoCasaApt;
            Cidade = cidade;
            Base = @base;
            Horario = horario;
            Segmento = segmento;
            Servico = servico;
            TipoDeServico = tipoDeServico;
            TipoOs = tipoOs;
            GrupoDeServico = grupoDeServico;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Node = node;
            Bairro = bairro;
            Pacote = pacote;
            Cod = cod;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Obs = obs;
            ObsTecnico = obsTecnico;
            Equipamento = equipamento;
        }
    }
}