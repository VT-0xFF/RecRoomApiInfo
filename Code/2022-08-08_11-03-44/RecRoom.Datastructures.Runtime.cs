using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JIANMCIKOJC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	public JIANMCIKOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x576A3D0", Offset = "0x57693D0", VA = "0x18576A3D0")]
	public byte[] AODNEHGPKIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void JICAKNICEGE(IncrementalHash KOPCAMHLCEK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xDD5560", Offset = "0xDD4560", VA = "0x180DD5560")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[BALLDLNPIHC]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[BALLDLNPIHC]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x576D160", Offset = "0x576C160", VA = "0x18576D160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x576D120", Offset = "0x576C120", VA = "0x18576D120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x576D1A0", Offset = "0x576C1A0", VA = "0x18576D1A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x576D3B0", Offset = "0x576C3B0", VA = "0x18576D3B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x576D320", Offset = "0x576C320", VA = "0x18576D320")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF28CB0", Offset = "0xF27CB0", VA = "0x180F28CB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x10BD170", Offset = "0x10BC170", VA = "0x1810BD170")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x576D0E0", Offset = "0x576C0E0", VA = "0x18576D0E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x576D290", Offset = "0x576C290", VA = "0x18576D290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x576CDE0", Offset = "0x576BDE0", VA = "0x18576CDE0")]
	public void CopyBounds(SavedExtents IJDAJAEAAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x576D050", Offset = "0x576C050", VA = "0x18576D050")]
	public void SetLocalSpaceBounds(Bounds JNNILLIFEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8FC690", Offset = "0x8FB690", VA = "0x1808FC690")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x576D040", Offset = "0x576C040", VA = "0x18576D040")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x576C550", Offset = "0x576B550", VA = "0x18576C550")]
	private void AHNBMMOCCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x576CE10", Offset = "0x576BE10", VA = "0x18576CE10")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x576C820", Offset = "0x576B820", VA = "0x18576C820")]
	public static void CalculateLocalBoundsFor(GameObject PKGBHIMGLPM, out Bounds JNNILLIFEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x576C760", Offset = "0x576B760", VA = "0x18576C760")]
	private static void AIEIHLFJJDD(Bounds GMPKOOIGMDG, Color ADHKGFCOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x576D070", Offset = "0x576C070", VA = "0x18576D070")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EE0", Offset = "0x5E4EE0", VA = "0x1805E5EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
	public virtual void AFNEFNDDLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[JIANMCIKOJC]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B76720", Offset = "0x2B75720", VA = "0x182B76720", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B76260", Offset = "0x2B75260", VA = "0x182B76260", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B76D20", Offset = "0x2B75D20", VA = "0x182B76D20")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LNPGEIABDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public LNPGEIABDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3690D20", Offset = "0x368FD20", VA = "0x183690D20")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[JIANMCIKOJC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3689910", Offset = "0x3688910", VA = "0x183689910", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3689940", Offset = "0x3688940", VA = "0x183689940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3689860", Offset = "0x3688860", VA = "0x183689860", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey GGLJFLNJABJ]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3689890", Offset = "0x3688890", VA = "0x183689890", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3689760", Offset = "0x3688760", VA = "0x183689760", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3688FC0", Offset = "0x3687FC0", VA = "0x183688FC0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3688930", Offset = "0x3687930", VA = "0x183688930", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3688590", Offset = "0x3687590", VA = "0x183688590", Slot = "14")]
	protected virtual string KJHENGJNCMB(TKeyVal PHPMMHCKOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3688470", Offset = "0x3687470", VA = "0x183688470", Slot = "4")]
	public bool ContainsKey(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3689650", Offset = "0x3688650", VA = "0x183689650", Slot = "5")]
	public bool TryGetValue(TKey GGLJFLNJABJ, out TVal JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x36884A0", Offset = "0x36874A0", VA = "0x1836884A0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x36884A0", Offset = "0x36874A0", VA = "0x1836884A0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3689680", Offset = "0x3688680", VA = "0x183689680")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GEGJOOOKKKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ELCBLALOMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public ELCBLALOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4033C10", Offset = "0x4032C10", VA = "0x184033C10")]
		internal bool <GetSamples>b__0(global::ADIPFMBPINN<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float EAPNKAIFNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float DECBNFAJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::ADIPFMBPINN<float, T>> KGCIIDPHGOC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int NKCFFBPLEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4040FA0", Offset = "0x403FFA0", VA = "0x184040FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4041870", Offset = "0x4040870", VA = "0x184041870")]
	public GEGJOOOKKKM(float LJFNEPPALCL, float INIEJCKHGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4040CE0", Offset = "0x403FCE0", VA = "0x184040CE0")]
	public bool FBANGPPBAOA(float BHDCBPKEHON, T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40417E0", Offset = "0x40407E0", VA = "0x1840417E0")]
	public int JFABANKCGHL(float BHDCBPKEHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40410A0", Offset = "0x40400A0", VA = "0x1840410A0")]
	public IEnumerable<T> HGCIDCPAJHI(float BHDCBPKEHON, [Optional] float? NHHIBDONFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4041840", Offset = "0x4040840", VA = "0x184041840")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4041720", Offset = "0x4040720", VA = "0x184041720")]
	private void IPEKDGOPNLA(float BHDCBPKEHON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PPNBOJIHFIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PEOOGGEPEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T GFNFCEIHNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float IKHPNENPMNN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float MOHICAGKBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> NFKMGHCLIAL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int BJGJLMBNGMA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private PEOOGGEPEBL[] DNAEDFOPGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int HIKNFPAJDJN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float EDLADBDPPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE5D400", Offset = "0xE5C400", VA = "0x180E5D400")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x10365A0", Offset = "0x10355A0", VA = "0x1810365A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30CB910", Offset = "0x30CA910", VA = "0x1830CB910")]
	public PPNBOJIHFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x30CB940", Offset = "0x30CA940", VA = "0x1830CB940")]
	public PPNBOJIHFIO(int CCDDIFMMPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30CB190", Offset = "0x30CA190", VA = "0x1830CB190")]
	public void PPCBFHPPBHE(float BHDCBPKEHON, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x30CAF60", Offset = "0x30C9F60", VA = "0x1830CAF60")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x30CB330", Offset = "0x30CA330", VA = "0x1830CB330")]
	public bool PPEMBCACMIM(float PNLIKPNCFEJ, float DICNHMPEPDD, out T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x30CA410", Offset = "0x30C9410", VA = "0x1830CA410")]
	public bool FLLPFFLHBPJ(float PNLIKPNCFEJ, float DICNHMPEPDD, out T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x30CA8D0", Offset = "0x30C98D0", VA = "0x1830CA8D0")]
	public void MCBLGJAEECG(float PNLIKPNCFEJ, float DICNHMPEPDD, List<T> AIKEPJOBOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x30CA3E0", Offset = "0x30C93E0", VA = "0x1830CA3E0")]
	private int DMOBPKHOHCP(int APOOFGHJAMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30CA890", Offset = "0x30C9890", VA = "0x1830CA890")]
	private void JPKOOFIKLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JMCGLKJLFLC();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BJGIMNEPLHL(T EPLBIHGPPPN, T PLMIDHOPDAL, float JBJIMKKMMPN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T NFGMAFMPKCH(T JNLOLNFALGF, float JBJIMKKMMPN);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CFIBKNBNANN(T EPLBIHGPPPN, T PLMIDHOPDAL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T HHAPGNOOIHO(T EPLBIHGPPPN, T PLMIDHOPDAL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MHLNDIMBPLC : global::PPNBOJIHFIO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x576B490", Offset = "0x576A490", VA = "0x18576B490", Slot = "4")]
	protected override Vector3 JMCGLKJLFLC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x576B2B0", Offset = "0x576A2B0", VA = "0x18576B2B0", Slot = "5")]
	protected override Vector3 BJGIMNEPLHL(Vector3 EPLBIHGPPPN, Vector3 PLMIDHOPDAL, float JBJIMKKMMPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x576B500", Offset = "0x576A500", VA = "0x18576B500", Slot = "6")]
	protected override Vector3 NFGMAFMPKCH(Vector3 JNLOLNFALGF, float JBJIMKKMMPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x576B370", Offset = "0x576A370", VA = "0x18576B370", Slot = "7")]
	protected override Vector3 CFIBKNBNANN(Vector3 EPLBIHGPPPN, Vector3 PLMIDHOPDAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x576B420", Offset = "0x576A420", VA = "0x18576B420", Slot = "8")]
	protected override Vector3 HHAPGNOOIHO(Vector3 EPLBIHGPPPN, Vector3 PLMIDHOPDAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x576B5A0", Offset = "0x576A5A0", VA = "0x18576B5A0")]
	public MHLNDIMBPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BFHMIGJOMBH : global::PPNBOJIHFIO<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5766000", Offset = "0x5765000", VA = "0x185766000")]
	public BFHMIGJOMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5765F90", Offset = "0x5764F90", VA = "0x185765F90")]
	public BFHMIGJOMBH(int CCDDIFMMPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF7CB40", Offset = "0xF7BB40", VA = "0x180F7CB40", Slot = "4")]
	protected override float JMCGLKJLFLC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5765F00", Offset = "0x5764F00", VA = "0x185765F00", Slot = "5")]
	protected override float BJGIMNEPLHL(float EPLBIHGPPPN, float PLMIDHOPDAL, float JBJIMKKMMPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x419ED80", Offset = "0x419DD80", VA = "0x18419ED80", Slot = "6")]
	protected override float NFGMAFMPKCH(float JNLOLNFALGF, float JBJIMKKMMPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2EAB760", Offset = "0x2EAA760", VA = "0x182EAB760", Slot = "7")]
	protected override float CFIBKNBNANN(float EPLBIHGPPPN, float PLMIDHOPDAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5765F80", Offset = "0x5764F80", VA = "0x185765F80", Slot = "8")]
	protected override float HHAPGNOOIHO(float EPLBIHGPPPN, float PLMIDHOPDAL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LBIFGIIGNKH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1CAFDB0", Offset = "0x1CAEDB0", VA = "0x181CAFDB0")]
	public static global::PDJFPMAECHI<T1> FBMLCAAKPML<T1>(T1 LMPLPKDFLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23854C0", Offset = "0x23844C0", VA = "0x1823854C0")]
	public static global::ADIPFMBPINN<T1, T2> FBMLCAAKPML<T1, T2>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB000", Offset = "0x1DDA000", VA = "0x181DDB000")]
	public static global::HINONODBCNA<T1, T2, T3> FBMLCAAKPML<T1, T2, T3>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF580", Offset = "0x1DCE580", VA = "0x181DCF580")]
	public static global::FNNCMNGMODH<T1, T2, T3, T4> FBMLCAAKPML<T1, T2, T3, T4>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x260A0A0", Offset = "0x26090A0", VA = "0x18260A0A0")]
	public static global::NEOENBNJGHJ<T1, T2, T3, T4, T5> FBMLCAAKPML<T1, T2, T3, T4, T5>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB090", Offset = "0x1DDA090", VA = "0x181DDB090")]
	public static global::KBPBFLLJCNH<T1, T2, T3, T4, T5, T6> FBMLCAAKPML<T1, T2, T3, T4, T5, T6>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG, T6 JACBHAGEOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2609FE0", Offset = "0x2608FE0", VA = "0x182609FE0")]
	public static global::MIDJPDAJAEI<T1, T2, T3, T4, T5, T6, T7> FBMLCAAKPML<T1, T2, T3, T4, T5, T6, T7>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG, T6 JACBHAGEOCG, T7 PEJKOHJGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2A70", Offset = "0x2DE1A70", VA = "0x182DE2A70")]
	public static global::PLBPCKDBHJB<T1, T2, T3, T4, T5, T6, T7, T8> FBMLCAAKPML<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG, T6 JACBHAGEOCG, T7 PEJKOHJGKHD, T8 PKHEHPILPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBF30", Offset = "0x1AFAF30", VA = "0x181AFBF30")]
	[IteratorStateMachine(typeof(OIDKAPDBODG))]
	public static IEnumerable<global::ADIPFMBPINN<T1, T2>> OLBOOFLMAHF<T1, T2>(IEnumerable<T1> KKHMNCLOHHK, IEnumerable<T2> GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D63ED0", Offset = "0x1D62ED0", VA = "0x181D63ED0")]
	[IteratorStateMachine(typeof(OKMCDOMOEDM))]
	public static IEnumerable<global::HINONODBCNA<T1, T2, T3>> OLBOOFLMAHF<T1, T2, T3>(IEnumerable<T1> KKHMNCLOHHK, IEnumerable<T2> GMPKOOIGMDG, IEnumerable<T3> ADHKGFCOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xC0AEE0", Offset = "0xC09EE0", VA = "0x180C0AEE0")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xC0AEF0", Offset = "0xC09EF0", VA = "0x180C0AEF0")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH, int HLDEIBOFEKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xC0AF00", Offset = "0xC09F00", VA = "0x180C0AF00")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH, int HLDEIBOFEKF, int JICPGIPLHGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x576B000", Offset = "0x576A000", VA = "0x18576B000")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH, int HLDEIBOFEKF, int JICPGIPLHGA, int FIEGPCOPNLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x576B020", Offset = "0x576A020", VA = "0x18576B020")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH, int HLDEIBOFEKF, int JICPGIPLHGA, int FIEGPCOPNLD, int OMEMLJABKAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x576B040", Offset = "0x576A040", VA = "0x18576B040")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH, int HLDEIBOFEKF, int JICPGIPLHGA, int FIEGPCOPNLD, int OMEMLJABKAH, int IMGBBHCHFIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x576AFD0", Offset = "0x5769FD0", VA = "0x18576AFD0")]
	internal static int IEJKFJKCGHD(int MIIDDAICEGJ, int OHHHGMOKICH, int HLDEIBOFEKF, int JICPGIPLHGA, int FIEGPCOPNLD, int OMEMLJABKAH, int IMGBBHCHFIL, int NFOJCJOBLMN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PDJFPMAECHI<T1> : IComparable<global::PDJFPMAECHI<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
	public PDJFPMAECHI(T1 LMPLPKDFLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x37F2E90", Offset = "0x37F1E90", VA = "0x1837F2E90", Slot = "4")]
	public int CompareTo(global::PDJFPMAECHI<T1> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37F2F00", Offset = "0x37F1F00", VA = "0x1837F2F00", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8EF150", Offset = "0x8EE150", VA = "0x1808EF150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37F2FA0", Offset = "0x37F1FA0", VA = "0x1837F2FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ADIPFMBPINN<T1, T2> : IComparable<global::ADIPFMBPINN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x30A29B0", Offset = "0x30A19B0", VA = "0x1830A29B0")]
	public ADIPFMBPINN(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x30A1060", Offset = "0x30A0060", VA = "0x1830A1060", Slot = "4")]
	public int CompareTo(global::ADIPFMBPINN<T1, T2> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x30A1240", Offset = "0x30A0240", VA = "0x1830A1240", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x30A1FC0", Offset = "0x30A0FC0", VA = "0x1830A1FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x30A2800", Offset = "0x30A1800", VA = "0x1830A2800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HINONODBCNA<T1, T2, T3> : IComparable<global::HINONODBCNA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 OFJNKCKGCND;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x23B0BF0", Offset = "0x23AFBF0", VA = "0x1823B0BF0")]
	public HINONODBCNA(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x23B0390", Offset = "0x23AF390", VA = "0x1823B0390", Slot = "4")]
	public int CompareTo(global::HINONODBCNA<T1, T2, T3> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x23B0590", Offset = "0x23AF590", VA = "0x1823B0590", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x23B0880", Offset = "0x23AF880", VA = "0x1823B0880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x23B09E0", Offset = "0x23AF9E0", VA = "0x1823B09E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FNNCMNGMODH<T1, T2, T3, T4> : IComparable<global::FNNCMNGMODH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 OFJNKCKGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 NJDKDIEKHKO;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x23B0300", Offset = "0x23AF300", VA = "0x1823B0300")]
	public FNNCMNGMODH(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x448B0C0", Offset = "0x448A0C0", VA = "0x18448B0C0", Slot = "4")]
	public int CompareTo(global::FNNCMNGMODH<T1, T2, T3, T4> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x448B200", Offset = "0x448A200", VA = "0x18448B200", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x448B320", Offset = "0x448A320", VA = "0x18448B320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x448B3E0", Offset = "0x448A3E0", VA = "0x18448B3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NEOENBNJGHJ<T1, T2, T3, T4, T5> : IComparable<global::NEOENBNJGHJ<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 OFJNKCKGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 NJDKDIEKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 PDEJDMIGOFM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3822220", Offset = "0x3821220", VA = "0x183822220")]
	public NEOENBNJGHJ(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3821D30", Offset = "0x3820D30", VA = "0x183821D30", Slot = "4")]
	public int CompareTo(global::NEOENBNJGHJ<T1, T2, T3, T4, T5> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3821EB0", Offset = "0x3820EB0", VA = "0x183821EB0", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3821FF0", Offset = "0x3820FF0", VA = "0x183821FF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38220F0", Offset = "0x38210F0", VA = "0x1838220F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KBPBFLLJCNH<T1, T2, T3, T4, T5, T6> : IComparable<global::KBPBFLLJCNH<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 OFJNKCKGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 NJDKDIEKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 PDEJDMIGOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 DOEHLKLMMPH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x32F3530", Offset = "0x32F2530", VA = "0x1832F3530")]
	public KBPBFLLJCNH(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG, T6 JACBHAGEOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x32F2F90", Offset = "0x32F1F90", VA = "0x1832F2F90", Slot = "4")]
	public int CompareTo(global::KBPBFLLJCNH<T1, T2, T3, T4, T5, T6> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x32F3150", Offset = "0x32F2150", VA = "0x1832F3150", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x32F32C0", Offset = "0x32F22C0", VA = "0x1832F32C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x32F33E0", Offset = "0x32F23E0", VA = "0x1832F33E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MIDJPDAJAEI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::MIDJPDAJAEI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 OFJNKCKGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 NJDKDIEKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 PDEJDMIGOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 DOEHLKLMMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 DKGOFEAJLGD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3718D10", Offset = "0x3717D10", VA = "0x183718D10")]
	public MIDJPDAJAEI(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG, T6 JACBHAGEOCG, T7 PEJKOHJGKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x37186B0", Offset = "0x37176B0", VA = "0x1837186B0", Slot = "4")]
	public int CompareTo(global::MIDJPDAJAEI<T1, T2, T3, T4, T5, T6, T7> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x37188B0", Offset = "0x37178B0", VA = "0x1837188B0", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3718A50", Offset = "0x3717A50", VA = "0x183718A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3718BA0", Offset = "0x3717BA0", VA = "0x183718BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PLBPCKDBHJB<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::PLBPCKDBHJB<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 MHCDIKKJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 CHCMCNEOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 OFJNKCKGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 NJDKDIEKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 PDEJDMIGOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 DOEHLKLMMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 DKGOFEAJLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 JMGMONALEDE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x30C7CB0", Offset = "0x30C6CB0", VA = "0x1830C7CB0")]
	public PLBPCKDBHJB(T1 LMPLPKDFLON, T2 PMPLPNJPPLJ, T3 IEDGCNIBHEM, T4 NFLMLPMKBFA, T5 ALPCBMGABMG, T6 JACBHAGEOCG, T7 PEJKOHJGKHD, T8 PKHEHPILPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30C75A0", Offset = "0x30C65A0", VA = "0x1830C75A0", Slot = "4")]
	public int CompareTo(global::PLBPCKDBHJB<T1, T2, T3, T4, T5, T6, T7, T8> IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30C77F0", Offset = "0x30C67F0", VA = "0x1830C77F0", Slot = "0")]
	public override bool Equals(object IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30C79B0", Offset = "0x30C69B0", VA = "0x1830C79B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30C7B20", Offset = "0x30C6B20", VA = "0x1830C7B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T GFNFCEIHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float BDMBBLAOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1180100", Offset = "0x117F100", VA = "0x181180100")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x44B61A0", Offset = "0x44B51A0", VA = "0x1844B61A0")]
	public T JPOGFKAJPPN(float JBJIMKKMMPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x44B63A0", Offset = "0x44B53A0", VA = "0x1844B63A0")]
	public T NLCMODHEHNE(float JBJIMKKMMPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BJGIMNEPLHL(T EPLBIHGPPPN, T PLMIDHOPDAL, float JBJIMKKMMPN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x57683A0", Offset = "0x57673A0", VA = "0x1857683A0", Slot = "4")]
	protected override float BJGIMNEPLHL(float EPLBIHGPPPN, float PLMIDHOPDAL, float JBJIMKKMMPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5768420", Offset = "0x5767420", VA = "0x185768420")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x576E310", Offset = "0x576D310", VA = "0x18576E310", Slot = "4")]
	protected override Vector3 BJGIMNEPLHL(Vector3 EPLBIHGPPPN, Vector3 PLMIDHOPDAL, float JBJIMKKMMPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x576E3D0", Offset = "0x576D3D0", VA = "0x18576E3D0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5766EC0", Offset = "0x5765EC0", VA = "0x185766EC0", Slot = "4")]
	protected override Color BJGIMNEPLHL(Color EPLBIHGPPPN, Color PLMIDHOPDAL, float JBJIMKKMMPN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5766F10", Offset = "0x5765F10", VA = "0x185766F10")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FMIPPNHOFJJ : global::BBDBCFOGFKL<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x57682F0", Offset = "0x57672F0", VA = "0x1857682F0")]
	public FMIPPNHOFJJ(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5768340", Offset = "0x5767340", VA = "0x185768340")]
	public FMIPPNHOFJJ(APGHLMDCGLH[] NPEEAAKFCBB, bool LJGABHFPLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5768280", Offset = "0x5767280", VA = "0x185768280", Slot = "6")]
	protected override uint NCDNNOEBBDE(uint KOPCAMHLCEK, string JNLOLNFALGF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HFINKOCINOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HFINKOCINOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::DPJJNNKLHHA<>.AHGKOGOMLCP))]
[DefaultMember("Item")]
public sealed class DPJJNNKLHHA<T> : IDisposable, global::CLLBNCOKFFJ<T>, EODBFKAKBBM, global::GBJEAOEEEGN<T, global::DPJJNNKLHHA<T>.NMCLJDOAMLJ>, global::LDJJHMDMBIK<T>, global::LCLKHNLDMHM<T, global::DPJJNNKLHHA<T>.NMCLJDOAMLJ>, global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, global::DPJJNNKLHHA<T>.NMCLJDOAMLJ>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct NMCLJDOAMLJ : EODBFKAKBBM, global::OEJOMOEGFJD<T>, global::GPADANINMLP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::DPJJNNKLHHA<T> LMBBANBHEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int NLCJNMKAJNF;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HJCHDLKJEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1CC08A0", Offset = "0x1CBF8A0", VA = "0x181CC08A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4051220", Offset = "0x4050220", VA = "0x184051220", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private T GCJKDOLLJJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4050AA0", Offset = "0x404FAA0", VA = "0x184050AA0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4050C60", Offset = "0x404FC60", VA = "0x184050C60", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4051060", Offset = "0x4050060", VA = "0x184051060", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x38567B0", Offset = "0x38557B0", VA = "0x1838567B0")]
		private NMCLJDOAMLJ(global::DPJJNNKLHHA<T> AMPFEINIDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2181560", Offset = "0x2180560", VA = "0x182181560")]
		public static NMCLJDOAMLJ NEPKDIDOCIM(global::DPJJNNKLHHA<T> AMPFEINIDNM)
		{
			return default(NMCLJDOAMLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4050B60", Offset = "0x404FB60", VA = "0x184050B60", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x21815C0", Offset = "0x21805C0", VA = "0x1821815C0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class AHGKOGOMLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::DPJJNNKLHHA<T> LMBBANBHEBL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int HJCHDLKJEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x2178F70", Offset = "0x2177F70", VA = "0x182178F70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T[] LPKNDHHPDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x40465C0", Offset = "0x40455C0", VA = "0x1840465C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AMNFGEJOCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4046500", Offset = "0x4045500", VA = "0x184046500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
		public AHGKOGOMLCP(global::DPJJNNKLHHA<T> AMPFEINIDNM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NHLNGFAFOKO OHPIAOGBGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] EBIBFNBHPFP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD0", Offset = "0x5E4CD0", VA = "0x1805E5CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x666A10", Offset = "0x665A10", VA = "0x180666A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> LPKNDHHPDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4049E00", Offset = "0x4048E00", VA = "0x184049E00")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T EMOJHLMHBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4049300", Offset = "0x4048300", VA = "0x184049300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T ANOFCMDJCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4049300", Offset = "0x4048300", VA = "0x184049300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4047BC0", Offset = "0x4046BC0", VA = "0x184047BC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4049360", Offset = "0x4048360", VA = "0x184049360")]
	public static global::DPJJNNKLHHA<T> NEPKDIDOCIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4048560", Offset = "0x4047560", VA = "0x184048560")]
	public static global::DPJJNNKLHHA<T> KPEDNILKLOP(int FANLILHFAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x404A930", Offset = "0x4049930", VA = "0x18404A930")]
	internal DPJJNNKLHHA(T[] DOKJIGMCCDE, int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x216FED0", Offset = "0x216EED0", VA = "0x18216FED0", Slot = "5")]
	public T GNEAPKNKAPI(int BJNKEHJJEBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4047A80", Offset = "0x4046A80", VA = "0x184047A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x404A590", Offset = "0x4049590", VA = "0x18404A590")]
	public void PPCBFHPPBHE(in T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4046CB0", Offset = "0x4045CB0", VA = "0x184046CB0")]
	public void AEKIKDHBOHP(int IIHEDPBOLFE, in T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4049230", Offset = "0x4048230", VA = "0x184049230")]
	public void LPJGPILEEAO(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4047700", Offset = "0x4046700", VA = "0x184047700")]
	public void CLGGIMOANLB(int CCDDIFMMPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4048910", Offset = "0x4047910", VA = "0x184048910")]
	private void LLEKFFHMMIL(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x40492D0", Offset = "0x40482D0", VA = "0x1840492D0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4047C80", Offset = "0x4046C80", VA = "0x184047C80")]
	public global::DPJJNNKLHHA<T> KDEDCHMMLEH(global::MJCGAOGKNAI<T, T> NFCFFJDJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4047B00", Offset = "0x4046B00", VA = "0x184047B00", Slot = "11")]
	public NMCLJDOAMLJ GetEnumerator()
	{
		return default(NMCLJDOAMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4047A00", Offset = "0x4046A00", VA = "0x184047A00", Slot = "8")]
	private global::OEJOMOEGFJD<T> LJJNHENOBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4047A00", Offset = "0x4046A00", VA = "0x184047A00", Slot = "10")]
	private global::GPADANINMLP<T> DNFNJPBCGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4047A00", Offset = "0x4046A00", VA = "0x184047A00", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4047A00", Offset = "0x4046A00", VA = "0x184047A00", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BDLPEDIHEDF
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B800", Offset = "0x2F8A800", VA = "0x182F8B800")]
	public static bool ACCIPEIGDLE<T>(this global::DPJJNNKLHHA<T> AMPFEINIDNM, in T JNLOLNFALGF) where T : global::ICCFNJLONFA<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct GIONFOKLAEA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JKLGOGGCNLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<OBILJNMGGGG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public JKLGOGGCNLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x576A5B0", Offset = "0x57695B0", VA = "0x18576A5B0")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OBILJNMGGGG>> BIMBDLHNCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int GKOGMCIIBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int GAIDPAGGMFI;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F29E0", Offset = "0x9F19E0", VA = "0x1809F29E0")]
	private GIONFOKLAEA(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OBILJNMGGGG>> BADBJNJFJDC, int IONLJDMJGIK, int NCGBBOGNEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5768740", Offset = "0x5767740", VA = "0x185768740")]
	public static GIONFOKLAEA NEPKDIDOCIM()
	{
		return default(GIONFOKLAEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x57687C0", Offset = "0x57677C0", VA = "0x1857687C0")]
	public (int, int, Task) OKMFLLNPLPP(int DAFFLDMGCDH, [Optional] CancellationToken JNDOKGNDNMO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5768690", Offset = "0x5767690", VA = "0x185768690")]
	public void KMHBEKOAAEI(int DAFFLDMGCDH, int NCGBBOGNEFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class FGGDBHNONBN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> MHKPJAIABCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> HBMFHJKBDMM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2178F70", Offset = "0x2177F70", VA = "0x182178F70", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TKey> NCNFHHNPBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2178DF0", Offset = "0x2177DF0", VA = "0x182178DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> KMAPGCNPHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x27C1E00", Offset = "0x27C0E00", VA = "0x1827C1E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public TVal AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A946A0", Offset = "0x3A936A0", VA = "0x183A946A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x27BE910", Offset = "0x27BD910", VA = "0x1827BE910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TKey AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3C23F60", Offset = "0x3C22F60", VA = "0x183C23F60")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C239E0", Offset = "0x3C229E0", VA = "0x183C239E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3C23A60", Offset = "0x3C22A60", VA = "0x183C23A60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3C24330", Offset = "0x3C23330", VA = "0x183C24330", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x287D5D0", Offset = "0x287C5D0", VA = "0x18287D5D0", Slot = "9")]
	public void Add(TKey GGLJFLNJABJ, TVal JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3C23870", Offset = "0x3C22870", VA = "0x183C23870", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3465600", Offset = "0x3464600", VA = "0x183465600", Slot = "8")]
	public bool ContainsKey(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC57A0", Offset = "0x2FC47A0", VA = "0x182FC57A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3C242D0", Offset = "0x3C232D0", VA = "0x183C242D0", Slot = "10")]
	public bool Remove(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C242D0", Offset = "0x3C232D0", VA = "0x183C242D0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x26D6D60", Offset = "0x26D5D60", VA = "0x1826D6D60", Slot = "11")]
	public bool TryGetValue(TKey GGLJFLNJABJ, out TVal JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C23BE0", Offset = "0x3C22BE0", VA = "0x183C23BE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C23AF0", Offset = "0x3C22AF0", VA = "0x183C23AF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C24250", Offset = "0x3C23250", VA = "0x183C24250")]
	public void PPCBFHPPBHE(TVal CDCAGKIIGNH, TKey GGLJFLNJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C24210", Offset = "0x3C23210", VA = "0x183C24210")]
	public void PPCBFHPPBHE(KeyValuePair<TVal, TKey> PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3C240A0", Offset = "0x3C230A0", VA = "0x183C240A0")]
	public bool LEADJOBBELM(TVal GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x21814B0", Offset = "0x21804B0", VA = "0x1821814B0")]
	public bool FAFGFNINKJO(KeyValuePair<TVal, TKey> PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x23AFBC0", Offset = "0x23AEBC0", VA = "0x1823AFBC0")]
	public bool DKCILJPFPEA(TVal GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x23AFBC0", Offset = "0x23AEBC0", VA = "0x1823AFBC0")]
	public bool DKCILJPFPEA(KeyValuePair<TVal, TKey> PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C23B50", Offset = "0x3C22B50", VA = "0x183C23B50")]
	public bool DCDCMBICKAB(TVal GGLJFLNJABJ, out TKey JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C240D0", Offset = "0x3C230D0", VA = "0x183C240D0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> PCBDKFNGNEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3C23960", Offset = "0x3C22960", VA = "0x183C23960")]
	private void BGCLILBBEAM(TKey GGLJFLNJABJ, TVal CDCAGKIIGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3C23F90", Offset = "0x3C22F90", VA = "0x183C23F90")]
	private void LAPCCFCAPHG(TKey GGLJFLNJABJ, TVal CDCAGKIIGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3C23C60", Offset = "0x3C22C60", VA = "0x183C23C60")]
	private bool JFANMJHECHO(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3C23DE0", Offset = "0x3C22DE0", VA = "0x183C23DE0")]
	private bool JFANMJHECHO(TVal CDCAGKIIGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3C243D0", Offset = "0x3C233D0", VA = "0x183C243D0")]
	public FGGDBHNONBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JODIOBDEONF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::JODIOBDEONF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xE5D400", Offset = "0xE5C400", VA = "0x180E5D400", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x32E0FD0", Offset = "0x32DFFD0", VA = "0x1832E0FD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x32E14E0", Offset = "0x32E04E0", VA = "0x1832E14E0")]
		public Enumerator(global::JODIOBDEONF<T> AIKEPJOBOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x32E0D60", Offset = "0x32DFD60", VA = "0x1832E0D60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x32E0F30", Offset = "0x32DFF30", VA = "0x1832E0F30", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x32E0830", Offset = "0x32DF830", VA = "0x1832E0830")]
		private void GJBOKODMDFN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] GNHIHFHAGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int KMEFLFMPMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int FFOFJJMCECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int GDLEDDNCPGJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x32ED1F0", Offset = "0x32EC1F0", VA = "0x1832ED1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x32EC740", Offset = "0x32EB740", VA = "0x1832EC740")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x32EB810", Offset = "0x32EA810", VA = "0x1832EB810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x32ED710", Offset = "0x32EC710", VA = "0x1832ED710")]
	public JODIOBDEONF(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x32ED460", Offset = "0x32EC460", VA = "0x1832ED460")]
	public void PPCBFHPPBHE(T JBJIMKKMMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x32EBA70", Offset = "0x32EAA70", VA = "0x1832EBA70")]
	public void HHLMDLEANMN(IEnumerable<T> JGJMKJKGEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x32ED140", Offset = "0x32EC140", VA = "0x1832ED140")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x32ED160", Offset = "0x32EC160", VA = "0x1832ED160")]
	public void NNKJGMFFEHD(int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x32EB690", Offset = "0x32EA690", VA = "0x1832EB690")]
	public void BKEOBBGJPGP(int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x32ECC30", Offset = "0x32EBC30", VA = "0x1832ECC30")]
	public void KKDJIBHIMKA(T[] DNAEDFOPGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x32EB980", Offset = "0x32EA980", VA = "0x1832EB980")]
	public Enumerator GMHPDHEDPBP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x32ED670", Offset = "0x32EC670", VA = "0x1832ED670", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x32ED670", Offset = "0x32EC670", VA = "0x1832ED670", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x32ECE70", Offset = "0x32EBE70", VA = "0x1832ECE70")]
	private int KMIGFCFBNEH(int IIHEDPBOLFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x32EC690", Offset = "0x32EB690", VA = "0x1832EC690")]
	private int IEHIPIHEIOP(int IIHEDPBOLFE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JNLPGOBEGKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] EBIBFNBHPFP;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
	public JNLPGOBEGKC(params IDisposable[] DOKJIGMCCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xE38DF0", Offset = "0xE37DF0", VA = "0x180E38DF0")]
	public static JNLPGOBEGKC NEPKDIDOCIM(params IDisposable[] DOKJIGMCCDE)
	{
		return default(JNLPGOBEGKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x576A700", Offset = "0x5769700", VA = "0x18576A700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct CHPGKDHFPPN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable NAMCMDKGPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T GFNFCEIHNLL;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2715BA0", Offset = "0x2714BA0", VA = "0x182715BA0")]
	public CHPGKDHFPPN(IDisposable GPBPHMJHPIL, in T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x237AFF0", Offset = "0x2379FF0", VA = "0x18237AFF0")]
	public static global::CHPGKDHFPPN<U> ONALDIKDPCH<U>(in global::CHPGKDHFPPN<T> GPBPHMJHPIL, in U JNLOLNFALGF)
	{
		return default(global::CHPGKDHFPPN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF1E0", Offset = "0x1DCE1E0", VA = "0x181DCF1E0")]
	public global::CHPGKDHFPPN<U> HDKOPDMLNEK<U>(in U JNLOLNFALGF)
	{
		return default(global::CHPGKDHFPPN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x237AD90", Offset = "0x2379D90", VA = "0x18237AD90")]
	public static global::CHPGKDHFPPN<(T, U)> GMDDMCBKALB<U>(in global::CHPGKDHFPPN<T> KKHMNCLOHHK, in global::CHPGKDHFPPN<U> GMPKOOIGMDG)
	{
		return default(global::CHPGKDHFPPN<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2715AB0", Offset = "0x2714AB0", VA = "0x182715AB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LINICGGLNPF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x23855C0", Offset = "0x23845C0", VA = "0x1823855C0")]
	public static global::CHPGKDHFPPN<T> NEPKDIDOCIM<T>(IDisposable GPBPHMJHPIL, in T JNLOLNFALGF)
	{
		return default(global::CHPGKDHFPPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF1E0", Offset = "0x1DCE1E0", VA = "0x181DCF1E0")]
	public static global::CHPGKDHFPPN<U> ONALDIKDPCH<U, T>(in global::CHPGKDHFPPN<T> JBPLFHLHKNJ, in U JNLOLNFALGF)
	{
		return default(global::CHPGKDHFPPN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2167EA0", Offset = "0x2166EA0", VA = "0x182167EA0")]
	public static global::CHPGKDHFPPN<(T, U)> GMDDMCBKALB<T, U>(in global::CHPGKDHFPPN<T> KKHMNCLOHHK, in global::CHPGKDHFPPN<U> GMPKOOIGMDG)
	{
		return default(global::CHPGKDHFPPN<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NHLNGFAFOKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0")]
	public static NHLNGFAFOKO BFHBCOPOEIO<T>([Optional] string EJJPPILKOOF, [Optional] string MFPENHDLOGC, bool GCIOAJNPOKI = false)
	{
		return default(NHLNGFAFOKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct LPKEDKCJEDA<T> : global::LCLKHNLDMHM<T, global::LPKEDKCJEDA<T>.MJIPFGEPDIO>, global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, global::LPKEDKCJEDA<T>.MJIPFGEPDIO>, IEnumerable<T>, IEnumerable, global::CLLBNCOKFFJ<T>, EODBFKAKBBM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct MJIPFGEPDIO : EODBFKAKBBM, global::GPADANINMLP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] LMBBANBHEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int NLCJNMKAJNF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int HJCHDLKJEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2179700", Offset = "0x2178700", VA = "0x182179700", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2181620", Offset = "0x2180620", VA = "0x182181620", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x21815D0", Offset = "0x21805D0", VA = "0x1821815D0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x21815D0", Offset = "0x21805D0", VA = "0x1821815D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA26A90", Offset = "0xA25A90", VA = "0x180A26A90")]
		private MJIPFGEPDIO(T[] AMPFEINIDNM, int IIHEDPBOLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2181560", Offset = "0x2180560", VA = "0x182181560")]
		public static MJIPFGEPDIO NEPKDIDOCIM(T[] AMPFEINIDNM)
		{
			return default(MJIPFGEPDIO);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2181530", Offset = "0x2180530", VA = "0x182181530", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x21815C0", Offset = "0x21805C0", VA = "0x1821815C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] OOMDOKBILAM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2179700", Offset = "0x2178700", VA = "0x182179700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2179AA0", Offset = "0x2178AA0", VA = "0x182179AA0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2179A60", Offset = "0x2178A60", VA = "0x182179A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
	internal LPKEDKCJEDA(T[] DNAEDFOPGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x21798A0", Offset = "0x21788A0", VA = "0x1821798A0")]
	public static global::LPKEDKCJEDA<T> FKGGGNACLJB()
	{
		return default(global::LPKEDKCJEDA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2179960", Offset = "0x2178960", VA = "0x182179960", Slot = "9")]
	public T GNEAPKNKAPI(int IIHEDPBOLFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3A94370", Offset = "0x3A93370", VA = "0x183A94370", Slot = "6")]
	public MJIPFGEPDIO GetEnumerator()
	{
		return default(MJIPFGEPDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3A94270", Offset = "0x3A93270", VA = "0x183A94270", Slot = "5")]
	private global::GPADANINMLP<T> DNFNJPBCGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3A94270", Offset = "0x3A93270", VA = "0x183A94270", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3A94270", Offset = "0x3A93270", VA = "0x183A94270", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class INJNHMJPJOB
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE270", Offset = "0x1DCD270", VA = "0x181DCE270")]
	public static global::LPKEDKCJEDA<T> NEPKDIDOCIM<T>(T[] DNAEDFOPGEJ)
	{
		return default(global::LPKEDKCJEDA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0320", Offset = "0x1DBF320", VA = "0x181DC0320")]
	public static global::LPKEDKCJEDA<T> LOLJBENHKHI<T>(this T[] AMPFEINIDNM)
	{
		return default(global::LPKEDKCJEDA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE2A0", Offset = "0x1DCD2A0", VA = "0x181DCE2A0")]
	public static global::LPKEDKCJEDA<T>.MJIPFGEPDIO PBNPGBBEGMO<T>(this T[] AMPFEINIDNM)
	{
		return default(global::LPKEDKCJEDA<T>.MJIPFGEPDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0320", Offset = "0x1DBF320", VA = "0x181DC0320")]
	public static global::LPKEDKCJEDA<T> NDEGJDBDKJI<T>(this T[] AMPFEINIDNM)
	{
		return default(global::LPKEDKCJEDA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct BPAOEJLFFDC<T, U> : global::LCLKHNLDMHM<T, U>, global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, U>, IEnumerable<T>, IEnumerable where U : global::GPADANINMLP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U BHCNADKNPDC;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x25F71E0", Offset = "0x25F61E0", VA = "0x1825F71E0")]
	internal BPAOEJLFFDC(in U GFNIILKEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "5")]
	private global::GPADANINMLP<T> DNFNJPBCGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ODNOOADJNGB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x23872F0", Offset = "0x23862F0", VA = "0x1823872F0")]
	public static global::BPAOEJLFFDC<T, U> NEPKDIDOCIM<U>(in U GFNIILKEBCB) where U : global::GPADANINMLP<T>
	{
		return default(global::BPAOEJLFFDC<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FALAHFLPJLD<TResult, TResultEnumerator> where TResultEnumerator : global::GPADANINMLP<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE210", Offset = "0x1DCD210", VA = "0x181DCE210")]
	public static global::HADEBPFMDPD<TSourceEnumerator, TResultEnumerator, TResult> AGAGGHMHKNE<TSourceEnumerator>(in TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::HADEBPFMDPD<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HADEBPFMDPD<TSourceEnumerator, TResultEnumerator, TResult> : global::GPADANINMLP<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::GPADANINMLP<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator LMBBANBHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator EJPPACNNBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool NDNNECEBBAI;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TResult EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4327570", Offset = "0x4326570", VA = "0x184327570", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x43274D0", Offset = "0x43264D0", VA = "0x1843274D0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x43274D0", Offset = "0x43264D0", VA = "0x1843274D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4327520", Offset = "0x4326520", VA = "0x184327520")]
	internal HADEBPFMDPD(in TSourceEnumerator AMPFEINIDNM, in TResultEnumerator KEIGPJHCIMA, bool GHJPOALIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4327350", Offset = "0x4326350", VA = "0x184327350", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4327480", Offset = "0x4326480", VA = "0x184327480", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4327300", Offset = "0x4326300", VA = "0x184327300", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct CACNKNANCAJ<TSourceEnumerator, TSource, TResult> : EODBFKAKBBM, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : EODBFKAKBBM, global::GPADANINMLP<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator LMBBANBHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::MJCGAOGKNAI<TSource, TResult> OLBAJNHIGOK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x287BD30", Offset = "0x287AD30", VA = "0x18287BD30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x287C590", Offset = "0x287B590", VA = "0x18287C590", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x287C140", Offset = "0x287B140", VA = "0x18287C140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2739800", Offset = "0x2738800", VA = "0x182739800")]
	internal CACNKNANCAJ(in TSourceEnumerator AMPFEINIDNM, global::MJCGAOGKNAI<TSource, TResult> CLAPKMKPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x287BB40", Offset = "0x287AB40", VA = "0x18287BB40", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x287C050", Offset = "0x287B050", VA = "0x18287C050", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x287B960", Offset = "0x287A960", VA = "0x18287B960", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IPILAIBHLHK<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::GPADANINMLP<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::GPADANINMLP<TSource> where TResultEnumerator : global::GPADANINMLP<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator LMBBANBHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator EJPPACNNBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::MJCGAOGKNAI<TSource, TResultEnumerator> OLBAJNHIGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool NDNNECEBBAI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TResult EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3347210", Offset = "0x3346210", VA = "0x183347210", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3347120", Offset = "0x3346120", VA = "0x183347120", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3347120", Offset = "0x3346120", VA = "0x183347120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x33471B0", Offset = "0x33461B0", VA = "0x1833471B0")]
	internal IPILAIBHLHK(in TSourceEnumerator AMPFEINIDNM, in TResultEnumerator KEIGPJHCIMA, global::MJCGAOGKNAI<TSource, TResultEnumerator> CLAPKMKPBMP, bool GHJPOALIDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3346F40", Offset = "0x3345F40", VA = "0x183346F40", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x33470D0", Offset = "0x33460D0", VA = "0x1833470D0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3346EF0", Offset = "0x3345EF0", VA = "0x183346EF0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct CLCAJOCIKGN<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : EODBFKAKBBM, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : EODBFKAKBBM, global::GPADANINMLP<TSource1> where TSource2Enumerator : EODBFKAKBBM, global::GPADANINMLP<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator EBNJONHOIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator BOGDPKMDMGM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2719DD0", Offset = "0x2718DD0", VA = "0x182719DD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public (TSource1, TSource2) EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2719FC0", Offset = "0x2718FC0", VA = "0x182719FC0", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2719EE0", Offset = "0x2718EE0", VA = "0x182719EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2719F80", Offset = "0x2718F80", VA = "0x182719F80")]
	internal CLCAJOCIKGN(in TSource1Enumerator DEGDJOJKIHJ, in TSource2Enumerator OOHNACAHPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2719D60", Offset = "0x2718D60", VA = "0x182719D60", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2719E70", Offset = "0x2718E70", VA = "0x182719E70", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2719D00", Offset = "0x2718D00", VA = "0x182719D00", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct OAFLPGGHCCA<T, U> : global::EODNLBIMIJP<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U BHCNADKNPDC;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x35D1000", Offset = "0x35D0000", VA = "0x1835D1000")]
	internal OAFLPGGHCCA(in U GFNIILKEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xB54810", Offset = "0xB53810", VA = "0x180B54810", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4819B60", Offset = "0x4818B60", VA = "0x184819B60", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4819B60", Offset = "0x4818B60", VA = "0x184819B60", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class LNHNIKKECIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2C20", Offset = "0x2DE1C20", VA = "0x182DE2C20")]
	public static global::OAFLPGGHCCA<T, U> NEPKDIDOCIM<U>(in U GFNIILKEBCB) where U : IEnumerator<T>
	{
		return default(global::OAFLPGGHCCA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct NDAILLAPPJN<TSourceEnumerator, TSource, TResult> : EODBFKAKBBM, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : EODBFKAKBBM, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator LMBBANBHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> OLBAJNHIGOK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x38207F0", Offset = "0x381F7F0", VA = "0x1838207F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public TResult EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x38208D0", Offset = "0x381F8D0", VA = "0x1838208D0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3820890", Offset = "0x381F890", VA = "0x183820890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x287C280", Offset = "0x287B280", VA = "0x18287C280")]
	internal NDAILLAPPJN(in TSourceEnumerator AMPFEINIDNM, Func<TSource, TResult> CLAPKMKPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38207A0", Offset = "0x381F7A0", VA = "0x1838207A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3820840", Offset = "0x381F840", VA = "0x183820840", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3820750", Offset = "0x381F750", VA = "0x183820750", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LGEBMCHIBII
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x24E24A0", Offset = "0x24E14A0", VA = "0x1824E24A0")]
	public static bool JENEPDEGBNL<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator AMPFEINIDNM, in TArgs OJDNPNIBMOA, in global::PHHANDCLAAL<TArgs, TSource, bool> JCEJNGLAJOG) where TSourceEnumerator : global::GPADANINMLP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x21C7F00", Offset = "0x21C6F00", VA = "0x1821C7F00")]
	public static int ABMHDCLFDND<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator AMPFEINIDNM, in TArgs OJDNPNIBMOA, global::PHHANDCLAAL<TArgs, TSource, bool> JCEJNGLAJOG) where TSourceEnumerator : global::GPADANINMLP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24E2350", Offset = "0x24E1350", VA = "0x1824E2350")]
	public static bool EIOJNCNIEFJ<TSourceEnumerator, TSource>(this TSourceEnumerator AMPFEINIDNM, in TSource PFENDKKONNM) where TSourceEnumerator : global::GPADANINMLP<TSource> where TSource : global::ICCFNJLONFA<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x21C81F0", Offset = "0x21C71F0", VA = "0x1821C81F0")]
	public static int LBLCGNKNKEC<TSourceEnumerator, TSource>(this TSourceEnumerator AMPFEINIDNM, in TSource JNLOLNFALGF) where TSourceEnumerator : global::GPADANINMLP<TSource> where TSource : global::ICCFNJLONFA<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2385530", Offset = "0x2384530", VA = "0x182385530")]
	public static global::CACNKNANCAJ<TSourceEnumerator, TSource, TResult> ALFPLDNCAKF<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator AMPFEINIDNM, global::MJCGAOGKNAI<TSource, TResult> CLAPKMKPBMP) where TSourceEnumerator : EODBFKAKBBM, global::GPADANINMLP<TSource>
	{
		return default(global::CACNKNANCAJ<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB4B0", Offset = "0x1DDA4B0", VA = "0x181DDB4B0")]
	public static global::NDAILLAPPJN<TSourceEnumerator, TSource, TResult> GOKAPJCLDPG<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator AMPFEINIDNM, Func<TSource, TResult> CLAPKMKPBMP) where TSourceEnumerator : EODBFKAKBBM, IEnumerator<TSource>
	{
		return default(global::NDAILLAPPJN<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LGCJKIAGKEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x24E2220", Offset = "0x24E1220", VA = "0x1824E2220")]
	public static bool OPJLLLBBKMC<TSourceEnumerator>(TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2B10", Offset = "0x1DC1B10", VA = "0x181DC2B10")]
	public static T IMGIACEKOAG<TSourceEnumerator>(TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : global::GPADANINMLP<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB3C0", Offset = "0x1DDA3C0", VA = "0x181DDB3C0")]
	public static global::IPILAIBHLHK<TSourceEnumerator, TSource, TResultEnumerator, T> OLJBAGNPFGA<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator AMPFEINIDNM, global::MJCGAOGKNAI<TSource, TResultEnumerator> CLAPKMKPBMP) where TSourceEnumerator : global::GPADANINMLP<TSource> where TResultEnumerator : global::GPADANINMLP<T>
	{
		return default(global::IPILAIBHLHK<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x21672C0", Offset = "0x21662C0", VA = "0x1821672C0")]
	public static string IJIFPNDFAFB<TSourceEnumerator>(TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2D54D70", Offset = "0x2D53D70", VA = "0x182D54D70")]
	public static T[] LEKKBBABPGJ<TSourceEnumerator>(TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : EODBFKAKBBM, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x20C05B0", Offset = "0x20BF5B0", VA = "0x1820C05B0")]
	public static T GLPOGEKAMPB<TSourceEnumerator>(TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x24E20F0", Offset = "0x24E10F0", VA = "0x1824E20F0")]
	public static bool AMBEOHNPDHH<TSourceEnumerator>(TSourceEnumerator AMPFEINIDNM) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class ANBLKKOLKJH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2377BB0", Offset = "0x2376BB0", VA = "0x182377BB0")]
	public static global::CLCAJOCIKGN<TSource1Enumerator, T, TSource2Enumerator, U> LPMMGMKLECH<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator DEGDJOJKIHJ, in TSource2Enumerator OOHNACAHPAI) where TSource1Enumerator : EODBFKAKBBM, global::GPADANINMLP<T> where TSource2Enumerator : EODBFKAKBBM, global::GPADANINMLP<U>
	{
		return default(global::CLCAJOCIKGN<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface OLCKFFAMHON<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GPADANINMLP<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LCLKHNLDMHM<T, TEnumerator> : global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::GPADANINMLP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GPADANINMLP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	T EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CLLBNCOKFFJ<T> : EODBFKAKBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T GNEAPKNKAPI(int BJNKEHJJEBP);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface EODNLBIMIJP<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface EODBFKAKBBM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface ICCFNJLONFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCJAALAEEPP(in T IJDAJAEAAKC);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LDJJHMDMBIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OEJOMOEGFJD<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GBJEAOEEEGN<T, TEnumerator> : global::LDJJHMDMBIK<T>, global::LCLKHNLDMHM<T, TEnumerator>, global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::OEJOMOEGFJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OEJOMOEGFJD<T> : global::GPADANINMLP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new T EINNBBEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void ABCCOLBLNGD<T>(in T JHMMPAIEPKF);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void BFEAFOHACMP<T1, T2>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class BBBBHFEBOLG
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B4D0", Offset = "0x2F8A4D0", VA = "0x182F8B4D0")]
	public static bool CMJKGLGJLLM<T, U>(this T AMPFEINIDNM, in U MDAEAKFNGDG) where T : global::ICCFNJLONFA<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult MJCGAOGKNAI<T, out TResult>(in T JHMMPAIEPKF);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult PHHANDCLAAL<T1, T2, out TResult>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult NDDIKOPFPHG<T1, T2, T3, out TResult>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF, in T3 LCNGJBPGEJG);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult CCAFEMKNKDD<T1, T2, T3, T4, out TResult>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF, in T3 LCNGJBPGEJG, in T4 FNIKFCCOLMC);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult GFCBKCDPNHI<T1, T2, T3, T4, T5, out TResult>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF, in T3 LCNGJBPGEJG, in T4 FNIKFCCOLMC, in T5 HOPHPOPCCDL);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult FHLLPFPLKIL<T, TResult>(in T JHMMPAIEPKF);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult IPJDKDKNIEF<T1, T2, TResult>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult FFFJJJJFDJG<T1, T2, T3, TResult>(in T1 JIDKCBCBNJM, in T2 CFMHDKNCMEF, in T3 LCNGJBPGEJG);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct DIPHMEIKKEM<T> : global::GBJEAOEEEGN<T, global::DIPHMEIKKEM<T>.JOHOHAAAGOB>, global::LDJJHMDMBIK<T>, global::LCLKHNLDMHM<T, global::DIPHMEIKKEM<T>.JOHOHAAAGOB>, global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, global::DIPHMEIKKEM<T>.JOHOHAAAGOB>, IEnumerable<T>, IEnumerable, global::CLLBNCOKFFJ<T>, EODBFKAKBBM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct JOHOHAAAGOB : EODBFKAKBBM, global::OEJOMOEGFJD<T>, global::GPADANINMLP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] LMBBANBHEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int NLCJNMKAJNF;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int HJCHDLKJEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2179700", Offset = "0x2178700", VA = "0x182179700", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public T EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2181620", Offset = "0x2180620", VA = "0x182181620", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private T GCJKDOLLJJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x21814E0", Offset = "0x21804E0", VA = "0x1821814E0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x21815D0", Offset = "0x21805D0", VA = "0x1821815D0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x21815D0", Offset = "0x21805D0", VA = "0x1821815D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA26A90", Offset = "0xA25A90", VA = "0x180A26A90")]
		private JOHOHAAAGOB(T[] AMPFEINIDNM, int IIHEDPBOLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2181560", Offset = "0x2180560", VA = "0x182181560")]
		public static JOHOHAAAGOB NEPKDIDOCIM(T[] AMPFEINIDNM)
		{
			return default(JOHOHAAAGOB);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2181530", Offset = "0x2180530", VA = "0x182181530", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x21815C0", Offset = "0x21805C0", VA = "0x1821815C0", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] OOMDOKBILAM;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2179700", Offset = "0x2178700", VA = "0x182179700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2179AA0", Offset = "0x2178AA0", VA = "0x182179AA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2179A60", Offset = "0x2178A60", VA = "0x182179A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
	internal DIPHMEIKKEM(T[] DNAEDFOPGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x21798A0", Offset = "0x21788A0", VA = "0x1821798A0")]
	public static global::DIPHMEIKKEM<T> FKGGGNACLJB()
	{
		return default(global::DIPHMEIKKEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2179960", Offset = "0x2178960", VA = "0x182179960", Slot = "11")]
	public T GNEAPKNKAPI(int IIHEDPBOLFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2179720", Offset = "0x2178720", VA = "0x182179720")]
	public global::LPKEDKCJEDA<T> CNHEHBBDLEB()
	{
		return default(global::LPKEDKCJEDA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x21799C0", Offset = "0x21789C0", VA = "0x1821799C0", Slot = "8")]
	public JOHOHAAAGOB GetEnumerator()
	{
		return default(JOHOHAAAGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x21797A0", Offset = "0x21787A0", VA = "0x1821797A0", Slot = "5")]
	private global::OEJOMOEGFJD<T> LJJNHENOBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x21797A0", Offset = "0x21787A0", VA = "0x1821797A0", Slot = "7")]
	private global::GPADANINMLP<T> DNFNJPBCGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x21797A0", Offset = "0x21787A0", VA = "0x1821797A0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x21797A0", Offset = "0x21787A0", VA = "0x1821797A0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class FNGGPMAIJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE270", Offset = "0x1DCD270", VA = "0x181DCE270")]
	public static global::DIPHMEIKKEM<T> NEPKDIDOCIM<T>(T[] DNAEDFOPGEJ)
	{
		return default(global::DIPHMEIKKEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0320", Offset = "0x1DBF320", VA = "0x181DC0320")]
	public static global::DIPHMEIKKEM<T> MNAHMDGPBMF<T>(this T[] AMPFEINIDNM)
	{
		return default(global::DIPHMEIKKEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE2A0", Offset = "0x1DCD2A0", VA = "0x181DCE2A0")]
	public static global::DIPHMEIKKEM<T>.JOHOHAAAGOB NNDDDAKBPFF<T>(this T[] AMPFEINIDNM)
	{
		return default(global::DIPHMEIKKEM<T>.JOHOHAAAGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0320", Offset = "0x1DBF320", VA = "0x181DC0320")]
	public static global::DIPHMEIKKEM<T> PJPOMHNPNNM<T>(this T[] AMPFEINIDNM)
	{
		return default(global::DIPHMEIKKEM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct LHFLIFPIMOM<T, U> : global::GBJEAOEEEGN<T, U>, global::LDJJHMDMBIK<T>, global::LCLKHNLDMHM<T, U>, global::OLCKFFAMHON<T>, global::EODNLBIMIJP<T, U>, IEnumerable<T>, IEnumerable where U : global::OEJOMOEGFJD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U BHCNADKNPDC;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x25F71E0", Offset = "0x25F61E0", VA = "0x1825F71E0")]
	internal LHFLIFPIMOM(in U GFNIILKEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "5")]
	private global::OEJOMOEGFJD<T> LJJNHENOBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "7")]
	private global::GPADANINMLP<T> DNFNJPBCGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DDE0", Offset = "0x3E2CDE0", VA = "0x183E2DDE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MFNAKDEHEEG<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x23872F0", Offset = "0x23862F0", VA = "0x1823872F0")]
	public static global::LHFLIFPIMOM<T, U> NEPKDIDOCIM<U>(in U GFNIILKEBCB) where U : global::OEJOMOEGFJD<T>
	{
		return default(global::LHFLIFPIMOM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class LJLGKFCCCEJ<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> EBEICGMKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> CCKAJHEPPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IList<Internal> JFAEFDJPBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x666990", Offset = "0x665990", VA = "0x180666990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA34180", Offset = "0xA33180", VA = "0x180A34180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public External AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A17F30", Offset = "0x3A16F30", VA = "0x183A17F30", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A17FD0", Offset = "0x3A16FD0", VA = "0x183A17FD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A17ED0", Offset = "0x3A16ED0", VA = "0x183A17ED0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A17E40", Offset = "0x3A16E40", VA = "0x183A17E40")]
	public LJLGKFCCCEJ(Func<Internal, External> EBEICGMKMCP, Func<External, Internal> CCKAJHEPPDK, bool NBHMHIMLODK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A17B50", Offset = "0x3A16B50", VA = "0x183A17B50", Slot = "6")]
	public int IndexOf(External PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A177D0", Offset = "0x3A167D0", VA = "0x183A177D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A17830", Offset = "0x3A16830", VA = "0x183A17830", Slot = "13")]
	public bool Contains(External PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A178C0", Offset = "0x3A168C0", VA = "0x183A178C0", Slot = "14")]
	public void CopyTo(External[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A176E0", Offset = "0x3A166E0", VA = "0x183A176E0", Slot = "11")]
	public void Add(External PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A17C40", Offset = "0x3A16C40", VA = "0x183A17C40", Slot = "7")]
	public void Insert(int IIHEDPBOLFE, External PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A17DB0", Offset = "0x3A16DB0", VA = "0x183A17DB0", Slot = "15")]
	public bool Remove(External PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A17CE0", Offset = "0x3A16CE0", VA = "0x183A17CE0", Slot = "8")]
	public void RemoveAt(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A17AE0", Offset = "0x3A16AE0", VA = "0x183A17AE0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2265400", Offset = "0x2264400", VA = "0x182265400", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class HAMBBLBHJLJ<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> EBEICGMKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IReadOnlyList<Internal> JFAEFDJPBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public External AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4327980", Offset = "0x4326980", VA = "0x184327980", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4327920", Offset = "0x4326920", VA = "0x184327920", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
	public HAMBBLBHJLJ(Func<Internal, External> EBEICGMKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x43278D0", Offset = "0x43268D0", VA = "0x1843278D0")]
	public HAMBBLBHJLJ(IReadOnlyList<Internal> DMCFFMAPNPG, Func<Internal, External> EBEICGMKMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x43276B0", Offset = "0x43266B0", VA = "0x1843276B0")]
	public void KKDJIBHIMKA(External[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4327640", Offset = "0x4326640", VA = "0x184327640", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1CC7D20", Offset = "0x1CC6D20", VA = "0x181CC7D20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class FCAHCIPBNMA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IReadOnlyList<Internal> JFAEFDJPBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public External AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x368EA40", Offset = "0x368DA40", VA = "0x18368EA40", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x368E9E0", Offset = "0x368D9E0", VA = "0x18368E9E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
	public FCAHCIPBNMA(IReadOnlyList<Internal> DMCFFMAPNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x368E640", Offset = "0x368D640", VA = "0x18368E640")]
	public bool FAFGFNINKJO(External PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x368E7B0", Offset = "0x368D7B0", VA = "0x18368E7B0")]
	public void KKDJIBHIMKA(External[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x368E6E0", Offset = "0x368D6E0", VA = "0x18368E6E0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2265400", Offset = "0x2264400", VA = "0x182265400", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class GIJCNIOGODB
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KHDGPFDFMBE(object[] OJDNPNIBMOA);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected GIJCNIOGODB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class IDHLECEOJFG<T> : GIJCNIOGODB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct AOEBKCAMLBA
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum CFHLNFGNFOM
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CFHLNFGNFOM GLKKDGLKBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T BBNMGAFNKKA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int CDJMLMAPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool JKCIOCBNIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool HPCBCJJLOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> HCBPIOBKEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<AOEBKCAMLBA> GFODPIDEBEN;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool GEMHEEKLIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x25133F0", Offset = "0x25123F0", VA = "0x1825133F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x25138E0", Offset = "0x25128E0", VA = "0x1825138E0")]
	protected IDHLECEOJFG(bool HPCBCJJLOJE, bool JKCIOCBNIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x25136C0", Offset = "0x25126C0", VA = "0x1825136C0")]
	protected bool OBNADOCBLEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x25135E0", Offset = "0x25125E0", VA = "0x1825135E0")]
	protected void NMJOGMLCBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2513430", Offset = "0x2512430", VA = "0x182513430")]
	protected void NHMEKDBAAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3474910", Offset = "0x3473910", VA = "0x183474910")]
	private static void ICKDKLEIOCL<U>(ref List<U> DMCFFMAPNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2513760", Offset = "0x2512760", VA = "0x182513760", Slot = "5")]
	public void PPCBFHPPBHE(T BBNMGAFNKKA, bool CABNDHOGNMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2513160", Offset = "0x2512160", VA = "0x182513160", Slot = "6")]
	public void DKCILJPFPEA(T BBNMGAFNKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x25132C0", Offset = "0x25122C0", VA = "0x1825132C0")]
	public void MCOHOPDDOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JFFHJFBOCMP
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class GNEFPHEGBGJ : global::IDHLECEOJFG<Action>, JFFHJFBOCMP
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5768E10", Offset = "0x5767E10", VA = "0x185768E10")]
	public GNEFPHEGBGJ(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5768BD0", Offset = "0x5767BD0", VA = "0x185768BD0")]
	public void JONEFOPHFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5768D90", Offset = "0x5767D90", VA = "0x185768D90", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5768B70", Offset = "0x5767B70", VA = "0x185768B70")]
	public static GNEFPHEGBGJ JCNGAANMENI(GNEFPHEGBGJ KOCMMODDDKD, Action BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5768B10", Offset = "0x5767B10", VA = "0x185768B10")]
	public static GNEFPHEGBGJ HIHEDOPKOFD(GNEFPHEGBGJ KOCMMODDDKD, Action BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface EEEAOHAGMCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action<T> BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action<T> BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class OONEDGICBMA<T> : global::IDHLECEOJFG<Action<T>>, global::EEEAOHAGMCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2516A80", Offset = "0x2515A80", VA = "0x182516A80")]
	public OONEDGICBMA(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x26D80B0", Offset = "0x26D70B0", VA = "0x1826D80B0")]
	public void JONEFOPHFLN(T JBJIMKKMMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x26DBAA0", Offset = "0x26DAAA0", VA = "0x1826DBAA0", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x26D6FF0", Offset = "0x26D5FF0", VA = "0x1826D6FF0")]
	public static global::OONEDGICBMA<T> JCNGAANMENI(global::OONEDGICBMA<T> KOCMMODDDKD, Action<T> BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x26D6F50", Offset = "0x26D5F50", VA = "0x1826D6F50")]
	public static global::OONEDGICBMA<T> HIHEDOPKOFD(global::OONEDGICBMA<T> KOCMMODDDKD, Action<T> BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface MCHDLLMFBKP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action<T, U> BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action<T, U> BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class EDFCDEHHEDJ<T, U> : global::IDHLECEOJFG<Action<T, U>>, global::MCHDLLMFBKP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2516A80", Offset = "0x2515A80", VA = "0x182516A80")]
	public EDFCDEHHEDJ(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EFB0", Offset = "0x3C0DFB0", VA = "0x183C0EFB0")]
	public void JONEFOPHFLN(T JBJIMKKMMPN, U IOAPHBNDBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3C12710", Offset = "0x3C11710", VA = "0x183C12710", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DDD0", Offset = "0x3C0CDD0", VA = "0x183C0DDD0")]
	public static global::EDFCDEHHEDJ<T, U> JCNGAANMENI(global::EDFCDEHHEDJ<T, U> KOCMMODDDKD, Action<T, U> BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DD30", Offset = "0x3C0CD30", VA = "0x183C0DD30")]
	public static global::EDFCDEHHEDJ<T, U> HIHEDOPKOFD(global::EDFCDEHHEDJ<T, U> KOCMMODDDKD, Action<T, U> BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface MIKHIOBFPLK<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action<T, U, V> BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action<T, U, V> BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class HOJJIHMBDOG<T, U, V> : global::IDHLECEOJFG<Action<T, U, V>>, global::MIKHIOBFPLK<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2516A80", Offset = "0x2515A80", VA = "0x182516A80")]
	public HOJJIHMBDOG(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x47F4590", Offset = "0x47F3590", VA = "0x1847F4590")]
	public void JONEFOPHFLN(T JBJIMKKMMPN, U IOAPHBNDBDJ, V PHCLDIDKELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x47F6510", Offset = "0x47F5510", VA = "0x1847F6510", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x47F3AB0", Offset = "0x47F2AB0", VA = "0x1847F3AB0")]
	public static global::HOJJIHMBDOG<T, U, V> JCNGAANMENI(global::HOJJIHMBDOG<T, U, V> KOCMMODDDKD, Action<T, U, V> BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x47F3A10", Offset = "0x47F2A10", VA = "0x1847F3A10")]
	public static global::HOJJIHMBDOG<T, U, V> HIHEDOPKOFD(global::HOJJIHMBDOG<T, U, V> KOCMMODDDKD, Action<T, U, V> BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface IEHFOPCOJNH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action<T, U, V, W> BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action<T, U, V, W> BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class IIMGPENEGMP<T, U, V, W> : global::IDHLECEOJFG<Action<T, U, V, W>>, global::IEHFOPCOJNH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2516A80", Offset = "0x2515A80", VA = "0x182516A80")]
	public IIMGPENEGMP(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3341220", Offset = "0x3340220", VA = "0x183341220")]
	public void JONEFOPHFLN(T JBJIMKKMMPN, U IOAPHBNDBDJ, V PHCLDIDKELI, W AMGKGKNGBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3343680", Offset = "0x3342680", VA = "0x183343680", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3341180", Offset = "0x3340180", VA = "0x183341180")]
	public static global::IIMGPENEGMP<T, U, V, W> JCNGAANMENI(global::IIMGPENEGMP<T, U, V, W> KOCMMODDDKD, Action<T, U, V, W> BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x33410E0", Offset = "0x33400E0", VA = "0x1833410E0")]
	public static global::IIMGPENEGMP<T, U, V, W> HIHEDOPKOFD(global::IIMGPENEGMP<T, U, V, W> KOCMMODDDKD, Action<T, U, V, W> BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface LFMHANGKLNJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action<T, U, V, W, X> BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action<T, U, V, W, X> BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class IFAPMHNPMJH<T, U, V, W, X> : global::IDHLECEOJFG<Action<T, U, V, W, X>>, global::LFMHANGKLNJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2516A80", Offset = "0x2515A80", VA = "0x182516A80")]
	public IFAPMHNPMJH(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x25161D0", Offset = "0x25151D0", VA = "0x1825161D0")]
	public void JONEFOPHFLN(T JBJIMKKMMPN, U IOAPHBNDBDJ, V PHCLDIDKELI, W AMGKGKNGBFO, X JIOINDMBNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2516470", Offset = "0x2515470", VA = "0x182516470", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2515E20", Offset = "0x2514E20", VA = "0x182515E20")]
	public static global::IFAPMHNPMJH<T, U, V, W, X> JCNGAANMENI(global::IFAPMHNPMJH<T, U, V, W, X> KOCMMODDDKD, Action<T, U, V, W, X> BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2515D80", Offset = "0x2514D80", VA = "0x182515D80")]
	public static global::IFAPMHNPMJH<T, U, V, W, X> HIHEDOPKOFD(global::IFAPMHNPMJH<T, U, V, W, X> KOCMMODDDKD, Action<T, U, V, W, X> BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface FNALHBAPNBO<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPCBFHPPBHE(Action<T, U, V, W, X, Y> BBNMGAFNKKA, bool CABNDHOGNMI = false);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCILJPFPEA(Action<T, U, V, W, X, Y> BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class HBCFMDFHNJL<T, U, V, W, X, Y> : global::IDHLECEOJFG<Action<T, U, V, W, X, Y>>, global::FNALHBAPNBO<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2516A80", Offset = "0x2515A80", VA = "0x182516A80")]
	public HBCFMDFHNJL(bool HPCBCJJLOJE = false, bool JKCIOCBNIAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4328130", Offset = "0x4327130", VA = "0x184328130")]
	public void JONEFOPHFLN(T JBJIMKKMMPN, U IOAPHBNDBDJ, V PHCLDIDKELI, W AMGKGKNGBFO, X JIOINDMBNBK, Y AOEDNBDEECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4328740", Offset = "0x4327740", VA = "0x184328740", Slot = "4")]
	public override void KHDGPFDFMBE(object[] OJDNPNIBMOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4327AC0", Offset = "0x4326AC0", VA = "0x184327AC0")]
	public static global::HBCFMDFHNJL<T, U, V, W, X, Y> JCNGAANMENI(global::HBCFMDFHNJL<T, U, V, W, X, Y> KOCMMODDDKD, Action<T, U, V, W, X, Y> BBNMGAFNKKA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4327A20", Offset = "0x4326A20", VA = "0x184327A20")]
	public static global::HBCFMDFHNJL<T, U, V, W, X, Y> HIHEDOPKOFD(global::HBCFMDFHNJL<T, U, V, W, X, Y> KOCMMODDDKD, Action<T, U, V, W, X, Y> BBNMGAFNKKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class ABLKAHKPDKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct ADFKDILGKNG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::ABLKAHKPDKC<T> FCGPGLJKEJB;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public T GFNFCEIHNLL
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x30A0C60", Offset = "0x309FC60", VA = "0x1830A0C60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x30A0C30", Offset = "0x309FC30", VA = "0x1830A0C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x726470", Offset = "0x725470", VA = "0x180726470")]
		public ADFKDILGKNG(global::ABLKAHKPDKC<T> FCGPGLJKEJB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct NHBECDFNFLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<ADFKDILGKNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::ABLKAHKPDKC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x30B22F0", Offset = "0x30B12F0", VA = "0x1830B22F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x30B24C0", Offset = "0x30B14C0", VA = "0x1830B24C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct PLGAGAJOOKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<ADFKDILGKNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::ABLKAHKPDKC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x30B2510", Offset = "0x30B1510", VA = "0x1830B2510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x30B24C0", Offset = "0x30B14C0", VA = "0x1830B24C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim LBHNKCCOLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T HMFCICMKDFO;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int BBKGDPJKOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x30A07A0", Offset = "0x309F7A0", VA = "0x1830A07A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x30A0870", Offset = "0x309F870", VA = "0x1830A0870")]
	public ABLKAHKPDKC(in T HMFCICMKDFO, int DDPMNIHKKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x30A0840", Offset = "0x309F840", VA = "0x1830A0840")]
	public ABLKAHKPDKC(in T HMFCICMKDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x30A07C0", Offset = "0x309F7C0", VA = "0x1830A07C0")]
	public ADFKDILGKNG MEAIDKADGEC()
	{
		return default(ADFKDILGKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x30A0800", Offset = "0x309F800", VA = "0x1830A0800")]
	public ADFKDILGKNG MEAIDKADGEC(CancellationToken JNDOKGNDNMO)
	{
		return default(ADFKDILGKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x30A01E0", Offset = "0x309F1E0", VA = "0x1830A01E0")]
	[AsyncStateMachine(typeof(global::ABLKAHKPDKC<>.NHBECDFNFLA))]
	public Task<ADFKDILGKNG> BNINLCOMJHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309F340", VA = "0x1830A0340")]
	[AsyncStateMachine(typeof(global::ABLKAHKPDKC<>.PLGAGAJOOKN))]
	public Task<ADFKDILGKNG> BNINLCOMJHP(CancellationToken JNDOKGNDNMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class FDFOEODNAIL
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5768140", Offset = "0x5767140", VA = "0x185768140")]
	public static global::ABLKAHKPDKC<OBILJNMGGGG> NEPKDIDOCIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x57681A0", Offset = "0x57671A0", VA = "0x1857681A0")]
	public static global::ABLKAHKPDKC<OBILJNMGGGG> NEPKDIDOCIM(int DDPMNIHKKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1CAFDB0", Offset = "0x1CAEDB0", VA = "0x181CAFDB0")]
	public static global::ABLKAHKPDKC<T> NEPKDIDOCIM<T>(in T HMFCICMKDFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF7A0", Offset = "0x1DCE7A0", VA = "0x181DCF7A0")]
	public static global::ABLKAHKPDKC<T> NEPKDIDOCIM<T>(in T HMFCICMKDFO, int DDPMNIHKKPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IACEFLFLKCG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate Task<TResult> KCAPHLNHMAK(TRequest PDHKNAGOONJ, CancellationToken JNDOKGNDNMO);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum KMJINDEACKP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class HANNFMFENHO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private const float FFCJMDJCOKJ = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TimeSpan EDEJHAKEALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int DJAEGPDOEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KMJINDEACKP ALBPGKLPKFO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly HANNFMFENHO CDLKEADKJFL;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float PFFFDEKLFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2509190", Offset = "0x2508190", VA = "0x182509190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public TimeSpan MMKBFKFDICH
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2509350", Offset = "0x2508350", VA = "0x182509350")]
		public HANNFMFENHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private readonly struct EEFBABIGJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly TRequest PDHKNAGOONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly CancellationToken JNDOKGNDNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly TaskCompletionSource<TResult> HDPNJGHNDIN;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5311780", Offset = "0x5310780", VA = "0x185311780")]
		public EEFBABIGJMA(TRequest PDHKNAGOONJ, TaskCompletionSource<TResult> HDPNJGHNDIN, CancellationToken JNDOKGNDNMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class OCBJDLMLOAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public OCBJDLMLOAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2178F70", Offset = "0x2177F70", VA = "0x182178F70")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct JLEGGDHCMON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public global::IACEFLFLKCG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x25193E0", Offset = "0x25183E0", VA = "0x1825193E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct NKMPKNLBOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public global::IACEFLFLKCG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private EEFBABIGJMA <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x251EA10", Offset = "0x251DA10", VA = "0x18251EA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationTokenSource DLEGECIONCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<EEFBABIGJMA> LEMEGGDFONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly HANNFMFENHO OJIINKGNAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly KCAPHLNHMAK JNEIFKADPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Task HMNJGBHOJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int BKLBLAABOFN;

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x250AF40", Offset = "0x2509F40", VA = "0x18250AF40")]
	public IACEFLFLKCG(KCAPHLNHMAK JNEIFKADPJA, [Optional] HANNFMFENHO OJIINKGNAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x250A150", Offset = "0x2509150", VA = "0x18250A150")]
	public Task<TResult> JKKBOCEHBJF(TRequest PDHKNAGOONJ, CancellationToken JNDOKGNDNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x250A8F0", Offset = "0x25098F0", VA = "0x18250A8F0")]
	private void MANEAPEHPDP(EEFBABIGJMA OAFKNHLDDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2509BB0", Offset = "0x2508BB0", VA = "0x182509BB0")]
	[AsyncStateMachine(typeof(global::IACEFLFLKCG<, >.JLEGGDHCMON))]
	private Task HPPNABBDDHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2509470", Offset = "0x2508470", VA = "0x182509470")]
	private EEFBABIGJMA HHFJDJBKAFI()
	{
		return default(EEFBABIGJMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x250AC60", Offset = "0x2509C60", VA = "0x18250AC60")]
	[AsyncStateMachine(typeof(global::IACEFLFLKCG<, >.NKMPKNLBOED))]
	private Task NNAHGIOEEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x250A6C0", Offset = "0x25096C0", VA = "0x18250A6C0")]
	private void JLIBOKHPOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2509430", Offset = "0x2508430", VA = "0x182509430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KGNHNKAPCMP<TKey, TVal> : global::AIBIMECPBLD<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int ADPAGLGLGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal Dictionary<TKey, (TVal value, int size)> CNPGBCKEEHP;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	internal override int PLGMLOPFMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8E00", Offset = "0x3DF7E00", VA = "0x183DF8E00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	internal int COOKIMDCGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8E30", Offset = "0x3DF7E30", VA = "0x183DF8E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public override int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9090", Offset = "0x3DF8090", VA = "0x183DF9090", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9320", Offset = "0x3DF8320", VA = "0x183DF9320")]
	public KGNHNKAPCMP(int FANLILHFAFO, [Optional] DDFLCCNDPHI ODDJEOIDGKE, [Optional] IEqualityComparer<TKey> NMPNCDNENNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8F00", Offset = "0x3DF7F00", VA = "0x183DF8F00")]
	public void JAKCPMKEEIP(TKey GGLJFLNJABJ, TVal JNLOLNFALGF, bool BJNFOHDADDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8FA0", Offset = "0x3DF7FA0", VA = "0x183DF8FA0")]
	public bool JJFCLDJDKBA(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8D50", Offset = "0x3DF7D50", VA = "0x183DF8D50", Slot = "6")]
	public override bool DCDCMBICKAB(TKey FLIHPMDIHHG, out TVal JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3DF90F0", Offset = "0x3DF80F0", VA = "0x183DF90F0")]
	public bool PMNAOEKCLJL(TKey GGLJFLNJABJ, TVal JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8C40", Offset = "0x3DF7C40", VA = "0x183DF8C40")]
	public bool AHJPBMGMHND(TKey GGLJFLNJABJ, TVal JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9020", Offset = "0x3DF8020", VA = "0x183DF9020", Slot = "7")]
	public override void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8E60", Offset = "0x3DF7E60", VA = "0x183DF8E60")]
	private bool GHHHMLEMFCK(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class AIBIMECPBLD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate int DDFLCCNDPHI(TKey GGLJFLNJABJ, TVal JNLOLNFALGF);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class FBEPMHFJNGP
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public TKey CLPKDAIHDOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public TVal GFNFCEIHNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x713FE0", Offset = "0x712FE0", VA = "0x180713FE0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x7B9CD0", Offset = "0x7B8CD0", VA = "0x1807B9CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int GFEAMCLPGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x7378D0", Offset = "0x7368D0", VA = "0x1807378D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736900", VA = "0x180737900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public DateTime AJOKNJOLEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x10C74D0", Offset = "0x10C64D0", VA = "0x1810C74D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2111BA0", Offset = "0x2110BA0", VA = "0x182111BA0")]
		public FBEPMHFJNGP(TKey GGLJFLNJABJ, TVal CDCAGKIIGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const int JJCKLJNHMLF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<TKey, LinkedListNode<FBEPMHFJNGP>> OAKABLPJNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly LinkedList<FBEPMHFJNGP> LCDHBGENFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	protected readonly DDFLCCNDPHI ODDJEOIDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly TimeSpan GLGIJGMOGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly GDBIMAICHEG APJHJNFDCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int FFCMDJLMGGD;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OHMIEBEANAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x740CD0", Offset = "0x73FCD0", VA = "0x180740CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private bool PELGMPCDJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x210BDF0", Offset = "0x210ADF0", VA = "0x18210BDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal virtual int PLGMLOPFMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x740CE0", Offset = "0x73FCE0", VA = "0x180740CE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private int FBKJALIBHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x210B720", Offset = "0x210A720", VA = "0x18210B720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public virtual int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4600", Offset = "0x1CC3600", VA = "0x181CC4600", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IEnumerable<TKey> NCNFHHNPBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x210BA30", Offset = "0x210AA30", VA = "0x18210BA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public TVal AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x210BDC0", Offset = "0x210ADC0", VA = "0x18210BDC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x210B2E0", Offset = "0x210A2E0", VA = "0x18210B2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x210C9A0", Offset = "0x210B9A0", VA = "0x18210C9A0")]
	public AIBIMECPBLD(int FANLILHFAFO, [Optional] DDFLCCNDPHI ODDJEOIDGKE, [Optional] IEqualityComparer<TKey> NMPNCDNENNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x210C3B0", Offset = "0x210B3B0", VA = "0x18210C3B0")]
	public AIBIMECPBLD(TimeSpan GLGIJGMOGAI, [Optional] IEqualityComparer<TKey> NMPNCDNENNE, [Optional] GDBIMAICHEG APJHJNFDCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x210C710", Offset = "0x210B710", VA = "0x18210C710")]
	public AIBIMECPBLD(int FANLILHFAFO, TimeSpan GLGIJGMOGAI, [Optional] IEqualityComparer<TKey> NMPNCDNENNE, [Optional] GDBIMAICHEG APJHJNFDCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x210C4D0", Offset = "0x210B4D0", VA = "0x18210C4D0")]
	public AIBIMECPBLD(int FANLILHFAFO, DDFLCCNDPHI ODDJEOIDGKE, TimeSpan GLGIJGMOGAI, [Optional] IEqualityComparer<TKey> NMPNCDNENNE, [Optional] GDBIMAICHEG APJHJNFDCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x210BC50", Offset = "0x210AC50", VA = "0x18210BC50")]
	public void ICCDFFKDOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x210B970", Offset = "0x210A970", VA = "0x18210B970")]
	public void GALDMPBHILF(TKey GGLJFLNJABJ, TVal JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x210B5C0", Offset = "0x210A5C0", VA = "0x18210B5C0")]
	public bool DKCILJPFPEA(TKey GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x210B750", Offset = "0x210A750", VA = "0x18210B750")]
	private TVal FGPHONIFMEK(TKey FLIHPMDIHHG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x210B310", Offset = "0x210A310", VA = "0x18210B310", Slot = "6")]
	public virtual bool DCDCMBICKAB(TKey FLIHPMDIHHG, out TVal JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x210BE80", Offset = "0x210AE80", VA = "0x18210BE80", Slot = "7")]
	public virtual void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x210BFB0", Offset = "0x210AFB0", VA = "0x18210BFB0")]
	private bool OBLILFCKCLN(FBEPMHFJNGP LGDAHEIIHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x210AAF0", Offset = "0x2109AF0", VA = "0x18210AAF0")]
	private void AMFBICFHPMA(LinkedListNode<FBEPMHFJNGP> APADFEIEJAA, TVal CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x210B110", Offset = "0x210A110", VA = "0x18210B110")]
	private void BINADFEEINP(TKey GGLJFLNJABJ, TVal JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x210C210", Offset = "0x210B210", VA = "0x18210C210")]
	private void OJLKJJNOKLD(FBEPMHFJNGP LGDAHEIIHPC, TVal CACEPBECNCN, int GJIKPEJODHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public class DNJLFCDKDDM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly List<T> DMCFFMAPNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private HashSet<T> HCKACKFLNMD;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2178F70", Offset = "0x2177F70", VA = "0x182178F70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x27C1EF0", Offset = "0x27C0EF0", VA = "0x1827C1EF0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x4298B30", Offset = "0x4297B30", VA = "0x184298B30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x271A940", Offset = "0x2719940", VA = "0x18271A940", Slot = "11")]
	public void Add(T PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4298490", Offset = "0x4297490", VA = "0x184298490")]
	public bool IOLPAJPCMFB(T PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4298940", Offset = "0x4297940", VA = "0x184298940", Slot = "15")]
	public bool Remove(T PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x26D6CB0", Offset = "0x26D5CB0", VA = "0x1826D6CB0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2266230", Offset = "0x2265230", VA = "0x182266230", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4298430", Offset = "0x4297430", VA = "0x184298430", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2509030", Offset = "0x2508030", VA = "0x182509030", Slot = "13")]
	public bool Contains(T PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x27C1DA0", Offset = "0x27C0DA0", VA = "0x1827C1DA0", Slot = "14")]
	public void CopyTo(T[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x3A946A0", Offset = "0x3A936A0", VA = "0x183A946A0", Slot = "6")]
	public int IndexOf(T PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x42985E0", Offset = "0x42975E0", VA = "0x1842985E0", Slot = "7")]
	public void Insert(int IIHEDPBOLFE, T PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x42987A0", Offset = "0x42977A0", VA = "0x1842987A0", Slot = "8")]
	public void RemoveAt(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x4298360", Offset = "0x4297360", VA = "0x184298360")]
	public void CKHKLOGCFOI(Predicate<T> GMPPIODFDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4298770", Offset = "0x4297770", VA = "0x184298770")]
	public void LONLOADKKJM(Comparison<T> CHEOPJCHMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4298A50", Offset = "0x4297A50", VA = "0x184298A50")]
	public DNJLFCDKDDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class DDCNPCGDAIE
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5766F50", Offset = "0x5765F50", VA = "0x185766F50")]
	public static Vector3 LOJMKLPOLPI(this GameObject PKGBHIMGLPM, float NPJCAJLMJJF)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x1E957B0", Offset = "0x1E947B0", VA = "0x181E957B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x576D8F0", Offset = "0x576C8F0", VA = "0x18576D8F0")]
		public SerializedGuid(in Guid BEAFCMKDKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x576D440", Offset = "0x576C440", VA = "0x18576D440")]
		public static SerializedGuid AODIPEBEPOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x576D4F0", Offset = "0x576C4F0", VA = "0x18576D4F0")]
		public static SerializedGuid DJHMACCNEIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x576D700", Offset = "0x576C700", VA = "0x18576D700")]
		public bool IJGLOCIIHFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x576D8C0", Offset = "0x576C8C0", VA = "0x18576D8C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x576D820", Offset = "0x576C820", VA = "0x18576D820", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x576D790", Offset = "0x576C790", VA = "0x18576D790")]
		public bool MHJPJGBBFJN(in Guid BEAFCMKDKCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x576D570", Offset = "0x576C570", VA = "0x18576D570", Slot = "7")]
		public bool Equals(SerializedGuid IJDAJAEAAKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x576D610", Offset = "0x576C610", VA = "0x18576D610", Slot = "0")]
		public override bool Equals(object MDAEAKFNGDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x576D6F0", Offset = "0x576C6F0", VA = "0x18576D6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x576D4C0", Offset = "0x576C4C0", VA = "0x18576D4C0", Slot = "6")]
		public int CompareTo(SerializedGuid IJDAJAEAAKC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class FEHONFNNNGH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly Type LPONFACIGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string CKCDGJOGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly bool JABFNEFMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly bool KLFHNBMGEED;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5768210", Offset = "0x5767210", VA = "0x185768210")]
	public FEHONFNNNGH(Type FEPBMHAODEI, string JNJENABBIFL, bool IKGAECALELD = false, bool FLKBMCEBCPE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface LBKPALGNFIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface CFKEJKLCKNP<T> : LBKPALGNFIP
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	T GFNFCEIHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool CCDAJDAEDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string PCJPCKNOILK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CFKEJKLCKNP<T> MPEFJAHPAOC(Action<T> DOEOMPHHBGL);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CFKEJKLCKNP<T> FDAKLOGMHCL(Action<T> DOEOMPHHBGL);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::CFKEJKLCKNP<T> OJLNLDNAHIM(Action<T, T> NIGDMNEALCN);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::CFKEJKLCKNP<T> HHIHADBCGPK(Action<T, T> NIGDMNEALCN);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::CFKEJKLCKNP<T> BHGCCNLPONL(Action<string> JDENDGOOPAN);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::CFKEJKLCKNP<T> EMKLLHIHGMB(Action<string> JDENDGOOPAN);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EGDEKJJDILN<T> : global::CFKEJKLCKNP<T>, LBKPALGNFIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private global::EDFCDEHHEDJ<T, T> EIIPCOHNGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private global::OONEDGICBMA<T> OEFOMBDFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::OONEDGICBMA<string> BBCMLOBEPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private string PGKDPDHANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private T HCBFPGACPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool CPKHLAFBGDA;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public T GFNFCEIHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x216F8D0", Offset = "0x216E8D0", VA = "0x18216F8D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool CCDAJDAEDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6678B0", Offset = "0x6668B0", VA = "0x1806678B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public string PCJPCKNOILK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x287D570", Offset = "0x287C570", VA = "0x18287D570", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C16DC0", Offset = "0x3C15DC0", VA = "0x183C16DC0")]
	private void HBHHAINOFBE(T PHHFPJMDJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C16F40", Offset = "0x3C15F40", VA = "0x183C16F40")]
	private void NBDLLCCPNLG(string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3C17030", Offset = "0x3C16030", VA = "0x183C17030")]
	public void PJOAAHNBHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3C16FE0", Offset = "0x3C15FE0", VA = "0x183C16FE0", Slot = "6")]
	public global::CFKEJKLCKNP<T> OJLNLDNAHIM(Action<T, T> NIGDMNEALCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C16E60", Offset = "0x3C15E60", VA = "0x183C16E60", Slot = "7")]
	public global::CFKEJKLCKNP<T> HHIHADBCGPK(Action<T, T> NIGDMNEALCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3C16EB0", Offset = "0x3C15EB0", VA = "0x183C16EB0", Slot = "4")]
	public global::CFKEJKLCKNP<T> MPEFJAHPAOC(Action<T> NIGDMNEALCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3C16D70", Offset = "0x3C15D70", VA = "0x183C16D70", Slot = "5")]
	public global::CFKEJKLCKNP<T> FDAKLOGMHCL(Action<T> DOEOMPHHBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C16C70", Offset = "0x3C15C70", VA = "0x183C16C70", Slot = "8")]
	public global::CFKEJKLCKNP<T> BHGCCNLPONL(Action<string> JDENDGOOPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C16D00", Offset = "0x3C15D00", VA = "0x183C16D00", Slot = "9")]
	public global::CFKEJKLCKNP<T> EMKLLHIHGMB(Action<string> JDENDGOOPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C170E0", Offset = "0x3C160E0", VA = "0x183C170E0")]
	public EGDEKJJDILN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class AEBKPENMKEM
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class NAHMIGCOMEG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public global::CFKEJKLCKNP<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::LIMIAHLCBDI<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public NAHMIGCOMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x30B2020", Offset = "0x30B1020", VA = "0x1830B2020")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2060770", Offset = "0x205F770", VA = "0x182060770")]
	public static global::LBHHDEJJNHM<T> KDDIPPKHHEK<T>(this global::CFKEJKLCKNP<T> HAKDOKABPPJ, Action<T> PCMFICPIFCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class JKOIANHLHOA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct PNDIPJAIIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly long JGAFFBLBKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly long MJLBBBBAIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly int OMBFOFGHFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly int MFNJLLJIJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly bool AGHIIIIDNOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string IHOLPPJPDKE;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x3498B40", Offset = "0x3497B40", VA = "0x183498B40")]
		public PNDIPJAIIED(long JGAFFBLBKCA, int OMBFOFGHFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x3498B10", Offset = "0x3497B10", VA = "0x183498B10")]
		public PNDIPJAIIED(long JGAFFBLBKCA, long MJLBBBBAIGL, int OMBFOFGHFDP, int MFNJLLJIJGN, bool AGHIIIIDNOI, string IHOLPPJPDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3498990", Offset = "0x3497990", VA = "0x183498990")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CNJMDCKHLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3498A00", Offset = "0x3497A00", VA = "0x183498A00")]
		public int DDCBAFKMDLO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3498970", Offset = "0x3497970", VA = "0x183498970")]
		public int CHPGBDHBEOB(int EECCLPJAGPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3498900", Offset = "0x3497900", VA = "0x183498900")]
		public double BMHBKNCGJHJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3498A50", Offset = "0x3497A50", VA = "0x183498A50")]
		public PNDIPJAIIED NEPBCLGEMCD(long MJLBBBBAIGL, int MFNJLLJIJGN)
		{
			return default(PNDIPJAIIED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MLACCLOKFHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly TKey CLPKDAIHDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly global::JKOIANHLHOA<TKey> BCAFPIOPGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<MLACCLOKFHB> JLHLHBCJEJP;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string PECCLMEKKIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x27C19D0", Offset = "0x27C09D0", VA = "0x1827C19D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x34976D0", Offset = "0x34966D0", VA = "0x1834976D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<MLACCLOKFHB> GMNMBFINLNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x3497700", Offset = "0x3496700", VA = "0x183497700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public PNDIPJAIIED MOPIKHHDOPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x1050870", Offset = "0x104F870", VA = "0x181050870")]
			[CompilerGenerated]
			get
			{
				return default(PNDIPJAIIED);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x3497AF0", Offset = "0x3496AF0", VA = "0x183497AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x3497B20", Offset = "0x3496B20", VA = "0x183497B20")]
		internal MLACCLOKFHB(global::JKOIANHLHOA<TKey> BCAFPIOPGIA, TKey GGLJFLNJABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x34979E0", Offset = "0x34969E0", VA = "0x1834979E0")]
		public MLACCLOKFHB JJDFNJGAKCG(TKey GGLJFLNJABJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x34978E0", Offset = "0x34968E0", VA = "0x1834978E0")]
		public void ILKKPAGLGFN(TKey GGLJFLNJABJ, Action<MLACCLOKFHB> BBNMGAFNKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x20C1A90", Offset = "0x20C0A90", VA = "0x1820C1A90")]
		public T ILKKPAGLGFN<T>(TKey GGLJFLNJABJ, Func<MLACCLOKFHB, T> IFFGGIOGCDO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2288D90", Offset = "0x2287D90", VA = "0x182288D90")]
		[AsyncStateMachine(typeof(OAGGGBEOAKK))]
		public Task<T> FIFMGIOMIGN<T>(TKey GGLJFLNJABJ, Func<MLACCLOKFHB, Task<T>> IFFGGIOGCDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x3497720", Offset = "0x3496720", VA = "0x183497720", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class HMIBKIOGJOJ : IEnumerable<(TKey, List<TKey>, PNDIPJAIIED)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PNDIPJAIIED)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private (TKey key, List<TKey> path, PNDIPJAIIED timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public global::JKOIANHLHOA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private IEnumerator<(TKey key, List<TKey> path, PNDIPJAIIED timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private (TKey, List<TKey>, PNDIPJAIIED) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x30BCF20", Offset = "0x30BBF20", VA = "0x1830BCF20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PNDIPJAIIED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x348C5A0", Offset = "0x348B5A0", VA = "0x18348C5A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x30BD470", Offset = "0x30BC470", VA = "0x1830BD470")]
		[DebuggerHidden]
		public HMIBKIOGJOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x348C600", Offset = "0x348B600", VA = "0x18348C600", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x348C220", Offset = "0x348B220", VA = "0x18348C220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x348C680", Offset = "0x348B680", VA = "0x18348C680")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x348C550", Offset = "0x348B550", VA = "0x18348C550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x348C490", Offset = "0x348B490", VA = "0x18348C490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PNDIPJAIIED)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4FD0", Offset = "0x1CC3FD0", VA = "0x181CC4FD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class PINLFHBKOMP : IEnumerable<(TKey, List<TKey>, PNDIPJAIIED)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PNDIPJAIIED)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private (TKey key, List<TKey> path, PNDIPJAIIED timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private MLACCLOKFHB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MLACCLOKFHB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::JKOIANHLHOA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IEnumerator<MLACCLOKFHB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private IEnumerator<(TKey key, List<TKey> path, PNDIPJAIIED timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private (TKey, List<TKey>, PNDIPJAIIED) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x30BCF20", Offset = "0x30BBF20", VA = "0x1830BCF20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PNDIPJAIIED));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x3498730", Offset = "0x3497730", VA = "0x183498730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x30BD470", Offset = "0x30BC470", VA = "0x1830BD470")]
		[DebuggerHidden]
		public PINLFHBKOMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x3498790", Offset = "0x3497790", VA = "0x183498790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x34980A0", Offset = "0x34970A0", VA = "0x1834980A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x3498860", Offset = "0x3497860", VA = "0x183498860")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x34988B0", Offset = "0x34978B0", VA = "0x1834988B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x34986E0", Offset = "0x34976E0", VA = "0x1834986E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x34985E0", Offset = "0x34975E0", VA = "0x1834985E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PNDIPJAIIED)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x34986B0", Offset = "0x34976B0", VA = "0x1834986B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Action<TKey, PNDIPJAIIED> KKFNICNKMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action<TKey, PNDIPJAIIED> NIAMLMJLENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<global::JKOIANHLHOA<TKey>> EPPEBKCHIDE;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private const string IAEGAIBACAH = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly MLACCLOKFHB GMDCBJGHKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool JBNHMJHHOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int DJPCMMJNALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Stopwatch AEHDKKNNPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public readonly int NICNIACLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private string BCFJGOOBGHB;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public MLACCLOKFHB JJPEGGEAFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	[NotNull]
	public string PECCLMEKKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x638130", Offset = "0x637130", VA = "0x180638130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3491BD0", Offset = "0x3490BD0", VA = "0x183491BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public long DELGPNJONBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3491F00", Offset = "0x3490F00", VA = "0x183491F00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int OMKOCAFDGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3491C30", Offset = "0x3490C30", VA = "0x183491C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3491F40", Offset = "0x3490F40", VA = "0x183491F40")]
	public JKOIANHLHOA(TKey JFHEFPPNMCA, [Optional] int? OMBFOFGHFDP, [Optional][CanBeNull] Stopwatch AEHDKKNNPGD, [Optional] Action<TKey, PNDIPJAIIED> KKFNICNKMGJ, [Optional] Action<TKey, PNDIPJAIIED> NIAMLMJLENK, [Optional] Action<global::JKOIANHLHOA<TKey>> EPPEBKCHIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3491C60", Offset = "0x3490C60", VA = "0x183491C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3491F20", Offset = "0x3490F20", VA = "0x183491F20")]
	public void OKCMHKMEEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3491E50", Offset = "0x3490E50", VA = "0x183491E50")]
	public void EPGJGNCDPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3491CF0", Offset = "0x3490CF0", VA = "0x183491CF0")]
	[IteratorStateMachine(typeof(global::JKOIANHLHOA<>.HMIBKIOGJOJ))]
	public IEnumerable<(TKey, List<TKey>, PNDIPJAIIED)> EEJAJGGMJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3491D80", Offset = "0x3490D80", VA = "0x183491D80")]
	[IteratorStateMachine(typeof(global::JKOIANHLHOA<>.PINLFHBKOMP))]
	private IEnumerable<(TKey, List<TKey>, PNDIPJAIIED)> EEJAJGGMJIC(List<TKey> LLBPEMIKGCJ, MLACCLOKFHB LCCNNNKHMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3491E70", Offset = "0x3490E70", VA = "0x183491E70")]
	private (long, int) LJGMAMNLNMN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class OHFJCBLAIED<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut DOJNNMCCGNO(global::JKOIANHLHOA<TKey> BCAFPIOPGIA);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	protected OHFJCBLAIED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class NBDGDNKBMDJ<TKey> : global::OHFJCBLAIED<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public delegate string KDPIOPOPFAF(TKey GGLJFLNJABJ);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3820430", Offset = "0x381F430", VA = "0x183820430")]
	protected string EGAEJOJCABH(double IHBPLCAOMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x3820210", Offset = "0x381F210", VA = "0x183820210")]
	protected string BJGLCIEOGIC(int LHHOLEGHFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3820490", Offset = "0x381F490", VA = "0x183820490")]
	private static string LLGIJDDHLKI(TKey GGLJFLNJABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3820380", Offset = "0x381F380", VA = "0x183820380", Slot = "4")]
	public override string DOJNNMCCGNO(global::JKOIANHLHOA<TKey> BCAFPIOPGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3820260", Offset = "0x381F260", VA = "0x183820260")]
	public string DOJNNMCCGNO(global::JKOIANHLHOA<TKey> BCAFPIOPGIA, [NotNull] KDPIOPOPFAF HFPPJMFPGHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PBHAMANHMDD(global::JKOIANHLHOA<TKey> BCAFPIOPGIA, [NotNull] KDPIOPOPFAF HFPPJMFPGHP);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2265400", Offset = "0x2264400", VA = "0x182265400")]
	protected NBDGDNKBMDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class KDCFNFAJMFI<TKey> : global::OHFJCBLAIED<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate string FODMALAHPMB(TKey GGLJFLNJABJ);

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const int LFCNFJDCOID = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string DKAGMAIMEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly double DBAGCBKELIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly bool POPKBKNPJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int AJPKOLAKKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly ISet<string> FOAFAHFOLHF;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x32F4FD0", Offset = "0x32F3FD0", VA = "0x1832F4FD0")]
	private static string LLGIJDDHLKI(TKey GGLJFLNJABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x32F51C0", Offset = "0x32F41C0", VA = "0x1832F51C0")]
	public KDCFNFAJMFI(string DKAGMAIMEJD = "F2", double DBAGCBKELIP = double.MaxValue, bool POPKBKNPJLJ = false, int AJPKOLAKKIJ = int.MaxValue, [Optional] ISet<string> FOAFAHFOLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x32F49A0", Offset = "0x32F39A0", VA = "0x1832F49A0", Slot = "4")]
	public override Dictionary<string, string> DOJNNMCCGNO(global::JKOIANHLHOA<TKey> BCAFPIOPGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x32F4EF0", Offset = "0x32F3EF0", VA = "0x1832F4EF0")]
	private bool JFIPLGEGBFF(string CBHLFJMOLAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x32F4A50", Offset = "0x32F3A50", VA = "0x1832F4A50")]
	public Dictionary<string, string> DOJNNMCCGNO(global::JKOIANHLHOA<TKey> BCAFPIOPGIA, FODMALAHPMB HFPPJMFPGHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x32F5010", Offset = "0x32F4010", VA = "0x1832F5010")]
	private string PGPCFPALJHL(StringBuilder BFFCPBNACNA, List<TKey> JFHNBIMMJBC, FODMALAHPMB HFPPJMFPGHP, bool JHEJOEBEECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x32F4840", Offset = "0x32F3840", VA = "0x1832F4840")]
	private static void CNDNDCOAAKN(StringBuilder GMAIOOGEDKD, string ELJKHCONNJB, bool KKCINIKPKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class EIDLEAEELOH<TKey> : global::NBDGDNKBMDJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct GACOGHJPFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public KDPIOPOPFAF keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static global::EIDLEAEELOH<TKey> CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int PNGHFNLMDDE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly string[] LGHDKPLEMOD;

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x335ABC0", Offset = "0x3359BC0", VA = "0x18335ABC0")]
	private EIDLEAEELOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3359CA0", Offset = "0x3358CA0", VA = "0x183359CA0", Slot = "5")]
	protected override string PBHAMANHMDD(global::JKOIANHLHOA<TKey> BCAFPIOPGIA, KDPIOPOPFAF HFPPJMFPGHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3359BC0", Offset = "0x3358BC0", VA = "0x183359BC0")]
	[CompilerGenerated]
	internal static string KOOHBCPJPAC(string NNCKAHEEGDH, TKey GGLJFLNJABJ, ref GACOGHJPFNB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class CBFMABKFBPJ<TKey> : global::NBDGDNKBMDJ<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class KCOGEPDGCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public KDPIOPOPFAF keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public KCOGEPDGCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x26E32E0", Offset = "0x26E22E0", VA = "0x1826E32E0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x287C750", Offset = "0x287B750", VA = "0x18287C750", Slot = "5")]
	protected override string PBHAMANHMDD(global::JKOIANHLHOA<TKey> BCAFPIOPGIA, KDPIOPOPFAF HFPPJMFPGHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x217E000", Offset = "0x217D000", VA = "0x18217E000")]
	public CBFMABKFBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class KIHLDHCDMEA : global::JKOIANHLHOA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class ACOPDNJBLHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Action<KIHLDHCDMEA> callback;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ACOPDNJBLHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x5765D80", Offset = "0x5764D80", VA = "0x185765D80")]
		internal void <Wrap>b__0(global::JKOIANHLHOA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x576AEB0", Offset = "0x5769EB0", VA = "0x18576AEB0")]
	public KIHLDHCDMEA([Optional] string ABDGHCLPBBC, [Optional] int? OMBFOFGHFDP, [Optional] Stopwatch AEHDKKNNPGD, [Optional] Action<string, PNDIPJAIIED> KKFNICNKMGJ, [Optional] Action<string, PNDIPJAIIED> NIAMLMJLENK, [Optional] Action<KIHLDHCDMEA> EPPEBKCHIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x576ADF0", Offset = "0x5769DF0", VA = "0x18576ADF0")]
	private static Action<global::JKOIANHLHOA<string>> ILKKPAGLGFN(Action<KIHLDHCDMEA> PCMFICPIFCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public abstract class GDBIMAICHEG
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private class LGJPJFOOKMF : GDBIMAICHEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static GDBIMAICHEG CEPBJDBANMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x576B070", Offset = "0x576A070", VA = "0x18576B070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override DateTime DOAHJAHNIGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x576B0D0", Offset = "0x576A0D0", VA = "0x18576B0D0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override float FIFGGGOKCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x576B120", Offset = "0x576A120", VA = "0x18576B120", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x576B1D0", Offset = "0x576A1D0", VA = "0x18576B1D0")]
		public LGJPJFOOKMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static GDBIMAICHEG MELHLAHKMMD;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public static GDBIMAICHEG CDLKEADKJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5768460", Offset = "0x5767460", VA = "0x185768460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public abstract DateTime DOAHJAHNIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public abstract float FIFGGGOKCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected GDBIMAICHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KFOEOCBOOBN : global::PLMNIHDMPKE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x576AC70", Offset = "0x5769C70", VA = "0x18576AC70")]
	public KFOEOCBOOBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class PLMNIHDMPKE<T> : global::DJDAPCKEGEO<T>, AJGDDJDNKLH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task<T> LGLAAFDBFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Task LIKBCANCIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3CA0", Offset = "0x1CB2CA0", VA = "0x181CB3CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public global::LBHHDEJJNHM<T> INMJNJGGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private HIOJNGOAMAG DNAJPDLIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7F90", Offset = "0x1CB6F90", VA = "0x181CB7F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x30C93B0", Offset = "0x30C83B0", VA = "0x1830C93B0")]
	public PLMNIHDMPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class JFCGGNKCMMG : global::GFCPKDJAIOL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x576A560", Offset = "0x5769560", VA = "0x18576A560")]
	public JFCGGNKCMMG(Exception MKAEFGDNMHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GFCPKDJAIOL<T> : global::DJDAPCKEGEO<T>, AJGDDJDNKLH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Task<T> LGLAAFDBFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Task LIKBCANCIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3CA0", Offset = "0x1CB2CA0", VA = "0x181CB3CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public global::LBHHDEJJNHM<T> INMJNJGGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private HIOJNGOAMAG DNAJPDLIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7F90", Offset = "0x1CB6F90", VA = "0x181CB7F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4041DF0", Offset = "0x4040DF0", VA = "0x184041DF0")]
	public GFCPKDJAIOL(Exception MKAEFGDNMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface AJGDDJDNKLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	[NotNull]
	Task LGLAAFDBFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	[NotNull]
	HIOJNGOAMAG INMJNJGGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface DJDAPCKEGEO<T> : AJGDDJDNKLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	[NotNull]
	new Task<T> LGLAAFDBFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	new global::LBHHDEJJNHM<T> INMJNJGGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class JEKBPDCAPJD<TTask, T> : global::DJDAPCKEGEO<T>, AJGDDJDNKLH, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class DIBCOJPJGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public global::JEKBPDCAPJD<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public DIBCOJPJGNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static bool CBPIDIPOOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly Task<T> DOGDKDCOCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected readonly CancellationTokenSource LBBCAKAHNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool JBNHMJHHOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private SynchronizationContext DBMOICGEJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Task<T> LGLAAFDBFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private Task LIKBCANCIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public global::LBHHDEJJNHM<T> INMJNJGGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private HIOJNGOAMAG DNAJPDLIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x200DC00", Offset = "0x200CC00", VA = "0x18200DC00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool AMNFGEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x666990", Offset = "0x665990", VA = "0x180666990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x334D6F0", Offset = "0x334C6F0", VA = "0x18334D6F0")]
	static JEKBPDCAPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x334DB80", Offset = "0x334CB80", VA = "0x18334DB80")]
	protected JEKBPDCAPJD(TTask DOGDKDCOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x334D5B0", Offset = "0x334C5B0", VA = "0x18334D5B0", Slot = "1")]
	~JEKBPDCAPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x334D530", Offset = "0x334C530", VA = "0x18334D530", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x334D3C0", Offset = "0x334C3C0", VA = "0x18334D3C0")]
	private void BPKDLHEEJPD(bool EGNBACAOKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T GLAOAGBPDOJ(TTask BOGAABAPBBH);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PLNCCFGNMCA();

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x334D560", Offset = "0x334C560", VA = "0x18334D560")]
	[CompilerGenerated]
	private void EBPIOIBCLNC(object CDAABFMDHFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface EPDNPFNIAMK
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	float IPFNAIGCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MDJDGEJJGLJ NAJMPEHFEGC;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class DPAOFPLLJNG : EPDNPFNIAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public readonly struct HDMLHAEGCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public readonly float DGHCKKHBFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly float AFLBIOIPBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		internal readonly bool NFKGIEPPODC;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public float GFEAMCLPGON
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x5769C80", Offset = "0x5768C80", VA = "0x185769C80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5769DF0", Offset = "0x5768DF0", VA = "0x185769DF0")]
		public HDMLHAEGCFD(float HNIIDPMJKFI, float MOCOMOOJDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x5769C90", Offset = "0x5768C90", VA = "0x185769C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class IMHCNPGJEBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public DPAOFPLLJNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IMHCNPGJEBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly int FANLILHFAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private int KHIKMEHOEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly EPDNPFNIAMK[] NGFHFEGCPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly MDJDGEJJGLJ[] BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly HDMLHAEGCFD[] KCGOOJKMMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private HDMLHAEGCFD MMGHBGJFCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly PBJPIDBLDLH KMBBJLKOCIJ;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HDMLHAEGCFD HEAOCFHJCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2882BD0", Offset = "0x2881BD0", VA = "0x182882BD0")]
		get
		{
			return default(HDMLHAEGCFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float IPFNAIGCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x57678B0", Offset = "0x57668B0", VA = "0x1857678B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MDJDGEJJGLJ NAJMPEHFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x57678D0", Offset = "0x57668D0", VA = "0x1857678D0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x5767410", Offset = "0x5766410", VA = "0x185767410", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5767A10", Offset = "0x5766A10", VA = "0x185767A10")]
	public DPAOFPLLJNG(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5767990", Offset = "0x5766990", VA = "0x185767990")]
	public PBJPIDBLDLH MOCDGFLIHMJ(HDMLHAEGCFD JGJMKJKGEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x57674D0", Offset = "0x57664D0", VA = "0x1857674D0")]
	public void HHOAAIMAFGG(EPDNPFNIAMK HFEOKFEDBMC, [Optional] HDMLHAEGCFD CAOLBOLANFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x57673C0", Offset = "0x57663C0", VA = "0x1857673C0")]
	internal int HDJBEKJPMMO(EPDNPFNIAMK NHCPLKBCCCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5767370", Offset = "0x5766370", VA = "0x185767370")]
	internal HDMLHAEGCFD EJPOKPMDGGH(int IIHEDPBOLFE)
	{
		return default(HDMLHAEGCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x57671E0", Offset = "0x57661E0", VA = "0x1857671E0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public delegate void MDJDGEJJGLJ(float IJLDALNLODE);
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class FBFIDDHOEKA
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	internal const float DGCINMAENMP = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class KHEHNHEGELA
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class CILKCCCIMOE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly EPDNPFNIAMK NHCPLKBCCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly MDJDGEJJGLJ PCMFICPIFCD;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x57660B0", Offset = "0x57650B0", VA = "0x1857660B0")]
		public CILKCCCIMOE(EPDNPFNIAMK NHCPLKBCCCD, MDJDGEJJGLJ PCMFICPIFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x5766060", Offset = "0x5765060", VA = "0x185766060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x576ACB0", Offset = "0x5769CB0", VA = "0x18576ACB0")]
	internal static bool EHIKNLADBDK(float KKHMNCLOHHK, float GMPKOOIGMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3660", Offset = "0x3BE2660", VA = "0x183BE3660")]
	internal static float JEEKCAAGKAI(float KKHMNCLOHHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x576AD30", Offset = "0x5769D30", VA = "0x18576AD30")]
	public static IDisposable OKLCEDBPGCB(this EPDNPFNIAMK NHCPLKBCCCD, MDJDGEJJGLJ PCMFICPIFCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class PBJPIDBLDLH : EPDNPFNIAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float IJLDALNLODE;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float IPFNAIGCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xF28CB0", Offset = "0xF27CB0", VA = "0x180F28CB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x576BAB0", Offset = "0x576AAB0", VA = "0x18576BAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MDJDGEJJGLJ NAJMPEHFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x576BA10", Offset = "0x576AA10", VA = "0x18576BA10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x576B970", Offset = "0x576A970", VA = "0x18576B970", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public PBJPIDBLDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class CJJJEPAKPLO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public readonly Type LPONFACIGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public readonly string CKCDGJOGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly bool JABFNEFMNJD;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x5766140", Offset = "0x5765140", VA = "0x185766140")]
	public CJJJEPAKPLO(Type FEPBMHAODEI, string JNJENABBIFL, bool IKGAECALELD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class OGFDNMJCJGI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x576B880", Offset = "0x576A880", VA = "0x18576B880")]
	public OGFDNMJCJGI(string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x576B8F0", Offset = "0x576A8F0", VA = "0x18576B8F0")]
	public OGFDNMJCJGI(string LPDLECBMBMG, Exception CPKECAHHDHM)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x5E5ED0", Offset = "0x5E4ED0", VA = "0x1805E5ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x609710", Offset = "0x608710", VA = "0x180609710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public T this[int BJNKEHJJEBP, int KPHNAPJNLAL]
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x30E2830", Offset = "0x30E1830", VA = "0x1830E2830")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x30E28D0", Offset = "0x30E18D0", VA = "0x1830E28D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x30E27A0", Offset = "0x30E17A0", VA = "0x1830E27A0")]
		public Array2D(uint GHGJDDLLLBP, uint EKAJBPONJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x30E2720", Offset = "0x30E1720", VA = "0x1830E2720")]
		public void MCOHOPDDOPF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5765EA0", Offset = "0x5764EA0", VA = "0x185765EA0")]
		public Array2DVector3(uint GHGJDDLLLBP, uint EKAJBPONJJD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class OPGIJNBNAKD
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public const int MKJPPIKAAHH = -1;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public const int GBOPDKBNDBC = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[DefaultMember("Item")]
public class HIFNABHKLBE<THandle, TValue> : IDisposable where THandle : struct, GHELMGKGIIN where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly List<THandle> PHCNLGFIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly List<TValue> LEHLGJBPLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly Func<TValue> NICPDDNMDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Action<TValue> KEEJGLCMABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int GHFEOCHOCJF;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public TValue AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x23AFBC0", Offset = "0x23AEBC0", VA = "0x1823AFBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x23AFF10", Offset = "0x23AEF10", VA = "0x1823AFF10")]
	public HIFNABHKLBE(Action<TValue> KEEJGLCMABO, [Optional] Func<TValue> NICPDDNMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x23AF380", Offset = "0x23AE380", VA = "0x1823AF380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x23AF730", Offset = "0x23AE730", VA = "0x1823AF730")]
	public THandle FBMLCAAKPML()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x23AFEA0", Offset = "0x23AEEA0", VA = "0x1823AFEA0")]
	public THandle PPCBFHPPBHE(TValue JNLOLNFALGF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x23AF2D0", Offset = "0x23AE2D0", VA = "0x1823AF2D0")]
	public bool DKCILJPFPEA(THandle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x23AF9C0", Offset = "0x23AE9C0", VA = "0x1823AF9C0")]
	public bool IOLIAPLKMKF(THandle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x23AF400", Offset = "0x23AE400", VA = "0x1823AF400")]
	public bool EAMIBAOAOOK(THandle BFJMCAAKMNM, out TValue JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x23AF7D0", Offset = "0x23AE7D0", VA = "0x1823AF7D0")]
	public TValue FGPHONIFMEK(THandle BFJMCAAKMNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x23AF4A0", Offset = "0x23AE4A0", VA = "0x1823AF4A0")]
	public bool EFMFIFBCNEK(THandle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x23AF2A0", Offset = "0x23AE2A0", VA = "0x1823AF2A0")]
	private THandle DBKLBMPLHNA(int IIHEDPBOLFE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x23AFBF0", Offset = "0x23AEBF0", VA = "0x1823AFBF0")]
	private TValue KDDIPPKHHEK(int IIHEDPBOLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x23AF820", Offset = "0x23AE820", VA = "0x1823AF820")]
	private void GCHEGOIAJPA(int IIHEDPBOLFE, in THandle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x23AF920", Offset = "0x23AE920", VA = "0x1823AF920")]
	private void HBHHAINOFBE(int IIHEDPBOLFE, in TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x23AFD90", Offset = "0x23AED90", VA = "0x1823AFD90")]
	private THandle PGDLGGKIJDP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x23AF860", Offset = "0x23AE860", VA = "0x1823AF860")]
	private void GHFGPOICKBH(THandle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x23AFCF0", Offset = "0x23AECF0", VA = "0x1823AFCF0")]
	private int OJONDLDOBGB(int GDLEDDNCPGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x23AFD80", Offset = "0x23AED80", VA = "0x1823AFD80")]
	private bool PCJGDGDKNNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6369A0", Offset = "0x6359A0", VA = "0x1806369A0")]
	private void COGBPGHFLOO(THandle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x23AFD00", Offset = "0x23AED00", VA = "0x1823AFD00")]
	private bool PCIGBIDBGFI(out THandle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x23AFC20", Offset = "0x23AEC20", VA = "0x1823AFC20")]
	private bool NCBHOJIIENB(out THandle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x23AF960", Offset = "0x23AE960", VA = "0x1823AF960")]
	private void HMABLFBMAMK(THandle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x23AFAA0", Offset = "0x23AEAA0", VA = "0x1823AFAA0")]
	private void JHMABBCPBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface GHELMGKGIIN
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int KBBNJEDOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface CKDCIHLAPNJ<T> : GHELMGKGIIN, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class PMOMNKHAKHE
{
	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xD6B5F0", Offset = "0xD6A5F0", VA = "0x180D6B5F0")]
	public static bool JGJEAGFIGEE<T>(this T BFJMCAAKMNM, T IJDAJAEAAKC) where T : struct, GHELMGKGIIN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	public static bool NFKGIEPPODC<T>(this T BFJMCAAKMNM) where T : struct, GHELMGKGIIN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x576BB80", Offset = "0x576AB80", VA = "0x18576BB80")]
	public static string DPGPPFMKEPK(this GHELMGKGIIN BFJMCAAKMNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class HDCGPEAOMFN
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private enum KJHFCNBACPP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private int KOPCAMHLCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool EPCFHGFNABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private KJHFCNBACPP LKOJKOJNBBK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FKGGGNACLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x57699E0", Offset = "0x57689E0", VA = "0x1857699E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool AGLKDJCPHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5769AC0", Offset = "0x5768AC0", VA = "0x185769AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5769C50", Offset = "0x5768C50", VA = "0x185769C50")]
	public HDCGPEAOMFN(bool EPCFHGFNABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x5769020", Offset = "0x5768020", VA = "0x185769020")]
	public void ICEGOAPGMDM(object MDAEAKFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5768E70", Offset = "0x5767E70", VA = "0x185768E70")]
	public void CEPFJFOKJCA(int JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x57699F0", Offset = "0x57689F0", VA = "0x1857699F0")]
	public void LICPCKLDEPF(uint JECBAIFFLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5769BF0", Offset = "0x5768BF0", VA = "0x185769BF0")]
	public void PMLKHMODABN(bool ECDLNBJDNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5769C10", Offset = "0x5768C10", VA = "0x185769C10")]
	public void PNJEFDFNMGI(long MBIPCINKBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5769A10", Offset = "0x5768A10", VA = "0x185769A10")]
	public void MDIKJEJCBFG(ulong IJDJHFCMGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5769900", Offset = "0x5768900", VA = "0x185769900")]
	public void IIJDCCGKAKF(string KHODCOPPDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5768F90", Offset = "0x5767F90", VA = "0x185768F90")]
	public void FFOKHDKFAND(Enum MKAEFGDNMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5769AD0", Offset = "0x5768AD0", VA = "0x185769AD0")]
	public void ONGKCLHJFFD(IList DMCFFMAPNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x34745B0", Offset = "0x34735B0", VA = "0x1834745B0")]
	public void HLCOLHOCENE<T, U>(Dictionary<T, U> DHPLJKHDDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5769540", Offset = "0x5768540", VA = "0x185769540")]
	private void IIDAAFHFDKB(IDictionary DHPLJKHDDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5769A50", Offset = "0x5768A50", VA = "0x185769A50")]
	public int MLOFFDHGGHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5768F20", Offset = "0x5767F20", VA = "0x185768F20")]
	public short CNMNCFKJPJN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5769A00", Offset = "0x5768A00", VA = "0x185769A00")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5769970", Offset = "0x5768970", VA = "0x185769970")]
	private void LAFMHJFFNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public abstract class LJJGEOGHKOB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class HKPBOMBNAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public TNode AMPFEINIDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public TNode ACNNFDIAAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public DONNJFFBANH GPBPHMJHPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public List<DONNJFFBANH> BGLBHBEJCAF;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public HKPBOMBNAFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal struct DONNJFFBANH : IComparable<DONNJFFBANH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int BPPJKBJLNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TClaimant OOBMHPOPJGF;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCF0", Offset = "0x5ECCF0", VA = "0x1805EDCF0")]
		public DONNJFFBANH(int BPPJKBJLNPG, TClaimant OOBMHPOPJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A075D0", Offset = "0x3A065D0", VA = "0x183A075D0")]
		public bool DMNBGIMAIKF(in DONNJFFBANH IJDAJAEAAKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A07630", Offset = "0x3A06630", VA = "0x183A07630")]
		public bool KIEIEFKIDBN(in DONNJFFBANH IJDAJAEAAKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A075C0", Offset = "0x3A065C0", VA = "0x183A075C0", Slot = "4")]
		public int CompareTo(DONNJFFBANH IJDAJAEAAKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A07640", Offset = "0x3A06640", VA = "0x183A07640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public enum KKBKGAKKODM
	{
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class IALDBGOGMIM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public global::LJJGEOGHKOB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2002D60", Offset = "0x2001D60", VA = "0x182002D60")]
		[DebuggerHidden]
		public IALDBGOGMIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A0ADE0", Offset = "0x3A09DE0", VA = "0x183A0ADE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AFA0", Offset = "0x3A09FA0", VA = "0x183A0AFA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AEC0", Offset = "0x3A09EC0", VA = "0x183A0AEC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4AA0", Offset = "0x1CC3AA0", VA = "0x181CC4AA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly global::JPFNIGCHAOP<HKPBOMBNAFE> IHOCOAPHNCN;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly global::JPFNIGCHAOP<List<DONNJFFBANH>> NBNHAEBCBFD;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static int DNJKKHNGGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	internal readonly Dictionary<TClaimant, TNode> LPCDOLOAAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	internal readonly Dictionary<TNode, HKPBOMBNAFE> IONOBBAAJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private KKBKGAKKODM DJPEOPIHMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AMDMBCDOPIK(TNode NNENOHEDIAL);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void PBJFFFEIHOG(TNode NNENOHEDIAL, TClaimant NIHENKGGOPL, TClaimant GMKJLFAMEFD);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A17520", Offset = "0x3A16520", VA = "0x183A17520")]
	public LJJGEOGHKOB(KKBKGAKKODM DJPEOPIHMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A17060", Offset = "0x3A16060", VA = "0x183A17060")]
	public void LKHAMLLMDEK(TNode NNENOHEDIAL, TNode LGIBIGENFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A16E60", Offset = "0x3A15E60", VA = "0x183A16E60")]
	public void KBCHFLMNEMN(TClaimant OOBMHPOPJGF, TNode HGFOAINOJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A16260", Offset = "0x3A15260", VA = "0x183A16260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A161C0", Offset = "0x3A151C0", VA = "0x183A161C0")]
	private void DOGDIKJBDGE(TClaimant OOBMHPOPJGF, TNode PDFPHFLPILJ, TNode HGFOAINOJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A17350", Offset = "0x3A16350", VA = "0x183A17350")]
	private int PHHAHCHLGAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A16590", Offset = "0x3A15590", VA = "0x183A16590")]
	private void EJEHCHABPCA(TClaimant OOBMHPOPJGF, TNode CDKHGPFEALO, TNode IIJHPNIJLGN, int DAIFKBHCKCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A16A00", Offset = "0x3A15A00", VA = "0x183A16A00")]
	private void HBLACPNDHAN(DONNJFFBANH DDHALJOGCOH, HKPBOMBNAFE BDDLEMDEBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A170E0", Offset = "0x3A160E0", VA = "0x183A170E0")]
	private void ODPGNPIKBAE(TClaimant OOBMHPOPJGF, TNode CDKHGPFEALO, TNode IIJHPNIJLGN, int DAIFKBHCKCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A16D60", Offset = "0x3A15D60", VA = "0x183A16D60")]
	private void JMDCFPHDDKN(DONNJFFBANH DDHALJOGCOH, TNode NNENOHEDIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A16F60", Offset = "0x3A15F60", VA = "0x183A16F60")]
	private void KDHNKJFHEDN(DONNJFFBANH DDHALJOGCOH, HKPBOMBNAFE BDDLEMDEBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A16A90", Offset = "0x3A15A90", VA = "0x183A16A90")]
	private void JAHHPLNLIIP(HKPBOMBNAFE BDDLEMDEBOA, bool CJLAICCECFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A15CC0", Offset = "0x3A14CC0", VA = "0x183A15CC0")]
	private void DFDJGDCEILL(HKPBOMBNAFE BDDLEMDEBOA, TNode LGIBIGENFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A164C0", Offset = "0x3A154C0", VA = "0x183A164C0")]
	[IteratorStateMachine(typeof(global::LJJGEOGHKOB<, >.IALDBGOGMIM))]
	private IEnumerable<TNode> EIEAODOKCBC(TNode CDKHGPFEALO, TNode IIJHPNIJLGN, bool HBNNHKPIAEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A16100", Offset = "0x3A15100", VA = "0x183A16100")]
	private HKPBOMBNAFE DMJLHEAHBIJ(TNode NNENOHEDIAL, TNode ACNNFDIAAFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A16BD0", Offset = "0x3A15BD0", VA = "0x183A16BD0")]
	private HKPBOMBNAFE JGNGMAPBLLF(TNode NNENOHEDIAL, TNode ACNNFDIAAFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A16840", Offset = "0x3A15840", VA = "0x183A16840")]
	private void FHPAGPCCFML(HKPBOMBNAFE BDDLEMDEBOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class BBDBCFOGFKL<T> : IEnumerable<global::BBDBCFOGFKL<T>.APGHLMDCGLH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct APGHLMDCGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T JNLOLNFALGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int IIHEDPBOLFE;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class JNHBOLMANCG : IEnumerator<APGHLMDCGLH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private global::BBDBCFOGFKL<T> KINLBAPNNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int IIHEDPBOLFE;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x24DA790", Offset = "0x24D9790", VA = "0x1824DA790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public APGHLMDCGLH EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x24DA810", Offset = "0x24D9810", VA = "0x1824DA810", Slot = "4")]
			get
			{
				return default(APGHLMDCGLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x913330", Offset = "0x912330", VA = "0x180913330")]
		public JNHBOLMANCG(global::BBDBCFOGFKL<T> KINLBAPNNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x24DA600", Offset = "0x24D9600", VA = "0x1824DA600", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x876780", Offset = "0x875780", VA = "0x180876780", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AB280", Offset = "0x8AA280", VA = "0x1808AB280", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct CHGCPIANLOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool ABEDLPKJBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public T JNLOLNFALGF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private const int GCKFDHOHPPL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Dictionary<T, int> KPHHNFPLBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private CHGCPIANLOP[] KFFHNKAHALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private int BGBGAEKKJDB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int FPNDMOOCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CC0", Offset = "0x5E4CC0", VA = "0x1805E5CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7401B0", Offset = "0x73F1B0", VA = "0x1807401B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2178F70", Offset = "0x2177F70", VA = "0x182178F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x24C99A0", Offset = "0x24C89A0", VA = "0x1824C99A0")]
	public BBDBCFOGFKL(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x24C9A80", Offset = "0x24C8A80", VA = "0x1824C9A80")]
	public BBDBCFOGFKL(APGHLMDCGLH[] NPEEAAKFCBB, bool LJGABHFPLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x24C84B0", Offset = "0x24C74B0", VA = "0x1824C84B0")]
	public int CPMCGNAOBBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x24C8250", Offset = "0x24C7250", VA = "0x1824C8250")]
	private int CLKNGDPOAPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x24C9470", Offset = "0x24C8470", VA = "0x1824C9470", Slot = "6")]
	protected virtual uint NCDNNOEBBDE(uint KOPCAMHLCEK, T JNLOLNFALGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x24C8A90", Offset = "0x24C7A90", VA = "0x1824C8A90")]
	public bool HPPOGCFLDKI(T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x24C8AD0", Offset = "0x24C7AD0", VA = "0x1824C8AD0")]
	public bool IMGGHOHMGGC(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x24C88E0", Offset = "0x24C78E0", VA = "0x1824C88E0")]
	public bool FAFGFNINKJO(Func<T, bool> OFFJFENHOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x24C7FA0", Offset = "0x24C6FA0", VA = "0x1824C7FA0")]
	public int BABCFGOCPDG(T JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x24C9280", Offset = "0x24C8280", VA = "0x1824C9280")]
	public T KDDIPPKHHEK(int IIHEDPBOLFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x24C93C0", Offset = "0x24C83C0", VA = "0x1824C93C0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x24C8E20", Offset = "0x24C7E20", VA = "0x1824C8E20")]
	public bool IOLPAJPCMFB(T JNLOLNFALGF, bool BLHJADHEBAH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x24C8E60", Offset = "0x24C7E60", VA = "0x1824C8E60")]
	public bool IOLPAJPCMFB(T JNLOLNFALGF, int IIHEDPBOLFE, bool BLHJADHEBAH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x24C85A0", Offset = "0x24C75A0", VA = "0x1824C85A0")]
	public bool DKCILJPFPEA(T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x24C9370", Offset = "0x24C8370", VA = "0x1824C9370")]
	public bool LPJGPILEEAO(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x24C9190", Offset = "0x24C8190", VA = "0x1824C9190")]
	private void JFANMJHECHO(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x24C87A0", Offset = "0x24C77A0", VA = "0x1824C87A0")]
	public APGHLMDCGLH[] EMJOBPCJJFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x24C94E0", Offset = "0x24C84E0", VA = "0x1824C94E0")]
	private int ONBCPOHJEGN(int KMEFLFMPMFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x24C9530", Offset = "0x24C8530", VA = "0x1824C9530", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x24C9530", Offset = "0x24C8530", VA = "0x1824C9530", Slot = "4")]
	private IEnumerator<APGHLMDCGLH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct MKBDLFOMOKH<Handle> where Handle : GHELMGKGIIN, new()
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private struct OOJIHNBAPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly global::MKBDLFOMOKH<Handle> ICELNJAGJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int IIHEDPBOLFE;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public int FHFDLDNIOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3722D20", Offset = "0x3721D20", VA = "0x183722D20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Handle AHMEEFPPIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x3722100", Offset = "0x3721100", VA = "0x183722100")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3722E00", Offset = "0x3721E00", VA = "0x183722E00")]
		public OOJIHNBAPEM(global::MKBDLFOMOKH<Handle> ICELNJAGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3722990", Offset = "0x3721990", VA = "0x183722990")]
		public IKKJPMHIDIM NEPKDIDOCIM(in IKKJPMHIDIM EDHFNBOOHPA)
		{
			return default(IKKJPMHIDIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x37228E0", Offset = "0x37218E0", VA = "0x1837228E0")]
		public AMPAEFMIOPK NEPKDIDOCIM(in AMPAEFMIOPK EDHFNBOOHPA)
		{
			return default(AMPAEFMIOPK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3722800", Offset = "0x3721800", VA = "0x183722800")]
		public bool IGPOAKPBHOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3722A40", Offset = "0x3721A40", VA = "0x183722A40")]
		private int NFBHLNJEPMN(string LPDLECBMBMG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x37225E0", Offset = "0x37215E0", VA = "0x1837225E0")]
		private Handle FFECIDLCJCJ(string LPDLECBMBMG)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct IKKJPMHIDIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private OOJIHNBAPEM EPPIODBIOPO;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public int EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x3711BB0", Offset = "0x3710BB0", VA = "0x183711BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x370EC60", Offset = "0x370DC60", VA = "0x18370EC60")]
		public IKKJPMHIDIM(global::MKBDLFOMOKH<Handle> ICELNJAGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x370EBE0", Offset = "0x370DBE0", VA = "0x18370EBE0")]
		public bool IGPOAKPBHOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3711A90", Offset = "0x3710A90", VA = "0x183711A90")]
		public IKKJPMHIDIM GMHPDHEDPBP()
		{
			return default(IKKJPMHIDIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public struct AMPAEFMIOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private OOJIHNBAPEM EPPIODBIOPO;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Handle EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x370EB20", Offset = "0x370DB20", VA = "0x18370EB20")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x370EC60", Offset = "0x370DC60", VA = "0x18370EC60")]
		public AMPAEFMIOPK(global::MKBDLFOMOKH<Handle> ICELNJAGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x370EBE0", Offset = "0x370DBE0", VA = "0x18370EBE0")]
		public bool IGPOAKPBHOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x370EA00", Offset = "0x370DA00", VA = "0x18370EA00")]
		public AMPAEFMIOPK GMHPDHEDPBP()
		{
			return default(AMPAEFMIOPK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeList<int> JDEFBEOAMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeList<int> GBFIINEPGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int BNGEBMPDAHO;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool LNHKEACDENA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x371D5D0", Offset = "0x371C5D0", VA = "0x18371D5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int OHMIEBEANAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x371B970", Offset = "0x371A970", VA = "0x18371B970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int LGKLPKHOHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD0", Offset = "0x5E4CD0", VA = "0x1805E5CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int JLGJMHEHBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD0", Offset = "0x5E4CD0", VA = "0x1805E5CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IKKJPMHIDIM CIACDOGEKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x371D8A0", Offset = "0x371C8A0", VA = "0x18371D8A0")]
		get
		{
			return default(IKKJPMHIDIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public AMPAEFMIOPK PDOLJAIBGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x371B9B0", Offset = "0x371A9B0", VA = "0x18371B9B0")]
		get
		{
			return default(AMPAEFMIOPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x371D950", Offset = "0x371C950", VA = "0x18371D950")]
	public MKBDLFOMOKH(int OGCAGAMFCKH, Allocator LKNIKCJFBFH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x371AD20", Offset = "0x3719D20", VA = "0x18371AD20")]
	public void BPKDLHEEJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xE68770", Offset = "0xE67770", VA = "0x180E68770")]
	public static int OJONDLDOBGB(int PHCLDIDKELI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x371B0F0", Offset = "0x371A0F0", VA = "0x18371B0F0")]
	public static bool EGKJKLMFHBH(int PHCLDIDKELI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x371ADE0", Offset = "0x3719DE0", VA = "0x18371ADE0")]
	public static bool COPKCMAKGOJ(int PHCLDIDKELI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x371AFF0", Offset = "0x3719FF0", VA = "0x18371AFF0")]
	public bool DLHNODGOELF(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x371B470", Offset = "0x371A470", VA = "0x18371B470")]
	public bool GCLPIGLHHKN(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x371B270", Offset = "0x371A270", VA = "0x18371B270")]
	public bool EOCMEDFLFAM(Handle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x371BF90", Offset = "0x371AF90", VA = "0x18371BF90")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void KKPKOMFBECA(Handle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x371C960", Offset = "0x371B960", VA = "0x18371C960")]
	public Handle LNGMIKCIELN()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x371D290", Offset = "0x371C290", VA = "0x18371D290")]
	public void MMBDHCPCDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x371D690", Offset = "0x371C690", VA = "0x18371D690")]
	public void OIJIGKKDAEF(Handle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x371CAB0", Offset = "0x371BAB0", VA = "0x18371CAB0")]
	public bool MJCHCIEPMKM(Handle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x371D7E0", Offset = "0x371C7E0", VA = "0x18371D7E0")]
	private bool PGBEMDMHPAE(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x371A7B0", Offset = "0x37197B0", VA = "0x18371A7B0")]
	private void AOJJHCMEFDF(out int IIHEDPBOLFE, out int GDLEDDNCPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x371C5B0", Offset = "0x371B5B0", VA = "0x18371C5B0")]
	private void LIGGLAGOPFN(Handle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x371BC90", Offset = "0x371AC90", VA = "0x18371BC90")]
	private void JODGDCLGHEE(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x371BBA0", Offset = "0x371ABA0", VA = "0x18371BBA0")]
	private bool IPHLIKKMKCF(out int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x371B770", Offset = "0x371A770", VA = "0x18371B770")]
	private static Handle GMHEDPJIHGK(int IIHEDPBOLFE, int GDLEDDNCPGJ)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
public struct DAMIDBMLOOO<Handle, T> where Handle : GHELMGKGIIN, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private global::MKBDLFOMOKH<Handle> MGCDJMADBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private T[] LOHBFPOMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private Action<T> DCFNICACCDO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool LNHKEACDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x21773C0", Offset = "0x21763C0", VA = "0x1821773C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public int OHMIEBEANAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2176F30", Offset = "0x2175F30", VA = "0x182176F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2177FC0", Offset = "0x2176FC0", VA = "0x182177FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2177000", Offset = "0x2176000", VA = "0x182177000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2178320", Offset = "0x2177320", VA = "0x182178320")]
	public DAMIDBMLOOO(int OGCAGAMFCKH, [Optional] Action<T> DCFNICACCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2175B20", Offset = "0x2174B20", VA = "0x182175B20")]
	public void BPKDLHEEJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2176A30", Offset = "0x2175A30", VA = "0x182176A30")]
	public bool EOCMEDFLFAM(Handle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void KKPKOMFBECA(Handle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2176B50", Offset = "0x2175B50", VA = "0x182176B50")]
	public T FGPHONIFMEK(Handle BFJMCAAKMNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x21767A0", Offset = "0x21757A0", VA = "0x1821767A0")]
	public bool EAMIBAOAOOK(Handle BFJMCAAKMNM, out T MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2176D80", Offset = "0x2175D80", VA = "0x182176D80")]
	public void GALDMPBHILF(Handle BFJMCAAKMNM, T MNLKBDKJLPK, out T HAALCPHGONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2176B90", Offset = "0x2175B90", VA = "0x182176B90")]
	public void GALDMPBHILF(Handle BFJMCAAKMNM, T MNLKBDKJLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2177850", Offset = "0x2176850", VA = "0x182177850")]
	public bool NNIKEFIHNGD(Handle BFJMCAAKMNM, T MNLKBDKJLPK, out T HAALCPHGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2177770", Offset = "0x2176770", VA = "0x182177770")]
	public bool NNIKEFIHNGD(Handle BFJMCAAKMNM, T MNLKBDKJLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2177FF0", Offset = "0x2176FF0", VA = "0x182177FF0")]
	public Handle PPCBFHPPBHE(T MDAEAKFNGDG)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2175E00", Offset = "0x2174E00", VA = "0x182175E00")]
	public void CKHKLOGCFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x21765F0", Offset = "0x21755F0", VA = "0x1821765F0")]
	public void DKCILJPFPEA(Handle BFJMCAAKMNM, out T HAALCPHGONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2176520", Offset = "0x2175520", VA = "0x182176520")]
	public void DKCILJPFPEA(Handle BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2177ED0", Offset = "0x2176ED0", VA = "0x182177ED0")]
	public bool OINFJFLNDFD(Handle BFJMCAAKMNM, out T HAALCPHGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2177A20", Offset = "0x2176A20", VA = "0x182177A20")]
	public bool OINFJFLNDFD(Handle BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2177360", Offset = "0x2176360", VA = "0x182177360")]
	private T LPJGPILEEAO(int IIHEDPBOLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2177260", Offset = "0x2176260", VA = "0x182177260")]
	private void LLEKFFHMMIL(int KGFMGFMCGGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class JPFNIGCHAOP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly Stack<T> ICELNJAGJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<T> KDJFOOFICPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly int DJEPLMPPHHP;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int BDMFDCOBHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x27C19D0", Offset = "0x27C09D0", VA = "0x1827C19D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int OKPCAPAJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x30E5A10", Offset = "0x30E4A10", VA = "0x1830E5A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x32EF170", Offset = "0x32EE170", VA = "0x1832EF170")]
	public static global::JPFNIGCHAOP<T> PPNDNJELHPA(int FANLILHFAFO = 0, int DJEPLMPPHHP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x32EE9B0", Offset = "0x32ED9B0", VA = "0x1832EE9B0")]
	public static global::JPFNIGCHAOP<T> BPICHBMMPAI(int FANLILHFAFO = 0, int DJEPLMPPHHP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x32EF240", Offset = "0x32EE240", VA = "0x1832EF240")]
	public JPFNIGCHAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x32EF280", Offset = "0x32EE280", VA = "0x1832EF280")]
	public JPFNIGCHAOP(int FANLILHFAFO, int DJEPLMPPHHP = int.MaxValue, bool EHKIJHMLIHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x32EEDC0", Offset = "0x32EDDC0", VA = "0x1832EEDC0")]
	public T LNDGEOIPPEP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x32EEEF0", Offset = "0x32EDEF0", VA = "0x1832EEEF0")]
	public void LNFINCFCIJH(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x32EED00", Offset = "0x32EDD00", VA = "0x1832EED00")]
	private void JEDJDJBFKPF(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x32EECE0", Offset = "0x32EDCE0", VA = "0x1832EECE0")]
	private void FJBAJGGJCGI(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x32EEA80", Offset = "0x32EDA80", VA = "0x1832EEA80")]
	[Conditional("DEBUG_BUILD")]
	private void DJEMPOFAEPM(T AAJEDNDIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x32EEC30", Offset = "0x32EDC30", VA = "0x1832EEC30")]
	[Conditional("DEBUG_BUILD")]
	private void EKPKPNEABJO(T AAJEDNDIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x32EEB20", Offset = "0x32EDB20", VA = "0x1832EEB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x32EEFB0", Offset = "0x32EDFB0", VA = "0x1832EEFB0")]
	private void MINDHKNMGEB(IEnumerable<T> LEHLGJBPLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class KCAIIDHPEPN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private Dictionary<int, T> EHBCGGPPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private T OFKPCLGGMDH;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public virtual T BDAIGBEKEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MDGCPDOHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x32F3E00", Offset = "0x32F2E00", VA = "0x1832F3E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x32F3640", Offset = "0x32F2640", VA = "0x1832F3640")]
	public bool BINADFEEINP(T JNLOLNFALGF, int BPPJKBJLNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x32F36D0", Offset = "0x32F26D0", VA = "0x1832F36D0")]
	public bool EBFGJLCCCPL(int BPPJKBJLNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x32F3930", Offset = "0x32F2930", VA = "0x1832F3930")]
	public T MHGIAJELGPJ(int LILCGJBFDNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x32F38D0", Offset = "0x32F28D0", VA = "0x1832F38D0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x32F3730", Offset = "0x32F2730", VA = "0x1832F3730")]
	private bool LGHGNNAFNNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x32F36A0", Offset = "0x32F26A0", VA = "0x1832F36A0")]
	public bool DCDCMBICKAB(int BPPJKBJLNPG, out T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x32F3E40", Offset = "0x32F2E40", VA = "0x1832F3E40")]
	public KCAIIDHPEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class NHIBAONMCFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	protected struct JDAOAPGHDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public T GFNFCEIHNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int MALJDGBLCBA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	protected readonly List<JDAOAPGHDPB> GNHIHFHAGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T IAGIECCCNJP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2178F70", Offset = "0x2177F70", VA = "0x182178F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x26EEA40", Offset = "0x26EDA40", VA = "0x1826EEA40")]
	public bool FAFGFNINKJO(T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x26EED60", Offset = "0x26EDD60", VA = "0x1826EED60")]
	public void PPCBFHPPBHE(T JNLOLNFALGF, int BPPJKBJLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x26EE680", Offset = "0x26ED680", VA = "0x1826EE680")]
	public bool DKCILJPFPEA(T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x26EED00", Offset = "0x26EDD00", VA = "0x1826EED00")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x26EE9B0", Offset = "0x26ED9B0", VA = "0x1826EE9B0")]
	public T EJKPGALJDJF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x26EEC90", Offset = "0x26EDC90", VA = "0x1826EEC90")]
	public T HHFJDJBKAFI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x26EE7A0", Offset = "0x26ED7A0", VA = "0x1826EE7A0")]
	private void EDBPMFKHBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x26EEE00", Offset = "0x26EDE00", VA = "0x1826EEE00")]
	public NHIBAONMCFN()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		[DMMPNBPEKOM(AACKNMMIFMG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x576BE50", Offset = "0x576AE50", VA = "0x18576BE50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x576C320", Offset = "0x576B320", VA = "0x18576C320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x576C140", Offset = "0x576B140", VA = "0x18576C140")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x576C4C0", Offset = "0x576B4C0", VA = "0x18576C4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x576BD10", Offset = "0x576AD10", VA = "0x18576BD10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x576C1E0", Offset = "0x576B1E0", VA = "0x18576C1E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x576C000", Offset = "0x576B000", VA = "0x18576C000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x576BC70", Offset = "0x576AC70", VA = "0x18576BC70")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public interface EOAEGANCEDM
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public abstract class ResourcePrefabReference<T> : EOAEGANCEDM where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x30EE6F0", Offset = "0x30ED6F0", VA = "0x1830EE6F0", Slot = "4")]
		public virtual T EMOMMEDGKNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class CNBCAMKJKCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Dictionary<byte, HFJBNFHBNAH> IOELJACBPDN;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public HFJBNFHBNAH CFKNNGGJMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Vector2 JOCGLBNBJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x127FB70", Offset = "0x127EB70", VA = "0x18127FB70")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2F50", Offset = "0x2FC1F50", VA = "0x182FC2F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector2 JJBPPCKPIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1F2A7B0", Offset = "0x1F297B0", VA = "0x181F2A7B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x20D7E20", Offset = "0x20D6E20", VA = "0x1820D7E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector2 OIPDPNFKCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x57662B0", Offset = "0x57652B0", VA = "0x1857662B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5766460", Offset = "0x5765460", VA = "0x185766460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int NLFOJHBAKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6107E0", Offset = "0x60F7E0", VA = "0x1806107E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6369A0", Offset = "0x6359A0", VA = "0x1806369A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x57669A0", Offset = "0x57659A0", VA = "0x1857669A0")]
	public CNBCAMKJKCP(Bounds NKMEOFPBKEN, Vector2[] IGCAALPNOJA, int IKAEPHNKCHJ, byte KMEFLFMPMFC, float ADMBOJLKIBK = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5766400", Offset = "0x5765400", VA = "0x185766400")]
	public HFJBNFHBNAH JBKFJEGPDAF(byte IIHEDPBOLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x57661C0", Offset = "0x57651C0", VA = "0x1857661C0")]
	public void HHLDJGIHNFO(Vector3 IPACGOANALG, float NGLKPPOGAID, float MPOFGPAKGCF, ref List<byte> CKMIOACGDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x57661A0", Offset = "0x57651A0", VA = "0x1857661A0")]
	public void CABICDBIMOM(HFJBNFHBNAH.OBNNNPHPGHE LOFAOCAGHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x57662D0", Offset = "0x57652D0", VA = "0x1857662D0")]
	private HFJBNFHBNAH IBKAFNPBGFE(byte IIHEDPBOLFE, HFJBNFHBNAH.CFIADJBOALF JNJFMOFMNBP, HFJBNFHBNAH ACNNFDIAAFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5766480", Offset = "0x5765480", VA = "0x185766480")]
	private void ODIIGHOEBJH(HFJBNFHBNAH ACNNFDIAAFM, Vector2[] IGCAALPNOJA, int EHCEGGPJLEH, int PCGEPDOCGMM, int ELBKCJFGIAI, int BGIDMFPANGA, float ADMBOJLKIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class HFJBNFHBNAH
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public enum CFIADJBOALF
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public enum OBNNNPHPGHE
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public byte EEBBOAEJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector3 KAKNOAIFHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector3 GFEAMCLPGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector3 JICJIIKHEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector3 CFBOPBEKKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public CFIADJBOALF IPGLCODHIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public HFJBNFHBNAH COCJCFDPJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public List<HFJBNFHBNAH> DGNOBIKMAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public bool MFMMAGCJJKJ;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x576A350", Offset = "0x5769350", VA = "0x18576A350")]
	public HFJBNFHBNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x576A370", Offset = "0x5769370", VA = "0x18576A370")]
	public HFJBNFHBNAH(byte LGBAJKGIPMA, CFIADJBOALF JNJFMOFMNBP, HFJBNFHBNAH ACNNFDIAAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5769F80", Offset = "0x5768F80", VA = "0x185769F80")]
	public void BIMNJABIABE(HFJBNFHBNAH GPFGJIGIKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	public void CABICDBIMOM(int PGHMFKAFPIF, OBNNNPHPGHE LOFAOCAGHAH, int GKCIEIHMIAF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x576A020", Offset = "0x5769020", VA = "0x18576A020")]
	public void HHLDJGIHNFO(List<byte> CKMIOACGDIA, Vector3 IPACGOANALG, float NGLKPPOGAID, float MPOFGPAKGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x576A2B0", Offset = "0x57692B0", VA = "0x18576A2B0")]
	public bool IDBGKMJOCEG(Vector3 EAKNLHDPPEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x576A310", Offset = "0x5769310", VA = "0x18576A310")]
	public bool LOLMAHKHEME(Vector3 EAKNLHDPPEJ, float EDFCKHCMIJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class JDLEPEKKEEJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<T, object> OACHJPNLAOL;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x26E32E0", Offset = "0x26E22E0", VA = "0x1826E32E0")]
	public bool FBFPHJBBIGO(T HFEIECAPFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x334CF80", Offset = "0x334BF80", VA = "0x18334CF80")]
	public bool FBFPHJBBIGO(T HFEIECAPFNK, object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x334CFC0", Offset = "0x334BFC0", VA = "0x18334CFC0")]
	public bool FBFPHJBBIGO(T HFEIECAPFNK, object KGJPBGICHFN, out object LKOBDNJIGNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x334D020", Offset = "0x334C020", VA = "0x18334D020")]
	public bool FGIBOEJCBGI(T HFEIECAPFNK, object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x334D190", Offset = "0x334C190", VA = "0x18334D190")]
	public bool OPKLEIFJLJD(T HFEIECAPFNK, object KGJPBGICHFN, out object LKOBDNJIGNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x334D060", Offset = "0x334C060", VA = "0x18334D060")]
	public bool FGIBOEJCBGI(T HFEIECAPFNK, object KGJPBGICHFN, out object LKOBDNJIGNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x27C1F20", Offset = "0x27C0F20", VA = "0x1827C1F20")]
	public void MKABCOLIHEA(T HFEIECAPFNK, object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x334D0F0", Offset = "0x334C0F0", VA = "0x18334D0F0")]
	public void OFMJHJCNLHM(T HFEIECAPFNK, object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x334D1D0", Offset = "0x334C1D0", VA = "0x18334D1D0")]
	public JDLEPEKKEEJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public struct MFJKICNDIBH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private readonly List<Component> DMCFFMAPNPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private readonly bool NFGHPNCBHKM;

			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x825360", Offset = "0x824360", VA = "0x180825360")]
			public MFJKICNDIBH(List<Component> DMCFFMAPNPG, bool NFGHPNCBHKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x30EB420", Offset = "0x30EA420", VA = "0x1830EB420")]
			public BCADFDMNAOF<T> GMHPDHEDPBP()
			{
				return default(BCADFDMNAOF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x30EB490", Offset = "0x30EA490", VA = "0x1830EB490", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x30EB490", Offset = "0x30EA490", VA = "0x1830EB490", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		public struct BCADFDMNAOF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private readonly List<Component> DMCFFMAPNPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private readonly bool NFGHPNCBHKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int IIHEDPBOLFE;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			public T EINNBBEGEGD
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x30E2AB0", Offset = "0x30E1AB0", VA = "0x1830E2AB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x30E2A40", Offset = "0x30E1A40", VA = "0x1830E2A40", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x30E2A80", Offset = "0x30E1A80", VA = "0x1830E2A80")]
			public BCADFDMNAOF(List<Component> DMCFFMAPNPG, bool NFGHPNCBHKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x30E2970", Offset = "0x30E1970", VA = "0x1830E2970", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x30E2980", Offset = "0x30E1980", VA = "0x1830E2980", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x30E2A30", Offset = "0x30E1A30", VA = "0x1830E2A30", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x576E180", Offset = "0x576D180", VA = "0x18576E180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x576E140", Offset = "0x576D140", VA = "0x18576E140")]
		public ToolHierarchyCache(GameObject HJIAKOOMNND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x576D920", Offset = "0x576C920", VA = "0x18576D920")]
		private void AICHPOAHICB(GameObject HJIAKOOMNND, bool MJIEEJJMIKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x576DA40", Offset = "0x576CA40", VA = "0x18576DA40")]
		public static void AICHPOAHICB(GameObject HJIAKOOMNND, ref ToolHierarchyCache JNALAKHGIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x576DE70", Offset = "0x576CE70", VA = "0x18576DE70")]
		public void KPBMDGKDMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x576E090", Offset = "0x576D090", VA = "0x18576E090")]
		public void OCCICJNLJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x244A4D0", Offset = "0x24494D0", VA = "0x18244A4D0")]
		public void PNILCEBGPPP<T>(Action<T> BBNMGAFNKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x576DF40", Offset = "0x576CF40", VA = "0x18576DF40")]
		public Component MJFPFHFBMHH(Type GLKKDGLKBMK, bool NFGHPNCBHKM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x20C7E00", Offset = "0x20C6E00", VA = "0x1820C7E00")]
		public T MJFPFHFBMHH<T>(bool NFGHPNCBHKM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x576E000", Offset = "0x576D000", VA = "0x18576E000")]
		public MFJKICNDIBH<Component> NFDNIJGAMHH(Type GLKKDGLKBMK, bool NFGHPNCBHKM = false)
		{
			return default(MFJKICNDIBH<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2F99570", Offset = "0x2F98570", VA = "0x182F99570")]
		public MFJKICNDIBH<T> NFDNIJGAMHH<T>(bool NFGHPNCBHKM = false) where T : class
		{
			return default(MFJKICNDIBH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x576DB50", Offset = "0x576CB50", VA = "0x18576DB50")]
		public List<Component> GGLNCFDGCFG(Type GLKKDGLKBMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x576DAD0", Offset = "0x576CAD0", VA = "0x18576DAD0", Slot = "4")]
		public bool Equals(ToolHierarchyCache JIOINDMBNBK, ToolHierarchyCache AOEDNBDEECB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x576DE00", Offset = "0x576CE00", VA = "0x18576DE00", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MDAEAKFNGDG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class LFGDBNJIKGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private int FANLILHFAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private int NJJEPNDBHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private List<T> OOEEMCHEMCH;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x27C19D0", Offset = "0x27C09D0", VA = "0x1827C19D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public T LNJGJEHKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x27C17B0", Offset = "0x27C07B0", VA = "0x1827C17B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public T BMHOCFNENOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x27C1700", Offset = "0x27C0700", VA = "0x1827C1700")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public T DMKABOKAOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x27C1980", Offset = "0x27C0980", VA = "0x1827C1980")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x27C1BB0", Offset = "0x27C0BB0", VA = "0x1827C1BB0")]
	public LFGDBNJIKGN(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x27C1AE0", Offset = "0x27C0AE0", VA = "0x1827C1AE0")]
	public void PPCBFHPPBHE(T LDJIIMADGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x27C18D0", Offset = "0x27C08D0", VA = "0x1827C18D0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x27C1600", Offset = "0x27C0600", VA = "0x1827C1600")]
	public void ANBCGDKBJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x27C16A0", Offset = "0x27C06A0", VA = "0x1827C16A0")]
	public void CKEHGMAEIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x27C16F0", Offset = "0x27C06F0", VA = "0x1827C16F0")]
	public void DLELMBICMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class AFJAAOKDNEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool MFCNCAHAOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Action BBNMGAFNKKA;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public static AFJAAOKDNEE JGCEKOKJJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5765E20", Offset = "0x5764E20", VA = "0x185765E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool JKKKBJOODFH
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6107B0", Offset = "0x60F7B0", VA = "0x1806107B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8FCC50", Offset = "0x8FBC50", VA = "0x1808FCC50")]
	public AFJAAOKDNEE(Action BBNMGAFNKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x5765E00", Offset = "0x5764E00", VA = "0x185765E00")]
	public void BNBCPKDPKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x5765E00", Offset = "0x5764E00", VA = "0x185765E00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class LEFJKHIFJOI
{
	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	public static void MFDAAMFLEJF(KEKBGPDGDLG NHHOFJNBKIB, string NPDBGFINFPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class ENDEOHDPIIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private struct HPANKKNGBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int MALJDGBLCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public T GFNFCEIHNLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<object, HPANKKNGBAB> EHBCGGPPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private T OFKPCLGGMDH;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public virtual T BDAIGBEKEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x127FB70", Offset = "0x127EB70", VA = "0x18127FB70", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2F50", Offset = "0x2FC1F50", VA = "0x182FC2F50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool MDGCPDOHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x3362A60", Offset = "0x3361A60", VA = "0x183362A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public object BJIOGPOAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x36866B0", Offset = "0x36856B0", VA = "0x1836866B0")]
	public bool BINADFEEINP(T JNLOLNFALGF, object KGJPBGICHFN, int BPPJKBJLNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x335F780", Offset = "0x335E780", VA = "0x18335F780")]
	public bool EBFGJLCCCPL(object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x335F720", Offset = "0x335E720", VA = "0x18335F720")]
	public bool DCDCMBICKAB(object KGJPBGICHFN, out T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x26F05E0", Offset = "0x26EF5E0", VA = "0x1826F05E0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x3362350", Offset = "0x3361350", VA = "0x183362350")]
	private bool LGHGNNAFNNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x32F3E40", Offset = "0x32F2E40", VA = "0x1832F3E40")]
	public ENDEOHDPIIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class NDCAPLAHEMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private Dictionary<object, float> EHBCGGPPJKJ;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float HACNOBLKJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xF28CB0", Offset = "0xF27CB0", VA = "0x180F28CB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE38130", Offset = "0xE37130", VA = "0x180E38130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x576B600", Offset = "0x576A600", VA = "0x18576B600")]
	public void BINADFEEINP(float JNLOLNFALGF, object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x576B670", Offset = "0x576A670", VA = "0x18576B670")]
	public void EBFGJLCCCPL(object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x576B6E0", Offset = "0x576A6E0", VA = "0x18576B6E0")]
	private void KFJEKOIBNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x576B800", Offset = "0x576A800", VA = "0x18576B800")]
	public NDCAPLAHEMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class JNGMFIANMOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public readonly string PMMPPEFJODH;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
	public JNGMFIANMOG(string EGDFEFACPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x576A650", Offset = "0x5769650", VA = "0x18576A650")]
	public JNGMFIANMOG(UnityEngine.Object NBIJFMHPKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x576A600", Offset = "0x5769600", VA = "0x18576A600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class KEKBGPDGDLG
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class GHEJDKMABJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GHEJDKMABJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x57685E0", Offset = "0x57675E0", VA = "0x1857685E0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private HashSet<object> GFKKMGBEEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private int CJHODLHOOFH;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IReadOnlyCollection<object> DGOFPOLODPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x576A980", Offset = "0x5769980", VA = "0x18576A980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool CCEMNEGJHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x576A910", Offset = "0x5769910", VA = "0x18576A910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x576AA50", Offset = "0x5769A50", VA = "0x18576AA50")]
	public bool PPCBFHPPBHE(object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x576A820", Offset = "0x5769820", VA = "0x18576A820")]
	public bool DKCILJPFPEA(object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x576A8B0", Offset = "0x57698B0", VA = "0x18576A8B0")]
	public bool FAFGFNINKJO(object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x576A920", Offset = "0x5769920", VA = "0x18576A920")]
	public void LAMGJDFJFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x576AB10", Offset = "0x5769B10", VA = "0x18576AB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KEKBGPDGDLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class GHGNNCAFDJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private struct MMHKBHMLHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public float IKHPNENPMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public T GFNFCEIHNLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private Dictionary<object, MMHKBHMLHIB> EHBCGGPPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private T HLMMKCBBCLH;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual T DDBNPGMOBME
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A74060", Offset = "0x1A73060", VA = "0x181A74060", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A737E0", Offset = "0x1A727E0", VA = "0x181A737E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public object DMBIMMKHODD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool MDGCPDOHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3C90", Offset = "0x2FC2C90", VA = "0x182FC3C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2B90", Offset = "0x2FC1B90", VA = "0x182FC2B90")]
	public bool BINADFEEINP(T JNLOLNFALGF, object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2EF0", Offset = "0x2FC1EF0", VA = "0x182FC2EF0")]
	public bool EBFGJLCCCPL(object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x26F05E0", Offset = "0x26EF5E0", VA = "0x1826F05E0")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x4045030", Offset = "0x4044030", VA = "0x184045030")]
	public bool DCDCMBICKAB(object KGJPBGICHFN, out T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x4045500", Offset = "0x4044500", VA = "0x184045500")]
	private bool LGHGNNAFNNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3CD0", Offset = "0x2FC2CD0", VA = "0x182FC3CD0")]
	public GHGNNCAFDJI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5767B50", Offset = "0x5766B50", VA = "0x185767B50")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5767C50", Offset = "0x5766C50", VA = "0x185767C50")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
