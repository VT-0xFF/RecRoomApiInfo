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
		[Cpp2IlInjected.Address(RVA = "0x8423140", Offset = "0x8422340", VA = "0x188423140", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class DEQHLQXGUON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly LayoutRect JJAOXYXJRYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int CVTCGWIBNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly YAIPLWZSDMB PZJPRJMEHGN;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8420AD0", Offset = "0x841FCD0", VA = "0x188420AD0")]
		public DEQHLQXGUON(LayoutRect a, YAIPLWZSDMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84209B0", Offset = "0x841FBB0", VA = "0x1884209B0")]
		public bool VLMXPUPHUVX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8420950", Offset = "0x841FB50", VA = "0x188420950")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class MeshBuffer : VQFIEDBPVCZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate Bounds BoundsGetterDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int RUQFODOSBSH = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public QuadVertex[] QFTDPCWYLIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int LCZZYYMYGZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ushort[] JLQMXHMWDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int BEIWTOMXHSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly BoundsGetterDelegate NGLCKAAZSCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Bounds TIODUXWXZTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MeshBufferDirtyStates KMZHYCTCFBL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MeshBuffer KCLUQAIPGRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x84258A0", Offset = "0x8424AA0", VA = "0x1884258A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string HMDNKGXRCYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xABCB70", Offset = "0xABBD70", VA = "0x180ABCB70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xABC980", Offset = "0xABBB80", VA = "0x180ABC980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public VQFIEDBPVCZ.GetMeshBufferDelegate NCXOQMSNOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xABC970", Offset = "0xABBB70", VA = "0x180ABC970", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8425D50", Offset = "0x8424F50", VA = "0x188425D50")]
		public MeshBuffer(BoundsGetterDelegate boundsGetter, int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8425D40", Offset = "0x8424F40", VA = "0x188425D40")]
		public MeshBuffer(int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8425CD0", Offset = "0x8424ED0", VA = "0x188425CD0", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8420850", Offset = "0x841FA50", VA = "0x188420850")]
		public void SQJTKXQBJYB(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84257F0", Offset = "0x84249F0", VA = "0x1884257F0")]
		public void JTIZLEBVHBO(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8425940", Offset = "0x8424B40", VA = "0x188425940")]
		public void SXOPTUOBNBE(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84257E0", Offset = "0x84249E0", VA = "0x1884257E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x38DF1E0", Offset = "0x38DE3E0", VA = "0x1838DF1E0")]
		private static void OOSSYRJYLRD<a>(a[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84259F0", Offset = "0x8424BF0", VA = "0x1884259F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84258F0", Offset = "0x8424AF0", VA = "0x1884258F0")]
		[CompilerGenerated]
		private Bounds PLAMBECXWXG()
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
	public static class FSIEMEMPENY
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly float3[] WHXZXGFKKRJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly float2[] BUXWSBZRRST;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8422090", Offset = "0x8421290", VA = "0x188422090")]
		public static void WWDSDNQUERA(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84221A0", Offset = "0x84213A0", VA = "0x1884221A0")]
		public static void WWDSDNQUERA(this MeshBuffer a, [In] int vertexBufferIdx, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8421F30", Offset = "0x8421130", VA = "0x188421F30")]
		public static void FACZJWZXURR(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84222E0", Offset = "0x84214E0", VA = "0x1884222E0")]
		public static void ZLSKPILPRZG(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8421FC0", Offset = "0x84211C0", VA = "0x188421FC0")]
		public static void FJZRPQMXERO(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] int quadIndexBufferIdx, [In] bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x841F810", Offset = "0x841EA10", VA = "0x18841F810")]
		public static void OIOIHGPZWRA(this MeshBuffer a, [In] int targetVertexBufferIdx, [In] int targetIndexBufferIdx, MeshBuffer b, [In] int sourceVertexBufferIdx, [In] int sourceIndexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EBRZNOUXXTL
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log NNZNHUAAUPX;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly int HENUJZELQOW;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static ProfilerMarker MSLMLRBBRQI;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static ProfilerMarker KTBCICEKEIT;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static ProfilerMarker KOEFFSKOMFD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static ProfilerMarker VJGSZACEOQZ;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static ProfilerMarker CMYHFTCPYLA;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static ushort[] RNXLDCEDPTI;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly SubMeshDescriptor[] HJBPOXCBKFT;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly MeshBuffer[] XBGHFOEGGOH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8420B40", Offset = "0x841FD40", VA = "0x188420B40")]
		public static MeshBufferDirtyStates EEVIYZTTVBI([In] Mesh mesh, [In] ReadOnlySpan<MeshBuffer> buffers, MeshBufferDirtyStates a = MeshBufferDirtyStates.Clean)
		{
			return default(MeshBufferDirtyStates);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8421530", Offset = "0x8420730", VA = "0x188421530")]
		private static bool KEBSGFQHSDC(this MeshBuffer a, [In] Mesh mesh, int b, int c, [In] MeshBufferDirtyStates dirtyState)
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
		private FastQuadSubMeshBuffer WTKCWADMYWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private QuadMeshManager FLARXGRWNXO;

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
		private YAIPLWZSDMB PZJPRJMEHGN;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84224E0", Offset = "0x84216E0", VA = "0x1884224E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84224B0", Offset = "0x84216B0", VA = "0x1884224B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8422710", Offset = "0x8421910", VA = "0x188422710")]
		private void TBCVEFETIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8422880", Offset = "0x8421A80", VA = "0x188422880")]
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
		private QuadMeshManager TJCVSKZJHVD;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QuadMeshManager UYPGWVWSTYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8422C80", Offset = "0x8421E80", VA = "0x188422C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8422990", Offset = "0x8421B90", VA = "0x188422990", Slot = "8")]
		protected override void EEZWVLDOLSE(OUPYUZYJXUP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8422BD0", Offset = "0x8421DD0", VA = "0x188422BD0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8422B00", Offset = "0x8421D00", VA = "0x188422B00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private void CMGNECRYXZN(OUPYUZYJXUP a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84228D0", Offset = "0x8421AD0", VA = "0x1884228D0")]
		private void BJSJYCBUBQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
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
		[Cpp2IlInjected.Address(RVA = "0x8426FE0", Offset = "0x84261E0", VA = "0x188426FE0")]
		public Quad(MeshBuffer buffer, int vertexBufferIdx, int indexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class HLFXSJJOTIZ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8422D40", Offset = "0x8421F40", VA = "0x188422D40")]
		public static void DQNKAZPDVXA(this Quad a, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8422DC0", Offset = "0x8421FC0", VA = "0x188422DC0")]
		public static void DQNKAZPDVXA(this Quad a, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8422ED0", Offset = "0x84220D0", VA = "0x188422ED0")]
		public static void FGEAXVEASBJ(this Quad a, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84230C0", Offset = "0x84222C0", VA = "0x1884230C0")]
		public static void WBSSPMPUDPS(this Quad a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8422FB0", Offset = "0x84221B0", VA = "0x188422FB0")]
		public static void MWKHSSVMYQI(this Quad a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8422E30", Offset = "0x8422030", VA = "0x188422E30")]
		public static void DWYWNETKRAK(this Quad a, Quad b)
		{
		}
	}
	[StructLayout((LayoutKind)0)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class YAIPLWZSDMB : IEquatable<YAIPLWZSDMB>
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const ushort VBLVEQPMNNJ = 0;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const int QYPDGONQOTA = 65534;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly YAIPLWZSDMB BBWFJTAPBPP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ushort FLSMGNAEYGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB5DCE0", Offset = "0xB5CEE0", VA = "0x180B5DCE0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB5DCF0", Offset = "0xB5CEF0", VA = "0x180B5DCF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public QuadMeshManager HTRPZNJYFDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8427270", Offset = "0x8426470", VA = "0x188427270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8427300", Offset = "0x8426500", VA = "0x188427300")]
		public YAIPLWZSDMB(int a, QuadMeshManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8427200", Offset = "0x8426400", VA = "0x188427200")]
		public bool TUOZJRNVFCI([Out] Quad a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84271B0", Offset = "0x84263B0", VA = "0x1884271B0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8427110", Offset = "0x8426310", VA = "0x188427110")]
		internal void GKJNFJFLAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84270B0", Offset = "0x84262B0", VA = "0x1884270B0", Slot = "4")]
		public bool Equals(YAIPLWZSDMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8426FF0", Offset = "0x84261F0", VA = "0x188426FF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8427140", Offset = "0x8426340", VA = "0x188427140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class QuadMeshManager : IDisposable, VQFIEDBPVCZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private string BVAALTLXYRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		internal readonly QuadMeshManagerConfig JDIPDVNAQQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal YAIPLWZSDMB[] OFYHKTPMROC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MeshBuffer YZWKRBENFWP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string HMDNKGXRCYX
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8426760", Offset = "0x8425960", VA = "0x188426760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int WVWOCTUFGOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC2480", Offset = "0xAC1680", VA = "0x180AC2480")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC2290", Offset = "0xAC1490", VA = "0x180AC2290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VQFIEDBPVCZ.GetMeshBufferDelegate NCXOQMSNOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABE640", Offset = "0xABD840", VA = "0x180ABE640", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8426D00", Offset = "0x8425F00", VA = "0x188426D00")]
		public QuadMeshManager(QuadMeshManagerConfig config, [Optional] MeshBuffer.BoundsGetterDelegate boundsGetter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8426F70", Offset = "0x8426170", VA = "0x188426F70")]
		public QuadMeshManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8426A40", Offset = "0x8425C40", VA = "0x188426A40", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8426470", Offset = "0x8425670", VA = "0x188426470")]
		public YAIPLWZSDMB IFHNWXMBDUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8426180", Offset = "0x8425380", VA = "0x188426180")]
		public void FJHPGTCSCJC(YAIPLWZSDMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8426740", Offset = "0x8425940", VA = "0x188426740")]
		public bool KCHCMXCJQVA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84269D0", Offset = "0x8425BD0", VA = "0x1884269D0")]
		internal bool TUOZJRNVFCI(YAIPLWZSDMB a, [Out] Quad b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8426430", Offset = "0x8425630", VA = "0x188426430")]
		internal Quad GQFOJIKUYDR(int a)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8426410", Offset = "0x8425610", VA = "0x188426410")]
		internal Quad GQFOJIKUYDR(int a, int b)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84267E0", Offset = "0x84259E0", VA = "0x1884267E0")]
		private void MBVXDUCEGNC(Quad a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8426B00", Offset = "0x8425D00", VA = "0x188426B00")]
		private void VYRYLPYUCLT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8426950", Offset = "0x8425B50", VA = "0x188426950")]
		private bool MBXSZCGAADL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84263F0", Offset = "0x84255F0", VA = "0x1884263F0")]
		private static int FNEOXCUDZMJ(YAIPLWZSDMB a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2382120", Offset = "0x2381320", VA = "0x182382120")]
		private static ushort NYBOQZAOVWP(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84260C0", Offset = "0x84252C0", VA = "0x1884260C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8426AB0", Offset = "0x8425CB0", VA = "0x188426AB0")]
		[CompilerGenerated]
		private Bounds UUUUCGDVSZZ()
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
		[Cpp2IlInjected.Address(RVA = "0x8425F50", Offset = "0x8425150", VA = "0x188425F50")]
		public QuadMeshManagerConfig JKJEPYHQGRI()
		{
			return default(QuadMeshManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8425FF0", Offset = "0x84251F0", VA = "0x188425FF0")]
		[CompilerGenerated]
		internal static void LNTRZBUDELX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8426000", Offset = "0x8425200", VA = "0x188426000")]
		[CompilerGenerated]
		internal static void VSUWCCOTUME(int a, int b)
		{
		}
	}
}
namespace RecRoom.FastMesh.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface OUPYUZYJXUP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMeshBufferSource(VQFIEDBPVCZ source);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveMeshBufferSource(VQFIEDBPVCZ source);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetMeshBufferSourceRenderOrder(VQFIEDBPVCZ source, int renderOrder);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetMeshBufferSourceMaterial(VQFIEDBPVCZ source, Material material);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MarkBufferSourceDirty(VQFIEDBPVCZ source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface VQFIEDBPVCZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate bool GetMeshBufferDelegate(VQFIEDBPVCZ source);

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string HMDNKGXRCYX
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
	public class MeshBufferRenderer : MonoBehaviour, OUPYUZYJXUP
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
		private class FCOAEHGEXFY : IComparer<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private IReadOnlyList<VWSUGAOINMV> PXQCSWQVQSK;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
			public void MPSAKZMSCGK(IReadOnlyList<VWSUGAOINMV> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8421E10", Offset = "0x8421010", VA = "0x188421E10", Slot = "4")]
			public int Compare(int lhsIdx, int rhsIdx)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public FCOAEHGEXFY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class VWSUGAOINMV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int NVTBJQJEABK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Material CPNXDXPYGOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MeshBuffer RKIBDXIUUTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public bool UPOCGKHNQHU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool YHJDWAYQXZG;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public VWSUGAOINMV()
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
		private static readonly Log NNZNHUAAUPX;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string FJFHCFWVZIS = "MeshBufferRenderer";

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
		private const int ISTGFRJTNFD = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Shader FallbackMaterialShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Mesh HLFKUETYGVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Material PUQDJRGSEGA;

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
		private DirtyStates CVFSRCXLGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal readonly List<VQFIEDBPVCZ> MZUDHAAVQWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly List<VWSUGAOINMV> QJFXYTZBJES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal int MJBTTXGJIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal int[] CWJBVZZATTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Material[] XAGGJGTOASO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MeshBuffer[] YUWISQCOJHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly FCOAEHGEXFY RABAJWTJHOW;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal DirtyStates KCMXKEECYKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x10C5A50", Offset = "0x10C4C50", VA = "0x1810C5A50")]
			get
			{
				return default(DirtyStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x25CB150", Offset = "0x25CA350", VA = "0x1825CB150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8424E30", Offset = "0x8424030", VA = "0x188424E30", Slot = "4")]
		public void SetMeshBufferSource(VQFIEDBPVCZ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84249C0", Offset = "0x8423BC0", VA = "0x1884249C0", Slot = "5")]
		public void RemoveMeshBufferSource(VQFIEDBPVCZ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8424D80", Offset = "0x8423F80", VA = "0x188424D80", Slot = "6")]
		public void SetMeshBufferSourceRenderOrder(VQFIEDBPVCZ source, int renderOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8424F20", Offset = "0x8424120", VA = "0x188424F20", Slot = "9")]
		public bool TryGetMeshBufferSourceRenderOrder(VQFIEDBPVCZ source, [Out] int renderOrder)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8424C80", Offset = "0x8423E80", VA = "0x188424C80", Slot = "7")]
		public void SetMeshBufferSourceMaterial(VQFIEDBPVCZ source, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8424E40", Offset = "0x8424040", VA = "0x188424E40", Slot = "10")]
		public bool TryGetMeshBufferSourceMaterial(VQFIEDBPVCZ source, [Out] Material material)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8424320", Offset = "0x8423520", VA = "0x188424320", Slot = "8")]
		public void MarkBufferSourceDirty(VQFIEDBPVCZ source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8423200", Offset = "0x8422400", VA = "0x188423200")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8424510", Offset = "0x8423710", VA = "0x188424510")]
		protected void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8424500", Offset = "0x8423700", VA = "0x188424500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8424470", Offset = "0x8423670", VA = "0x188424470")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84241F0", Offset = "0x84233F0", VA = "0x1884241F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8423E50", Offset = "0x8423050", VA = "0x188423E50")]
		private void KSAWWKZRKRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8423320", Offset = "0x8422520", VA = "0x188423320")]
		private void BACXLYXBVBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8423790", Offset = "0x8422990", VA = "0x188423790")]
		private void CZOYTTZYYAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8424A80", Offset = "0x8423C80", VA = "0x188424A80")]
		private void SVQISVLEGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8423CD0", Offset = "0x8422ED0", VA = "0x188423CD0")]
		private bool FEJRRLWECVM(VQFIEDBPVCZ a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84203B0", Offset = "0x841F5B0", VA = "0x1884203B0")]
		private int PGQMTNELOPV(VQFIEDBPVCZ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84246A0", Offset = "0x84238A0", VA = "0x1884246A0")]
		private int PTUZDYYGCYZ(VQFIEDBPVCZ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84243F0", Offset = "0x84235F0", VA = "0x1884243F0")]
		private void OVZIMISSFWO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8423D40", Offset = "0x8422F40", VA = "0x188423D40")]
		private void GTIBNMKOKCW(int a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84240D0", Offset = "0x84232D0", VA = "0x1884240D0")]
		private void LQGUKVHOUSE(int a, MeshBuffer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84239B0", Offset = "0x8422BB0", VA = "0x1884239B0")]
		private void DHOQIPGHBGR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8424180", Offset = "0x8423380", VA = "0x188424180")]
		private void LWVQZIKGNDO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8424820", Offset = "0x8423A20", VA = "0x188424820")]
		private void QUIZMEDOXGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8423A20", Offset = "0x8422C20", VA = "0x188423A20")]
		private void EJNIOPXLOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8424FE0", Offset = "0x84241E0", VA = "0x188424FE0")]
		private bool XDAQFIYBCZR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84243D0", Offset = "0x84235D0", VA = "0x1884243D0")]
		private static Material[] OLJCYWTDHQZ(MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8423E30", Offset = "0x8423030", VA = "0x188423E30")]
		private static void HOGTGLCMDLX(MeshRenderer a, Material[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8424040", Offset = "0x8423240", VA = "0x188424040")]
		private static void KYUKYQZFZLE(MeshFilter a, Mesh b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8424620", Offset = "0x8423820", VA = "0x188424620")]
		private static void PQJPLPWHPZT(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8425260", Offset = "0x8424460", VA = "0x188425260")]
		public MeshBufferRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x38DEEE0", Offset = "0x38DE0E0", VA = "0x1838DEEE0")]
		[CompilerGenerated]
		private a EINONJNNXNT<a>(RenderComponents a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x38DF010", Offset = "0x38DE210", VA = "0x1838DF010")]
		[CompilerGenerated]
		private b SHUGKPPQYKO<b>(b a, RenderComponents b, <>c__DisplayClass57_0 c) where b : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	public abstract class MeshBufferSource : MonoBehaviour, VQFIEDBPVCZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual VQFIEDBPVCZ.GetMeshBufferDelegate NCXOQMSNOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OUPYUZYJXUP MFEHLDSKFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAB8170", Offset = "0xAB7370", VA = "0x180AB8170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ZMBRAKMEPPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB1BF50", Offset = "0xB1B150", VA = "0x180B1BF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB1C780", Offset = "0xB1B980", VA = "0x180B1C780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IXOPIISZWLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCEB500", Offset = "0xCEA700", VA = "0x180CEB500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD31830", Offset = "0xD30A30", VA = "0x180D31830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void EEZWVLDOLSE(OUPYUZYJXUP a);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84253F0", Offset = "0x84245F0", VA = "0x1884253F0")]
		[Conditional("UNITY_EDITOR")]
		protected void ATQRPZQNTLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8425640", Offset = "0x8424840", VA = "0x188425640")]
		public void MarkSubMeshDataDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8425710", Offset = "0x8424910", VA = "0x188425710", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84256A0", Offset = "0x84248A0", VA = "0x1884256A0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8425490", Offset = "0x8424690", VA = "0x188425490")]
		protected bool EEZWVLDOLSE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8425780", Offset = "0x8424980", VA = "0x188425780", Slot = "12")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8425790", Offset = "0x8424990", VA = "0x188425790")]
		protected static void PQJPLPWHPZT(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		protected MeshBufferSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB97C50", Offset = "0xB96E50", VA = "0x180B97C50", Slot = "4")]
		private string SBMJFWKIPOB()
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
