// <auto-generated>
/*
 * merged spec
 *
 * merged spec
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using PowerOfficeGoV2.Client;

namespace PowerOfficeGoV2.Model
{
    /// <summary>
    /// Enum representing special income condition types.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey&lt;/i&gt; - Seafarers’ wages paid to crew members on fishing, small whaling and sealing vessels.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig&lt;/i&gt; - Pay and other remuneration not liable for tax.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet&lt;/i&gt; - Pay from the Norwegian State earned abroad.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennVedArbeidsmarkedstiltak&lt;/i&gt; - Pay from labour market schemes.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennVedKonkursEllerStatsgarantiOsv&lt;/i&gt; - Pay in the event of compulsory liquidation – State guarantee.&lt;/li&gt;&lt;li&gt;&lt;i&gt;SkattefriArbeidsinntektBarnUnderTrettenAar&lt;/i&gt; - Tax-free income from employment for children under the age of 13.&lt;/li&gt;&lt;li&gt;&lt;i&gt;UtenlandskeSjoefolkSomIkkeErSkattepliktig&lt;/i&gt; - Foreign seafarers who are not liable for tax.&lt;/li&gt;&lt;li&gt;&lt;i&gt;HavMineralFornybarKarbon&lt;/i&gt; - Special earning conditions related to Ocean, mineral, renewable, carbon.             This value will only be reported on the A02 from 2025 and onwards.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    /// <value>Enum representing special income condition types.&lt;p&gt;Members:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;i&gt;HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey&lt;/i&gt; - Seafarers’ wages paid to crew members on fishing, small whaling and sealing vessels.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig&lt;/i&gt; - Pay and other remuneration not liable for tax.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet&lt;/i&gt; - Pay from the Norwegian State earned abroad.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennVedArbeidsmarkedstiltak&lt;/i&gt; - Pay from labour market schemes.&lt;/li&gt;&lt;li&gt;&lt;i&gt;LoennVedKonkursEllerStatsgarantiOsv&lt;/i&gt; - Pay in the event of compulsory liquidation – State guarantee.&lt;/li&gt;&lt;li&gt;&lt;i&gt;SkattefriArbeidsinntektBarnUnderTrettenAar&lt;/i&gt; - Tax-free income from employment for children under the age of 13.&lt;/li&gt;&lt;li&gt;&lt;i&gt;UtenlandskeSjoefolkSomIkkeErSkattepliktig&lt;/i&gt; - Foreign seafarers who are not liable for tax.&lt;/li&gt;&lt;li&gt;&lt;i&gt;HavMineralFornybarKarbon&lt;/i&gt; - Special earning conditions related to Ocean, mineral, renewable, carbon.             This value will only be reported on the A02 from 2025 and onwards.&lt;/li&gt;&lt;/ul&gt;</value>
    public enum SpecialIncomeConditionType
    {
        /// <summary>
        /// Enum HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey for value: HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey
        /// </summary>
        HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey = 1,

        /// <summary>
        /// Enum LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig for value: LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig
        /// </summary>
        LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig = 2,

        /// <summary>
        /// Enum LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet for value: LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet
        /// </summary>
        LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet = 3,

        /// <summary>
        /// Enum LoennVedArbeidsmarkedstiltak for value: LoennVedArbeidsmarkedstiltak
        /// </summary>
        LoennVedArbeidsmarkedstiltak = 4,

        /// <summary>
        /// Enum LoennVedKonkursEllerStatsgarantiOsv for value: LoennVedKonkursEllerStatsgarantiOsv
        /// </summary>
        LoennVedKonkursEllerStatsgarantiOsv = 5,

        /// <summary>
        /// Enum SkattefriArbeidsinntektBarnUnderTrettenAar for value: SkattefriArbeidsinntektBarnUnderTrettenAar
        /// </summary>
        SkattefriArbeidsinntektBarnUnderTrettenAar = 6,

        /// <summary>
        /// Enum UtenlandskeSjoefolkSomIkkeErSkattepliktig for value: UtenlandskeSjoefolkSomIkkeErSkattepliktig
        /// </summary>
        UtenlandskeSjoefolkSomIkkeErSkattepliktig = 7,

        /// <summary>
        /// Enum HavMineralFornybarKarbon for value: HavMineralFornybarKarbon
        /// </summary>
        HavMineralFornybarKarbon = 8
    }

    /// <summary>
    /// Converts <see cref="SpecialIncomeConditionType"/> to and from the JSON value
    /// </summary>
    public static class SpecialIncomeConditionTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="SpecialIncomeConditionType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SpecialIncomeConditionType FromString(string value)
        {
            if (value.Equals("HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey"))
                return SpecialIncomeConditionType.HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey;

            if (value.Equals("LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig"))
                return SpecialIncomeConditionType.LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig;

            if (value.Equals("LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet"))
                return SpecialIncomeConditionType.LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet;

            if (value.Equals("LoennVedArbeidsmarkedstiltak"))
                return SpecialIncomeConditionType.LoennVedArbeidsmarkedstiltak;

            if (value.Equals("LoennVedKonkursEllerStatsgarantiOsv"))
                return SpecialIncomeConditionType.LoennVedKonkursEllerStatsgarantiOsv;

            if (value.Equals("SkattefriArbeidsinntektBarnUnderTrettenAar"))
                return SpecialIncomeConditionType.SkattefriArbeidsinntektBarnUnderTrettenAar;

            if (value.Equals("UtenlandskeSjoefolkSomIkkeErSkattepliktig"))
                return SpecialIncomeConditionType.UtenlandskeSjoefolkSomIkkeErSkattepliktig;

            if (value.Equals("HavMineralFornybarKarbon"))
                return SpecialIncomeConditionType.HavMineralFornybarKarbon;

            throw new NotImplementedException($"Could not convert value to type SpecialIncomeConditionType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="SpecialIncomeConditionType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SpecialIncomeConditionType? FromStringOrDefault(string value)
        {
            if (value.Equals("HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey"))
                return SpecialIncomeConditionType.HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey;

            if (value.Equals("LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig"))
                return SpecialIncomeConditionType.LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig;

            if (value.Equals("LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet"))
                return SpecialIncomeConditionType.LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet;

            if (value.Equals("LoennVedArbeidsmarkedstiltak"))
                return SpecialIncomeConditionType.LoennVedArbeidsmarkedstiltak;

            if (value.Equals("LoennVedKonkursEllerStatsgarantiOsv"))
                return SpecialIncomeConditionType.LoennVedKonkursEllerStatsgarantiOsv;

            if (value.Equals("SkattefriArbeidsinntektBarnUnderTrettenAar"))
                return SpecialIncomeConditionType.SkattefriArbeidsinntektBarnUnderTrettenAar;

            if (value.Equals("UtenlandskeSjoefolkSomIkkeErSkattepliktig"))
                return SpecialIncomeConditionType.UtenlandskeSjoefolkSomIkkeErSkattepliktig;

            if (value.Equals("HavMineralFornybarKarbon"))
                return SpecialIncomeConditionType.HavMineralFornybarKarbon;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SpecialIncomeConditionType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(SpecialIncomeConditionType value)
        {
            if (value == SpecialIncomeConditionType.HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey)
                return "HyreTilMannskapPaaFiskeSmaahvalfangstOgSelfangstfartoey";

            if (value == SpecialIncomeConditionType.LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig)
                return "LoennOgAnnenGodtgjoerelseSomIkkeErSkattepliktig";

            if (value == SpecialIncomeConditionType.LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet)
                return "LoennUtbetaltFraDenNorskeStatOpptjentIUtlandet";

            if (value == SpecialIncomeConditionType.LoennVedArbeidsmarkedstiltak)
                return "LoennVedArbeidsmarkedstiltak";

            if (value == SpecialIncomeConditionType.LoennVedKonkursEllerStatsgarantiOsv)
                return "LoennVedKonkursEllerStatsgarantiOsv";

            if (value == SpecialIncomeConditionType.SkattefriArbeidsinntektBarnUnderTrettenAar)
                return "SkattefriArbeidsinntektBarnUnderTrettenAar";

            if (value == SpecialIncomeConditionType.UtenlandskeSjoefolkSomIkkeErSkattepliktig)
                return "UtenlandskeSjoefolkSomIkkeErSkattepliktig";

            if (value == SpecialIncomeConditionType.HavMineralFornybarKarbon)
                return "HavMineralFornybarKarbon";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="SpecialIncomeConditionType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class SpecialIncomeConditionTypeJsonConverter : JsonConverter<SpecialIncomeConditionType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override SpecialIncomeConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            SpecialIncomeConditionType? result = rawValue == null
                ? null
                : SpecialIncomeConditionTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the SpecialIncomeConditionType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="specialIncomeConditionType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, SpecialIncomeConditionType specialIncomeConditionType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(specialIncomeConditionType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="SpecialIncomeConditionType"/>
    /// </summary>
    public class SpecialIncomeConditionTypeNullableJsonConverter : JsonConverter<SpecialIncomeConditionType?>
    {
        /// <summary>
        /// Returns a SpecialIncomeConditionType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override SpecialIncomeConditionType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            SpecialIncomeConditionType? result = rawValue == null
                ? null
                : SpecialIncomeConditionTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="specialIncomeConditionType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, SpecialIncomeConditionType? specialIncomeConditionType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(specialIncomeConditionType?.ToString() ?? "null");
        }
    }
}
