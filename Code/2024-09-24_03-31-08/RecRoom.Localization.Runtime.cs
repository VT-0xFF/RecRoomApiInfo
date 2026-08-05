using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Metadata;
using UnityEngine.Localization.Pseudo;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Localization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8F30", Offset = "0x6BD7930", VA = "0x186BD8F30", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class FontAssetReference : AssetReferenceT<TMP_FontAsset>, IEquatable<FontAssetReference>, IEqualityComparer<FontAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BD34C0", Offset = "0x6BD1EC0", VA = "0x186BD34C0", Slot = "23")]
		public bool Equals(FontAssetReference CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BD35B0", Offset = "0x6BD1FB0", VA = "0x186BD35B0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BD36C0", Offset = "0x6BD20C0", VA = "0x186BD36C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3590", Offset = "0x6BD1F90", VA = "0x186BD3590", Slot = "24")]
		public bool Equals(FontAssetReference OFCNMBDJPHM, FontAssetReference CONCKFNNMJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF940", Offset = "0x5AAE340", VA = "0x185AAF940", Slot = "25")]
		public int GetHashCode(FontAssetReference FHFDEAHMMBI)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LazyEmojiSpriteAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private SpriteAssetReference emojiAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private List<string> emojiNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private AsyncOperationHandle<TMP_SpriteAsset> emojiAssetHandle;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public SpriteAssetReference EmojiAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<string> EmojiNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		public LazyEmojiSpriteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LazyFallbackFontAsset : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class Range
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			[SerializeField]
			private uint minimum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			[SerializeField]
			private uint maximum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			[SerializeField]
			private byte assetReferenceIndex;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public uint Minimum
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public byte AssetReferenceIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6BD7B30", Offset = "0x6BD6530", VA = "0x186BD7B30")]
			public bool DDGNJIHOIKG(uint GHECMOPCOLE)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private List<FontAssetReference> fallbackFontAssetReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private List<Range> ranges;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> _fallbackFontAssetHandles;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HasFallbackFontReferences
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6BD55E0", Offset = "0x6BD3FE0", VA = "0x186BD55E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyDictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> FallbackFontAssetHandles
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4DA0", Offset = "0x6BD37A0", VA = "0x186BD4DA0")]
		public bool GGEODAPCABE(uint GHECMOPCOLE, [Out] TMP_FontAsset HEDBPEHMDEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD51E0", Offset = "0x6BD3BE0", VA = "0x186BD51E0")]
		public void JMHNHGLPKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD50D0", Offset = "0x6BD3AD0", VA = "0x186BD50D0")]
		public bool JCCLPCMHEOA(FontAssetReference PJDFBOFKBGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5430", Offset = "0x6BD3E30", VA = "0x186BD5430")]
		private bool PILJJGLBHPJ(uint GHECMOPCOLE, [Out] FontAssetReference PJDFBOFKBGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5550", Offset = "0x6BD3F50", VA = "0x186BD5550")]
		public LazyFallbackFontAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SpriteAssetReference : AssetReferenceT<TMP_SpriteAsset>, IEquatable<SpriteAssetReference>, IEqualityComparer<SpriteAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BD34C0", Offset = "0x6BD1EC0", VA = "0x186BD34C0", Slot = "23")]
		public bool Equals(SpriteAssetReference CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8930", Offset = "0x6BD7330", VA = "0x186BD8930", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BD36C0", Offset = "0x6BD20C0", VA = "0x186BD36C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3590", Offset = "0x6BD1F90", VA = "0x186BD3590", Slot = "24")]
		public bool Equals(SpriteAssetReference OFCNMBDJPHM, SpriteAssetReference CONCKFNNMJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF940", Offset = "0x5AAE340", VA = "0x185AAF940", Slot = "25")]
		public int GetHashCode(SpriteAssetReference FHFDEAHMMBI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MIHDOFKDPCI<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x469A1D0", Offset = "0x4698BD0", VA = "0x18469A1D0")]
	public MIHDOFKDPCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PIGIOAGFGLN : IEmojiProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LazyEmojiSpriteAsset NNPHJOFBFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AsyncOperationHandle<TMP_SpriteAsset> ILHJIHJLJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private TMP_SpriteAsset POOJHNLGNCF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<string> LIKIAGFIJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1478400", Offset = "0x1476E00", VA = "0x181478400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public TMP_SpriteAsset AHMBBMPIICM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD69C0", Offset = "0x6BD53C0", VA = "0x186BD69C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6970", Offset = "0x6BD5370", VA = "0x186BD6970")]
	public PIGIOAGFGLN(LazyEmojiSpriteAsset NNPHJOFBFIB, bool OBILMCEGBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6870", Offset = "0x6BD5270", VA = "0x186BD6870")]
	private TMP_SpriteAsset EBAPAGGLLNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD67E0", Offset = "0x6BD51E0", VA = "0x186BD67E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HJHCOMJBAGC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MIJEGGAMOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MIJEGGAMOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6300", Offset = "0x6BD4D00", VA = "0x186BD6300")]
		internal bool NNMLABHGGCA(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3C10", Offset = "0x6BD2610", VA = "0x186BD3C10")]
	public static List<Locale> JGMHHPEMLFH(this LocalizationSettings ONONNKMGMKH, bool LBHDCPAKHMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4790", Offset = "0x6BD3190", VA = "0x186BD4790")]
	public static void PHICDBHDDDI(Locale CJKDACOPJGD, string AIDGFEHNLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3EB0", Offset = "0x6BD28B0", VA = "0x186BD3EB0")]
	public static Locale KEHDGBNFBAG(this LocalizationSettings ONONNKMGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BD40C0", Offset = "0x6BD2AC0", VA = "0x186BD40C0")]
	private static void NMGBDLAJHIH(string BHLFEIAFPIP, string CJFHEPLAJPI, string FCLIEHCKPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BD43D0", Offset = "0x6BD2DD0", VA = "0x186BD43D0")]
	public static void OGIDCKFIAGK(this LocalizationSettings ONONNKMGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4750", Offset = "0x6BD3150", VA = "0x186BD4750")]
	public static Locale ONJFFCJHOBD(this LocalizationSettings ONONNKMGMKH, string EBLJLDGJMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4480", Offset = "0x6BD2E80", VA = "0x186BD4480")]
	public static Locale ONJFFCJHOBD(this ILocalesProvider CDNGDGIHDCC, string EBLJLDGJMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4200", Offset = "0x6BD2C00", VA = "0x186BD4200")]
	public static string ODKPOHJFCAK(this Locale CJKDACOPJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3940", Offset = "0x6BD2340", VA = "0x186BD3940")]
	public static string APLBJHDKBJA(this Locale CJKDACOPJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BD39C0", Offset = "0x6BD23C0", VA = "0x186BD39C0")]
	public static string HDGMLNMANCC(this CultureInfo DBLOKNFCMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3AC0", Offset = "0x6BD24C0", VA = "0x186BD3AC0")]
	public static string IBDCCHPNIJJ(this LocalizedString ALPPNEAAFOJ, string COMNIKKFEEB, object IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3E60", Offset = "0x6BD2860", VA = "0x186BD3E60")]
	public static string KAILMAIEMLJ(this LocalizedString ALPPNEAAFOJ, string FNKHHODCBNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IPFMCJFJBEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GPBNLIHBEDI<T> : IAsyncStateMachine where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T enumValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4CB0", Offset = "0x3EE36B0", VA = "0x183EE4CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5350", Offset = "0x3EE3D50", VA = "0x183EE5350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AMAHENBKBPL<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AMAHENBKBPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA52C0", Offset = "0x3EA3CC0", VA = "0x183EA52C0")]
		internal void MHKEDHFCGAD(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Dictionary<(Type, string), string> KFICIANINKE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Dictionary<Type, string> EOOJJJIPIEB;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2DABFB0", Offset = "0x2DAA9B0", VA = "0x182DABFB0")]
	private static string NOPPDFOLJGL<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4AB0", Offset = "0x6BD34B0", VA = "0x186BD4AB0")]
	private static bool DBKIKNODAFD((Type type, string name) EEIBOIPGNKJ, [Out] string FDBHCGNAEND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB680", Offset = "0x2DAA080", VA = "0x182DAB680")]
	public static string FCDPFFAJPFL<T>(this T OEDIDFDHHOH, params object[] PKMHPILPCEB) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2DABDA0", Offset = "0x2DAA7A0", VA = "0x182DABDA0")]
	[AsyncStateMachine(typeof(GPBNLIHBEDI<>))]
	public static Task<string> MLBPEOOFHKF<T>(this T OEDIDFDHHOH, params object[] PKMHPILPCEB) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB8C0", Offset = "0x2DAA2C0", VA = "0x182DAB8C0")]
	private static bool HOBKOLFBAOH<T>([Out] string IPHMAHBENGI, T OEDIDFDHHOH, params object[] PKMHPILPCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC350", Offset = "0x2DAAD50", VA = "0x182DAC350")]
	private static AsyncOperationHandle<string> PHHEIJJEAHD<T>(T OEDIDFDHHOH, params object[] PKMHPILPCEB) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4BA0", Offset = "0x6BD35A0", VA = "0x186BD4BA0")]
	static IPFMCJFJBEM()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3150", Offset = "0x6BD1B50", VA = "0x186BD3150")]
		public void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3420", Offset = "0x6BD1E20", VA = "0x186BD3420")]
		public void MOGENANDEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
		private void LHGEDOPAMBC(StringTable JNGEMBJOBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BD31F0", Offset = "0x6BD1BF0", VA = "0x186BD31F0")]
		public string IAMJOGHHJOH(string COMNIKKFEEB, string FNKHHODCBNM = "", bool FEMNEHJOJBN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FallbackTableReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class POOKNHGABHJ : IFallbackFontProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FIEKAHIOFEO PNNPCMDAOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LazyFallbackFontAsset BMGAKPNJGBC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7200", Offset = "0x6BD5C00", VA = "0x186BD7200")]
	public POOKNHGABHJ(LazyFallbackFontAsset CBMACFKBLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6B80", Offset = "0x6BD5580", VA = "0x186BD6B80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6C40", Offset = "0x6BD5640", VA = "0x186BD6C40", Slot = "4")]
	public TMP_Character TryGetCharacter(HashSet<int> LJIMBNDODPE, uint GHECMOPCOLE, TMP_FontAsset JJALIFNOECO, bool DBIMFJMNAAD, FontStyles EONMLNIDIPD, FontWeight LKJNLACDBCE, [Out] bool IBPCBJIPAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6C20", Offset = "0x6BD5620", VA = "0x186BD6C20")]
	private void HKKHAEFCCGO(Scene GAFAAAGMMJN)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisplayName("RR Command Line Locale Selector")]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7310", Offset = "0x6BD5D10", VA = "0x186BD7310", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider MJJMPIMNPPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7820", Offset = "0x6BD6220", VA = "0x186BD7820")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DisplayName("RR Player Preferences Locale Selector")]
	public class RRPlayerPrefLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Should be the default code, but can be the default name as a fallback")]
		public LocaleIdentifier defaultLocaleIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("If no locale can be found, should fallback to the ProjectLocale?")]
		public bool fallbackToProjectLocale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GJAOPJJEKBG _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7870", Offset = "0x6BD6270", VA = "0x186BD7870", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider MJJMPIMNPPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7AD0", Offset = "0x6BD64D0", VA = "0x186BD7AD0")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[UnityEngine.Scripting.Preserve]
public class POOIJOJECLH : DJEPNLCFCBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CCJHAODINBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6AB0", Offset = "0x6BD54B0", VA = "0x186BD6AB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string HNNBDBHFOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6A40", Offset = "0x6BD5440", VA = "0x186BD6A40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KDMBLMFAMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6B20", Offset = "0x6BD5520", VA = "0x186BD6B20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BD69D0", Offset = "0x6BD53D0", VA = "0x186BD69D0")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public POOIJOJECLH()
	{
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LocalizedFontConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class FontAssetReference : AssetReferenceT<TMP_FontAsset>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const string SingletonResourceKey = "LocalizedFontConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("JP font")]
		public FontAssetReference FontJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("SC font")]
		public FontAssetReference FontSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("KR font")]
		public FontAssetReference FontKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("All of the actual CJK type fonts should go here")]
		[FormerlySerializedAs("HighEndLocalizedFonts")]
		[SerializeField]
		private List<FontAssetReference> localizedFonts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LazyFallbackFontAsset lazyFallbackFontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private LazyEmojiSpriteAsset lazyEmojiSpriteAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The font that will contain the fallback chain to CJK")]
		public TMP_FontAsset fallbackFontPlayerBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An addressable reference to the font that will contain the fallback chains to the CJK fonts")]
		public FontAssetReference fallbackFontAddressable;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<FontAssetReference> LocalizedFonts
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LazyFallbackFontAsset LazyFallbackFontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LazyEmojiSpriteAsset LazyEmojiSpriteAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5710", Offset = "0x6BD4110", VA = "0x186BD5710")]
		public static LocalizedFontConfig GJFCPJJDCIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5630", Offset = "0x6BD4030", VA = "0x186BD5630")]
		public FontAssetReference DNANIGAJEOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		public LocalizedFontConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class AGHLOCHLMLJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public LocalizedFontManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private AssetReferenceT<TMP_FontAsset> <localeAssetReference>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
			[DebuggerHidden]
			public AGHLOCHLMLJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6BD22A0", Offset = "0x6BD0CA0", VA = "0x186BD22A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6BD2A00", Offset = "0x6BD1400", VA = "0x186BD2A00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OMGJPPLOMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public TMP_FontAsset fontAsset;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public OMGJPPLOMLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6BD6710", Offset = "0x6BD5110", VA = "0x186BD6710")]
			internal void LCIJNDCICNJ(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AsyncOperationHandle<TMP_FontAsset> ODIHCNIKMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private AsyncOperationHandle<TMP_FontAsset> BMABNNHNHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> AFKNMLOBKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private LocalizedFontConfig EILKMNJGOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private DGMMCJOACNP DAHEHAAEHJN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string ILMFHOFCCEH = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string NMDBCPJBFHM = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string EDGNHFAOAPB = "interfaces_2024q1_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string JJHMCGAKENJ = "should_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string LOBBOOCCKKB = "interfaces_2024q1_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string BBMBFLLLPDM = "should_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6280", Offset = "0x6BD4C80", VA = "0x186BD6280")]
		[IteratorStateMachine(typeof(AGHLOCHLMLJ))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5F50", Offset = "0x6BD4950", VA = "0x186BD5F50")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5760", Offset = "0x6BD4160", VA = "0x186BD5760")]
		private void AOPLPEALGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD58D0", Offset = "0x6BD42D0", VA = "0x186BD58D0")]
		private void FPKIOBGCOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5930", Offset = "0x6BD4330", VA = "0x186BD5930")]
		private void FPKIOBGCOBL(TMP_FontAsset HEDBPEHMDEG, IReadOnlyList<AssetReference> GMLHBKFMMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5E30", Offset = "0x6BD4830", VA = "0x186BD5E30")]
		private void NAHPLHPIJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Description("Exclude this locale from the picker")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Metadata(AllowedTypes = MetadataType.Locale, AllowMultiple = false)]
	public class LocaleDisplayName : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string DisplayName;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LocaleDisplayName()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Metadata(AllowedTypes = MetadataType.SharedStringTableEntry, AllowMultiple = false)]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Description("What locale should we send up to the server for the access token claim")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Description("What locale should we send up to the strings server for localization")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings)]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public SkippableKnownText()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8A40", Offset = "0x6BD7440", VA = "0x186BD8A40", Slot = "4")]
		public void Transform(Message BBDGOIMNDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LOIFFCPDALG
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LKFJGPLGKIN([Optional] CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[RecRoom.NoEngine.Common.Preserve]
public class APLGHHFODAH : LOIFFCPDALG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct HGPMALOKGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3730", Offset = "0x6BD2130", VA = "0x186BD3730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6BD38E0", Offset = "0x6BD22E0", VA = "0x186BD38E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2A50", Offset = "0x6BD1450", VA = "0x186BD2A50")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2AC0", Offset = "0x6BD14C0", VA = "0x186BD2AC0", Slot = "4")]
	[AsyncStateMachine(typeof(HGPMALOKGDL))]
	public Task LKFJGPLGKIN([Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public APLGHHFODAH()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class MPJLDEGLCJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public MPJLDEGLCJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6BD6340", Offset = "0x6BD4D40", VA = "0x186BD6340")]
			internal void KDGNGOJBPCM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BDLBJNKDMJI retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7B40", Offset = "0x6BD6540", VA = "0x186BD7B40")]
		public static KGIOENCPIOK HINDDHMAHAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7DA0", Offset = "0x6BD67A0", VA = "0x186BD7DA0", Slot = "4")]
		public void PostprocessTable(LocalizationTable BCAHIKDMHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		private void IKGNAELPGIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD87B0", Offset = "0x6BD71B0", VA = "0x186BD87B0", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8830", Offset = "0x6BD7230", VA = "0x186BD8830")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
internal class BDLBJNKDMJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Dictionary<string, Dictionary<long, string>> EPPJFFHCFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB84E20", Offset = "0xB83820", VA = "0x180B84E20")]
	public void FHPGEJAJKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2DA0", Offset = "0x6BD17A0", VA = "0x186BD2DA0")]
	public KGIOENCPIOK GJIAEKOKGLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public BDLBJNKDMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2B90", Offset = "0x6BD1590", VA = "0x186BD2B90")]
	[CompilerGenerated]
	private void BBHAPDNLEBL(Dictionary<string, Dictionary<long, string>> CBDCEIMDKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2C90", Offset = "0x6BD1690", VA = "0x186BD2C90")]
	[CompilerGenerated]
	private void EEAHNCJLNLN(string OOCPPLNIOAJ)
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
