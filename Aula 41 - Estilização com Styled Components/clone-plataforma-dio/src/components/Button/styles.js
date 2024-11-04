import styled, { css } from "styled-components";

export const ButtonContainer = styled.button`
    background: #565665;
    border-radius: 22px;
    position: relative;
    border: 0;

    color: #ffffff;
    padding: 2px 12px;
    min-width: 120px;
    width: 100%;

    &:hover {
        opacity: 0.6;
        cursor: pointer;
    }

    // Recebe um parâmetro "variant", que define o tipo de estilização a ser usada.
    // Caso variant não seja "primary", usa a estilização definida abaixo.
    ${({ variant }) =>
        variant !== "primary" &&
        css`
            min-width: 167px;
            height: 33px;

            background: #e4105d;

            // Permite inserir conteúdo depois do conteúdo do botão.
            &::after {
                content: "";
                position: absolute;
                border: 1px solid #e4105d;
                top: -5px;
                left: -6px;
                width: calc(100% + 10px); // Realiza cálculos em CSS.
                height: calc(100% + 10px);
                border-radius: 22px;
            }
        `}
`;
