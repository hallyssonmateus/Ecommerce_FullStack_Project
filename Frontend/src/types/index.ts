export interface Category {
    id: number;
    name: string;
    description: string;
    createdAt: string;
    products: Product[];
}

export interface Product {
    id: number;
    name: string;
    description: string;
    price: number;
    stockQuantity: number;
    isActive: boolean;
    createdAt: string;
    categoryId: number;
    category: Category | null;
}