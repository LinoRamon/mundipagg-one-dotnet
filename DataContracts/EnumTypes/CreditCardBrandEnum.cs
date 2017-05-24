using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts.EnumTypes {

    /// <summary>
    /// Bandeiras de cartões
    /// </summary>
    [DataContract]
    public enum CreditCardBrandEnum {

        /// <summary>
        /// Visa
        /// </summary>
        [EnumMember]
        Visa = 1,

        /// <summary>
        /// MasterCard
        /// </summary>
        [EnumMember]
        Mastercard = 2,

        /// <summary>
        /// Hipercard
        /// </summary>
        [EnumMember]
        Hipercard = 3,

        /// <summary>
        /// Amex
        /// </summary>
        [EnumMember]
        Amex = 4,

        /// <summary>
        /// Diners
        /// </summary>
        [EnumMember]
        Diners = 5,

        /// <summary>
        /// Elo
        /// </summary>
        [EnumMember]
        Elo = 6,

        /// <summary>
        /// Aura
        /// </summary>
        [EnumMember]
        Aura = 7,

        /// <summary>
        /// Discover
        /// </summary>
        [EnumMember]
        Discover = 8,

        /// <summary>
        /// Casa Show
        /// </summary>
        [EnumMember]
        CasaShow = 9,

        /// <summary>
        /// Havan
        /// </summary>
        [EnumMember]
        Havan = 10,

        /// <summary>
        /// HugCard
        /// </summary>
        [EnumMember]
        HugCard = 11,

        /// <summary>
        /// AndarAki
        /// </summary>
        [EnumMember]
        AndarAki = 12,

        /// <summary>
        /// LearderCard
        /// </summary>
        [EnumMember]
        LeaderCard = 13,

        /// <summary>
        /// Submarino
        /// </summary>
        [EnumMember]
        Submarino = 14,

        /// <summary>
        /// SodexoAlimentacao
        /// </summary>
        [EnumMember]
        SodexoAlimentacao = 15,

        /// <summary>
        /// SodexoRefeicao
        /// </summary>
        [EnumMember]
        SodexoRefeicao = 16,

        /// <summary>
        /// SodexoPremium
        /// </summary>
        [EnumMember]
        SodexoPremium = 17,

        /// <summary>
        /// SodexoCombustivel
        /// </summary>
        [EnumMember]
        SodexoCombustivel = 18,

        /// <summary>
        /// SodexoCultura
        /// </summary>
        [EnumMember]
        SodexoCultura = 19,

        /// <summary>
        /// SodexoGift
        /// </summary>
        [EnumMember]
        SodexoGift = 20,

        /// <summary>
        /// JCB
        /// </summary>
        [EnumMember]
        JCB = 21,

        /// <summary>
        /// Credz
        /// </summary>
        [EnumMember]
        Credz = 22,

        /// <summary>
        /// Pernambucanas
        /// </summary>
        [EnumMember]
        Pernambucanas = 23,

        /// <summary>
        /// Paqueta
        /// </summary>
        [EnumMember]
        Paqueta = 24,

        /// <summary>
        /// Mais
        /// </summary>
        [EnumMember]
        Mais = 25,

        /// <summary>
        /// Sodexo
        /// </summary>
        [EnumMember]
        Sodexo = 26
    }
}