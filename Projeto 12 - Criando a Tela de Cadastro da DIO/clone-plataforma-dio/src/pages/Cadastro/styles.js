import styled from "styled-components";

export const Container = styled.div`
    width: 100%;
    max-width: 80%;
    margin: 0 auto;
    margin-top: 120px;

    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-direction: row;
`;

export const Column = styled.div`
    flex: 1;
`;
export const Title = styled.h2`
    font-family: "Open Sans";
    font-style: normal;
    font-weight: 700;
    font-size: 32px;
    width: 320px;
    margin-bottom: 20px;
    line-height: 44px;

    color: #ffffff;
`;

export const Wrapper = styled.div`
    width: 350px;
`;

export const TitleLogin = styled.p`
    font-family: "Open Sans";
    font-style: normal;
    font-weight: 700;
    font-size: 32px;
    margin-bottom: 20px;
    line-height: 44px;
`;

export const SubtitleLogin = styled.p`
    font-family: "Open Sans";
    font-style: normal;
    font-weight: 400;
    font-size: 18px;
    margin: 20px 0;
    line-height: 25px;
`;

export const Row = styled.div`
    display: flex;
    align-items: flex-start;
    justify-content: left;
`

export const TextLogin = styled.p`
    font-family: "Open Sans";
    font-style: normal;
    font-weight: 700;
    font-size: 12px;
    line-height: 18px;
`;

export const TextLinkLogin = styled.a`
    font-family: "Open Sans";
    font-style: normal;
    font-weight: 700;
    font-size: 12px;
    line-height: 18px;
    margin-left: 5px;
    color: #30b060
`;