export default function Product({ params }) {
    const id = params.id;

    return (
        <div>
            <h1>Produto {id}</h1>
        </div>
    );
}
