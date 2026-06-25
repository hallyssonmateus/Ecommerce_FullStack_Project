import {Link} from 'react-router-dom';
import { FiSearch, FiHeart, FiShoppingBag } from 'react-icons/fi';

export default function Header(){
    return (
        <header className="sticky top-0 z-50 border-b border-zinc-100 bg-white/80 backdrop-blur-md">
            <div className="mx-auto flex max-w-7xl h-20 items-center justify-between px-4 sm:px-6 lg:px-8">
                {/* Links de navegação a esquerda */}
                <nav className="hidden md:flex space-x-8 text-sm font-light tracking-widest uppercase text-zinc-600">
                    <Link to="/" className="hover:text-zinc-900 text-sm font-light tracking-widest uppercase text-zinc-600">Início</Link>
                    <a href="#brincos" className="hover:text-zinc-950 transition-colors">Brincos</a>
                    <a href="#colares" className="hover:text-zinc-950 transition-colors">Colares</a>
                </nav>

                {/* Links de navegação a esquerda */}
                <div className="flex-1 text-center md:absolute md:left-1/2 md:-translate-x-1/2 md:flex md:flex-col">
                    <Link to="/" className="hover:text-zinc-900 text-sm font-light tracking-widest uppercase text-zinc-600">Aurelle</Link>
                    <a href="#bijou-maison" className="hover:text-zinc-900 text-xs font-light tracking-widest uppercase text-zinc-600">Bijou Maison</a>
                </div>

                {/* Links de navegação a direita */}
                <div className="flex items-center space-x-6 text-zinc-700">
                    <button className="hover:text-zinc-950 transition-colors aria-label='Buscar'">
                        <FiSearch size={20} strokeWidth={1.5} />
                    </button>
                    
                    <button className="relative hover:text-zinc-950 transition-colors aria-label='Favoritos'">
                        <FiHeart size={20} strokeWidth={1.5} />
                        {/* Indicador visual de favoritos (mock) */}
                        <span className="absolute -top-1 -right-1 h-2 w-2 rounded-full bg-amber-500"></span>
                    </button>

                    <button className="relative hover:text-zinc-950 transition-colors aria-label='Carrinho'">
                        <FiShoppingBag size={20} strokeWidth={1.5} />
                        {/* Contador do carrinho (mock inicial) */}
                        <span className="absolute -bottom-1 -right-1 flex h-4 w-4 items-center justify-center rounded-full bg-zinc-900 text-[10px] font-medium text-white">
                        0
                        </span>
                    </button>
                </div>

            </div>
        </header>
    )
}