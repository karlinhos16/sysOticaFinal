﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysOticaForm.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserirProduto", ReplyAction="http://tempuri.org/IService1/InserirProdutoResponse")]
        void InserirProduto(SysOtica.Negocio.Classes_Basicas.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserirProduto", ReplyAction="http://tempuri.org/IService1/InserirProdutoResponse")]
        System.Threading.Tasks.Task InserirProdutoAsync(SysOtica.Negocio.Classes_Basicas.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AlterarProduto", ReplyAction="http://tempuri.org/IService1/AlterarProdutoResponse")]
        void AlterarProduto(SysOtica.Negocio.Classes_Basicas.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AlterarProduto", ReplyAction="http://tempuri.org/IService1/AlterarProdutoResponse")]
        System.Threading.Tasks.Task AlterarProdutoAsync(SysOtica.Negocio.Classes_Basicas.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/excluirProduto", ReplyAction="http://tempuri.org/IService1/excluirProdutoResponse")]
        void excluirProduto(SysOtica.Negocio.Classes_Basicas.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/excluirProduto", ReplyAction="http://tempuri.org/IService1/excluirProdutoResponse")]
        System.Threading.Tasks.Task excluirProdutoAsync(SysOtica.Negocio.Classes_Basicas.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pesquisaProduto", ReplyAction="http://tempuri.org/IService1/pesquisaProdutoResponse")]
        SysOtica.Negocio.Classes_Basicas.Produto[] pesquisaProduto(string pr_descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pesquisaProduto", ReplyAction="http://tempuri.org/IService1/pesquisaProdutoResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Produto[]> pesquisaProdutoAsync(string pr_descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarProduto", ReplyAction="http://tempuri.org/IService1/listarProdutoResponse")]
        SysOtica.Negocio.Classes_Basicas.Produto[] listarProduto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarProduto", ReplyAction="http://tempuri.org/IService1/listarProdutoResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Produto[]> listarProdutoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserir", ReplyAction="http://tempuri.org/IService1/inserirResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void inserir(SysOtica.Negocio.Classes_Basicas.Venda v);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserir", ReplyAction="http://tempuri.org/IService1/inserirResponse")]
        System.Threading.Tasks.Task inserirAsync(SysOtica.Negocio.Classes_Basicas.Venda v);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarCliente", ReplyAction="http://tempuri.org/IService1/alterarClienteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void alterarCliente(SysOtica.Negocio.Classes_Basicas.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/alterarCliente", ReplyAction="http://tempuri.org/IService1/alterarClienteResponse")]
        System.Threading.Tasks.Task alterarClienteAsync(SysOtica.Negocio.Classes_Basicas.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirCliente", ReplyAction="http://tempuri.org/IService1/inserirClienteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void inserirCliente(SysOtica.Negocio.Classes_Basicas.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inserirCliente", ReplyAction="http://tempuri.org/IService1/inserirClienteResponse")]
        System.Threading.Tasks.Task inserirClienteAsync(SysOtica.Negocio.Classes_Basicas.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/excluirCliente", ReplyAction="http://tempuri.org/IService1/excluirClienteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void excluirCliente(SysOtica.Negocio.Classes_Basicas.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/excluirCliente", ReplyAction="http://tempuri.org/IService1/excluirClienteResponse")]
        System.Threading.Tasks.Task excluirClienteAsync(SysOtica.Negocio.Classes_Basicas.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pesquisarCliente", ReplyAction="http://tempuri.org/IService1/pesquisarClienteResponse")]
        SysOtica.Negocio.Classes_Basicas.Cliente[] pesquisarCliente(string cl_nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pesquisarCliente", ReplyAction="http://tempuri.org/IService1/pesquisarClienteResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Cliente[]> pesquisarClienteAsync(string cl_nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarCliente", ReplyAction="http://tempuri.org/IService1/listarClienteResponse")]
        SysOtica.Negocio.Classes_Basicas.Cliente[] listarCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/listarCliente", ReplyAction="http://tempuri.org/IService1/listarClienteResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Cliente[]> listarClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCliente", ReplyAction="http://tempuri.org/IService1/getClienteResponse")]
        SysOtica.Negocio.Classes_Basicas.Cliente[] getCliente(int cl_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCliente", ReplyAction="http://tempuri.org/IService1/getClienteResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Cliente[]> getClienteAsync(int cl_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserirReceita", ReplyAction="http://tempuri.org/IService1/InserirReceitaResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void InserirReceita(SysOtica.Negocio.Classes_Basicas.Receita receita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InserirReceita", ReplyAction="http://tempuri.org/IService1/InserirReceitaResponse")]
        System.Threading.Tasks.Task InserirReceitaAsync(SysOtica.Negocio.Classes_Basicas.Receita receita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AlterarReceita", ReplyAction="http://tempuri.org/IService1/AlterarReceitaResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void AlterarReceita(SysOtica.Negocio.Classes_Basicas.Receita receita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AlterarReceita", ReplyAction="http://tempuri.org/IService1/AlterarReceitaResponse")]
        System.Threading.Tasks.Task AlterarReceitaAsync(SysOtica.Negocio.Classes_Basicas.Receita receita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExcluirReceita", ReplyAction="http://tempuri.org/IService1/ExcluirReceitaResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Categoria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Fornecedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.ProdutoVenda))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Receita[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Produto[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SysOtica.Negocio.Classes_Basicas.Cliente[]))]
        void ExcluirReceita(SysOtica.Negocio.Classes_Basicas.Receita receita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExcluirReceita", ReplyAction="http://tempuri.org/IService1/ExcluirReceitaResponse")]
        System.Threading.Tasks.Task ExcluirReceitaAsync(SysOtica.Negocio.Classes_Basicas.Receita receita);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PuxaReceita", ReplyAction="http://tempuri.org/IService1/PuxaReceitaResponse")]
        SysOtica.Negocio.Classes_Basicas.Receita[] PuxaReceita(string cl_nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PuxaReceita", ReplyAction="http://tempuri.org/IService1/PuxaReceitaResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Receita[]> PuxaReceitaAsync(string cl_nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListaReceita", ReplyAction="http://tempuri.org/IService1/ListaReceitaResponse")]
        SysOtica.Negocio.Classes_Basicas.Receita[] ListaReceita();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListaReceita", ReplyAction="http://tempuri.org/IService1/ListaReceitaResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Receita[]> ListaReceitaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/vendaReceita", ReplyAction="http://tempuri.org/IService1/vendaReceitaResponse")]
        SysOtica.Negocio.Classes_Basicas.Receita[] vendaReceita();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/vendaReceita", ReplyAction="http://tempuri.org/IService1/vendaReceitaResponse")]
        System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Receita[]> vendaReceitaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SysOticaForm.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SysOticaForm.ServiceReference1.IService1>, SysOticaForm.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InserirProduto(SysOtica.Negocio.Classes_Basicas.Produto p) {
            base.Channel.InserirProduto(p);
        }
        
        public System.Threading.Tasks.Task InserirProdutoAsync(SysOtica.Negocio.Classes_Basicas.Produto p) {
            return base.Channel.InserirProdutoAsync(p);
        }
        
        public void AlterarProduto(SysOtica.Negocio.Classes_Basicas.Produto p) {
            base.Channel.AlterarProduto(p);
        }
        
        public System.Threading.Tasks.Task AlterarProdutoAsync(SysOtica.Negocio.Classes_Basicas.Produto p) {
            return base.Channel.AlterarProdutoAsync(p);
        }
        
        public void excluirProduto(SysOtica.Negocio.Classes_Basicas.Produto p) {
            base.Channel.excluirProduto(p);
        }
        
        public System.Threading.Tasks.Task excluirProdutoAsync(SysOtica.Negocio.Classes_Basicas.Produto p) {
            return base.Channel.excluirProdutoAsync(p);
        }
        
        public SysOtica.Negocio.Classes_Basicas.Produto[] pesquisaProduto(string pr_descricao) {
            return base.Channel.pesquisaProduto(pr_descricao);
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Produto[]> pesquisaProdutoAsync(string pr_descricao) {
            return base.Channel.pesquisaProdutoAsync(pr_descricao);
        }
        
        public SysOtica.Negocio.Classes_Basicas.Produto[] listarProduto() {
            return base.Channel.listarProduto();
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Produto[]> listarProdutoAsync() {
            return base.Channel.listarProdutoAsync();
        }
        
        public void inserir(SysOtica.Negocio.Classes_Basicas.Venda v) {
            base.Channel.inserir(v);
        }
        
        public System.Threading.Tasks.Task inserirAsync(SysOtica.Negocio.Classes_Basicas.Venda v) {
            return base.Channel.inserirAsync(v);
        }
        
        public void alterarCliente(SysOtica.Negocio.Classes_Basicas.Cliente c) {
            base.Channel.alterarCliente(c);
        }
        
        public System.Threading.Tasks.Task alterarClienteAsync(SysOtica.Negocio.Classes_Basicas.Cliente c) {
            return base.Channel.alterarClienteAsync(c);
        }
        
        public void inserirCliente(SysOtica.Negocio.Classes_Basicas.Cliente c) {
            base.Channel.inserirCliente(c);
        }
        
        public System.Threading.Tasks.Task inserirClienteAsync(SysOtica.Negocio.Classes_Basicas.Cliente c) {
            return base.Channel.inserirClienteAsync(c);
        }
        
        public void excluirCliente(SysOtica.Negocio.Classes_Basicas.Cliente c) {
            base.Channel.excluirCliente(c);
        }
        
        public System.Threading.Tasks.Task excluirClienteAsync(SysOtica.Negocio.Classes_Basicas.Cliente c) {
            return base.Channel.excluirClienteAsync(c);
        }
        
        public SysOtica.Negocio.Classes_Basicas.Cliente[] pesquisarCliente(string cl_nome) {
            return base.Channel.pesquisarCliente(cl_nome);
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Cliente[]> pesquisarClienteAsync(string cl_nome) {
            return base.Channel.pesquisarClienteAsync(cl_nome);
        }
        
        public SysOtica.Negocio.Classes_Basicas.Cliente[] listarCliente() {
            return base.Channel.listarCliente();
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Cliente[]> listarClienteAsync() {
            return base.Channel.listarClienteAsync();
        }
        
        public SysOtica.Negocio.Classes_Basicas.Cliente[] getCliente(int cl_id) {
            return base.Channel.getCliente(cl_id);
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Cliente[]> getClienteAsync(int cl_id) {
            return base.Channel.getClienteAsync(cl_id);
        }
        
        public void InserirReceita(SysOtica.Negocio.Classes_Basicas.Receita receita) {
            base.Channel.InserirReceita(receita);
        }
        
        public System.Threading.Tasks.Task InserirReceitaAsync(SysOtica.Negocio.Classes_Basicas.Receita receita) {
            return base.Channel.InserirReceitaAsync(receita);
        }
        
        public void AlterarReceita(SysOtica.Negocio.Classes_Basicas.Receita receita) {
            base.Channel.AlterarReceita(receita);
        }
        
        public System.Threading.Tasks.Task AlterarReceitaAsync(SysOtica.Negocio.Classes_Basicas.Receita receita) {
            return base.Channel.AlterarReceitaAsync(receita);
        }
        
        public void ExcluirReceita(SysOtica.Negocio.Classes_Basicas.Receita receita) {
            base.Channel.ExcluirReceita(receita);
        }
        
        public System.Threading.Tasks.Task ExcluirReceitaAsync(SysOtica.Negocio.Classes_Basicas.Receita receita) {
            return base.Channel.ExcluirReceitaAsync(receita);
        }
        
        public SysOtica.Negocio.Classes_Basicas.Receita[] PuxaReceita(string cl_nome) {
            return base.Channel.PuxaReceita(cl_nome);
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Receita[]> PuxaReceitaAsync(string cl_nome) {
            return base.Channel.PuxaReceitaAsync(cl_nome);
        }
        
        public SysOtica.Negocio.Classes_Basicas.Receita[] ListaReceita() {
            return base.Channel.ListaReceita();
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Receita[]> ListaReceitaAsync() {
            return base.Channel.ListaReceitaAsync();
        }
        
        public SysOtica.Negocio.Classes_Basicas.Receita[] vendaReceita() {
            return base.Channel.vendaReceita();
        }
        
        public System.Threading.Tasks.Task<SysOtica.Negocio.Classes_Basicas.Receita[]> vendaReceitaAsync() {
            return base.Channel.vendaReceitaAsync();
        }
    }
}
