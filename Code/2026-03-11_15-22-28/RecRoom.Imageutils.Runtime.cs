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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84DE990", Offset = "0x84DD990", VA = "0x1884DE990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x84DC6C0", Offset = "0x84DB6C0", VA = "0x1884DC6C0")]
		public CubeMapGenerator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TCZNRVMWJDX
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
			public bool EDAAVNHLDHK
			{
				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x84DEE90", Offset = "0x84DDE90", VA = "0x1884DEE90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x84DEEA0", Offset = "0x84DDEA0", VA = "0x1884DEEA0")]
			public Resolution(uint x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
			public Resolution(uint x, uint y)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84DEDB0", Offset = "0x84DDDB0", VA = "0x1884DEDB0")]
			public static Resolution Reduce(Resolution[] options, Resolution originalResolution, int times)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class KGDKEOUQHHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Resolution LHUSGYTGLTG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private Resolution? RNJDBFLWGJT;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public uint WOXVEZFDISB
			{
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x84DD2D0", Offset = "0x84DC2D0", VA = "0x1884DD2D0")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Resolution RLTMWBHWXMB
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x84DD2E0", Offset = "0x84DC2E0", VA = "0x1884DD2E0")]
				get
				{
					return default(Resolution);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD35590", Offset = "0xD34590", VA = "0x180D35590")]
			public KGDKEOUQHHD(Resolution a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84DD150", Offset = "0x84DC150", VA = "0x1884DD150")]
			private static Resolution DSCMKRWYQQD(Resolution a, DeviceMemoryTier b)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class ZMACEZWXMAQ
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Resolution JOZXGOENLXS;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Resolution QUXDVISOJEQ;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Resolution KPKWGNQDTOE;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Resolution RVICVIEEQVC;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Resolution HMSQFTDHVJX;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Resolution QYDUKRPAMXO;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			internal static readonly Resolution[] VSDHZRNUZNM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class MJOWPISCBGA
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Resolution JOZXGOENLXS;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Resolution QUXDVISOJEQ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Resolution KPKWGNQDTOE;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Resolution RVICVIEEQVC;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Resolution HMSQFTDHVJX;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Resolution QYDUKRPAMXO;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			internal static readonly Resolution[] VSDHZRNUZNM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class UAYOYGCXYYI
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Resolution JOZXGOENLXS;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Resolution QUXDVISOJEQ;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Resolution KPKWGNQDTOE;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Resolution RVICVIEEQVC;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Resolution HMSQFTDHVJX;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public static readonly Resolution QYDUKRPAMXO;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			internal static readonly Resolution[] VSDHZRNUZNM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class HVJVPJRZSHO
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly Resolution JOZXGOENLXS;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly Resolution QUXDVISOJEQ;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public static readonly Resolution KPKWGNQDTOE;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public static readonly Resolution RVICVIEEQVC;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public static readonly Resolution HMSQFTDHVJX;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public static readonly Resolution QYDUKRPAMXO;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			internal static readonly Resolution[] VSDHZRNUZNM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class ABIYTBNRNVV
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly Resolution JHPKWGMOMKO;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly Resolution UMVGBJAXOGX;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly Resolution HDNBKWGLVPS;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly Resolution DCYJOUVUQYR;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly Resolution HLFDNNBKBKN;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public static readonly Resolution JOZXGOENLXS;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public static readonly Resolution QUXDVISOJEQ;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly Resolution KPKWGNQDTOE;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly Resolution RVICVIEEQVC;

			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly Resolution HMSQFTDHVJX;

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public static readonly Resolution QYDUKRPAMXO;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			internal static readonly Resolution[] VSDHZRNUZNM;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x84DBF90", Offset = "0x84DAF90", VA = "0x1884DBF90")]
			public static Resolution METNTBEBQXA(uint a)
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Resolution YZVRWWERPVZ;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class BRHTGNFOVLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84DC660", Offset = "0x84DB660", VA = "0x1884DC660")]
		private static bool ZZCYJDXPQYN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84DC620", Offset = "0x84DB620", VA = "0x1884DC620")]
		public static bool OSXGAKJWNAG(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84DC430", Offset = "0x84DB430", VA = "0x1884DC430")]
		public static bool ALKYBEDDAYR(byte[] a, [Out] int b, [Out] int c)
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
		private class MVMHCRMPPZN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string CJDQDEKJGVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D FAOCUKLXUNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public TextureMemory OTREBRMFESF;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x84DD860", Offset = "0x84DC860", VA = "0x1884DD860")]
			public MVMHCRMPPZN(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3B30", Offset = "0x1AB2B30", VA = "0x181AB3B30")]
			public MVMHCRMPPZN(string a, Texture2D b, TextureMemory c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x84DD820", Offset = "0x84DC820", VA = "0x1884DD820", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CDVNMSUAISX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public ManagedTexture SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextureMemory EVBTHVBUYJX;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CDVNMSUAISX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84DC680", Offset = "0x84DB680", VA = "0x1884DC680")]
			internal void XBSPIIEXQXB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class UGWSJTRGBHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int KBWFKQCZRWU;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public UGWSJTRGBHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84DFC80", Offset = "0x84DEC80", VA = "0x1884DFC80")]
			internal EncodedImage GQXEXZDLDWB(Texture2D a)
			{
				return default(EncodedImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class WGRFUSVIBPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture EEFPOAKJQPK;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public WGRFUSVIBPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84DFCC0", Offset = "0x84DECC0", VA = "0x1884DFCC0")]
			internal void JQIVKYYTMVC()
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
		private VKQMZHJZWXK<Texture2D> VEIUXZEYGXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private MVMHCRMPPZN FYKBCYAEIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private VKQMZHJZWXK<EncodedImage> LWMUTVMFHNM;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private VKQMZHJZWXK<EncodedImage> WSTYHNFFPYO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private MVMHCRMPPZN GWMXTQHZLST
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84DE2B0", Offset = "0x84DD2B0", VA = "0x1884DE2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84DE720", Offset = "0x84DD720", VA = "0x1884DE720")]
		public ManagedTexture(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84DE780", Offset = "0x84DD780", VA = "0x1884DE780")]
		public ManagedTexture(string name, bool usePalette)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84DE270", Offset = "0x84DD270", VA = "0x1884DE270")]
		public void JTPOAFQIIJK(RenderTexture a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84DDA50", Offset = "0x84DCA50", VA = "0x1884DDA50")]
		public VKQMZHJZWXK<Texture2D> IBEXXKHAURL(TextureMemory a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84DD8C0", Offset = "0x84DC8C0", VA = "0x1884DD8C0")]
		public VKQMZHJZWXK<EncodedImage> GDCWJLOCSNZ(bool a = false, int b = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84DE450", Offset = "0x84DD450", VA = "0x1884DE450")]
		public VKQMZHJZWXK<EncodedImage> YVPDQAYXNZF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84DDD20", Offset = "0x84DCD20", VA = "0x1884DDD20")]
		private static VKQMZHJZWXK<Texture2D> JMWBFJCJBOY(string a, RenderTexture b, Texture2D c, bool d, TextureMemory e = TextureMemory.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84DE3B0", Offset = "0x84DD3B0", VA = "0x1884DE3B0")]
		public void YDCUBSZBWNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84DD8B0", Offset = "0x84DC8B0", VA = "0x1884DD8B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84DE350", Offset = "0x84DD350", VA = "0x1884DE350")]
		[CompilerGenerated]
		private VKQMZHJZWXK<byte[]> RGPVUHEYMZQ(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class FJILADBGDOX
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct RRTexturePlugin
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84DECB0", Offset = "0x84DDCB0", VA = "0x1884DECB0")]
			public unsafe static extern void SubmitPngForCompression(void* pngdata, void* dst, bool mipmap, bool bgr, bool etc2ordxt, [Out] int width, [Out] int height, [Out] bool rgba);
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NMXMBBMJYRH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public byte[] RXWGTHEVSGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public bool KLYDBLHKGPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public bool CPFVPCJCBHE;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NMXMBBMJYRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84DE7F0", Offset = "0x84DD7F0", VA = "0x1884DE7F0")]
			internal void IRQOTQPKLTX(NativeArray<byte> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ZOAXUNZKSXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action<NativeArray<byte>> BDECGKOAKIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public NativeArray<byte> AWFUSQIXMFC;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZOAXUNZKSXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84DFF30", Offset = "0x84DEF30", VA = "0x1884DFF30")]
			internal void VPPFGGZFKGT()
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
			[Cpp2IlInjected.Address(RVA = "0x84DF070", Offset = "0x84DE070", VA = "0x1884DF070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84DF280", Offset = "0x84DE280", VA = "0x1884DF280", Slot = "5")]
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
			private ZOAXUNZKSXA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Texture2D <outputTexture>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84DF2F0", Offset = "0x84DE2F0", VA = "0x1884DF2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84DF980", Offset = "0x84DE980", VA = "0x1884DF980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly bool JYVRXEQHOIT;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
		public static bool HWBBOAJJVNR(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84DC6E0", Offset = "0x84DB6E0", VA = "0x1884DC6E0")]
		[AsyncStateMachine(typeof(<Compress>d__4))]
		public static Task<Texture2D> DCDCUDFHFQX(byte[] a, bool b = false, bool c = false, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84DC8B0", Offset = "0x84DB8B0", VA = "0x1884DC8B0")]
		[AsyncStateMachine(typeof(<RunCompressionJob>d__5))]
		private static Task<Texture2D> LARDZSUCZSV(int a, int b, bool c, bool d, bool e, Action<NativeArray<byte>> compressionAction, CancellationToken f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84DC820", Offset = "0x84DB820", VA = "0x1884DC820")]
		private static TextureFormat EMESAGHOYWQ(bool a)
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
	internal static class HWLQKOKLEHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84DCC30", Offset = "0x84DBC30", VA = "0x1884DCC30")]
		public static bool LRLJCSXDXHU(byte[] a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84DCD10", Offset = "0x84DBD10", VA = "0x1884DCD10")]
		public static void QPTUXBBBMRX(byte[] a, [Out] int b, [Out] int c, [Out] PNGFormat d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84DCC70", Offset = "0x84DBC70", VA = "0x1884DCC70")]
		private static uint OHSZIHFKNBC(byte[] a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84DCFF0", Offset = "0x84DBFF0", VA = "0x1884DCFF0")]
		private static ulong UNJKZJIGYJN(byte[] a, int b)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class QFQODDYUCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84DEA10", Offset = "0x84DDA10", VA = "0x1884DEA10")]
		public static RenderTexture PVEQSAYKMYE(int a, int b, int c, Camera d, RenderTextureMemoryless e = RenderTextureMemoryless.None)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84DEC50", Offset = "0x84DDC50", VA = "0x1884DEC50")]
		public static void SSBUOJZUSNN(RenderTexture a)
		{
		}
	}
}
namespace RecRoom.Utils.Image.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class MEYTJXVWEVH<a> : IDisposable where a : notnull, IEquatable<a>
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
			[Cpp2IlInjected.Address(RVA = "0x1887C40", Offset = "0x1886C40", VA = "0x181887C40")]
			public ImageIdAndLoadOptions(a key, TextureLoadOptions loadOptions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x51D3910", Offset = "0x51D2910", VA = "0x1851D3910", Slot = "4")]
			public bool Equals(MEYTJXVWEVH<a>.ImageIdAndLoadOptions other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x51D3A90", Offset = "0x51D2A90", VA = "0x1851D3A90", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x51D4150", Offset = "0x51D3150", VA = "0x1851D4150", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x51D4450", Offset = "0x51D3450", VA = "0x1851D4450", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D0F420", Offset = "0x3D0E420", VA = "0x183D0F420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F810", Offset = "0x3D0E810", VA = "0x183D0F810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RMSRXUIDDBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public XZICGPHOFUJ<Task<Texture2D>> TJSFNBTZDNQ;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public RMSRXUIDDBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5E7CE00", Offset = "0x5E7BE00", VA = "0x185E7CE00")]
			internal void CZYUQNBJQDD()
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
			public MEYTJXVWEVH<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5001A80", Offset = "0x5000A80", VA = "0x185001A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5003940", Offset = "0x5002940", VA = "0x185003940", Slot = "5")]
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
			public MEYTJXVWEVH<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x525E540", Offset = "0x525D540", VA = "0x18525E540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x525ED00", Offset = "0x525DD00", VA = "0x18525ED00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const int YJMBDRHOHRO = 1;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly SemaphoreSlim VEJVARYJJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Func<a, CancellationToken, Task<byte[]>>? KMPEJOFORBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? MSIYMEUECWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Func<a, string>? GLGEIVLCPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly EWAWEPPZUTA<ImageIdAndLoadOptions, Texture2D> MJGLXODIZPY;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5A89D90", Offset = "0x5A88D90", VA = "0x185A89D90")]
		public MEYTJXVWEVH(Func<a, CancellationToken, Task<byte[]>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5A89BB0", Offset = "0x5A88BB0", VA = "0x185A89BB0")]
		public MEYTJXVWEVH(Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>> a, [Optional] Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5A89A00", Offset = "0x5A88A00", VA = "0x185A89A00")]
		private MEYTJXVWEVH(Func<a, CancellationToken, Task<byte[]>>? getImageFunc, Func<a, TextureLoadOptions, CancellationToken, Task<Texture2D>>? getTextureFunc, Func<a, string>? getImageNameFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5A88EF0", Offset = "0x5A87EF0", VA = "0x185A88EF0")]
		public TEHJZDMBIST<Texture2D> UQIPVSHJNTB(a a, TextureLoadOptions b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5A87CD0", Offset = "0x5A86CD0", VA = "0x185A87CD0")]
		public void AWCLHFKFFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5A88190", Offset = "0x5A87190", VA = "0x185A88190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5A886B0", Offset = "0x5A876B0", VA = "0x185A886B0")]
		[AsyncStateMachine(typeof(MEYTJXVWEVH<>.<CreateTexture>d__13))]
		private Task<Texture2D> ISWRLGYSOZM(ImageIdAndLoadOptions a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5A88810", Offset = "0x5A87810", VA = "0x185A88810")]
		[AsyncStateMachine(typeof(MEYTJXVWEVH<>.<LoadTexture>d__14))]
		private Task<Texture2D> IUENDVUFOEG(byte[] a, TextureLoadOptions b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5A892B0", Offset = "0x5A882B0", VA = "0x185A892B0")]
		private void WVBUEWIOYTY(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5A88250", Offset = "0x5A87250", VA = "0x185A88250")]
		private bool HZOCVWMDBHR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5A87D60", Offset = "0x5A86D60", VA = "0x185A87D60")]
		private void BZZROZWXLRB(byte[] a, [Out] int b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5A87D30", Offset = "0x5A86D30", VA = "0x185A87D30")]
		private bool BOETPXZJIVN(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5A892C0", Offset = "0x5A882C0", VA = "0x185A892C0")]
		[AsyncStateMachine(typeof(MEYTJXVWEVH<>.<<GetOrAdd>g__DelayDispose|9_1>d))]
		[CompilerGenerated]
		internal static Task YMILYUZQFDF(IDisposable a)
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
