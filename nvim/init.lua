--test
------------------------------------------------------------
-- Leader
------------------------------------------------------------
vim.g.mapleader = ","
vim.g.maplocalleader = ","

------------------------------------------------------------
-- Clipboard  
------------------------------------------------------------
-- Using system clipboard
vim.opt.clipboard = "unnamedplus"

------------------------------------------------------------
-- Options
------------------------------------------------------------
vim.opt.scrolloff = 5
vim.opt.number = true
vim.opt.relativenumber = true
vim.opt.incsearch = true

------------------------------------------------------------
-- Bootstrap lazy.nvim
------------------------------------------------------------
local lazypath = vim.fn.stdpath("data") .. "/lazy/lazy.nvim"
if not vim.loop.fs_stat(lazypath) then
  vim.fn.system({
    "git", "clone", "--filter=blob:none",
    "https://github.com/folke/lazy.nvim.git",
    "--branch=stable",
    lazypath
  })
end
vim.opt.rtp:prepend(lazypath)

------------------------------------------------------------
-- Plugins
------------------------------------------------------------
require("lazy").setup({
  -- Matches vim-highlightedyank
  { "machakann/vim-highlightedyank" },

  -- Matches tpope/vim-commentary
  { "tpope/vim-commentary" },

  -- Needed to replace <Action>(GotoFile/RecentFiles/SearchEverywhere/etc.)
  { "nvim-lua/plenary.nvim" },
  {
    "nvim-telescope/telescope.nvim",
    dependencies = { "nvim-lua/plenary.nvim" },
    config = function()
      require("telescope").setup({})
    end,
  },

  -- File tree like "ActivateProjectToolWindow" vibe
  {
    "nvim-tree/nvim-tree.lua",
    dependencies = { "nvim-tree/nvim-web-devicons" },
    config = function()
      require("nvim-tree").setup({})
    end,
  },

  -- LSP actions: rename, references, go-to-definition, formatting
  { "neovim/nvim-lspconfig" },

  -- { "stevearc/conform.nvim", opts = {} },
  {
	  "kawre/leetcode.nvim",
	  dependencies = {
	    "nvim-lua/plenary.nvim",
	    "MunifTanjim/nui.nvim",
	    "nvim-telescope/telescope.nvim",
	  },
	  opts = {
	    lang = "python3",
	    plugins = { non_standalone = true },
	  },
  },
	{
	  "williamboman/mason.nvim",
	  config = function()
	    require("mason").setup()
	  end,
	},
	{
	  "williamboman/mason-lspconfig.nvim",
	  dependencies = { "williamboman/mason.nvim" },
	  config = function()
	    require("mason-lspconfig").setup({
	      ensure_installed = {
		"lua_ls",
		"pyright",
	      },
	    })
	  end,
	},
	{ "neovim/nvim-lspconfig" },
})

------------------------------------------------------------
-- Mappings
------------------------------------------------------------
local opts = { noremap = true, silent = true }

local function map(mode, lhs, rhs, o)
  vim.keymap.set(mode, lhs, rhs, o or opts)
end

local function lsp_format()
  if vim.lsp.buf.format then
    vim.lsp.buf.format({ async = true })
  else
    vim.lsp.buf.formatting()
  end
end

map("n", "<leader>a", "<cmd>Telescope builtin<cr>")
map("n", "<leader>b", "<cmd>Telescope buffers<cr>")
map("n", "<leader>s", "<cmd>Telescope lsp_document_symbols<cr>")
map("n", "<leader>f", "<cmd>Telescope lsp_references<cr>")
map("n", "<leader>d", vim.lsp.buf.definition)
map("n", "<leader>R", vim.lsp.buf.rename)
map("n", "<leader>=", lsp_format)
map("n", "<leader>e", "<cmd>NvimTreeToggle<cr>")

-- Tabs
map("n", "<leader>p", "gt")
map("n", "<leader>n", "gT")

-- Write / close
map("n", "<leader>w", "<cmd>wa<cr>")
map("n", "<leader>q", "<cmd>close<cr>")

map("n", "<leader>j", "<C-d>")
map("n", "<leader>k", "<C-u>")
map("n", "<leader>h", "<C-w>h")
map("n", "<leader>l", "<C-w>l")
map("n", "<leader>sv", "<cmd>vsplit<cr>")

map("i", "jj", "<Esc>")
map("n", "<leader>a", "<cmd>Telescope builtin<cr>")
map("n", "<leader>b", "<cmd>Telescope buffers<cr>")
map("n", "<leader>s", "<cmd>Telescope lsp_document_symbols<cr>")
map("n", "<leader>f", "<cmd>Telescope lsp_references<cr>")
map("n", "<leader>d", vim.lsp.buf.definition)
map("n", "<leader>R", vim.lsp.buf.rename)
map("n", "<leader>=", lsp_format)
map("n", "<leader>e", "<cmd>NvimTreeToggle<cr>")
map("n", "<leader>p", "gt")
map("n", "<leader>n", "gT")
map("n", "<leader>w", "<cmd>wa<cr>")
map("n", "<leader>q", "<cmd>close<cr>")
map("n", "<leader>j", "<C-d>")
map("n", "<leader>k", "<C-u>")
map("n", "<leader>h", "<C-w>h")
map("n", "<leader>l", "<C-w>l")
map("n", "<leader>sv", "<cmd>vsplit<cr>")
map("i", "jj", "<Esc>")

