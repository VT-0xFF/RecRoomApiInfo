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
		[Cpp2IlInjected.Address(RVA = "0x99A9E40", Offset = "0x99A8E40", VA = "0x1899A9E40", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class JQAWSZGKTMT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly LayoutRect XHJESSCAMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int KFPQZFKKPPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ZZVDVVBSISH DBKTFZRDQBZ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99A9DD0", Offset = "0x99A8DD0", VA = "0x1899A9DD0")]
		public JQAWSZGKTMT(LayoutRect a, ZZVDVVBSISH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99A9CB0", Offset = "0x99A8CB0", VA = "0x1899A9CB0")]
		public bool LXFEPLAAMNR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99A9C50", Offset = "0x99A8C50", VA = "0x1899A9C50")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class MeshBuffer : ANVYTGYFCQL
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate Bounds BoundsGetterDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int YYKHCTDTSCN = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public QuadVertex[] RURICDAPYPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int UAGWKYNNIOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ushort[] IKGVATXUYGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int QLWDQWLFTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly BoundsGetterDelegate DWBCGTHRHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Bounds FMPNRBVBSXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MeshBufferDirtyStates CRKNAUZKQEL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MeshBuffer SGYHQKGKMCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99AC620", Offset = "0x99AB620", VA = "0x1899AC620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string GAXOXHPQSZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ANVYTGYFCQL.GetMeshBufferDelegate HANLZAPTXIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99ACA90", Offset = "0x99ABA90", VA = "0x1899ACA90")]
		public MeshBuffer(BoundsGetterDelegate boundsGetter, int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99ACA80", Offset = "0x99ABA80", VA = "0x1899ACA80")]
		public MeshBuffer(int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99AC960", Offset = "0x99AB960", VA = "0x1899AC960", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A80E0", Offset = "0x99A70E0", VA = "0x1899A80E0")]
		public void NSOCOZKBYEL(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99AC520", Offset = "0x99AB520", VA = "0x1899AC520")]
		public void IOBJTQBPXNE(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99AC9D0", Offset = "0x99AB9D0", VA = "0x1899AC9D0")]
		public void YRYZLMBNOEI(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99AC510", Offset = "0x99AB510", VA = "0x1899AC510")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D12980", Offset = "0x3D11980", VA = "0x183D12980")]
		private static void BKEAJXDXQBJ<a>(a[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99AC670", Offset = "0x99AB670", VA = "0x1899AC670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99AC5D0", Offset = "0x99AB5D0", VA = "0x1899AC5D0")]
		[CompilerGenerated]
		private Bounds KETRUIVQXHU()
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
	public static class FATFJFZPMGQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly float3[] QFKXFDLFRUN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly float2[] KLVLUNEVDGV;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99A8BF0", Offset = "0x99A7BF0", VA = "0x1899A8BF0")]
		public static void CYWXMLCOVGQ(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99A8AB0", Offset = "0x99A7AB0", VA = "0x1899A8AB0")]
		public static void CYWXMLCOVGQ(this MeshBuffer a, [In] int vertexBufferIdx, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99A8A20", Offset = "0x99A7A20", VA = "0x1899A8A20")]
		public static void BUAUOGCQAAV(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99A8D00", Offset = "0x99A7D00", VA = "0x1899A8D00")]
		public static void IONKDLKCLLE(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99A8E30", Offset = "0x99A7E30", VA = "0x1899A8E30")]
		public static void PVBDMJRUVPA(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] int quadIndexBufferIdx, [In] bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99A7410", Offset = "0x99A6410", VA = "0x1899A7410")]
		public static void KGKJYSRTMRS(this MeshBuffer a, [In] int targetVertexBufferIdx, [In] int targetIndexBufferIdx, MeshBuffer b, [In] int sourceVertexBufferIdx, [In] int sourceIndexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TYAGCQKYPCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log ODQOGMWHRXV;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly int DQXIVKUBLRK;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static ProfilerMarker EKKAVMDRMFE;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static ProfilerMarker QERXKGVXAKB;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static ProfilerMarker BZVAUCUCSUP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static ProfilerMarker WDGFHTQQTMP;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static ProfilerMarker CDYGYMHEUEQ;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static ushort[] ALLEGTLQKIA;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly SubMeshDescriptor[] ZDQYCSAYJOH;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly MeshBuffer[] HHMHBPNZAAZ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99ADE60", Offset = "0x99ACE60", VA = "0x1899ADE60")]
		public static MeshBufferDirtyStates JSZYPNFZGOI([In] Mesh mesh, [In] ReadOnlySpan<MeshBuffer> buffers, MeshBufferDirtyStates a = MeshBufferDirtyStates.Clean)
		{
			return default(MeshBufferDirtyStates);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99AE870", Offset = "0x99AD870", VA = "0x1899AE870")]
		private static bool OHQHWWFEHWG(this MeshBuffer a, [In] Mesh mesh, int b, int c, [In] MeshBufferDirtyStates dirtyState)
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
		private FastQuadSubMeshBuffer UULMHUHOAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private QuadMeshManager VHMKZXZJZXI;

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
		private ZZVDVVBSISH DBKTFZRDQBZ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99A93F0", Offset = "0x99A83F0", VA = "0x1899A93F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99A93C0", Offset = "0x99A83C0", VA = "0x1899A93C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99A9620", Offset = "0x99A8620", VA = "0x1899A9620")]
		private void SGKSYCOFRYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99A9790", Offset = "0x99A8790", VA = "0x1899A9790")]
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
		private QuadMeshManager XJFGFBPBKTN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QuadMeshManager BEMLQWZPLLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99A9B90", Offset = "0x99A8B90", VA = "0x1899A9B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99A9970", Offset = "0x99A8970", VA = "0x1899A9970", Slot = "8")]
		protected override void PHLBMKXXNLA(GABTMZZSPDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99A9AE0", Offset = "0x99A8AE0", VA = "0x1899A9AE0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99A98A0", Offset = "0x99A88A0", VA = "0x1899A98A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private void ICFRYQBLHGN(GABTMZZSPDD a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99A97E0", Offset = "0x99A87E0", VA = "0x1899A97E0")]
		private void KNBCFCGCGGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99ADD30", Offset = "0x99ACD30", VA = "0x1899ADD30")]
		public Quad(MeshBuffer buffer, int vertexBufferIdx, int indexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class FWRIXMQBAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99A9030", Offset = "0x99A8030", VA = "0x1899A9030")]
		public static void EJHYYIJBBUA(this Quad a, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99A8FC0", Offset = "0x99A7FC0", VA = "0x1899A8FC0")]
		public static void EJHYYIJBBUA(this Quad a, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99A9130", Offset = "0x99A8130", VA = "0x1899A9130")]
		public static void QHJSSAAJNZT(this Quad a, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99A90B0", Offset = "0x99A80B0", VA = "0x1899A90B0")]
		public static void JFALMXVMHNM(this Quad a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99A92B0", Offset = "0x99A82B0", VA = "0x1899A92B0")]
		public static void WGOOEEQTJHU(this Quad a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99A9210", Offset = "0x99A8210", VA = "0x1899A9210")]
		public static void SJBCDKEGNQI(this Quad a, Quad b)
		{
		}
	}
	[StructLayout((LayoutKind)0)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class ZZVDVVBSISH : IEquatable<ZZVDVVBSISH>
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const ushort ECBYPMNAOYB = 0;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const int GXXAOIQAGDC = 65534;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ZZVDVVBSISH GECUTCQQTXZ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ushort DETNLJGKNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xDBD1A0", Offset = "0xDBC1A0", VA = "0x180DBD1A0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xDBD1B0", Offset = "0xDBC1B0", VA = "0x180DBD1B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public QuadMeshManager CRUNLPTVVQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99AF1A0", Offset = "0x99AE1A0", VA = "0x1899AF1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99AF4B0", Offset = "0x99AE4B0", VA = "0x1899AF4B0")]
		public ZZVDVVBSISH(int a, QuadMeshManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99AF340", Offset = "0x99AE340", VA = "0x1899AF340")]
		public bool NDMEHZISKNQ([Out] Quad a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99AF3E0", Offset = "0x99AE3E0", VA = "0x1899AF3E0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99AF3B0", Offset = "0x99AE3B0", VA = "0x1899AF3B0")]
		internal void PEIOIQZYFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99AF270", Offset = "0x99AE270", VA = "0x1899AF270", Slot = "4")]
		public bool Equals(ZZVDVVBSISH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99AF1B0", Offset = "0x99AE1B0", VA = "0x1899AF1B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99AF2D0", Offset = "0x99AE2D0", VA = "0x1899AF2D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class QuadMeshManager : IDisposable, ANVYTGYFCQL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private string SLAOVMJMRPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		internal readonly QuadMeshManagerConfig SHVWYHTNORO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal ZZVDVVBSISH[] ZGENZKSVPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MeshBuffer IBEYMZWLYLX;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GAXOXHPQSZL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x99AD2A0", Offset = "0x99AC2A0", VA = "0x1899AD2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BVEMBKPZHSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF4860", Offset = "0xCF3860", VA = "0x180CF4860")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF4870", Offset = "0xCF3870", VA = "0x180CF4870")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ANVYTGYFCQL.GetMeshBufferDelegate HANLZAPTXIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99ADA50", Offset = "0x99ACA50", VA = "0x1899ADA50")]
		public QuadMeshManager(QuadMeshManagerConfig config, [Optional] MeshBuffer.BoundsGetterDelegate boundsGetter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99ADCC0", Offset = "0x99ACCC0", VA = "0x1899ADCC0")]
		public QuadMeshManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x99AD510", Offset = "0x99AC510", VA = "0x1899AD510", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99AD580", Offset = "0x99AC580", VA = "0x1899AD580")]
		public ZZVDVVBSISH YVTFEKTHFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99ACE00", Offset = "0x99ABE00", VA = "0x1899ACE00")]
		public void AULNXFPXYAG(ZZVDVVBSISH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99AD280", Offset = "0x99AC280", VA = "0x1899AD280")]
		public bool NGBVAQTOJYI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99AD210", Offset = "0x99AC210", VA = "0x1899AD210")]
		internal bool NDMEHZISKNQ(ZZVDVVBSISH a, [Out] Quad b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99AD1B0", Offset = "0x99AC1B0", VA = "0x1899AD1B0")]
		internal Quad LDUGOSIFMBX(int a)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99AD1F0", Offset = "0x99AC1F0", VA = "0x1899AD1F0")]
		internal Quad LDUGOSIFMBX(int a, int b)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99AD390", Offset = "0x99AC390", VA = "0x1899AD390")]
		private void PLYESNLSGKS(Quad a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99AD850", Offset = "0x99AC850", VA = "0x1899AD850")]
		private void ZFWKHUCBWRN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99AD070", Offset = "0x99AC070", VA = "0x1899AD070")]
		private bool CNDCDRNCTYT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99AD320", Offset = "0x99AC320", VA = "0x1899AD320")]
		private static int OUPIYBOMTPV(ZZVDVVBSISH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x25ECB30", Offset = "0x25EBB30", VA = "0x1825ECB30")]
		private static ushort KLWHPDHKAAJ(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99AD0F0", Offset = "0x99AC0F0", VA = "0x1899AD0F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99AD340", Offset = "0x99AC340", VA = "0x1899AD340")]
		[CompilerGenerated]
		private Bounds PEOUTPUPJXX()
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
		[Cpp2IlInjected.Address(RVA = "0x99ACCA0", Offset = "0x99ABCA0", VA = "0x1899ACCA0")]
		public QuadMeshManagerConfig BBRCRBMIAYQ()
		{
			return default(QuadMeshManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99ACD40", Offset = "0x99ABD40", VA = "0x1899ACD40")]
		[CompilerGenerated]
		internal static void PPVLGXISUSP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99ACC90", Offset = "0x99ABC90", VA = "0x1899ACC90")]
		[CompilerGenerated]
		internal static void AWGOIHVAFBY(int a, int b)
		{
		}
	}
}
namespace RecRoom.FastMesh.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface GABTMZZSPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMeshBufferSource(ANVYTGYFCQL source);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveMeshBufferSource(ANVYTGYFCQL source);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetMeshBufferSourceRenderOrder(ANVYTGYFCQL source, int renderOrder);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetMeshBufferSourceMaterial(ANVYTGYFCQL source, Material material);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MarkBufferSourceDirty(ANVYTGYFCQL source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ANVYTGYFCQL
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate bool GetMeshBufferDelegate(ANVYTGYFCQL source);

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string GAXOXHPQSZL
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
	public class MeshBufferRenderer : MonoBehaviour, GABTMZZSPDD
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
		private class RBCHHLSTTLC : IComparer<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private IReadOnlyList<NDEJOFLHITR> PKEIAAMCWAY;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			public void KWSQHQMQIDG(IReadOnlyList<NDEJOFLHITR> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x99ADD40", Offset = "0x99ACD40", VA = "0x1899ADD40", Slot = "4")]
			public int Compare(int lhsIdx, int rhsIdx)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public RBCHHLSTTLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class NDEJOFLHITR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int OFAWLOVYRLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Material TTNXTZFTOKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MeshBuffer PXOOIORCWVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public bool XSUKGJNXEOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool JFUWVEMTPBU;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public NDEJOFLHITR()
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
		private static readonly Log ODQOGMWHRXV;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string ORKRVHFEXTG = "MeshBufferRenderer";

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
		private const int QBQDTPXLOTB = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Shader FallbackMaterialShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Mesh SPBFNCHKFVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Material RODJKPWODLA;

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
		private DirtyStates JMQVNJULBVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal readonly List<ANVYTGYFCQL> HLWGVJCQEKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly List<NDEJOFLHITR> NSHUQINXILW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal int SFQYKGZOJXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal int[] UKXDOLBLFAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Material[] OYBYFFTZEQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MeshBuffer[] SNHALCXSSNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly RBCHHLSTTLC PBNKQUZHWXO;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal DirtyStates HSOWSAFKXNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x132BF40", Offset = "0x132AF40", VA = "0x18132BF40")]
			get
			{
				return default(DirtyStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x285F980", Offset = "0x285E980", VA = "0x18285F980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99AB410", Offset = "0x99AA410", VA = "0x1899AB410", Slot = "4")]
		public void SetMeshBufferSource(ANVYTGYFCQL source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99AB100", Offset = "0x99AA100", VA = "0x1899AB100", Slot = "5")]
		public void RemoveMeshBufferSource(ANVYTGYFCQL source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99AB360", Offset = "0x99AA360", VA = "0x1899AB360", Slot = "6")]
		public void SetMeshBufferSourceRenderOrder(ANVYTGYFCQL source, int renderOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99ABA80", Offset = "0x99AAA80", VA = "0x1899ABA80", Slot = "9")]
		public bool TryGetMeshBufferSourceRenderOrder(ANVYTGYFCQL source, [Out] int renderOrder)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99AB260", Offset = "0x99AA260", VA = "0x1899AB260", Slot = "7")]
		public void SetMeshBufferSourceMaterial(ANVYTGYFCQL source, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99AB9A0", Offset = "0x99AA9A0", VA = "0x1899AB9A0", Slot = "10")]
		public bool TryGetMeshBufferSourceMaterial(ANVYTGYFCQL source, [Out] Material material)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99AADC0", Offset = "0x99A9DC0", VA = "0x1899AADC0", Slot = "8")]
		public void MarkBufferSourceDirty(ANVYTGYFCQL source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99AA230", Offset = "0x99A9230", VA = "0x1899AA230")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99AAF80", Offset = "0x99A9F80", VA = "0x1899AAF80")]
		protected void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99AAF70", Offset = "0x99A9F70", VA = "0x1899AAF70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99AAEE0", Offset = "0x99A9EE0", VA = "0x1899AAEE0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99AAC20", Offset = "0x99A9C20", VA = "0x1899AAC20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x99AA550", Offset = "0x99A9550", VA = "0x1899AA550")]
		private void CUAERJAXTVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99AB520", Offset = "0x99AA520", VA = "0x1899AB520")]
		private void TMCRSMQJCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99AAA00", Offset = "0x99A9A00", VA = "0x1899AAA00")]
		private void IGMGEFEAHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99AA350", Offset = "0x99A9350", VA = "0x1899AA350")]
		private void BQYOMQGEJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99AAE70", Offset = "0x99A9E70", VA = "0x1899AAE70")]
		private bool ONARVRXDYYA(ANVYTGYFCQL a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99A7FC0", Offset = "0x99A6FC0", VA = "0x1899A7FC0")]
		private int XFCJHWOLZWZ(ANVYTGYFCQL a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99AA7F0", Offset = "0x99A97F0", VA = "0x1899AA7F0")]
		private int DAWAJOVQAUD(ANVYTGYFCQL a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99AB1E0", Offset = "0x99AA1E0", VA = "0x1899AB1E0")]
		private void SOANPCUKSSU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99ABD00", Offset = "0x99AAD00", VA = "0x1899ABD00")]
		private void YNHBHXPMHMI(int a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99AA740", Offset = "0x99A9740", VA = "0x1899AA740")]
		private void CUFURCAXOWG(int a, MeshBuffer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99AAD50", Offset = "0x99A9D50", VA = "0x1899AAD50")]
		private void MODGDNHAOID(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99AB090", Offset = "0x99AA090", VA = "0x1899AB090")]
		private void QDGPRKHRMHQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99ABB60", Offset = "0x99AAB60", VA = "0x1899ABB60")]
		private void WNLADMHNRSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99A9F00", Offset = "0x99A8F00", VA = "0x1899A9F00")]
		private void AIQYVJRYSLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99AB420", Offset = "0x99AA420", VA = "0x1899AB420")]
		private bool TJWOVPGETZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99AB1C0", Offset = "0x99AA1C0", VA = "0x1899AB1C0")]
		private static Material[] SJZPGWAJPET(MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99ABB40", Offset = "0x99AAB40", VA = "0x1899ABB40")]
		private static void VTACNQSNYGP(MeshRenderer a, Material[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99AA970", Offset = "0x99A9970", VA = "0x1899AA970")]
		private static void EHDPYIZJDLO(MeshFilter a, Mesh b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99AA1B0", Offset = "0x99A91B0", VA = "0x1899AA1B0")]
		private static void AXHSZBKYXYX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99ABF90", Offset = "0x99AAF90", VA = "0x1899ABF90")]
		public MeshBufferRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D12680", Offset = "0x3D11680", VA = "0x183D12680")]
		[CompilerGenerated]
		private a HKWWDPQNWBR<a>(RenderComponents a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3D127B0", Offset = "0x3D117B0", VA = "0x183D127B0")]
		[CompilerGenerated]
		private b ZMJMQCMOFBO<b>(b a, RenderComponents b, <>c__DisplayClass57_0 c) where b : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	public abstract class MeshBufferSource : MonoBehaviour, ANVYTGYFCQL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual ANVYTGYFCQL.GetMeshBufferDelegate HANLZAPTXIN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GABTMZZSPDD NQQGUXVCVDP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool XRCRWHPGBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD4F620", Offset = "0xD4E620", VA = "0x180D4F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FUJSUWWNCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xF4DE70", Offset = "0xF4CE70", VA = "0x180F4DE70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xF93080", Offset = "0xF92080", VA = "0x180F93080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void PHLBMKXXNLA(GABTMZZSPDD a);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99AC470", Offset = "0x99AB470", VA = "0x1899AC470")]
		[Conditional("UNITY_EDITOR")]
		protected void SDGFXOBBFZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99AC170", Offset = "0x99AB170", VA = "0x1899AC170")]
		public void MarkSubMeshDataDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99AC240", Offset = "0x99AB240", VA = "0x1899AC240", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99AC1D0", Offset = "0x99AB1D0", VA = "0x1899AC1D0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x99AC2C0", Offset = "0x99AB2C0", VA = "0x1899AC2C0")]
		protected bool PHLBMKXXNLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x99AC2B0", Offset = "0x99AB2B0", VA = "0x1899AC2B0", Slot = "12")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99AC120", Offset = "0x99AB120", VA = "0x1899AC120")]
		protected static void AXHSZBKYXYX(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
		protected MeshBufferSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xDF3CF0", Offset = "0xDF2CF0", VA = "0x180DF3CF0", Slot = "4")]
		private string RSNKGDPYSLF()
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
