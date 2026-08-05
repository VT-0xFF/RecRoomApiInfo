using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Async;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
using Unity.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9884F20", Offset = "0x9883D20", VA = "0x189884F20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9883940", Offset = "0x9882740", VA = "0x189883940")]
		public CubeMapGenerator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class AKJHEIBSQXF
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Resolution
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public uint x;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public uint y;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool DISBCVKKZAW
			{
				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x98853D0", Offset = "0x98841D0", VA = "0x1898853D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x98854C0", Offset = "0x98842C0", VA = "0x1898854C0")]
			public Resolution(uint x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
			public Resolution(uint x, uint y)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x98853E0", Offset = "0x98841E0", VA = "0x1898853E0")]
			public static Resolution Reduce(Resolution[] options, Resolution originalResolution, int times)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class TJDGDPWQLFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Resolution PTFWMMXTPFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private Resolution? QJOYLFOYSRJ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public uint ABENRSAJXKL
			{
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x9885F60", Offset = "0x9884D60", VA = "0x189885F60")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Resolution ULUVVWAZVWT
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x9885C10", Offset = "0x9884A10", VA = "0x189885C10")]
				get
				{
					return default(Resolution);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xF78950", Offset = "0xF77750", VA = "0x180F78950")]
			public TJDGDPWQLFN(Resolution a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9885F70", Offset = "0x9884D70", VA = "0x189885F70")]
			private static Resolution VCSQZHWEZER(Resolution a, DeviceMemoryTier b)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class NUTFGAMIRLQ
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Resolution FNPRIMHNIAC;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Resolution BLJOSFRHELM;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Resolution BQLRHAUNFGO;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Resolution FSRTXHKTIVE;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Resolution ZCKDUIUVQLN;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Resolution LHFWCHQEYOC;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			internal static readonly Resolution[] VLWTYVYUEMA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class BHPDRQIEMDM
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Resolution FNPRIMHNIAC;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Resolution BLJOSFRHELM;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Resolution BQLRHAUNFGO;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Resolution FSRTXHKTIVE;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Resolution ZCKDUIUVQLN;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Resolution LHFWCHQEYOC;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			internal static readonly Resolution[] VLWTYVYUEMA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class SVDEZXOLKWO
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Resolution FNPRIMHNIAC;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Resolution BLJOSFRHELM;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Resolution BQLRHAUNFGO;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Resolution FSRTXHKTIVE;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Resolution ZCKDUIUVQLN;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Resolution LHFWCHQEYOC;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			internal static readonly Resolution[] VLWTYVYUEMA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class TMYCNMMSAZE
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Resolution FNPRIMHNIAC;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Resolution BLJOSFRHELM;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Resolution BQLRHAUNFGO;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Resolution FSRTXHKTIVE;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Resolution ZCKDUIUVQLN;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Resolution LHFWCHQEYOC;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			internal static readonly Resolution[] VLWTYVYUEMA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class UREZHJTKMNX
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Resolution XZSYACQAOIY;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Resolution TMZBROOSAZX;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Resolution DBPSWIHESPY;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Resolution ZIDSNIRCOSD;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Resolution CKYZZFOESSD;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Resolution FNPRIMHNIAC;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Resolution BLJOSFRHELM;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Resolution BQLRHAUNFGO;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Resolution FSRTXHKTIVE;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Resolution ZCKDUIUVQLN;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Resolution LHFWCHQEYOC;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			internal static readonly Resolution[] VLWTYVYUEMA;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9886D30", Offset = "0x9885B30", VA = "0x189886D30")]
			public static Resolution OWKFBQOBSAY(uint a)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Resolution VFSGTOVYMCJ;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class IIEPYHUGTYA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9883D30", Offset = "0x9882B30", VA = "0x189883D30")]
		private static bool WSLPLZMYNVJ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9883CF0", Offset = "0x9882AF0", VA = "0x189883CF0")]
		public static bool PABIBACXJNG(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9883B00", Offset = "0x9882900", VA = "0x189883B00")]
		public static bool GQHAJHDBLSX(byte[] a, [Out] int b, [Out] int c)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum TextureMemory : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class OCBVXZYBFNX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string TRYGGLEORZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D QKPEJIMIOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public TextureMemory KJZFYXPXJMH;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9884FE0", Offset = "0x9883DE0", VA = "0x189884FE0")]
			public OCBVXZYBFNX(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D20010", Offset = "0x1D1EE10", VA = "0x181D20010")]
			public OCBVXZYBFNX(string a, Texture2D b, TextureMemory c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9884FA0", Offset = "0x9883DA0", VA = "0x189884FA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LMHYOZGZEPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public ManagedTexture XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextureMemory ARZBYEGHEHN;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public LMHYOZGZEPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9883D90", Offset = "0x9882B90", VA = "0x189883D90")]
			internal void THKXMGXMMGR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZVHFLELJGRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int EYTPWMOSRFU;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZVHFLELJGRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9887620", Offset = "0x9886420", VA = "0x189887620")]
			internal EncodedImage QQIVIKZBTZR(Texture2D a)
			{
				return default(EncodedImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class UUXWEKIUFRE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture DGRXUPJPUUG;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UUXWEKIUFRE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9887220", Offset = "0x9886020", VA = "0x189887220")]
			internal void FRYKFGSNDHY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private CCAFLELIKTY<Texture2D> GWTRCISFVQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private OCBVXZYBFNX FXGNERPKBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private CCAFLELIKTY<EncodedImage> VNEQXTPHXQY;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CCAFLELIKTY<EncodedImage> XIUBUVVSLUY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD3CC00", Offset = "0xD3BA00", VA = "0x180D3CC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private OCBVXZYBFNX XJVDRKRMJRX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9884B90", Offset = "0x9883990", VA = "0x189884B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9884C30", Offset = "0x9883A30", VA = "0x189884C30")]
		public ManagedTexture(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9884C90", Offset = "0x9883A90", VA = "0x189884C90")]
		public ManagedTexture(string name, bool usePalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9884880", Offset = "0x9883680", VA = "0x189884880")]
		public void RYLGOYFQUFQ(RenderTexture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98848C0", Offset = "0x98836C0", VA = "0x1898848C0")]
		public CCAFLELIKTY<Texture2D> WREFCWRWSCX(TextureMemory a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9883E80", Offset = "0x9882C80", VA = "0x189883E80")]
		public CCAFLELIKTY<EncodedImage> HUZMSETAEDL(bool a = false, int b = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98845B0", Offset = "0x98833B0", VA = "0x1898845B0")]
		public CCAFLELIKTY<EncodedImage> OUJQLYODUWN(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9884000", Offset = "0x9882E00", VA = "0x189884000")]
		private static CCAFLELIKTY<Texture2D> JERZWJRSNHU(string a, RenderTexture b, Texture2D c, bool d, TextureMemory e = TextureMemory.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9883DD0", Offset = "0x9882BD0", VA = "0x189883DD0")]
		public void CXUYLABZXUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9883E70", Offset = "0x9882C70", VA = "0x189883E70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9884550", Offset = "0x9883350", VA = "0x189884550")]
		[CompilerGenerated]
		private CCAFLELIKTY<byte[]> NISUDABSWRS(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class WNVHJEUTGYR
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct RRTexturePlugin
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x98852D0", Offset = "0x98840D0", VA = "0x1898852D0")]
			public unsafe static extern void SubmitPngForCompression(void* pngdata, void* dst, bool mipmap, bool bgr, bool etc2ordxt, [Out] int width, [Out] int height, [Out] bool rgba);
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public byte[] YZPKCZWELJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public bool YGUZODYNQJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public bool PUDIAWJNNKQ;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9883960", Offset = "0x9882760", VA = "0x189883960")]
			internal void ENOIAVROOWL(NativeArray<byte> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action<NativeArray<byte>> QLRKDWWLUFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public NativeArray<byte> NUSIXBFDOIO;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9883D50", Offset = "0x9882B50", VA = "0x189883D50")]
			internal void IHSTHQMWGLP()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <Compress>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public byte[] imageBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public bool generateMipMaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool makeTextureReadable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9886310", Offset = "0x9885110", VA = "0x189886310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9886520", Offset = "0x9885320", VA = "0x189886520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <RunCompressionJob>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action<NativeArray<byte>> compressionAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool hasAlpha;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int width;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int height;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool generateMipMaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public bool makeTextureReadable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private KRDFVZFEZPK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Texture2D <outputTexture>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9886590", Offset = "0x9885390", VA = "0x189886590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9886C20", Offset = "0x9885A20", VA = "0x189886C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly bool LYPVBDOWOCR;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
		public static bool GEYZWGSKMXD(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9887490", Offset = "0x9886290", VA = "0x189887490")]
		[AsyncStateMachine(typeof(<Compress>d__4))]
		public static Task<Texture2D> ZWAUKJIJZTP(byte[] a, bool b = false, bool c = false, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9887340", Offset = "0x9886140", VA = "0x189887340")]
		[AsyncStateMachine(typeof(<RunCompressionJob>d__5))]
		private static Task<Texture2D> KLNFQOCKZQP(int a, int b, bool c, bool d, bool e, Action<NativeArray<byte>> compressionAction, CancellationToken f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98872A0", Offset = "0x98860A0", VA = "0x1898872A0")]
		private static TextureFormat FMMIBIWFFSO(bool a)
		{
			return default(TextureFormat);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal enum PNGFormat
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		RGB,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		BGR,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		ABGR
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class SGIKVJPGNWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98857B0", Offset = "0x98845B0", VA = "0x1898857B0")]
		public static bool EITAGZOJKOM(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98854D0", Offset = "0x98842D0", VA = "0x1898854D0")]
		public static void AYQIBVBIHVR(byte[] a, [Out] int b, [Out] int c, [Out] PNGFormat d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9885950", Offset = "0x9884750", VA = "0x189885950")]
		private static uint ZOUPFNKXCKS(byte[] a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98857F0", Offset = "0x98845F0", VA = "0x1898857F0")]
		private static ulong GRBBOWLZAPT(byte[] a, int b)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class ROTFSTGEXLT
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9885090", Offset = "0x9883E90", VA = "0x189885090")]
		public static RenderTexture XLHSBMWNLXQ(int a, int b, int c, Camera d, RenderTextureMemoryless e = RenderTextureMemoryless.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9885030", Offset = "0x9883E30", VA = "0x189885030")]
		public static void DMTRVTWHQFT(RenderTexture a)
		{
		}
	}
}
namespace RecRoom.Utils.Image.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class HQMGKLVJKLB<a> : IDisposable where a : notnull, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private readonly struct ImageIdAndLoadOptions : IEquatable<ImageIdAndLoadOptions>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public readonly a ImageId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public readonly TextureLoadOptions LoadOptions;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1AF6310", Offset = "0x1AF5110", VA = "0x181AF6310")]
			public ImageIdAndLoadOptions(a key, TextureLoadOptions loadOptions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x659A860", Offset = "0x6599660", VA = "0x18659A860", Slot = "4")]
			public bool Equals(HQMGKLVJKLB<a>.ImageIdAndLoadOptions other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x659A260", Offset = "0x6599060", VA = "0x18659A260", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x659ADA0", Offset = "0x6599BA0", VA = "0x18659ADA0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x659B040", Offset = "0x6599E40", VA = "0x18659B040", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <<GetOrAdd>g__DelayDispose|9_1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public IDisposable disposable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x41B0F50", Offset = "0x41AFD50", VA = "0x1841B0F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x41B1580", Offset = "0x41B0380", VA = "0x1841B1580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public ULKKXRJFDXF<Task<Texture2D>> JYRTSMUWNHW;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7CCBFF0", Offset = "0x7CCADF0", VA = "0x187CCBFF0")]
			internal void BOWZFWPAPJB()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <CreateTexture>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public ImageIdAndLoadOptions cacheKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public HQMGKLVJKLB<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private a <imageId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TextureLoadOptions <textureLoadOptions>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter<byte[]> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x64C87E0", Offset = "0x64C75E0", VA = "0x1864C87E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x64CA490", Offset = "0x64C9290", VA = "0x1864CA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <LoadTexture>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public TextureLoadOptions textureLoadOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HQMGKLVJKLB<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public byte[] imageBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool <generateMipMaps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private bool <makeTextureReadable>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private bool <usePointFiltering>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private bool <useClampWrapMode>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <width>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private int <height>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x694B8D0", Offset = "0x694A6D0", VA = "0x18694B8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x694C810", Offset = "0x694B610", VA = "0x18694C810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const int TCDBJQUJCTQ = 1;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly SemaphoreSlim FQVDGMNIMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Func<a, CancellationToken, Task<byte[]>>? KXTSPYZFVJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? CCJOZNKAVTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Func<a, string>? CGEHJIBQTFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly LIPKHNPTING<ImageIdAndLoadOptions, Texture2D> RMSWMRHEIQA;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x64761F0", Offset = "0x6474FF0", VA = "0x1864761F0")]
		public HQMGKLVJKLB(Func<a, CancellationToken, Task<byte[]>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6476700", Offset = "0x6475500", VA = "0x186476700")]
		public HQMGKLVJKLB(Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6476420", Offset = "0x6475220", VA = "0x186476420")]
		private HQMGKLVJKLB(Func<a, CancellationToken, Task<byte[]>>? getImageFunc, Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? getTextureFunc, Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6475D60", Offset = "0x6474B60", VA = "0x186475D60")]
		public OIRALRYLARL<Texture2D> WEZWPWCRGIB(a a, TextureLoadOptions b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6474C00", Offset = "0x6473A00", VA = "0x186474C00")]
		public void JJLADVYKRIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6474820", Offset = "0x6473620", VA = "0x186474820", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6474C30", Offset = "0x6473A30", VA = "0x186474C30")]
		[AsyncStateMachine(typeof(HQMGKLVJKLB<>.<CreateTexture>d__13))]
		private Task<Texture2D> JYDUWTDOJTG(ImageIdAndLoadOptions a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6475760", Offset = "0x6474560", VA = "0x186475760")]
		[AsyncStateMachine(typeof(HQMGKLVJKLB<>.<LoadTexture>d__14))]
		private Task<Texture2D> WASUWPYGFWE(byte[] a, TextureLoadOptions b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64746C0", Offset = "0x64734C0", VA = "0x1864746C0")]
		private void BPLWPPFVFEM(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64746B0", Offset = "0x64734B0", VA = "0x1864746B0")]
		private bool ADKQIGDTONH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x64748D0", Offset = "0x64736D0", VA = "0x1864748D0")]
		private void HHNCYEALSQV(byte[] a, [Out] int b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6475F20", Offset = "0x6474D20", VA = "0x186475F20")]
		private bool YYJJBMZXKZP(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64753B0", Offset = "0x64741B0", VA = "0x1864753B0")]
		[AsyncStateMachine(typeof(HQMGKLVJKLB<>.<<GetOrAdd>g__DelayDispose|9_1>d))]
		[CompilerGenerated]
		internal static Task KNPWCSMIXFD(IDisposable a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Flags]
	public enum TextureLoadOptions : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NoMipMaps = 1,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		MakeTextureReadable = 2,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		CompressTexture = 4,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		UseNearestTextureFiltering = 8,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		UseClampWrapMode = 0x10
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
