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
namespace TMPro
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class FontAssetReference : AssetReferenceT<TMP_FontAsset>, IEquatable<FontAssetReference>, IEqualityComparer<FontAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69EB290", Offset = "0x69E9890", VA = "0x1869EB290", Slot = "23")]
		public bool Equals(FontAssetReference OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69EB380", Offset = "0x69E9980", VA = "0x1869EB380", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69EB490", Offset = "0x69E9A90", VA = "0x1869EB490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69EB360", Offset = "0x69E9960", VA = "0x1869EB360", Slot = "24")]
		public bool Equals(FontAssetReference OEMFOJFNECE, FontAssetReference DPKOFHFGJKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x58857B0", Offset = "0x5883DB0", VA = "0x1858857B0", Slot = "25")]
		public int GetHashCode(FontAssetReference CDBNFNMIHPK)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
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
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<string> EmojiNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x942CD0", Offset = "0x9412D0", VA = "0x180942CD0")]
		public LazyEmojiSpriteAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LazyFallbackFontAsset : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
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
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public byte AssetReferenceIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x96BEB0", Offset = "0x96A4B0", VA = "0x18096BEB0")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x69EEFF0", Offset = "0x69ED5F0", VA = "0x1869EEFF0")]
			public bool GJJPBLIIILJ(uint OLADAANOILM)
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x69ECF70", Offset = "0x69EB570", VA = "0x1869ECF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyDictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> FallbackFontAssetHandles
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69EC850", Offset = "0x69EAE50", VA = "0x1869EC850")]
		public bool ADMLPIPIPGE(uint OLADAANOILM, [Out] TMP_FontAsset JPDKHCGLNIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69ECB80", Offset = "0x69EB180", VA = "0x1869ECB80")]
		public void AIAKEAFDDKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69ECDD0", Offset = "0x69EB3D0", VA = "0x1869ECDD0")]
		public bool IKBJKDKIDIH(FontAssetReference JIFOMOCMGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69EC730", Offset = "0x69EAD30", VA = "0x1869EC730")]
		private bool AALEDBDHIGL(uint OLADAANOILM, [Out] FontAssetReference JIFOMOCMGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69ECEE0", Offset = "0x69EB4E0", VA = "0x1869ECEE0")]
		public LazyFallbackFontAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SpriteAssetReference : AssetReferenceT<TMP_SpriteAsset>, IEquatable<SpriteAssetReference>, IEqualityComparer<SpriteAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69EB290", Offset = "0x69E9890", VA = "0x1869EB290", Slot = "23")]
		public bool Equals(SpriteAssetReference OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69EFE10", Offset = "0x69EE410", VA = "0x1869EFE10", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69EB490", Offset = "0x69E9A90", VA = "0x1869EB490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69EB360", Offset = "0x69E9960", VA = "0x1869EB360", Slot = "24")]
		public bool Equals(SpriteAssetReference OEMFOJFNECE, SpriteAssetReference DPKOFHFGJKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x58857B0", Offset = "0x5883DB0", VA = "0x1858857B0", Slot = "25")]
		public int GetHashCode(SpriteAssetReference CDBNFNMIHPK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LLKGKNOFKKE<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42E0DB0", Offset = "0x42DF3B0", VA = "0x1842E0DB0")]
	public LLKGKNOFKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OIDLCHPKIEH : IEmojiProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LazyEmojiSpriteAsset HBHOBFCMBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AsyncOperationHandle<TMP_SpriteAsset> OOAKCCAMKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private TMP_SpriteAsset KGDHNPNIBGF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<string> JEBHGOJIMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x13091D0", Offset = "0x13077D0", VA = "0x1813091D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public TMP_SpriteAsset CAPDJLFLMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69EE7E0", Offset = "0x69ECDE0", VA = "0x1869EE7E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69EE790", Offset = "0x69ECD90", VA = "0x1869EE790")]
	public OIDLCHPKIEH(LazyEmojiSpriteAsset HBHOBFCMBNJ, bool GNJHPNNIFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69EE600", Offset = "0x69ECC00", VA = "0x1869EE600")]
	private TMP_SpriteAsset DAPIHKGANHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69EE700", Offset = "0x69ECD00", VA = "0x1869EE700", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FIIIJBBPIEE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GAEGAHJMMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GAEGAHJMMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69EB500", Offset = "0x69E9B00", VA = "0x1869EB500")]
		internal bool CLJHKHHMEHP(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69EABB0", Offset = "0x69E91B0", VA = "0x1869EABB0")]
	public static List<Locale> NADJNLHCGMH(this LocalizationSettings IMPPBNPOBJP, bool PIHIPOODABB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69EA8B0", Offset = "0x69E8EB0", VA = "0x1869EA8B0")]
	public static void MNMGPHFGAAC(Locale HHPBCCBDLGJ, string KDKIKDGMMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69EA6C0", Offset = "0x69E8CC0", VA = "0x1869EA6C0")]
	public static Locale MNADNJBIPAL(this LocalizationSettings IMPPBNPOBJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69EADE0", Offset = "0x69E93E0", VA = "0x1869EADE0")]
	private static void NCNCGEAIKEM(string GAHDDPHMJLK, string HMFGPOMGJKO, string JOCJMGGBHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69EA610", Offset = "0x69E8C10", VA = "0x1869EA610")]
	public static void LHACAJJFOGO(this LocalizationSettings IMPPBNPOBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69EA1E0", Offset = "0x69E87E0", VA = "0x1869EA1E0")]
	public static Locale EMPIDBHFCHE(this LocalizationSettings IMPPBNPOBJP, string FNNCILEJLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69E9F10", Offset = "0x69E8510", VA = "0x1869E9F10")]
	public static Locale EMPIDBHFCHE(this ILocalesProvider MBAEPKDOADF, string FNNCILEJLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69EA270", Offset = "0x69E8870", VA = "0x1869EA270")]
	public static string HFABNOHNGEI(this Locale HHPBCCBDLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69EA590", Offset = "0x69E8B90", VA = "0x1869EA590")]
	public static string LAGIBELFHBB(this Locale HHPBCCBDLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69E9E10", Offset = "0x69E8410", VA = "0x1869E9E10")]
	public static string EHMBJCGFLHL(this CultureInfo OOKNILDICCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69EA440", Offset = "0x69E8A40", VA = "0x1869EA440")]
	public static string KKFPHCJHCIF(this LocalizedString IAPEEAAJECB, string MNBFPOFIDHA, object FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69EA220", Offset = "0x69E8820", VA = "0x1869EA220")]
	public static string HCJCPONNCED(this LocalizedString IAPEEAAJECB, string DAHDGPFGKJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KKPOAIAKHHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NMPMFODNIPN<T> : IAsyncStateMachine where T : Enum
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

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x45FC420", Offset = "0x45FAA20", VA = "0x1845FC420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x45FC7E0", Offset = "0x45FADE0", VA = "0x1845FC7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PIOICMPHJEL<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public PIOICMPHJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x481D630", Offset = "0x481BC30", VA = "0x18481D630")]
		internal void FJAOOLOJCMO(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Dictionary<(Type, string), string> ECAFGFIJCID;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Dictionary<Type, string> CJPGGCHEPGA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C8A0", Offset = "0x2C0AEA0", VA = "0x182C0C8A0")]
	private static string AFIFALHAGMD<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69EBCE0", Offset = "0x69EA2E0", VA = "0x1869EBCE0")]
	private static bool OJFBNLEGNJL((Type type, string name) JBLHPPMAAOA, [Out] string LPIIHMGHFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CC40", Offset = "0x2C0B240", VA = "0x182C0CC40")]
	public static string BHCFHMIJHON<T>(this T FKJJEAOFBOH, params object[] PLJOOCONEHF) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CE80", Offset = "0x2C0B480", VA = "0x182C0CE80")]
	[AsyncStateMachine(typeof(NMPMFODNIPN<>))]
	public static Task<string> FEMGHDNHOLM<T>(this T FKJJEAOFBOH, params object[] PLJOOCONEHF) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D6D0", Offset = "0x2C0BCD0", VA = "0x182C0D6D0")]
	private static bool HEIJGKFHPHE<T>([Out] string FEBGGALLBNN, T FKJJEAOFBOH, params object[] PLJOOCONEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D090", Offset = "0x2C0B690", VA = "0x182C0D090")]
	private static AsyncOperationHandle<string> GABBMIAEFEC<T>(T FKJJEAOFBOH, params object[] PLJOOCONEHF) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69EBDD0", Offset = "0x69EA3D0", VA = "0x1869EBDD0")]
	static KKPOAIAKHHL()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69EAFC0", Offset = "0x69E95C0", VA = "0x1869EAFC0")]
		public void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69EAF20", Offset = "0x69E9520", VA = "0x1869EAF20")]
		public void AMMOOILDICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
		private void GBEHJHGMKGP(StringTable PPDFIKOAPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69EB060", Offset = "0x69E9660", VA = "0x1869EB060")]
		public string OIJEPNKNKCG(string MNBFPOFIDHA, string DAHDGPFGKJH = "", bool CNCAEGCNGHI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FallbackTableReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LMDBLMIKGHL : IFallbackFontProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GNJCJIFAFED KODMPIMBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LazyFallbackFontAsset OADDLGFNONL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69EC640", Offset = "0x69EAC40", VA = "0x1869EC640")]
	public LMDBLMIKGHL(LazyFallbackFontAsset ONPGKAGPLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69EBFD0", Offset = "0x69EA5D0", VA = "0x1869EBFD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69EC090", Offset = "0x69EA690", VA = "0x1869EC090", Slot = "4")]
	public TMP_Character TryGetCharacter(HashSet<int> INNABNOPGIA, uint OLADAANOILM, TMP_FontAsset JGDLLHNGOPE, bool MHMHBMELNLF, FontStyles KPPCLHJLGPA, FontWeight HGLMNEFLGHP, [Out] bool GJEAHPKNOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69EC070", Offset = "0x69EA670", VA = "0x1869EC070")]
	private void EKLFNOPINLP(Scene COCIKBKCNFK)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisplayName("RR Command Line Locale Selector")]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69EE7F0", Offset = "0x69ECDF0", VA = "0x1869EE7F0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider LKFILIAKFNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69EED00", Offset = "0x69ED300", VA = "0x1869EED00")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
		private KFDOLDGEEBK _preferences;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69EED50", Offset = "0x69ED350", VA = "0x1869EED50", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider LKFILIAKFNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69EEF90", Offset = "0x69ED590", VA = "0x1869EEF90")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[UnityEngine.Scripting.Preserve]
public class BHCLIKMIPOH : EJOEEFGDLIC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CLJDJIIKNLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69E9980", Offset = "0x69E7F80", VA = "0x1869E9980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DFKHBDMAEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69E9840", Offset = "0x69E7E40", VA = "0x1869E9840", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EEOEEFIGEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x69E9920", Offset = "0x69E7F20", VA = "0x1869E9920", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69E98B0", Offset = "0x69E7EB0", VA = "0x1869E98B0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.None)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public BHCLIKMIPOH()
	{
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class LocalizedFontConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
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
		[FormerlySerializedAs("HighEndLocalizedFonts")]
		[Tooltip("All of the actual CJK type fonts should go here")]
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
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LazyFallbackFontAsset LazyFallbackFontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LazyEmojiSpriteAsset LazyEmojiSpriteAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69ECFC0", Offset = "0x69EB5C0", VA = "0x1869ECFC0")]
		public static LocalizedFontConfig EFJNAOELFMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69ED010", Offset = "0x69EB610", VA = "0x1869ED010")]
		public FontAssetReference JHCCCFDPDBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x942CD0", Offset = "0x9412D0", VA = "0x180942CD0")]
		public LocalizedFontConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KHJOKCAHIMD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public KHJOKCAHIMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69EB540", Offset = "0x69E9B40", VA = "0x1869EB540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x69EBC90", Offset = "0x69EA290", VA = "0x1869EBC90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CENGCKDEIMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public TMP_FontAsset fontAsset;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public CENGCKDEIMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69E99F0", Offset = "0x69E7FF0", VA = "0x1869E99F0")]
			internal void AOADPMONHAK(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AsyncOperationHandle<TMP_FontAsset> GHBCDDHFLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private AsyncOperationHandle<TMP_FontAsset> EFJJHDIHPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> DABLGEFOMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private LocalizedFontConfig AHDGGDAMLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private BBFOFLHBLBK JHLHJKLAENJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string IEMNCBICHIG = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string AOMBFOEPACN = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string AHBNBKCKLCM = "interfaces_2024q1_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string DEIFDMCAKHD = "should_lazy_load_fallback_fonts";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string KAMFOKMNNDK = "interfaces_2024q1_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string IIFEGNBPIKL = "should_lazy_load_emojis";

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x69EDBF0", Offset = "0x69EC1F0", VA = "0x1869EDBF0")]
		[IteratorStateMachine(typeof(KHJOKCAHIMD))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69ED8C0", Offset = "0x69EBEC0", VA = "0x1869ED8C0")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69ED750", Offset = "0x69EBD50", VA = "0x1869ED750")]
		private void LGMJNJHGFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69ED210", Offset = "0x69EB810", VA = "0x1869ED210")]
		private void HDOBCHEMNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x69ED270", Offset = "0x69EB870", VA = "0x1869ED270")]
		private void HDOBCHEMNLG(TMP_FontAsset JPDKHCGLNIC, IReadOnlyList<AssetReference> LNJFPKLHEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x69ED0F0", Offset = "0x69EB6F0", VA = "0x1869ED0F0")]
		private void FNPHLNNPHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	[Description("Exclude this locale from the picker")]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Metadata(AllowedTypes = MetadataType.Locale, AllowMultiple = false)]
	public class LocaleDisplayName : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string DisplayName;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LocaleDisplayName()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Metadata(AllowedTypes = MetadataType.SharedStringTableEntry, AllowMultiple = false)]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	[Description("What locale should we send up to the server for the access token claim")]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Description("What locale should we send up to the strings server for localization")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings)]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public SkippableKnownText()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69EFF20", Offset = "0x69EE520", VA = "0x1869EFF20", Slot = "4")]
		public void Transform(Message DICMABMCPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FEEMADPFOHE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JNKEGANEMCC([Optional] CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[RecRoom.NoEngine.Common.Preserve]
public class CJGBDGOCLNE : FEEMADPFOHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ENLDPBHECLN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69E9C00", Offset = "0x69E8200", VA = "0x1869E9C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69E9DB0", Offset = "0x69E83B0", VA = "0x1869E9DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69E9AC0", Offset = "0x69E80C0", VA = "0x1869E9AC0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.GameOnly)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69E9B30", Offset = "0x69E8130", VA = "0x1869E9B30", Slot = "4")]
	[AsyncStateMachine(typeof(ENLDPBHECLN))]
	public Task JNKEGANEMCC([Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public CJGBDGOCLNE()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class MEJOAGHBKMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public MEJOAGHBKMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69EDC70", Offset = "0x69EC270", VA = "0x1869EDC70")]
			internal void PEKEEPPNGEL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private OCHFJGOMCOE retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69EF000", Offset = "0x69ED600", VA = "0x1869EF000")]
		public static MKEIEIBMPOE HGDANEHJCNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69EF260", Offset = "0x69ED860", VA = "0x1869EF260", Slot = "4")]
		public void PostprocessTable(LocalizationTable JHHHJPJGOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		private void OEEGHDCEBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69EFC90", Offset = "0x69EE290", VA = "0x1869EFC90", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69EFD10", Offset = "0x69EE310", VA = "0x1869EFD10")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
internal class OCHFJGOMCOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Dictionary<string, Dictionary<long, string>> JJCOMOJBCPN;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA17B50", Offset = "0xA16150", VA = "0x180A17B50")]
	public void OIJNICLABMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69EE250", Offset = "0x69EC850", VA = "0x1869EE250")]
	public MKEIEIBMPOE ICIKDBAHBEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public OCHFJGOMCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69EE040", Offset = "0x69EC640", VA = "0x1869EE040")]
	[CompilerGenerated]
	private void ACIDHOACMGL(Dictionary<string, Dictionary<long, string>> APDDJMEIPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69EE140", Offset = "0x69EC740", VA = "0x1869EE140")]
	[CompilerGenerated]
	private void HHCLALPJDOO(string GCCBDCNGFBP)
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
