using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Creation;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.MCluster.Types;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MCluster_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82F9C40", Offset = "0x82F9040", VA = "0x1882F9C40", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.MCluster
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct Constants
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly int[] CULLING_LAYER_ARG_OFFSETS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly uint[] CULLING_LAYER_MASK;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly string[] SHADER_KEYWORD_ARRAY;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1A7EFA0", Offset = "0x1A7E3A0", VA = "0x181A7EFA0")]
		public static int SFOIGVZRIFB(CullingLayer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82F5750", Offset = "0x82F4B50", VA = "0x1882F5750")]
		public static int RXDNZXJPBTS(CullingLayer a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YTXRAEFMQRQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int FZSWKBXEODW
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HFASGTHLKEI GVKOFKVQHRS(int a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Hash128 GWQAWEUIJXE(int a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRTransform NBEFOVOIPYG();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MaterialInfo ZGDOCGQUQDN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JCFIPSYRWDF : RNLXADHQFRR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RRTransform WJCWXTHIKWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Transform QHSJKEJAHVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<FOWGCTJWFFH> LVYVCKMQIMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private OTADZBLNFYN EQEIFSJZAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ComputeHandle RSUAMOHMYWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool BJRUHVFQBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private YTXRAEFMQRQ QQELQJCMZEF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float RIOBEBUFEES
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4010", Offset = "0xAD3410", VA = "0x180AD4010")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D50", Offset = "0xAD3150", VA = "0x180AD3D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RFDUVGOFNHS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xC6B720", Offset = "0xC6AB20", VA = "0x180C6B720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC6B160", Offset = "0xC6A560", VA = "0x180C6B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool LGIIAYOVXBU
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x12AD950", Offset = "0x12ACD50", VA = "0x1812AD950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x12AD620", Offset = "0x12ACA20", VA = "0x1812AD620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool WMTAQBKUULG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7715B90", Offset = "0x7714F90", VA = "0x187715B90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1DD5AF0", Offset = "0x1DD4EF0", VA = "0x181DD5AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EATGZEGMDVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x734D6B0", Offset = "0x734CAB0", VA = "0x18734D6B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82F9630", Offset = "0x82F8A30", VA = "0x1882F9630")]
		public JCFIPSYRWDF(YTXRAEFMQRQ a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82F9010", Offset = "0x82F8410", VA = "0x1882F9010")]
		private bool BRKLQJNZCCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82F83C0", Offset = "0x82F77C0", VA = "0x1882F83C0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82F9460", Offset = "0x82F8860", VA = "0x1882F9460", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82F9240", Offset = "0x82F8640", VA = "0x1882F9240", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82F9230", Offset = "0x82F8630", VA = "0x1882F9230", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface JRFZNNPLOUB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OEHDIJIRSDD(CommandBuffer a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct TexturePropertyData : JRFZNNPLOUB
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public readonly RenderTargetIdentifier Texture
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x52EDF30", Offset = "0x52ED330", VA = "0x1852EDF30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8303480", Offset = "0x8302880", VA = "0x188303480")]
		public TexturePropertyData(int id, RenderTargetIdentifier data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8303430", Offset = "0x8302830", VA = "0x188303430", Slot = "4")]
		public void OEHDIJIRSDD(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct VectorArrayPropertyData : JRFZNNPLOUB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly Vector4[] VectorArray
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1662AD0", Offset = "0x1661ED0", VA = "0x181662AD0")]
		public VectorArrayPropertyData(int id, Vector4[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83034A0", Offset = "0x83028A0", VA = "0x1883034A0", Slot = "4")]
		public void OEHDIJIRSDD(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FloatArrayPropertyData : JRFZNNPLOUB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly float[] FloatArray
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1662AD0", Offset = "0x1661ED0", VA = "0x181662AD0")]
		public FloatArrayPropertyData(int id, float[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82F82E0", Offset = "0x82F76E0", VA = "0x1882F82E0", Slot = "4")]
		public void OEHDIJIRSDD(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KeywordPropertyData : JRFZNNPLOUB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBB8560", Offset = "0xBB7960", VA = "0x180BB8560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x17DCB20", Offset = "0x17DBF20", VA = "0x1817DCB20")]
		public KeywordPropertyData(string name, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82F9C00", Offset = "0x82F9000", VA = "0x1882F9C00", Slot = "4")]
		public void OEHDIJIRSDD(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MaterialInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Hash128 Hash
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xFB4270", Offset = "0xFB3670", VA = "0x180FB4270")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float4 BaseColorLinear
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(float4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int ColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float DetailScale
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xDBC5E0", Offset = "0xDBB9E0", VA = "0x180DBC5E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82FB510", Offset = "0x82FA910", VA = "0x1882FB510")]
		public MaterialInfo(Color color, int colorIndex, int typeIndex, float detailScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		private static float4 QWDGARLIRSC(Color a)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82FB480", Offset = "0x82FA880", VA = "0x1882FB480")]
		private static Hash128 SSKOOIPTHBA(MaterialInfo a)
		{
			return default(Hash128);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class OTADZBLNFYN : RNLXADHQFRR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly string DVRHIGDRWIP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly string TGSGVFZHNDU;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly string QIQUPFJEJUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MaterialInfo CLVGCTJEXBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ClusterMaterial OECLGOBUSBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Hash128 FIRRDPGRRBA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ComputeHandle FJFZDJPLHQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xF76410", Offset = "0xF75810", VA = "0x180F76410")]
			[CompilerGenerated]
			get
			{
				return default(ComputeHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15292A0", Offset = "0x15286A0", VA = "0x1815292A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool RFDUVGOFNHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1021050", Offset = "0x1020450", VA = "0x181021050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70A95B0", Offset = "0x70A89B0", VA = "0x1870A95B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool LGIIAYOVXBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1021080", Offset = "0x1020480", VA = "0x181021080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8257F80", Offset = "0x8257380", VA = "0x188257F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EATGZEGMDVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool WMTAQBKUULG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1021090", Offset = "0x1020490", VA = "0x181021090", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82FBC50", Offset = "0x82FB050", VA = "0x1882FBC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int NKHCRNAJCUK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82FB950", Offset = "0x82FAD50", VA = "0x1882FB950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82FBD40", Offset = "0x82FB140", VA = "0x1882FBD40")]
		public OTADZBLNFYN(MaterialInfo a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82FB810", Offset = "0x82FAC10", VA = "0x1882FB810")]
		private bool BRKLQJNZCCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82FB6C0", Offset = "0x82FAAC0", VA = "0x1882FB6C0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82FB910", Offset = "0x82FAD10", VA = "0x1882FB910")]
		private static ClusterMaterial FRLTYEHLPVN(MaterialInfo a)
		{
			return default(ClusterMaterial);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82FBAA0", Offset = "0x82FAEA0", VA = "0x1882FBAA0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82FB9A0", Offset = "0x82FADA0", VA = "0x1882FB9A0", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82F9CC0", Offset = "0x82F90C0", VA = "0x1882F9CC0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82F9EC0", Offset = "0x82F92C0", VA = "0x1882F9EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private KGWWHQARDGI opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RenderPipeline YJHPQCWIZDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x82FA7A0", Offset = "0x82F9BA0", VA = "0x1882FA7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x82FA4E0", Offset = "0x82F98E0", VA = "0x1882FA4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82F9FA0", Offset = "0x82F93A0", VA = "0x1882F9FA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82F9F70", Offset = "0x82F9370", VA = "0x1882F9F70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82FA550", Offset = "0x82F9950", VA = "0x1882FA550")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1674F80", Offset = "0x1674380", VA = "0x181674F80")]
		public MClusterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class NLDPRJIWWWC<a> : IDisposable where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private WCENXRMNRTZ IJFLKJXHDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private WCENXRMNRTZ IKXJNSZMZPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ComputeBuffer PYYZWJMCZMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RenderTexture OOYTEFHTDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int AODMOJWNVRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int UDYVJSVQQRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private string UJORJBGDFMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string AZTMGKSANMJ;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int WIFUIKWYFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int AUFXHEROEEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5855A00", Offset = "0x5854E00", VA = "0x185855A00")]
		public NLDPRJIWWWC(string a, int b, [Optional] RenderTextureFormat? c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5853CF0", Offset = "0x58530F0", VA = "0x185853CF0")]
		public void Update(CommandBuffer cmd, NativeArray<a> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x58524B0", Offset = "0x58518B0", VA = "0x1858524B0")]
		public void Bind(CommandBuffer cmd, ComputeShader computeShader, int kernel, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5851F60", Offset = "0x5851360", VA = "0x185851F60")]
		public void Bind(Material material, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5853050", Offset = "0x5852450", VA = "0x185853050", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KVELIGWQLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Bind(Material mat);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TOALYIKOEHE<a, b> : KVELIGWQLJB, IDisposable where a : struct where b : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected bool[] EXNTPVKNEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected WCENXRMNRTZ MDOVXWCPVAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected WCENXRMNRTZ DGJTIVWMRSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected NativeArray<int> MORTOUBELWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected NativeArray<a> IACWKEJKGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected int UJKTFLXFHSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected int GVRZEXEODXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected NLDPRJIWWWC<int> BELAUQVSQNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected NLDPRJIWWWC<a> FIKCURXVIYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected NLDPRJIWWWC<b> KCFJOKTHLJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected ComputeShader YQEZTOPZNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected int EHUPZUDZJXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected int FAXFESRADRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		protected int FARYHLXCUGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected int FBHSZGEUWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected int KNACWBCFOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected int XWZLVHEMFCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int LHZAYTECEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int CUDTPVAHECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected int FJKKDELWUHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int JBBESTFJBNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int SZSFUXSSCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected int UOQBZQAYHIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string GHYPQFDPWFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected float[] CTNZYTJDYOT;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int CAZKSLEJPCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5F00550", Offset = "0x5EFF950", VA = "0x185F00550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string KYIYROHZCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5F03C10", Offset = "0x5F03010", VA = "0x185F03C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5F05D10", Offset = "0x5F05110", VA = "0x185F05D10")]
		public TOALYIKOEHE(string a, int b, int c, RenderTextureFormat d, ComputeShader e, int f = 0, int g = 0, int h = 0, int i = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5F038E0", Offset = "0x5F02CE0", VA = "0x185F038E0")]
		public int LXFZKGCOJWT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5F05CC0", Offset = "0x5F050C0", VA = "0x185F05CC0")]
		protected void YXEVXUKBONA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5F00560", Offset = "0x5EFF960", VA = "0x185F00560")]
		public ComputeHandle Add(a data)
		{
			return default(ComputeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5F05B00", Offset = "0x5F04F00", VA = "0x185F05B00")]
		public bool Update(ComputeHandle handle, a data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5F04F10", Offset = "0x5F04310", VA = "0x185F04F10")]
		public bool Remove(ComputeHandle handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		protected virtual void HUWQPRAWMMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5F02BB0", Offset = "0x5F01FB0", VA = "0x185F02BB0", Slot = "7")]
		public void IUTJVSRLSVB(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5F02CE0", Offset = "0x5F020E0", VA = "0x185F02CE0", Slot = "8")]
		public void IUTJVSRLSVB(CommandBuffer a, ComputeShader b, int c = -1, int d = -1, int e = -1, int f = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F01800", Offset = "0x5F00C00", VA = "0x185F01800", Slot = "9")]
		public void Bind(CommandBuffer cmd, ComputeShader shader, int kernelIndex = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F01760", Offset = "0x5F00B60", VA = "0x185F01760", Slot = "4")]
		public void Bind(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5F021C0", Offset = "0x5F015C0", VA = "0x185F021C0", Slot = "10")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WCENXRMNRTZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ulong SizeInMemoryCPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ulong SizeInMemoryGPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class MLNIOWZTCND
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ResourceHandle : WCENXRMNRTZ, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private IDisposable resource;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2A78250", Offset = "0x2A77650", VA = "0x182A78250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8303230", Offset = "0x8302630", VA = "0x188303230")]
			internal ResourceHandle(IDisposable createdResource, ulong cpuMemorySize, ulong gpuMemorySize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83031B0", Offset = "0x83025B0", VA = "0x1883031B0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct RenderTextureHandle : WCENXRMNRTZ, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private RenderTexture renderTexture;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2A78250", Offset = "0x2A77650", VA = "0x182A78250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8303180", Offset = "0x8302580", VA = "0x188303180")]
			public RenderTextureHandle(RenderTexture texture, ulong gpuSize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x83030E0", Offset = "0x83024E0", VA = "0x1883030E0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static ulong NGCIUGWNJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x82FAEC0", Offset = "0x82FA2C0", VA = "0x1882FAEC0")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x82FB050", Offset = "0x82FA450", VA = "0x1882FB050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static ulong KRNFWMOHSBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x82FAF00", Offset = "0x82FA300", VA = "0x1882FAF00")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x82FAE80", Offset = "0x82FA280", VA = "0x1882FAE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82FAB80", Offset = "0x82F9F80", VA = "0x1882FAB80")]
		public static ComputeBuffer Create(int count, int stride, ComputeBufferType type, [Out] WCENXRMNRTZ handle, ComputeBufferMode mode = ComputeBufferMode.Immutable)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82FA7F0", Offset = "0x82F9BF0", VA = "0x1882FA7F0")]
		public static RenderTexture Create(int height, int width, int depth, RenderTextureFormat format, [Out] WCENXRMNRTZ handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x375DD40", Offset = "0x375D140", VA = "0x18375DD40")]
		public static NativeArray<a> DDSLHOXMBOP<a>(NativeArray<a> a, ulong b, [Out] WCENXRMNRTZ c) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x375D120", Offset = "0x375C520", VA = "0x18375D120")]
		public static NativeArray<T> Create<T>(int length, Allocator allocator, [Out] WCENXRMNRTZ handle, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82FAD40", Offset = "0x82FA140", VA = "0x1882FAD40")]
		public static void Destroy(WCENXRMNRTZ resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82FAF40", Offset = "0x82FA340", VA = "0x1882FAF40")]
		public static uint PUXQQSZEHHS(RenderTextureFormat a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class EOVBVUTDYUK : TOALYIKOEHE<ClusterTransform, ClusterTransform>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[BurstCompile]
		public struct SampleTransformData : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[ReadOnly]
			private NativeArray<int> indexArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[ReadOnly]
			private NativeArray<float> extentArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[WriteOnly]
			private NativeArray<float4x4> sampledTransformDst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[WriteOnly]
			private NativeArray<float4> sampledScaleExtentDst;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x82F5BA0", Offset = "0x82F4FA0", VA = "0x1882F5BA0")]
			public SampleTransformData(NativeArray<int> indexSrc, NativeArray<float> extentSrc, NativeArray<float4x4> transformDst, NativeArray<float4> scaleExtentDst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8303270", Offset = "0x8302670", VA = "0x188303270", Slot = "4")]
			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile]
		public struct CreateClusterTransformUpdateData : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[ReadOnly]
			private NativeArray<int> indexArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[ReadOnly]
			private NativeArray<float4x4> sampledTransformData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[ReadOnly]
			private NativeArray<float4> sampledScaleExtentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[WriteOnly]
			private NativeArray<ClusterTransform> transformUpdateDst;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x82F5BA0", Offset = "0x82F4FA0", VA = "0x1882F5BA0")]
			public CreateClusterTransformUpdateData(NativeArray<int> indexSrc, NativeArray<float4x4> transformData, NativeArray<float4> scaleExtentSrc, NativeArray<ClusterTransform> dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x82F5B30", Offset = "0x82F4F30", VA = "0x1882F5B30", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private const byte QWLVVVMPNZL = 255;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TransformAccessArray DCHFCQIDMZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> MAXLAJQGISA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NativeArray<float4x4> PWINUZVIQBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NativeArray<float4> ORJJNAEESLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private NativeArray<int> PDHDZGJFVDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NativeArray<int> AQUJUDYEUUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private WCENXRMNRTZ NMSTFFSIDHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private WCENXRMNRTZ TBVWUXUFVPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private WCENXRMNRTZ CXKDOQXOPZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private WCENXRMNRTZ KFSUITCFQBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private WCENXRMNRTZ TMUYZNTRUEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Transform HQZTAHMWQVP;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82F62E0", Offset = "0x82F56E0", VA = "0x1882F62E0")]
		public EOVBVUTDYUK(int a, int b, ComputeShader c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82F5DD0", Offset = "0x82F51D0", VA = "0x1882F5DD0", Slot = "6")]
		protected override void HUWQPRAWMMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82F6220", Offset = "0x82F5620", VA = "0x1882F6220")]
		private void USZVPQDIRPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82F5FE0", Offset = "0x82F53E0", VA = "0x1882F5FE0")]
		public bool LKVTKHLKXBY(ComputeHandle a, Transform b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82F6140", Offset = "0x82F5540", VA = "0x1882F6140")]
		public void TYUOQWJCIAJ(ComputeHandle a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82F5C80", Offset = "0x82F5080", VA = "0x1882F5C80")]
		public void AEACIGJLUEQ(ComputeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82F5D30", Offset = "0x82F5130", VA = "0x1882F5D30", Slot = "10")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface HFASGTHLKEI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeMesh Complete();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface PVOXZIMHWMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		Hash128 ANWYMRJAOVY
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int QKGLHRTPCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int RGACUWQPXAP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NativeArray<float3> UFCVMLCAYHD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		NativeArray<float3> LCYMKKOFNYB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		NativeArray<float4> CQKXWPQPPIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		NativeArray<int> YUFBJKJPQQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		NativeArray<float2> MNHFRQEMECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		NativeArray<float4> FUMQDNGLWBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		int UXOZQQFURYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int OYYKNFFPZCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		int EHVCOXEAUPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool TZFXZFCIWFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IUTJVSRLSVB();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MUJYLXABOMU : PVOXZIMHWMJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private HFASGTHLKEI TXRFUVWKVZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeMesh FQBRAHPLIZV;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Hash128 ANWYMRJAOVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool SWQPOARYPMT
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int QKGLHRTPCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int RGACUWQPXAP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private int NBPPWDUHUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1ACB200", Offset = "0x1ACA600", VA = "0x181ACB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NativeArray<float3> UFCVMLCAYHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x82FB2A0", Offset = "0x82FA6A0", VA = "0x1882FB2A0", Slot = "7")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public NativeArray<float3> LCYMKKOFNYB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x82FB390", Offset = "0x82FA790", VA = "0x1882FB390", Slot = "8")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NativeArray<float4> CQKXWPQPPIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x82FB270", Offset = "0x82FA670", VA = "0x1882FB270", Slot = "9")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public NativeArray<int> YUFBJKJPQQK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x82FB3C0", Offset = "0x82FA7C0", VA = "0x1882FB3C0", Slot = "10")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public NativeArray<float2> MNHFRQEMECB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x82FB330", Offset = "0x82FA730", VA = "0x1882FB330", Slot = "11")]
			get
			{
				return default(NativeArray<float2>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NativeArray<float4> FUMQDNGLWBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x82FB360", Offset = "0x82FA760", VA = "0x1882FB360", Slot = "12")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool TZFXZFCIWFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int UXOZQQFURYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x82FB120", Offset = "0x82FA520", VA = "0x1882FB120", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int OYYKNFFPZCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x82FB310", Offset = "0x82FA710", VA = "0x1882FB310", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int EHVCOXEAUPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x82FB130", Offset = "0x82FA530", VA = "0x1882FB130", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82FB430", Offset = "0x82FA830", VA = "0x1882FB430")]
		public MUJYLXABOMU(Hash128 a, HFASGTHLKEI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82FB150", Offset = "0x82FA550", VA = "0x1882FB150", Slot = "16")]
		public void IUTJVSRLSVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82FB090", Offset = "0x82FA490", VA = "0x1882FB090", Slot = "18")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct ComputeHandle : IEquatable<ComputeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly ComputeHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public readonly int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
		public ComputeHandle(int index = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82F55A0", Offset = "0x82F49A0", VA = "0x1882F55A0", Slot = "4")]
		public bool Equals(ComputeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82F55F0", Offset = "0x82F49F0", VA = "0x1882F55F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82F56C0", Offset = "0x82F4AC0", VA = "0x1882F56C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class FOWGCTJWFFH : RNLXADHQFRR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool BJRUHVFQBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PVOXZIMHWMJ SWGHPRBWDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private List<ComputeHandle> EYMRRUMYANU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private List<ComputeHandle> WGFZAVOOCYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<ComputeHandle> XQNEDANPMUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<int, uint> IVACVXMUEDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int IDQYDJXDVTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int SDXSLFDAMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int LCKPNPUHLXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int NGYYGYCKXYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int SHFIYDGFTNR;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int NKHCRNAJCUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x82F7A20", Offset = "0x82F6E20", VA = "0x1882F7A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x82F71F0", Offset = "0x82F65F0", VA = "0x1882F71F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool RFDUVGOFNHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool LGIIAYOVXBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB22480", Offset = "0xB21880", VA = "0x180B22480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xB22790", Offset = "0xB21B90", VA = "0x180B22790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool EATGZEGMDVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool WMTAQBKUULG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2804670", Offset = "0x2803A70", VA = "0x182804670", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2508280", Offset = "0x2507680", VA = "0x182508280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float RIOBEBUFEES
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1A0", Offset = "0xD8E5A0", VA = "0x180D8F1A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1B0", Offset = "0xD8E5B0", VA = "0x180D8F1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82F81A0", Offset = "0x82F75A0", VA = "0x1882F81A0")]
		public FOWGCTJWFFH(PVOXZIMHWMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82F7290", Offset = "0x82F6690", VA = "0x1882F7290")]
		private void EJYXGGBJRQJ(PVOXZIMHWMJ a, int b, int c, int d, int e, VertexData f, float g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x82F7760", Offset = "0x82F6B60", VA = "0x1882F7760")]
		private void GWMQJUSJPNT(PVOXZIMHWMJ a, int b, int c, uint3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x82F6F50", Offset = "0x82F6350", VA = "0x1882F6F50")]
		private bool BRKLQJNZCCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x82F65C0", Offset = "0x82F59C0", VA = "0x1882F65C0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x82F8120", Offset = "0x82F7520", VA = "0x1882F8120", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x82F7AD0", Offset = "0x82F6ED0", VA = "0x1882F7AD0", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x82F7230", Offset = "0x82F6630", VA = "0x1882F7230")]
		public void HHNUDJJQGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x82F7230", Offset = "0x82F6630", VA = "0x1882F7230", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface RNLXADHQFRR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool EATGZEGMDVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool WMTAQBKUULG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Add();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Update();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ZEGXRDKCAJS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly float HLLMDKPCSAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Dictionary<Hash128, FOWGCTJWFFH> DKNOARIGYUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Dictionary<Hash128, OTADZBLNFYN> CRFSWXYCKXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Queue<RNLXADHQFRR> SCWTRPGVLQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Queue<RNLXADHQFRR> GWVFBTQYLCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Queue<RNLXADHQFRR> MOJVNIJYWWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int KVLYWKTXIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int DZTOXJKUOUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private float JJKIAPGYZWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool AMRZRCPNZQB;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool CYZHOQKBZEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool FTMJVYJTSVE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8304280", Offset = "0x8303680", VA = "0x188304280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string KYIYROHZCNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8303EE0", Offset = "0x83032E0", VA = "0x188303EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83047E0", Offset = "0x8303BE0", VA = "0x1883047E0")]
		public void TORDECQRPYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2105510", Offset = "0x2104910", VA = "0x182105510")]
		public void VMVXQKQQRNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8304920", Offset = "0x8303D20", VA = "0x188304920")]
		public ZEGXRDKCAJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83042D0", Offset = "0x83036D0", VA = "0x1883042D0")]
		public JCFIPSYRWDF SHWXSEAJSCT(YTXRAEFMQRQ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83043F0", Offset = "0x83037F0", VA = "0x1883043F0")]
		public OTADZBLNFYN SHWXSEAJSCT(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8304870", Offset = "0x8303C70", VA = "0x188304870")]
		public bool WRJSWYDYCKJ(Hash128 a, [Out] FOWGCTJWFFH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8304520", Offset = "0x8303920", VA = "0x188304520")]
		public FOWGCTJWFFH SHWXSEAJSCT(PVOXZIMHWMJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8303EC0", Offset = "0x83032C0", VA = "0x188303EC0")]
		private void LPZJAFNKIHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83047F0", Offset = "0x8303BF0", VA = "0x1883047F0")]
		private bool UXCMZOLILHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8303A10", Offset = "0x8302E10", VA = "0x188303A10")]
		public void IUTJVSRLSVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8303900", Offset = "0x8302D00", VA = "0x188303900", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8303850", Offset = "0x8302C50", VA = "0x188303850")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ZWPSXCUPCZF : TOALYIKOEHE<ObjectInfo, ObjectInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8304A90", Offset = "0x8303E90", VA = "0x188304A90")]
		public ZWPSXCUPCZF(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GJODXMEWJGV : TOALYIKOEHE<ClusterMaterial, ClusterMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x82F8310", Offset = "0x82F7710", VA = "0x1882F8310")]
		public GJODXMEWJGV(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class EAIBHIBOQFS : TOALYIKOEHE<ClusterInfo, ClusterInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x82F5BD0", Offset = "0x82F4FD0", VA = "0x1882F5BD0")]
		public EAIBHIBOQFS(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class QPHVAECZZEE : TOALYIKOEHE<ClusterVertexData, ClusterCompressedVertexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x82FC0B0", Offset = "0x82FB4B0", VA = "0x1882FC0B0")]
		public QPHVAECZZEE(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class XMSJWFUGCZU : TOALYIKOEHE<ClusterIndexData, ClusterIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83037A0", Offset = "0x8302BA0", VA = "0x1883037A0")]
		public XMSJWFUGCZU(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class KGWWHQARDGI : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private RenderPipeline KNVYLPNRCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool GGMXSBRQZCT;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static bool NVBDRVMDSZP;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x82F9B90", Offset = "0x82F8F90", VA = "0x1882F9B90")]
		public KGWWHQARDGI(RenderPipeline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x82F9A70", Offset = "0x82F8E70", VA = "0x1882F9A70", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x82F96E0", Offset = "0x82F8AE0", VA = "0x1882F96E0", Slot = "6")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x82F9720", Offset = "0x82F8B20", VA = "0x1882F9720", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class WKJWMIHLFLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public readonly struct RenderPassContext : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private readonly string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private readonly CommandBuffer cmd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private readonly ScriptableRenderContext context;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x82FC210", Offset = "0x82FB610", VA = "0x1882FC210")]
			public RenderPassContext(string passName, ScriptableRenderContext currentContext, [Out] CommandBuffer externCmd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x82FC160", Offset = "0x82FB560", VA = "0x1882FC160", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83034D0", Offset = "0x83028D0", VA = "0x1883034D0")]
		public static bool KQFZCNOASLZ(RenderingData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83035B0", Offset = "0x83029B0", VA = "0x1883035B0")]
		public static void VYGATWDVISB(CommandBuffer a, ScriptableRenderContext b, ShadowDrawingSettings c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RenderPipeline : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class NQKSDCACTTR
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly int WDDMFPDJUDB;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly int ZWMCHDNTSNK;
		}

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static NLDPRJIWWWC<ClusterReference> ATMJRXFJXIS;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static NLDPRJIWWWC<uint> RQPJNUHNDPH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static WCENXRMNRTZ DKWNHXSRBNF;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static ComputeBuffer TIDAYIAAOMV;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static List<KVELIGWQLJB> BNGWDKFFHPU;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int RZWIPLUESHA;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int RPVJPONONQI;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int RTFJGFQMCCB;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int HKKYLOMCASH;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static int[] FVLOOFERAKX;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Material[] BGLOUBYTONW;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static JRFZNNPLOUB[][] IOPMMBMSSSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Plane[] IPJLEGNSTIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int AYDGYGNWYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int TPBBGWRWBUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int HNVBBFFLKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int QDLNZBAUZPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int TCNKTLNHTTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int UUWSOJRZIZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int ZCBULSIMUQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int OTBGFTLHZSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int PFUXPOXDWMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int OIKZGMQYPRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int JYZEYUSZJQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int AUGLPBTHAYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int CQYTSOKFMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int DVQCUOFFRGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int ALYMZQWVZNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int NYKRNGXOIWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int OKPTWZCHORG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int EURETPAUHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private float[] PTJZHDNLDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private ZEGXRDKCAJS VMALFGRHSME;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static bool YZZSTDFWHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8302DB0", Offset = "0x83021B0", VA = "0x188302DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x82FC320", Offset = "0x82FB720", VA = "0x1882FC320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static bool GJZGMYSWVHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8300670", Offset = "0x82FFA70", VA = "0x188300670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x82FF960", Offset = "0x82FED60", VA = "0x1882FF960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static MClusterData VQVHWHVOHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x82FCA10", Offset = "0x82FBE10", VA = "0x1882FCA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x83028E0", Offset = "0x8301CE0", VA = "0x1883028E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static EOVBVUTDYUK EOVBVUTDYUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8302950", Offset = "0x8301D50", VA = "0x188302950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x82FC380", Offset = "0x82FB780", VA = "0x1882FC380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static ZWPSXCUPCZF ZWPSXCUPCZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x82FFAD0", Offset = "0x82FEED0", VA = "0x1882FFAD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x82FDB70", Offset = "0x82FCF70", VA = "0x1882FDB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static GJODXMEWJGV GJODXMEWJGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x82FDBE0", Offset = "0x82FCFE0", VA = "0x1882FDBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8301A50", Offset = "0x8300E50", VA = "0x188301A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static EAIBHIBOQFS EAIBHIBOQFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8302760", Offset = "0x8301B60", VA = "0x188302760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8302820", Offset = "0x8301C20", VA = "0x188302820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static QPHVAECZZEE QPHVAECZZEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x82FDB20", Offset = "0x82FCF20", VA = "0x1882FDB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8301AC0", Offset = "0x8300EC0", VA = "0x188301AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static XMSJWFUGCZU XMSJWFUGCZU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x83029F0", Offset = "0x8301DF0", VA = "0x1883029F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8300600", Offset = "0x82FFA00", VA = "0x188300600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static Material JAKWQHTBRCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8302A50", Offset = "0x8301E50", VA = "0x188302A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x83027B0", Offset = "0x8301BB0", VA = "0x1883027B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static Material XWXYSWOBNZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x83029A0", Offset = "0x8301DA0", VA = "0x1883029A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x82FDC30", Offset = "0x82FD030", VA = "0x1882FDC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static Material JAISOXPZXBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8300D00", Offset = "0x8300100", VA = "0x188300D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x83006C0", Offset = "0x82FFAC0", VA = "0x1883006C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static Material SQVNVUHBCVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x82FFB20", Offset = "0x82FEF20", VA = "0x1882FFB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x82FF9C0", Offset = "0x82FEDC0", VA = "0x1882FF9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static bool RZMTOEYWLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8302890", Offset = "0x8301C90", VA = "0x188302890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8301FB0", Offset = "0x83013B0", VA = "0x188301FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool FTMJVYJTSVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8302010", Offset = "0x8301410", VA = "0x188302010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string KYIYROHZCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x82FFF60", Offset = "0x82FF360", VA = "0x1882FFF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8302E90", Offset = "0x8302290", VA = "0x188302E90")]
		internal RenderPipeline([Optional] MClusterData dataData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82FE570", Offset = "0x82FD970", VA = "0x1882FE570")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x82FFA30", Offset = "0x82FEE30", VA = "0x1882FFA30")]
		public void JQTXHCYQJVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8302A40", Offset = "0x8301E40", VA = "0x188302A40")]
		public void XIERAIIGYUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82FDA80", Offset = "0x82FCE80", VA = "0x1882FDA80")]
		public bool FUWFOVVTIYE(Hash128 a, [Out] FOWGCTJWFFH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8302630", Offset = "0x8301A30", VA = "0x188302630")]
		public FOWGCTJWFFH SHWXSEAJSCT(PVOXZIMHWMJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8302440", Offset = "0x8301840", VA = "0x188302440")]
		public OTADZBLNFYN SHWXSEAJSCT(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8302290", Offset = "0x8301690", VA = "0x188302290")]
		public JCFIPSYRWDF SHWXSEAJSCT(YTXRAEFMQRQ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8302240", Offset = "0x8301640", VA = "0x188302240")]
		public void Remove(RNLXADHQFRR element)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x82FC930", Offset = "0x82FBD30", VA = "0x1882FC930")]
		public static void CTZNRDNBCBJ(CullingLayer a, JRFZNNPLOUB[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x82FDCA0", Offset = "0x82FD0A0", VA = "0x1882FDCA0")]
		private void HLTEBHRLHEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8300D50", Offset = "0x8300150", VA = "0x188300D50")]
		private static void NNQMASSNHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8302AA0", Offset = "0x8301EA0", VA = "0x188302AA0")]
		public void XTZLCXTMMTF(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8302070", Offset = "0x8301470", VA = "0x188302070")]
		public void QUIKAAGAERL([Optional] ScriptableRenderContext? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82FFB70", Offset = "0x82FEF70", VA = "0x1882FFB70")]
		public void LWIFRODTVQW(CommandBuffer a, ShadowSplitData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82FFDC0", Offset = "0x82FF1C0", VA = "0x1882FFDC0")]
		public void LWIFRODTVQW(CommandBuffer a, CameraData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x82FC3F0", Offset = "0x82FB7F0", VA = "0x1882FC3F0")]
		public void COHOVMOVEHR(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83026F0", Offset = "0x8301AF0", VA = "0x1883026F0")]
		public void SRQHNEWPEMK(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8301B30", Offset = "0x8300F30", VA = "0x188301B30")]
		public void QHCGEIQDMIX(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8300730", Offset = "0x82FFB30", VA = "0x188300730")]
		public void NGHAQAQMZSI(CommandBuffer a, CullingLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8301970", Offset = "0x8300D70", VA = "0x188301970")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x82FCA60", Offset = "0x82FBE60", VA = "0x1882FCA60")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x82FD970", Offset = "0x82FCD70", VA = "0x1882FD970", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class KCBYULNHUTE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2777790", Offset = "0x2776B90", VA = "0x182777790")]
		public static int CSISWQQAMVO(int a, int b)
		{
			return default(int);
		}
	}
}
namespace RecRoom.MCluster.Types
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ClusterTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float4x4 RotationTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public float4 NonUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly ClusterTransform Zero;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly ClusterTransform Invalid;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x82F5570", Offset = "0x82F4970", VA = "0x1882F5570")]
		public ClusterTransform(float4x4 rotationTranslation, float4 scaleExtent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x82F5410", Offset = "0x82F4810", VA = "0x1882F5410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct VertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public float4 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public float4 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float4 tangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float4 uvCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float4 uvCoord1;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct CompressedVertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float4 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public half4 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public half4 tangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public half4 uvCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public half4 uvCoord1;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct ClusterCompressedVertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CompressedVertexData vert00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CompressedVertexData vert01;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CompressedVertexData vert02;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CompressedVertexData vert03;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CompressedVertexData vert04;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CompressedVertexData vert05;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public CompressedVertexData vert06;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CompressedVertexData vert07;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct ClusterVertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public VertexData vert00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public VertexData vert01;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public VertexData vert02;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public VertexData vert03;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public VertexData vert04;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public VertexData vert05;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public VertexData vert06;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public VertexData vert07;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct ClusterMaterial
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public float4 baseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public uint colorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public uint typeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float detailScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82F5340", Offset = "0x82F4740", VA = "0x1882F5340")]
		public ClusterMaterial(MaterialInfo material)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct ClusterReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public uint objectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint cullingResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint clusterIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x82F5370", Offset = "0x82F4770", VA = "0x1882F5370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct ClusterInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public uint vertexOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public uint indexOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public uint indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x82F52A0", Offset = "0x82F46A0", VA = "0x1882F52A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct ObjectInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public uint materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public uint lod0ClusterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public uint lod0ClusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public uint lod1ClusterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public uint lod1ClusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public uint lod2ClusterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public uint lod2ClusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82FBD80", Offset = "0x82FB180", VA = "0x1882FBD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct ClusterIndexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public uint3 index0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public uint3 index1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public uint3 index2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public uint3 index3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public uint3 index4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint3 index5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public uint3 index6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public uint3 index7;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x82F4EA0", Offset = "0x82F42A0", VA = "0x1882F4EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public enum CullingLayer
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Opaque,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		DepthOnly,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Transparent,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Shadow
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4294369855
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8304B50", Offset = "0x8303F50", VA = "0x188304B50")]
	public static void ZKRXGWNKWSY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8304B40", Offset = "0x8303F40", VA = "0x188304B40")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
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
