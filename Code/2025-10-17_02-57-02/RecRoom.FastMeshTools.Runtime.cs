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
		[Cpp2IlInjected.Address(RVA = "0x84F75F0", Offset = "0x84F5BF0", VA = "0x1884F75F0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class INVALJOSWEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly LayoutRect UEEJRGWZKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int ETKXSINPXEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MQXBRFECGTL AAKIOCDMJCZ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84F7580", Offset = "0x84F5B80", VA = "0x1884F7580")]
		public INVALJOSWEF(LayoutRect a, MQXBRFECGTL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84F7460", Offset = "0x84F5A60", VA = "0x1884F7460")]
		public bool KKDTBCMNHEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84F7400", Offset = "0x84F5A00", VA = "0x1884F7400")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class MeshBuffer : BBUSSLDKBTT
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate Bounds BoundsGetterDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const int UQIDCBFYMWH = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public QuadVertex[] QMMWJJFXYXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int UVKNPBOFEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ushort[] ZKPNCDUNAFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GKUYWVZPCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly BoundsGetterDelegate JSXAGIOGNXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Bounds YLLQFDKWPFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MeshBufferDirtyStates SJNIAZRRRMJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MeshBuffer HJMKXSMPYIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x84FA170", Offset = "0x84F8770", VA = "0x1884FA170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string NCYYWAFKAWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BBUSSLDKBTT.GetMeshBufferDelegate ZSGHPCIPYOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84FA580", Offset = "0x84F8B80", VA = "0x1884FA580")]
		public MeshBuffer(BoundsGetterDelegate boundsGetter, int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84FA570", Offset = "0x84F8B70", VA = "0x1884FA570")]
		public MeshBuffer(int initialQuadCapacity = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84FA500", Offset = "0x84F8B00", VA = "0x1884FA500", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84F5800", Offset = "0x84F3E00", VA = "0x1884F5800")]
		public void KDXVQHHVZBD(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84FA010", Offset = "0x84F8610", VA = "0x1884FA010")]
		public void FOZDYOUIXUU(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84FA0C0", Offset = "0x84F86C0", VA = "0x1884FA0C0")]
		public void JEBEKMISJTU(int a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84FA000", Offset = "0x84F8600", VA = "0x1884FA000")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8FC0", Offset = "0x3AB75C0", VA = "0x183AB8FC0")]
		private static void MUUCQLBCJUR<a>(a[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84FA210", Offset = "0x84F8810", VA = "0x1884FA210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84FA1C0", Offset = "0x84F87C0", VA = "0x1884FA1C0")]
		[CompilerGenerated]
		private Bounds PFOIOTGRADS()
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
	public static class ZTGSSBGJJQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly float3[] HYNJBFMGPDF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly float2[] GNQONFXDBSH;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84FCCA0", Offset = "0x84FB2A0", VA = "0x1884FCCA0")]
		public static void JWCPLHJFAHI(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84FCDB0", Offset = "0x84FB3B0", VA = "0x1884FCDB0")]
		public static void JWCPLHJFAHI(this MeshBuffer a, [In] int vertexBufferIdx, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC10", Offset = "0x84FB210", VA = "0x1884FCC10")]
		public static void GSXURKJYPSP(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84FCAF0", Offset = "0x84FB0F0", VA = "0x1884FCAF0")]
		public static void AOGQSXGCILS(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84FCEF0", Offset = "0x84FB4F0", VA = "0x1884FCEF0")]
		public static void ZUYKFINCZWU(this MeshBuffer a, [In] int quadVertexBufferIdx, [In] int quadIndexBufferIdx, [In] bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84F63E0", Offset = "0x84F49E0", VA = "0x1884F63E0")]
		public static void ZMMQHCUYVMC(this MeshBuffer a, [In] int targetVertexBufferIdx, [In] int targetIndexBufferIdx, MeshBuffer b, [In] int sourceVertexBufferIdx, [In] int sourceIndexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PHSSOMXKCXT
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log MMQZIZMISGN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly int IIVLEMDMKVM;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static ProfilerMarker USNHFMIOVOY;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static ProfilerMarker YTPYPNHYGVV;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static ProfilerMarker MDWKCEBNRMN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static ProfilerMarker QVZFVGCKCMN;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static ProfilerMarker YIOKFEAWELE;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static ushort[] CDIXKWRAOUW;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly SubMeshDescriptor[] ISFUISHRICN;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly MeshBuffer[] MAPOPXETUGD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84FAD70", Offset = "0x84F9370", VA = "0x1884FAD70")]
		public static MeshBufferDirtyStates XNAJYJQGDQW([In] Mesh mesh, [In] ReadOnlySpan<MeshBuffer> buffers, MeshBufferDirtyStates a = MeshBufferDirtyStates.Clean)
		{
			return default(MeshBufferDirtyStates);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84FA780", Offset = "0x84F8D80", VA = "0x1884FA780")]
		private static bool KUDMLORUQCA(this MeshBuffer a, [In] Mesh mesh, int b, int c, [In] MeshBufferDirtyStates dirtyState)
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
		private FastQuadSubMeshBuffer IKLGFFRUYRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private QuadMeshManager HKHVYYNROHG;

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
		private MQXBRFECGTL AAKIOCDMJCZ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84F67A0", Offset = "0x84F4DA0", VA = "0x1884F67A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84F6770", Offset = "0x84F4D70", VA = "0x1884F6770")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84F69D0", Offset = "0x84F4FD0", VA = "0x1884F69D0")]
		private void RFAMCQYOTQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84F6B40", Offset = "0x84F5140", VA = "0x1884F6B40")]
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
		private QuadMeshManager RUDQWGNIGKB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QuadMeshManager VJQBHIJZLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84F6F40", Offset = "0x84F5540", VA = "0x1884F6F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84F6C50", Offset = "0x84F5250", VA = "0x1884F6C50", Slot = "8")]
		protected override void CLZEBGQRXWI(BHESRWURXJZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84F6E90", Offset = "0x84F5490", VA = "0x1884F6E90", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84F6DC0", Offset = "0x84F53C0", VA = "0x1884F6DC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private void BIREJJCZRQD(BHESRWURXJZ a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84F6B90", Offset = "0x84F5190", VA = "0x1884F6B90")]
		private void CCPMARWHPMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		[Cpp2IlInjected.Address(RVA = "0x84FCAE0", Offset = "0x84FB0E0", VA = "0x1884FCAE0")]
		public Quad(MeshBuffer buffer, int vertexBufferIdx, int indexBufferIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class HETJQSOVWWV
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84F72A0", Offset = "0x84F58A0", VA = "0x1884F72A0")]
		public static void QALRKJJXZNI(this Quad a, [In] float2 rectPos, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84F7230", Offset = "0x84F5830", VA = "0x1884F7230")]
		public static void QALRKJJXZNI(this Quad a, [In] float2Rect rect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84F7320", Offset = "0x84F5920", VA = "0x1884F7320")]
		public static void TTATXQODWDB(this Quad a, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84F70A0", Offset = "0x84F56A0", VA = "0x1884F70A0")]
		public static void IWBEZZXTXKI(this Quad a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84F7120", Offset = "0x84F5720", VA = "0x1884F7120")]
		public static void JDGCESYEQHO(this Quad a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84F7000", Offset = "0x84F5600", VA = "0x1884F7000")]
		public static void FDGIKRSCTRU(this Quad a, Quad b)
		{
		}
	}
	[StructLayout((LayoutKind)0)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class MQXBRFECGTL : IEquatable<MQXBRFECGTL>
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const ushort IQHLLFAKSUT = 0;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const int BGJSOHHOMPE = 65534;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly MQXBRFECGTL AWYAYENMJKN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ushort MZUYNHTTAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xE2D1B0", Offset = "0xE2B7B0", VA = "0x180E2D1B0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xE2D1C0", Offset = "0xE2B7C0", VA = "0x180E2D1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public QuadMeshManager EHJDGLOGFVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x84F7890", Offset = "0x84F5E90", VA = "0x1884F7890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84F79C0", Offset = "0x84F5FC0", VA = "0x1884F79C0")]
		public MQXBRFECGTL(int a, QuadMeshManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84F78A0", Offset = "0x84F5EA0", VA = "0x1884F78A0")]
		public bool XZNMKRDECOA([Out] Quad a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84F7840", Offset = "0x84F5E40", VA = "0x1884F7840")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84F7910", Offset = "0x84F5F10", VA = "0x1884F7910")]
		internal void YEKJRGPMNYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84F7770", Offset = "0x84F5D70", VA = "0x1884F7770", Slot = "4")]
		public bool Equals(MQXBRFECGTL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84F76B0", Offset = "0x84F5CB0", VA = "0x1884F76B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84F77D0", Offset = "0x84F5DD0", VA = "0x1884F77D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class QuadMeshManager : IDisposable, BBUSSLDKBTT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private string XXGCTXHYPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		internal readonly QuadMeshManagerConfig TGOEJGVMXTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal MQXBRFECGTL[] YJEDJCBBSQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MeshBuffer DMGSXGABSTV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string NCYYWAFKAWP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84FBEF0", Offset = "0x84FA4F0", VA = "0x1884FBEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int MDYPAANREBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAB0750", Offset = "0xAAED50", VA = "0x180AB0750")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAB0780", Offset = "0xAAED80", VA = "0x180AB0780")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BBUSSLDKBTT.GetMeshBufferDelegate ZSGHPCIPYOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84FC800", Offset = "0x84FAE00", VA = "0x1884FC800")]
		public QuadMeshManager(QuadMeshManagerConfig config, [Optional] MeshBuffer.BoundsGetterDelegate boundsGetter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84FCA70", Offset = "0x84FB070", VA = "0x1884FCA70")]
		public QuadMeshManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84FC370", Offset = "0x84FA970", VA = "0x1884FC370", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84FC4B0", Offset = "0x84FAAB0", VA = "0x1884FC4B0")]
		public MQXBRFECGTL YOLRVLAHQQU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84FC100", Offset = "0x84FA700", VA = "0x1884FC100")]
		public void RECAGMENTAE(MQXBRFECGTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84FBBC0", Offset = "0x84FA1C0", VA = "0x1884FBBC0")]
		public bool AOKSNKUMISS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84FC440", Offset = "0x84FAA40", VA = "0x1884FC440")]
		internal bool XZNMKRDECOA(MQXBRFECGTL a, [Out] Quad b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84FC3E0", Offset = "0x84FA9E0", VA = "0x1884FC3E0")]
		internal Quad WZJIZUQBRPZ(int a)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84FC420", Offset = "0x84FAA20", VA = "0x1884FC420")]
		internal Quad WZJIZUQBRPZ(int a, int b)
		{
			return default(Quad);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84FBF70", Offset = "0x84FA570", VA = "0x1884FBF70")]
		private void KBTASFDTICM(Quad a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84FBCF0", Offset = "0x84FA2F0", VA = "0x1884FBCF0")]
		private void FCJNPQWXQXP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84FC780", Offset = "0x84FAD80", VA = "0x1884FC780")]
		private bool ZMGEJLBPPIJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84FC0E0", Offset = "0x84FA6E0", VA = "0x1884FC0E0")]
		private static int PIQSYZUGZQF(MQXBRFECGTL a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x257B0E0", Offset = "0x25796E0", VA = "0x18257B0E0")]
		private static ushort IHONTEWAYSX(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84FBBE0", Offset = "0x84FA1E0", VA = "0x1884FBBE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84FBCA0", Offset = "0x84FA2A0", VA = "0x1884FBCA0")]
		[CompilerGenerated]
		private Bounds EIOQULTAEKT()
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
		[Cpp2IlInjected.Address(RVA = "0x84FBA50", Offset = "0x84FA050", VA = "0x1884FBA50")]
		public QuadMeshManagerConfig HVKCTUNFHKG()
		{
			return default(QuadMeshManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84FBAF0", Offset = "0x84FA0F0", VA = "0x1884FBAF0")]
		[CompilerGenerated]
		internal static void QUKMEWWKAOV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84FBB00", Offset = "0x84FA100", VA = "0x1884FBB00")]
		[CompilerGenerated]
		internal static void RNRZZDPURIM(int a, int b)
		{
		}
	}
}
namespace RecRoom.FastMesh.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BHESRWURXJZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetMeshBufferSource(BBUSSLDKBTT source);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveMeshBufferSource(BBUSSLDKBTT source);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetMeshBufferSourceRenderOrder(BBUSSLDKBTT source, int renderOrder);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetMeshBufferSourceMaterial(BBUSSLDKBTT source, Material material);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MarkBufferSourceDirty(BBUSSLDKBTT source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BBUSSLDKBTT
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate bool GetMeshBufferDelegate(BBUSSLDKBTT source);

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string NCYYWAFKAWP
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
	public class MeshBufferRenderer : MonoBehaviour, BHESRWURXJZ
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
		private class DRFGCDGIICO : IComparer<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private IReadOnlyList<CYNRAPTSSDX> JNJGLXXPKEC;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			public void FTYJJGFKYMC(IReadOnlyList<CYNRAPTSSDX> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x84F6650", Offset = "0x84F4C50", VA = "0x1884F6650", Slot = "4")]
			public int Compare(int lhsIdx, int rhsIdx)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DRFGCDGIICO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class CYNRAPTSSDX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int CSYKHGOZEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Material VVSRREQNLJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MeshBuffer ETXEKZEKQVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public bool SXRQFDRXIPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool WLNHSHGLVJS;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public CYNRAPTSSDX()
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
		private static readonly Log MMQZIZMISGN;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string MTHETTXZCWO = "MeshBufferRenderer";

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
		private const int JZPCBQRDPNX = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Shader FallbackMaterialShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Mesh SNIRYPYSEKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Material PGBBYABXZNC;

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
		private DirtyStates LVTRDCFQLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal readonly List<BBUSSLDKBTT> KEKMUOKWGTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly List<CYNRAPTSSDX> DKYGYKEQYKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal int OGQTONHGFMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal int[] IYZXJTDVEQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Material[] FJEWEAPMGUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MeshBuffer[] IOPDFPTYZNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly DRFGCDGIICO YYWZRKTJUBA;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal DirtyStates MTHIQCOYFKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB9A670", Offset = "0xB98C70", VA = "0x180B9A670")]
			get
			{
				return default(DirtyStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB9A650", Offset = "0xB98C50", VA = "0x180B9A650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84F92E0", Offset = "0x84F78E0", VA = "0x1884F92E0", Slot = "4")]
		public void SetMeshBufferSource(BBUSSLDKBTT source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84F8FE0", Offset = "0x84F75E0", VA = "0x1884F8FE0", Slot = "5")]
		public void RemoveMeshBufferSource(BBUSSLDKBTT source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84F9230", Offset = "0x84F7830", VA = "0x1884F9230", Slot = "6")]
		public void SetMeshBufferSourceRenderOrder(BBUSSLDKBTT source, int renderOrder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84F93D0", Offset = "0x84F79D0", VA = "0x1884F93D0", Slot = "9")]
		public bool TryGetMeshBufferSourceRenderOrder(BBUSSLDKBTT source, [Out] int renderOrder)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84F9130", Offset = "0x84F7730", VA = "0x1884F9130", Slot = "7")]
		public void SetMeshBufferSourceMaterial(BBUSSLDKBTT source, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84F92F0", Offset = "0x84F78F0", VA = "0x1884F92F0", Slot = "10")]
		public bool TryGetMeshBufferSourceMaterial(BBUSSLDKBTT source, [Out] Material material)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84F8A60", Offset = "0x84F7060", VA = "0x1884F8A60", Slot = "8")]
		public void MarkBufferSourceDirty(BBUSSLDKBTT source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84F7A40", Offset = "0x84F6040", VA = "0x1884F7A40")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84F8D50", Offset = "0x84F7350", VA = "0x1884F8D50")]
		protected void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84F8D40", Offset = "0x84F7340", VA = "0x1884F8D40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84F8CB0", Offset = "0x84F72B0", VA = "0x1884F8CB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84F88A0", Offset = "0x84F6EA0", VA = "0x1884F88A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84F7C80", Offset = "0x84F6280", VA = "0x1884F7C80")]
		private void IKWEDWITIUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84F8180", Offset = "0x84F6780", VA = "0x1884F8180")]
		private void LRVCHDZWQYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84F7E70", Offset = "0x84F6470", VA = "0x1884F7E70")]
		private void JHCCNREHJIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84F9700", Offset = "0x84F7D00", VA = "0x1884F9700")]
		private void ZTJZOPRFRDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84F89F0", Offset = "0x84F6FF0", VA = "0x1884F89F0")]
		private bool MUCFODRPJQO(BBUSSLDKBTT a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84F4EE0", Offset = "0x84F34E0", VA = "0x1884F4EE0")]
		private int BDUSJNVKDGH(BBUSSLDKBTT a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84F8E60", Offset = "0x84F7460", VA = "0x1884F8E60")]
		private int PBGLDAPARIZ(BBUSSLDKBTT a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84F9590", Offset = "0x84F7B90", VA = "0x1884F9590")]
		private void XBKRROHENMO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84F8090", Offset = "0x84F6690", VA = "0x1884F8090")]
		private void KDFVAMJROOS(int a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84F7B60", Offset = "0x84F6160", VA = "0x1884F7B60")]
		private void FQVIYCIJFEQ(int a, MeshBuffer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84F7C10", Offset = "0x84F6210", VA = "0x1884F7C10")]
		private void HVQOSEAXHQJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84F9690", Offset = "0x84F7C90", VA = "0x1884F9690")]
		private void ZEHLYZHHFEQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84F8B10", Offset = "0x84F7110", VA = "0x1884F8B10")]
		private void OTNFXAWNETR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84F85F0", Offset = "0x84F6BF0", VA = "0x1884F85F0")]
		private void LYSGKNRSDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84F9490", Offset = "0x84F7A90", VA = "0x1884F9490")]
		private bool ULKAEHCRWNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84F7A20", Offset = "0x84F6020", VA = "0x1884F7A20")]
		private static Material[] AANIWGOMXDH(MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84F89D0", Offset = "0x84F6FD0", VA = "0x1884F89D0")]
		private static void MRZQKMWGCQV(MeshRenderer a, Material[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84F90A0", Offset = "0x84F76A0", VA = "0x1884F90A0")]
		private static void SZEQMIEDJSS(MeshFilter a, Mesh b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84F9610", Offset = "0x84F7C10", VA = "0x1884F9610")]
		private static void XRDTERBDALP(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84F9A80", Offset = "0x84F8080", VA = "0x1884F9A80")]
		public MeshBufferRenderer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8E90", Offset = "0x3AB7490", VA = "0x183AB8E90")]
		[CompilerGenerated]
		private a UOTWNPYHMDX<a>(RenderComponents a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8CC0", Offset = "0x3AB72C0", VA = "0x183AB8CC0")]
		[CompilerGenerated]
		private b KCCCPPOKLVI<b>(b a, RenderComponents b, <>c__DisplayClass57_0 c) where b : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	public abstract class MeshBufferSource : MonoBehaviour, BBUSSLDKBTT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual BBUSSLDKBTT.GetMeshBufferDelegate ZSGHPCIPYOP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BHESRWURXJZ VDKZMAWJKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool SPDQPIRGLTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAFD1B0", Offset = "0xAFB7B0", VA = "0x180AFD1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IMRROJHFWEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xFC1340", Offset = "0xFBF940", VA = "0x180FC1340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x100E010", Offset = "0x100C610", VA = "0x18100E010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void CLZEBGQRXWI(BHESRWURXJZ a);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84F9F10", Offset = "0x84F8510", VA = "0x1884F9F10")]
		[Conditional("UNITY_EDITOR")]
		protected void QRFGFNFETCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84F9DC0", Offset = "0x84F83C0", VA = "0x1884F9DC0")]
		public void MarkSubMeshDataDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84F9E90", Offset = "0x84F8490", VA = "0x1884F9E90", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84F9E20", Offset = "0x84F8420", VA = "0x1884F9E20", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84F9C10", Offset = "0x84F8210", VA = "0x1884F9C10")]
		protected bool CLZEBGQRXWI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84F9F00", Offset = "0x84F8500", VA = "0x1884F9F00", Slot = "12")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84F9FB0", Offset = "0x84F85B0", VA = "0x1884F9FB0")]
		protected static void XRDTERBDALP(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		protected MeshBufferSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xE5D420", Offset = "0xE5BA20", VA = "0x180E5D420", Slot = "4")]
		private string PNURZMETWMF()
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
