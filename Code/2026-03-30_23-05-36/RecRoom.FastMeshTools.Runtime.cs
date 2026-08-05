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
		[Cpp2IlInjected.Address(RVA = "0x8515D40", Offset = "0x8514B40", VA = "0x188515D40", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class GKYHQWYHADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly LayoutRect FVUEDCSEAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int VNYXGHXAAYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly JJXETTTGVBT WAJXWWTWSSF;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8515840", Offset = "0x8514640", VA = "0x188515840")]
		public GKYHQWYHADP(LayoutRect a, JJXETTTGVBT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8515720", Offset = "0x8514520", VA = "0x188515720")]
		public bool QZTEXTHKDMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85156C0", Offset = "0x85144C0", VA = "0x1885156C0")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class MeshBuffer : VCQRKCLLIBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate Bounds BoundsGetterDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int AGLUOOSVBQX = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public QuadVertex[] WYVPDEVVYOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int SPQZDEGGAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ushort[] DDMFUDVAMYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int FALNFJVJDZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly BoundsGetterDelegate GTMBQBMQZVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Bounds URAIEUHXDMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MeshBufferDirtyStates WCUEVUESRIZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MeshBuffer YHLREFFXUGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8518510", Offset = "0x8517310", VA = "0x188518510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string GDOZECFRVGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAC6400", Offset = "0xAC5200", VA = "0x180AC6400", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC6120", Offset = "0xAC4F20", VA = "0x180AC6120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public VCQRKCLLIBD.GetMeshBufferDelegate VBAFYZCJWRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAC6140", Offset = "0xAC4F40", VA = "0x180AC6140", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8518970", Offset = "0x8517770", VA = "0x188518970")]
		public MeshBuffer(BoundsGetterDelegate boundsGetter, int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8518960", Offset = "0x8517760", VA = "0x188518960")]
		public MeshBuffer(int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8518840", Offset = "0x8517640", VA = "0x188518840", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8512F30", Offset = "0x8511D30", VA = "0x188512F30")]
		public void EZHJZDMUFNT(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85188B0", Offset = "0x85176B0", VA = "0x1885188B0")]
		public void XOXKZSWVNOQ(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8518410", Offset = "0x8517210", VA = "0x188518410")]
		public void FFJKUCUFOCC(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8518400", Offset = "0x8517200", VA = "0x188518400")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3928EF0", Offset = "0x3927CF0", VA = "0x183928EF0")]
		private static void KPXZYPJZNKN<a>(a[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8518560", Offset = "0x8517360", VA = "0x188518560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85184C0", Offset = "0x85172C0", VA = "0x1885184C0")]
		[CompilerGenerated]
		private Bounds FZPBDSIHZPG()
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
	public static class NSZOQKPKDRY
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly float3[] WZLNLMGUQNN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly float2[] LLEXGUFDLPN;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8518B70", Offset = "0x8517970", VA = "0x188518B70")]
		public static void AWYRZWXYHJA(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8518C80", Offset = "0x8517A80", VA = "0x188518C80")]
		public static void AWYRZWXYHJA(this MeshBuffer a, [In] int vertexBufferIdx, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8518FC0", Offset = "0x8517DC0", VA = "0x188518FC0")]
		public static void VCACRLYIQZF(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8518DC0", Offset = "0x8517BC0", VA = "0x188518DC0")]
		public static void ETCQFSBDKFO(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8518EF0", Offset = "0x8517CF0", VA = "0x188518EF0")]
		public static void GPLREYSOMKQ(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] int quadIndexBufferIdx, [In] bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8513460", Offset = "0x8512260", VA = "0x188513460")]
		public static void PHZLIEHNYJM(this MeshBuffer a, [In] int targetVertexBufferIdx, [In] int targetIndexBufferIdx, MeshBuffer b, [In] int sourceVertexBufferIdx, [In] int sourceIndexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ESVLCURHRFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log CEYCTSQHZPP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly int XEYVXNHXIMG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static ProfilerMarker ZWTDSOLGNUM;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static ProfilerMarker TCDPFAUKAXZ;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static ProfilerMarker PTJPRBHUBAN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static ProfilerMarker JPZNKVPRTQZ;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static ProfilerMarker XTRQKEKHKSO;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static ushort[] TGTPYVYEQPA;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly SubMeshDescriptor[] BINLHTYXALD;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly MeshBuffer[] QMUQAASQSMH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8513AF0", Offset = "0x85128F0", VA = "0x188513AF0")]
		public static MeshBufferDirtyStates EUHQGLJGUZY([In] Mesh mesh, [In] ReadOnlySpan<MeshBuffer> buffers, MeshBufferDirtyStates a = MeshBufferDirtyStates.Clean)
		{
			return default(MeshBufferDirtyStates);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8514500", Offset = "0x8513300", VA = "0x188514500")]
		private static bool UOOFPSAZUAM(this MeshBuffer a, [In] Mesh mesh, int b, int c, [In] MeshBufferDirtyStates dirtyState)
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
		private FastQuadSubMeshBuffer JYJAARWWIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private QuadMeshManager CUXUVNUERVG;

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
		private JJXETTTGVBT WAJXWWTWSSF;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8514FD0", Offset = "0x8513DD0", VA = "0x188514FD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8514FA0", Offset = "0x8513DA0", VA = "0x188514FA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8514E30", Offset = "0x8513C30", VA = "0x188514E30")]
		private void NTCOIZQIHYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8515200", Offset = "0x8514000", VA = "0x188515200")]
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
		private QuadMeshManager MXMNXHYFGFL;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QuadMeshManager KAIZAUPYZVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8515600", Offset = "0x8514400", VA = "0x188515600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8515250", Offset = "0x8514050", VA = "0x188515250", Slot = "8")]
		protected override void DAFFBQPVVZS(UAEJVLGMJLF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8515550", Offset = "0x8514350", VA = "0x188515550", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8515480", Offset = "0x8514280", VA = "0x188515480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private void AZZLKTHQOKD(UAEJVLGMJLF a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85153C0", Offset = "0x85141C0", VA = "0x1885153C0")]
		private void GIFNHQTECME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x851A1B0", Offset = "0x8518FB0", VA = "0x18851A1B0")]
		public Quad(MeshBuffer buffer, int vertexBufferIdx, int indexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class UAINDRFRAZP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x851A3C0", Offset = "0x85191C0", VA = "0x18851A3C0")]
		public static void NFCLIVAREOC(this Quad a, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x851A440", Offset = "0x8519240", VA = "0x18851A440")]
		public static void NFCLIVAREOC(this Quad a, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x851A2E0", Offset = "0x85190E0", VA = "0x18851A2E0")]
		public static void IKXBRSPMLML(this Quad a, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x851A260", Offset = "0x8519060", VA = "0x18851A260")]
		public static void ELMFKNEQVUU(this Quad a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x851A4B0", Offset = "0x85192B0", VA = "0x18851A4B0")]
		public static void ORQIXASNCSA(this Quad a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x851A1C0", Offset = "0x8518FC0", VA = "0x18851A1C0")]
		public static void ACIPVZYOZXA(this Quad a, Quad b)
		{
		}
	}
	[StructLayout((LayoutKind)0)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class JJXETTTGVBT : IEquatable<JJXETTTGVBT>
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const ushort IQLWHBCOIGH = 0;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const int UMEFYENVQRI = 65534;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly JJXETTTGVBT AILRFAORUPH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ushort XYEJDYYQCXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB8F0A0", Offset = "0xB8DEA0", VA = "0x180B8F0A0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB8F0B0", Offset = "0xB8DEB0", VA = "0x180B8F0B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public QuadMeshManager YWMQUBRLYGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8515AC0", Offset = "0x85148C0", VA = "0x188515AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8515BC0", Offset = "0x85149C0", VA = "0x188515BC0")]
		public JJXETTTGVBT(int a, QuadMeshManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8515AD0", Offset = "0x85148D0", VA = "0x188515AD0")]
		public bool WKZCDSGUTDK([Out] Quad a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8515A70", Offset = "0x8514870", VA = "0x188515A70")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85158B0", Offset = "0x85146B0", VA = "0x1885158B0")]
		internal void ACGDQIALKNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85158E0", Offset = "0x85146E0", VA = "0x1885158E0", Slot = "4")]
		public bool Equals(JJXETTTGVBT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8515940", Offset = "0x8514740", VA = "0x188515940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8515A00", Offset = "0x8514800", VA = "0x188515A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class QuadMeshManager : IDisposable, VCQRKCLLIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private string CFTXYDLKVCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		internal readonly QuadMeshManagerConfig SQXJXQOBPIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal JJXETTTGVBT[] QJEZHWEVRQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MeshBuffer ODKAQQUFCTV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GDOZECFRVGD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8519A80", Offset = "0x8518880", VA = "0x188519A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int CSSXPDQPEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACE310", Offset = "0xACD110", VA = "0x180ACE310")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xACE320", Offset = "0xACD120", VA = "0x180ACE320")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VCQRKCLLIBD.GetMeshBufferDelegate VBAFYZCJWRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACC890", Offset = "0xACB690", VA = "0x180ACC890", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8519ED0", Offset = "0x8518CD0", VA = "0x188519ED0")]
		public QuadMeshManager(QuadMeshManagerConfig config, [Optional] MeshBuffer.BoundsGetterDelegate boundsGetter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x851A140", Offset = "0x8518F40", VA = "0x18851A140")]
		public QuadMeshManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8519B00", Offset = "0x8518900", VA = "0x188519B00", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85193C0", Offset = "0x85181C0", VA = "0x1885193C0")]
		public JJXETTTGVBT LFVUEEHBNUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8519BD0", Offset = "0x85189D0", VA = "0x188519BD0")]
		public void UVIMKQTYFGY(JJXETTTGVBT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8519890", Offset = "0x8518690", VA = "0x188519890")]
		public bool MHJWIWSFYEW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8519E40", Offset = "0x8518C40", VA = "0x188519E40")]
		internal bool WKZCDSGUTDK(JJXETTTGVBT a, [Out] Quad b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8519B90", Offset = "0x8518990", VA = "0x188519B90")]
		internal Quad UEACYGGUWQT(int a)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8519B70", Offset = "0x8518970", VA = "0x188519B70")]
		internal Quad UEACYGGUWQT(int a, int b)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8519900", Offset = "0x8518700", VA = "0x188519900")]
		private void OQKEPGIBYWE(Quad a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8519690", Offset = "0x8518490", VA = "0x188519690")]
		private void LQVPDKVOIBD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8519340", Offset = "0x8518140", VA = "0x188519340")]
		private bool JWRIMLLNQOZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8519EB0", Offset = "0x8518CB0", VA = "0x188519EB0")]
		private static int ZZOJFWKNRHX(JJXETTTGVBT a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x239FE90", Offset = "0x239EC90", VA = "0x18239FE90")]
		private static ushort HMVWNUNUURR(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8519280", Offset = "0x8518080", VA = "0x188519280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85198B0", Offset = "0x85186B0", VA = "0x1885198B0")]
		[CompilerGenerated]
		private Bounds NYSNMLWMKPJ()
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
		[Cpp2IlInjected.Address(RVA = "0x8519110", Offset = "0x8517F10", VA = "0x188519110")]
		public QuadMeshManagerConfig AQQWLOIQYXI()
		{
			return default(QuadMeshManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85191C0", Offset = "0x8517FC0", VA = "0x1885191C0")]
		[CompilerGenerated]
		internal static void VBJSUVGIDGJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85191B0", Offset = "0x8517FB0", VA = "0x1885191B0")]
		[CompilerGenerated]
		internal static void HPHNXQEXLVK(int a, int b)
		{
		}
	}
}
namespace RecRoom.FastMesh.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface UAEJVLGMJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMeshBufferSource(VCQRKCLLIBD source);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveMeshBufferSource(VCQRKCLLIBD source);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetMeshBufferSourceRenderOrder(VCQRKCLLIBD source, int renderOrder);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetMeshBufferSourceMaterial(VCQRKCLLIBD source, Material material);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MarkBufferSourceDirty(VCQRKCLLIBD source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface VCQRKCLLIBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate bool GetMeshBufferDelegate(VCQRKCLLIBD source);

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string GDOZECFRVGD
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
	public class MeshBufferRenderer : MonoBehaviour, UAEJVLGMJLF
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
		private class JRQACZNQOUS : IComparer<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private IReadOnlyList<WJXLRYRIUZD> TPYYHYWSKOW;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			public void NRKVJJKJWDM(IReadOnlyList<WJXLRYRIUZD> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8515C20", Offset = "0x8514A20", VA = "0x188515C20", Slot = "4")]
			public int Compare(int lhsIdx, int rhsIdx)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public JRQACZNQOUS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class WJXLRYRIUZD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int RSBYDSSRGRG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Material EYCCBUUZXMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MeshBuffer MVTPCXPWESP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public bool MMZQMJVDASS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool WIXZOXOTDNS;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public WJXLRYRIUZD()
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
		private static readonly Log CEYCTSQHZPP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string CTIJMIIKIHE = "MeshBufferRenderer";

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
		private const int NBYRZXDDEDH = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Shader FallbackMaterialShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Mesh KASZQGMCOYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Material KCHGNXPWVSY;

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
		private DirtyStates QEUJLUGAOYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal readonly List<VCQRKCLLIBD> NUCQCUXMUJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly List<WJXLRYRIUZD> PVMJABGSAUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal int ZFXPMJVAWSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal int[] JWEWRFONSQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Material[] KNCXFHWTXQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MeshBuffer[] TNDWWXUWEOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly JRQACZNQOUS OJYGNSAPCWG;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal DirtyStates BTAEGRHMDLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x10FE9F0", Offset = "0x10FD7F0", VA = "0x1810FE9F0")]
			get
			{
				return default(DirtyStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x261CD30", Offset = "0x261BB30", VA = "0x18261CD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8517710", Offset = "0x8516510", VA = "0x188517710", Slot = "4")]
		public void SetMeshBufferSource(VCQRKCLLIBD source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85173B0", Offset = "0x85161B0", VA = "0x1885173B0", Slot = "5")]
		public void RemoveMeshBufferSource(VCQRKCLLIBD source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8517660", Offset = "0x8516460", VA = "0x188517660", Slot = "6")]
		public void SetMeshBufferSourceRenderOrder(VCQRKCLLIBD source, int renderOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8517800", Offset = "0x8516600", VA = "0x188517800", Slot = "9")]
		public bool TryGetMeshBufferSourceRenderOrder(VCQRKCLLIBD source, [Out] int renderOrder)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8517560", Offset = "0x8516360", VA = "0x188517560", Slot = "7")]
		public void SetMeshBufferSourceMaterial(VCQRKCLLIBD source, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8517720", Offset = "0x8516520", VA = "0x188517720", Slot = "10")]
		public bool TryGetMeshBufferSourceMaterial(VCQRKCLLIBD source, [Out] Material material)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8516700", Offset = "0x8515500", VA = "0x188516700", Slot = "8")]
		public void MarkBufferSourceDirty(VCQRKCLLIBD source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8515E00", Offset = "0x8514C00", VA = "0x188515E00")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8516EC0", Offset = "0x8515CC0", VA = "0x188516EC0")]
		protected void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8516EB0", Offset = "0x8515CB0", VA = "0x188516EB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8516E20", Offset = "0x8515C20", VA = "0x188516E20")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8516330", Offset = "0x8515130", VA = "0x188516330")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85171C0", Offset = "0x8515FC0", VA = "0x1885171C0")]
		private void RKLSXANWVXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85167B0", Offset = "0x85155B0", VA = "0x1885167B0")]
		private void NFCXMNAEVAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8516460", Offset = "0x8515260", VA = "0x188516460")]
		private void MKPOKYDURFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8516C20", Offset = "0x8515A20", VA = "0x188516C20")]
		private void OCWGKUJUVJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8517930", Offset = "0x8516730", VA = "0x188517930")]
		private bool WYVMKKEYHXI(VCQRKCLLIBD a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8512EC0", Offset = "0x8511CC0", VA = "0x188512EC0")]
		private int ZKGMXBFOPVR(VCQRKCLLIBD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8516FD0", Offset = "0x8515DD0", VA = "0x188516FD0")]
		private int PYCXMZJIVVX(VCQRKCLLIBD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8516680", Offset = "0x8515480", VA = "0x188516680")]
		private void MUSFONIITCK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8517470", Offset = "0x8516270", VA = "0x188517470")]
		private void SZUMUUBKSIW(int a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8516280", Offset = "0x8515080", VA = "0x188516280")]
		private void IIHBDFKHRJO(int a, MeshBuffer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8517150", Offset = "0x8515F50", VA = "0x188517150")]
		private void QOCIXWMMTUJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85178C0", Offset = "0x85166C0", VA = "0x1885178C0")]
		private void WJSEKEXRLZG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8517AA0", Offset = "0x85168A0", VA = "0x188517AA0")]
		private void YOYJGSASCEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8515F20", Offset = "0x8514D20", VA = "0x188515F20")]
		private void BJNOLUFPAYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85179A0", Offset = "0x85167A0", VA = "0x1885179A0")]
		private bool XVJSKDOMXIT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8517CC0", Offset = "0x8516AC0", VA = "0x188517CC0")]
		private static Material[] YYTJHORGWAZ(MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8516260", Offset = "0x8515060", VA = "0x188516260")]
		private static void HZKSNCNKUHH(MeshRenderer a, Material[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85161D0", Offset = "0x8514FD0", VA = "0x1885161D0")]
		private static void HNSOIBVKQHM(MeshFilter a, Mesh b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8517C40", Offset = "0x8516A40", VA = "0x188517C40")]
		private static void YTDRYFTWAVT(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8517E80", Offset = "0x8516C80", VA = "0x188517E80")]
		public MeshBufferRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3928DC0", Offset = "0x3927BC0", VA = "0x183928DC0")]
		[CompilerGenerated]
		private a VSIBUKOSSOJ<a>(RenderComponents a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3928BF0", Offset = "0x39279F0", VA = "0x183928BF0")]
		[CompilerGenerated]
		private b BZWPPOIUZMK<b>(b a, RenderComponents b, <>c__DisplayClass57_0 c) where b : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	public abstract class MeshBufferSource : MonoBehaviour, VCQRKCLLIBD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual VCQRKCLLIBD.GetMeshBufferDelegate VBAFYZCJWRZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public UAEJVLGMJLF UCXXUDEWADN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x180AC8C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CMEKHCQVLHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB20690", Offset = "0xB1F490", VA = "0x180B20690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB21030", Offset = "0xB1FE30", VA = "0x180B21030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZFCOOMLNFWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD222C0", Offset = "0xD210C0", VA = "0x180D222C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD62AE0", Offset = "0xD618E0", VA = "0x180D62AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DAFFBQPVVZS(UAEJVLGMJLF a);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8518220", Offset = "0x8517020", VA = "0x188518220")]
		[Conditional("UNITY_EDITOR")]
		protected void NVRXDPMICEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85181C0", Offset = "0x8516FC0", VA = "0x1885181C0")]
		public void MarkSubMeshDataDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8518330", Offset = "0x8517130", VA = "0x188518330", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85182C0", Offset = "0x85170C0", VA = "0x1885182C0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8518010", Offset = "0x8516E10", VA = "0x188518010")]
		protected bool DAFFBQPVVZS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85183A0", Offset = "0x85171A0", VA = "0x1885183A0", Slot = "12")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85183B0", Offset = "0x85171B0", VA = "0x1885183B0")]
		protected static void YTDRYFTWAVT(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		protected MeshBufferSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBCA1D0", Offset = "0xBC8FD0", VA = "0x180BCA1D0", Slot = "4")]
		private string UEEWROPXJGF()
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
