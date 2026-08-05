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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		private int? CNIKRMLQGWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int? RAKFSUXVQJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int? NWQPNEIXPJJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string SourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string TargetPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ShaderPropertyTranslatorType PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(ShaderPropertyTranslatorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int SourcePropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE980", Offset = "0xA4FD980", VA = "0x18A4FE980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int TargetPropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA4FEA10", Offset = "0xA4FDA10", VA = "0x18A4FEA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4FE700", Offset = "0xA4FD700", VA = "0x18A4FE700")]
		public void GZQTNIVCVLF(MaterialEntry a)
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
		[Cpp2IlInjected.Address(RVA = "0xD8EE00", Offset = "0xD8DE00", VA = "0x180D8EE00")]
		protected ShaderPropertyConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ShaderPropertyTerrainConverter : ShaderPropertyConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEAA0", Offset = "0xA4FDAA0", VA = "0x18A4FEAA0", Slot = "4")]
		public override void OnAfterTranslation(ShaderPropertyTranslator translator, MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD8EE00", Offset = "0xD8DE00", VA = "0x180D8EE00")]
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
		private Shader JZWCZSNPLRV;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string SourceShaderName
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<ShaderPropertyAssignment> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA500400", Offset = "0xA4FF400", VA = "0x18A500400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFE70", Offset = "0xA4FEE70", VA = "0x18A4FFE70")]
		private Shader CBVPWSMZRHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA500180", Offset = "0xA4FF180", VA = "0x18A500180")]
		public string SRBMKDNOOBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA500060", Offset = "0xA4FF060", VA = "0x18A500060")]
		public bool FJCMQBSKJVE(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF7A0", Offset = "0xA4FE7A0", VA = "0x18A4FF7A0")]
		public void Apply(MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA500130", Offset = "0xA4FF130", VA = "0x18A500130")]
		private void PTHWTHJDLBN(Material a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ShaderPropertyTranslator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5003B0", Offset = "0xA4FF3B0", VA = "0x18A5003B0")]
		[CompilerGenerated]
		private object VAAQWVMOMKA()
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
		[Cpp2IlInjected.Address(RVA = "0xD8EE00", Offset = "0xD8DE00", VA = "0x180D8EE00")]
		protected ShaderPropertyTranslatorCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShaderPropertyTranslatorConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MaterialEntry YRTNNMKZDSS;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE630", Offset = "0xA4FD630", VA = "0x18A4FE630")]
			internal bool FHHEYSDTJLF(ShaderPropertyTranslator a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MaterialEntry EGTSFQKCMLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ShaderPropertyTranslator YIGYQKYIUBO;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE420", Offset = "0xA4FD420", VA = "0x18A4FE420")]
			internal object AUHBNNKCIHZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE2E0", Offset = "0xA4FD2E0", VA = "0x18A4FE2E0")]
			internal object AUBUQGQEYWQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE5C0", Offset = "0xA4FD5C0", VA = "0x18A4FE5C0")]
			internal object AURPIAXXBER()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE480", Offset = "0xA4FD480", VA = "0x18A4FE480")]
			internal object AUMIKUDZRTI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE1A0", Offset = "0xA4FD1A0", VA = "0x18A4FE1A0")]
			internal object ATLZYMIMWOP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA4FE060", Offset = "0xA4FD060", VA = "0x18A4FE060")]
			internal object ATGTBFOPNDG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ShaderPropertyTranslator[] translators;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<ShaderPropertyTranslator> CXUMXZPKXVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA4FF3C0", Offset = "0xA4FE3C0", VA = "0x18A4FF3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF290", Offset = "0xA4FE290", VA = "0x18A4FF290")]
		public bool TryGetTranslator(MaterialEntry sourceMaterial, [Out] ShaderPropertyTranslator translator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEAF0", Offset = "0xA4FDAF0", VA = "0x18A4FEAF0")]
		public bool TranslateMaterialEntry(MaterialEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD8EE00", Offset = "0xD8DE00", VA = "0x180D8EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4FF410", Offset = "0xA4FE410", VA = "0x18A4FF410", Slot = "4")]
		public override bool CanTranslate(MaterialEntry matEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD8EE00", Offset = "0xD8DE00", VA = "0x180D8EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4FF630", Offset = "0xA4FE630", VA = "0x18A4FF630")]
		public bool CFCMENMBVUL(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
