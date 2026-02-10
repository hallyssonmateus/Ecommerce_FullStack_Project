# 🚀 E-commerce Website (FullStack)

Desenvolvimento de uma aplicação web completa e moderna ficticia de um e-commerce utilizando **React + Tailwind CSS** no frontend e **ASP.NET Core + SQL Server** no backend. Implementação de **autenticação JWT**, controle de usuários, carrinho de compras, checkout sem pagamento, painel administrativo, CRUD de produtos e pedidos, seguindo boas práticas de arquitetura e segurança.

---

## 🧱 Visão Geral do Projeto

O objetivo deste projeto é fornecer uma plataforma completa de **e-commerce**, permitindo o gerenciamento de produtos, usuários e pedidos, além de oferecer uma experiência de compra simples e responsiva.

O usuário pode:
- Criar conta, fazer login e gerenciar seu **perfil**
- Navegar, buscar e filtrar **produtos** por nome, categoria e preço
- Adicionar, remover e atualizar itens no **carrinho de compras**
- Finalizar pedidos através de um fluxo de **checkout** (sem integração de pagamento)
- Visualizar **histórico de pedidos** e detalhes de compras realizadas

O administrador pode:
- Criar, editar e excluir **produtos** e **categorias**
- Controlar **estoque** e status de produtos (ativo/inativo)
- Visualizar e gerenciar **pedidos**
- Atualizar o status dos pedidos conforme o andamento


---

## 🎨 Layout
Abaixo estão as tela das principais páginas da aplicação:
 

| **Página de ... -**  

## 🖥️ Tecnologias Utilizadas

| Camada | Tecnologia |
|--------|-------------|
| Framework Frontend | [React 18+](https://react.dev/) |
| Linguagem | [TypeScript](https://www.typescriptlang.org/) |
| Estilização | [Tailwind CSS](https://tailwindcss.com/) |
| Roteamento | [React Router](https://reactrouter.com/) |
| Gerenciamento de Estado | React Hooks / Context |
| Validação de Formulários | Validação customizada (com mensagens de sucesso/erro claras) |
| Framework Backend | .NET |
| Linguagem | C# |
| API | Padrão REST |
| Segurança | Autenticação JWT |

---

## 2️⃣ Funcionalidades essenciais do e-commerce (Checklist)

### 🔐 Autenticação e Usuários

- Cadastro de usuário  
- Login  
- Logout  
- Criptografia de senha (ex: BCrypt)  
- Autenticação com JWT  
- Controle de sessão  
- Perfil do usuário  
- Atualização de dados pessoais  

### 👥 Tipos de Usuário (muito importante)

- Usuário comum (cliente)  
- Administrador (admin)  

### 📦 Produtos

- Listagem de produtos  
- Página de detalhes do produto  
- Busca por nome  
- Filtro por categoria  
- Ordenação (preço, nome, mais recentes)  
- Controle de estoque  
- Status do produto (ativo/inativo)  

### 🗂️ Categorias

- CRUD de categorias (admin)  
- Associação produto ↔ categoria  

### 🛒 Carrinho de Compras

- Adicionar produto ao carrinho  
- Remover produto  
- Alterar quantidade  
- Carrinho persistente (localStorage ou banco)  
- Cálculo de subtotal  

### 📑 Checkout (sem pagamento)

- Resumo da compra  
- Endereço de entrega  
- Validação de dados  
- Confirmação do pedido  
- Geração de pedido no banco  
- Status do pedido (ex: Pendente, Confirmado)  

### 📄 Pedidos

- Histórico de pedidos do usuário  
- Detalhes do pedido  
- Status do pedido  
- Itens do pedido  

### 🛠️ Painel Administrativo (diferencial forte)

- Dashboard simples  
- CRUD de produtos  
- CRUD de categorias  
- Visualizar pedidos  
- Alterar status do pedido  
- Controle de estoque  


---

## 3️⃣ Arquitetura e boas práticas (para se destacar)

### 🔹 Backend (.NET / C#)

- ASP.NET Core Web API  

**Organização em camadas:**
- Controllers  
- Services  
- Repositories  

**Tecnologias e padrões:**
- Entity Framework Core  
- DTOs (Request / Response)  
- JWT + Authorization  
- Swagger documentado  
- Migrations  
- SQL Server bem modelado  

**📌 Entidades principais:**
- User  
- Product  
- Category  
- Order  
- OrderItem  
- Cart  


### 🔹 Frontend (React + Tailwind)

- Componentização  
- Hooks (useState, useEffect, useContext)  
- Context API ou Redux (opcional)  
- Consumo de API com Axios  
- Rotas protegidas  
- Layout responsivo  
- Estados de loading e erro 

---

## 🗂️ Clonar o repositorio
Clone o repositorio na pasta que preferir do seu computador com o seguinte comando no seu terminal:
```bash
git clone https://github.com/hallyssonmateus/Leads_Tasks_Project
cd Leads_Tasks_Project
```
### Após clonar
- Abra o projeto na sua IDE(caso for Visual Studio Code)
- Vá em terminal -> New Terminal
```bash
cd frontend
npm install
npm run dev
```