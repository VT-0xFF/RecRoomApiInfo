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
		[Cpp2IlInjected.Address(RVA = "0x83B6D90", Offset = "0x83B5790", VA = "0x1883B6D90", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A9E4E0", Offset = "0x1A9CEE0", VA = "0x181A9E4E0")]
		public static int EIKVDQHQMXA(CullingLayer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83B67F0", Offset = "0x83B51F0", VA = "0x1883B67F0")]
		public static int FJEPOLJCWUF(CullingLayer a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ZZKLHWPVANX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int XMIZZRIXMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WLNUANDGASB BKAJUTRFFKR(int a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Hash128 INMISEPZWFX(int a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRTransform QTGQHTXHILN();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MaterialInfo CDUAHSCRRSU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PRTCQWAIIGM : PUTREPBFNZE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RRTransform UPSIZUKXNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Transform PTRPVDYDCPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<WYAUWVBMMFQ> XDZGXHAJAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private YXWQHLDRVEC XZTMJPOIUNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ComputeHandle QDYGZDHKLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool HENRRSKACVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ZZKLHWPVANX EXPPRHMKOSQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float VOBGMNFQLCL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAE6190", Offset = "0xAE4B90", VA = "0x180AE6190")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAE60F0", Offset = "0xAE4AF0", VA = "0x180AE60F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SZJCBZAVCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCB3680", Offset = "0xCB2080", VA = "0x180CB3680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCB3480", Offset = "0xCB1E80", VA = "0x180CB3480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool XIDSMIQEVRZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x12F29A0", Offset = "0x12F13A0", VA = "0x1812F29A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x12F26C0", Offset = "0x12F10C0", VA = "0x1812F26C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7792DE0", Offset = "0x77917E0", VA = "0x187792DE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1E49EC0", Offset = "0x1E488C0", VA = "0x181E49EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NBIOTFXGXWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x749ECD0", Offset = "0x749D6D0", VA = "0x18749ECD0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83BA350", Offset = "0x83B8D50", VA = "0x1883BA350")]
		public PRTCQWAIIGM(ZZKLHWPVANX a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83B9D40", Offset = "0x83B8740", VA = "0x1883B9D40")]
		private bool JYJXSMJLOLY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83B90F0", Offset = "0x83B7AF0", VA = "0x1883B90F0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83BA180", Offset = "0x83B8B80", VA = "0x1883BA180", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83B9F60", Offset = "0x83B8960", VA = "0x1883B9F60", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83B9D30", Offset = "0x83B8730", VA = "0x1883B9D30", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface SBOYVNJRWHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ISWZQDLCROK(CommandBuffer a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct TexturePropertyData : SBOYVNJRWHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
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
			[Cpp2IlInjected.Address(RVA = "0x538CB00", Offset = "0x538B500", VA = "0x18538CB00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83C18F0", Offset = "0x83C02F0", VA = "0x1883C18F0")]
		public TexturePropertyData(int id, RenderTargetIdentifier data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83C18A0", Offset = "0x83C02A0", VA = "0x1883C18A0", Slot = "4")]
		public void ISWZQDLCROK(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct VectorArrayPropertyData : SBOYVNJRWHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
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
			[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x16C88D0", Offset = "0x16C72D0", VA = "0x1816C88D0")]
		public VectorArrayPropertyData(int id, Vector4[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83C33F0", Offset = "0x83C1DF0", VA = "0x1883C33F0", Slot = "4")]
		public void ISWZQDLCROK(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FloatArrayPropertyData : SBOYVNJRWHE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
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
			[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x16C88D0", Offset = "0x16C72D0", VA = "0x1816C88D0")]
		public FloatArrayPropertyData(int id, float[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83B6C70", Offset = "0x83B5670", VA = "0x1883B6C70", Slot = "4")]
		public void ISWZQDLCROK(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KeywordPropertyData : SBOYVNJRWHE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xC00D70", Offset = "0xBFF770", VA = "0x180C00D70")]
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
			[Cpp2IlInjected.Address(RVA = "0xC00D80", Offset = "0xBFF780", VA = "0x180C00D80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1836260", Offset = "0x1834C60", VA = "0x181836260")]
		public KeywordPropertyData(string name, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83B6D50", Offset = "0x83B5750", VA = "0x1883B6D50", Slot = "4")]
		public void ISWZQDLCROK(CommandBuffer a)
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
			[Cpp2IlInjected.Address(RVA = "0x1004B50", Offset = "0x1003550", VA = "0x181004B50")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
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
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83B8C10", Offset = "0x83B7610", VA = "0x1883B8C10")]
		public MaterialInfo(Color color, int colorIndex, int typeIndex, float detailScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x10A2940", Offset = "0x10A1340", VA = "0x1810A2940")]
		private static float4 DKCIDMHWFHL(Color a)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83B8B80", Offset = "0x83B7580", VA = "0x1883B8B80")]
		private static Hash128 MWMQLESZAOR(MaterialInfo a)
		{
			return default(Hash128);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class YXWQHLDRVEC : PUTREPBFNZE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly string BEWFYQSBABS;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly string RDAYJPQOSJZ;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly string FBZRAUCRTMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MaterialInfo DPTUZHHSDTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ClusterMaterial MLPPKBJOXGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Hash128 LQHFDWPUNID;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ComputeHandle WHESTXEXVLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xFDCE00", Offset = "0xFDB800", VA = "0x180FDCE00")]
			[CompilerGenerated]
			get
			{
				return default(ComputeHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15729C0", Offset = "0x15713C0", VA = "0x1815729C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool SZJCBZAVCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1075A70", Offset = "0x1074470", VA = "0x181075A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71FB3D0", Offset = "0x71F9DD0", VA = "0x1871FB3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool XIDSMIQEVRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1075AA0", Offset = "0x10744A0", VA = "0x181075AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8315B00", Offset = "0x8314500", VA = "0x188315B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NBIOTFXGXWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1075AB0", Offset = "0x10744B0", VA = "0x181075AB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83C5460", Offset = "0x83C3E60", VA = "0x1883C5460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83C5760", Offset = "0x83C4160", VA = "0x1883C5760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83C5890", Offset = "0x83C4290", VA = "0x1883C5890")]
		public YXWQHLDRVEC(MaterialInfo a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83C5360", Offset = "0x83C3D60", VA = "0x1883C5360")]
		private bool JYJXSMJLOLY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83C5210", Offset = "0x83C3C10", VA = "0x1883C5210", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83C5470", Offset = "0x83C3E70", VA = "0x1883C5470")]
		private static ClusterMaterial QQBTFPAJBSC(MaterialInfo a)
		{
			return default(ClusterMaterial);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83C55B0", Offset = "0x83C3FB0", VA = "0x1883C55B0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83C54B0", Offset = "0x83C3EB0", VA = "0x1883C54B0", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83B6E10", Offset = "0x83B5810", VA = "0x1883B6E10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83B7010", Offset = "0x83B5A10", VA = "0x1883B7010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBF0BD0", Offset = "0xBEF5D0", VA = "0x180BF0BD0")]
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
		private VOPZJLDTZMF opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RenderPipeline KWCRWDFGMXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83B78F0", Offset = "0x83B62F0", VA = "0x1883B78F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83B7810", Offset = "0x83B6210", VA = "0x1883B7810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83B70F0", Offset = "0x83B5AF0", VA = "0x1883B70F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83B70C0", Offset = "0x83B5AC0", VA = "0x1883B70C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83B7630", Offset = "0x83B6030", VA = "0x1883B7630")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public MClusterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GHJXPGMZRIR<a> : IDisposable where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private BRTZTUAOXLG PBTJLSGIIQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private BRTZTUAOXLG CYTEPNTWNIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ComputeBuffer YCUPBGIXYSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RenderTexture YUHAJGLAHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int OKUWCVLQKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int GIRCDCDCETK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private string HLNTQEQGBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string HNNTWIYJZWS;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int QQBZNMEDXOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int IIVUUVHMXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4E38250", Offset = "0x4E36C50", VA = "0x184E38250")]
		public GHJXPGMZRIR(string a, int b, [Optional] RenderTextureFormat? c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E369C0", Offset = "0x4E353C0", VA = "0x184E369C0")]
		public void Update(CommandBuffer cmd, NativeArray<a> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4E359A0", Offset = "0x4E343A0", VA = "0x184E359A0")]
		public void Bind(CommandBuffer cmd, ComputeShader computeShader, int kernel, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E34F00", Offset = "0x4E33900", VA = "0x184E34F00")]
		public void Bind(Material material, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4E36570", Offset = "0x4E34F70", VA = "0x184E36570", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KWOWLQVZWOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Bind(Material mat);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EIQLMDTWFPJ<a, b> : KWOWLQVZWOG, IDisposable where a : struct where b : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected bool[] KNFZTDHTNRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected BRTZTUAOXLG EICUPBZKTPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected BRTZTUAOXLG SLKXENNWBZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected NativeArray<int> ROAYRHUZDKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected NativeArray<a> PASADOSXGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected int VALKJVBTCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected int PHNCUTASKYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected GHJXPGMZRIR<int> CPURZNUUOFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected GHJXPGMZRIR<a> MXALFQBEHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected GHJXPGMZRIR<b> ORSGRBTSHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected ComputeShader FGKPRFIDCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected int EKIJSGXPKIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected int BRFELGLCPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		protected int BRKLINEZYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected int BRPSFTYXIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected int JNHUSLNHRFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected int XYKMNOYLFKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int ESVRATEXUIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int PFKJKPFJYLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected int KUYEQKHVMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int WHQPYMTGAPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int LDJVWRGOCMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected int ZABUJWOZZUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string TXWJZJZGSOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected float[] CBZBVITOOLO;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int EPJMNHCVHXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x46C1EE0", Offset = "0x46C08E0", VA = "0x1846C1EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string XKLAIQWSEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x46C5210", Offset = "0x46C3C10", VA = "0x1846C5210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x46C7560", Offset = "0x46C5F60", VA = "0x1846C7560")]
		public EIQLMDTWFPJ(string a, int b, int c, RenderTextureFormat d, ComputeShader e, int f = 0, int g = 0, int h = 0, int i = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x46C46A0", Offset = "0x46C30A0", VA = "0x1846C46A0")]
		public int XCXUGZLFOAM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x46C3960", Offset = "0x46C2360", VA = "0x1846C3960")]
		protected void UTBOASWLPZT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x46C0480", Offset = "0x46BEE80", VA = "0x1846C0480")]
		public ComputeHandle Add(a data)
		{
			return default(ComputeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x46C44D0", Offset = "0x46C2ED0", VA = "0x1846C44D0")]
		public bool Update(ComputeHandle handle, a data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x46C21F0", Offset = "0x46C0BF0", VA = "0x1846C21F0")]
		public bool Remove(ComputeHandle handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "6")]
		protected virtual void ESFNYWDLEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x46C2FC0", Offset = "0x46C19C0", VA = "0x1846C2FC0", Slot = "7")]
		public void SNLVHQAMKMI(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x46C3670", Offset = "0x46C2070", VA = "0x1846C3670", Slot = "8")]
		public void SNLVHQAMKMI(CommandBuffer a, ComputeShader b, int c = -1, int d = -1, int e = -1, int f = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x46C17B0", Offset = "0x46C01B0", VA = "0x1846C17B0", Slot = "9")]
		public void Bind(CommandBuffer cmd, ComputeShader shader, int kernelIndex = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x46C14C0", Offset = "0x46BFEC0", VA = "0x1846C14C0", Slot = "4")]
		public void Bind(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E20", Offset = "0x46C0820", VA = "0x1846C1E20", Slot = "10")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface BRTZTUAOXLG : IDisposable
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
	public static class VUBEVRJPPJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ResourceHandle : BRTZTUAOXLG, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private IDisposable resource;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2AD1510", Offset = "0x2ACFF10", VA = "0x182AD1510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x83C13D0", Offset = "0x83BFDD0", VA = "0x1883C13D0")]
			internal ResourceHandle(IDisposable createdResource, ulong cpuMemorySize, ulong gpuMemorySize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83C1350", Offset = "0x83BFD50", VA = "0x1883C1350", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct RenderTextureHandle : BRTZTUAOXLG, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private RenderTexture renderTexture;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2AD1510", Offset = "0x2ACFF10", VA = "0x182AD1510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x83C1320", Offset = "0x83BFD20", VA = "0x1883C1320")]
			public RenderTextureHandle(RenderTexture texture, ulong gpuSize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x83C1280", Offset = "0x83BFC80", VA = "0x1883C1280", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static ulong XIHMJJPZLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83C2CC0", Offset = "0x83C16C0", VA = "0x1883C2CC0")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83C2FD0", Offset = "0x83C19D0", VA = "0x1883C2FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static ulong HNGSSMGLBJV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83C2E80", Offset = "0x83C1880", VA = "0x1883C2E80")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x83C2D00", Offset = "0x83C1700", VA = "0x1883C2D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83C2B00", Offset = "0x83C1500", VA = "0x1883C2B00")]
		public static ComputeBuffer Create(int count, int stride, ComputeBufferType type, [Out] BRTZTUAOXLG handle, ComputeBufferMode mode = ComputeBufferMode.Immutable)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83C2770", Offset = "0x83C1170", VA = "0x1883C2770")]
		public static RenderTexture Create(int height, int width, int depth, RenderTextureFormat format, [Out] BRTZTUAOXLG handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7460", Offset = "0x3BC5E60", VA = "0x183BC7460")]
		public static NativeArray<a> LDHODPYJFMU<a>(NativeArray<a> a, ulong b, [Out] BRTZTUAOXLG c) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6840", Offset = "0x3BC5240", VA = "0x183BC6840")]
		public static NativeArray<T> Create<T>(int length, Allocator allocator, [Out] BRTZTUAOXLG handle, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83C2D40", Offset = "0x83C1740", VA = "0x1883C2D40")]
		public static void Destroy(BRTZTUAOXLG resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83C2EC0", Offset = "0x83C18C0", VA = "0x1883C2EC0")]
		public static uint NHKLAUPBMIP(RenderTextureFormat a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class UCJDTDVGEYH : EIQLMDTWFPJ<ClusterTransform, ClusterTransform>
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
			[Cpp2IlInjected.Address(RVA = "0x83B6C40", Offset = "0x83B5640", VA = "0x1883B6C40")]
			public SampleTransformData(NativeArray<int> indexSrc, NativeArray<float> extentSrc, NativeArray<float4x4> transformDst, NativeArray<float4> scaleExtentDst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x83C1410", Offset = "0x83BFE10", VA = "0x1883C1410", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B6C40", Offset = "0x83B5640", VA = "0x1883B6C40")]
			public CreateClusterTransformUpdateData(NativeArray<int> indexSrc, NativeArray<float4x4> transformData, NativeArray<float4> scaleExtentSrc, NativeArray<ClusterTransform> dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x83B6BD0", Offset = "0x83B55D0", VA = "0x1883B6BD0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private const byte WDDYAQUFKUO = 255;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TransformAccessArray BFGEPSSOBDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> TAXZDTRHOKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NativeArray<float4x4> CFREBBDHVAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NativeArray<float4> FEDQRNCEOEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private NativeArray<int> DNUCMPIXEYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NativeArray<int> CBPQXWZHDUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private BRTZTUAOXLG AHKTRGUURUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BRTZTUAOXLG EBABKOXWHEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private BRTZTUAOXLG WLQLRIODCKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BRTZTUAOXLG LPYOBMZXWDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private BRTZTUAOXLG XSAUUAFXFUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Transform DHBOWYHPVAC;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83C1F70", Offset = "0x83C0970", VA = "0x1883C1F70")]
		public UCJDTDVGEYH(int a, int b, ComputeShader c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83C19B0", Offset = "0x83C03B0", VA = "0x1883C19B0", Slot = "6")]
		protected override void ESFNYWDLEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83C1EB0", Offset = "0x83C08B0", VA = "0x1883C1EB0")]
		private void YGZTHJGHHCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83C1C70", Offset = "0x83C0670", VA = "0x1883C1C70")]
		public bool IRQQOUWAOOR(ComputeHandle a, Transform b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83C1DD0", Offset = "0x83C07D0", VA = "0x1883C1DD0")]
		public void UMXVOUZGCCM(ComputeHandle a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83C1BC0", Offset = "0x83C05C0", VA = "0x1883C1BC0")]
		public void HRWIDQFSHKZ(ComputeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83C1910", Offset = "0x83C0310", VA = "0x1883C1910", Slot = "10")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface WLNUANDGASB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeMesh Complete();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface QUDGKPDWZWS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		Hash128 PHGUSVWVUXF
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int ZLBIUKVEGRO
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int THGMVPMUQFS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NativeArray<float3> ZJSBNRYHJFC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		NativeArray<float3> WIOMBDOFSXW
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		NativeArray<float4> BLUHCXXUFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		NativeArray<int> GTLOXMQUWSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		NativeArray<float2> XOMBHIKDYYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		NativeArray<float4> CZLGDNHQVPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		int RARGHFEIVAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int RJZGPFQIWMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		int HWTPOFLOLPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool TPRCKYZBQCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void SNLVHQAMKMI();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class VXAIPOTXNUB : QUDGKPDWZWS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private WLNUANDGASB VPJENBDWBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeMesh RNUVXSOSTUS;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Hash128 PHGUSVWVUXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool ILOVGAJTPPU
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int ZLBIUKVEGRO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int THGMVPMUQFS
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private int RARDOMBWKGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NativeArray<float3> ZJSBNRYHJFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x83C3300", Offset = "0x83C1D00", VA = "0x1883C3300", Slot = "7")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public NativeArray<float3> WIOMBDOFSXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x83C3140", Offset = "0x83C1B40", VA = "0x1883C3140", Slot = "8")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NativeArray<float4> BLUHCXXUFEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x83C3370", Offset = "0x83C1D70", VA = "0x1883C3370", Slot = "9")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public NativeArray<int> GTLOXMQUWSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x83C30D0", Offset = "0x83C1AD0", VA = "0x1883C30D0", Slot = "10")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public NativeArray<float2> XOMBHIKDYYE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x83C32D0", Offset = "0x83C1CD0", VA = "0x1883C32D0", Slot = "11")]
			get
			{
				return default(NativeArray<float2>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NativeArray<float4> CZLGDNHQVPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x83C3190", Offset = "0x83C1B90", VA = "0x1883C3190", Slot = "12")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool TPRCKYZBQCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int RARGHFEIVAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x83C3030", Offset = "0x83C1A30", VA = "0x1883C3030", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int RJZGPFQIWMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83C3010", Offset = "0x83C1A10", VA = "0x1883C3010", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int HWTPOFLOLPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x83C3170", Offset = "0x83C1B70", VA = "0x1883C3170", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83C33A0", Offset = "0x83C1DA0", VA = "0x1883C33A0")]
		public VXAIPOTXNUB(Hash128 a, WLNUANDGASB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x83C31C0", Offset = "0x83C1BC0", VA = "0x1883C31C0", Slot = "16")]
		public void SNLVHQAMKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83C3040", Offset = "0x83C1A40", VA = "0x1883C3040", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
		public ComputeHandle(int index = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83B6640", Offset = "0x83B5040", VA = "0x1883B6640", Slot = "4")]
		public bool Equals(ComputeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83B6690", Offset = "0x83B5090", VA = "0x1883B6690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83B6760", Offset = "0x83B5160", VA = "0x1883B6760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class WYAUWVBMMFQ : PUTREPBFNZE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool HENRRSKACVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private QUDGKPDWZWS MDRBSKVOPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private List<ComputeHandle> SFXVORZZHVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private List<ComputeHandle> IVUXJCRSPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<ComputeHandle> RGIYLFSYWTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<int, uint> JFRPCVILRZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int BPEUEPXANIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int DGPATQJYIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int KAEDUPXXXPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int JKDYROJONCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int OADSWXLYYSC;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x83C4F70", Offset = "0x83C3970", VA = "0x1883C4F70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x83C4F30", Offset = "0x83C3930", VA = "0x1883C4F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool SZJCBZAVCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool XIDSMIQEVRZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB50300", Offset = "0xB4ED00", VA = "0x180B50300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xB50310", Offset = "0xB4ED10", VA = "0x180B50310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool NBIOTFXGXWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x285BFE0", Offset = "0x285A9E0", VA = "0x18285BFE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2598FD0", Offset = "0x25979D0", VA = "0x182598FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float VOBGMNFQLCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4E0", Offset = "0xDD8EE0", VA = "0x180DDA4E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xDDA500", Offset = "0xDD8F00", VA = "0x180DDA500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83C5020", Offset = "0x83C3A20", VA = "0x1883C5020")]
		public WYAUWVBMMFQ(QUDGKPDWZWS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83C4380", Offset = "0x83C2D80", VA = "0x1883C4380")]
		private void QLJTWHZBYXY(QUDGKPDWZWS a, int b, int c, int d, int e, VertexData f, float g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83C3E20", Offset = "0x83C2820", VA = "0x1883C3E20")]
		private void GNRCCETBCGI(QUDGKPDWZWS a, int b, int c, uint3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83C40E0", Offset = "0x83C2AE0", VA = "0x1883C40E0")]
		private bool JYJXSMJLOLY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83C3420", Offset = "0x83C1E20", VA = "0x1883C3420", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83C4EB0", Offset = "0x83C38B0", VA = "0x1883C4EB0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83C4860", Offset = "0x83C3260", VA = "0x1883C4860", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83C3DC0", Offset = "0x83C27C0", VA = "0x1883C3DC0")]
		public void ZAPPGTEEEZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83C3DC0", Offset = "0x83C27C0", VA = "0x1883C3DC0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface PUTREPBFNZE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool NBIOTFXGXWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool BNNDFGNXEUZ
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
	public class MVPJOCSIAPN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly float OZPYYKKAHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Dictionary<Hash128, WYAUWVBMMFQ> BSUQOYHDHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Dictionary<Hash128, YXWQHLDRVEC> VUVZPMFEYTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Queue<PUTREPBFNZE> CJYVSYRTPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Queue<PUTREPBFNZE> JPSWFXPFMTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Queue<PUTREPBFNZE> MRBIWCQBCWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int FMGIZSXAPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int RZVXHOQMFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private float YRQUMFXECJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool DXCGYXGRTUM;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool LMVCCNBHTBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDD0", Offset = "0x16EE7D0", VA = "0x1816EFDD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDE0", Offset = "0x16EE7E0", VA = "0x1816EFDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool WWSKWNYHMYB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x83B7940", Offset = "0x83B6340", VA = "0x1883B7940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string XKLAIQWSEFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x83B8630", Offset = "0x83B7030", VA = "0x1883B8630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83B8620", Offset = "0x83B7020", VA = "0x1883B8620")]
		public void YFPHQGCJHXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x217E960", Offset = "0x217D360", VA = "0x18217E960")]
		public void RVUKBLMUKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83B8A10", Offset = "0x83B7410", VA = "0x1883B8A10")]
		public MVPJOCSIAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83B7EA0", Offset = "0x83B68A0", VA = "0x1883B7EA0")]
		public PRTCQWAIIGM JIBLBJTHOBM(ZZKLHWPVANX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83B7FC0", Offset = "0x83B69C0", VA = "0x1883B7FC0")]
		public YXWQHLDRVEC JIBLBJTHOBM(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83B7B70", Offset = "0x83B6570", VA = "0x1883B7B70")]
		public bool IDOKGAIXHKW(Hash128 a, [Out] WYAUWVBMMFQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83B7BE0", Offset = "0x83B65E0", VA = "0x1883B7BE0")]
		public WYAUWVBMMFQ JIBLBJTHOBM(QUDGKPDWZWS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83B7B50", Offset = "0x83B6550", VA = "0x1883B7B50")]
		private void GJBMSLNOKHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83B80F0", Offset = "0x83B6AF0", VA = "0x1883B80F0")]
		private bool LDERBUJJDXA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83B8170", Offset = "0x83B6B70", VA = "0x1883B8170")]
		public void SNLVHQAMKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A40", Offset = "0x83B6440", VA = "0x1883B7A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83B7990", Offset = "0x83B6390", VA = "0x1883B7990")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class COFGIRASGXG : EIQLMDTWFPJ<ObjectInfo, ObjectInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83B5E90", Offset = "0x83B4890", VA = "0x1883B5E90")]
		public COFGIRASGXG(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class JSODBDXTKZU : EIQLMDTWFPJ<ClusterMaterial, ClusterMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x83B6CA0", Offset = "0x83B56A0", VA = "0x1883B6CA0")]
		public JSODBDXTKZU(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ZEHXPKKUFHT : EIQLMDTWFPJ<ClusterInfo, ClusterInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x83C58D0", Offset = "0x83C42D0", VA = "0x1883C58D0")]
		public ZEHXPKKUFHT(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class XFTYCVPLXJZ : EIQLMDTWFPJ<ClusterVertexData, ClusterCompressedVertexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83C5160", Offset = "0x83C3B60", VA = "0x1883C5160")]
		public XFTYCVPLXJZ(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RBZZUPIWOSP : EIQLMDTWFPJ<ClusterIndexData, ClusterIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83BA400", Offset = "0x83B8E00", VA = "0x1883BA400")]
		public RBZZUPIWOSP(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class VOPZJLDTZMF : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private RenderPipeline AVASEVJVCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool RDUVLXRTMBW;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static bool XRNZICEWCOK;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83C2700", Offset = "0x83C1100", VA = "0x1883C2700")]
		public VOPZJLDTZMF(RenderPipeline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83C25E0", Offset = "0x83C0FE0", VA = "0x1883C25E0", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83C2250", Offset = "0x83C0C50", VA = "0x1883C2250", Slot = "6")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x83C2290", Offset = "0x83C0C90", VA = "0x1883C2290", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class TPGEXRWRCMW
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
			[Cpp2IlInjected.Address(RVA = "0x83BA560", Offset = "0x83B8F60", VA = "0x1883BA560")]
			public RenderPassContext(string passName, ScriptableRenderContext currentContext, [Out] CommandBuffer externCmd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x83BA4B0", Offset = "0x83B8EB0", VA = "0x1883BA4B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83C15D0", Offset = "0x83BFFD0", VA = "0x1883C15D0")]
		public static bool NWLBYGMWVWG(RenderingData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83C16B0", Offset = "0x83C00B0", VA = "0x1883C16B0")]
		public static void ZGUDONCXDZU(CommandBuffer a, ScriptableRenderContext b, ShadowDrawingSettings c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RenderPipeline : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class OFNWHICEWTE
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly int RNFKMPQPLSQ;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly int IMTMDQULKFT;
		}

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static GHJXPGMZRIR<ClusterReference> AYUZJYPBSNP;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static GHJXPGMZRIR<uint> BGGIGORVUPG;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static BRTZTUAOXLG RIOKCMGETJU;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static ComputeBuffer GQCOLYYPMSU;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static List<KWOWLQVZWOG> TJYWZYDXQAJ;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int FPURLYCVMYF;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int WBPLVNNQEDT;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int ZJBWSKQYKYC;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int NQAKSOQDVAS;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static int[] NWUVPXXLOCM;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Material[] NYZHUANEZFV;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static SBOYVNJRWHE[][] HECBCGPJPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Plane[] MUGWMYFVUHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int DHTLLMVTFRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int DQKHCDNEBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int MOORYPROAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int AQJSMATAUKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int ERZOKPYSNSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int ISMJIRRGMPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int YIJYHGLOSQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int MBVFZEZRNSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int ZPRZHMBIERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int PNZXPKLYMPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int PSYNJAVSZIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int NYMWQWDDDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int ITSSDFANOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int MRMKUKPXSYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int ZZFTZTJBSWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int VRNMJLKUGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int OYLQKFJIQPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int MDKTUZQVLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private float[] PPJSYMNNIZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private MVPJOCSIAPN SOXEDDAUVZV;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static bool FGQUDCOSCRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x83BF5A0", Offset = "0x83BDFA0", VA = "0x1883BF5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x83BA840", Offset = "0x83B9240", VA = "0x1883BA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static bool TALAZIXDJEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x83BA730", Offset = "0x83B9130", VA = "0x1883BA730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x83BCFE0", Offset = "0x83BB9E0", VA = "0x1883BCFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static MClusterData DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x83BA6E0", Offset = "0x83B90E0", VA = "0x1883BA6E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x83BF3A0", Offset = "0x83BDDA0", VA = "0x1883BF3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static UCJDTDVGEYH UCJDTDVGEYH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x83BC070", Offset = "0x83BAA70", VA = "0x1883BC070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x83BC0C0", Offset = "0x83BAAC0", VA = "0x1883BC0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static COFGIRASGXG COFGIRASGXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x83BBF40", Offset = "0x83BA940", VA = "0x1883BBF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x83BF410", Offset = "0x83BDE10", VA = "0x1883BF410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static JSODBDXTKZU JSODBDXTKZU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x83BA8A0", Offset = "0x83B92A0", VA = "0x1883BA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x83BEBC0", Offset = "0x83BD5C0", VA = "0x1883BEBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static ZEHXPKKUFHT ZEHXPKKUFHT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x83BE810", Offset = "0x83BD210", VA = "0x1883BE810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x83BFC20", Offset = "0x83BE620", VA = "0x1883BFC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static XFTYCVPLXJZ XFTYCVPLXJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x83BFBD0", Offset = "0x83BE5D0", VA = "0x1883BFBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x83BAEB0", Offset = "0x83B98B0", VA = "0x1883BAEB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static RBZZUPIWOSP RBZZUPIWOSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x83BF4D0", Offset = "0x83BDED0", VA = "0x1883BF4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x83BF250", Offset = "0x83BDC50", VA = "0x1883BF250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static Material ODNUZHFDENP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x83BF5F0", Offset = "0x83BDFF0", VA = "0x1883BF5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x83BF520", Offset = "0x83BDF20", VA = "0x1883BF520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static Material RGUWHIXOUWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x83BE720", Offset = "0x83BD120", VA = "0x1883BE720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x83BF640", Offset = "0x83BE040", VA = "0x1883BF640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static Material YJCKPJFJEZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x83BEB70", Offset = "0x83BD570", VA = "0x1883BEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x83BA670", Offset = "0x83B9070", VA = "0x1883BA670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static Material KUPLFEHZJHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x83BFC90", Offset = "0x83BE690", VA = "0x1883BFC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x83BBF90", Offset = "0x83BA990", VA = "0x1883BBF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static bool XBOVCXUJFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x83BE270", Offset = "0x83BCC70", VA = "0x1883BE270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x83BA780", Offset = "0x83B9180", VA = "0x1883BA780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool WWSKWNYHMYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x83BA7E0", Offset = "0x83B91E0", VA = "0x1883BA7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string XKLAIQWSEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x83C0900", Offset = "0x83BF300", VA = "0x1883C0900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83C1030", Offset = "0x83BFA30", VA = "0x1883C1030")]
		internal RenderPipeline([Optional] MClusterData dataData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x83BD040", Offset = "0x83BBA40", VA = "0x1883BD040")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83BFB30", Offset = "0x83BE530", VA = "0x1883BFB30")]
		public void VFYFXUJHKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83BF590", Offset = "0x83BDF90", VA = "0x1883BF590")]
		public void SVJWJJYGOVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83BE770", Offset = "0x83BD170", VA = "0x1883BE770")]
		public bool LKLQKEQFVCH(Hash128 a, [Out] WYAUWVBMMFQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83BE2C0", Offset = "0x83BCCC0", VA = "0x1883BE2C0")]
		public WYAUWVBMMFQ JIBLBJTHOBM(QUDGKPDWZWS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83BE530", Offset = "0x83BCF30", VA = "0x1883BE530")]
		public YXWQHLDRVEC JIBLBJTHOBM(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83BE380", Offset = "0x83BCD80", VA = "0x1883BE380")]
		public PRTCQWAIIGM JIBLBJTHOBM(ZZKLHWPVANX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83BF480", Offset = "0x83BDE80", VA = "0x1883BF480")]
		public void Remove(PUTREPBFNZE element)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x83BF170", Offset = "0x83BDB70", VA = "0x1883BF170")]
		public static void OMVHMVZFTZW(CullingLayer a, SBOYVNJRWHE[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83BC710", Offset = "0x83BB110", VA = "0x1883BC710")]
		private void HPDXSDRLUIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83BFCE0", Offset = "0x83BE6E0", VA = "0x1883BFCE0")]
		private static void WQWHPOYCXGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x83BE860", Offset = "0x83BD260", VA = "0x1883BE860")]
		public void MPLIPNGXUFE(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83BA8F0", Offset = "0x83B92F0", VA = "0x1883BA8F0")]
		public void CPBEMTZACJM([Optional] ScriptableRenderContext? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83BAC60", Offset = "0x83B9660", VA = "0x1883BAC60")]
		public void DKZWXPCBUZX(CommandBuffer a, ShadowSplitData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83BAAC0", Offset = "0x83B94C0", VA = "0x1883BAAC0")]
		public void DKZWXPCBUZX(CommandBuffer a, CameraData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83BEC30", Offset = "0x83BD630", VA = "0x1883BEC30")]
		public void OKOLQIVXNXK(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83BC000", Offset = "0x83BAA00", VA = "0x1883BC000")]
		public void FUORUTAYTMJ(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83BF6B0", Offset = "0x83BE0B0", VA = "0x1883BF6B0")]
		public void VDCYPIYLHMA(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x83BC130", Offset = "0x83BAB30", VA = "0x1883BC130")]
		public void HASRHDBMONT(CommandBuffer a, CullingLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83BF2C0", Offset = "0x83BDCC0", VA = "0x1883BF2C0")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83BAF20", Offset = "0x83B9920", VA = "0x1883BAF20")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83BBE30", Offset = "0x83BA830", VA = "0x1883BBE30", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class FEARPASVDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27CD4E0", Offset = "0x27CBEE0", VA = "0x1827CD4E0")]
		public static int VMPFQMRORQP(int a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x83B6610", Offset = "0x83B5010", VA = "0x1883B6610")]
		public ClusterTransform(float4x4 rotationTranslation, float4 scaleExtent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x83B64B0", Offset = "0x83B4EB0", VA = "0x1883B64B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B63E0", Offset = "0x83B4DE0", VA = "0x1883B63E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B6410", Offset = "0x83B4E10", VA = "0x1883B6410", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B6340", Offset = "0x83B4D40", VA = "0x1883B6340", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B8DC0", Offset = "0x83B77C0", VA = "0x1883B8DC0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B5F40", Offset = "0x83B4940", VA = "0x1883B5F40", Slot = "3")]
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
internal class __JobReflectionRegistrationOutput__2487265901
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x83C5990", Offset = "0x83C4390", VA = "0x1883C5990")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x83C5980", Offset = "0x83C4380", VA = "0x1883C5980")]
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
