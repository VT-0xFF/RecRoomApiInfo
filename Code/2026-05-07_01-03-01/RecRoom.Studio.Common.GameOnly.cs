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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		private int? OWBUVSGQPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int? TNLWKVXUHRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int? VWOFDSANNKN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string SourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string TargetPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ShaderPropertyTranslatorType PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550")]
			get
			{
				return default(ShaderPropertyTranslatorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int SourcePropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA385780", Offset = "0xA384180", VA = "0x18A385780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int TargetPropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA385810", Offset = "0xA384210", VA = "0x18A385810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA385500", Offset = "0xA383F00", VA = "0x18A385500")]
		public void PUJCJFTPQGN(MaterialEntry a)
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
		[Cpp2IlInjected.Address(RVA = "0xD6A2A0", Offset = "0xD68CA0", VA = "0x180D6A2A0")]
		protected ShaderPropertyConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ShaderPropertyTerrainConverter : ShaderPropertyConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA3858A0", Offset = "0xA3842A0", VA = "0x18A3858A0", Slot = "4")]
		public override void OnAfterTranslation(ShaderPropertyTranslator translator, MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD6A2A0", Offset = "0xD68CA0", VA = "0x180D6A2A0")]
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
		private Shader HGBQWFESOPH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string SourceShaderName
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<ShaderPropertyAssignment> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA387200", Offset = "0xA385C00", VA = "0x18A387200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA386F40", Offset = "0xA385940", VA = "0x18A386F40")]
		private Shader PZXUXSLMEMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA386D10", Offset = "0xA385710", VA = "0x18A386D10")]
		public string PUOYBFERTVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA387130", Offset = "0xA385B30", VA = "0x18A387130")]
		public bool UOBLTNZSANS(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3865A0", Offset = "0xA384FA0", VA = "0x18A3865A0")]
		public void Apply(MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA386C70", Offset = "0xA385670", VA = "0x18A386C70")]
		private void BKEMHVLODGZ(Material a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ShaderPropertyTranslator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA386CC0", Offset = "0xA3856C0", VA = "0x18A386CC0")]
		[CompilerGenerated]
		private object IKOQUCKLCKC()
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
		[Cpp2IlInjected.Address(RVA = "0xD6A2A0", Offset = "0xD68CA0", VA = "0x180D6A2A0")]
		protected ShaderPropertyTranslatorCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShaderPropertyTranslatorConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FBYKUNLQLDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MaterialEntry ZCFTWIHASTG;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public FBYKUNLQLDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA385430", Offset = "0xA383E30", VA = "0x18A385430")]
			internal bool KHRADNVSDQN(ShaderPropertyTranslator a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class ZBRDALKAYGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MaterialEntry YRBXIMYWISE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ShaderPropertyTranslator KKCIORWABAG;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZBRDALKAYGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA3877C0", Offset = "0xA3861C0", VA = "0x18A3877C0")]
			internal object APXIWWOECRL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA387680", Offset = "0xA386080", VA = "0x18A387680")]
			internal object APSBZPUGTGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA387610", Offset = "0xA386010", VA = "0x18A387610")]
			internal object APMVCJAJJUT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA3874D0", Offset = "0xA385ED0", VA = "0x18A3874D0")]
			internal object APHOFCGMAJK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA387390", Offset = "0xA385D90", VA = "0x18A387390")]
			internal object APCHHVMOQYB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA387250", Offset = "0xA385C50", VA = "0x18A387250")]
			internal object AOXAKOSRHMS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ShaderPropertyTranslator[] translators;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<ShaderPropertyTranslator> PDQSYZWXHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA3861C0", Offset = "0xA384BC0", VA = "0x18A3861C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA386090", Offset = "0xA384A90", VA = "0x18A386090")]
		public bool TryGetTranslator(MaterialEntry sourceMaterial, [Out] ShaderPropertyTranslator translator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3858F0", Offset = "0xA3842F0", VA = "0x18A3858F0")]
		public bool TranslateMaterialEntry(MaterialEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD6A2A0", Offset = "0xD68CA0", VA = "0x180D6A2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA386210", Offset = "0xA384C10", VA = "0x18A386210", Slot = "4")]
		public override bool CanTranslate(MaterialEntry matEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD6A2A0", Offset = "0xD68CA0", VA = "0x180D6A2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA386430", Offset = "0xA384E30", VA = "0x18A386430")]
		public bool WBNHTYMLUND(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
