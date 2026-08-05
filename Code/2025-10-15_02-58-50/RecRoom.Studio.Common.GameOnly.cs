using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ShaderPropertyAssignment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private string sourcePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private string targetPropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private ShaderPropertyTranslatorType propertyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private int? ZWIMTLGRNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int? VQVDIRMECCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int? BARQODGQUMK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string SourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string TargetPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ShaderPropertyTranslatorType PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
			get
			{
				return default(ShaderPropertyTranslatorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int SourcePropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0620", Offset = "0x8FAF420", VA = "0x188FB0620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int TargetPropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8FB06B0", Offset = "0x8FAF4B0", VA = "0x188FB06B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FB03A0", Offset = "0x8FAF1A0", VA = "0x188FB03A0")]
		public void EUGGHTBISUK(MaterialEntry a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class ShaderPropertyConverter : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OnAfterTranslation(ShaderPropertyTranslator translator, MaterialEntry matEntry);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		protected ShaderPropertyConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ShaderPropertyTerrainConverter : ShaderPropertyConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0740", Offset = "0x8FAF540", VA = "0x188FB0740", Slot = "4")]
		public override void OnAfterTranslation(ShaderPropertyTranslator translator, MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public ShaderPropertyTerrainConverter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ShaderPropertyTranslator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private string sourceShaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private bool lazyLoadTargetShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool shaderFindTargetShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Shader targetShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private string targetShaderResourcePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private ShaderPropertyTranslatorCondition condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private ShaderPropertyConverter converter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private ShaderPropertyAssignment[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Shader CQVIMPGXKNS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string SourceShaderName
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<ShaderPropertyAssignment> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8FB20B0", Offset = "0x8FB0EB0", VA = "0x188FB20B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1EC0", Offset = "0x8FB0CC0", VA = "0x188FB1EC0")]
		private Shader ZZFBOMONOXM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1B70", Offset = "0x8FB0970", VA = "0x188FB1B70")]
		public string KFJMJNOIJHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1DA0", Offset = "0x8FB0BA0", VA = "0x188FB1DA0")]
		public bool LMVLUVVBCWH(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1490", Offset = "0x8FB0290", VA = "0x188FB1490")]
		public void Apply(MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1440", Offset = "0x8FB0240", VA = "0x188FB1440")]
		private void ASLZMXKLRFG(Material a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ShaderPropertyTranslator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1E70", Offset = "0x8FB0C70", VA = "0x188FB1E70")]
		[CompilerGenerated]
		private object NXNALCHGCSH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class ShaderPropertyTranslatorCondition : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool CanTranslate(MaterialEntry matEntry);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		protected ShaderPropertyTranslatorCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShaderPropertyTranslatorConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class RYMNRJREOIY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MaterialEntry RWRWNJOAZGP;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public RYMNRJREOIY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8FB02D0", Offset = "0x8FAF0D0", VA = "0x188FB02D0")]
			internal bool RBZWFTFQIVQ(ShaderPropertyTranslator a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OPUURPABOAR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MaterialEntry QQCQHGIOZIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ShaderPropertyTranslator NYGYJXBTCVL;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OPUURPABOAR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0130", Offset = "0x8FAEF30", VA = "0x188FB0130")]
			internal object KRGPMJIOECO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0190", Offset = "0x8FAEF90", VA = "0x188FB0190")]
			internal object KRLWJQCLNNX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFF80", Offset = "0x8FAED80", VA = "0x188FAFF80")]
			internal object KQWBRVUTLFW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFFF0", Offset = "0x8FAEDF0", VA = "0x188FAFFF0")]
			internal object KRBIPCOQURF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFD00", Offset = "0x8FAEB00", VA = "0x188FAFD00")]
			internal object KQLNXIGYSJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFE40", Offset = "0x8FAEC40", VA = "0x188FAFE40")]
			internal object KQQUUPAWBUN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ShaderPropertyTranslator[] translators;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<ShaderPropertyTranslator> WLOBCMMGJAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8FB1060", Offset = "0x8FAFE60", VA = "0x188FB1060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F30", Offset = "0x8FAFD30", VA = "0x188FB0F30")]
		public bool TryGetTranslator(MaterialEntry sourceMaterial, [Out] ShaderPropertyTranslator translator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0790", Offset = "0x8FAF590", VA = "0x188FB0790")]
		public bool TranslateMaterialEntry(MaterialEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public ShaderPropertyTranslatorConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu(fileName = "ShaderPropertyTranslatorMultiPropertyCondition", menuName = "RecRoom/Studio/Shader Property Translator MultiCondition")]
	public class ShaderPropertyTranslatorMultiPropertyCondition : ShaderPropertyTranslatorCondition
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum EmissionRequirement
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			MustBeEmissive,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			MustBeNonEmissive
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		public EmissionRequirement emissionRequirement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		public ShaderPropertyTranslatorPropertyCondition[] conditions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8FB10B0", Offset = "0x8FAFEB0", VA = "0x188FB10B0", Slot = "4")]
		public override bool CanTranslate(MaterialEntry matEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public ShaderPropertyTranslatorMultiPropertyCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum ShaderPropertyComparisonType
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Equals,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		NotEquals,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		KeywordExists,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		KeywordDoesntExist
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ShaderPropertyTranslatorPropertyCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float propertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private ShaderPropertyComparisonType comparisonType;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8FB12D0", Offset = "0x8FB00D0", VA = "0x188FB12D0")]
		public bool LKEUTKBOCGG(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ShaderPropertyTranslatorPropertyCondition()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum ShaderPropertyTranslatorType
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Range,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Vector,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Texture
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
