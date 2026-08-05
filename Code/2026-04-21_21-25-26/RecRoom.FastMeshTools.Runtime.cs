using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_FastMeshTools_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99B7930", Offset = "0x99B6330", VA = "0x1899B7930", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class PNBOMWOEIZC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly LayoutRect UUFFPXZSVAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int GHJEKYVGGYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly DRKZPAVGAPG HTARQMBDCPW;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99BA8F0", Offset = "0x99B92F0", VA = "0x1899BA8F0")]
		public PNBOMWOEIZC(LayoutRect a, DRKZPAVGAPG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99BA7D0", Offset = "0x99B91D0", VA = "0x1899BA7D0")]
		public bool ULIEKXJBDFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99BA770", Offset = "0x99B9170", VA = "0x1899BA770")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class MeshBuffer : HOVKSWBPVOW
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate Bounds BoundsGetterDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int QVPPPRLNIYM = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public QuadVertex[] JEHWUDSVMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int NIBUYFJGCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ushort[] HCZZXOYKDRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int DQMBFWAHLAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly BoundsGetterDelegate ONPZNEHZQCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Bounds PWIOOGNMKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MeshBufferDirtyStates IMQJAYULTJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MeshBuffer EEASTUVHTQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99BA010", Offset = "0x99B8A10", VA = "0x1899BA010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string TRYGGLEORZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HOVKSWBPVOW.GetMeshBufferDelegate ECGWWKWSSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99BA580", Offset = "0x99B8F80", VA = "0x1899BA580")]
		public MeshBuffer(BoundsGetterDelegate boundsGetter, int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99BA570", Offset = "0x99B8F70", VA = "0x1899BA570")]
		public MeshBuffer(int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99BA4B0", Offset = "0x99B8EB0", VA = "0x1899BA4B0", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99B4B50", Offset = "0x99B3550", VA = "0x1899B4B50")]
		public void LHCJUJEKWQU(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99BA060", Offset = "0x99B8A60", VA = "0x1899BA060")]
		public void PEGFBZNBYIF(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99BA110", Offset = "0x99B8B10", VA = "0x1899BA110")]
		public void TWZUQQMHJQV(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99BA000", Offset = "0x99B8A00", VA = "0x1899BA000")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DDE0", Offset = "0x3D3C7E0", VA = "0x183D3DDE0")]
		private static void HDILYGKKAWU<a>(a[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99BA1C0", Offset = "0x99B8BC0", VA = "0x1899BA1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99BA520", Offset = "0x99B8F20", VA = "0x1899BA520")]
		[CompilerGenerated]
		private Bounds ZTHFEMPTIMJ()
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum MeshBufferDirtyStates : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Clean = 0,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		DirtyVertices = 1,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		DirtyIndices = 2,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		DirtyBounds = 4,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		MarkedForRewrite = 8,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		DirtyVisibility = 6,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		DirtyVertexPositions = 5,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		DirtyAll = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class GBDJWDBQQYP
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly float3[] EHUTLEFSOQS;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly float2[] SULZPUNVIQG;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99B5CE0", Offset = "0x99B46E0", VA = "0x1899B5CE0")]
		public static void DZKKEBIYMNH(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99B5DF0", Offset = "0x99B47F0", VA = "0x1899B5DF0")]
		public static void DZKKEBIYMNH(this MeshBuffer a, [In] int vertexBufferIdx, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99B5C50", Offset = "0x99B4650", VA = "0x1899B5C50")]
		public static void DTEBOUIMBYC(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99B6000", Offset = "0x99B4A00", VA = "0x1899B6000")]
		public static void TJMMKOPYOMJ(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99B5F30", Offset = "0x99B4930", VA = "0x1899B5F30")]
		public static void QCOPXWQIONZ(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] int quadIndexBufferIdx, [In] bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99B37F0", Offset = "0x99B21F0", VA = "0x1899B37F0")]
		public static void DZLWADKIVOH(this MeshBuffer a, [In] int targetVertexBufferIdx, [In] int targetIndexBufferIdx, MeshBuffer b, [In] int sourceVertexBufferIdx, [In] int sourceIndexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KUBSDTODCVM
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log WMZWNZHGHQO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly int OZCTQBKNYDJ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static ProfilerMarker WQDQTUWKHEZ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static ProfilerMarker UCDLXCNQMUG;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static ProfilerMarker DBQRLZAIQFA;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static ProfilerMarker KWSNAJNFVDS;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static ProfilerMarker PLJNQSVKWFL;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static ushort[] WYFOANJNJXR;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly SubMeshDescriptor[] QGXKDCHSYPA;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly MeshBuffer[] BXEEGXNBDJK;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99B6C00", Offset = "0x99B5600", VA = "0x1899B6C00")]
		public static MeshBufferDirtyStates QLWJFDPSNJR([In] Mesh mesh, [In] ReadOnlySpan<MeshBuffer> buffers, MeshBufferDirtyStates a = MeshBufferDirtyStates.Clean)
		{
			return default(MeshBufferDirtyStates);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99B65F0", Offset = "0x99B4FF0", VA = "0x1899B65F0")]
		private static bool IBUFYGDSVAX(this MeshBuffer a, [In] Mesh mesh, int b, int c, [In] MeshBufferDirtyStates dirtyState)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(FastQuadSubMeshBuffer))]
	public class FastQuadSimpleSpan : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FastQuadSubMeshBuffer YVOCESQDVQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private QuadMeshManager JWYETEMQIMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float2 QuadSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Color32 QuadColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float2 QuadAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DRKZPAVGAPG HTARQMBDCPW;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99B5560", Offset = "0x99B3F60", VA = "0x1899B5560")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99B5530", Offset = "0x99B3F30", VA = "0x1899B5530")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99B53C0", Offset = "0x99B3DC0", VA = "0x1899B53C0")]
		private void FDEVKJWIFSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99B5790", Offset = "0x99B4190", VA = "0x1899B5790")]
		public FastQuadSimpleSpan()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FastQuadSubMeshBuffer : MeshBufferSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Header("Fast Quad Config")]
		public Material QuadMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private QuadMeshManager RAXCLREGDFS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QuadMeshManager ZEUNSHWVCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99B5B90", Offset = "0x99B4590", VA = "0x1899B5B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99B57E0", Offset = "0x99B41E0", VA = "0x1899B57E0", Slot = "8")]
		protected override void BUPYOOSSEZL(CCXDQBYQPIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99B5AE0", Offset = "0x99B44E0", VA = "0x1899B5AE0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99B5950", Offset = "0x99B4350", VA = "0x1899B5950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void GVDYQWRBGHQ(CCXDQBYQPIY a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99B5A20", Offset = "0x99B4420", VA = "0x1899B5A20")]
		private void RCLCXWKDXCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public FastQuadSubMeshBuffer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly ref struct Quad
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal readonly MeshBuffer Buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal readonly int VertexBufferIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal readonly int IndexBufferIdx;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99BBA00", Offset = "0x99BA400", VA = "0x1899BBA00")]
		public Quad(MeshBuffer buffer, int vertexBufferIdx, int indexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class GJKXRCHGOSE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99B6260", Offset = "0x99B4C60", VA = "0x1899B6260")]
		public static void PVZMLYBWPTH(this Quad a, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99B61F0", Offset = "0x99B4BF0", VA = "0x1899B61F0")]
		public static void PVZMLYBWPTH(this Quad a, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99B6510", Offset = "0x99B4F10", VA = "0x1899B6510")]
		public static void ZXHLQYKLNRY(this Quad a, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99B62E0", Offset = "0x99B4CE0", VA = "0x1899B62E0")]
		public static void QEHLGKMPQUB(this Quad a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99B6360", Offset = "0x99B4D60", VA = "0x1899B6360")]
		public static void YYNJZJQXBMX(this Quad a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99B6470", Offset = "0x99B4E70", VA = "0x1899B6470")]
		public static void ZCSUMIOQFLJ(this Quad a, Quad b)
		{
		}
	}
	[StructLayout((LayoutKind)0)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class DRKZPAVGAPG : IEquatable<DRKZPAVGAPG>
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const ushort JRROKGZGWHO = 0;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const int RINMCUACNRD = 65534;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly DRKZPAVGAPG ZBBXLPRAYBY;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ushort KBNSRJPOPPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xDD78D0", Offset = "0xDD62D0", VA = "0x180DD78D0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xDD78E0", Offset = "0xDD62E0", VA = "0x180DD78E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public QuadMeshManager DKWTSYBPUTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99B5250", Offset = "0x99B3C50", VA = "0x1899B5250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99B5360", Offset = "0x99B3D60", VA = "0x1899B5360")]
		public DRKZPAVGAPG(int a, QuadMeshManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99B51E0", Offset = "0x99B3BE0", VA = "0x1899B51E0")]
		public bool IDZAJYPKGGZ([Out] Quad a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99B5290", Offset = "0x99B3C90", VA = "0x1899B5290")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99B5260", Offset = "0x99B3C60", VA = "0x1899B5260")]
		internal void PPAOWVBBJCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99B5110", Offset = "0x99B3B10", VA = "0x1899B5110", Slot = "4")]
		public bool Equals(DRKZPAVGAPG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99B5050", Offset = "0x99B3A50", VA = "0x1899B5050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99B5170", Offset = "0x99B3B70", VA = "0x1899B5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class QuadMeshManager : IDisposable, HOVKSWBPVOW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private string LVRMURGCZHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		internal readonly QuadMeshManagerConfig XQRSGSBTDXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal DRKZPAVGAPG[] VTIFBLZUHJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MeshBuffer OCEJATKPBVM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string TRYGGLEORZU
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x99BB210", Offset = "0x99B9C10", VA = "0x1899BB210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int HRWIQGHYKIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HOVKSWBPVOW.GetMeshBufferDelegate ECGWWKWSSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99BB720", Offset = "0x99BA120", VA = "0x1899BB720")]
		public QuadMeshManager(QuadMeshManagerConfig config, [Optional] MeshBuffer.BoundsGetterDelegate boundsGetter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99BB990", Offset = "0x99BA390", VA = "0x1899BB990")]
		public QuadMeshManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x99BB310", Offset = "0x99B9D10", VA = "0x1899BB310", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99BAB90", Offset = "0x99B9590", VA = "0x1899BAB90")]
		public DRKZPAVGAPG FCXGPXVWLGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99BAF40", Offset = "0x99B9940", VA = "0x1899BAF40")]
		public void KJYDUVKRMOD(DRKZPAVGAPG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99BAE60", Offset = "0x99B9860", VA = "0x1899BAE60")]
		public bool GCWMLDWWCMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99BAE80", Offset = "0x99B9880", VA = "0x1899BAE80")]
		internal bool IDZAJYPKGGZ(DRKZPAVGAPG a, [Out] Quad b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99BB1D0", Offset = "0x99B9BD0", VA = "0x1899BB1D0")]
		internal Quad KNAYMPJREAU(int a)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99BB1B0", Offset = "0x99B9BB0", VA = "0x1899BB1B0")]
		internal Quad KNAYMPJREAU(int a, int b)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99BB5A0", Offset = "0x99B9FA0", VA = "0x1899BB5A0")]
		private void ZVOPUYOOLWF(Quad a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99BB3A0", Offset = "0x99B9DA0", VA = "0x1899BB3A0")]
		private void XMRZMXLESNK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99BB290", Offset = "0x99B9C90", VA = "0x1899BB290")]
		private bool MLJIPUGIDJY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99BB380", Offset = "0x99B9D80", VA = "0x1899BB380")]
		private static int UFJBXELKWHI(DRKZPAVGAPG a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x26199D0", Offset = "0x26183D0", VA = "0x1826199D0")]
		private static ushort PDYIASVZWNS(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99BAAD0", Offset = "0x99B94D0", VA = "0x1899BAAD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99BAEF0", Offset = "0x99B98F0", VA = "0x1899BAEF0")]
		[CompilerGenerated]
		private Bounds JAEUPVCLBKO()
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct QuadMeshManagerConfig
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly QuadMeshManagerConfig DefaultConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool DefaultQuadVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Color32 DefaultQuadColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int InitialQuadCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int TotalVertexLimit;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99BA980", Offset = "0x99B9380", VA = "0x1899BA980")]
		public QuadMeshManagerConfig SJIYDVOYJDV()
		{
			return default(QuadMeshManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99BA960", Offset = "0x99B9360", VA = "0x1899BA960")]
		[CompilerGenerated]
		internal static void LEGYGDGUZUC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99BA970", Offset = "0x99B9370", VA = "0x1899BA970")]
		[CompilerGenerated]
		internal static void NRZHUZRLBIR(int a, int b)
		{
		}
	}
}
namespace RecRoom.FastMesh.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface CCXDQBYQPIY
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMeshBufferSource(HOVKSWBPVOW source);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveMeshBufferSource(HOVKSWBPVOW source);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetMeshBufferSourceRenderOrder(HOVKSWBPVOW source, int renderOrder);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetMeshBufferSourceMaterial(HOVKSWBPVOW source, Material material);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MarkBufferSourceDirty(HOVKSWBPVOW source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface HOVKSWBPVOW
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate bool GetMeshBufferDelegate(HOVKSWBPVOW source);

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string TRYGGLEORZU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class MeshBufferRenderer : MonoBehaviour, CCXDQBYQPIY
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[Flags]
		internal enum RenderComponents : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			CanvasRenderer = 1,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			MeshRenderer = 2,
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			MeshFilter = 4,
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			Canvas = 1,
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			Mesh = 6
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[Flags]
		internal enum DirtyStates : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Clean = 0,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			SourceMarkedDirty = 1,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			MeshDirty = 2,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			MaterialsDirty = 4,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			RenderSequenceDirty = 8,
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			WriteMaterials = 0xC,
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			WriteMesh = 0xA,
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			All = 0xF
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private class DCQRJEASDEP : IComparer<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private IReadOnlyList<UQOEVTLXOUK> PSNQABKWNKD;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			public void RKCBVVMJUOD(IReadOnlyList<UQOEVTLXOUK> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x99B4F30", Offset = "0x99B3930", VA = "0x1899B4F30", Slot = "4")]
			public int Compare(int lhsIdx, int rhsIdx)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public DCQRJEASDEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class UQOEVTLXOUK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int VZPMACQXXGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Material HHMSNTNERSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MeshBuffer EQGGRZNSHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public bool QPQRZSYJUMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool IGTZSZDZYBR;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public UQOEVTLXOUK()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass57_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public MeshBufferRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public RenderComponents invalidComponents;
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly Log WMZWNZHGHQO;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string NPWORGEGDYN = "MeshBufferRenderer";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static ProfilerMarker LateUpdateMarker;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static ProfilerMarker UpdateDirtyMeshBuffersMarker;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static ProfilerMarker UpdateRenderSequenceMarker;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static ProfilerMarker WriteMaterialsToRenderComponentMarker;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static ProfilerMarker WriteMeshBuffersToRenderComponentMarker;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private const int MKFSRNMGZHY = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Shader FallbackMaterialShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Mesh XJRREXWQHRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Material ZZALFWYNNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[HideInInspector]
		internal MeshRenderer MeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		[HideInInspector]
		internal MeshFilter MeshFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		[HideInInspector]
		internal CanvasRenderer CanvasRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[HideInInspector]
		internal RenderComponents CreatedComponents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[HideInInspector]
		internal RenderComponents ActiveRenderMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private DirtyStates PXLQXYSJTZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal readonly List<HOVKSWBPVOW> PYAWKTVZKZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly List<UQOEVTLXOUK> WEGMWWZLTDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal int HWWMRPDGZST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal int[] UQYADRFTTMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Material[] WQGKDCCRRAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MeshBuffer[] QDKKLHJWDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly DCQRJEASDEP BFDHJLRVERR;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal DirtyStates ICLWECAHCNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x137D840", Offset = "0x137C240", VA = "0x18137D840")]
			get
			{
				return default(DirtyStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2894160", Offset = "0x2892B60", VA = "0x182894160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99B90A0", Offset = "0x99B7AA0", VA = "0x1899B90A0", Slot = "4")]
		public void SetMeshBufferSource(HOVKSWBPVOW source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99B8E30", Offset = "0x99B7830", VA = "0x1899B8E30", Slot = "5")]
		public void RemoveMeshBufferSource(HOVKSWBPVOW source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99B8FF0", Offset = "0x99B79F0", VA = "0x1899B8FF0", Slot = "6")]
		public void SetMeshBufferSourceRenderOrder(HOVKSWBPVOW source, int renderOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99B91B0", Offset = "0x99B7BB0", VA = "0x1899B91B0", Slot = "9")]
		public bool TryGetMeshBufferSourceRenderOrder(HOVKSWBPVOW source, [Out] int renderOrder)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99B8EF0", Offset = "0x99B78F0", VA = "0x1899B8EF0", Slot = "7")]
		public void SetMeshBufferSourceMaterial(HOVKSWBPVOW source, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99B90D0", Offset = "0x99B7AD0", VA = "0x1899B90D0", Slot = "10")]
		public bool TryGetMeshBufferSourceMaterial(HOVKSWBPVOW source, [Out] Material material)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99B8090", Offset = "0x99B6A90", VA = "0x1899B8090", Slot = "8")]
		public void MarkBufferSourceDirty(HOVKSWBPVOW source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99B7CC0", Offset = "0x99B66C0", VA = "0x1899B7CC0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99B8600", Offset = "0x99B7000", VA = "0x1899B8600")]
		protected void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99B85F0", Offset = "0x99B6FF0", VA = "0x1899B85F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99B8560", Offset = "0x99B6F60", VA = "0x1899B8560")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99B7F60", Offset = "0x99B6960", VA = "0x1899B7F60")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x99B95D0", Offset = "0x99B7FD0", VA = "0x1899B95D0")]
		private void VXXMYNUNKZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99B8710", Offset = "0x99B7110", VA = "0x1899B8710")]
		private void PJIRPGULZSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99B8340", Offset = "0x99B6D40", VA = "0x1899B8340")]
		private void OKWLSDCIUYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99B8140", Offset = "0x99B6B40", VA = "0x1899B8140")]
		private void NZPLPLWFHAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99B97C0", Offset = "0x99B81C0", VA = "0x1899B97C0")]
		private bool YONBVINBFVV(HOVKSWBPVOW a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99B4420", Offset = "0x99B2E20", VA = "0x1899B4420")]
		private int LIYFSLFZHIE(HOVKSWBPVOW a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99B9360", Offset = "0x99B7D60", VA = "0x1899B9360")]
		private int VXJAAPSEJKK(HOVKSWBPVOW a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99B9270", Offset = "0x99B7C70", VA = "0x1899B9270")]
		private void UHJSRDDUQXZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99B94E0", Offset = "0x99B7EE0", VA = "0x1899B94E0")]
		private void VXMRCDVXTMN(int a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99B9830", Offset = "0x99B8230", VA = "0x1899B9830")]
		private void ZNOMYSWICZZ(int a, MeshBuffer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99B92F0", Offset = "0x99B7CF0", VA = "0x1899B92F0")]
		private void VNEIQUSEMJG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99B7EF0", Offset = "0x99B68F0", VA = "0x1899B7EF0")]
		private void LHBJVVVGEDB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99B8C90", Offset = "0x99B7690", VA = "0x1899B8C90")]
		private void RINYTEVISVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99B7A10", Offset = "0x99B6410", VA = "0x1899B7A10")]
		private void AUHZANSMHST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99B8B90", Offset = "0x99B7590", VA = "0x1899B8B90")]
		private bool PYCEXFFVLJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99B90B0", Offset = "0x99B7AB0", VA = "0x1899B90B0")]
		private static Material[] TWDDJDTPDXA(MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99B79F0", Offset = "0x99B63F0", VA = "0x1899B79F0")]
		private static void AAFVUZNGJVQ(MeshRenderer a, Material[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99B7E60", Offset = "0x99B6860", VA = "0x1899B7E60")]
		private static void HMJFBVXQONH(MeshFilter a, Mesh b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99B7DE0", Offset = "0x99B67E0", VA = "0x1899B7DE0")]
		private static void BELRWQPLJDE(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99B9A80", Offset = "0x99B8480", VA = "0x1899B9A80")]
		public MeshBufferRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DCB0", Offset = "0x3D3C6B0", VA = "0x183D3DCB0")]
		[CompilerGenerated]
		private a YBDYWLBFLQA<a>(RenderComponents a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DAE0", Offset = "0x3D3C4E0", VA = "0x183D3DAE0")]
		[CompilerGenerated]
		private b RRIXYRYVMLJ<b>(b a, RenderComponents b, <>c__DisplayClass57_0 c) where b : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	public abstract class MeshBufferSource : MonoBehaviour, HOVKSWBPVOW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual HOVKSWBPVOW.GetMeshBufferDelegate ECGWWKWSSPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CCXDQBYQPIY WUOTQYCKLCS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool XEDAJQOHDZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD6EFC0", Offset = "0xD6D9C0", VA = "0x180D6EFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZZDUDHFFSDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xF82FB0", Offset = "0xF819B0", VA = "0x180F82FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xFC24A0", Offset = "0xFC0EA0", VA = "0x180FC24A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void BUPYOOSSEZL(CCXDQBYQPIY a);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F60", Offset = "0x99B8960", VA = "0x1899B9F60")]
		[Conditional("UNITY_EDITOR")]
		protected void WDERMZCTQCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99B9E10", Offset = "0x99B8810", VA = "0x1899B9E10")]
		public void MarkSubMeshDataDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99B9EE0", Offset = "0x99B88E0", VA = "0x1899B9EE0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99B9E70", Offset = "0x99B8870", VA = "0x1899B9E70", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x99B9C60", Offset = "0x99B8660", VA = "0x1899B9C60")]
		protected bool BUPYOOSSEZL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F50", Offset = "0x99B8950", VA = "0x1899B9F50", Slot = "12")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99B9C10", Offset = "0x99B8610", VA = "0x1899B9C10")]
		protected static void BELRWQPLJDE(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		protected MeshBufferSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xE0BFD0", Offset = "0xE0A9D0", VA = "0x180E0BFD0", Slot = "4")]
		private string YGSDWDOAQCW()
		{
			return null;
		}
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
