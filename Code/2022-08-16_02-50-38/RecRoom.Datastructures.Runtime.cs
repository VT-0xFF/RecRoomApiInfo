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
public class LEAONLIFPJM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public LEAONLIFPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x575D1D0", Offset = "0x575BDD0", VA = "0x18575D1D0")]
	public byte[] BOHHGBNMDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void EIPPLLEGGML(IncrementalHash CAGODHOHMPP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xDD4560", Offset = "0xDD3160", VA = "0x180DD4560")]
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
	[JAEAPBJLEHA]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[JAEAPBJLEHA]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x57615E0", Offset = "0x57601E0", VA = "0x1857615E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57615A0", Offset = "0x57601A0", VA = "0x1857615A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5761620", Offset = "0x5760220", VA = "0x185761620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5761830", Offset = "0x5760430", VA = "0x185761830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57617A0", Offset = "0x57603A0", VA = "0x1857617A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1051800", Offset = "0x1050400", VA = "0x181051800")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF0A9F0", Offset = "0xF095F0", VA = "0x180F0A9F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5761560", Offset = "0x5760160", VA = "0x185761560")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5761710", Offset = "0x5760310", VA = "0x185761710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5760F90", Offset = "0x575FB90", VA = "0x185760F90")]
	public void CopyBounds(SavedExtents LPEBOAHCFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57614D0", Offset = "0x57600D0", VA = "0x1857614D0")]
	public void SetLocalSpaceBounds(Bounds MCOGCAAPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8FB690", Offset = "0x8FA290", VA = "0x1808FB690")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57614C0", Offset = "0x57600C0", VA = "0x1857614C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5761080", Offset = "0x575FC80", VA = "0x185761080")]
	private void MOMLHJHPKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5761290", Offset = "0x575FE90", VA = "0x185761290")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57609D0", Offset = "0x575F5D0", VA = "0x1857609D0")]
	public static void CalculateLocalBoundsFor(GameObject JPIPKHMPCNE, out Bounds MCOGCAAPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5760FC0", Offset = "0x575FBC0", VA = "0x185760FC0")]
	private static void MBKHDMDCBCF(Bounds DBJNEGCCKCM, Color CAOLLJDPDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57614F0", Offset = "0x57600F0", VA = "0x1857614F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EE0", Offset = "0x5E3AE0", VA = "0x1805E4EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
	public virtual void APECPDGCJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
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
	[LEAONLIFPJM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x292F5B0", Offset = "0x292E1B0", VA = "0x18292F5B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x292F0F0", Offset = "0x292DCF0", VA = "0x18292F0F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x292FBB0", Offset = "0x292E7B0", VA = "0x18292FBB0")]
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
	private sealed class NANLOJPANCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public NANLOJPANCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3E21850", Offset = "0x3E20450", VA = "0x183E21850")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[LEAONLIFPJM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3E201D0", Offset = "0x3E1EDD0", VA = "0x183E201D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E20200", Offset = "0x3E1EE00", VA = "0x183E20200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3E20120", Offset = "0x3E1ED20", VA = "0x183E20120", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey IHPCMBAPNMC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3E20150", Offset = "0x3E1ED50", VA = "0x183E20150", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3E20020", Offset = "0x3E1EC20", VA = "0x183E20020", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F880", Offset = "0x3E1E480", VA = "0x183E1F880", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F1F0", Offset = "0x3E1DDF0", VA = "0x183E1F1F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E1ED60", Offset = "0x3E1D960", VA = "0x183E1ED60", Slot = "14")]
	protected virtual string CGAKAJFPGMB(TKeyVal PIPCEPGIPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7190", Offset = "0x2CF5D90", VA = "0x182CF7190", Slot = "4")]
	public bool ContainsKey(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FF10", Offset = "0x3E1EB10", VA = "0x183E1FF10", Slot = "5")]
	public bool TryGetValue(TKey IHPCMBAPNMC, out TVal PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EDF0", Offset = "0x3E1D9F0", VA = "0x183E1EDF0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E1EDF0", Offset = "0x3E1D9F0", VA = "0x183E1EDF0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E1FF40", Offset = "0x3E1EB40", VA = "0x183E1FF40")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BJEBGEONAON<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ILPAEPLKOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public ILPAEPLKOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B65D30", Offset = "0x3B64930", VA = "0x183B65D30")]
		internal bool <GetSamples>b__0(global::GGFBDHJCLEA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float AFJLNBJOFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float HCEPHDDIPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::GGFBDHJCLEA<float, T>> EEFCMCHLBOM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FOLCCNONKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3B60EC0", Offset = "0x3B5FAC0", VA = "0x183B60EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B612B0", Offset = "0x3B5FEB0", VA = "0x183B612B0")]
	public BJEBGEONAON(float HOKGHFJBODM, float GPIBCOIHJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3B61120", Offset = "0x3B5FD20", VA = "0x183B61120")]
	public bool MHEFIIHEDAL(float MJGLMLNMELE, T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B60DA0", Offset = "0x3B5F9A0", VA = "0x183B60DA0")]
	public int BEHBNMGEJBO(float MJGLMLNMELE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B60720", Offset = "0x3B5F320", VA = "0x183B60720")]
	public IEnumerable<T> BDCJDMCGJPP(float MJGLMLNMELE, [Optional] float? FHMMLBIPDGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B61280", Offset = "0x3B5FE80", VA = "0x183B61280")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5FA00", VA = "0x183B60E00")]
	private void BKNHAPBBAKI(float MJGLMLNMELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class BLPKLDFJIGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HCNIFBCCKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T CFABBBMGOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float PCENMHEAMAP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float AHFIHFOJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> LGKMHCJMGLK;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int CPJBKIMGIEN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private HCNIFBCCKFL[] MPENDCAONOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int MMKKLPLHMGB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OJBNDILMADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xEBE990", Offset = "0xEBD590", VA = "0x180EBE990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF108F0", Offset = "0xF0F4F0", VA = "0x180F108F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x203F360", Offset = "0x203DF60", VA = "0x18203F360")]
	public BLPKLDFJIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x203F390", Offset = "0x203DF90", VA = "0x18203F390")]
	public BLPKLDFJIGM(int AABEJHHLOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x203E7F0", Offset = "0x203D3F0", VA = "0x18203E7F0")]
	public void JNIPLPDFDNO(float MJGLMLNMELE, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x203ED40", Offset = "0x203D940", VA = "0x18203ED40")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x203DE30", Offset = "0x203CA30", VA = "0x18203DE30")]
	public bool GGOCBFOACOH(float PJIFCMEMIJD, float ABJGFOHIJJA, out T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x203F1A0", Offset = "0x203DDA0", VA = "0x18203F1A0")]
	public bool NGCPALGHCKJ(float PJIFCMEMIJD, float ABJGFOHIJJA, out T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x203E400", Offset = "0x203D000", VA = "0x18203E400")]
	public void JCGCBJNILKP(float PJIFCMEMIJD, float ABJGFOHIJJA, List<T> GDLCFFFAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x203EA70", Offset = "0x203D670", VA = "0x18203EA70")]
	private int LMFHALILBHA(int EMHPOAMMPFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x203E3C0", Offset = "0x203CFC0", VA = "0x18203E3C0")]
	private void HEKIHBMAIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LFPLNGJBOPF();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MMPPEAGLONN(T EAGBNEBPABL, T HDKBIEHDLMI, float JJBHDPAHMPA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T NLDIAJEINPJ(T PDMPLJICJLE, float JJBHDPAHMPA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T AIJMFLHKOCJ(T EAGBNEBPABL, T HDKBIEHDLMI);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KNNFMANCDDF(T EAGBNEBPABL, T HDKBIEHDLMI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HNJDKBPDAIG : global::BLPKLDFJIGM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x575CFA0", Offset = "0x575BBA0", VA = "0x18575CFA0", Slot = "4")]
	protected override Vector3 LFPLNGJBOPF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x575D010", Offset = "0x575BC10", VA = "0x18575D010", Slot = "5")]
	protected override Vector3 MMPPEAGLONN(Vector3 EAGBNEBPABL, Vector3 HDKBIEHDLMI, float JJBHDPAHMPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x575D0D0", Offset = "0x575BCD0", VA = "0x18575D0D0", Slot = "6")]
	protected override Vector3 NLDIAJEINPJ(Vector3 PDMPLJICJLE, float JJBHDPAHMPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x575CE80", Offset = "0x575BA80", VA = "0x18575CE80", Slot = "7")]
	protected override Vector3 AIJMFLHKOCJ(Vector3 EAGBNEBPABL, Vector3 HDKBIEHDLMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x575CF30", Offset = "0x575BB30", VA = "0x18575CF30", Slot = "8")]
	protected override Vector3 KNNFMANCDDF(Vector3 EAGBNEBPABL, Vector3 HDKBIEHDLMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x575D170", Offset = "0x575BD70", VA = "0x18575D170")]
	public HNJDKBPDAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DHPIIJDMOFG : global::BLPKLDFJIGM<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x575ABF0", Offset = "0x57597F0", VA = "0x18575ABF0")]
	public DHPIIJDMOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x575AB80", Offset = "0x5759780", VA = "0x18575AB80")]
	public DHPIIJDMOFG(int AABEJHHLOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x10DBAF0", Offset = "0x10DA6F0", VA = "0x1810DBAF0", Slot = "4")]
	protected override float LFPLNGJBOPF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x575AB00", Offset = "0x5759700", VA = "0x18575AB00", Slot = "5")]
	protected override float MMPPEAGLONN(float EAGBNEBPABL, float HDKBIEHDLMI, float JJBHDPAHMPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41480B0", Offset = "0x4146CB0", VA = "0x1841480B0", Slot = "6")]
	protected override float NLDIAJEINPJ(float PDMPLJICJLE, float JJBHDPAHMPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x37739D0", Offset = "0x37725D0", VA = "0x1837739D0", Slot = "7")]
	protected override float AIJMFLHKOCJ(float EAGBNEBPABL, float HDKBIEHDLMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x575AAF0", Offset = "0x57596F0", VA = "0x18575AAF0", Slot = "8")]
	protected override float KNNFMANCDDF(float EAGBNEBPABL, float HDKBIEHDLMI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class APNMJOBIPFA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6740", Offset = "0x1CA5340", VA = "0x181CA6740")]
	public static global::HNMJLHBGLIG<T1> NEKFKHFNPIG<T1>(T1 OGKPCPNEJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2183120", Offset = "0x2181D20", VA = "0x182183120")]
	public static global::GGFBDHJCLEA<T1, T2> NEKFKHFNPIG<T1, T2>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4060", Offset = "0x1DF2C60", VA = "0x181DF4060")]
	public static global::LBAFMLMEKCF<T1, T2, T3> NEKFKHFNPIG<T1, T2, T3>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E05FA0", Offset = "0x1E04BA0", VA = "0x181E05FA0")]
	public static global::HNNMOBCGNMO<T1, T2, T3, T4> NEKFKHFNPIG<T1, T2, T3, T4>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2183240", Offset = "0x2181E40", VA = "0x182183240")]
	public static global::JDAHHHAFLBP<T1, T2, T3, T4, T5> NEKFKHFNPIG<T1, T2, T3, T4, T5>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2183190", Offset = "0x2181D90", VA = "0x182183190")]
	public static global::HKLHGJPDIMC<T1, T2, T3, T4, T5, T6> NEKFKHFNPIG<T1, T2, T3, T4, T5, T6>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML, T6 JJMLCJOOGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x273FC00", Offset = "0x273E800", VA = "0x18273FC00")]
	public static global::GAONOMGADLM<T1, T2, T3, T4, T5, T6, T7> NEKFKHFNPIG<T1, T2, T3, T4, T5, T6, T7>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML, T6 JJMLCJOOGND, T7 CPPFNEMKDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x273FB30", Offset = "0x273E730", VA = "0x18273FB30")]
	public static global::DFGDAHFODLJ<T1, T2, T3, T4, T5, T6, T7, T8> NEKFKHFNPIG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML, T6 JJMLCJOOGND, T7 CPPFNEMKDEL, T8 GDMHJCPNNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1B26920", Offset = "0x1B25520", VA = "0x181B26920")]
	[IteratorStateMachine(typeof(NIGMNPKPGOD))]
	public static IEnumerable<global::GGFBDHJCLEA<T1, T2>> LKEIKEFMNBF<T1, T2>(IEnumerable<T1> GBHOMBFJPAG, IEnumerable<T2> DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D7D0", Offset = "0x1D2C3D0", VA = "0x181D2D7D0")]
	[IteratorStateMachine(typeof(NCKFBLMNJOG))]
	public static IEnumerable<global::LBAFMLMEKCF<T1, T2, T3>> LKEIKEFMNBF<T1, T2, T3>(IEnumerable<T1> GBHOMBFJPAG, IEnumerable<T2> DBJNEGCCKCM, IEnumerable<T3> CAOLLJDPDGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xC09EE0", Offset = "0xC08AE0", VA = "0x180C09EE0")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xC09EF0", Offset = "0xC08AF0", VA = "0x180C09EF0")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO, int AIIBPEGACLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xC09F00", Offset = "0xC08B00", VA = "0x180C09F00")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO, int AIIBPEGACLM, int OKNFEIDEOMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x575A200", Offset = "0x5758E00", VA = "0x18575A200")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO, int AIIBPEGACLM, int OKNFEIDEOMB, int NDIIBJAGJDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x575A220", Offset = "0x5758E20", VA = "0x18575A220")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO, int AIIBPEGACLM, int OKNFEIDEOMB, int NDIIBJAGJDC, int IDENNABEPPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x575A240", Offset = "0x5758E40", VA = "0x18575A240")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO, int AIIBPEGACLM, int OKNFEIDEOMB, int NDIIBJAGJDC, int IDENNABEPPD, int DIODFHHFNJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x575A270", Offset = "0x5758E70", VA = "0x18575A270")]
	internal static int OHGNOPCKDMB(int HPFNHMCCLEF, int GKPGKMIBMPO, int AIIBPEGACLM, int OKNFEIDEOMB, int NDIIBJAGJDC, int IDENNABEPPD, int DIODFHHFNJC, int EHGFHKLIFPO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HNMJLHBGLIG<T1> : IComparable<global::HNMJLHBGLIG<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
	public HNMJLHBGLIG(T1 OGKPCPNEJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x43A9300", Offset = "0x43A7F00", VA = "0x1843A9300", Slot = "4")]
	public int CompareTo(global::HNMJLHBGLIG<T1> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x43A9370", Offset = "0x43A7F70", VA = "0x1843A9370", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8EE150", Offset = "0x8ECD50", VA = "0x1808EE150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x43A9410", Offset = "0x43A8010", VA = "0x1843A9410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GGFBDHJCLEA<T1, T2> : IComparable<global::GGFBDHJCLEA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x33A3160", Offset = "0x33A1D60", VA = "0x1833A3160")]
	public GGFBDHJCLEA(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x33A15D0", Offset = "0x33A01D0", VA = "0x1833A15D0", Slot = "4")]
	public int CompareTo(global::GGFBDHJCLEA<T1, T2> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x33A19F0", Offset = "0x33A05F0", VA = "0x1833A19F0", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x33A24F0", Offset = "0x33A10F0", VA = "0x1833A24F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x33A2C90", Offset = "0x33A1890", VA = "0x1833A2C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LBAFMLMEKCF<T1, T2, T3> : IComparable<global::LBAFMLMEKCF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 PGDKGMDCFIL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44E7ED0", Offset = "0x44E6AD0", VA = "0x1844E7ED0")]
	public LBAFMLMEKCF(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44E76F0", Offset = "0x44E62F0", VA = "0x1844E76F0", Slot = "4")]
	public int CompareTo(global::LBAFMLMEKCF<T1, T2, T3> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44E78F0", Offset = "0x44E64F0", VA = "0x1844E78F0", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x44E7BE0", Offset = "0x44E67E0", VA = "0x1844E7BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44E7D40", Offset = "0x44E6940", VA = "0x1844E7D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HNNMOBCGNMO<T1, T2, T3, T4> : IComparable<global::HNNMOBCGNMO<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 PGDKGMDCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 DGEAJHAMCPE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A52BD0", Offset = "0x2A517D0", VA = "0x182A52BD0")]
	public HNNMOBCGNMO(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x43A94B0", Offset = "0x43A80B0", VA = "0x1843A94B0", Slot = "4")]
	public int CompareTo(global::HNNMOBCGNMO<T1, T2, T3, T4> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x43A95F0", Offset = "0x43A81F0", VA = "0x1843A95F0", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x43A9710", Offset = "0x43A8310", VA = "0x1843A9710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43A97D0", Offset = "0x43A83D0", VA = "0x1843A97D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JDAHHHAFLBP<T1, T2, T3, T4, T5> : IComparable<global::JDAHHHAFLBP<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 PGDKGMDCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 DGEAJHAMCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 KNJLJBLJNAA;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x31FBC20", Offset = "0x31FA820", VA = "0x1831FBC20")]
	public JDAHHHAFLBP(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31FB730", Offset = "0x31FA330", VA = "0x1831FB730", Slot = "4")]
	public int CompareTo(global::JDAHHHAFLBP<T1, T2, T3, T4, T5> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31FB8B0", Offset = "0x31FA4B0", VA = "0x1831FB8B0", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x31FB9F0", Offset = "0x31FA5F0", VA = "0x1831FB9F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31FBAF0", Offset = "0x31FA6F0", VA = "0x1831FBAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HKLHGJPDIMC<T1, T2, T3, T4, T5, T6> : IComparable<global::HKLHGJPDIMC<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 PGDKGMDCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 DGEAJHAMCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 KNJLJBLJNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 FFJNGHPAPCM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x43A17C0", Offset = "0x43A03C0", VA = "0x1843A17C0")]
	public HKLHGJPDIMC(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML, T6 JJMLCJOOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x43A1220", Offset = "0x439FE20", VA = "0x1843A1220", Slot = "4")]
	public int CompareTo(global::HKLHGJPDIMC<T1, T2, T3, T4, T5, T6> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x43A13E0", Offset = "0x439FFE0", VA = "0x1843A13E0", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x43A1550", Offset = "0x43A0150", VA = "0x1843A1550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x43A1670", Offset = "0x43A0270", VA = "0x1843A1670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GAONOMGADLM<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::GAONOMGADLM<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 PGDKGMDCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 DGEAJHAMCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 KNJLJBLJNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 FFJNGHPAPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 OPODOLAEGMN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x339E510", Offset = "0x339D110", VA = "0x18339E510")]
	public GAONOMGADLM(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML, T6 JJMLCJOOGND, T7 CPPFNEMKDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x339DEB0", Offset = "0x339CAB0", VA = "0x18339DEB0", Slot = "4")]
	public int CompareTo(global::GAONOMGADLM<T1, T2, T3, T4, T5, T6, T7> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x339E0B0", Offset = "0x339CCB0", VA = "0x18339E0B0", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x339E250", Offset = "0x339CE50", VA = "0x18339E250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x339E3A0", Offset = "0x339CFA0", VA = "0x18339E3A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DFGDAHFODLJ<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::DFGDAHFODLJ<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 KOOJLDFFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 BOGPNCFCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 PGDKGMDCFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 DGEAJHAMCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 KNJLJBLJNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 FFJNGHPAPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 OPODOLAEGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 NLCJKKODPPG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B591F0", Offset = "0x4B57DF0", VA = "0x184B591F0")]
	public DFGDAHFODLJ(T1 OGKPCPNEJHE, T2 FDFMHLLOFIG, T3 KHNJMCOJLJE, T4 LDBHJHCPABO, T5 MJADMKNPGML, T6 JJMLCJOOGND, T7 CPPFNEMKDEL, T8 GDMHJCPNNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B58AE0", Offset = "0x4B576E0", VA = "0x184B58AE0", Slot = "4")]
	public int CompareTo(global::DFGDAHFODLJ<T1, T2, T3, T4, T5, T6, T7, T8> LPEBOAHCFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B58D30", Offset = "0x4B57930", VA = "0x184B58D30", Slot = "0")]
	public override bool Equals(object LPEBOAHCFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B58EF0", Offset = "0x4B57AF0", VA = "0x184B58EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4B59060", Offset = "0x4B57C60", VA = "0x184B59060", Slot = "3")]
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
	public T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CPPJKKNPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x151B9A0", Offset = "0x151A5A0", VA = "0x18151B9A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x445C330", Offset = "0x445AF30", VA = "0x18445C330")]
	public T DBBOAINPKJE(float JJBHDPAHMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x445C6B0", Offset = "0x445B2B0", VA = "0x18445C6B0")]
	public T IBPJGAKLCAG(float JJBHDPAHMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MMPPEAGLONN(T EAGBNEBPABL, T HDKBIEHDLMI, float JJBHDPAHMPA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x575C8A0", Offset = "0x575B4A0", VA = "0x18575C8A0", Slot = "4")]
	protected override float MMPPEAGLONN(float EAGBNEBPABL, float HDKBIEHDLMI, float JJBHDPAHMPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x575C920", Offset = "0x575B520", VA = "0x18575C920")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5762790", Offset = "0x5761390", VA = "0x185762790", Slot = "4")]
	protected override Vector3 MMPPEAGLONN(Vector3 EAGBNEBPABL, Vector3 HDKBIEHDLMI, float JJBHDPAHMPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5762850", Offset = "0x5761450", VA = "0x185762850")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x575AA60", Offset = "0x5759660", VA = "0x18575AA60", Slot = "4")]
	protected override Color MMPPEAGLONN(Color EAGBNEBPABL, Color HDKBIEHDLMI, float JJBHDPAHMPA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x575AAB0", Offset = "0x57596B0", VA = "0x18575AAB0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FKPJFIFODNE : global::HLDONIDHMEP<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x575C7F0", Offset = "0x575B3F0", VA = "0x18575C7F0")]
	public FKPJFIFODNE(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x575C790", Offset = "0x575B390", VA = "0x18575C790")]
	public FKPJFIFODNE(GFHONDKJNAP[] HGLGBCEPLMF, bool OGHKLKHLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x575C720", Offset = "0x575B320", VA = "0x18575C720", Slot = "6")]
	protected override uint LCPDKOADEMC(uint CAGODHOHMPP, string PDMPLJICJLE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GPBAPGLGJHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public GPBAPGLGJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::DDJKPFKCHHE<>.GJNCEELGMDA))]
[DefaultMember("Item")]
public sealed class DDJKPFKCHHE<T> : IDisposable, global::BJEDPLCNELI<T>, MDCAECCDPAB, global::DAKHCNABDKM<T, global::DDJKPFKCHHE<T>.DEFGNJFADFB>, global::FDPCMLIJCKP<T>, global::KGBJEDINCPD<T, global::DDJKPFKCHHE<T>.DEFGNJFADFB>, global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, global::DDJKPFKCHHE<T>.DEFGNJFADFB>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct DEFGNJFADFB : MDCAECCDPAB, global::DKPOBNPICCF<T>, global::PALNBMKGDOF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::DDJKPFKCHHE<T> NCEPLELEBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int EOOCBGCOEDN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int JFMPCJJIJJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E2B130", Offset = "0x1E29D30", VA = "0x181E2B130", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4915350", Offset = "0x4913F50", VA = "0x184915350", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private T BFOMKCAMHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4914C30", Offset = "0x4913830", VA = "0x184914C30", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4914E80", Offset = "0x4913A80", VA = "0x184914E80", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4915030", Offset = "0x4913C30", VA = "0x184915030", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x385D9C0", Offset = "0x385C5C0", VA = "0x18385D9C0")]
		private DEFGNJFADFB(global::DDJKPFKCHHE<T> HKEOACGCKDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x22C4D80", Offset = "0x22C3980", VA = "0x1822C4D80")]
		public static DEFGNJFADFB EBNJNBKPCHE(global::DDJKPFKCHHE<T> HKEOACGCKDE)
		{
			return default(DEFGNJFADFB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4914C90", Offset = "0x4913890", VA = "0x184914C90", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x22C4E60", Offset = "0x22C3A60", VA = "0x1822C4E60", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class GJNCEELGMDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::DDJKPFKCHHE<T> NCEPLELEBKG;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int JFMPCJJIJJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x29910B0", Offset = "0x298FCB0", VA = "0x1829910B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T[] OLKELAGMDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4918FA0", Offset = "0x4917BA0", VA = "0x184918FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool GKDFMIBKEPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4919060", Offset = "0x4917C60", VA = "0x184919060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
		public GJNCEELGMDA(global::DDJKPFKCHHE<T> HKEOACGCKDE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PCNDIBJIEDC BBLPGEEGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] JFCLJGPJHOE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CD0", Offset = "0x5E38D0", VA = "0x1805E4CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x665A10", Offset = "0x664610", VA = "0x180665A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> OLKELAGMDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x490FB80", Offset = "0x490E780", VA = "0x18490FB80")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T JNPKDPJPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4910C10", Offset = "0x490F810", VA = "0x184910C10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T CIAHOCIONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4910C10", Offset = "0x490F810", VA = "0x184910C10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4912390", Offset = "0x4910F90", VA = "0x184912390")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4910AD0", Offset = "0x490F6D0", VA = "0x184910AD0")]
	public static global::DDJKPFKCHHE<T> EBNJNBKPCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x490FD10", Offset = "0x490E910", VA = "0x18490FD10")]
	public static global::DDJKPFKCHHE<T> CONJEFICHON(int EFOLPOOCAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4913120", Offset = "0x4911D20", VA = "0x184913120")]
	internal DDJKPFKCHHE(T[] OALGPDJHKKG, int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x242C460", Offset = "0x242B060", VA = "0x18242C460", Slot = "5")]
	public T CGONPJENCPN(int ACJHPBCLINB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x490FE50", Offset = "0x490EA50", VA = "0x18490FE50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4912000", Offset = "0x4910C00", VA = "0x184912000")]
	public void JNIPLPDFDNO(in T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4911130", Offset = "0x490FD30", VA = "0x184911130")]
	public void FFCBNOPDCNH(int BAOHKIGDOBF, in T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4912440", Offset = "0x4911040", VA = "0x184912440")]
	public void OFOMMAGAOIE(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4910840", Offset = "0x490F440", VA = "0x184910840")]
	public void EAMDHOMFAFG(int AABEJHHLOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4912E60", Offset = "0x4911A60", VA = "0x184912E60")]
	private void PDNFMEFDKJB(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4912410", Offset = "0x4911010", VA = "0x184912410")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x49116F0", Offset = "0x49102F0", VA = "0x1849116F0")]
	public global::DDJKPFKCHHE<T> FPJCJDLKDFJ(global::NOOKCJJJEGF<T, T> JFECLCNCAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4911C40", Offset = "0x4910840", VA = "0x184911C40", Slot = "11")]
	public DEFGNJFADFB GetEnumerator()
	{
		return default(DEFGNJFADFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4911C80", Offset = "0x4910880", VA = "0x184911C80", Slot = "8")]
	private global::DKPOBNPICCF<T> PCFIIBCAANL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4911C80", Offset = "0x4910880", VA = "0x184911C80", Slot = "10")]
	private global::PALNBMKGDOF<T> JABGMOOHEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4911C80", Offset = "0x4910880", VA = "0x184911C80", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4911C80", Offset = "0x4910880", VA = "0x184911C80", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FJCLLNDKDPB
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28B21B0", Offset = "0x28B0DB0", VA = "0x1828B21B0")]
	public static bool GEKKAHHNPJD<T>(this global::DDJKPFKCHHE<T> HKEOACGCKDE, in T PDMPLJICJLE) where T : global::IFPMBEDBOED<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JPHLCEKFKEK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class POEBFMJGGJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<JPLMCCNINHK> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public POEBFMJGGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x57600A0", Offset = "0x575ECA0", VA = "0x1857600A0")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<JPLMCCNINHK>> AKEIFPFHIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int KOBOADNPEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int EJGBJCIHIKC;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F19E0", Offset = "0x9F05E0", VA = "0x1809F19E0")]
	private JPHLCEKFKEK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<JPLMCCNINHK>> AMBELABDDIL, int HPPDPOEFLMA, int JBEDNGOOODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x575D3A0", Offset = "0x575BFA0", VA = "0x18575D3A0")]
	public static JPHLCEKFKEK EBNJNBKPCHE()
	{
		return default(JPHLCEKFKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x575D420", Offset = "0x575C020", VA = "0x18575D420")]
	public (int, int, Task) JCEPIEFGMJA(int BHOBBHFIIOL, [Optional] CancellationToken NKLNCNDPFGD)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x575D2F0", Offset = "0x575BEF0", VA = "0x18575D2F0")]
	public void BLDGONHDKIL(int BHOBBHFIIOL, int JBEDNGOOODE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class IBHMCGNPKKC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> GJNJOMJAOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> PGGMHGPGNNI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x29910B0", Offset = "0x298FCB0", VA = "0x1829910B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TKey> LLBAEOGIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3132400", Offset = "0x3131000", VA = "0x183132400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> ONAJPJDPGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2F78960", Offset = "0x2F77560", VA = "0x182F78960", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public TVal LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x33154B0", Offset = "0x33140B0", VA = "0x1833154B0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3314F30", Offset = "0x3313B30", VA = "0x183314F30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TKey LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x33C43B0", Offset = "0x33C2FB0", VA = "0x1833C43B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x33C3B80", Offset = "0x33C2780", VA = "0x1833C3B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x33C3C00", Offset = "0x33C2800", VA = "0x1833C3C00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x33C46E0", Offset = "0x33C32E0", VA = "0x1833C46E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A58500", Offset = "0x2A57100", VA = "0x182A58500", Slot = "9")]
	public void Add(TKey IHPCMBAPNMC, TVal PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x33C3B50", Offset = "0x33C2750", VA = "0x1833C3B50", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x33C3C60", Offset = "0x33C2860", VA = "0x1833C3C60", Slot = "8")]
	public bool ContainsKey(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3313960", Offset = "0x3312560", VA = "0x183313960", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x33C4660", Offset = "0x33C3260", VA = "0x1833C4660", Slot = "10")]
	public bool Remove(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x33C4660", Offset = "0x33C3260", VA = "0x1833C4660", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2F786F0", Offset = "0x2F772F0", VA = "0x182F786F0", Slot = "11")]
	public bool TryGetValue(TKey IHPCMBAPNMC, out TVal PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x33C4100", Offset = "0x33C2D00", VA = "0x1833C4100", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x33C3CC0", Offset = "0x33C28C0", VA = "0x1833C3CC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x33C4370", Offset = "0x33C2F70", VA = "0x1833C4370")]
	public void JNIPLPDFDNO(TVal OFLCHCPLOKA, TKey IHPCMBAPNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x33C4300", Offset = "0x33C2F00", VA = "0x1833C4300")]
	public void JNIPLPDFDNO(KeyValuePair<TVal, TKey> IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x33C4050", Offset = "0x33C2C50", VA = "0x1833C4050")]
	public bool GOFBAEHAJMJ(TVal IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2104B10", Offset = "0x2103710", VA = "0x182104B10")]
	public bool HNMPINFIMAB(KeyValuePair<TVal, TKey> IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3056B70", Offset = "0x3055770", VA = "0x183056B70")]
	public bool MAHLOMNJIKK(TVal IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3056B70", Offset = "0x3055770", VA = "0x183056B70")]
	public bool MAHLOMNJIKK(KeyValuePair<TVal, TKey> IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x33C3D20", Offset = "0x33C2920", VA = "0x1833C3D20")]
	public bool EKDAOPLAPIM(TVal IHPCMBAPNMC, out TKey PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x33C44A0", Offset = "0x33C30A0", VA = "0x1833C44A0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> NHAALPIDGNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x33C4520", Offset = "0x33C3120", VA = "0x1833C4520")]
	private void PAIPIDMGLHH(TKey IHPCMBAPNMC, TVal OFLCHCPLOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x33C4240", Offset = "0x33C2E40", VA = "0x1833C4240")]
	private void JJBLHNFGEPN(TKey IHPCMBAPNMC, TVal OFLCHCPLOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33C3ED0", Offset = "0x33C2AD0", VA = "0x1833C3ED0")]
	private bool FBFCKKAAGNA(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33C3E10", Offset = "0x33C2A10", VA = "0x1833C3E10")]
	private bool FBFCKKAAGNA(TVal OFLCHCPLOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x33C4730", Offset = "0x33C3330", VA = "0x1833C4730")]
	public IBHMCGNPKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JMLKBDIDKIJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::JMLKBDIDKIJ<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xEBE990", Offset = "0xEBD590", VA = "0x180EBE990", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2420640", Offset = "0x241F240", VA = "0x182420640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x24207A0", Offset = "0x241F3A0", VA = "0x1824207A0")]
		public Enumerator(global::JMLKBDIDKIJ<T> GDLCFFFAFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x241FD60", Offset = "0x241E960", VA = "0x18241FD60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2420150", Offset = "0x241ED50", VA = "0x182420150", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x241FAA0", Offset = "0x241E6A0", VA = "0x18241FAA0")]
		private void CFHPBGNFPHC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] KKBLPIMEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int OEHNDNCNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int MJMHBOALPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int PGLJOAGFHIO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2426E50", Offset = "0x2425A50", VA = "0x182426E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x24277C0", Offset = "0x24263C0", VA = "0x1824277C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2425FB0", Offset = "0x2424BB0", VA = "0x182425FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2428030", Offset = "0x2426C30", VA = "0x182428030")]
	public JMLKBDIDKIJ(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2427490", Offset = "0x2426090", VA = "0x182427490")]
	public void JNIPLPDFDNO(T JJBHDPAHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2426530", Offset = "0x2425130", VA = "0x182426530")]
	public void DIIKIMNFFNL(IEnumerable<T> JCAANKCENCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x24278E0", Offset = "0x24264E0", VA = "0x1824278E0")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x24276D0", Offset = "0x24262D0", VA = "0x1824276D0")]
	public void KJNAEMHPDCE(int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x24261A0", Offset = "0x2424DA0", VA = "0x1824261A0")]
	public void CGDEENEOJJE(int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2427A50", Offset = "0x2426650", VA = "0x182427A50")]
	public void PMKOCOEJIKJ(T[] MPENDCAONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2427280", Offset = "0x2425E80", VA = "0x182427280")]
	public Enumerator FIAIDFFFPCH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2427E40", Offset = "0x2426A40", VA = "0x182427E40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2427E40", Offset = "0x2426A40", VA = "0x182427E40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2427190", Offset = "0x2425D90", VA = "0x182427190")]
	private int FBKMLMGHKNG(int BAOHKIGDOBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2426E90", Offset = "0x2425A90", VA = "0x182426E90")]
	private int EKLICGDEMHN(int BAOHKIGDOBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PBNCNGPDFKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] JFCLJGPJHOE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x725470", Offset = "0x724070", VA = "0x180725470")]
	public PBNCNGPDFKJ(params IDisposable[] OALGPDJHKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xE37DF0", Offset = "0xE369F0", VA = "0x180E37DF0")]
	public static PBNCNGPDFKJ EBNJNBKPCHE(params IDisposable[] OALGPDJHKKG)
	{
		return default(PBNCNGPDFKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x575FE90", Offset = "0x575EA90", VA = "0x18575FE90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct CPONMCCMFJK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable EDFBONHJLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T CFABBBMGOIO;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x23509C0", Offset = "0x234F5C0", VA = "0x1823509C0")]
	public CPONMCCMFJK(IDisposable BOLCPAJJPIN, in T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2389D00", Offset = "0x2388900", VA = "0x182389D00")]
	public static global::CPONMCCMFJK<U> NHAGJPAHNII<U>(in global::CPONMCCMFJK<T> BOLCPAJJPIN, in U PDMPLJICJLE)
	{
		return default(global::CPONMCCMFJK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1D85FE0", Offset = "0x1D84BE0", VA = "0x181D85FE0")]
	public global::CPONMCCMFJK<U> MCLEDLHABPG<U>(in U PDMPLJICJLE)
	{
		return default(global::CPONMCCMFJK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2389AA0", Offset = "0x23886A0", VA = "0x182389AA0")]
	public static global::CPONMCCMFJK<(T, U)> BDKOJIPLOAC<U>(in global::CPONMCCMFJK<T> GBHOMBFJPAG, in global::CPONMCCMFJK<U> DBJNEGCCKCM)
	{
		return default(global::CPONMCCMFJK<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2358630", Offset = "0x2357230", VA = "0x182358630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NOCGJCMEAMN
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x23951B0", Offset = "0x2393DB0", VA = "0x1823951B0")]
	public static global::CPONMCCMFJK<T> EBNJNBKPCHE<T>(IDisposable BOLCPAJJPIN, in T PDMPLJICJLE)
	{
		return default(global::CPONMCCMFJK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1D85FE0", Offset = "0x1D84BE0", VA = "0x181D85FE0")]
	public static global::CPONMCCMFJK<U> NHAGJPAHNII<U, T>(in global::CPONMCCMFJK<T> BKNBEIBHBJO, in U PDMPLJICJLE)
	{
		return default(global::CPONMCCMFJK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x21830E0", Offset = "0x2181CE0", VA = "0x1821830E0")]
	public static global::CPONMCCMFJK<(T, U)> BDKOJIPLOAC<T, U>(in global::CPONMCCMFJK<T> GBHOMBFJPAG, in global::CPONMCCMFJK<U> DBJNEGCCKCM)
	{
		return default(global::CPONMCCMFJK<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PCNDIBJIEDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0")]
	public static PCNDIBJIEDC ONNAEPJPGJD<T>([Optional] string JEGJCICFBPB, [Optional] string MPAPFBMJDOM, bool MHFFMKJBDHH = false)
	{
		return default(PCNDIBJIEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct KFEBBDOOEJF<T> : global::KGBJEDINCPD<T, global::KFEBBDOOEJF<T>.DAMJBLLIKEM>, global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, global::KFEBBDOOEJF<T>.DAMJBLLIKEM>, IEnumerable<T>, IEnumerable, global::BJEDPLCNELI<T>, MDCAECCDPAB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct DAMJBLLIKEM : MDCAECCDPAB, global::PALNBMKGDOF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] NCEPLELEBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int EOOCBGCOEDN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int JFMPCJJIJJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x22BDB20", Offset = "0x22BC720", VA = "0x1822BDB20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EC0", Offset = "0x22C3AC0", VA = "0x1822C4EC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x22C4E70", Offset = "0x22C3A70", VA = "0x1822C4E70", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x22C4E70", Offset = "0x22C3A70", VA = "0x1822C4E70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA25A90", Offset = "0xA24690", VA = "0x180A25A90")]
		private DAMJBLLIKEM(T[] HKEOACGCKDE, int BAOHKIGDOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x22C4D80", Offset = "0x22C3980", VA = "0x1822C4D80")]
		public static DAMJBLLIKEM EBNJNBKPCHE(T[] HKEOACGCKDE)
		{
			return default(DAMJBLLIKEM);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x22C4E30", Offset = "0x22C3A30", VA = "0x1822C4E30", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x22C4E60", Offset = "0x22C3A60", VA = "0x1822C4E60", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] FIKOAFDOPGP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x22BDB20", Offset = "0x22BC720", VA = "0x1822BDB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x22BD840", Offset = "0x22BC440", VA = "0x1822BD840", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x22BDAE0", Offset = "0x22BC6E0", VA = "0x1822BDAE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x725470", Offset = "0x724070", VA = "0x180725470")]
	internal KFEBBDOOEJF(T[] MPENDCAONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x22BD920", Offset = "0x22BC520", VA = "0x1822BD920")]
	public static global::KFEBBDOOEJF<T> INHNAJHBIEJ()
	{
		return default(global::KFEBBDOOEJF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x22BD7E0", Offset = "0x22BC3E0", VA = "0x1822BD7E0", Slot = "9")]
	public T CGONPJENCPN(int BAOHKIGDOBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x31334E0", Offset = "0x31320E0", VA = "0x1831334E0", Slot = "6")]
	public DAMJBLLIKEM GetEnumerator()
	{
		return default(DAMJBLLIKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3133580", Offset = "0x3132180", VA = "0x183133580", Slot = "5")]
	private global::PALNBMKGDOF<T> JABGMOOHEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3133580", Offset = "0x3132180", VA = "0x183133580", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3133580", Offset = "0x3132180", VA = "0x183133580", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JNDMAGEODKP
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA2F0", Offset = "0x1DF8EF0", VA = "0x181DFA2F0")]
	public static global::KFEBBDOOEJF<T> EBNJNBKPCHE<T>(T[] MPENDCAONOC)
	{
		return default(global::KFEBBDOOEJF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA350", Offset = "0x1DF8F50", VA = "0x181DFA350")]
	public static global::KFEBBDOOEJF<T> NNIPGJPMIBP<T>(this T[] HKEOACGCKDE)
	{
		return default(global::KFEBBDOOEJF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA320", Offset = "0x1DF8F20", VA = "0x181DFA320")]
	public static global::KFEBBDOOEJF<T>.DAMJBLLIKEM MNBDHAKKHIB<T>(this T[] HKEOACGCKDE)
	{
		return default(global::KFEBBDOOEJF<T>.DAMJBLLIKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA350", Offset = "0x1DF8F50", VA = "0x181DFA350")]
	public static global::KFEBBDOOEJF<T> PDGPJJHNKLB<T>(this T[] HKEOACGCKDE)
	{
		return default(global::KFEBBDOOEJF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LCCJIGBKNMH<T, U> : global::KGBJEDINCPD<T, U>, global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, U>, IEnumerable<T>, IEnumerable where U : global::PALNBMKGDOF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U ECLOIFNNFOM;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x203F500", Offset = "0x203E100", VA = "0x18203F500")]
	internal LCCJIGBKNMH(in U CFPIDHGJGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "5")]
	private global::PALNBMKGDOF<T> JABGMOOHEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ANLGNOECLHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3EE0", Offset = "0x1DF2AE0", VA = "0x181DF3EE0")]
	public static global::LCCJIGBKNMH<T, U> EBNJNBKPCHE<U>(in U CFPIDHGJGJN) where U : global::PALNBMKGDOF<T>
	{
		return default(global::LCCJIGBKNMH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KHJOEKEBBEN<TResult, TResultEnumerator> where TResultEnumerator : global::PALNBMKGDOF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2392830", Offset = "0x2391430", VA = "0x182392830")]
	public static global::CGACLBGOOEK<TSourceEnumerator, TResultEnumerator, TResult> GDKDFMNPDGC<TSourceEnumerator>(in TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::CGACLBGOOEK<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CGACLBGOOEK<TSourceEnumerator, TResultEnumerator, TResult> : global::PALNBMKGDOF<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::PALNBMKGDOF<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator NCEPLELEBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator GGCLNLLNBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool HCOPCHKJAGE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TResult JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1BF0", Offset = "0x2CF07F0", VA = "0x182CF1BF0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1B50", Offset = "0x2CF0750", VA = "0x182CF1B50", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1B50", Offset = "0x2CF0750", VA = "0x182CF1B50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1BA0", Offset = "0x2CF07A0", VA = "0x182CF1BA0")]
	internal CGACLBGOOEK(in TSourceEnumerator HKEOACGCKDE, in TResultEnumerator BJIGOICFJGI, bool HIBBCDNAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF19D0", Offset = "0x2CF05D0", VA = "0x182CF19D0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1B00", Offset = "0x2CF0700", VA = "0x182CF1B00", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1980", Offset = "0x2CF0580", VA = "0x182CF1980", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IPELBLHNEJL<TSourceEnumerator, TSource, TResult> : MDCAECCDPAB, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : MDCAECCDPAB, global::PALNBMKGDOF<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator NCEPLELEBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::NOOKCJJJEGF<TSource, TResult> MNLFOOKLPNJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x40042E0", Offset = "0x4002EE0", VA = "0x1840042E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4004D80", Offset = "0x4003980", VA = "0x184004D80", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4004970", Offset = "0x4003570", VA = "0x184004970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x27048F0", Offset = "0x27034F0", VA = "0x1827048F0")]
	internal IPELBLHNEJL(in TSourceEnumerator HKEOACGCKDE, global::NOOKCJJJEGF<TSource, TResult> KGMPEOHELPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4004650", Offset = "0x4003250", VA = "0x184004650", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4004740", Offset = "0x4003340", VA = "0x184004740", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x40041F0", Offset = "0x4002DF0", VA = "0x1840041F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KODJLEEGCJF<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::PALNBMKGDOF<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::PALNBMKGDOF<TSource> where TResultEnumerator : global::PALNBMKGDOF<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator NCEPLELEBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator GGCLNLLNBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::NOOKCJJJEGF<TSource, TResultEnumerator> MNLFOOKLPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool HCOPCHKJAGE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TResult JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x44E5100", Offset = "0x44E3D00", VA = "0x1844E5100", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x44E5010", Offset = "0x44E3C10", VA = "0x1844E5010", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x44E5010", Offset = "0x44E3C10", VA = "0x1844E5010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x44E50A0", Offset = "0x44E3CA0", VA = "0x1844E50A0")]
	internal KODJLEEGCJF(in TSourceEnumerator HKEOACGCKDE, in TResultEnumerator BJIGOICFJGI, global::NOOKCJJJEGF<TSource, TResultEnumerator> KGMPEOHELPJ, bool HIBBCDNAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x44E4E30", Offset = "0x44E3A30", VA = "0x1844E4E30", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x44E4FC0", Offset = "0x44E3BC0", VA = "0x1844E4FC0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x44E4DE0", Offset = "0x44E39E0", VA = "0x1844E4DE0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct HELANFMPIHL<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : MDCAECCDPAB, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : MDCAECCDPAB, global::PALNBMKGDOF<TSource1> where TSource2Enumerator : MDCAECCDPAB, global::PALNBMKGDOF<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator KPGHJNIKKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator PMPLNFFINLA;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3F99C90", Offset = "0x3F98890", VA = "0x183F99C90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public (TSource1, TSource2) JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3F99EF0", Offset = "0x3F98AF0", VA = "0x183F99EF0", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3F99E10", Offset = "0x3F98A10", VA = "0x183F99E10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3F99EB0", Offset = "0x3F98AB0", VA = "0x183F99EB0")]
	internal HELANFMPIHL(in TSource1Enumerator GGKCBIKKEOA, in TSource2Enumerator MIPOPEENDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3F99D30", Offset = "0x3F98930", VA = "0x183F99D30", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3F99DA0", Offset = "0x3F989A0", VA = "0x183F99DA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3F99C30", Offset = "0x3F98830", VA = "0x183F99C30", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct FKALBPHMJDO<T, U> : global::BPMELEBGMKL<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U ECLOIFNNFOM;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2101350", Offset = "0x20FFF50", VA = "0x182101350")]
	internal FKALBPHMJDO(in U CFPIDHGJGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xB53810", Offset = "0xB52410", VA = "0x180B53810", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2101280", Offset = "0x20FFE80", VA = "0x182101280", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2101280", Offset = "0x20FFE80", VA = "0x182101280", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GDLKAGNEBNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2743E20", Offset = "0x2742A20", VA = "0x182743E20")]
	public static global::FKALBPHMJDO<T, U> EBNJNBKPCHE<U>(in U CFPIDHGJGJN) where U : IEnumerator<T>
	{
		return default(global::FKALBPHMJDO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CAMNKKFNKAL<TSourceEnumerator, TSource, TResult> : MDCAECCDPAB, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : MDCAECCDPAB, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator NCEPLELEBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> MNLFOOKLPNJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2045560", Offset = "0x2044160", VA = "0x182045560", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public TResult JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x20456D0", Offset = "0x20442D0", VA = "0x1820456D0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2045650", Offset = "0x2044250", VA = "0x182045650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2045690", Offset = "0x2044290", VA = "0x182045690")]
	internal CAMNKKFNKAL(in TSourceEnumerator HKEOACGCKDE, Func<TSource, TResult> KGMPEOHELPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x20455B0", Offset = "0x20441B0", VA = "0x1820455B0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2045600", Offset = "0x2044200", VA = "0x182045600", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2045510", Offset = "0x2044110", VA = "0x182045510", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PJOABHPJEEN
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2328800", Offset = "0x2327400", VA = "0x182328800")]
	public static bool JCBGLBLNDKA<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator HKEOACGCKDE, in TArgs IHGKCAPJCJE, in global::DLBOMPGLIMI<TArgs, TSource, bool> OLMDIOFCHNJ) where TSourceEnumerator : global::PALNBMKGDOF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x207D520", Offset = "0x207C120", VA = "0x18207D520")]
	public static int HDMDHJGMMBD<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator HKEOACGCKDE, in TArgs IHGKCAPJCJE, global::DLBOMPGLIMI<TArgs, TSource, bool> OLMDIOFCHNJ) where TSourceEnumerator : global::PALNBMKGDOF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x23286B0", Offset = "0x23272B0", VA = "0x1823286B0")]
	public static bool FNPKABBGIKK<TSourceEnumerator, TSource>(this TSourceEnumerator HKEOACGCKDE, in TSource IPBHEMHOEAH) where TSourceEnumerator : global::PALNBMKGDOF<TSource> where TSource : global::IFPMBEDBOED<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x207D810", Offset = "0x207C410", VA = "0x18207D810")]
	public static int IEGMKHKBKHC<TSourceEnumerator, TSource>(this TSourceEnumerator HKEOACGCKDE, in TSource PDMPLJICJLE) where TSourceEnumerator : global::PALNBMKGDOF<TSource> where TSource : global::IFPMBEDBOED<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2194D60", Offset = "0x2193960", VA = "0x182194D60")]
	public static global::IPELBLHNEJL<TSourceEnumerator, TSource, TResult> OHGOGICIIND<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator HKEOACGCKDE, global::NOOKCJJJEGF<TSource, TResult> KGMPEOHELPJ) where TSourceEnumerator : MDCAECCDPAB, global::PALNBMKGDOF<TSource>
	{
		return default(global::IPELBLHNEJL<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2194DB0", Offset = "0x21939B0", VA = "0x182194DB0")]
	public static global::CAMNKKFNKAL<TSourceEnumerator, TSource, TResult> BLKBJNCLIEE<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator HKEOACGCKDE, Func<TSource, TResult> KGMPEOHELPJ) where TSourceEnumerator : MDCAECCDPAB, IEnumerator<TSource>
	{
		return default(global::CAMNKKFNKAL<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HHIHHGHKCKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x23164E0", Offset = "0x23150E0", VA = "0x1823164E0")]
	public static bool HMJNNHMCLDL<TSourceEnumerator>(TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B950", Offset = "0x1F2A550", VA = "0x181F2B950")]
	public static T ECABOLDABNE<TSourceEnumerator>(TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : global::PALNBMKGDOF<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7870", Offset = "0x1DF6470", VA = "0x181DF7870")]
	public static global::KODJLEEGCJF<TSourceEnumerator, TSource, TResultEnumerator, T> EPIILJBIBIA<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator HKEOACGCKDE, global::NOOKCJJJEGF<TSource, TResultEnumerator> KGMPEOHELPJ) where TSourceEnumerator : global::PALNBMKGDOF<TSource> where TResultEnumerator : global::PALNBMKGDOF<T>
	{
		return default(global::KODJLEEGCJF<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2217EF0", Offset = "0x2216AF0", VA = "0x182217EF0")]
	public static string HHBJKJDMPOK<TSourceEnumerator>(TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2D85D70", Offset = "0x2D84970", VA = "0x182D85D70")]
	public static T[] OMONHJINGFL<TSourceEnumerator>(TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : MDCAECCDPAB, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x33DA360", Offset = "0x33D8F60", VA = "0x1833DA360")]
	public static T FMKKGNAFHLH<TSourceEnumerator>(TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x23163B0", Offset = "0x2314FB0", VA = "0x1823163B0")]
	public static bool FBKCIIOLABD<TSourceEnumerator>(TSourceEnumerator HKEOACGCKDE) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IHJAGAHDAOL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x218F040", Offset = "0x218DC40", VA = "0x18218F040")]
	public static global::HELANFMPIHL<TSource1Enumerator, T, TSource2Enumerator, U> AONKBEKOOOL<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator GGKCBIKKEOA, in TSource2Enumerator MIPOPEENDCM) where TSource1Enumerator : MDCAECCDPAB, global::PALNBMKGDOF<T> where TSource2Enumerator : MDCAECCDPAB, global::PALNBMKGDOF<U>
	{
		return default(global::HELANFMPIHL<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CDOPIAMKDCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PALNBMKGDOF<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KGBJEDINCPD<T, TEnumerator> : global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::PALNBMKGDOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PALNBMKGDOF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	T JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface BJEDPLCNELI<T> : MDCAECCDPAB
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T CGONPJENCPN(int ACJHPBCLINB);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BPMELEBGMKL<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MDCAECCDPAB
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IFPMBEDBOED<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLOKHAJCDFP(in T LPEBOAHCFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FDPCMLIJCKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DKPOBNPICCF<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DAKHCNABDKM<T, TEnumerator> : global::FDPCMLIJCKP<T>, global::KGBJEDINCPD<T, TEnumerator>, global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::DKPOBNPICCF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DKPOBNPICCF<T> : global::PALNBMKGDOF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new T JLHGEOLLPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void IEFEGBJLOKK<T>(in T GAIKKANOHGI);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void DGEBOEOPBCE<T1, T2>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class AAILCGCNEGC
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x28A1A60", Offset = "0x28A0660", VA = "0x1828A1A60")]
	public static bool FFKMPHBOCCE<T, U>(this T HKEOACGCKDE, in U HLJJNKOAONN) where T : global::IFPMBEDBOED<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult NOOKCJJJEGF<T, out TResult>(in T GAIKKANOHGI);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult DLBOMPGLIMI<T1, T2, out TResult>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult NOLPOIBEPJB<T1, T2, T3, out TResult>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA, in T3 BLFACEDHHFP);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult EPDJNEBFCGO<T1, T2, T3, T4, out TResult>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA, in T3 BLFACEDHHFP, in T4 PJKHKEMKKLP);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult MIDMAPADJLP<T1, T2, T3, T4, T5, out TResult>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA, in T3 BLFACEDHHFP, in T4 PJKHKEMKKLP, in T5 PIJECGLLJHP);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult IOEPAKDICMJ<T, TResult>(in T GAIKKANOHGI);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult DPJNKANJGIC<T1, T2, TResult>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult JHGOEIDKABC<T1, T2, T3, TResult>(in T1 KANEFFJHBIE, in T2 FNHLONMDGLA, in T3 BLFACEDHHFP);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct DOFJAEIPDGL<T> : global::DAKHCNABDKM<T, global::DOFJAEIPDGL<T>.MAGKCNEGAME>, global::FDPCMLIJCKP<T>, global::KGBJEDINCPD<T, global::DOFJAEIPDGL<T>.MAGKCNEGAME>, global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, global::DOFJAEIPDGL<T>.MAGKCNEGAME>, IEnumerable<T>, IEnumerable, global::BJEDPLCNELI<T>, MDCAECCDPAB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct MAGKCNEGAME : MDCAECCDPAB, global::DKPOBNPICCF<T>, global::PALNBMKGDOF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] NCEPLELEBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int EOOCBGCOEDN;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JFMPCJJIJJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x22BDB20", Offset = "0x22BC720", VA = "0x1822BDB20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public T JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EC0", Offset = "0x22C3AC0", VA = "0x1822C4EC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private T BFOMKCAMHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x22C4DE0", Offset = "0x22C39E0", VA = "0x1822C4DE0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x22C4E70", Offset = "0x22C3A70", VA = "0x1822C4E70", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x22C4E70", Offset = "0x22C3A70", VA = "0x1822C4E70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA25A90", Offset = "0xA24690", VA = "0x180A25A90")]
		private MAGKCNEGAME(T[] HKEOACGCKDE, int BAOHKIGDOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x22C4D80", Offset = "0x22C3980", VA = "0x1822C4D80")]
		public static MAGKCNEGAME EBNJNBKPCHE(T[] HKEOACGCKDE)
		{
			return default(MAGKCNEGAME);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x22C4E30", Offset = "0x22C3A30", VA = "0x1822C4E30", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x22C4E60", Offset = "0x22C3A60", VA = "0x1822C4E60", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] FIKOAFDOPGP;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int JKHPADLGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x22BDB20", Offset = "0x22BC720", VA = "0x1822BDB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x22BD840", Offset = "0x22BC440", VA = "0x1822BD840", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22BDAE0", Offset = "0x22BC6E0", VA = "0x1822BDAE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x725470", Offset = "0x724070", VA = "0x180725470")]
	internal DOFJAEIPDGL(T[] MPENDCAONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x22BD920", Offset = "0x22BC520", VA = "0x1822BD920")]
	public static global::DOFJAEIPDGL<T> INHNAJHBIEJ()
	{
		return default(global::DOFJAEIPDGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x22BD7E0", Offset = "0x22BC3E0", VA = "0x1822BD7E0", Slot = "11")]
	public T CGONPJENCPN(int BAOHKIGDOBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22BD760", Offset = "0x22BC360", VA = "0x1822BD760")]
	public global::KFEBBDOOEJF<T> BLHDMFJMIMF()
	{
		return default(global::KFEBBDOOEJF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x22BD880", Offset = "0x22BC480", VA = "0x1822BD880", Slot = "8")]
	public MAGKCNEGAME GetEnumerator()
	{
		return default(MAGKCNEGAME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x22BD9E0", Offset = "0x22BC5E0", VA = "0x1822BD9E0", Slot = "5")]
	private global::DKPOBNPICCF<T> PCFIIBCAANL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x22BD9E0", Offset = "0x22BC5E0", VA = "0x1822BD9E0", Slot = "7")]
	private global::PALNBMKGDOF<T> JABGMOOHEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x22BD9E0", Offset = "0x22BC5E0", VA = "0x1822BD9E0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x22BD9E0", Offset = "0x22BC5E0", VA = "0x1822BD9E0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NBALKHPBKJM
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA2F0", Offset = "0x1DF8EF0", VA = "0x181DFA2F0")]
	public static global::DOFJAEIPDGL<T> EBNJNBKPCHE<T>(T[] MPENDCAONOC)
	{
		return default(global::DOFJAEIPDGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA350", Offset = "0x1DF8F50", VA = "0x181DFA350")]
	public static global::DOFJAEIPDGL<T> BJDMFKKLKDO<T>(this T[] HKEOACGCKDE)
	{
		return default(global::DOFJAEIPDGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA320", Offset = "0x1DF8F20", VA = "0x181DFA320")]
	public static global::DOFJAEIPDGL<T>.MAGKCNEGAME OJHBJCELKFC<T>(this T[] HKEOACGCKDE)
	{
		return default(global::DOFJAEIPDGL<T>.MAGKCNEGAME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA350", Offset = "0x1DF8F50", VA = "0x181DFA350")]
	public static global::DOFJAEIPDGL<T> BNGOJKJBENB<T>(this T[] HKEOACGCKDE)
	{
		return default(global::DOFJAEIPDGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct EEGBIKHIOHN<T, U> : global::DAKHCNABDKM<T, U>, global::FDPCMLIJCKP<T>, global::KGBJEDINCPD<T, U>, global::CDOPIAMKDCB<T>, global::BPMELEBGMKL<T, U>, IEnumerable<T>, IEnumerable where U : global::DKPOBNPICCF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U ECLOIFNNFOM;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x203F500", Offset = "0x203E100", VA = "0x18203F500")]
	internal EEGBIKHIOHN(in U CFPIDHGJGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "5")]
	private global::DKPOBNPICCF<T> PCFIIBCAANL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "7")]
	private global::PALNBMKGDOF<T> JABGMOOHEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2101310", Offset = "0x20FFF10", VA = "0x182101310", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JOEKINBECOC<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3EE0", Offset = "0x1DF2AE0", VA = "0x181DF3EE0")]
	public static global::EEGBIKHIOHN<T, U> EBNJNBKPCHE<U>(in U CFPIDHGJGJN) where U : global::DKPOBNPICCF<T>
	{
		return default(global::EEGBIKHIOHN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class AJHBJMCILHP<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> DPMMEIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> BOPCLAOBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IList<Internal> ANMBAEEBODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x665990", Offset = "0x664590", VA = "0x180665990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA33180", Offset = "0xA31D80", VA = "0x180A33180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public External LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2EE31D0", Offset = "0x2EE1DD0", VA = "0x182EE31D0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2EE3270", Offset = "0x2EE1E70", VA = "0x182EE3270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2EE3170", Offset = "0x2EE1D70", VA = "0x182EE3170", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2EE30E0", Offset = "0x2EE1CE0", VA = "0x182EE30E0")]
	public AJHBJMCILHP(Func<Internal, External> DPMMEIABOCJ, Func<External, Internal> BOPCLAOBNKL, bool EGMEIMCHLPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2DF0", Offset = "0x2EE19F0", VA = "0x182EE2DF0", Slot = "6")]
	public int IndexOf(External IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2A10", Offset = "0x2EE1610", VA = "0x182EE2A10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2A70", Offset = "0x2EE1670", VA = "0x182EE2A70", Slot = "13")]
	public bool Contains(External IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2B00", Offset = "0x2EE1700", VA = "0x182EE2B00", Slot = "14")]
	public void CopyTo(External[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2920", Offset = "0x2EE1520", VA = "0x182EE2920", Slot = "11")]
	public void Add(External IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2EE0", Offset = "0x2EE1AE0", VA = "0x182EE2EE0", Slot = "7")]
	public void Insert(int BAOHKIGDOBF, External IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2EE3050", Offset = "0x2EE1C50", VA = "0x182EE3050", Slot = "15")]
	public bool Remove(External IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2F80", Offset = "0x2EE1B80", VA = "0x182EE2F80", Slot = "8")]
	public void RemoveAt(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2D20", Offset = "0x2EE1920", VA = "0x182EE2D20", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3440", Offset = "0x1FC2040", VA = "0x181FC3440", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class DBJHKMBJGGI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> DPMMEIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IReadOnlyList<Internal> ANMBAEEBODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public External LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3205DA0", Offset = "0x32049A0", VA = "0x183205DA0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3205D40", Offset = "0x3204940", VA = "0x183205D40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
	public DBJHKMBJGGI(Func<Internal, External> DPMMEIABOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3205CF0", Offset = "0x32048F0", VA = "0x183205CF0")]
	public DBJHKMBJGGI(IReadOnlyList<Internal> EJNJGLOFIFF, Func<Internal, External> DPMMEIABOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3205AD0", Offset = "0x32046D0", VA = "0x183205AD0")]
	public void PMKOCOEJIKJ(External[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3205A00", Offset = "0x3204600", VA = "0x183205A00", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB3C0", Offset = "0x1FC9FC0", VA = "0x181FCB3C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class FEJLKMCEKBN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> EJNJGLOFIFF;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IReadOnlyList<Internal> ANMBAEEBODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public External LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C02980", Offset = "0x3C01580", VA = "0x183C02980", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C02920", Offset = "0x3C01520", VA = "0x183C02920", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
	public FEJLKMCEKBN(IReadOnlyList<Internal> EJNJGLOFIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C02650", Offset = "0x3C01250", VA = "0x183C02650")]
	public bool HNMPINFIMAB(External IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C026F0", Offset = "0x3C012F0", VA = "0x183C026F0")]
	public void PMKOCOEJIKJ(External[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C025E0", Offset = "0x3C011E0", VA = "0x183C025E0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3440", Offset = "0x1FC2040", VA = "0x181FC3440", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class CDDJHIHPOKI
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OHPMJMPNBMI(object[] IHGKCAPJCJE);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected CDDJHIHPOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class NHLOLANOPHD<T> : CDDJHIHPOKI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct GLOEOHPPBNH
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum HABDILMNCIM
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
		public HABDILMNCIM HCPDGKICMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T FHCMCNABNIM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int JCCOBFNEBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool POOCICDGPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool HPAEEPGKEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> CAEHLCCIMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<GLOEOHPPBNH> ELMGLLOMIAO;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool OHMAGAMBGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CD77D0", Offset = "0x2CD63D0", VA = "0x182CD77D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7F50", Offset = "0x2CD6B50", VA = "0x182CD7F50")]
	protected NHLOLANOPHD(bool HPAEEPGKEAG, bool POOCICDGPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7810", Offset = "0x2CD6410", VA = "0x182CD7810")]
	protected bool GNPPGDNJEMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7B90", Offset = "0x2CD6790", VA = "0x182CD7B90")]
	protected void MMJBKJGDMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7DA0", Offset = "0x2CD69A0", VA = "0x182CD7DA0")]
	protected void OBDIBDHMKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2E20000", Offset = "0x2E1EC00", VA = "0x182E20000")]
	private static void JDLODBCPFKL<U>(ref List<U> EJNJGLOFIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2CD78B0", Offset = "0x2CD64B0", VA = "0x182CD78B0", Slot = "5")]
	public void JNIPLPDFDNO(T FHCMCNABNIM, bool OLPICNFENLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7A30", Offset = "0x2CD6630", VA = "0x182CD7A30", Slot = "6")]
	public void MAHLOMNJIKK(T FHCMCNABNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7C70", Offset = "0x2CD6870", VA = "0x182CD7C70")]
	public void MNHBKLHOOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface BHMOEJLBHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class COJGPCFANME : global::NHLOLANOPHD<Action>, BHMOEJLBHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x575A900", Offset = "0x5759500", VA = "0x18575A900")]
	public COJGPCFANME(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x575A660", Offset = "0x5759260", VA = "0x18575A660")]
	public void CKIEOHHCEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x575A880", Offset = "0x5759480", VA = "0x18575A880", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x575A820", Offset = "0x5759420", VA = "0x18575A820")]
	public static COJGPCFANME DMKHOINDPJP(COJGPCFANME HHNNDPDCAGC, Action FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x575A600", Offset = "0x5759200", VA = "0x18575A600")]
	public static COJGPCFANME BNJDCMFIPDA(COJGPCFANME HHNNDPDCAGC, Action FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface NPMNOMBGGKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action<T> FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action<T> FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class MIPGLBJBDGJ<T> : global::NHLOLANOPHD<Action<T>>, global::NPMNOMBGGKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046D30", VA = "0x182048130")]
	public MIPGLBJBDGJ(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3909590", Offset = "0x3908190", VA = "0x183909590")]
	public void CKIEOHHCEAL(T JJBHDPAHMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x390A370", Offset = "0x3908F70", VA = "0x18390A370", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3236AC0", Offset = "0x32356C0", VA = "0x183236AC0")]
	public static global::MIPGLBJBDGJ<T> DMKHOINDPJP(global::MIPGLBJBDGJ<T> HHNNDPDCAGC, Action<T> FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3234C40", Offset = "0x3233840", VA = "0x183234C40")]
	public static global::MIPGLBJBDGJ<T> BNJDCMFIPDA(global::MIPGLBJBDGJ<T> HHNNDPDCAGC, Action<T> FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface MLDIDJJAEAL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action<T, U> FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action<T, U> FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class CBCMACGLNAI<T, U> : global::NHLOLANOPHD<Action<T, U>>, global::MLDIDJJAEAL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046D30", VA = "0x182048130")]
	public CBCMACGLNAI(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6FC0", Offset = "0x2CE5BC0", VA = "0x182CE6FC0")]
	public void CKIEOHHCEAL(T JJBHDPAHMPA, U GGFDCMIALOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2047270", Offset = "0x2045E70", VA = "0x182047270", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2047030", Offset = "0x2045C30", VA = "0x182047030")]
	public static global::CBCMACGLNAI<T, U> DMKHOINDPJP(global::CBCMACGLNAI<T, U> HHNNDPDCAGC, Action<T, U> FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x20457B0", Offset = "0x20443B0", VA = "0x1820457B0")]
	public static global::CBCMACGLNAI<T, U> BNJDCMFIPDA(global::CBCMACGLNAI<T, U> HHNNDPDCAGC, Action<T, U> FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HDHINHLKAOI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action<T, U, V> FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action<T, U, V> FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class NMKCBCGEJPK<T, U, V> : global::NHLOLANOPHD<Action<T, U, V>>, global::HDHINHLKAOI<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046D30", VA = "0x182048130")]
	public NMKCBCGEJPK(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDCFC0", Offset = "0x2CDBBC0", VA = "0x182CDCFC0")]
	public void CKIEOHHCEAL(T JJBHDPAHMPA, U GGFDCMIALOL, V MLEMCDNNOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD580", Offset = "0x2CDC180", VA = "0x182CDD580", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD4E0", Offset = "0x2CDC0E0", VA = "0x182CDD4E0")]
	public static global::NMKCBCGEJPK<T, U, V> DMKHOINDPJP(global::NMKCBCGEJPK<T, U, V> HHNNDPDCAGC, Action<T, U, V> FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB280", Offset = "0x2CD9E80", VA = "0x182CDB280")]
	public static global::NMKCBCGEJPK<T, U, V> BNJDCMFIPDA(global::NMKCBCGEJPK<T, U, V> HHNNDPDCAGC, Action<T, U, V> FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface IBKGHLKPPFC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action<T, U, V, W> FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action<T, U, V, W> FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class PDPMGABKKHE<T, U, V, W> : global::NHLOLANOPHD<Action<T, U, V, W>>, global::IBKGHLKPPFC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046D30", VA = "0x182048130")]
	public PDPMGABKKHE(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4629C00", Offset = "0x4628800", VA = "0x184629C00")]
	public void CKIEOHHCEAL(T JJBHDPAHMPA, U GGFDCMIALOL, V MLEMCDNNOBN, W EPICGAFMOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x462AF90", Offset = "0x4629B90", VA = "0x18462AF90", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x462A9E0", Offset = "0x46295E0", VA = "0x18462A9E0")]
	public static global::PDPMGABKKHE<T, U, V, W> DMKHOINDPJP(global::PDPMGABKKHE<T, U, V, W> HHNNDPDCAGC, Action<T, U, V, W> FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x46293A0", Offset = "0x4627FA0", VA = "0x1846293A0")]
	public static global::PDPMGABKKHE<T, U, V, W> BNJDCMFIPDA(global::PDPMGABKKHE<T, U, V, W> HHNNDPDCAGC, Action<T, U, V, W> FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface BPFAPDBDDCB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action<T, U, V, W, X> FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action<T, U, V, W, X> FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class GPAMFKMHFHC<T, U, V, W, X> : global::NHLOLANOPHD<Action<T, U, V, W, X>>, global::BPFAPDBDDCB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046D30", VA = "0x182048130")]
	public GPAMFKMHFHC(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x37320E0", Offset = "0x3730CE0", VA = "0x1837320E0")]
	public void CKIEOHHCEAL(T JJBHDPAHMPA, U GGFDCMIALOL, V MLEMCDNNOBN, W EPICGAFMOJC, X FPNCCNLMGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3732740", Offset = "0x3731340", VA = "0x183732740", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3732380", Offset = "0x3730F80", VA = "0x183732380")]
	public static global::GPAMFKMHFHC<T, U, V, W, X> DMKHOINDPJP(global::GPAMFKMHFHC<T, U, V, W, X> HHNNDPDCAGC, Action<T, U, V, W, X> FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3731D30", Offset = "0x3730930", VA = "0x183731D30")]
	public static global::GPAMFKMHFHC<T, U, V, W, X> BNJDCMFIPDA(global::GPAMFKMHFHC<T, U, V, W, X> HHNNDPDCAGC, Action<T, U, V, W, X> FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface JMBKHJAENPC<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIPLPDFDNO(Action<T, U, V, W, X, Y> FHCMCNABNIM, bool OLPICNFENLF = false);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHLOMNJIKK(Action<T, U, V, W, X, Y> FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class MFGJHMCGBMN<T, U, V, W, X, Y> : global::NHLOLANOPHD<Action<T, U, V, W, X, Y>>, global::JMBKHJAENPC<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2048130", Offset = "0x2046D30", VA = "0x182048130")]
	public MFGJHMCGBMN(bool HPAEEPGKEAG = false, bool POOCICDGPML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3907290", Offset = "0x3905E90", VA = "0x183907290")]
	public void CKIEOHHCEAL(T JJBHDPAHMPA, U GGFDCMIALOL, V MLEMCDNNOBN, W EPICGAFMOJC, X FPNCCNLMGCF, Y JNKDBNBEKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3907CB0", Offset = "0x39068B0", VA = "0x183907CB0", Slot = "4")]
	public override void OHPMJMPNBMI(object[] IHGKCAPJCJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3907550", Offset = "0x3906150", VA = "0x183907550")]
	public static global::MFGJHMCGBMN<T, U, V, W, X, Y> DMKHOINDPJP(global::MFGJHMCGBMN<T, U, V, W, X, Y> HHNNDPDCAGC, Action<T, U, V, W, X, Y> FHCMCNABNIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3906C20", Offset = "0x3905820", VA = "0x183906C20")]
	public static global::MFGJHMCGBMN<T, U, V, W, X, Y> BNJDCMFIPDA(global::MFGJHMCGBMN<T, U, V, W, X, Y> HHNNDPDCAGC, Action<T, U, V, W, X, Y> FHCMCNABNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class FDPPEDHLNDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct MKMIOKNHEFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::FDPPEDHLNDG<T> INGMPGLKMJH;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public T CFABBBMGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x3C07BD0", Offset = "0x3C067D0", VA = "0x183C07BD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3C07BA0", Offset = "0x3C067A0", VA = "0x183C07BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x725470", Offset = "0x724070", VA = "0x180725470")]
		public MKMIOKNHEFG(global::FDPPEDHLNDG<T> INGMPGLKMJH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct EFPAGOGLKJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<MKMIOKNHEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::FDPPEDHLNDG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6E70", Offset = "0x3BF5A70", VA = "0x183BF6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7210", Offset = "0x3BF5E10", VA = "0x183BF7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NLKIFFLLKCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<MKMIOKNHEFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::FDPPEDHLNDG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3C07BF0", Offset = "0x3C067F0", VA = "0x183C07BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7210", Offset = "0x3BF5E10", VA = "0x183BF7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim HGGOEJNIMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T PBHHBJLDODI;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int FHGBIHPLKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3C017B0", Offset = "0x3C003B0", VA = "0x183C017B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3C01E10", Offset = "0x3C00A10", VA = "0x183C01E10")]
	public FDPPEDHLNDG(in T PBHHBJLDODI, int EGLCJOFAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3C01EB0", Offset = "0x3C00AB0", VA = "0x183C01EB0")]
	public FDPPEDHLNDG(in T PBHHBJLDODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3C01DD0", Offset = "0x3C009D0", VA = "0x183C01DD0")]
	public MKMIOKNHEFG PGCPJCOJHOL()
	{
		return default(MKMIOKNHEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3C01D90", Offset = "0x3C00990", VA = "0x183C01D90")]
	public MKMIOKNHEFG PGCPJCOJHOL(CancellationToken NKLNCNDPFGD)
	{
		return default(MKMIOKNHEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3C01950", Offset = "0x3C00550", VA = "0x183C01950")]
	[AsyncStateMachine(typeof(global::FDPPEDHLNDG<>.EFPAGOGLKJN))]
	public Task<MKMIOKNHEFG> LLFMIALHIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3C017D0", Offset = "0x3C003D0", VA = "0x183C017D0")]
	[AsyncStateMachine(typeof(global::FDPPEDHLNDG<>.NLKIFFLLKCP))]
	public Task<MKMIOKNHEFG> LLFMIALHIHC(CancellationToken NKLNCNDPFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class DJFJPBKECHH
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x575AC50", Offset = "0x5759850", VA = "0x18575AC50")]
	public static global::FDPPEDHLNDG<JPLMCCNINHK> EBNJNBKPCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x575ACB0", Offset = "0x57598B0", VA = "0x18575ACB0")]
	public static global::FDPPEDHLNDG<JPLMCCNINHK> EBNJNBKPCHE(int EGLCJOFAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6740", Offset = "0x1CA5340", VA = "0x181CA6740")]
	public static global::FDPPEDHLNDG<T> EBNJNBKPCHE<T>(in T PBHHBJLDODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2194800", Offset = "0x2193400", VA = "0x182194800")]
	public static global::FDPPEDHLNDG<T> EBNJNBKPCHE<T>(in T PBHHBJLDODI, int EGLCJOFAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BFCIFNGJBLJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate Task<TResult> OAEDBHPDJLM(TRequest KCDJHPHCFKN, CancellationToken NKLNCNDPFGD);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public enum IOMCBKHNGFA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class AMPPGBAIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private const float DGBININENKE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TimeSpan GOJPPOKAOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int MOMOOEDALCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public IOMCBKHNGFA IDHAMLODENO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly AMPPGBAIAEJ OAMALNNIHFL;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float CMBKAPABMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x3B57420", Offset = "0x3B56020", VA = "0x183B57420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public TimeSpan BCPIMNFFMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3B575E0", Offset = "0x3B561E0", VA = "0x183B575E0")]
		public AMPPGBAIAEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private readonly struct AFHGDCPLOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly TRequest KCDJHPHCFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly CancellationToken NKLNCNDPFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly TaskCompletionSource<TResult> CLJNKKJMBPK;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3B573C0", Offset = "0x3B55FC0", VA = "0x183B573C0")]
		public AFHGDCPLOJN(TRequest KCDJHPHCFKN, TaskCompletionSource<TResult> CLJNKKJMBPK, CancellationToken NKLNCNDPFGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DLOKBJEOPMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public DLOKBJEOPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x29910B0", Offset = "0x298FCB0", VA = "0x1829910B0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct HMLDBMHNPPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public global::BFCIFNGJBLJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3B64360", Offset = "0x3B62F60", VA = "0x183B64360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct IKAPMJFJLHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public global::BFCIFNGJBLJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private AFHGDCPLOJN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3B652C0", Offset = "0x3B63EC0", VA = "0x183B652C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationTokenSource GOMJGDAMCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<AFHGDCPLOJN> OLOKEFPJEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly AMPPGBAIAEJ FGIKFFIFKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly OAEDBHPDJLM IFGMGHGBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Task KOMGPJEDOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int JKJHODABBCO;

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D200", Offset = "0x3B5BE00", VA = "0x183B5D200")]
	public BFCIFNGJBLJ(OAEDBHPDJLM IFGMGHGBMGP, [Optional] AMPPGBAIAEJ FGIKFFIFKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C930", Offset = "0x3B5B530", VA = "0x183B5C930")]
	public Task<TResult> PLKHDNFPOJC(TRequest KCDJHPHCFKN, CancellationToken NKLNCNDPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B9E0", Offset = "0x3B5A5E0", VA = "0x183B5B9E0")]
	private void DGCMCIFOOML(AFHGDCPLOJN KNFMMGEMFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C820", Offset = "0x3B5B420", VA = "0x183B5C820")]
	[AsyncStateMachine(typeof(global::BFCIFNGJBLJ<, >.HMLDBMHNPPH))]
	private Task OCIKOCIJIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C110", Offset = "0x3B5AD10", VA = "0x183B5C110")]
	private AFHGDCPLOJN LPPFFGEEAFL()
	{
		return default(AFHGDCPLOJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3B5BB50", Offset = "0x3B5A750", VA = "0x183B5BB50")]
	[AsyncStateMachine(typeof(global::BFCIFNGJBLJ<, >.IKAPMJFJLHF))]
	private Task FPMFAOBDKFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5B6E0", Offset = "0x3B5A2E0", VA = "0x183B5B6E0")]
	private void ALFAGDDMCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5BB10", Offset = "0x3B5A710", VA = "0x183B5BB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PKCIHDLOKCP<TKey, TVal> : global::BHCMEKKAJEN<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int DGLIAIBIFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal Dictionary<TKey, (TVal value, int size)> OFPLDKDNHEC;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	internal override int INFGNGEKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x46ECAF0", Offset = "0x46EB6F0", VA = "0x1846ECAF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	internal int DNONDJBGICK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x46EC7F0", Offset = "0x46EB3F0", VA = "0x1846EC7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public override int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x46EC6E0", Offset = "0x46EB2E0", VA = "0x1846EC6E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x46ECCB0", Offset = "0x46EB8B0", VA = "0x1846ECCB0")]
	public PKCIHDLOKCP(int EFOLPOOCAHO, [Optional] FLPHDFCCBFK KMIDKFMLNLG, [Optional] IEqualityComparer<TKey> GFNIJJPCOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x46ECB20", Offset = "0x46EB720", VA = "0x1846ECB20")]
	public void KGMBOPPGGKK(TKey IHPCMBAPNMC, TVal PDMPLJICJLE, bool IJFOLMLOEMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x46ECBC0", Offset = "0x46EB7C0", VA = "0x1846ECBC0")]
	public bool LIJLKCGEGCO(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x46EC740", Offset = "0x46EB340", VA = "0x1846EC740", Slot = "6")]
	public override bool EKDAOPLAPIM(TKey DBBOMNEIDGK, out TVal PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x46EC820", Offset = "0x46EB420", VA = "0x1846EC820")]
	public bool GFOMGKAENLF(TKey IHPCMBAPNMC, TVal PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x46EC5D0", Offset = "0x46EB1D0", VA = "0x1846EC5D0")]
	public bool BLGLIFDGPMG(TKey IHPCMBAPNMC, TVal PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x46ECC40", Offset = "0x46EB840", VA = "0x1846ECC40", Slot = "7")]
	public override void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x46ECA50", Offset = "0x46EB650", VA = "0x1846ECA50")]
	private bool HGBEDPHDAOM(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class BHCMEKKAJEN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate int FLPHDFCCBFK(TKey IHPCMBAPNMC, TVal PDMPLJICJLE);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class KACOMFKLNOL
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public TKey EBFNOOKFFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public TVal CFABBBMGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x712FE0", Offset = "0x711BE0", VA = "0x180712FE0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B78D0", VA = "0x1807B8CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int NODCJGOKMPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x7368D0", Offset = "0x7354D0", VA = "0x1807368D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x736900", Offset = "0x735500", VA = "0x180736900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public DateTime DNLPOAJHJDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x1987DD0", Offset = "0x19869D0", VA = "0x181987DD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3B65E60", Offset = "0x3B64A60", VA = "0x183B65E60")]
		public KACOMFKLNOL(TKey IHPCMBAPNMC, TVal OFLCHCPLOKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const int IOLENAGEGNK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<TKey, LinkedListNode<KACOMFKLNOL>> GLBLHHENKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly LinkedList<KACOMFKLNOL> BKNLOANNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	protected readonly FLPHDFCCBFK KMIDKFMLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly TimeSpan GJDPAIPHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly BFJGMFIIGJK MFIPNKELIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int LAOOIGNEAFF;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int DBOEJCGBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x73FCD0", Offset = "0x73E8D0", VA = "0x18073FCD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private bool PNHBFLNHBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3B5EF30", Offset = "0x3B5DB30", VA = "0x183B5EF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal virtual int INFGNGEKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x73FCE0", Offset = "0x73E8E0", VA = "0x18073FCE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private int GCKMDOIKFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x21F7D80", Offset = "0x21F6980", VA = "0x1821F7D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public virtual int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3B80", Offset = "0x1FC2780", VA = "0x181FC3B80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IEnumerable<TKey> LLBAEOGIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FE40", Offset = "0x3B5EA40", VA = "0x183B5FE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public TVal LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3056B00", Offset = "0x3055700", VA = "0x183056B00")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3314CB0", Offset = "0x33138B0", VA = "0x183314CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3B60060", Offset = "0x3B5EC60", VA = "0x183B60060")]
	public BHCMEKKAJEN(int EFOLPOOCAHO, [Optional] FLPHDFCCBFK KMIDKFMLNLG, [Optional] IEqualityComparer<TKey> GFNIJJPCOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3B60130", Offset = "0x3B5ED30", VA = "0x183B60130")]
	public BHCMEKKAJEN(TimeSpan GJDPAIPHFMO, [Optional] IEqualityComparer<TKey> GFNIJJPCOEK, [Optional] BFJGMFIIGJK MFIPNKELIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3B60180", Offset = "0x3B5ED80", VA = "0x183B60180")]
	public BHCMEKKAJEN(int EFOLPOOCAHO, TimeSpan GJDPAIPHFMO, [Optional] IEqualityComparer<TKey> GFNIJJPCOEK, [Optional] BFJGMFIIGJK MFIPNKELIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3B604E0", Offset = "0x3B5F0E0", VA = "0x183B604E0")]
	public BHCMEKKAJEN(int EFOLPOOCAHO, FLPHDFCCBFK KMIDKFMLNLG, TimeSpan GJDPAIPHFMO, [Optional] IEqualityComparer<TKey> GFNIJJPCOEK, [Optional] BFJGMFIIGJK MFIPNKELIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F140", Offset = "0x3B5DD40", VA = "0x183B5F140")]
	public void HMHPDIFKMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FA50", Offset = "0x3B5E650", VA = "0x183B5FA50")]
	public void KCACFLLCKKN(TKey IHPCMBAPNMC, TVal PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FC70", Offset = "0x3B5E870", VA = "0x183B5FC70")]
	public bool MAHLOMNJIKK(TKey IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FBC0", Offset = "0x3B5E7C0", VA = "0x183B5FBC0")]
	private TVal LBHEOGGFILM(TKey DBBOMNEIDGK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3B5EC80", Offset = "0x3B5D880", VA = "0x183B5EC80", Slot = "6")]
	public virtual bool EKDAOPLAPIM(TKey DBBOMNEIDGK, out TVal PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FDD0", Offset = "0x3B5E9D0", VA = "0x183B5FDD0", Slot = "7")]
	public virtual void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5EFC0", Offset = "0x3B5DBC0", VA = "0x183B5EFC0")]
	private bool HFJJLILPHGN(KACOMFKLNOL HDMEFCCGMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3B5EA50", Offset = "0x3B5D650", VA = "0x183B5EA50")]
	private void BICPJNOHHJG(LinkedListNode<KACOMFKLNOL> HGHFJAHGPMO, TVal GCBBKONDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F480", Offset = "0x3B5E080", VA = "0x183B5F480")]
	private void JOMHIKHKDFI(TKey IHPCMBAPNMC, TVal PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F7F0", Offset = "0x3B5E3F0", VA = "0x183B5F7F0")]
	private void KBKPDFDCHDL(KACOMFKLNOL HDMEFCCGMJF, TVal GCBBKONDMHJ, int IGPJCKOIDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DefaultMember("Item")]
public class MNOMHKOLAOI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly List<T> EJNJGLOFIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private HashSet<T> IJLMNGEDNIO;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x29910B0", Offset = "0x298FCB0", VA = "0x1829910B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool BBKIICODHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2F78750", Offset = "0x2F77350", VA = "0x182F78750", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3315AC0", Offset = "0x33146C0", VA = "0x183315AC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x24633D0", Offset = "0x2461FD0", VA = "0x1824633D0", Slot = "11")]
	public void Add(T IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x3315410", Offset = "0x3314010", VA = "0x183315410")]
	public bool IEGCNIFBCNH(T IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x3315810", Offset = "0x3314410", VA = "0x183315810", Slot = "15")]
	public bool Remove(T IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x33152E0", Offset = "0x3313EE0", VA = "0x1833152E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE410", Offset = "0x1FBD010", VA = "0x181FBE410", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x3315250", Offset = "0x3313E50", VA = "0x183315250", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x22BA830", Offset = "0x22B9430", VA = "0x1822BA830", Slot = "13")]
	public bool Contains(T IPBHEMHOEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2F78330", Offset = "0x2F76F30", VA = "0x182F78330", Slot = "14")]
	public void CopyTo(T[] MPENDCAONOC, int KLKFOFJLECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x33154B0", Offset = "0x33140B0", VA = "0x1833154B0", Slot = "6")]
	public int IndexOf(T IPBHEMHOEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x33154E0", Offset = "0x33140E0", VA = "0x1833154E0", Slot = "7")]
	public void Insert(int BAOHKIGDOBF, T IPBHEMHOEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3315740", Offset = "0x3314340", VA = "0x183315740", Slot = "8")]
	public void RemoveAt(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x33150B0", Offset = "0x3313CB0", VA = "0x1833150B0")]
	public void ADGOOIDKDMF(Predicate<T> EGEEADFIFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x33152B0", Offset = "0x3313EB0", VA = "0x1833152B0")]
	public void DHLDBBGKHEA(Comparison<T> OPIGDEIGPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3315920", Offset = "0x3314520", VA = "0x183315920")]
	public MNOMHKOLAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class NFGEJJHEJEN
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x575E960", Offset = "0x575D560", VA = "0x18575E960")]
	public static Vector3 DIEHLKNAKIC(this GameObject JPIPKHMPCNE, float MJLFIODCFLJ)
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
			[Cpp2IlInjected.Address(RVA = "0x1F61A60", Offset = "0x1F60660", VA = "0x181F61A60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5761D70", Offset = "0x5760970", VA = "0x185761D70")]
		public SerializedGuid(in Guid EDJALHGEENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5761C20", Offset = "0x5760820", VA = "0x185761C20")]
		public static SerializedGuid ONMDBOLJECA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5761B10", Offset = "0x5760710", VA = "0x185761B10")]
		public static SerializedGuid NBGIIGJAEHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x5761B90", Offset = "0x5760790", VA = "0x185761B90")]
		public bool NHGANEKMKNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5761D40", Offset = "0x5760940", VA = "0x185761D40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5761CA0", Offset = "0x57608A0", VA = "0x185761CA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5761A80", Offset = "0x5760680", VA = "0x185761A80")]
		public bool KMDDCOFIBJP(in Guid EDJALHGEENI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x57618F0", Offset = "0x57604F0", VA = "0x1857618F0", Slot = "7")]
		public bool Equals(SerializedGuid LPEBOAHCFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5761990", Offset = "0x5760590", VA = "0x185761990", Slot = "0")]
		public override bool Equals(object HLJJNKOAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5761A70", Offset = "0x5760670", VA = "0x185761A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x57618C0", Offset = "0x57604C0", VA = "0x1857618C0", Slot = "6")]
		public int CompareTo(SerializedGuid LPEBOAHCFNN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GPNJIJFDLOO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly Type NPODLGGIGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string JIBCBLBCBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly bool PGJOIKJOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly bool NNLPNIEDCEH;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x575CE10", Offset = "0x575BA10", VA = "0x18575CE10")]
	public GPNJIJFDLOO(Type JJJLJJKPEGH, string LGFEFBAMBCO, bool DGPKBEDDPEK = false, bool DDHPJEOPNFF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface FHBAHIGNCNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface DJJGBGKPDJJ<T> : FHBAHIGNCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool HIPEBEJNEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string CIPNGGOKBIM
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
	global::DJJGBGKPDJJ<T> DNAMGCPAJPP(Action<T> DGHIFNIOIPH);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DJJGBGKPDJJ<T> GILPODDAGDH(Action<T> DGHIFNIOIPH);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DJJGBGKPDJJ<T> OPJNJGGFGEN(Action<T, T> JFPODMHKMHL);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DJJGBGKPDJJ<T> FCEIBNIEHPC(Action<T, T> JFPODMHKMHL);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DJJGBGKPDJJ<T> LGIAKBMPEOB(Action<string> IBAEDMOEIND);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DJJGBGKPDJJ<T> ACOCBBCBFHK(Action<string> IBAEDMOEIND);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OCLKONMGFGL<T> : global::DJJGBGKPDJJ<T>, FHBAHIGNCNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private global::CBCMACGLNAI<T, T> FEIOJICMMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private global::MIPGLBJBDGJ<T> PDAGJLFEIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::MIPGLBJBDGJ<string> ALFOFAPLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private string PBNGOGFENBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private T FADBLLIMALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool HMIAGJBHNMP;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x241E230", Offset = "0x241CE30", VA = "0x18241E230", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool HIPEBEJNEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6668B0", Offset = "0x6654B0", VA = "0x1806668B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public string CIPNGGOKBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x27D4C90", Offset = "0x27D3890", VA = "0x1827D4C90", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A53F40", Offset = "0x2A52B40", VA = "0x182A53F40")]
	private void FIINOFGKAGM(T IBEPFEBNHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A53DC0", Offset = "0x2A529C0", VA = "0x182A53DC0")]
	private void CEMODIENMBB(string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A53FE0", Offset = "0x2A52BE0", VA = "0x182A53FE0")]
	public void GGCMIAHONCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A54170", Offset = "0x2A52D70", VA = "0x182A54170", Slot = "6")]
	public global::DJJGBGKPDJJ<T> OPJNJGGFGEN(Action<T, T> JFPODMHKMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A53EF0", Offset = "0x2A52AF0", VA = "0x182A53EF0", Slot = "7")]
	public global::DJJGBGKPDJJ<T> FCEIBNIEHPC(Action<T, T> JFPODMHKMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A53E60", Offset = "0x2A52A60", VA = "0x182A53E60", Slot = "4")]
	public global::DJJGBGKPDJJ<T> DNAMGCPAJPP(Action<T> JFPODMHKMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A54090", Offset = "0x2A52C90", VA = "0x182A54090", Slot = "5")]
	public global::DJJGBGKPDJJ<T> GILPODDAGDH(Action<T> DGHIFNIOIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A540E0", Offset = "0x2A52CE0", VA = "0x182A540E0", Slot = "8")]
	public global::DJJGBGKPDJJ<T> LGIAKBMPEOB(Action<string> IBAEDMOEIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A53D50", Offset = "0x2A52950", VA = "0x182A53D50", Slot = "9")]
	public global::DJJGBGKPDJJ<T> ACOCBBCBFHK(Action<string> IBAEDMOEIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A541C0", Offset = "0x2A52DC0", VA = "0x182A541C0")]
	public OCLKONMGFGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class CKFHNHAEHJP
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class LADJDGFDEAC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public global::DJJGBGKPDJJ<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::DDFBBDKIGCD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public LADJDGFDEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x235BB40", Offset = "0x235A740", VA = "0x18235BB40")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4FF0", Offset = "0x1DF3BF0", VA = "0x181DF4FF0")]
	public static global::OEKDNOIOMEB<T> ELNOFIGJJCO<T>(this global::DJJGBGKPDJJ<T> MOEAPJPBLLE, Action<T> HGFJMMOGKFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class BPGDCCMFEJP<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct MEEBCCLKAAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly long GHEBKHBNNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly long BONPBAMKKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly int BHELKHCNPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly int KKFHAKEFEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly bool DJBEKLMAEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string MMEAHFBJBJM;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x204D430", Offset = "0x204C030", VA = "0x18204D430")]
		public MEEBCCLKAAG(long GHEBKHBNNDI, int BHELKHCNPOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x204D400", Offset = "0x204C000", VA = "0x18204D400")]
		public MEEBCCLKAAG(long GHEBKHBNNDI, long BONPBAMKKHA, int BHELKHCNPOD, int KKFHAKEFEPB, bool DJBEKLMAEHF, string MMEAHFBJBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x204D260", Offset = "0x204BE60", VA = "0x18204D260")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void DMFDLGCBELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x204D3B0", Offset = "0x204BFB0", VA = "0x18204D3B0")]
		public int JHBDLABIOAK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x204D2D0", Offset = "0x204BED0", VA = "0x18204D2D0")]
		public int HHJAFHOMMOP(int GNOAEFBFCAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x204D1F0", Offset = "0x204BDF0", VA = "0x18204D1F0")]
		public double CKNLMCHCEDO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x204D2F0", Offset = "0x204BEF0", VA = "0x18204D2F0")]
		public MEEBCCLKAAG IDDFDJEMPJO(long BONPBAMKKHA, int KKFHAKEFEPB)
		{
			return default(MEEBCCLKAAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class JPHACOIJIFD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly TKey EBFNOOKFFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly global::BPGDCCMFEJP<TKey> OPOGIBGMOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<JPHACOIJIFD> FLHBMIGDPII;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string FKIMNFEGOKF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x204C860", Offset = "0x204B460", VA = "0x18204C860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x204C620", Offset = "0x204B220", VA = "0x18204C620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<JPHACOIJIFD> DOOOFADIIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x204C840", Offset = "0x204B440", VA = "0x18204C840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public MEEBCCLKAAG OLJOHLCIMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xFF2B40", Offset = "0xFF1740", VA = "0x180FF2B40")]
			[CompilerGenerated]
			get
			{
				return default(MEEBCCLKAAG);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x204C810", Offset = "0x204B410", VA = "0x18204C810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x204CAA0", Offset = "0x204B6A0", VA = "0x18204CAA0")]
		internal JPHACOIJIFD(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE, TKey IHPCMBAPNMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x204C990", Offset = "0x204B590", VA = "0x18204C990")]
		public JPHACOIJIFD PIEEKIEKMBF(TKey IHPCMBAPNMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x204C890", Offset = "0x204B490", VA = "0x18204C890")]
		public void OFCAGIGIBJH(TKey IHPCMBAPNMC, Action<JPHACOIJIFD> FHCMCNABNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1D8E160", Offset = "0x1D8CD60", VA = "0x181D8E160")]
		public T OFCAGIGIBJH<T>(TKey IHPCMBAPNMC, Func<JPHACOIJIFD, T> FOANONGBKAC)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2A60", Offset = "0x1FA1660", VA = "0x181FA2A60")]
		[AsyncStateMachine(typeof(ANHJGBCKBMM))]
		public Task<T> KNBGGICGMJN<T>(TKey IHPCMBAPNMC, Func<JPHACOIJIFD, Task<T>> FOANONGBKAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x204C650", Offset = "0x204B250", VA = "0x18204C650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class BIJFKAMELEG : IEnumerable<(TKey, List<TKey>, MEEBCCLKAAG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MEEBCCLKAAG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private (TKey key, List<TKey> path, MEEBCCLKAAG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public global::BPGDCCMFEJP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private IEnumerator<(TKey key, List<TKey> path, MEEBCCLKAAG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		private (TKey, List<TKey>, MEEBCCLKAAG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x203DC40", Offset = "0x203C840", VA = "0x18203DC40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MEEBCCLKAAG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x203DCC0", Offset = "0x203C8C0", VA = "0x18203DCC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x203DDF0", Offset = "0x203C9F0", VA = "0x18203DDF0")]
		[DebuggerHidden]
		public BIJFKAMELEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x203DD20", Offset = "0x203C920", VA = "0x18203DD20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x203D910", Offset = "0x203C510", VA = "0x18203D910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x203DDA0", Offset = "0x203C9A0", VA = "0x18203DDA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x203DC70", Offset = "0x203C870", VA = "0x18203DC70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x203DB80", Offset = "0x203C780", VA = "0x18203DB80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MEEBCCLKAAG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8B00", Offset = "0x1FC7700", VA = "0x181FC8B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class CDENENOLAJL : IEnumerable<(TKey, List<TKey>, MEEBCCLKAAG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, MEEBCCLKAAG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private (TKey key, List<TKey> path, MEEBCCLKAAG timerEntry) <>2__current;

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
		private JPHACOIJIFD timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JPHACOIJIFD <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::BPGDCCMFEJP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IEnumerator<JPHACOIJIFD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private IEnumerator<(TKey key, List<TKey> path, MEEBCCLKAAG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private (TKey, List<TKey>, MEEBCCLKAAG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x203DC40", Offset = "0x203C840", VA = "0x18203DC40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, MEEBCCLKAAG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x20487F0", Offset = "0x20473F0", VA = "0x1820487F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x203DDF0", Offset = "0x203C9F0", VA = "0x18203DDF0")]
		[DebuggerHidden]
		public CDENENOLAJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2048850", Offset = "0x2047450", VA = "0x182048850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2048160", Offset = "0x2046D60", VA = "0x182048160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2048920", Offset = "0x2047520", VA = "0x182048920")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2048970", Offset = "0x2047570", VA = "0x182048970")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x20487A0", Offset = "0x20473A0", VA = "0x1820487A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x20486A0", Offset = "0x20472A0", VA = "0x1820486A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, MEEBCCLKAAG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2048770", Offset = "0x2047370", VA = "0x182048770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Action<TKey, MEEBCCLKAAG> KPHMJCKOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action<TKey, MEEBCCLKAAG> EIIDMAHFGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<global::BPGDCCMFEJP<TKey>> KLMDAMJNEKL;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private const string KDCPCOJFAAL = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly JPHACOIJIFD OGLDAEGHMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool KCKLADPBJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int ECEEKAABNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Stopwatch OBKMJENDMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public readonly int DOCFMLLHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private string IKBJIFAMECF;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JPHACOIJIFD HHBAHMDMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	[NotNull]
	public string FKIMNFEGOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x637130", Offset = "0x635D30", VA = "0x180637130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2044240", Offset = "0x2042E40", VA = "0x182044240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public long DKKNJBIFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2044360", Offset = "0x2042F60", VA = "0x182044360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int JCHNBIGKPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x20442A0", Offset = "0x2042EA0", VA = "0x1820442A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x20445B0", Offset = "0x20431B0", VA = "0x1820445B0")]
	public BPGDCCMFEJP(TKey EHAABOJIOOM, [Optional] int? BHELKHCNPOD, [Optional][CanBeNull] Stopwatch OBKMJENDMKD, [Optional] Action<TKey, MEEBCCLKAAG> KPHMJCKOJKF, [Optional] Action<TKey, MEEBCCLKAAG> EIIDMAHFGHA, [Optional] Action<global::BPGDCCMFEJP<TKey>> KLMDAMJNEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x20442D0", Offset = "0x2042ED0", VA = "0x1820442D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2044380", Offset = "0x2042F80", VA = "0x182044380")]
	public void HBOKHJIOCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x20443A0", Offset = "0x2042FA0", VA = "0x1820443A0")]
	public void HFHGIIEIPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2044490", Offset = "0x2043090", VA = "0x182044490")]
	[IteratorStateMachine(typeof(global::BPGDCCMFEJP<>.BIJFKAMELEG))]
	public IEnumerable<(TKey, List<TKey>, MEEBCCLKAAG)> KDPDDPEIOMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x20443C0", Offset = "0x2042FC0", VA = "0x1820443C0")]
	[IteratorStateMachine(typeof(global::BPGDCCMFEJP<>.CDENENOLAJL))]
	private IEnumerable<(TKey, List<TKey>, MEEBCCLKAAG)> KDPDDPEIOMM(List<TKey> BMKGDMDCJNI, JPHACOIJIFD AHHJMMCBJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2044520", Offset = "0x2043120", VA = "0x182044520")]
	private (long, int) NJEABOIEGCA()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class DDKKHCDBEPI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GKGOJDKKBDE(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	protected DDKKHCDBEPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class BEFDOBFGLAI<TKey> : global::DDKKHCDBEPI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public delegate string PPIABIGEJFP(TKey IHPCMBAPNMC);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3B591B0", Offset = "0x3B57DB0", VA = "0x183B591B0")]
	protected string ABIKLBCPFKM(double GIIPOMBBLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x3B59210", Offset = "0x3B57E10", VA = "0x183B59210")]
	protected string DOPDIDEEFDP(int DDFOLOIHJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3B59260", Offset = "0x3B57E60", VA = "0x183B59260")]
	private static string FDLKNLGKMIB(TKey IHPCMBAPNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3B593C0", Offset = "0x3B57FC0", VA = "0x183B593C0", Slot = "4")]
	public override string GKGOJDKKBDE(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3B592A0", Offset = "0x3B57EA0", VA = "0x183B592A0")]
	public string GKGOJDKKBDE(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE, [NotNull] PPIABIGEJFP PPKICDNFPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string CLIJHHAENBN(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE, [NotNull] PPIABIGEJFP PPKICDNFPFG);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3440", Offset = "0x1FC2040", VA = "0x181FC3440")]
	protected BEFDOBFGLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class BKMIFAAIMGL<TKey> : global::DDKKHCDBEPI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate string BNFLNMPIFDP(TKey IHPCMBAPNMC);

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const int NABKLILBLML = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string POKJAJBOHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly double KEGLNLNOJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly bool NFAGNNFFKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int HOCBBAPDAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly ISet<string> OANPLPILNHB;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3B63B00", Offset = "0x3B62700", VA = "0x183B63B00")]
	private static string FDLKNLGKMIB(TKey IHPCMBAPNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3B64240", Offset = "0x3B62E40", VA = "0x183B64240")]
	public BKMIFAAIMGL(string POKJAJBOHJB = "F2", double KEGLNLNOJDB = double.MaxValue, bool NFAGNNFFKAM = false, int HOCBBAPDAAN = int.MaxValue, [Optional] ISet<string> OANPLPILNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3B63FE0", Offset = "0x3B62BE0", VA = "0x183B63FE0", Slot = "4")]
	public override Dictionary<string, string> GKGOJDKKBDE(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3B638C0", Offset = "0x3B624C0", VA = "0x183B638C0")]
	private bool CHGCLOMAGNI(string LBCNJFFDMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3B63B40", Offset = "0x3B62740", VA = "0x183B63B40")]
	public Dictionary<string, string> GKGOJDKKBDE(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE, BNFLNMPIFDP PPKICDNFPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3B64090", Offset = "0x3B62C90", VA = "0x183B64090")]
	private string NOOGHDOGCFO(StringBuilder NLNAEOLENID, List<TKey> NBBGGGFNENK, BNFLNMPIFDP PPKICDNFPFG, bool NCGDCJKBICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3B639A0", Offset = "0x3B625A0", VA = "0x183B639A0")]
	private static void CLAJAJIMAOA(StringBuilder APBKHDLFDED, string NFNFMNMHHCI, bool IAHBBCNGHMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class PEKMCEECLBB<TKey> : global::BEFDOBFGLAI<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct BANMKJJLALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public PPIABIGEJFP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static global::PEKMCEECLBB<TKey> PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int KKEGJCAMGAM = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly string[] PPJAEPOIMEG;

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x462CF30", Offset = "0x462BB30", VA = "0x18462CF30")]
	private PEKMCEECLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x462BE80", Offset = "0x462AA80", VA = "0x18462BE80", Slot = "5")]
	protected override string CLIJHHAENBN(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE, PPIABIGEJFP PPKICDNFPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x462CD50", Offset = "0x462B950", VA = "0x18462CD50")]
	[CompilerGenerated]
	internal static string INDBJDHBJHL(string MOHKEELMDMO, TKey IHPCMBAPNMC, ref BANMKJJLALH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class OBDJFHBHJOM<TKey> : global::BEFDOBFGLAI<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class DGBFEIIADOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public PPIABIGEJFP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public DGBFEIIADOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x22C4BB0", Offset = "0x22C37B0", VA = "0x1822C4BB0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2A52C60", Offset = "0x2A51860", VA = "0x182A52C60", Slot = "5")]
	protected override string CLIJHHAENBN(global::BPGDCCMFEJP<TKey> OPOGIBGMOJE, PPIABIGEJFP PPKICDNFPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2A533B0", Offset = "0x2A51FB0", VA = "0x182A533B0")]
	public OBDJFHBHJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class LLNHLDENBNO : global::BPGDCCMFEJP<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class CPFOPDJMOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Action<LLNHLDENBNO> callback;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public CPFOPDJMOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x575A960", Offset = "0x5759560", VA = "0x18575A960")]
		internal void <Wrap>b__0(global::BPGDCCMFEJP<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x575DB20", Offset = "0x575C720", VA = "0x18575DB20")]
	public LLNHLDENBNO([Optional] string BOIJMENDJGF, [Optional] int? BHELKHCNPOD, [Optional] Stopwatch OBKMJENDMKD, [Optional] Action<string, MEEBCCLKAAG> KPHMJCKOJKF, [Optional] Action<string, MEEBCCLKAAG> EIIDMAHFGHA, [Optional] Action<LLNHLDENBNO> KLMDAMJNEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x575DA60", Offset = "0x575C660", VA = "0x18575DA60")]
	private static Action<global::BPGDCCMFEJP<string>> OFCAGIGIBJH(Action<LLNHLDENBNO> HGFJMMOGKFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public abstract class BFJGMFIIGJK
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private class NLNNEAKLPGE : BFJGMFIIGJK
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public static BFJGMFIIGJK PPLIIACIKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x575EC40", Offset = "0x575D840", VA = "0x18575EC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override DateTime KAPIMKBEMGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x575EBF0", Offset = "0x575D7F0", VA = "0x18575EBF0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override float PFJEFBHGPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x575ECA0", Offset = "0x575D8A0", VA = "0x18575ECA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x575ED50", Offset = "0x575D950", VA = "0x18575ED50")]
		public NLNNEAKLPGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static BFJGMFIIGJK LJFGCCCLPLG;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public static BFJGMFIIGJK OAMALNNIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x575A3E0", Offset = "0x5758FE0", VA = "0x18575A3E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public abstract DateTime KAPIMKBEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public abstract float PFJEFBHGPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	protected BFJGMFIIGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class IPEPCGKKMCG : global::PLDEFKANDOF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x575D2B0", Offset = "0x575BEB0", VA = "0x18575D2B0")]
	public IPEPCGKKMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class PLDEFKANDOF<T> : global::GHDPIMKJGAM<T>, KMPLGOAIIAG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task<T> HIBNLBJEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Task HHCAKFODMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F120", Offset = "0x1E1DD20", VA = "0x181E1F120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public global::OEKDNOIOMEB<T> KDCKFPPCMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private IHEBICEMHFG JBIBLHNAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1E21F90", Offset = "0x1E20B90", VA = "0x181E21F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDDA0", Offset = "0x2FEC9A0", VA = "0x182FEDDA0")]
	public PLDEFKANDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class LECLMHHGJKN : global::ACNMNKNIIDJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x575DA10", Offset = "0x575C610", VA = "0x18575DA10")]
	public LECLMHHGJKN(Exception NDHKDNBHBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class ACNMNKNIIDJ<T> : global::GHDPIMKJGAM<T>, KMPLGOAIIAG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Task<T> HIBNLBJEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Task HHCAKFODMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F120", Offset = "0x1E1DD20", VA = "0x181E1F120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public global::OEKDNOIOMEB<T> KDCKFPPCMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private IHEBICEMHFG JBIBLHNAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1E21F90", Offset = "0x1E20B90", VA = "0x181E21F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x44AA560", Offset = "0x44A9160", VA = "0x1844AA560")]
	public ACNMNKNIIDJ(Exception NDHKDNBHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface KMPLGOAIIAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	[NotNull]
	Task HIBNLBJEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	[NotNull]
	IHEBICEMHFG KDCKFPPCMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface GHDPIMKJGAM<T> : KMPLGOAIIAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	[NotNull]
	new Task<T> HIBNLBJEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[NotNull]
	new global::OEKDNOIOMEB<T> KDCKFPPCMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class FAMPLBHPEAE<TTask, T> : global::GHDPIMKJGAM<T>, KMPLGOAIIAG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class GLLFKGLHLEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public global::FAMPLBHPEAE<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public GLLFKGLHLEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static bool AAJOOOEHEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly Task<T> MHPDMHIEPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected readonly CancellationTokenSource LJBAPHOAMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool KCKLADPBJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private SynchronizationContext JFNHANIOFCM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Task<T> HIBNLBJEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private Task HHCAKFODMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public global::OEKDNOIOMEB<T> KDCKFPPCMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private IHEBICEMHFG JBIBLHNAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1FBFC90", Offset = "0x1FBE890", VA = "0x181FBFC90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool GKDFMIBKEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x665990", Offset = "0x664590", VA = "0x180665990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9950", Offset = "0x3BF8550", VA = "0x183BF9950")]
	static FAMPLBHPEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9DE0", Offset = "0x3BF89E0", VA = "0x183BF9DE0")]
	protected FAMPLBHPEAE(TTask MHPDMHIEPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9530", Offset = "0x3BF8130", VA = "0x183BF9530", Slot = "1")]
	~FAMPLBHPEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9500", Offset = "0x3BF8100", VA = "0x183BF9500", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9670", Offset = "0x3BF8270", VA = "0x183BF9670")]
	private void KHFNNCAMANL(bool APFLHHLNNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CFKNNOHKLOL(TTask MLNLMDBANON);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CNONPCOHGAD();

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3BF94B0", Offset = "0x3BF80B0", VA = "0x183BF94B0")]
	[CompilerGenerated]
	private void DLJODNMBPEL(object HPLLIJEIOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface CJPNFOACJBI
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	float BJCBPKBPBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CPLHPHKOJAF FHBKOGHHAFM;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class OMHNGAFFBMM : CJPNFOACJBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public readonly struct KDBBBLHOOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public readonly float LGIIPGLLNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly float LEDNEIIJEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		internal readonly bool MLPCDHELIGA;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public float NODCJGOKMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x575D770", Offset = "0x575C370", VA = "0x18575D770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x575D8E0", Offset = "0x575C4E0", VA = "0x18575D8E0")]
		public KDBBBLHOOBC(float DJHHNCHEKKB, float HDGDBPHDMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x575D780", Offset = "0x575C380", VA = "0x18575D780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class NLOHENCBBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public OMHNGAFFBMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public NLOHENCBBKJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly int EFOLPOOCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private int IKELGNPNPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly CJPNFOACJBI[] BJLHDFDFNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly CPLHPHKOJAF[] LLALMPDIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly KDBBBLHOOBC[] JBMCFDMBBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private KDBBBLHOOBC BOPJAMKDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly OMMEACPJNAF ELHMOLMEMJG;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public KDBBBLHOOBC BEKOLGIEEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x243D6F0", Offset = "0x243C2F0", VA = "0x18243D6F0")]
		get
		{
			return default(KDBBBLHOOBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float BJCBPKBPBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x575F3D0", Offset = "0x575DFD0", VA = "0x18575F3D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CPLHPHKOJAF FHBKOGHHAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x575F5D0", Offset = "0x575E1D0", VA = "0x18575F5D0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x575F310", Offset = "0x575DF10", VA = "0x18575F310", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x575FB40", Offset = "0x575E740", VA = "0x18575FB40")]
	public OMHNGAFFBMM(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x575F690", Offset = "0x575E290", VA = "0x18575F690")]
	public OMMEACPJNAF LEGBFKJGEHJ(KDBBBLHOOBC JCAANKCENCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x575F710", Offset = "0x575E310", VA = "0x18575F710")]
	public void OGEHBIANDGM(CJPNFOACJBI CBDAHPMFFEE, [Optional] KDBBBLHOOBC DCIHGPNFHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x575FAF0", Offset = "0x575E6F0", VA = "0x18575FAF0")]
	internal int OIPMBJNKOEM(CJPNFOACJBI CBKDFINKDNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x575F580", Offset = "0x575E180", VA = "0x18575F580")]
	internal KDBBBLHOOBC GNMIBKKMFEL(int BAOHKIGDOBF)
	{
		return default(KDBBBLHOOBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x575F3F0", Offset = "0x575DFF0", VA = "0x18575F3F0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public delegate void CPLHPHKOJAF(float JIGFGNIDECG);
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class LDONADDFPLN
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	internal const float HKPMMMHEHCB = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class NPLEFPGEDAP
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class BEEMIPJLLFN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly CJPNFOACJBI CBKDFINKDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly CPLHPHKOJAF HGFJMMOGKFF;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x575A350", Offset = "0x5758F50", VA = "0x18575A350")]
		public BEEMIPJLLFN(CJPNFOACJBI CBKDFINKDNK, CPLHPHKOJAF HGFJMMOGKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x575A300", Offset = "0x5758F00", VA = "0x18575A300", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x575EE60", Offset = "0x575DA60", VA = "0x18575EE60")]
	internal static bool HJKDGKMIJBH(float GBHOMBFJPAG, float DBJNEGCCKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3C57C60", Offset = "0x3C56860", VA = "0x183C57C60")]
	internal static float EOHDNCOPLBE(float GBHOMBFJPAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x575EEE0", Offset = "0x575DAE0", VA = "0x18575EEE0")]
	public static IDisposable KCCAJKNNADI(this CJPNFOACJBI CBKDFINKDNK, CPLHPHKOJAF HGFJMMOGKFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class OMMEACPJNAF : CJPNFOACJBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float JIGFGNIDECG;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float BJCBPKBPBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1051800", Offset = "0x1050400", VA = "0x181051800", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x575FD20", Offset = "0x575E920", VA = "0x18575FD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CPLHPHKOJAF FHBKOGHHAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x575FDF0", Offset = "0x575E9F0", VA = "0x18575FDF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x575FC80", Offset = "0x575E880", VA = "0x18575FC80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OMMEACPJNAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class FNONNHLOHEJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public readonly Type NPODLGGIGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public readonly string JIBCBLBCBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly bool PGJOIKJOLLM;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x575C840", Offset = "0x575B440", VA = "0x18575C840")]
	public FNONNHLOHEJ(Type JJJLJJKPEGH, string LGFEFBAMBCO, bool DGPKBEDDPEK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class PJOLKLBJBNC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x5760030", Offset = "0x575EC30", VA = "0x185760030")]
	public PJOLKLBJBNC(string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x575FFB0", Offset = "0x575EBB0", VA = "0x18575FFB0")]
	public PJOLKLBJBNC(string EHGGIAFACBG, Exception MMEICOMJMNF)
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
			[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x608710", Offset = "0x607310", VA = "0x180608710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public T this[int ACJHPBCLINB, int MOBEELFEHOL]
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x2989520", Offset = "0x2988120", VA = "0x182989520")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x29895C0", Offset = "0x29881C0", VA = "0x1829895C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2989490", Offset = "0x2988090", VA = "0x182989490")]
		public Array2D(uint OMHAPPIIDLM, uint HPMPKHBFKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2989410", Offset = "0x2988010", VA = "0x182989410")]
		public void MNHBKLHOOAC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x575A2A0", Offset = "0x5758EA0", VA = "0x18575A2A0")]
		public Array2DVector3(uint OMHAPPIIDLM, uint HPMPKHBFKPL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class JMOFDGNNHAO
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public const int BKEDPFBKKAN = -1;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public const int DBBNCBJPLKN = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[DefaultMember("Item")]
public class MPMDJDCFKAB<THandle, TValue> : IDisposable where THandle : struct, NINKJOKNHPH where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly List<THandle> PGHOFPMOHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly List<TValue> IOHIDFMHKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly Func<TValue> ENDBKLNGFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Action<TValue> CBPFOBIKKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int AMPKKDIDGAJ;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public TValue LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3056B70", Offset = "0x3055770", VA = "0x183056B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3317EF0", Offset = "0x3316AF0", VA = "0x183317EF0")]
	public MPMDJDCFKAB(Action<TValue> CBPFOBIKKBB, [Optional] Func<TValue> ENDBKLNGFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x33174F0", Offset = "0x33160F0", VA = "0x1833174F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3317BC0", Offset = "0x33167C0", VA = "0x183317BC0")]
	public THandle NEKFKHFNPIG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x33176D0", Offset = "0x33162D0", VA = "0x1833176D0")]
	public THandle JNIPLPDFDNO(TValue PDMPLJICJLE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x33179C0", Offset = "0x33165C0", VA = "0x1833179C0")]
	public bool MAHLOMNJIKK(THandle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x33172B0", Offset = "0x3315EB0", VA = "0x1833172B0")]
	public bool ACBDHJAGILA(THandle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3317740", Offset = "0x3316340", VA = "0x183317740")]
	public bool KKAHJGPJCBE(THandle PEIBOBCLLBF, out TValue PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3317970", Offset = "0x3316570", VA = "0x183317970")]
	public TValue LBHEOGGFILM(THandle PEIBOBCLLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3317A70", Offset = "0x3316670", VA = "0x183317A70")]
	public bool MDNKFKLILBA(THandle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3317DA0", Offset = "0x33169A0", VA = "0x183317DA0")]
	private THandle OIFDAOJOHPB(int BAOHKIGDOBF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x33175D0", Offset = "0x33161D0", VA = "0x1833175D0")]
	private TValue ELNOFIGJJCO(int BAOHKIGDOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x33174A0", Offset = "0x33160A0", VA = "0x1833174A0")]
	private void BPLMKJLCMOP(int BAOHKIGDOBF, in THandle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3317600", Offset = "0x3316200", VA = "0x183317600")]
	private void FIINOFGKAGM(int BAOHKIGDOBF, in TValue PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3317390", Offset = "0x3315F90", VA = "0x183317390")]
	private THandle BOHMBGMMBFD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x33177E0", Offset = "0x33163E0", VA = "0x1833177E0")]
	private void KNOCHFIPHAK(THandle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x33174E0", Offset = "0x33160E0", VA = "0x1833174E0")]
	private int CPKOIJBDFMO(int PGLJOAGFHIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3317640", Offset = "0x3316240", VA = "0x183317640")]
	private bool GDEOPJIEPIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6359A0", Offset = "0x6345A0", VA = "0x1806359A0")]
	private void DCLJMCNCGGB(THandle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3317650", Offset = "0x3316250", VA = "0x183317650")]
	private bool JBPPGOAJPFF(out THandle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x33178A0", Offset = "0x33164A0", VA = "0x1833178A0")]
	private bool LAGHIIJLLLL(out THandle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3317570", Offset = "0x3316170", VA = "0x183317570")]
	private void EDFOAEJDPOL(THandle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3317DD0", Offset = "0x33169D0", VA = "0x183317DD0")]
	private void PFMFNOGICGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface NINKJOKNHPH
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	int DBOCDBJDJNH
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
public interface DGMLBDFJNFE<T> : NINKJOKNHPH, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class OKNPMPBGCKL
{
	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xD6A5F0", Offset = "0xD691F0", VA = "0x180D6A5F0")]
	public static bool CIFJCNGDJKN<T>(this T PEIBOBCLLBF, T LPEBOAHCFNN) where T : struct, NINKJOKNHPH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2327860", Offset = "0x2326460", VA = "0x182327860")]
	public static bool MLPCDHELIGA<T>(this T PEIBOBCLLBF) where T : struct, NINKJOKNHPH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x575F220", Offset = "0x575DE20", VA = "0x18575F220")]
	public static string BNKPKCHFPJM(this NINKJOKNHPH PEIBOBCLLBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class EHALBNDAOMM
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private enum OCMPAIAKAPE : byte
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
	private int CAGODHOHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool LLLEALCHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private OCMPAIAKAPE DGLKFIPALBO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool INHNAJHBIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x575B540", Offset = "0x575A140", VA = "0x18575B540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool LOKBHDDLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x575B450", Offset = "0x575A050", VA = "0x18575B450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x575C050", Offset = "0x575AC50", VA = "0x18575C050")]
	public EHALBNDAOMM(bool LLLEALCHIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x575B650", Offset = "0x575A250", VA = "0x18575B650")]
	public void NCCMFLHKBKM(object HLJJNKOAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x575B550", Offset = "0x575A150", VA = "0x18575B550")]
	public void MFFJCEIDKGH(int PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x575B440", Offset = "0x575A040", VA = "0x18575B440")]
	public void FKABLJGNADG(uint AKHBEHIDOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x575B320", Offset = "0x5759F20", VA = "0x18575B320")]
	public void BOPNJMPKKOM(bool MHNMBHELPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x575B270", Offset = "0x5759E70", VA = "0x18575B270")]
	public void ADLFJDCGGDP(long OPGHPKNAGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x575B610", Offset = "0x575A210", VA = "0x18575B610")]
	public void MOOJLKJCCDP(ulong OCECCDLELII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x575B4D0", Offset = "0x575A0D0", VA = "0x18575B4D0")]
	public void JIIPOHONDGD(string LDIGNLIMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x575B340", Offset = "0x5759F40", VA = "0x18575B340")]
	public void CLDILJLONFP(Enum NDHKDNBHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x575BF30", Offset = "0x575AB30", VA = "0x18575BF30")]
	public void OOELFCHPCGH(IList EJNJGLOFIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x30AC250", Offset = "0x30AAE50", VA = "0x1830AC250")]
	public void PMNFMHKDEHF<T, U>(Dictionary<T, U> LHENAJIADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x575BB70", Offset = "0x575A770", VA = "0x18575BB70")]
	private void OCGMKOHDHFG(IDictionary LHENAJIADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x575B460", Offset = "0x575A060", VA = "0x18575B460")]
	public int HBGONEOOBKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x575B2B0", Offset = "0x5759EB0", VA = "0x18575B2B0")]
	public short AOJFKNNDFNO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x575B600", Offset = "0x575A200", VA = "0x18575B600")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x575B3D0", Offset = "0x5759FD0", VA = "0x18575B3D0")]
	private void EFHKBGDECJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public abstract class COICBPHIEID<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class IGBILFBPJFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public TNode HKEOACGCKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public TNode PPHLLODMENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KOCKCIFDICO BOLCPAJJPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public List<KOCKCIFDICO> MDEBGJJGHEF;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public IGBILFBPJFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal struct KOCKCIFDICO : IComparable<KOCKCIFDICO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int EONCPJFEEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public TClaimant PHLPJACFPPG;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCF0", Offset = "0x5EB8F0", VA = "0x1805ECCF0")]
		public KOCKCIFDICO(int EONCPJFEEDG, TClaimant PHLPJACFPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x235BA80", Offset = "0x235A680", VA = "0x18235BA80")]
		public bool DOHGHIELLKH(in KOCKCIFDICO LPEBOAHCFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x235BA60", Offset = "0x235A660", VA = "0x18235BA60")]
		public bool CACBNLALDIK(in KOCKCIFDICO LPEBOAHCFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x235BA70", Offset = "0x235A670", VA = "0x18235BA70", Slot = "4")]
		public int CompareTo(KOCKCIFDICO LPEBOAHCFNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x235BAE0", Offset = "0x235A6E0", VA = "0x18235BAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public enum OBJGAMNBPNC
	{
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class GIIKCIFBGHH : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::COICBPHIEID<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x21136E0", Offset = "0x21122E0", VA = "0x1821136E0")]
		[DebuggerHidden]
		public GIIKCIFBGHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x235A690", Offset = "0x2359290", VA = "0x18235A690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x235A850", Offset = "0x2359450", VA = "0x18235A850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x235A770", Offset = "0x2359370", VA = "0x18235A770", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C9E0", Offset = "0x1F0B5E0", VA = "0x181F0C9E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly global::MOJEEJOKOFF<IGBILFBPJFG> BPIIENBECID;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly global::MOJEEJOKOFF<List<KOCKCIFDICO>> JJEKLIGKCLM;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static int GEKKFOKPAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	internal readonly Dictionary<TClaimant, TNode> MEAJFAIFBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	internal readonly Dictionary<TNode, IGBILFBPJFG> AHNJCNDLPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private OBJGAMNBPNC DJEGGGAIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GONPBILDEDE(TNode KCNEPLILALO);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IJIICGAGNKB(TNode KCNEPLILALO, TClaimant EINAPEFPMJO, TClaimant KPNCMBEEHFG);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2354510", Offset = "0x2353110", VA = "0x182354510")]
	public COICBPHIEID(OBJGAMNBPNC DJEGGGAIOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2354330", Offset = "0x2352F30", VA = "0x182354330")]
	public void PPDJMPDPJJI(TNode KCNEPLILALO, TNode HBOBFHIJAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2353C50", Offset = "0x2352850", VA = "0x182353C50")]
	public void GMGMOCDGGKM(TClaimant PHLPJACFPPG, TNode CGKFBOMDKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x23538F0", Offset = "0x23524F0", VA = "0x1823538F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x23530A0", Offset = "0x2351CA0", VA = "0x1823530A0")]
	private void BJBIPGPLNMM(TClaimant PHLPJACFPPG, TNode BHEFLDKFDGD, TNode CGKFBOMDKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2353B50", Offset = "0x2352750", VA = "0x182353B50")]
	private int FPHNGHNKOBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2352DF0", Offset = "0x23519F0", VA = "0x182352DF0")]
	private void BBLDMINBMGC(TClaimant PHLPJACFPPG, TNode DKKJMOPAKMC, TNode DDBHKAHGHAL, int OLPIKABLCPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2353BC0", Offset = "0x23527C0", VA = "0x182353BC0")]
	private void GBPJFJCCNAA(KOCKCIFDICO DKGAAMOEBJL, IGBILFBPJFG IEIEOBBJEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2353240", Offset = "0x2351E40", VA = "0x182353240")]
	private void DKEBMAMBGJE(TClaimant PHLPJACFPPG, TNode DKKJMOPAKMC, TNode DDBHKAHGHAL, int OLPIKABLCPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2353140", Offset = "0x2351D40", VA = "0x182353140")]
	private void CGHOJLEIBFP(KOCKCIFDICO DKGAAMOEBJL, TNode KCNEPLILALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2353E20", Offset = "0x2352A20", VA = "0x182353E20")]
	private void HBFLMNJANBC(KOCKCIFDICO DKGAAMOEBJL, IGBILFBPJFG IEIEOBBJEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2352CB0", Offset = "0x23518B0", VA = "0x182352CB0")]
	private void ADGAGMNOKEE(IGBILFBPJFG IEIEOBBJEBM, bool BGHEDLHBODF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x23534B0", Offset = "0x23520B0", VA = "0x1823534B0")]
	private void DLJCCDBHIND(IGBILFBPJFG IEIEOBBJEBM, TNode HBOBFHIJAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2353D50", Offset = "0x2352950", VA = "0x182353D50")]
	[IteratorStateMachine(typeof(global::COICBPHIEID<, >.GIIKCIFBGHH))]
	private IEnumerable<TNode> GNEIELJICDD(TNode DKKJMOPAKMC, TNode DDBHKAHGHAL, bool KJBDONBEEMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x23540B0", Offset = "0x2352CB0", VA = "0x1823540B0")]
	private IGBILFBPJFG OJNKJMAFAGF(TNode KCNEPLILALO, TNode PPHLLODMENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2353F20", Offset = "0x2352B20", VA = "0x182353F20")]
	private IGBILFBPJFG LHPLPMBCBAH(TNode KCNEPLILALO, TNode PPHLLODMENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2354170", Offset = "0x2352D70", VA = "0x182354170")]
	private void PIKAFCDFGAM(IGBILFBPJFG IEIEOBBJEBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class HLDONIDHMEP<T> : IEnumerable<global::HLDONIDHMEP<T>.GFHONDKJNAP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct GFHONDKJNAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T PDMPLJICJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int BAOHKIGDOBF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class FEPCJMMDJFI : IEnumerator<GFHONDKJNAP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private global::HLDONIDHMEP<T> MIFOEAMJCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int BAOHKIGDOBF;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2B74170", Offset = "0x2B72D70", VA = "0x182B74170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public GFHONDKJNAP JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x43975F0", Offset = "0x43961F0", VA = "0x1843975F0", Slot = "4")]
			get
			{
				return default(GFHONDKJNAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x912330", Offset = "0x910F30", VA = "0x180912330")]
		public FEPCJMMDJFI(global::HLDONIDHMEP<T> MIFOEAMJCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x43973E0", Offset = "0x4395FE0", VA = "0x1843973E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x875780", Offset = "0x874380", VA = "0x180875780", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A8E80", VA = "0x1808AA280", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct EAADIJFEPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool OAOHHGLPIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public T PDMPLJICJLE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private const int PKEDAMLIILJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Dictionary<T, int> KDBDPGFJAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private EAADIJFEPBJ[] HNHIJFHHCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private int HIDHCAGCBLM;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int IABJGCDDDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CC0", Offset = "0x5E38C0", VA = "0x1805E4CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x73F1B0", Offset = "0x73DDB0", VA = "0x18073F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x29910B0", Offset = "0x298FCB0", VA = "0x1829910B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x43A2ED0", Offset = "0x43A1AD0", VA = "0x1843A2ED0")]
	public HLDONIDHMEP(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x43A2FB0", Offset = "0x43A1BB0", VA = "0x1843A2FB0")]
	public HLDONIDHMEP(GFHONDKJNAP[] HGLGBCEPLMF, bool OGHKLKHLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x43A2DE0", Offset = "0x43A19E0", VA = "0x1843A2DE0")]
	public int PAAFIANJNEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x43A23A0", Offset = "0x43A0FA0", VA = "0x1843A23A0")]
	private int IJLNEMEKANF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x43A2B00", Offset = "0x43A1700", VA = "0x1843A2B00", Slot = "6")]
	protected virtual uint LCPDKOADEMC(uint CAGODHOHMPP, T PDMPLJICJLE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x43A1A20", Offset = "0x43A0620", VA = "0x1843A1A20")]
	public bool EPKNJFIFMCN(T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x43A1870", Offset = "0x43A0470", VA = "0x1843A1870")]
	public bool BDNKHCFBCBB(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x43A1DB0", Offset = "0x43A09B0", VA = "0x1843A1DB0")]
	public bool HNMPINFIMAB(Func<T, bool> FOJKOMAOGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x43A2D30", Offset = "0x43A1930", VA = "0x1843A2D30")]
	public int OLHJEGHDKDC(T PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x43A1930", Offset = "0x43A0530", VA = "0x1843A1930")]
	public T ELNOFIGJJCO(int BAOHKIGDOBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x43A2C60", Offset = "0x43A1860", VA = "0x1843A2C60")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x43A1E80", Offset = "0x43A0A80", VA = "0x1843A1E80")]
	public bool IEGCNIFBCNH(T PDMPLJICJLE, bool BFPFMHFGIIB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x43A1EF0", Offset = "0x43A0AF0", VA = "0x1843A1EF0")]
	public bool IEGCNIFBCNH(T PDMPLJICJLE, int BAOHKIGDOBF, bool BFPFMHFGIIB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x43A2BD0", Offset = "0x43A17D0", VA = "0x1843A2BD0")]
	public bool MAHLOMNJIKK(T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x43A2CE0", Offset = "0x43A18E0", VA = "0x1843A2CE0")]
	public bool OFOMMAGAOIE(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x43A1B70", Offset = "0x43A0770", VA = "0x1843A1B70")]
	private void FBFCKKAAGNA(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x43A2850", Offset = "0x43A1450", VA = "0x1843A2850")]
	public GFHONDKJNAP[] JAKNHMFGHIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x43A1CB0", Offset = "0x43A08B0", VA = "0x1843A1CB0")]
	private int GBLPLAMBJBH(int OEHNDNCNDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x43A2E50", Offset = "0x43A1A50", VA = "0x1843A2E50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x43A2E50", Offset = "0x43A1A50", VA = "0x1843A2E50", Slot = "4")]
	private IEnumerator<GFHONDKJNAP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct DLEHDALBDGK<Handle> where Handle : NINKJOKNHPH, new()
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private struct GNJAMADMAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly global::DLEHDALBDGK<Handle> ACLBDOBMOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int BAOHKIGDOBF;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public int GKMNILINAJO
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x22C4210", Offset = "0x22C2E10", VA = "0x1822C4210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Handle IMEIIBMOGLO
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x22C4650", Offset = "0x22C3250", VA = "0x1822C4650")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x22C4B90", Offset = "0x22C3790", VA = "0x1822C4B90")]
		public GNJAMADMAKN(global::DLEHDALBDGK<Handle> ACLBDOBMOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x22C4480", Offset = "0x22C3080", VA = "0x1822C4480")]
		public AMHICEJDEBB EBNJNBKPCHE(in AMHICEJDEBB JONOOKFGNFB)
		{
			return default(AMHICEJDEBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x22C43D0", Offset = "0x22C2FD0", VA = "0x1822C43D0")]
		public GFFBPOFGKHK EBNJNBKPCHE(in GFFBPOFGKHK JONOOKFGNFB)
		{
			return default(GFFBPOFGKHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x22C4050", Offset = "0x22C2C50", VA = "0x1822C4050")]
		public bool AFDKOCFLMJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x22C4590", Offset = "0x22C3190", VA = "0x1822C4590")]
		private int FFOCKGOAPOD(string EHGGIAFACBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x22C4B30", Offset = "0x22C3730", VA = "0x1822C4B30")]
		private Handle PLIHKLCEBGK(string EHGGIAFACBG)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct AMHICEJDEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private GNJAMADMAKN IDADPEINOEJ;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public int JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x22B2300", Offset = "0x22B0F00", VA = "0x1822B2300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x22B23C0", Offset = "0x22B0FC0", VA = "0x1822B23C0")]
		public AMHICEJDEBB(global::DLEHDALBDGK<Handle> ACLBDOBMOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x22B21A0", Offset = "0x22B0DA0", VA = "0x1822B21A0")]
		public bool AFDKOCFLMJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x22B2220", Offset = "0x22B0E20", VA = "0x1822B2220")]
		public AMHICEJDEBB FIAIDFFFPCH()
		{
			return default(AMHICEJDEBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public struct GFFBPOFGKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private GNJAMADMAKN IDADPEINOEJ;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Handle JLHGEOLLPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x22C2710", Offset = "0x22C1310", VA = "0x1822C2710")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x22B23C0", Offset = "0x22B0FC0", VA = "0x1822B23C0")]
		public GFFBPOFGKHK(global::DLEHDALBDGK<Handle> ACLBDOBMOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x22B21A0", Offset = "0x22B0DA0", VA = "0x1822B21A0")]
		public bool AFDKOCFLMJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x22C25F0", Offset = "0x22C11F0", VA = "0x1822C25F0")]
		public GFFBPOFGKHK FIAIDFFFPCH()
		{
			return default(GFFBPOFGKHK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeList<int> BHJBPECFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeList<int> LHBLECGMIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int NKLBGMBMMJH;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool IJOOMGLLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x22B68A0", Offset = "0x22B54A0", VA = "0x1822B68A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int DBOEJCGBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x22B86D0", Offset = "0x22B72D0", VA = "0x1822B86D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int CFEGJHOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CD0", Offset = "0x5E38D0", VA = "0x1805E4CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int DFFMNJEEBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CD0", Offset = "0x5E38D0", VA = "0x1805E4CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public AMHICEJDEBB GNDDJNINCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x22B5830", Offset = "0x22B4430", VA = "0x1822B5830")]
		get
		{
			return default(AMHICEJDEBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public GFFBPOFGKHK AFEEHBIPCNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x22B7C70", Offset = "0x22B6870", VA = "0x1822B7C70")]
		get
		{
			return default(GFFBPOFGKHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x22B88A0", Offset = "0x22B74A0", VA = "0x1822B88A0")]
	public DLEHDALBDGK(int MOEHNNDFGCC, Allocator KIPGDNHHBGE = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x22B7BB0", Offset = "0x22B67B0", VA = "0x1822B7BB0")]
	public void KHFNNCAMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xF10210", Offset = "0xF0EE10", VA = "0x180F10210")]
	public static int CPKOIJBDFMO(int MLEMCDNNOBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x22B8750", Offset = "0x22B7350", VA = "0x1822B8750")]
	public static bool PGKIPEGHEDP(int MLEMCDNNOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x22B5DC0", Offset = "0x22B49C0", VA = "0x1822B5DC0")]
	public static bool FMDJJEKOOFI(int MLEMCDNNOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x22B5BC0", Offset = "0x22B47C0", VA = "0x1822B5BC0")]
	public bool FIDFOHAJNKC(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x22B7730", Offset = "0x22B6330", VA = "0x1822B7730")]
	public bool JIGNHKMGNHC(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x22B8320", Offset = "0x22B6F20", VA = "0x1822B8320")]
	public bool MOIBPANABED(Handle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x22B5EC0", Offset = "0x22B4AC0", VA = "0x1822B5EC0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void GKFFHPCPCPD(Handle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x22B8110", Offset = "0x22B6D10", VA = "0x1822B8110")]
	public Handle MGDNIECMCAJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x22B73F0", Offset = "0x22B5FF0", VA = "0x1822B73F0")]
	public void JDBHHNIFIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x22B5E70", Offset = "0x22B4A70", VA = "0x1822B5E70")]
	public void GDNAGHJDLLM(Handle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x22B66E0", Offset = "0x22B52E0", VA = "0x1822B66E0")]
	public bool HAFKEGKFMIL(Handle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x22B69A0", Offset = "0x22B55A0", VA = "0x1822B69A0")]
	private bool IHPCEEJFFED(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x22B7FC0", Offset = "0x22B6BC0", VA = "0x1822B7FC0")]
	private void LNGJHCBJLOM(out int BAOHKIGDOBF, out int PGLJOAGFHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x22B6A00", Offset = "0x22B5600", VA = "0x1822B6A00")]
	private void JAHPHNLJJIK(Handle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x22B55C0", Offset = "0x22B41C0", VA = "0x1822B55C0")]
	private void BKFKGALOJLN(int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x22B58E0", Offset = "0x22B44E0", VA = "0x1822B58E0")]
	private bool DOPPNIFJCDH(out int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x22B57A0", Offset = "0x22B43A0", VA = "0x1822B57A0")]
	private static Handle CNBGJOBNFID(int BAOHKIGDOBF, int PGLJOAGFHIO)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
public struct LDPOKLHHIGK<Handle, T> where Handle : NINKJOKNHPH, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private global::DLEHDALBDGK<Handle> NDKEBJFNIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private T[] HEDOLDJNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private Action<T> EJJNMPNNOLK;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool IJOOMGLLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x489F0F0", Offset = "0x489DCF0", VA = "0x18489F0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public int DBOEJCGBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x48A0AB0", Offset = "0x489F6B0", VA = "0x1848A0AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x489F0C0", Offset = "0x489DCC0", VA = "0x18489F0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public T LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x48A0230", Offset = "0x489EE30", VA = "0x1848A0230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x48A0EF0", Offset = "0x489FAF0", VA = "0x1848A0EF0")]
	public LDPOKLHHIGK(int MOEHNNDFGCC, [Optional] Action<T> EJJNMPNNOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x489FF40", Offset = "0x489EB40", VA = "0x18489FF40")]
	public void KHFNNCAMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x48A0980", Offset = "0x489F580", VA = "0x1848A0980")]
	public bool MOIBPANABED(Handle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void GKFFHPCPCPD(Handle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x48A0360", Offset = "0x489EF60", VA = "0x1848A0360")]
	public T LBHEOGGFILM(Handle PEIBOBCLLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x48A0180", Offset = "0x489ED80", VA = "0x1848A0180")]
	public bool KKAHJGPJCBE(Handle PEIBOBCLLBF, out T HLJJNKOAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x489FC70", Offset = "0x489E870", VA = "0x18489FC70")]
	public void KCACFLLCKKN(Handle PEIBOBCLLBF, T FABMCJAMHJJ, out T JBLAHKAOMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x489FB50", Offset = "0x489E750", VA = "0x18489FB50")]
	public void KCACFLLCKKN(Handle PEIBOBCLLBF, T FABMCJAMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x489EEB0", Offset = "0x489DAB0", VA = "0x18489EEB0")]
	public bool DBKKNMGLAGE(Handle PEIBOBCLLBF, T FABMCJAMHJJ, out T JBLAHKAOMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x489EC10", Offset = "0x489D810", VA = "0x18489EC10")]
	public bool DBKKNMGLAGE(Handle PEIBOBCLLBF, T FABMCJAMHJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x489F880", Offset = "0x489E480", VA = "0x18489F880")]
	public Handle JNIPLPDFDNO(T HLJJNKOAONN)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x489E490", Offset = "0x489D090", VA = "0x18489E490")]
	public void ADGOOIDKDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x48A0470", Offset = "0x489F070", VA = "0x1848A0470")]
	public void MAHLOMNJIKK(Handle PEIBOBCLLBF, out T JBLAHKAOMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x48A03A0", Offset = "0x489EFA0", VA = "0x1848A03A0")]
	public void MAHLOMNJIKK(Handle PEIBOBCLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x489F660", Offset = "0x489E260", VA = "0x18489F660")]
	public bool HLBGHANEEOO(Handle PEIBOBCLLBF, out T JBLAHKAOMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x489F4A0", Offset = "0x489E0A0", VA = "0x18489F4A0")]
	public bool HLBGHANEEOO(Handle PEIBOBCLLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x48A09D0", Offset = "0x489F5D0", VA = "0x1848A09D0")]
	private T OFOMMAGAOIE(int BAOHKIGDOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x48A0CF0", Offset = "0x489F8F0", VA = "0x1848A0CF0")]
	private void PDNFMEFDKJB(int FFJOAELJOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class MOJEEJOKOFF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly Stack<T> ACLBDOBMOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<T> GOBDCNFHBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly int HLDPKACEEBM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int KKBECBJHPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x204C860", Offset = "0x204B460", VA = "0x18204C860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int LAGGCEDOFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x298EB20", Offset = "0x298D720", VA = "0x18298EB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x3316AD0", Offset = "0x33156D0", VA = "0x183316AD0")]
	public static global::MOJEEJOKOFF<T> JCOHPMGFBCJ(int EFOLPOOCAHO = 0, int HLDPKACEEBM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3316A00", Offset = "0x3315600", VA = "0x183316A00")]
	public static global::MOJEEJOKOFF<T> IOKFLKNDCKH(int EFOLPOOCAHO = 0, int HLDPKACEEBM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3316C40", Offset = "0x3315840", VA = "0x183316C40")]
	public MOJEEJOKOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3316C80", Offset = "0x3315880", VA = "0x183316C80")]
	public MOJEEJOKOFF(int EFOLPOOCAHO, int HLDPKACEEBM = int.MaxValue, bool DHNJONMKBPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x33168D0", Offset = "0x33154D0", VA = "0x1833168D0")]
	public T HDHCDMEAMMM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3316810", Offset = "0x3315410", VA = "0x183316810")]
	public void FNAPKEMHLBG(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x33163B0", Offset = "0x3314FB0", VA = "0x1833163B0")]
	private void CEFGAMEDHNF(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3316740", Offset = "0x3315340", VA = "0x183316740")]
	private void FBJFHMBICNB(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x3316BA0", Offset = "0x33157A0", VA = "0x183316BA0")]
	[Conditional("DEBUG_BUILD")]
	private void ODKNKCAKBNA(T HDMGIIGLKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x3316760", Offset = "0x3315360", VA = "0x183316760")]
	[Conditional("DEBUG_BUILD")]
	private void FFIALMMJPHM(T HDMGIIGLKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3316470", Offset = "0x3315070", VA = "0x183316470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x3316580", Offset = "0x3315180", VA = "0x183316580")]
	private void EGINMLDBCJA(IEnumerable<T> IOHIDFMHKJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class KHNMPLOHDHP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private Dictionary<int, T> NNFPDOENKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private T OPFFGLGBIBH;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public virtual T NIKFFPLDHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool JKGBEMAGACK
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3056130", Offset = "0x3054D30", VA = "0x183056130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x30568D0", Offset = "0x30554D0", VA = "0x1830568D0")]
	public bool JOMHIKHKDFI(T PDMPLJICJLE, int EONCPJFEEDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3056340", Offset = "0x3054F40", VA = "0x183056340")]
	public bool GNDHHKOLNLK(int EONCPJFEEDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x30563A0", Offset = "0x3054FA0", VA = "0x1830563A0")]
	public T IBNCEEAPBJP(int FJDLHPBCGLL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x3056930", Offset = "0x3055530", VA = "0x183056930")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x3056170", Offset = "0x3054D70", VA = "0x183056170")]
	private bool DKFKPBJKGPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x3056310", Offset = "0x3054F10", VA = "0x183056310")]
	public bool EKDAOPLAPIM(int EONCPJFEEDG, out T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x3056990", Offset = "0x3055590", VA = "0x183056990")]
	public KHNMPLOHDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class GJGHGGNOINI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	protected struct FFDGKECPAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public T CFABBBMGOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int HCKPAEDAGAL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	protected readonly List<FFDGKECPAML> KKBLPIMEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T GCGAPGNPCBK;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x29910B0", Offset = "0x298FCB0", VA = "0x1829910B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x33A7080", Offset = "0x33A5C80", VA = "0x1833A7080")]
	public bool HNMPINFIMAB(T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x33A72D0", Offset = "0x33A5ED0", VA = "0x1833A72D0")]
	public void JNIPLPDFDNO(T PDMPLJICJLE, int EONCPJFEEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x33A75F0", Offset = "0x33A61F0", VA = "0x1833A75F0")]
	public bool MAHLOMNJIKK(T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x33A7710", Offset = "0x33A6310", VA = "0x1833A7710")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x33A7770", Offset = "0x33A6370", VA = "0x1833A7770")]
	public T PJNNLLGOJPN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x33A7580", Offset = "0x33A6180", VA = "0x1833A7580")]
	public T LPPFFGEEAFL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x33A7370", Offset = "0x33A5F70", VA = "0x1833A7370")]
	private void KEAELKAMNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x33A7800", Offset = "0x33A6400", VA = "0x1833A7800")]
	public GJGHGGNOINI()
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
		[FKBMPBMBLBA(PFBNBFOHPDG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x57602D0", Offset = "0x575EED0", VA = "0x1857602D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x57607A0", Offset = "0x575F3A0", VA = "0x1857607A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x57605C0", Offset = "0x575F1C0", VA = "0x1857605C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x5760940", Offset = "0x575F540", VA = "0x185760940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x5760190", Offset = "0x575ED90", VA = "0x185760190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x5760660", Offset = "0x575F260", VA = "0x185760660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x5760480", Offset = "0x575F080", VA = "0x185760480")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x57600F0", Offset = "0x575ECF0", VA = "0x1857600F0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public interface PEHKPEDNNHA
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public abstract class ResourcePrefabReference<T> : PEHKPEDNNHA where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x299A4B0", Offset = "0x29990B0", VA = "0x18299A4B0", Slot = "4")]
		public virtual T NMEBCIDNFCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class MHKMJMMBMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Dictionary<byte, EAGHCGGDFNE> LPFNDCCEFNP;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public EAGHCGGDFNE JCGIJCHNPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Vector2 AIAAHCAEAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xF1A860", Offset = "0xF19460", VA = "0x180F1A860")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9280", Offset = "0x2CD7E80", VA = "0x182CD9280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector2 LKKKEIHGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7C60", Offset = "0x1EB6860", VA = "0x181EB7C60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1F79050", Offset = "0x1F77C50", VA = "0x181F79050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector2 LCAKJOGDIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x575DD90", Offset = "0x575C990", VA = "0x18575DD90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x575E420", Offset = "0x575D020", VA = "0x18575E420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int IKFPFJFHNDO
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x60F7E0", Offset = "0x60E3E0", VA = "0x18060F7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6359A0", Offset = "0x6345A0", VA = "0x1806359A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x575E440", Offset = "0x575D040", VA = "0x18575E440")]
	public MHKMJMMBMGO(Bounds PMPNGGOIMFG, Vector2[] LAGKEBELALK, int MOECEOIPNKN, byte OEHNDNCNDKL, float PJAHPFEDCFG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x575DDB0", Offset = "0x575C9B0", VA = "0x18575DDB0")]
	public EAGHCGGDFNE LLGCMPPNCJH(byte BAOHKIGDOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x575E330", Offset = "0x575CF30", VA = "0x18575E330")]
	public void OFDIBAICMHA(Vector3 AJODAOPNJGC, float KLAOBBOEFBA, float JEJNBJHHFHP, ref List<byte> LMBKNIFBNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x575DC40", Offset = "0x575C840", VA = "0x18575DC40")]
	public void DOHEDEAPGMF(EAGHCGGDFNE.BKENNJDBKLG FNPFHGEJPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x575DC60", Offset = "0x575C860", VA = "0x18575DC60")]
	private EAGHCGGDFNE GNNNDFEBDNG(byte BAOHKIGDOBF, EAGHCGGDFNE.DNGALGPIPDN AEANJINGMOL, EAGHCGGDFNE PPHLLODMENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x575DE10", Offset = "0x575CA10", VA = "0x18575DE10")]
	private void MHONNPKDOBK(EAGHCGGDFNE PPHLLODMENC, Vector2[] LAGKEBELALK, int EEEFIIDNOMK, int EGGDPFNICJI, int DLGNKNIFDJG, int EIGFIKOMFKH, float PJAHPFEDCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class EAGHCGGDFNE
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public enum DNGALGPIPDN
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public enum BKENNJDBKLG
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
	public byte EIFANLOKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector3 DCDABPOJAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector3 NODCJGOKMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector3 KHGBCLMDCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector3 AKDJBGNAGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public DNGALGPIPDN LLFAHILBEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public EAGHCGGDFNE GBDEIDMACBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public List<EAGHCGGDFNE> LKALEALOEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public bool ANBIFHBFLIM;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x575B150", Offset = "0x5759D50", VA = "0x18575B150")]
	public EAGHCGGDFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x575B0F0", Offset = "0x5759CF0", VA = "0x18575B0F0")]
	public EAGHCGGDFNE(byte PHGKKLLIIFD, DNGALGPIPDN AEANJINGMOL, EAGHCGGDFNE PPHLLODMENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x575ADC0", Offset = "0x57599C0", VA = "0x18575ADC0")]
	public void KCADPNPACHD(EAGHCGGDFNE PCCELBMBFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	public void DOHEDEAPGMF(int NJMMGNNLFAB, BKENNJDBKLG FNPFHGEJPBO, int AJGHPKJDAOE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x575AE60", Offset = "0x5759A60", VA = "0x18575AE60")]
	public void OFDIBAICMHA(List<byte> LMBKNIFBNLM, Vector3 AJODAOPNJGC, float KLAOBBOEFBA, float JEJNBJHHFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x575AD20", Offset = "0x5759920", VA = "0x18575AD20")]
	public bool BPFAFDODJPA(Vector3 LFHAKIFFEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x575AD80", Offset = "0x5759980", VA = "0x18575AD80")]
	public bool CAOCIHKGMPO(Vector3 LFHAKIFFEMA, float JCFFLPOHPHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class NLIGKFBIGHK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly Dictionary<T, object> ODAODKMJEJK;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x22C4BB0", Offset = "0x22C37B0", VA = "0x1822C4BB0")]
	public bool ECEEAKOPAEC(T HFAEDDILDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA230", Offset = "0x2CD8E30", VA = "0x182CDA230")]
	public bool ECEEAKOPAEC(T HFAEDDILDPE, object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA1D0", Offset = "0x2CD8DD0", VA = "0x182CDA1D0")]
	public bool ECEEAKOPAEC(T HFAEDDILDPE, object BNKIDKMECMP, out object BEIDAHFJADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA3E0", Offset = "0x2CD8FE0", VA = "0x182CDA3E0")]
	public bool PJGKFOKLKHF(T HFAEDDILDPE, object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA270", Offset = "0x2CD8E70", VA = "0x182CDA270")]
	public bool FPILHBEIKAC(T HFAEDDILDPE, object BNKIDKMECMP, out object BEIDAHFJADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA350", Offset = "0x2CD8F50", VA = "0x182CDA350")]
	public bool PJGKFOKLKHF(T HFAEDDILDPE, object BNKIDKMECMP, out object BEIDAHFJADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA420", Offset = "0x2CD9020", VA = "0x182CDA420")]
	public void POFLLKMFOCI(T HFAEDDILDPE, object BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA2B0", Offset = "0x2CD8EB0", VA = "0x182CDA2B0")]
	public void LMOJNGPDPCD(T HFAEDDILDPE, object BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA450", Offset = "0x2CD9050", VA = "0x182CDA450")]
	public NLIGKFBIGHK()
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
		public struct NBKKMPOFJDC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private readonly List<Component> EJNJGLOFIFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private readonly bool GCEFMIFPOLO;

			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x824360", Offset = "0x822F60", VA = "0x180824360")]
			public NBKKMPOFJDC(List<Component> EJNJGLOFIFF, bool GCEFMIFPOLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x298E880", Offset = "0x298D480", VA = "0x18298E880")]
			public BBCGDIOBMHH<T> FIAIDFFFPCH()
			{
				return default(BBCGDIOBMHH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x298E8F0", Offset = "0x298D4F0", VA = "0x18298E8F0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x298E8F0", Offset = "0x298D4F0", VA = "0x18298E8F0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		public struct BBCGDIOBMHH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private readonly List<Component> EJNJGLOFIFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private readonly bool GCEFMIFPOLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int BAOHKIGDOBF;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			public T JLHGEOLLPBA
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0x29897A0", Offset = "0x29883A0", VA = "0x1829897A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0x2989730", Offset = "0x2988330", VA = "0x182989730", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x2989770", Offset = "0x2988370", VA = "0x182989770")]
			public BBCGDIOBMHH(List<Component> EJNJGLOFIFF, bool GCEFMIFPOLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x2989660", Offset = "0x2988260", VA = "0x182989660", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x2989670", Offset = "0x2988270", VA = "0x182989670", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x2989720", Offset = "0x2988320", VA = "0x182989720", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5762600", Offset = "0x5761200", VA = "0x185762600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x57625C0", Offset = "0x57611C0", VA = "0x1857625C0")]
		public ToolHierarchyCache(GameObject CJIGEPIKLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5761EF0", Offset = "0x5760AF0", VA = "0x185761EF0")]
		private void CMEOLNMPNEL(GameObject CJIGEPIKLDD, bool PPDFINNPBCJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x5762010", Offset = "0x5760C10", VA = "0x185762010")]
		public static void CMEOLNMPNEL(GameObject CJIGEPIKLDD, ref ToolHierarchyCache EJBOOPKBJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5762440", Offset = "0x5761040", VA = "0x185762440")]
		public void NAACMCFGLMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x5762510", Offset = "0x5761110", VA = "0x185762510")]
		public void PFJCHLBCNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x22354A0", Offset = "0x22340A0", VA = "0x1822354A0")]
		public void BAHCOMHMHIP<T>(Action<T> FHCMCNABNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5761DA0", Offset = "0x57609A0", VA = "0x185761DA0")]
		public Component BAJIAHCOKBI(Type HCPDGKICMEB, bool GCEFMIFPOLO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2251D50", Offset = "0x2250950", VA = "0x182251D50")]
		public T BAJIAHCOKBI<T>(bool GCEFMIFPOLO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5761E60", Offset = "0x5760A60", VA = "0x185761E60")]
		public NBKKMPOFJDC<Component> BDDEKFNKFOB(Type HCPDGKICMEB, bool GCEFMIFPOLO = false)
		{
			return default(NBKKMPOFJDC<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x28B62A0", Offset = "0x28B4EA0", VA = "0x1828B62A0")]
		public NBKKMPOFJDC<T> BDDEKFNKFOB<T>(bool GCEFMIFPOLO = false) where T : class
		{
			return default(NBKKMPOFJDC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x5762190", Offset = "0x5760D90", VA = "0x185762190")]
		public List<Component> JKBDKOMBICC(Type HCPDGKICMEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x57620A0", Offset = "0x5760CA0", VA = "0x1857620A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FPNCCNLMGCF, ToolHierarchyCache JNKDBNBEKBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5762120", Offset = "0x5760D20", VA = "0x185762120", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HLJJNKOAONN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class IHPBOEDFCEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private int EFOLPOOCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private int AEMLFDDNGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private List<T> DDJJEIOCKHK;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x204C860", Offset = "0x204B460", VA = "0x18204C860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public T DBBHILFBFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x33CDEC0", Offset = "0x33CCAC0", VA = "0x1833CDEC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public T NMFNGLMCOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x33CE2A0", Offset = "0x33CCEA0", VA = "0x1833CE2A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public T DHJBBEMAHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x33CDFE0", Offset = "0x33CCBE0", VA = "0x1833CDFE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x33CE390", Offset = "0x33CCF90", VA = "0x1833CE390")]
	public IHPBOEDFCEN(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x33CE0A0", Offset = "0x33CCCA0", VA = "0x1833CE0A0")]
	public void JNIPLPDFDNO(T LLDDAGKDGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x33CE350", Offset = "0x33CCF50", VA = "0x1833CE350")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x33CDE20", Offset = "0x33CCA20", VA = "0x1833CDE20")]
	public void EJMLIKPMBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x33CE250", Offset = "0x33CCE50", VA = "0x1833CE250")]
	public void MEOMHBHAEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x33CDE10", Offset = "0x33CCA10", VA = "0x1833CDE10")]
	public void AJGFILKLOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class BMHPMPNJNGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool DBFFOPBIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Action FHCMCNABNIM;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public static BMHPMPNJNGJ NJDECHPFHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x575A560", Offset = "0x5759160", VA = "0x18575A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool MJFAJBLIEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x60F7B0", Offset = "0x60E3B0", VA = "0x18060F7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC50", Offset = "0x8FA850", VA = "0x1808FBC50")]
	public BMHPMPNJNGJ(Action FHCMCNABNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x575A5E0", Offset = "0x57591E0", VA = "0x18575A5E0")]
	public void HLHCNOFHMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x575A5E0", Offset = "0x57591E0", VA = "0x18575A5E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class GILHPPMNEGM
{
	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80")]
	public static void HBOKIJFGHHE(GJIHOLNGKMI FAOFMGAPHDP, string LEOBJLIBBBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class LPKENOAPCJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private struct KHLMLLIHNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int HCKPAEDAGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public T CFABBBMGOIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<object, KHLMLLIHNPA> NNFPDOENKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private T OPFFGLGBIBH;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public virtual T NIKFFPLDHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xF1A860", Offset = "0xF19460", VA = "0x180F1A860", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9280", Offset = "0x2CD7E80", VA = "0x182CD9280", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool JKGBEMAGACK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x38FEE00", Offset = "0x38FDA00", VA = "0x1838FEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public object KEEGIAPFLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x39042B0", Offset = "0x3902EB0", VA = "0x1839042B0")]
	public bool JOMHIKHKDFI(T PDMPLJICJLE, object BNKIDKMECMP, int EONCPJFEEDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x3904100", Offset = "0x3902D00", VA = "0x183904100")]
	public bool GNDHHKOLNLK(object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x3903E20", Offset = "0x3902A20", VA = "0x183903E20")]
	public bool EKDAOPLAPIM(object BNKIDKMECMP, out T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4A40", Offset = "0x2CE3640", VA = "0x182CE4A40")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x3901E40", Offset = "0x3900A40", VA = "0x183901E40")]
	private bool DKFKPBJKGPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x3056990", Offset = "0x3055590", VA = "0x183056990")]
	public LPKENOAPCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public class OJKAMPGEFEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private Dictionary<object, float> NNFPDOENKLP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float MCKIBKNKJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1051800", Offset = "0x1050400", VA = "0x181051800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE37130", Offset = "0xE35D30", VA = "0x180E37130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x575F130", Offset = "0x575DD30", VA = "0x18575F130")]
	public void JOMHIKHKDFI(float PDMPLJICJLE, object BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x575EFA0", Offset = "0x575DBA0", VA = "0x18575EFA0")]
	public void GNDHHKOLNLK(object BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x575F010", Offset = "0x575DC10", VA = "0x18575F010")]
	private void IOGLAJDPFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x575F1A0", Offset = "0x575DDA0", VA = "0x18575F1A0")]
	public OJKAMPGEFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class EEBMGPBCCHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public readonly string DNDLLJGCMLJ;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
	public EEBMGPBCCHC(string CBJDIBMONJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x575B1C0", Offset = "0x5759DC0", VA = "0x18575B1C0")]
	public EEBMGPBCCHC(UnityEngine.Object MOPBBCGPMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x575B170", Offset = "0x5759D70", VA = "0x18575B170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class GJIHOLNGKMI
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class EIEGNDAFENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public EIEGNDAFENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x575C080", Offset = "0x575AC80", VA = "0x18575C080")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private HashSet<object> CFKJHCIBOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private int CGDFDJEIBEG;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IReadOnlyCollection<object> HLECBPNLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x575CB20", Offset = "0x575B720", VA = "0x18575CB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool MINNDPBDKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x575C960", Offset = "0x575B560", VA = "0x18575C960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public int JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x670670", Offset = "0x66F270", VA = "0x180670670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x575C9D0", Offset = "0x575B5D0", VA = "0x18575C9D0")]
	public bool JNIPLPDFDNO(object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x575CA90", Offset = "0x575B690", VA = "0x18575CA90")]
	public bool MAHLOMNJIKK(object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x575C970", Offset = "0x575B570", VA = "0x18575C970")]
	public bool HNMPINFIMAB(object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x575CBF0", Offset = "0x575B7F0", VA = "0x18575CBF0")]
	public void PMBGMGJOOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x575CC50", Offset = "0x575B850", VA = "0x18575CC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public GJIHOLNGKMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class LNFIDCPMLKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private struct LFHIPLDFFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public float PCENMHEAMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public T CFABBBMGOIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private Dictionary<object, LFHIPLDFFFA> NNFPDOENKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private T BLDNOMAJOAN;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual T OBKJPEBONEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x1AE18A0", Offset = "0x1AE04A0", VA = "0x181AE18A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1020", Offset = "0x1ADFC20", VA = "0x181AE1020", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public object IOCABEEBMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool JKGBEMAGACK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x34E9980", Offset = "0x34E8580", VA = "0x1834E9980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x34EB500", Offset = "0x34EA100", VA = "0x1834EB500")]
	public bool JOMHIKHKDFI(T PDMPLJICJLE, object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x34EB4A0", Offset = "0x34EA0A0", VA = "0x1834EB4A0")]
	public bool GNDHHKOLNLK(object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4A40", Offset = "0x2CE3640", VA = "0x182CE4A40")]
	public void MNHBKLHOOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x34EB280", Offset = "0x34E9E80", VA = "0x1834EB280")]
	public bool EKDAOPLAPIM(object BNKIDKMECMP, out T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x34E99C0", Offset = "0x34E85C0", VA = "0x1834E99C0")]
	private bool DKFKPBJKGPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x34EBAD0", Offset = "0x34EA6D0", VA = "0x1834EBAD0")]
	public LNFIDCPMLKK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x575C460", Offset = "0x575B060", VA = "0x18575C460")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x575C130", Offset = "0x575AD30", VA = "0x18575C130")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
