export interface Produto {
    id: number;
    codigo: string;
    nome: string;
    descricao?: string;
    dataInclusao: string; 
    unidadeDeMedida: string;
    precoVarejo: number;
    precoAtacado: number;
    codigoSituacaoTributaria: string;
    quantidadeAtacado: number;
    inativo: boolean;
    fornecedorId: number;
}
  