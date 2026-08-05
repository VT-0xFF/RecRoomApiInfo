using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FastMesh
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class WRJOCDCYTKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84863A0", Offset = "0x84853A0", VA = "0x1884863A0")]
		public static float2 YVUDWIUOEHH(this RectAlignment a)
		{
			return default(float2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum RectAlignment : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		BottomCenter,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		CenterLeft,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Center,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		CenterRight,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		TopCenter,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		TopRight
	}
}
namespace RecRoom.FastMesh.Core
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct float2Rect : IEquatable<float2Rect>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const int BYTE_SIZE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float width;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float height;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float2 position;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float2 size;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2EA98A0", Offset = "0x2EA88A0", VA = "0x182EA98A0")]
		public float2Rect(float2 position, float2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8488A70", Offset = "0x8487A70", VA = "0x188488A70")]
		public void AKGSYCXFFIN([Out] float2 a, [Out] float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8488A90", Offset = "0x8487A90", VA = "0x188488A90")]
		public float2 BYNUIHCKMEH(float2 a)
		{
			return default(float2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x181BE70", Offset = "0x181AE70", VA = "0x18181BE70", Slot = "4")]
		public bool Equals(float2Rect other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8488AC0", Offset = "0x8487AC0", VA = "0x188488AC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8488BC0", Offset = "0x8487BC0", VA = "0x188488BC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8488C70", Offset = "0x8487C70", VA = "0x188488C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8488E80", Offset = "0x8487E80", VA = "0x188488E80", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct floatMinMax : IEquatable<floatMinMax>, IEquatable<float2>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int BYTE_SIZE = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float max;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 value;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84892C0", Offset = "0x84882C0", VA = "0x1884892C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8489230", Offset = "0x8488230", VA = "0x188489230", Slot = "6")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8489090", Offset = "0x8488090", VA = "0x188489090", Slot = "4")]
		public bool Equals(floatMinMax other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8489180", Offset = "0x8488180", VA = "0x188489180", Slot = "5")]
		public bool Equals(float2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84890D0", Offset = "0x84880D0", VA = "0x1884890D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84891B0", Offset = "0x84881B0", VA = "0x1884891B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Obfuscation(Exclude = true)]
	public struct QuadVertex
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[Obfuscation(Exclude = true)]
		public static class Constants
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly VertexAttributeDescriptor[] layout;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Color32 color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float2 uv;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Obfuscation(Exclude = true)]
	public class LayoutRect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private float2Rect localRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float2 parentAlignmentNormalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LayoutRect parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<LayoutRect> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private LayoutRectDirtyStates cacheDirtyState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float2Rect cachedLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int cacheVersion;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8486BE0", Offset = "0x8485BE0", VA = "0x188486BE0")]
		public LayoutRect([Optional] LayoutRect parent, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8486D20", Offset = "0x8485D20", VA = "0x188486D20")]
		public LayoutRect(LayoutRect parent, RectAlignment parentAlignment, bool matchParentRect = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8486680", Offset = "0x8485680", VA = "0x188486680")]
		public void InitVersion(int toTrack)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84865E0", Offset = "0x84855E0", VA = "0x1884865E0")]
		public bool CheckVersionChange(int toCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8486650", Offset = "0x8485650", VA = "0x188486650")]
		public float2Rect GetWorldLayout()
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84865F0", Offset = "0x84855F0", VA = "0x1884865F0")]
		public bool GetWorldLayoutIfNew(int versionToCheck, [Out] float2Rect worldLayout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8486790", Offset = "0x8485790", VA = "0x188486790")]
		public void SetHeight(float height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8486260", Offset = "0x8485260", VA = "0x188486260")]
		public void SetLocalRect([In] float2 localRectPos, [In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84868A0", Offset = "0x84858A0", VA = "0x1884868A0")]
		public void SetLocalRect([In] float2Rect localRect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8486850", Offset = "0x8485850", VA = "0x188486850")]
		public void SetLocalRectSize([In] float2 localRectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8486800", Offset = "0x8485800", VA = "0x188486800")]
		public void SetLocalRectPosition(float2 localRectPos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8486960", Offset = "0x8485960", VA = "0x188486960")]
		public void SetParent(LayoutRect newParent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8486910", Offset = "0x8485910", VA = "0x188486910")]
		public void SetParentAlignment(float2 alignmentNormalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84868B0", Offset = "0x84858B0", VA = "0x1884868B0")]
		public void SetParentAlignment(RectAlignment rectAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84866A0", Offset = "0x84856A0", VA = "0x1884866A0")]
		public void MatchParentRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8486700", Offset = "0x8485700", VA = "0x188486700")]
		public void SetFromRectTransform(Transform viewer, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8486690", Offset = "0x8485690", VA = "0x188486690")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8486A10", Offset = "0x8485A10", VA = "0x188486A10")]
		private LayoutRectDirtyStates UpdateCache()
		{
			return default(LayoutRectDirtyStates);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum LayoutRectDirtyStates : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Clean,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Dirty
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class UESJZAHIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Vector3[] EYRROJQMXZH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8486F90", Offset = "0x8485F90", VA = "0x188486F90")]
		public static float2Rect MFBSYHIOBFN(Transform a, RectTransform b)
		{
			return default(float2Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84872A0", Offset = "0x84862A0", VA = "0x1884872A0")]
		public static void SCXPEYRSKCT(Vector3[] a, [Out] float2 b, [Out] float2 c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PGHCKATKHKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int[] GATQWLBPGLP;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8486E50", Offset = "0x8485E50", VA = "0x188486E50")]
		public static void EBOREFOELIS([In] int indexBufferIdx, [Out] ushort a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ZTPEODNGGDI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <>c__DisplayClass27_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float minX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float minY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float minZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public float maxX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public float maxY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public float maxZ;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8488010", Offset = "0x8487010", VA = "0x188488010")]
		public static void LGQSIUYRCPQ(float3[] a, [In] float2 rectPosition, [In] float2 rectSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84889E0", Offset = "0x84879E0", VA = "0x1884889E0")]
		public static void ZTZZOYHFLYA(float2[] a, [In] float2 uvMin, [In] float2 uvMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84874E0", Offset = "0x84864E0", VA = "0x1884874E0")]
		public static void BHNMDMYTQGU(float3[] a, [In] float shiftWidth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8487840", Offset = "0x8486840", VA = "0x188487840")]
		public static void BJMHLEXABPD(QuadVertex[] a, [In] int vertexBufferIdx, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8487DF0", Offset = "0x8486DF0", VA = "0x188487DF0")]
		public static void GYUTEJRFTBN(QuadVertex[] a, int b, [In] float3[] quadPositions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8487AC0", Offset = "0x8486AC0", VA = "0x188487AC0")]
		public static void EWZUFZAENHD(QuadVertex[] a, [In] int vertexBufferIdx, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8488960", Offset = "0x8487960", VA = "0x188488960")]
		public static void WKUXSHACNSD(QuadVertex[] a, int b, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84873D0", Offset = "0x84863D0", VA = "0x1884873D0")]
		public static void APOWJGFLUHB(QuadVertex[] a, [In] int vertexBufferIdx, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8487F00", Offset = "0x8486F00", VA = "0x188487F00")]
		public static void JHZCTGYZVCN(QuadVertex[] a, int b, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84887E0", Offset = "0x84877E0", VA = "0x1884887E0")]
		public static void TBQPHJGRJDF(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8487BD0", Offset = "0x8486BD0", VA = "0x188487BD0")]
		public static void GESQOOPEJWR(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8488110", Offset = "0x8487110", VA = "0x188488110")]
		public static void OUEBITGNBDW(QuadVertex[] a, int b, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8488290", Offset = "0x8487290", VA = "0x188488290")]
		public static void PYWLYEOVCCA(QuadVertex[] a, int b, [In] float3[] quadPositions, [In] Color32 quadColor, [In] float2[] quadUVs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8487990", Offset = "0x8486990", VA = "0x188487990")]
		public static void ERAETSMWKFA(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8487950", Offset = "0x8486950", VA = "0x188487950")]
		public static void DZULUBGOZQY(ushort[] a, int b, [In] int indexBufferEndIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8487B40", Offset = "0x8486B40", VA = "0x188487B40")]
		public static void FXXTHILVZWV(ushort[] a, [In] int indexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8488520", Offset = "0x8487520", VA = "0x188488520")]
		public static void SECQVBQGNQR(ushort[] a, [In] int indexBufferIdx, [In] int vertexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84885E0", Offset = "0x84875E0", VA = "0x1884885E0")]
		public static Bounds SUYYMLYIVMM([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8487550", Offset = "0x8486550", VA = "0x188487550")]
		public static Bounds BHNZZLSKXSL([In] QuadVertex[] vertexBuffer, [In] ushort[] indexBuffer, [In] int indexBufferCount)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8488090", Offset = "0x8487090", VA = "0x188488090")]
		[CompilerGenerated]
		internal static void MHTMZFRNVTC([In] float3 p, <>c__DisplayClass27_0 a)
		{
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
