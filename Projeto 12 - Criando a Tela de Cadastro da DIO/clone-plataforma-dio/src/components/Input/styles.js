import styled from "styled-components";

export const InputContainer = styled.div`
    width: 100%;
    max-width: 275px;
    height: 30px;
    border-bottom: 1px solid #3b3450;

    display: flex;
    align-items: center;
    margin-bottom: 10px;
`;

export const IconContainer = styled.div`
    margin-right: 10px;
`

export const InputText = styled.input`
    background-color: transparent;
    width: 100%;
    color: #ffffff;
    border: 0;
    height: 30px;
`

export const ErrorText = styled.p`
    font-family: "Open Sans";
    font-style: normal;
    font-size: 12px;
    margin: 5px 0 10px 0;

    color: #ff0000;
`;