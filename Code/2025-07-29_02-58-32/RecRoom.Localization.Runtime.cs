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
using RecRoom.DataLayer.Registration;
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x835FD00", Offset = "0x835E700", VA = "0x18835FD00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x835B740", Offset = "0x835A140", VA = "0x18835B740", Slot = "23")]
		public bool Equals(FontAssetReference EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x835B830", Offset = "0x835A230", VA = "0x18835B830", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x835B940", Offset = "0x835A340", VA = "0x18835B940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x835B810", Offset = "0x835A210", VA = "0x18835B810", Slot = "24")]
		public bool Equals(FontAssetReference IECENJOJFJH, FontAssetReference OFOCBNJJIJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x44A5BB0", Offset = "0x44A45B0", VA = "0x1844A5BB0", Slot = "25")]
		public int GetHashCode(FontAssetReference CEFJEHJNIAP)
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<string> EmojiNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
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
				[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
				get
				{
					return default(uint);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public byte AssetReferenceIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x835E930", Offset = "0x835D330", VA = "0x18835E930")]
			public bool JBFDGOBACLK(uint BDHPKACBAGH)
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
			[Cpp2IlInjected.Address(RVA = "0x835D3C0", Offset = "0x835BDC0", VA = "0x18835D3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyDictionary<FontAssetReference, AsyncOperationHandle<TMP_FontAsset>> FallbackFontAssetHandles
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x835CC90", Offset = "0x835B690", VA = "0x18835CC90")]
		public bool DCAHFPNNCNJ(uint BDHPKACBAGH, [Out] TMP_FontAsset CGOCEPLKPJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x835CFC0", Offset = "0x835B9C0", VA = "0x18835CFC0")]
		public void KGBICDGKDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x835CB80", Offset = "0x835B580", VA = "0x18835CB80")]
		public bool BGECMPDJPGG(FontAssetReference JNGIGOJOHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x835D210", Offset = "0x835BC10", VA = "0x18835D210")]
		private bool LJPHLFJFBIC(uint BDHPKACBAGH, [Out] FontAssetReference JNGIGOJOHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x835D330", Offset = "0x835BD30", VA = "0x18835D330")]
		public LazyFallbackFontAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SpriteAssetReference : AssetReferenceT<TMP_SpriteAsset>, IEquatable<SpriteAssetReference>, IEqualityComparer<SpriteAssetReference>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x835B740", Offset = "0x835A140", VA = "0x18835B740", Slot = "23")]
		public bool Equals(SpriteAssetReference EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x835F750", Offset = "0x835E150", VA = "0x18835F750", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x835B940", Offset = "0x835A340", VA = "0x18835B940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x835B810", Offset = "0x835A210", VA = "0x18835B810", Slot = "24")]
		public bool Equals(SpriteAssetReference IECENJOJFJH, SpriteAssetReference OFOCBNJJIJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x44A5BB0", Offset = "0x44A45B0", VA = "0x1844A5BB0", Slot = "25")]
		public int GetHashCode(SpriteAssetReference CEFJEHJNIAP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IGOHFKPEOJE<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x514B110", Offset = "0x5149B10", VA = "0x18514B110")]
	public IGOHFKPEOJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JMFPDBCAMHB : IEmojiProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LazyEmojiSpriteAsset ACJACFCGDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AsyncOperationHandle<TMP_SpriteAsset> CEHELCNAIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private TMP_SpriteAsset IKNLNFBBDNC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<string> CLHBGBJELHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E285C0", Offset = "0x1E26FC0", VA = "0x181E285C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public TMP_SpriteAsset MKEBPPJEAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x835C870", Offset = "0x835B270", VA = "0x18835C870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public JMFPDBCAMHB(LazyEmojiSpriteAsset ACJACFCGDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x835C870", Offset = "0x835B270", VA = "0x18835C870")]
	private TMP_SpriteAsset PFFCPKNBHJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x835C7E0", Offset = "0x835B1E0", VA = "0x18835C7E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EGOJFHMPHGP
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CNIEIMJDNGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CNIEIMJDNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83595F0", Offset = "0x8357FF0", VA = "0x1883595F0")]
		internal bool CMHLAMMICIA(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8359ED0", Offset = "0x83588D0", VA = "0x188359ED0")]
	public static List<Locale> FCBDALADKPP(this LocalizationSettings IMFNJOKFKEG, bool LBJAKBABHPK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x835A4F0", Offset = "0x8358EF0", VA = "0x18835A4F0")]
	public static void OIGKOEKHIIF(Locale GKGKOIIBJMJ, string KFJACMABKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x835A810", Offset = "0x8359210", VA = "0x18835A810")]
	public static Locale OIKJEMJFEDP(this LocalizationSettings IMFNJOKFKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8359930", Offset = "0x8358330", VA = "0x188359930")]
	private static void AHJJBGPLJAE(string PLAMBINLEJB, string PHGFNFGDOKG, string PEIDNFHKHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x835A2F0", Offset = "0x8358CF0", VA = "0x18835A2F0")]
	public static void KBFBDKMNPBF(this LocalizationSettings IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8359A70", Offset = "0x8358470", VA = "0x188359A70")]
	public static Locale DAILKMHEKAE(this LocalizationSettings IMFNJOKFKEG, string EKOFBPALJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8359AB0", Offset = "0x83584B0", VA = "0x188359AB0")]
	public static Locale DAILKMHEKAE(this ILocalesProvider GACDMLEAKAP, string EKOFBPALJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x835A120", Offset = "0x8358B20", VA = "0x18835A120")]
	public static string GHCBLAFJHMJ(this Locale GKGKOIIBJMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x835AA20", Offset = "0x8359420", VA = "0x18835AA20")]
	public static string OKHFFDNPEPE(this Locale GKGKOIIBJMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8359DD0", Offset = "0x83587D0", VA = "0x188359DD0")]
	public static string DKBGMDHHDDO(this CultureInfo NGAEPIPFEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x835A3A0", Offset = "0x8358DA0", VA = "0x18835A3A0")]
	public static string MJJCIEBLCMI(this LocalizedString IFJKDOEPIBA, string LNBCHJPEENA, object PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8359D80", Offset = "0x8358780", VA = "0x188359D80")]
	public static string DFMFEBKMDNF(this LocalizedString IFJKDOEPIBA, string IEMHIOBFHLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DAJGJGEHKMO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MMDCNDMPJJI<T> : IAsyncStateMachine where T : Enum
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
		[Cpp2IlInjected.Address(RVA = "0x583BC10", Offset = "0x583A610", VA = "0x18583BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x583BFB0", Offset = "0x583A9B0", VA = "0x18583BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OCOJIPMLCGH<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OCOJIPMLCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x59F6EB0", Offset = "0x59F58B0", VA = "0x1859F6EB0")]
		internal void NDKPKOOKBIL(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Dictionary<(Type, string), string> MJLBPDEPCJC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Dictionary<Type, string> HBGLJCFFJMP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9170", Offset = "0x3AA7B70", VA = "0x183AA9170")]
	private static string FKGHGOCNKND<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8359630", Offset = "0x8358030", VA = "0x188359630")]
	private static bool FJEGBBJNFND((Type type, string name) AHFAIICGMDA, [Out] string NAFGBLNBFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9530", Offset = "0x3AA7F30", VA = "0x183AA9530")]
	public static string KKBHHGFPHJF<T>(this T IGABBOEDEPP, params object[] JEAMHIFDMBF) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9750", Offset = "0x3AA8150", VA = "0x183AA9750")]
	[AsyncStateMachine(typeof(MMDCNDMPJJI<>))]
	public static Task<string> MJFEGDNEOCO<T>(this T IGABBOEDEPP, params object[] JEAMHIFDMBF) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9960", Offset = "0x3AA8360", VA = "0x183AA9960")]
	private static bool OIGGEJADIJO<T>([Out] string PDKJBMPOMNC, T IGABBOEDEPP, params object[] JEAMHIFDMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9E40", Offset = "0x3AA8840", VA = "0x183AA9E40")]
	private static AsyncOperationHandle<string> PHNBHFEOFCA<T>(T IGABBOEDEPP, params object[] JEAMHIFDMBF) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8359720", Offset = "0x8358120", VA = "0x188359720")]
	static DAJGJGEHKMO()
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
		[Cpp2IlInjected.Address(RVA = "0x835B3E0", Offset = "0x8359DE0", VA = "0x18835B3E0")]
		public void ICNIAFDKEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x835B6A0", Offset = "0x835A0A0", VA = "0x18835B6A0")]
		public void NHMIPJFACPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		private void KGCCJIEKFLD(StringTable KEHJPLKNBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x835B480", Offset = "0x8359E80", VA = "0x18835B480")]
		public string MIPJKHGJMBI(string LNBCHJPEENA, string IEMHIOBFHLD = "", bool HJHMNJLNNBM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FallbackTableReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FBOHHMAMOGO : IFallbackFontProvider, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CBFODCPOFMH NNNHJIFLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LazyFallbackFontAsset LJIHGFGJHBG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x835B120", Offset = "0x8359B20", VA = "0x18835B120")]
	public FBOHHMAMOGO(LazyFallbackFontAsset GBGPAOIGCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x835AAA0", Offset = "0x83594A0", VA = "0x18835AAA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x835AB60", Offset = "0x8359560", VA = "0x18835AB60", Slot = "4")]
	public TMP_Character TryGetCharacter(HashSet<int> EFJBPOJOIKM, uint BDHPKACBAGH, TMP_FontAsset KFKANDKPGHD, bool MJOKIGLOFGO, FontStyles KFJFFFNMHPM, FontWeight LHLOMAACKGF, [Out] bool JMNPAMNLCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x835AB40", Offset = "0x8359540", VA = "0x18835AB40")]
	private void KHEFIBJFNPE(Scene FPJGDNNEOIB)
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
		[Cpp2IlInjected.Address(RVA = "0x835E100", Offset = "0x835CB00", VA = "0x18835E100", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider EFIMJIAMGPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x835E610", Offset = "0x835D010", VA = "0x18835E610")]
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
		private OEDJIHBFGCK _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x835E660", Offset = "0x835D060", VA = "0x18835E660", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider EFIMJIAMGPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x835E8D0", Offset = "0x835D2D0", VA = "0x18835E8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[UnityEngine.Scripting.Preserve]
public class FDOEIBLHMPP : OLACPFIJOMB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string BPOBMEPCDII
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x835B2A0", Offset = "0x8359CA0", VA = "0x18835B2A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string NJHLAANOOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x835B310", Offset = "0x8359D10", VA = "0x18835B310", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EBNHDEBCAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x835B380", Offset = "0x8359D80", VA = "0x18835B380", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x835B230", Offset = "0x8359C30", VA = "0x18835B230")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void EIKIOMKMPDG(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FDOEIBLHMPP()
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
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LazyFallbackFontAsset LazyFallbackFontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LazyEmojiSpriteAsset LazyEmojiSpriteAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x835D4F0", Offset = "0x835BEF0", VA = "0x18835D4F0")]
		public static LocalizedFontConfig NHOOMJJKFJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x835D410", Offset = "0x835BE10", VA = "0x18835D410")]
		public FontAssetReference ALAHFOKHBAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		public LocalizedFontConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GMBIKMOGKLO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public LocalizedFontManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private AssetReferenceT<TMP_FontAsset> <localeAssetReference>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public GMBIKMOGKLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x835C0B0", Offset = "0x835AAB0", VA = "0x18835C0B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x835C790", Offset = "0x835B190", VA = "0x18835C790", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AsyncOperationHandle<TMP_FontAsset> NBIKJEAJAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private AsyncOperationHandle<TMP_FontAsset> LHGBGEFHPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> NCFABMKDLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private LocalizedFontConfig CJFJFBGGCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private OADOONOPPPN LJLGJHJNHOB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string KEJKMGPJNBP = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string MAOIKIIMOKG = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x835DCB0", Offset = "0x835C6B0", VA = "0x18835DCB0")]
		[IteratorStateMachine(typeof(GMBIKMOGKLO))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x835D980", Offset = "0x835C380", VA = "0x18835D980")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x835D540", Offset = "0x835BF40", VA = "0x18835D540")]
		private void KNJJOLJKPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x835D690", Offset = "0x835C090", VA = "0x18835D690")]
		private void MIKAIPHIBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x835D6F0", Offset = "0x835C0F0", VA = "0x18835D6F0")]
		private void MIKAIPHIBCL(TMP_FontAsset CGOCEPLKPJP, IReadOnlyList<AssetReference> NAJBPAPICEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x835D610", Offset = "0x835C010", VA = "0x18835D610")]
		private void MGOKDCHBEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Description("Exclude this locale from the picker")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[Metadata(AllowedTypes = MetadataType.Locale, AllowMultiple = false)]
	public class LocaleDisplayName : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public string DisplayName;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LocaleDisplayName()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Metadata(AllowedTypes = MetadataType.SharedStringTableEntry, AllowMultiple = false)]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	[Description("What locale should we send up to the server for the access token claim")]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Metadata(AllowedTypes = MetadataType.Locale)]
	[Description("What locale should we send up to the strings server for localization")]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings)]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public SkippableKnownText()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x835F860", Offset = "0x835E260", VA = "0x18835F860", Slot = "4")]
		public void Transform(Message ONGDPODJNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DCNNMJAAOCJ
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OABNIBBHPKP([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[RecRoom.NoEngine.Common.Preserve]
public class GCHGEDKPCOO : DCNNMJAAOCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct JPHAFBDCPLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x835C970", Offset = "0x835B370", VA = "0x18835C970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x835CB20", Offset = "0x835B520", VA = "0x18835CB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x835B9B0", Offset = "0x835A3B0", VA = "0x18835B9B0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void EIKIOMKMPDG(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x835BA20", Offset = "0x835A420", VA = "0x18835BA20", Slot = "4")]
	[AsyncStateMachine(typeof(JPHAFBDCPLK))]
	public Task OABNIBBHPKP([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GCHGEDKPCOO()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class POGAGGPKJDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public POGAGGPKJDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x835DD30", Offset = "0x835C730", VA = "0x18835DD30")]
			internal void MLMOEHIGALH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GGIJGKPOGGC retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x835E940", Offset = "0x835D340", VA = "0x18835E940")]
		public static PNBAKNHPHGJ ICNIAFDKEKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x835EBA0", Offset = "0x835D5A0", VA = "0x18835EBA0", Slot = "4")]
		public void PostprocessTable(LocalizationTable AELKFCDJBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		private void LAMOCOMBEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x835F5D0", Offset = "0x835DFD0", VA = "0x18835F5D0", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x835F650", Offset = "0x835E050", VA = "0x18835F650")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
internal class GGIJGKPOGGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Dictionary<string, Dictionary<long, string>> HGJKNIEPKKI;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x12E6830", Offset = "0x12E5230", VA = "0x1812E6830")]
	public void EDOMILLKKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x835BAF0", Offset = "0x835A4F0", VA = "0x18835BAF0")]
	public PNBAKNHPHGJ CCGCOKAIFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GGIJGKPOGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x835BEA0", Offset = "0x835A8A0", VA = "0x18835BEA0")]
	[CompilerGenerated]
	private void HNCCBNGPNMN(Dictionary<string, Dictionary<long, string>> KALGJBIBGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x835BFA0", Offset = "0x835A9A0", VA = "0x18835BFA0")]
	[CompilerGenerated]
	private void IKJEBDANMGE(string OJCMLFFIJFF)
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
