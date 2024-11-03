import React from "react";
import { ItemContainer } from "./styles";

const ItemRepo = () => {
    return (
        <ItemContainer>
            <h3>Teste</h3>
            <p>Teste 2</p>
            <section className="links">
                <a href="#">Ver Repositório.</a>
                <a href="#" className="remover">Remover</a>
            </section>
            <hr />
        </ItemContainer>
    );
};

export default ItemRepo;
