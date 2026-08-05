using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ShaderPropertyAssignment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private string sourcePropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private string targetPropertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private ShaderPropertyTranslatorType propertyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int? sourcePropertyID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private int? targetPropertyID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int? targetPropertyTextureScaleOffsetID;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string SourcePropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string TargetPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ShaderPropertyTranslatorType PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0")]
			get
			{
				return default(ShaderPropertyTranslatorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int SourcePropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x77B3FE0", Offset = "0x77B29E0", VA = "0x1877B3FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int TargetPropertyID
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77B4070", Offset = "0x77B2A70", VA = "0x1877B4070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77B3D50", Offset = "0x77B2750", VA = "0x1877B3D50")]
		public void PPGBCLNENBF(MaterialEntry DONMCNNPIBL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class ShaderPropertyConverter : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DGGNNKGNBHK(ShaderPropertyTranslator DCBAEHGDIPG, MaterialEntry DONMCNNPIBL);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
		protected ShaderPropertyConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class ShaderPropertyTerrainConverter : ShaderPropertyConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77B4100", Offset = "0x77B2B00", VA = "0x1877B4100", Slot = "4")]
		public override void DGGNNKGNBHK(ShaderPropertyTranslator DCBAEHGDIPG, MaterialEntry DONMCNNPIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
		public ShaderPropertyTerrainConverter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ShaderPropertyTranslator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private string sourceShaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool lazyLoadTargetShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Shader targetShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private string targetShaderResourcePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private ShaderPropertyTranslatorCondition condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private ShaderPropertyConverter converter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private ShaderPropertyAssignment[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Shader effectiveTargetShader;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string SourceShaderName
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<ShaderPropertyAssignment> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x77B5A90", Offset = "0x77B4490", VA = "0x1877B5A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77B5790", Offset = "0x77B4190", VA = "0x1877B5790")]
		private Shader HNEEMJOKENC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77B53F0", Offset = "0x77B3DF0", VA = "0x1877B53F0")]
		public string GMPFACHCDDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77B5970", Offset = "0x77B4370", VA = "0x1877B5970")]
		public bool IAFOIFJMJHJ(MaterialEntry DONMCNNPIBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77B4D00", Offset = "0x77B3700", VA = "0x1877B4D00")]
		public void BEJPPMOKIFB(MaterialEntry DONMCNNPIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77B5A40", Offset = "0x77B4440", VA = "0x1877B5A40")]
		private void ONCELMJNMGC(Material FLBCMGELMBF, string LCGGOKBFOOF, string JKKOEFMEAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ShaderPropertyTranslator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77B53A0", Offset = "0x77B3DA0", VA = "0x1877B53A0")]
		[CompilerGenerated]
		private object DOFLMIPBCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class ShaderPropertyTranslatorCondition : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool IAFOIFJMJHJ(MaterialEntry DONMCNNPIBL);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
		protected ShaderPropertyTranslatorCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ShaderPropertyTranslatorConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FGJOCEHEDJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public MaterialEntry sourceMaterial;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public FGJOCEHEDJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x77B34B0", Offset = "0x77B1EB0", VA = "0x1877B34B0")]
			internal bool MBNCAPKGALD(ShaderPropertyTranslator t)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class OJPGEBEKKGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MaterialEntry entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ShaderPropertyTranslator translator;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public OJPGEBEKKGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x77B3CF0", Offset = "0x77B26F0", VA = "0x1877B3CF0")]
			internal object PMJAOLPPCJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x77B3A90", Offset = "0x77B2490", VA = "0x1877B3A90")]
			internal object MMIEJMHPBGO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x77B37D0", Offset = "0x77B21D0", VA = "0x1877B37D0")]
			internal object FCMDLOANPFO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x77B3580", Offset = "0x77B1F80", VA = "0x1877B3580")]
			internal object AOPNNPPCNBD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x77B3840", Offset = "0x77B2240", VA = "0x1877B3840")]
			internal object GINLJALEFGA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private ShaderPropertyTranslator[] translators;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IReadOnlyList<ShaderPropertyTranslator> Translators
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x77B4910", Offset = "0x77B3310", VA = "0x1877B4910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77B4150", Offset = "0x77B2B50", VA = "0x1877B4150")]
		public bool GENDGCCLKPN(MaterialEntry BKMDNJELMHC, [Out] ShaderPropertyTranslator DCBAEHGDIPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77B4280", Offset = "0x77B2C80", VA = "0x1877B4280")]
		public bool HBDHOLNAMAB(MaterialEntry AGOHIJCCAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
		public ShaderPropertyTranslatorConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CreateAssetMenu(fileName = "ShaderPropertyTranslatorMultiPropertyCondition", menuName = "RecRoom/Studio/Shader Property Translator MultiCondition")]
	public class ShaderPropertyTranslatorMultiPropertyCondition : ShaderPropertyTranslatorCondition
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum MGOIJDNLAKB
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			MustBeEmissive,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			MustBeNonEmissive
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		public MGOIJDNLAKB emissionRequirement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		public ShaderPropertyTranslatorPropertyCondition[] conditions;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x77B4960", Offset = "0x77B3360", VA = "0x1877B4960", Slot = "4")]
		public override bool IAFOIFJMJHJ(MaterialEntry DONMCNNPIBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
		public ShaderPropertyTranslatorMultiPropertyCondition()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NOFKDIBFPAE
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Equals,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	NotEquals,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	KeywordExists,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	KeywordDoesntExist
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ShaderPropertyTranslatorPropertyCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float propertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private NOFKDIBFPAE comparisonType;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x77B4B80", Offset = "0x77B3580", VA = "0x1877B4B80")]
		public bool KJOFCFGNKGA(MaterialEntry BCFLJNKHAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ShaderPropertyTranslatorPropertyCondition()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum ShaderPropertyTranslatorType
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Range,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Vector,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
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
