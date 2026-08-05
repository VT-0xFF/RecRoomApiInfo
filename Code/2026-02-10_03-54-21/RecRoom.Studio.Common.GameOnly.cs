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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		private int? EUZYXHDBUIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int? QBGGWPQMIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int? FDSNYHSMAQV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string SourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string TargetPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ShaderPropertyTranslatorType PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520")]
			get
			{
				return default(ShaderPropertyTranslatorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int SourcePropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A770", Offset = "0x8F59970", VA = "0x188F5A770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int TargetPropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A800", Offset = "0x8F59A00", VA = "0x188F5A800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A4F0", Offset = "0x8F596F0", VA = "0x188F5A4F0")]
		public void HEDFAXFXGIZ(MaterialEntry a)
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
		[Cpp2IlInjected.Address(RVA = "0xB2F4B0", Offset = "0xB2E6B0", VA = "0x180B2F4B0")]
		protected ShaderPropertyConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ShaderPropertyTerrainConverter : ShaderPropertyConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A890", Offset = "0x8F59A90", VA = "0x188F5A890", Slot = "4")]
		public override void OnAfterTranslation(ShaderPropertyTranslator translator, MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB2F4B0", Offset = "0xB2E6B0", VA = "0x180B2F4B0")]
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
		private Shader EARFELUEABT;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string SourceShaderName
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<ShaderPropertyAssignment> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8F5C1E0", Offset = "0x8F5B3E0", VA = "0x188F5C1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BFF0", Offset = "0x8F5B1F0", VA = "0x188F5BFF0")]
		private Shader ZHZVSMPFRRD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BC50", Offset = "0x8F5AE50", VA = "0x188F5BC50")]
		public string EFXZSHEMZQD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BED0", Offset = "0x8F5B0D0", VA = "0x188F5BED0")]
		public bool QMMFGPUBSRS(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F5B580", Offset = "0x8F5A780", VA = "0x188F5B580")]
		public void Apply(MaterialEntry matEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BFA0", Offset = "0x8F5B1A0", VA = "0x188F5BFA0")]
		private void VDDXMZVRERX(Material a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ShaderPropertyTranslator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BE80", Offset = "0x8F5B080", VA = "0x188F5BE80")]
		[CompilerGenerated]
		private object GFKIYQFYCAW()
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
		[Cpp2IlInjected.Address(RVA = "0xB2F4B0", Offset = "0xB2E6B0", VA = "0x180B2F4B0")]
		protected ShaderPropertyTranslatorCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShaderPropertyTranslatorConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DVLSPHLOUXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MaterialEntry AGJBAIFECJS;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public DVLSPHLOUXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8F59E50", Offset = "0x8F59050", VA = "0x188F59E50")]
			internal bool ZJBRPRBUPUN(ShaderPropertyTranslator a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PLYECEGTBAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MaterialEntry NKXCLLMTAVG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ShaderPropertyTranslator XSDQIRFXCUK;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PLYECEGTBAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A490", Offset = "0x8F59690", VA = "0x188F5A490")]
			internal object YUVSEZZUDBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A350", Offset = "0x8F59550", VA = "0x188F5A350")]
			internal object YUQLHTFWTQG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A2E0", Offset = "0x8F594E0", VA = "0x188F5A2E0")]
			internal object YULEKMLZKEX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A1A0", Offset = "0x8F593A0", VA = "0x188F5A1A0")]
			internal object YUFXNFSCATO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8F5A060", Offset = "0x8F59260", VA = "0x188F5A060")]
			internal object YUAQPYYERIF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8F59F20", Offset = "0x8F59120", VA = "0x188F59F20")]
			internal object YTVJSSEHHWW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ShaderPropertyTranslator[] translators;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<ShaderPropertyTranslator> JPCCMDKAHWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8F5B1A0", Offset = "0x8F5A3A0", VA = "0x188F5B1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F5B070", Offset = "0x8F5A270", VA = "0x188F5B070")]
		public bool TryGetTranslator(MaterialEntry sourceMaterial, [Out] ShaderPropertyTranslator translator)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A8E0", Offset = "0x8F59AE0", VA = "0x188F5A8E0")]
		public bool TranslateMaterialEntry(MaterialEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB2F4B0", Offset = "0xB2E6B0", VA = "0x180B2F4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F5B1F0", Offset = "0x8F5A3F0", VA = "0x188F5B1F0", Slot = "4")]
		public override bool CanTranslate(MaterialEntry matEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB2F4B0", Offset = "0xB2E6B0", VA = "0x180B2F4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F5B410", Offset = "0x8F5A610", VA = "0x188F5B410")]
		public bool HPVLTZPCRTT(MaterialEntry a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
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
