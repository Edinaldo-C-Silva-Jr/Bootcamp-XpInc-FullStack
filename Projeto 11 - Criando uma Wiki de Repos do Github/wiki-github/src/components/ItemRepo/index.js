import React from "react";
import { ItemContainer } from "./styles";

const ItemRepo = ({repo, handleRemoveRepo}) => {
    const handleRemove = () => {
        handleRemoveRepo(repo.id);
    }

    return (
        <ItemContainer>
            <h3>{repo.name}</h3>
            <p>{repo.full_name}</p>
            <section className="links">
                <a href={repo.html_url} target="blank">Ver Repositório.</a>
                <button onClick={handleRemove} className="remover">Remover</button>
            </section>
            <hr />
        </ItemContainer>
    );
};

export default ItemRepo;
