import {useParams} from "react-router-dom";

export default function ProductDetailPage() {
    const {id} = useParams<{id: string}>();

    return (
        <div>
            <h2 className="text-2xl font-light tracking-wide text-zinc-800">Detalhes do Produto</h2>
            <p className="text-zinc-500 mt-2">Exibindo o produto com ID: {id}</p>
        </div>
    )
}