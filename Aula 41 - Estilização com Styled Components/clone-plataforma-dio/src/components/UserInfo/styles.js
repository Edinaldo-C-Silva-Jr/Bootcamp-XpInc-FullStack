import styled from "styled-components";

export const Container = styled.div`
    display: flex;
    flex-direction: row;
    margin-bottom: 24px;
`;

export const UserPicture = styled.img`
    width: 32px;
    height: 32px;
    border-radius: 22px;
    border: 3px solid #ffffff;
    margin-right: 12px;
`;

export const NameText = styled.div`
    font-family: "Open Sans";
    font-style: normal;
    font-weight: 700;
    font-size: 18px;
    line-height: 25px;
    color: #ffffff;
`;

// Barra de progresso: Uma barra branca com uma outra barra verde por cima.
export const Progress = styled.div`
    // Define a barra branca.
    width: 100%;
    height: 6px;
    background-color: #ffffff;
    border-radius: 3px;
    position: relative;

    // Define a barra verde, que ficará por cima dela para mostrar o progresso.
    &::after {
        content: "";
        position: absolute;
        top: 0;
        left: 0%;
        width: ${({ percentual }) =>
            percentual}%; // Parâmetro de porcentagem recebido para exibição.
        height: 6px;
        border-radius: 3px;
        background-color: #23dd7a;
    }
`;
