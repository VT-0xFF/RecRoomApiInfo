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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FHAINJFGBBF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69ECF0", Offset = "0x69DCF0", VA = "0x18069ECF0")]
	public FHAINJFGBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C94AD0", Offset = "0x4C93AD0", VA = "0x184C94AD0")]
	public byte[] PLHNOLNBHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CMBDGMDFLCD(IncrementalHash MNKLNMHPAPP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63DF90", Offset = "0x63CF90", VA = "0x18063DF90")]
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
	[EIHJBFIJLEO]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[EIHJBFIJLEO]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4C974A0", Offset = "0x4C964A0", VA = "0x184C974A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C97460", Offset = "0x4C96460", VA = "0x184C97460")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4C974E0", Offset = "0x4C964E0", VA = "0x184C974E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4C976F0", Offset = "0x4C966F0", VA = "0x184C976F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4C97660", Offset = "0x4C96660", VA = "0x184C97660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7625C0", Offset = "0x7615C0", VA = "0x1807625C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE970", Offset = "0x6DD970", VA = "0x1806DE970")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4C97420", Offset = "0x4C96420", VA = "0x184C97420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4C975D0", Offset = "0x4C965D0", VA = "0x184C975D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C96E50", Offset = "0x4C95E50", VA = "0x184C96E50")]
	public void CopyBounds(SavedExtents GKBKHIIEFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4C97390", Offset = "0x4C96390", VA = "0x184C97390")]
	public void SetLocalSpaceBounds(Bounds OFLIICJPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7203B0", Offset = "0x71F3B0", VA = "0x1807203B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4C97170", Offset = "0x4C96170", VA = "0x184C97170")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C97180", Offset = "0x4C96180", VA = "0x184C97180")]
	private void PMDOFAMPLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C96F40", Offset = "0x4C95F40", VA = "0x184C96F40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C96890", Offset = "0x4C95890", VA = "0x184C96890")]
	public static void CalculateLocalBoundsFor(GameObject NJCEGNEAEJH, out Bounds OFLIICJPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C96E80", Offset = "0x4C95E80", VA = "0x184C96E80")]
	private static void OMBJOBLMGGE(Bounds FMMAACMCILJ, Color MCODHPOGBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C973B0", Offset = "0x4C963B0", VA = "0x184C973B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3430", Offset = "0x5B2430", VA = "0x1805B3430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "4")]
	public virtual void IGAJGADHMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
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
	[SerializeField]
	[FHAINJFGBBF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D34D00", Offset = "0x3D33D00", VA = "0x183D34D00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D34840", Offset = "0x3D33840", VA = "0x183D34840", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D35300", Offset = "0x3D34300", VA = "0x183D35300")]
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
	private sealed class ONGBDLBPHBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public ONGBDLBPHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34438A0", Offset = "0x34428A0", VA = "0x1834438A0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[FHAINJFGBBF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x34379C0", Offset = "0x34369C0", VA = "0x1834379C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34379F0", Offset = "0x34369F0", VA = "0x1834379F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3437910", Offset = "0x3436910", VA = "0x183437910", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey BJKKIOODGOA]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3437940", Offset = "0x3436940", VA = "0x183437940", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3437810", Offset = "0x3436810", VA = "0x183437810", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3437070", Offset = "0x3436070", VA = "0x183437070", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34369E0", Offset = "0x34359E0", VA = "0x1834369E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3436610", Offset = "0x3435610", VA = "0x183436610", Slot = "14")]
	protected virtual string NHAIJLIMDCB(TKeyVal BBCGHEDINOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3CC0", Offset = "0x2BA2CC0", VA = "0x182BA3CC0", Slot = "4")]
	public bool ContainsKey(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3437700", Offset = "0x3436700", VA = "0x183437700", Slot = "5")]
	public bool TryGetValue(TKey BJKKIOODGOA, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3436550", Offset = "0x3435550", VA = "0x183436550", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3436550", Offset = "0x3435550", VA = "0x183436550", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3437730", Offset = "0x3436730", VA = "0x183437730")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HBGFADPMBAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IDFPADGHBJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public IDFPADGHBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3772470", Offset = "0x3771470", VA = "0x183772470")]
		internal bool <GetSamples>b__0(global::JEIJHHJGJEP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float LACBBFMAJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float LDDNKFOCLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::JEIJHHJGJEP<float, T>> EFEELHLEOBG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LFMEMFHOLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3767060", Offset = "0x3766060", VA = "0x183767060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3767220", Offset = "0x3766220", VA = "0x183767220")]
	public HBGFADPMBAD(float PHFGMDKGIJK, float NNDFGJOFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3766F00", Offset = "0x3765F00", VA = "0x183766F00")]
	public bool KONFMAKLKBJ(float EPBBCHMOFCN, T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3766690", Offset = "0x3765690", VA = "0x183766690")]
	public int ANBDNHLNHNC(float EPBBCHMOFCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3766720", Offset = "0x3765720", VA = "0x183766720")]
	public IEnumerable<T> DHDOOLJPMGM(float EPBBCHMOFCN, [Optional] float? HFMAHHCIBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37666F0", Offset = "0x37656F0", VA = "0x1837666F0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3767160", Offset = "0x3766160", VA = "0x183767160")]
	private void OGEINGACIJH(float EPBBCHMOFCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class IICPDPJLKBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OOOPKBOOOEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T CIFMBHMEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float PNBNHPKCNNB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float OFEJFGJHFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> IDKIJKDDGJI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int HBPAKBKHKGH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private OOOPKBOOOEP[] ECGFLNEOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int NALAFEEKKJE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float KBOOGILELJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2B0", Offset = "0x8AD2B0", VA = "0x1808AE2B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x643AE0", Offset = "0x642AE0", VA = "0x180643AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x16FA240", Offset = "0x16F9240", VA = "0x1816FA240")]
	public IICPDPJLKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x16FA160", Offset = "0x16F9160", VA = "0x1816FA160")]
	public IICPDPJLKBE(int DDMFGCPNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x16F95B0", Offset = "0x16F85B0", VA = "0x1816F95B0")]
	public void IONNJMGFDPB(float EPBBCHMOFCN, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x16F8C30", Offset = "0x16F7C30", VA = "0x1816F8C30")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16F9240", Offset = "0x16F8240", VA = "0x1816F9240")]
	public bool HMGEEILFBHF(float KBCDOFHLMAP, float AHHLDEANCNN, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16F98A0", Offset = "0x16F88A0", VA = "0x1816F98A0")]
	public bool PDLEJLKOEAH(float KBCDOFHLMAP, float AHHLDEANCNN, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16F9D20", Offset = "0x16F8D20", VA = "0x1816F9D20")]
	public void PKGJJBDIJMC(float KBCDOFHLMAP, float AHHLDEANCNN, List<T> MGGGNBHMHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16F9870", Offset = "0x16F8870", VA = "0x1816F9870")]
	private int PBLNOGLPLMD(int GHLBEDMNIKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x16F9830", Offset = "0x16F8830", VA = "0x1816F9830")]
	private void KOPGGLELHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JDHEENCCIIH();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BMJBNCNEAPH(T LLKALDKKJFP, T EIFOFLJGEEA, float AHIMPPGEGDB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GLKFEOODFCE(T MFBIHMKFNKA, float AHIMPPGEGDB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IGDIGEFLBDG(T LLKALDKKJFP, T EIFOFLJGEEA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GHLLJPCNAOP(T LLKALDKKJFP, T EIFOFLJGEEA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HDFGGOOMFJK : global::IICPDPJLKBE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4C949A0", Offset = "0x4C939A0", VA = "0x184C949A0", Slot = "4")]
	protected override Vector3 JDHEENCCIIH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4C94720", Offset = "0x4C93720", VA = "0x184C94720", Slot = "5")]
	protected override Vector3 BMJBNCNEAPH(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4C94850", Offset = "0x4C93850", VA = "0x184C94850", Slot = "6")]
	protected override Vector3 GLKFEOODFCE(Vector3 MFBIHMKFNKA, float AHIMPPGEGDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C948F0", Offset = "0x4C938F0", VA = "0x184C948F0", Slot = "7")]
	protected override Vector3 IGDIGEFLBDG(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4C947E0", Offset = "0x4C937E0", VA = "0x184C947E0", Slot = "8")]
	protected override Vector3 GHLLJPCNAOP(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4C94A10", Offset = "0x4C93A10", VA = "0x184C94A10")]
	public HDFGGOOMFJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FGJOIKMHLFJ : global::IICPDPJLKBE<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4C937D0", Offset = "0x4C927D0", VA = "0x184C937D0")]
	public FGJOIKMHLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4C93830", Offset = "0x4C92830", VA = "0x184C93830")]
	public FGJOIKMHLFJ(int DDMFGCPNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x596CC0", Offset = "0x595CC0", VA = "0x180596CC0", Slot = "4")]
	protected override float JDHEENCCIIH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4C93740", Offset = "0x4C92740", VA = "0x184C93740", Slot = "5")]
	protected override float BMJBNCNEAPH(float LLKALDKKJFP, float EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C058A0", Offset = "0x3C048A0", VA = "0x183C058A0", Slot = "6")]
	protected override float GLKFEOODFCE(float MFBIHMKFNKA, float AHIMPPGEGDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23FA3C0", Offset = "0x23F93C0", VA = "0x1823FA3C0", Slot = "7")]
	protected override float IGDIGEFLBDG(float LLKALDKKJFP, float EIFOFLJGEEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4C937C0", Offset = "0x4C927C0", VA = "0x184C937C0", Slot = "8")]
	protected override float GHLLJPCNAOP(float LLKALDKKJFP, float EIFOFLJGEEA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MACIBANHAPA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1245CA0", Offset = "0x1244CA0", VA = "0x181245CA0")]
	public static global::HJCKNLNAFCH<T1> JHOEBDGEJAE<T1>(T1 EJGPPOJHNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1730F60", Offset = "0x172FF60", VA = "0x181730F60")]
	public static global::JEIJHHJGJEP<T1, T2> JHOEBDGEJAE<T1, T2>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x18D14E0", Offset = "0x18D04E0", VA = "0x1818D14E0")]
	public static global::CJCDMFEOEOE<T1, T2, T3> JHOEBDGEJAE<T1, T2, T3>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1722D90", Offset = "0x1721D90", VA = "0x181722D90")]
	public static global::HEKCFNKIALC<T1, T2, T3, T4> JHOEBDGEJAE<T1, T2, T3, T4>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x18C8380", Offset = "0x18C7380", VA = "0x1818C8380")]
	public static global::FACCAIHFLFG<T1, T2, T3, T4, T5> JHOEBDGEJAE<T1, T2, T3, T4, T5>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x17310A0", Offset = "0x17300A0", VA = "0x1817310A0")]
	public static global::MJJNBLFMIDI<T1, T2, T3, T4, T5, T6> JHOEBDGEJAE<T1, T2, T3, T4, T5, T6>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x18D1570", Offset = "0x18D0570", VA = "0x1818D1570")]
	public static global::DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7> JHOEBDGEJAE<T1, T2, T3, T4, T5, T6, T7>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1730FD0", Offset = "0x172FFD0", VA = "0x181730FD0")]
	public static global::KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8> JHOEBDGEJAE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ, T8 OJEKLAEMBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1118320", Offset = "0x1117320", VA = "0x181118320")]
	[IteratorStateMachine(typeof(FMJNAHLLLNJ))]
	public static IEnumerable<global::JEIJHHJGJEP<T1, T2>> AKDAFHFFNKH<T1, T2>(IEnumerable<T1> OOKPIHBNHGF, IEnumerable<T2> FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1123DF0", Offset = "0x1122DF0", VA = "0x181123DF0")]
	[IteratorStateMachine(typeof(APOFFCDPLAP))]
	public static IEnumerable<global::CJCDMFEOEOE<T1, T2, T3>> AKDAFHFFNKH<T1, T2, T3>(IEnumerable<T1> OOKPIHBNHGF, IEnumerable<T2> FMMAACMCILJ, IEnumerable<T3> MCODHPOGBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E880", Offset = "0x1D5D880", VA = "0x181D5E880")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4397AC0", Offset = "0x4396AC0", VA = "0x184397AC0")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4397AD0", Offset = "0x4396AD0", VA = "0x184397AD0")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4C952C0", Offset = "0x4C942C0", VA = "0x184C952C0")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4C952E0", Offset = "0x4C942E0", VA = "0x184C952E0")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM, int OHHLHDIOGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4C95290", Offset = "0x4C94290", VA = "0x184C95290")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM, int OHHLHDIOGOJ, int ANAIFJIBBNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4C95300", Offset = "0x4C94300", VA = "0x184C95300")]
	internal static int GFPGCKJJPLF(int KNFPENNEDOE, int JEECPCJLFCJ, int OOBIOGOFEJG, int JPLBICFHNBG, int GAIKCHBNFIM, int OHHLHDIOGOJ, int ANAIFJIBBNE, int MKFOBHJDKKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HJCKNLNAFCH<T1> : IComparable<global::HJCKNLNAFCH<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x18F69B0", Offset = "0x18F59B0", VA = "0x1818F69B0")]
	public HJCKNLNAFCH(T1 EJGPPOJHNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x33558D0", Offset = "0x33548D0", VA = "0x1833558D0", Slot = "4")]
	public int CompareTo(global::HJCKNLNAFCH<T1> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3355940", Offset = "0x3354940", VA = "0x183355940", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1330A70", Offset = "0x132FA70", VA = "0x181330A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33559E0", Offset = "0x33549E0", VA = "0x1833559E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JEIJHHJGJEP<T1, T2> : IComparable<global::JEIJHHJGJEP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32DE350", Offset = "0x32DD350", VA = "0x1832DE350")]
	public JEIJHHJGJEP(T1 EJGPPOJHNJF, T2 KGMFHLFODBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x330C0A0", Offset = "0x330B0A0", VA = "0x18330C0A0", Slot = "4")]
	public int CompareTo(global::JEIJHHJGJEP<T1, T2> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x330C5B0", Offset = "0x330B5B0", VA = "0x18330C5B0", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x330CD10", Offset = "0x330BD10", VA = "0x18330CD10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x330D360", Offset = "0x330C360", VA = "0x18330D360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CJCDMFEOEOE<T1, T2, T3> : IComparable<global::CJCDMFEOEOE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x308BCC0", Offset = "0x308ACC0", VA = "0x18308BCC0")]
	public CJCDMFEOEOE(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x308B5E0", Offset = "0x308A5E0", VA = "0x18308B5E0", Slot = "4")]
	public int CompareTo(global::CJCDMFEOEOE<T1, T2, T3> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x308B6E0", Offset = "0x308A6E0", VA = "0x18308B6E0", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x308B9D0", Offset = "0x308A9D0", VA = "0x18308B9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x308BB30", Offset = "0x308AB30", VA = "0x18308BB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HEKCFNKIALC<T1, T2, T3, T4> : IComparable<global::HEKCFNKIALC<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1A80410", Offset = "0x1A7F410", VA = "0x181A80410")]
	public HEKCFNKIALC(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3767C90", Offset = "0x3766C90", VA = "0x183767C90", Slot = "4")]
	public int CompareTo(global::HEKCFNKIALC<T1, T2, T3, T4> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3767DD0", Offset = "0x3766DD0", VA = "0x183767DD0", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3767EF0", Offset = "0x3766EF0", VA = "0x183767EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3767FB0", Offset = "0x3766FB0", VA = "0x183767FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FACCAIHFLFG<T1, T2, T3, T4, T5> : IComparable<global::FACCAIHFLFG<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3438160", Offset = "0x3437160", VA = "0x183438160")]
	public FACCAIHFLFG(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3437C70", Offset = "0x3436C70", VA = "0x183437C70", Slot = "4")]
	public int CompareTo(global::FACCAIHFLFG<T1, T2, T3, T4, T5> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3437DF0", Offset = "0x3436DF0", VA = "0x183437DF0", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3437F30", Offset = "0x3436F30", VA = "0x183437F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3438030", Offset = "0x3437030", VA = "0x183438030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MJJNBLFMIDI<T1, T2, T3, T4, T5, T6> : IComparable<global::MJJNBLFMIDI<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 GHKKNLACLHA;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1A75C30", Offset = "0x1A74C30", VA = "0x181A75C30")]
	public MJJNBLFMIDI(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1A75690", Offset = "0x1A74690", VA = "0x181A75690", Slot = "4")]
	public int CompareTo(global::MJJNBLFMIDI<T1, T2, T3, T4, T5, T6> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1A75850", Offset = "0x1A74850", VA = "0x181A75850", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1A759C0", Offset = "0x1A749C0", VA = "0x181A759C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1A75AE0", Offset = "0x1A74AE0", VA = "0x181A75AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 GHKKNLACLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 FPNAKPJKKOE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35BCFC0", Offset = "0x35BBFC0", VA = "0x1835BCFC0")]
	public DNFOEJDDMKL(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35BC960", Offset = "0x35BB960", VA = "0x1835BC960", Slot = "4")]
	public int CompareTo(global::DNFOEJDDMKL<T1, T2, T3, T4, T5, T6, T7> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35BCB60", Offset = "0x35BBB60", VA = "0x1835BCB60", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35BCD00", Offset = "0x35BBD00", VA = "0x1835BCD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35BCE50", Offset = "0x35BBE50", VA = "0x1835BCE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 CGJODAAIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 KEOEKIIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 FENCGDCFMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 AFFKOACANCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 JMMKAFDHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 GHKKNLACLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 FPNAKPJKKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 OEPMILEIMJG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B91050", Offset = "0x2B90050", VA = "0x182B91050")]
	public KGKHKMINIGM(T1 EJGPPOJHNJF, T2 KGMFHLFODBN, T3 HLGMELMDMOK, T4 EPEMFEKOCKN, T5 IECLAAKKNOL, T6 KCDMLCGGNPJ, T7 MGFKFABHDLJ, T8 OJEKLAEMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B90940", Offset = "0x2B8F940", VA = "0x182B90940", Slot = "4")]
	public int CompareTo(global::KGKHKMINIGM<T1, T2, T3, T4, T5, T6, T7, T8> GKBKHIIEFAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B90B90", Offset = "0x2B8FB90", VA = "0x182B90B90", Slot = "0")]
	public override bool Equals(object GKBKHIIEFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B90D50", Offset = "0x2B8FD50", VA = "0x182B90D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B90EC0", Offset = "0x2B8FEC0", VA = "0x182B90EC0", Slot = "3")]
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
	public T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float CEHBKMAPOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C50", Offset = "0x7E2C50", VA = "0x1807E3C50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C68AF0", Offset = "0x3C67AF0", VA = "0x183C68AF0")]
	public T MNEBHPEINEN(float AHIMPPGEGDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C68950", Offset = "0x3C67950", VA = "0x183C68950")]
	public T CLFBEINLNOG(float AHIMPPGEGDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BMJBNCNEAPH(T LLKALDKKJFP, T EIFOFLJGEEA, float AHIMPPGEGDB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4C945C0", Offset = "0x4C935C0", VA = "0x184C945C0", Slot = "4")]
	protected override float BMJBNCNEAPH(float LLKALDKKJFP, float EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C94640", Offset = "0x4C93640", VA = "0x184C94640")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C98650", Offset = "0x4C97650", VA = "0x184C98650", Slot = "4")]
	protected override Vector3 BMJBNCNEAPH(Vector3 LLKALDKKJFP, Vector3 EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C98710", Offset = "0x4C97710", VA = "0x184C98710")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C92C10", Offset = "0x4C91C10", VA = "0x184C92C10", Slot = "4")]
	protected override Color BMJBNCNEAPH(Color LLKALDKKJFP, Color EIFOFLJGEEA, float AHIMPPGEGDB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4C92C60", Offset = "0x4C91C60", VA = "0x184C92C60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class BGPEIBFIKBD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AHCBFGLNCFM CHPBGBIIOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private T[] KPBDGKEGNGO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E40F0", Offset = "0x7E30F0", VA = "0x1807E40F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E3FD0", Offset = "0x7E2FD0", VA = "0x1807E3FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x33EBE00", Offset = "0x33EAE00", VA = "0x1833EBE00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x33EB3C0", Offset = "0x33EA3C0", VA = "0x1833EB3C0")]
	public static global::BGPEIBFIKBD<T> BAPHMNFAJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x33EBB40", Offset = "0x33EAB40", VA = "0x1833EBB40")]
	public static global::BGPEIBFIKBD<T> KPGOMLIBGPH(int FFHMMNBBJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33EBFE0", Offset = "0x33EAFE0", VA = "0x1833EBFE0")]
	private BGPEIBFIKBD(T[] CFJMEKFEPPD, int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33EB4F0", Offset = "0x33EA4F0", VA = "0x1833EB4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x33EB770", Offset = "0x33EA770", VA = "0x1833EB770")]
	public void IONNJMGFDPB(in T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x33EA870", Offset = "0x33E9870", VA = "0x1833EA870")]
	public void AKGGEDBEDOG(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x33EA910", Offset = "0x33E9910", VA = "0x1833EA910")]
	public void AKLLNNAAAGJ(int DDMFGCPNLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x33EBC80", Offset = "0x33EAC80", VA = "0x1833EBC80")]
	private void OCMKAFFOPBE(int FFHMMNBBJIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class IDOMIGOBOBN
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x18CC710", Offset = "0x18CB710", VA = "0x1818CC710")]
	public static global::BGPEIBFIKBD<T> BAPHMNFAJJN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x124B0F0", Offset = "0x124A0F0", VA = "0x18124B0F0")]
	public static global::BGPEIBFIKBD<T> KPGOMLIBGPH<T>(int FFHMMNBBJIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PJMDODMLCLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<HGPEMCJLGLF>> BNNJANLOGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int CCPDFCLHGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DALKGIKNPAN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D629E0", Offset = "0x1D619E0", VA = "0x181D629E0")]
	private PJMDODMLCLE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<HGPEMCJLGLF>> HNMFKJOCFBM, int OKMFEMLGIGO, int GMBFCMDCOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4C95790", Offset = "0x4C94790", VA = "0x184C95790")]
	public static PJMDODMLCLE BAPHMNFAJJN()
	{
		return default(PJMDODMLCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C958C0", Offset = "0x4C948C0", VA = "0x184C958C0")]
	public (int, int, Task) NFMIAFJEGIP(int OFDDFGBMNKD)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C95810", Offset = "0x4C94810", VA = "0x184C95810")]
	public void BOFPINOHHFN(int OFDDFGBMNKD, int GMBFCMDCOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class GFMOPFKENHB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<TKey, TVal> EJNKOJHDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TVal, TKey> IPAGMBEMLBL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1C46DB0", Offset = "0x1C45DB0", VA = "0x181C46DB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> JGBNGJPBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x16FBAB0", Offset = "0x16FAAB0", VA = "0x1816FBAB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> JHJMINNLBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x16FB0D0", Offset = "0x16FA0D0", VA = "0x1816FB0D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C46DE0", Offset = "0x1C45DE0", VA = "0x181C46DE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1C46E10", Offset = "0x1C45E10", VA = "0x181C46E10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1C46B70", Offset = "0x1C45B70", VA = "0x181C46B70")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1C46AF0", Offset = "0x1C45AF0", VA = "0x181C46AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C460C0", Offset = "0x1C450C0", VA = "0x181C460C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C46C00", Offset = "0x1C45C00", VA = "0x181C46C00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C46030", Offset = "0x1C45030", VA = "0x181C46030", Slot = "9")]
	public void Add(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C46000", Offset = "0x1C45000", VA = "0x181C46000", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C46120", Offset = "0x1C45120", VA = "0x181C46120", Slot = "8")]
	public bool ContainsKey(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C46180", Offset = "0x1C45180", VA = "0x181C46180", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C46BD0", Offset = "0x1C45BD0", VA = "0x181C46BD0", Slot = "10")]
	public bool Remove(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1C46BD0", Offset = "0x1C45BD0", VA = "0x181C46BD0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1C46CA0", Offset = "0x1C45CA0", VA = "0x181C46CA0", Slot = "11")]
	public bool TryGetValue(TKey BJKKIOODGOA, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1C46350", Offset = "0x1C45350", VA = "0x181C46350", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C461B0", Offset = "0x1C451B0", VA = "0x181C461B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1C46750", Offset = "0x1C45750", VA = "0x181C46750")]
	public void IONNJMGFDPB(TVal BPAFLPOFGHP, TKey BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C46790", Offset = "0x1C45790", VA = "0x181C46790")]
	public void IONNJMGFDPB(KeyValuePair<TVal, TKey> AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1C46210", Offset = "0x1C45210", VA = "0x181C46210")]
	public bool ENMGGOLDCEG(TVal BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1C46060", Offset = "0x1C45060", VA = "0x181C46060")]
	public bool CDHEDEIGJMA(KeyValuePair<TVal, TKey> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1C46870", Offset = "0x1C45870", VA = "0x181C46870")]
	public bool JPAMCOIJOBL(TVal BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C46870", Offset = "0x1C45870", VA = "0x181C46870")]
	public bool JPAMCOIJOBL(KeyValuePair<TVal, TKey> AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1C46AC0", Offset = "0x1C45AC0", VA = "0x181C46AC0")]
	public bool OADACMKKJNG(TVal BJKKIOODGOA, out TKey MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C462D0", Offset = "0x1C452D0", VA = "0x181C462D0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FLCPDBCJAIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1C468A0", Offset = "0x1C458A0", VA = "0x181C468A0")]
	private void MMHALBANMIA(TKey BJKKIOODGOA, TVal BPAFLPOFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1C46A40", Offset = "0x1C45A40", VA = "0x181C46A40")]
	private void NNNLOEONAIA(TKey BJKKIOODGOA, TVal BPAFLPOFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C46510", Offset = "0x1C45510", VA = "0x181C46510")]
	private bool IGOCCBLCPFH(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C465D0", Offset = "0x1C455D0", VA = "0x181C465D0")]
	private bool IGOCCBLCPFH(TVal BPAFLPOFGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1C46CD0", Offset = "0x1C45CD0", VA = "0x181C46CD0")]
	public GFMOPFKENHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class JHBMGHMNEJG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private global::JHBMGHMNEJG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8AE2B0", Offset = "0x8AD2B0", VA = "0x1808AE2B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3CCC1D0", Offset = "0x3CCB1D0", VA = "0x183CCC1D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC730", Offset = "0x3CCB730", VA = "0x183CCC730")]
		public Enumerator(global::JHBMGHMNEJG<T> MGGGNBHMHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBF60", Offset = "0x3CCAF60", VA = "0x183CCBF60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC090", Offset = "0x3CCB090", VA = "0x183CCC090", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBAB0", Offset = "0x3CCAAB0", VA = "0x183CCBAB0")]
		private void CKKMBALIMFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private T[] OGFGMOHGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int HKONJCKHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int FPNEDMKNKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int CEHIIEKHBCF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0920", Offset = "0x3CDF920", VA = "0x183CE0920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1A30", Offset = "0x3CE0A30", VA = "0x183CE1A30")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1860", Offset = "0x3CE0860", VA = "0x183CE1860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1CD0", Offset = "0x3CE0CD0", VA = "0x183CE1CD0")]
	public JHBMGHMNEJG(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1180", Offset = "0x3CE0180", VA = "0x183CE1180")]
	public void IONNJMGFDPB(T AHIMPPGEGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3CDFC50", Offset = "0x3CDEC50", VA = "0x183CDFC50")]
	public void ANMEOHCCMID(IEnumerable<T> DNFKPCJBKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0900", Offset = "0x3CDF900", VA = "0x183CE0900")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0AC0", Offset = "0x3CDFAC0", VA = "0x183CE0AC0")]
	public void HOKACCBPPDG(int KLPGLGDELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0870", Offset = "0x3CDF870", VA = "0x183CE0870")]
	public void BHNNMJPFDOE(int KLPGLGDELCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0B80", Offset = "0x3CDFB80", VA = "0x183CE0B80")]
	public void IJCLBMEAOBA(T[] ECGFLNEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE09D0", Offset = "0x3CDF9D0", VA = "0x183CE09D0")]
	public Enumerator EGDKACNFMBB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1B90", Offset = "0x3CE0B90", VA = "0x183CE1B90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1B90", Offset = "0x3CE0B90", VA = "0x183CE1B90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1680", Offset = "0x3CE0680", VA = "0x183CE1680")]
	private int OFMEBENMNMF(int CFANIPEBCPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0B50", Offset = "0x3CDFB50", VA = "0x183CE0B50")]
	private int IGKDJFLNANB(int CFANIPEBCPB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct COLDEBFAKGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IDisposable[] KPBDGKEGNGO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x595060", Offset = "0x594060", VA = "0x180595060")]
	public COLDEBFAKGC(params IDisposable[] CFJMEKFEPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x12A0F10", Offset = "0x129FF10", VA = "0x1812A0F10")]
	public static COLDEBFAKGC BAPHMNFAJJN(params IDisposable[] CFJMEKFEPPD)
	{
		return default(COLDEBFAKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C92AF0", Offset = "0x4C91AF0", VA = "0x184C92AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LNBFPELIBLH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly IDisposable IBIBKOCJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public T CIFMBHMEFPE;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DFB0", Offset = "0x1E5CFB0", VA = "0x181E5DFB0")]
	public LNBFPELIBLH(IDisposable OHIDPFBACFG, in T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1730B70", Offset = "0x172FB70", VA = "0x181730B70")]
	public static global::LNBFPELIBLH<U> MJIHGCENJMD<U>(in global::LNBFPELIBLH<T> OHIDPFBACFG, in U MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1724B10", Offset = "0x1723B10", VA = "0x181724B10")]
	public global::LNBFPELIBLH<U> NGIINMKHPJO<U>(in U MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1730BB0", Offset = "0x172FBB0", VA = "0x181730BB0")]
	public static global::LNBFPELIBLH<(T, U)> NPMKDKFMHEK<U>(in global::LNBFPELIBLH<T> OOKPIHBNHGF, in global::LNBFPELIBLH<U> FMMAACMCILJ)
	{
		return default(global::LNBFPELIBLH<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DED0", Offset = "0x1E5CED0", VA = "0x181E5DED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FADJEFHANAM
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1724AC0", Offset = "0x1723AC0", VA = "0x181724AC0")]
	public static global::LNBFPELIBLH<T> BAPHMNFAJJN<T>(IDisposable OHIDPFBACFG, in T MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1724B10", Offset = "0x1723B10", VA = "0x181724B10")]
	public static global::LNBFPELIBLH<U> MJIHGCENJMD<U, T>(in global::LNBFPELIBLH<T> MOHAGKHNADH, in U MFBIHMKFNKA)
	{
		return default(global::LNBFPELIBLH<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1724B40", Offset = "0x1723B40", VA = "0x181724B40")]
	public static global::LNBFPELIBLH<(T, U)> NPMKDKFMHEK<T, U>(in global::LNBFPELIBLH<T> OOKPIHBNHGF, in global::LNBFPELIBLH<U> FMMAACMCILJ)
	{
		return default(global::LNBFPELIBLH<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct AHCBFGLNCFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0")]
	public static AHCBFGLNCFM PMDCLFNPECG<T>([Optional] string JKKHCCJEKHF, [Optional] string POECCIABBIB, bool OOJKKAHKPEK = false)
	{
		return default(AHCBFGLNCFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class HFICLDIALAH<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Internal, External> HBMJDPHMOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<External, Internal> LCNCNMLPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IList<Internal> DPOGJPHIACD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> ICIKKALGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6D38D0", Offset = "0x6D28D0", VA = "0x1806D38D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0AF0", Offset = "0x7EFAF0", VA = "0x1807F0AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3771760", Offset = "0x3770760", VA = "0x183771760", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3771800", Offset = "0x3770800", VA = "0x183771800", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3771700", Offset = "0x3770700", VA = "0x183771700", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3771670", Offset = "0x3770670", VA = "0x183771670")]
	public HFICLDIALAH(Func<Internal, External> HBMJDPHMOMC, Func<External, Internal> LCNCNMLPALH, bool LPAAGLDJCHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x37713E0", Offset = "0x37703E0", VA = "0x1837713E0", Slot = "6")]
	public int IndexOf(External AJODLAHIEME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3771000", Offset = "0x3770000", VA = "0x183771000", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3771060", Offset = "0x3770060", VA = "0x183771060", Slot = "13")]
	public bool Contains(External AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x37710F0", Offset = "0x37700F0", VA = "0x1837710F0", Slot = "14")]
	public void CopyTo(External[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3770F10", Offset = "0x376FF10", VA = "0x183770F10", Slot = "11")]
	public void Add(External AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x37714D0", Offset = "0x37704D0", VA = "0x1837714D0", Slot = "7")]
	public void Insert(int CFANIPEBCPB, External AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x37715E0", Offset = "0x37705E0", VA = "0x1837715E0", Slot = "15")]
	public bool Remove(External AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3771570", Offset = "0x3770570", VA = "0x183771570", Slot = "8")]
	public void RemoveAt(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3771310", Offset = "0x3770310", VA = "0x183771310", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1411900", Offset = "0x1410900", VA = "0x181411900", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class LDFOIGNGDGI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<Internal, External> HBMJDPHMOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> DPOGJPHIACD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> ICIKKALGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x555B00", Offset = "0x554B00", VA = "0x180555B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2422530", Offset = "0x2421530", VA = "0x182422530", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x24224D0", Offset = "0x24214D0", VA = "0x1824224D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x18F69B0", Offset = "0x18F59B0", VA = "0x1818F69B0")]
	public LDFOIGNGDGI(Func<Internal, External> HBMJDPHMOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2422480", Offset = "0x2421480", VA = "0x182422480")]
	public LDFOIGNGDGI(IReadOnlyList<Internal> DPOGJPHIACD, Func<Internal, External> HBMJDPHMOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2422260", Offset = "0x2421260", VA = "0x182422260")]
	public void IJCLBMEAOBA(External[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x24221F0", Offset = "0x24211F0", VA = "0x1824221F0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1419570", Offset = "0x1418570", VA = "0x181419570", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class LDCJKNABAOI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> DPOGJPHIACD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> ICIKKALGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x555B00", Offset = "0x554B00", VA = "0x180555B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3D90F80", Offset = "0x3D8FF80", VA = "0x183D90F80", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3D90F20", Offset = "0x3D8FF20", VA = "0x183D90F20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x18F69B0", Offset = "0x18F59B0", VA = "0x1818F69B0")]
	public LDCJKNABAOI(IReadOnlyList<Internal> DPOGJPHIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3D90B80", Offset = "0x3D8FB80", VA = "0x183D90B80")]
	public bool CDHEDEIGJMA(External AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3D90CF0", Offset = "0x3D8FCF0", VA = "0x183D90CF0")]
	public void IJCLBMEAOBA(External[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3D90C20", Offset = "0x3D8FC20", VA = "0x183D90C20", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1411900", Offset = "0x1410900", VA = "0x181411900", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public abstract class CBJEKJFEEOD
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PIMMIIONJOM(object[] DHAMMIIHHBF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	protected CBJEKJFEEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class CCIFEKDLIEJ<T> : CBJEKJFEEOD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	protected struct JBAHDBKMMME
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum GGCBBFGINGI
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GGCBBFGINGI DMBEFJIHONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public T DJBODGKMGGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int GMANBAGCBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly bool KPNDCMOAOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly bool JGONEINHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected List<T> NODEDLJBIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private List<JBAHDBKMMME> MIGJKOOCAIL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BPJDGMIGFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3086140", Offset = "0x3085140", VA = "0x183086140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x30868C0", Offset = "0x30858C0", VA = "0x1830868C0")]
	protected CCIFEKDLIEJ(bool JGONEINHOKL, bool KPNDCMOAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3086740", Offset = "0x3085740", VA = "0x183086740")]
	protected bool MHEELPLIIOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x30867E0", Offset = "0x30857E0", VA = "0x1830867E0")]
	protected void NCEFIGOMIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x30862B0", Offset = "0x30852B0", VA = "0x1830862B0")]
	protected void DKLBLANPJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2711AB0", Offset = "0x2710AB0", VA = "0x182711AB0")]
	private static void PBCHKLGIGJN<U>(ref List<U> DPOGJPHIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3086460", Offset = "0x3085460", VA = "0x183086460", Slot = "5")]
	public void IONNJMGFDPB(T DJBODGKMGGL, bool PBEPGECDECM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x30865E0", Offset = "0x30855E0", VA = "0x1830865E0", Slot = "6")]
	public void JPAMCOIJOBL(T DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3086180", Offset = "0x3085180", VA = "0x183086180")]
	public void BNEMLHGGHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EAGAFCENEAD
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EBEHMDGBKDH : global::CCIFEKDLIEJ<Action>, EAGAFCENEAD
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4C936E0", Offset = "0x4C926E0", VA = "0x184C936E0")]
	public EBEHMDGBKDH(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4C934A0", Offset = "0x4C924A0", VA = "0x184C934A0")]
	public void PDFCGMMIIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4C93660", Offset = "0x4C92660", VA = "0x184C93660", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4C933E0", Offset = "0x4C923E0", VA = "0x184C933E0")]
	public static EBEHMDGBKDH GCJLOHFJPJA(EBEHMDGBKDH KLGKANJBCOO, Action DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4C93440", Offset = "0x4C92440", VA = "0x184C93440")]
	public static EBEHMDGBKDH KAHEKGMBKFK(EBEHMDGBKDH KLGKANJBCOO, Action DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JBBOLFHCCDM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AKCANMNILAC<T> : global::CCIFEKDLIEJ<Action<T>>, global::JBBOLFHCCDM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x16F7230", Offset = "0x16F6230", VA = "0x1816F7230")]
	public AKCANMNILAC(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD130", Offset = "0x1FDC130", VA = "0x181FDD130")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFE10", Offset = "0x1FDEE10", VA = "0x181FDFE10", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC210", Offset = "0x1FDB210", VA = "0x181FDC210")]
	public static global::AKCANMNILAC<T> GCJLOHFJPJA(global::AKCANMNILAC<T> KLGKANJBCOO, Action<T> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC2B0", Offset = "0x1FDB2B0", VA = "0x181FDC2B0")]
	public static global::AKCANMNILAC<T> KAHEKGMBKFK(global::AKCANMNILAC<T> KLGKANJBCOO, Action<T> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AIPBGCHKFIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class OIBDELKGGAL<T, U> : global::CCIFEKDLIEJ<Action<T, U>>, global::AIPBGCHKFIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x16F7230", Offset = "0x16F6230", VA = "0x1816F7230")]
	public OIBDELKGGAL(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D920", Offset = "0x3B9C920", VA = "0x183B9D920")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F590", Offset = "0x3B9E590", VA = "0x183B9F590", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3653F20", Offset = "0x3652F20", VA = "0x183653F20")]
	public static global::OIBDELKGGAL<T, U> GCJLOHFJPJA(global::OIBDELKGGAL<T, U> KLGKANJBCOO, Action<T, U> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3653FC0", Offset = "0x3652FC0", VA = "0x183653FC0")]
	public static global::OIBDELKGGAL<T, U> KAHEKGMBKFK(global::OIBDELKGGAL<T, U> KLGKANJBCOO, Action<T, U> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IIGODPLDOAF<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class BEBPFHHHDLM<T, U, V> : global::CCIFEKDLIEJ<Action<T, U, V>>, global::IIGODPLDOAF<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x16F7230", Offset = "0x16F6230", VA = "0x1816F7230")]
	public BEBPFHHHDLM(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x32E01E0", Offset = "0x32DF1E0", VA = "0x1832E01E0")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x32E2FB0", Offset = "0x32E1FB0", VA = "0x1832E2FB0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x32E00A0", Offset = "0x32DF0A0", VA = "0x1832E00A0")]
	public static global::BEBPFHHHDLM<T, U, V> GCJLOHFJPJA(global::BEBPFHHHDLM<T, U, V> KLGKANJBCOO, Action<T, U, V> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x32E0140", Offset = "0x32DF140", VA = "0x1832E0140")]
	public static global::BEBPFHHHDLM<T, U, V> KAHEKGMBKFK(global::BEBPFHHHDLM<T, U, V> KLGKANJBCOO, Action<T, U, V> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface CIFFIAPCGDC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V, W> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V, W> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class IGHACMNGGMK<T, U, V, W> : global::CCIFEKDLIEJ<Action<T, U, V, W>>, global::CIFFIAPCGDC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x16F7230", Offset = "0x16F6230", VA = "0x1816F7230")]
	public IGHACMNGGMK(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x43770E0", Offset = "0x43760E0", VA = "0x1843770E0")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE, W ENPBHFNIBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4378490", Offset = "0x4377490", VA = "0x184378490", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x16F6BE0", Offset = "0x16F5BE0", VA = "0x1816F6BE0")]
	public static global::IGHACMNGGMK<T, U, V, W> GCJLOHFJPJA(global::IGHACMNGGMK<T, U, V, W> KLGKANJBCOO, Action<T, U, V, W> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x16F6C80", Offset = "0x16F5C80", VA = "0x1816F6C80")]
	public static global::IGHACMNGGMK<T, U, V, W> KAHEKGMBKFK(global::IGHACMNGGMK<T, U, V, W> KLGKANJBCOO, Action<T, U, V, W> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GCHILPFFJFM<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V, W, X> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V, W, X> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class HKPDPNOBCFP<T, U, V, W, X> : global::CCIFEKDLIEJ<Action<T, U, V, W, X>>, global::GCHILPFFJFM<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x16F7230", Offset = "0x16F6230", VA = "0x1816F7230")]
	public HKPDPNOBCFP(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3192220", Offset = "0x3191220", VA = "0x183192220")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE, W ENPBHFNIBIC, X FMMKCBAOFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x31924C0", Offset = "0x31914C0", VA = "0x1831924C0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3191DD0", Offset = "0x3190DD0", VA = "0x183191DD0")]
	public static global::HKPDPNOBCFP<T, U, V, W, X> GCJLOHFJPJA(global::HKPDPNOBCFP<T, U, V, W, X> KLGKANJBCOO, Action<T, U, V, W, X> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3191E70", Offset = "0x3190E70", VA = "0x183191E70")]
	public static global::HKPDPNOBCFP<T, U, V, W, X> KAHEKGMBKFK(global::HKPDPNOBCFP<T, U, V, W, X> KLGKANJBCOO, Action<T, U, V, W, X> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CNMEHLFHMEP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IONNJMGFDPB(Action<T, U, V, W, X, Y> DJBODGKMGGL, bool PBEPGECDECM = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPAMCOIJOBL(Action<T, U, V, W, X, Y> DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class JKADDLCKBBL<T, U, V, W, X, Y> : global::CCIFEKDLIEJ<Action<T, U, V, W, X, Y>>, global::CNMEHLFHMEP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x16F7230", Offset = "0x16F6230", VA = "0x1816F7230")]
	public JKADDLCKBBL(bool JGONEINHOKL = false, bool KPNDCMOAOCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x25ECD40", Offset = "0x25EBD40", VA = "0x1825ECD40")]
	public void PDFCGMMIIKI(T AHIMPPGEGDB, U HIJOPBOGMED, V ANCLCJIJMKE, W ENPBHFNIBIC, X FMMKCBAOFKA, Y HPNMBFKMIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x25ED2C0", Offset = "0x25EC2C0", VA = "0x1825ED2C0", Slot = "4")]
	public override void PIMMIIONJOM(object[] DHAMMIIHHBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x25EC8F0", Offset = "0x25EB8F0", VA = "0x1825EC8F0")]
	public static global::JKADDLCKBBL<T, U, V, W, X, Y> GCJLOHFJPJA(global::JKADDLCKBBL<T, U, V, W, X, Y> KLGKANJBCOO, Action<T, U, V, W, X, Y> DJBODGKMGGL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x25EC990", Offset = "0x25EB990", VA = "0x1825EC990")]
	public static global::JKADDLCKBBL<T, U, V, W, X, Y> KAHEKGMBKFK(global::JKADDLCKBBL<T, U, V, W, X, Y> KLGKANJBCOO, Action<T, U, V, W, X, Y> DJBODGKMGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class HNOIJOKGLGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct BLIFPGNGNIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly global::HNOIJOKGLGE<T> GBELKJHPJIM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T CIFMBHMEFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x318F870", Offset = "0x318E870", VA = "0x18318F870")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x318F840", Offset = "0x318E840", VA = "0x18318F840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x595060", Offset = "0x594060", VA = "0x180595060")]
		public BLIFPGNGNIN(global::HNOIJOKGLGE<T> GBELKJHPJIM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DGMDNOMHKCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<BLIFPGNGNIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public global::HNOIJOKGLGE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x318FE10", Offset = "0x318EE10", VA = "0x18318FE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x318FFE0", Offset = "0x318EFE0", VA = "0x18318FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OLPIODHGACJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<BLIFPGNGNIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::HNOIJOKGLGE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x31A4160", Offset = "0x31A3160", VA = "0x1831A4160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x318FFE0", Offset = "0x318EFE0", VA = "0x18318FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly SemaphoreSlim ALJFKPFKHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private T JMOINLHNEAK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BDIILOOPJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3198800", Offset = "0x3197800", VA = "0x183198800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3198E60", Offset = "0x3197E60", VA = "0x183198E60")]
	public HNOIJOKGLGE(in T JMOINLHNEAK, int JDDBODAOLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3198FA0", Offset = "0x3197FA0", VA = "0x183198FA0")]
	public HNOIJOKGLGE(in T JMOINLHNEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3198860", Offset = "0x3197860", VA = "0x183198860")]
	public BLIFPGNGNIN CNIEMGJOOPO()
	{
		return default(BLIFPGNGNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3198820", Offset = "0x3197820", VA = "0x183198820")]
	public BLIFPGNGNIN CNIEMGJOOPO(CancellationToken LFOGICEEHBE)
	{
		return default(BLIFPGNGNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x31988A0", Offset = "0x31978A0", VA = "0x1831988A0")]
	[AsyncStateMachine(typeof(global::HNOIJOKGLGE<>.DGMDNOMHKCK))]
	public Task<BLIFPGNGNIN> PCCDJNEDJGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3198A00", Offset = "0x3197A00", VA = "0x183198A00")]
	[AsyncStateMachine(typeof(global::HNOIJOKGLGE<>.OLPIODHGACJ))]
	public Task<BLIFPGNGNIN> PCCDJNEDJGD(CancellationToken LFOGICEEHBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PLBOEFDNEPF
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4C95B30", Offset = "0x4C94B30", VA = "0x184C95B30")]
	public static global::HNOIJOKGLGE<HGPEMCJLGLF> BAPHMNFAJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4C95B90", Offset = "0x4C94B90", VA = "0x184C95B90")]
	public static global::HNOIJOKGLGE<HGPEMCJLGLF> BAPHMNFAJJN(int JDDBODAOLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1245CA0", Offset = "0x1244CA0", VA = "0x181245CA0")]
	public static global::HNOIJOKGLGE<T> BAPHMNFAJJN<T>(in T JMOINLHNEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1735770", Offset = "0x1734770", VA = "0x181735770")]
	public static global::HNOIJOKGLGE<T> BAPHMNFAJJN<T>(in T JMOINLHNEAK, int JDDBODAOLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class JJLEFOILODG<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate bool JEHBBCFKHJE(global::JJLEFOILODG<T> HCLJNIDPDDK);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class CKKFKMGCMFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::JJLEFOILODG<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public CKKFKMGCMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x25E0580", Offset = "0x25DF580", VA = "0x1825E0580")]
		internal bool <FindNode>b__0(global::JJLEFOILODG<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public T PHAGDNDMFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public LinkedList<global::JJLEFOILODG<T>> LJGPANFGKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public global::JJLEFOILODG<T> AAFBLFKJOEJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::JJLEFOILODG<T> PAIJNEEMEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x594D30", Offset = "0x593D30", VA = "0x180594D30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x25EBD80", Offset = "0x25EAD80", VA = "0x1825EBD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool NKICKLMEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x25EADF0", Offset = "0x25E9DF0", VA = "0x1825EADF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JACAJEJCFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x25EABA0", Offset = "0x25E9BA0", VA = "0x1825EABA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::JJLEFOILODG<T> APMCDMMCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x25EAAE0", Offset = "0x25E9AE0", VA = "0x1825EAAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x25EC7A0", Offset = "0x25EB7A0", VA = "0x1825EC7A0")]
	public JJLEFOILODG(T BHOKFNONJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x25EABE0", Offset = "0x25E9BE0", VA = "0x1825EABE0")]
	public global::JJLEFOILODG<T> GIDFGAEEKPL(T BKNBBCFNAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x25EAFE0", Offset = "0x25E9FE0", VA = "0x1825EAFE0")]
	public global::JJLEFOILODG<T> JKKAHLKGDOH(T OBEFLMEHOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x25EB240", Offset = "0x25EA240", VA = "0x1825EB240")]
	public global::JJLEFOILODG<T> JPAMCOIJOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x25EA1F0", Offset = "0x25E91F0", VA = "0x1825EA1F0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x25EBF40", Offset = "0x25EAF40", VA = "0x1825EBF40")]
	public global::JJLEFOILODG<T> NLMJEKOEJKB(T NMIEICEKHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x25EC120", Offset = "0x25EB120", VA = "0x1825EC120")]
	public static void NOMNHFIPDFC(global::JJLEFOILODG<T> CDJBNJMJFHA, JEHBBCFKHJE KGHMBCJKMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4F40", Offset = "0x1DA3F40", VA = "0x181DA4F40")]
	public static void NOMNHFIPDFC<A>(global::JJLEFOILODG<T> CDJBNJMJFHA, Func<global::JJLEFOILODG<T>, A, bool> KGHMBCJKMII, A OOLOJKLEIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x25EB2F0", Offset = "0x25EA2F0", VA = "0x1825EB2F0")]
	public static string MDMDOFECHHI(global::JJLEFOILODG<T> CDJBNJMJFHA, int LOOFANMHKBL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x25EA6B0", Offset = "0x25E96B0", VA = "0x1825EA6B0")]
	public static global::JJLEFOILODG<T> COMMHCKOOJD(global::JJLEFOILODG<T> CDJBNJMJFHA, T KLJOPFNLKDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class LFCDHBKJMOA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TResult> NMDHHOHHIAF(TRequest ANHMAOHNMJC, CancellationToken LFOGICEEHBE);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum CKFOOANKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class MJECKLMENCD
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const float DPPMKFCJLLP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TimeSpan HFIPIEMLDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int JIBAGIFKAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CKFOOANKDCG IBHIFBHNHKA;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MJECKLMENCD BNBEJHJGDAJ;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float ILADGBLKGOA
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x242C190", Offset = "0x242B190", VA = "0x18242C190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan NOLBCLIGHNN
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x242C350", Offset = "0x242B350", VA = "0x18242C350")]
		public MJECKLMENCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private readonly struct AOEEPDAOFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly TRequest ANHMAOHNMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly CancellationToken LFOGICEEHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly TaskCompletionSource<TResult> FDGKJCFKKEI;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x24198F0", Offset = "0x24188F0", VA = "0x1824198F0")]
		public AOEEPDAOFHN(TRequest ANHMAOHNMJC, TaskCompletionSource<TResult> FDGKJCFKKEI, CancellationToken LFOGICEEHBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class OJGGEANACGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public OJGGEANACGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1C46DB0", Offset = "0x1C45DB0", VA = "0x181C46DB0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JFLILNEEBPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::LFCDHBKJMOA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2421410", Offset = "0x2420410", VA = "0x182421410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CB9D0", Offset = "0x5CA9D0", VA = "0x1805CB9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DNDPHBNJKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AOEEPDAOFHN req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::LFCDHBKJMOA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public DNDPHBNJKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2420030", Offset = "0x241F030", VA = "0x182420030")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CancellationTokenSource HKJHDMEOGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<AOEEPDAOFHN> LLIELGCBGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MJECKLMENCD OJAPLLCFDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly NMDHHOHHIAF IGFAEBDKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Task PJOLKHMBDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int NKELNADKOBK;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2428CE0", Offset = "0x2427CE0", VA = "0x182428CE0")]
	public LFCDHBKJMOA(NMDHHOHHIAF IGFAEBDKGCP, [Optional] MJECKLMENCD OJAPLLCFDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2427B20", Offset = "0x2426B20", VA = "0x182427B20")]
	public Task<TResult> FEIFAAJIKOO(TRequest ANHMAOHNMJC, CancellationToken LFOGICEEHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2427790", Offset = "0x2426790", VA = "0x182427790")]
	private void ENPDOEFNEDC(AOEEPDAOFHN KBLMEAAEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x24275A0", Offset = "0x24265A0", VA = "0x1824275A0")]
	[AsyncStateMachine(typeof(global::LFCDHBKJMOA<, >.JFLILNEEBPO))]
	private Task CLFGOLHDEOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x24284B0", Offset = "0x24274B0", VA = "0x1824284B0")]
	private AOEEPDAOFHN HIHJJMBDNIA()
	{
		return default(AOEEPDAOFHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2428710", Offset = "0x2427710", VA = "0x182428710")]
	private void NLKKDOHKGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x24276B0", Offset = "0x24266B0", VA = "0x1824276B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FGBOPLLKBLE<TKey, TVal> : global::IDLNCHFLECO<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int AGOFHHDHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	internal Dictionary<TKey, (TVal value, int size)> NCDOCICEDIK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int GCBEOECAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3035240", Offset = "0x3034240", VA = "0x183035240", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int OJKGLNIFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3035270", Offset = "0x3034270", VA = "0x183035270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3035140", Offset = "0x3034140", VA = "0x183035140", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3035710", Offset = "0x3034710", VA = "0x183035710")]
	public FGBOPLLKBLE(int FFHMMNBBJIL, [Optional] AKKHDKGHBHP MBHDNFJHLLL, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x30350A0", Offset = "0x30340A0", VA = "0x1830350A0")]
	public void CDCOAMHOCNK(TKey BJKKIOODGOA, TVal MFBIHMKFNKA, bool KCPJCKLHHCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x30352A0", Offset = "0x30342A0", VA = "0x1830352A0")]
	public bool JHINLPEIGBE(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3035550", Offset = "0x3034550", VA = "0x183035550", Slot = "6")]
	public override bool OADACMKKJNG(TKey KCBJEAFAABP, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3035320", Offset = "0x3034320", VA = "0x183035320")]
	public bool NFPLOPKCNPO(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3035600", Offset = "0x3034600", VA = "0x183035600")]
	public bool OKLKPNDMMDE(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3035030", Offset = "0x3034030", VA = "0x183035030", Slot = "7")]
	public override void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x30351A0", Offset = "0x30341A0", VA = "0x1830351A0")]
	private bool DNBCLHFPMGC(TKey BJKKIOODGOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public class IDLNCHFLECO<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int AKKHDKGHBHP(TKey BJKKIOODGOA, TVal MFBIHMKFNKA);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PNKGAHIGBKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey LOKNCHMIENF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal CIFMBHMEFPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x5BD5B0", Offset = "0x5BC5B0", VA = "0x1805BD5B0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6F1140", Offset = "0x6F0140", VA = "0x1806F1140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int NBHCNACMKMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7624B0", Offset = "0x7614B0", VA = "0x1807624B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7C4530", Offset = "0x7C3530", VA = "0x1807C4530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime CNALCNMLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xB95BC0", Offset = "0xB94BC0", VA = "0x180B95BC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4854830", Offset = "0x4853830", VA = "0x184854830")]
		public PNKGAHIGBKB(TKey BJKKIOODGOA, TVal BPAFLPOFGHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const int NNJNDPLEKEF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Dictionary<TKey, LinkedListNode<PNKGAHIGBKB>> NONAKFMOEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LinkedList<PNKGAHIGBKB> ODIGGOAOGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	protected readonly AKKHDKGHBHP MBHDNFJHLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly TimeSpan JLJAGDIDIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly OPBAJAHKLKH IKAAJNOHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int NPHJKKFNEAO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int MBOBFNEGKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x584C60", Offset = "0x583C60", VA = "0x180584C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool NAMMFGCALNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x484DC60", Offset = "0x484CC60", VA = "0x18484DC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int GCBEOECAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x726DB0", Offset = "0x725DB0", VA = "0x180726DB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int KLPGLGDELCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x18C21F0", Offset = "0x18C11F0", VA = "0x1818C21F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x14119D0", Offset = "0x14109D0", VA = "0x1814119D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> JGBNGJPBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x484E4C0", Offset = "0x484D4C0", VA = "0x18484E4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x21BE3C0", Offset = "0x21BD3C0", VA = "0x1821BE3C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x36A5E60", Offset = "0x36A4E60", VA = "0x1836A5E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x484EC20", Offset = "0x484DC20", VA = "0x18484EC20")]
	public IDLNCHFLECO(int FFHMMNBBJIL, [Optional] AKKHDKGHBHP MBHDNFJHLLL, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x484E930", Offset = "0x484D930", VA = "0x18484E930")]
	public IDLNCHFLECO(TimeSpan JLJAGDIDIOG, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK, [Optional] OPBAJAHKLKH IKAAJNOHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x484E980", Offset = "0x484D980", VA = "0x18484E980")]
	public IDLNCHFLECO(int FFHMMNBBJIL, TimeSpan JLJAGDIDIOG, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK, [Optional] OPBAJAHKLKH IKAAJNOHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x484E9D0", Offset = "0x484D9D0", VA = "0x18484E9D0")]
	public IDLNCHFLECO(int FFHMMNBBJIL, AKKHDKGHBHP MBHDNFJHLLL, TimeSpan JLJAGDIDIOG, [Optional] IEqualityComparer<TKey> OIBFCHDFOIK, [Optional] OPBAJAHKLKH IKAAJNOHAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x484D990", Offset = "0x484C990", VA = "0x18484D990")]
	public void ILHIFLGOGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x484D4D0", Offset = "0x484C4D0", VA = "0x18484D4D0")]
	public void GCLFAKHIAMJ(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x484DB00", Offset = "0x484CB00", VA = "0x18484DB00")]
	public bool JPAMCOIJOBL(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x484D370", Offset = "0x484C370", VA = "0x18484D370")]
	private TVal FLCFGOMKECP(TKey KCBJEAFAABP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x484DCF0", Offset = "0x484CCF0", VA = "0x18484DCF0", Slot = "6")]
	public virtual bool OADACMKKJNG(TKey KCBJEAFAABP, out TVal MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x484CEB0", Offset = "0x484BEB0", VA = "0x18484CEB0", Slot = "7")]
	public virtual void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x484E060", Offset = "0x484D060", VA = "0x18484E060")]
	private bool OCNHJKCHKJG(PNKGAHIGBKB IOELKPFLGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x484CF20", Offset = "0x484BF20", VA = "0x18484CF20")]
	private void EADLPHOJEPF(LinkedListNode<PNKGAHIGBKB> BDDMHBNDDHE, TVal ICFAPCFNPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x484E2F0", Offset = "0x484D2F0", VA = "0x18484E2F0")]
	private void OKEGCOKGHHP(TKey BJKKIOODGOA, TVal MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x484D650", Offset = "0x484C650", VA = "0x18484D650")]
	private void IDMJEJHLIMG(PNKGAHIGBKB IOELKPFLGGG, TVal ICFAPCFNPHF, int MPAHBNHIEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public class JPEGMMBMEMP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<T> DPOGJPHIACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HashSet<T> EBDHBMBIBDL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1C46DB0", Offset = "0x1C45DB0", VA = "0x181C46DB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LFMMFBCPEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x555AF0", Offset = "0x554AF0", VA = "0x180555AF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE20", Offset = "0x2B89E20", VA = "0x182B8AE20", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AF10", Offset = "0x2B89F10", VA = "0x182B8AF10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1D6EFA0", Offset = "0x1D6DFA0", VA = "0x181D6EFA0", Slot = "11")]
	public void Add(T AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A4D0", Offset = "0x2B894D0", VA = "0x182B8A4D0")]
	public bool BGBJIKPDFEG(T AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ACC0", Offset = "0x2B89CC0", VA = "0x182B8ACC0", Slot = "15")]
	public bool Remove(T AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A6B0", Offset = "0x2B896B0", VA = "0x182B8A6B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x21EC320", Offset = "0x21EB320", VA = "0x1821EC320", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A620", Offset = "0x2B89620", VA = "0x182B8A620", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x25E1E10", Offset = "0x25E0E10", VA = "0x1825E1E10", Slot = "13")]
	public bool Contains(T AJODLAHIEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A680", Offset = "0x2B89680", VA = "0x182B8A680", Slot = "14")]
	public void CopyTo(T[] ECGFLNEOIIM, int GAEDOACAGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C46DE0", Offset = "0x1C45DE0", VA = "0x181C46DE0", Slot = "6")]
	public int IndexOf(T AJODLAHIEME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A730", Offset = "0x2B89730", VA = "0x182B8A730", Slot = "7")]
	public void Insert(int CFANIPEBCPB, T AJODLAHIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AA90", Offset = "0x2B89A90", VA = "0x182B8AA90", Slot = "8")]
	public void RemoveAt(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A9C0", Offset = "0x2B899C0", VA = "0x182B8A9C0")]
	public void MLPEKAEPDGA(Predicate<T> IJPHBEGKADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A8C0", Offset = "0x2B898C0", VA = "0x182B8A8C0")]
	public void JLAILMDDCFD(Comparison<T> GKEAECBBGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AD40", Offset = "0x2B89D40", VA = "0x182B8AD40")]
	public JPEGMMBMEMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NMEHAPGACBG
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C95330", Offset = "0x4C94330", VA = "0x184C95330")]
	public static Vector3 DDKCHJBGAMD(this GameObject NJCEGNEAEJH, float OLAIGFMFPDL)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1978B20", Offset = "0x1977B20", VA = "0x181978B20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4C97C30", Offset = "0x4C96C30", VA = "0x184C97C30")]
		public SerializedGuid(in Guid OFAPLABHPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4C97780", Offset = "0x4C96780", VA = "0x184C97780")]
		public static SerializedGuid BOMGMKJICCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4C97A40", Offset = "0x4C96A40", VA = "0x184C97A40")]
		public static SerializedGuid FPCIEGGPHEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4C97800", Offset = "0x4C96800", VA = "0x184C97800")]
		public bool CKKNCOMKHFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4C97C00", Offset = "0x4C96C00", VA = "0x184C97C00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C97B60", Offset = "0x4C96B60", VA = "0x184C97B60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4C97AD0", Offset = "0x4C96AD0", VA = "0x184C97AD0")]
		public bool HHFANCOAJID(in Guid OFAPLABHPIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4C978C0", Offset = "0x4C968C0", VA = "0x184C978C0", Slot = "7")]
		public bool Equals(SerializedGuid GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4C97960", Offset = "0x4C96960", VA = "0x184C97960", Slot = "0")]
		public override bool Equals(object OMILIKJDDEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4C97AC0", Offset = "0x4C96AC0", VA = "0x184C97AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C97890", Offset = "0x4C96890", VA = "0x184C97890", Slot = "6")]
		public int CompareTo(SerializedGuid GKBKHIIEFAH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EAGGKHPBHID : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly Type NCKNGJHPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string OOKJNEDHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool CKJBOEPDPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool MNAANMEBGIG;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4C93370", Offset = "0x4C92370", VA = "0x184C93370")]
	public EAGGKHPBHID(Type NIHLIJBPIID, string BKCKKNLMBAN, bool GCPEPIFDAIL = false, bool JJAJEADOPPC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface COFFMOEAFFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface DIDHAMMHPDI<T> : COFFMOEAFFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BHCADIEEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CEEEBHBFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DIDHAMMHPDI<T> AGKAAPEDOGB(Action<T> LALCAMKBDPG);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DIDHAMMHPDI<T> JKBNFHMHHLF(Action<T> LALCAMKBDPG);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DIDHAMMHPDI<T> AJFCEOBEKPJ(Action<T, T> BJGJPOGNNKC);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DIDHAMMHPDI<T> GNMLDEDBHGF(Action<T, T> BJGJPOGNNKC);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DIDHAMMHPDI<T> NLNKLHMDKKI(Action<string> HHLPOPLGNGL);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DIDHAMMHPDI<T> NIDFGDMHBOB(Action<string> HHLPOPLGNGL);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NGMDFKNNGDH<T> : global::DIDHAMMHPDI<T>, COFFMOEAFFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private global::OIBDELKGGAL<T, T> KKKGBJKALKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::AKCANMNILAC<T> JJMBCGJHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::AKCANMNILAC<string> FDPMJLPAIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private string FHJBPHCDOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private T AFGNBGMNGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool AFEFCGJGLGF;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1E55B80", Offset = "0x1E54B80", VA = "0x181E55B80", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool BHCADIEEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8A0", Offset = "0x6F98A0", VA = "0x1806FA8A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string CEEEBHBFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x58BFF0", Offset = "0x58AFF0", VA = "0x18058BFF0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1E6C8B0", Offset = "0x1E6B8B0", VA = "0x181E6C8B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x36A6110", Offset = "0x36A5110", VA = "0x1836A6110")]
	private void FINDIOADIDM(T LCPCMCBOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x36A6300", Offset = "0x36A5300", VA = "0x1836A6300")]
	private void MOBPJMBKICD(string LMJMILCCPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x36A6200", Offset = "0x36A5200", VA = "0x1836A6200")]
	public void IDHIAHKAEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x36A60C0", Offset = "0x36A50C0", VA = "0x1836A60C0", Slot = "6")]
	public global::DIDHAMMHPDI<T> AJFCEOBEKPJ(Action<T, T> BJGJPOGNNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x36A61B0", Offset = "0x36A51B0", VA = "0x1836A61B0", Slot = "7")]
	public global::DIDHAMMHPDI<T> GNMLDEDBHGF(Action<T, T> BJGJPOGNNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x36A6030", Offset = "0x36A5030", VA = "0x1836A6030", Slot = "4")]
	public global::DIDHAMMHPDI<T> AGKAAPEDOGB(Action<T> BJGJPOGNNKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x36A62B0", Offset = "0x36A52B0", VA = "0x1836A62B0", Slot = "5")]
	public global::DIDHAMMHPDI<T> JKBNFHMHHLF(Action<T> LALCAMKBDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x36A6410", Offset = "0x36A5410", VA = "0x1836A6410", Slot = "8")]
	public global::DIDHAMMHPDI<T> NLNKLHMDKKI(Action<string> HHLPOPLGNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x36A63A0", Offset = "0x36A53A0", VA = "0x1836A63A0", Slot = "9")]
	public global::DIDHAMMHPDI<T> NIDFGDMHBOB(Action<string> HHLPOPLGNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x36A64A0", Offset = "0x36A54A0", VA = "0x1836A64A0")]
	public NGMDFKNNGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NGMEPCBHFDK
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PBBILBLGFPP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public global::DIDHAMMHPDI<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::FCENHLGFPDA<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public PBBILBLGFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x36AD2B0", Offset = "0x36AC2B0", VA = "0x1836AD2B0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x165E490", Offset = "0x165D490", VA = "0x18165E490")]
	public static global::PKODKNLJGEP<T> AGCFOHCOPCO<T>(this global::DIDHAMMHPDI<T> AGNDECFIDCK, Action<T> IJOJDDBGAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class OPBAJAHKLKH
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class CJJMGGKJJGN : OPBAJAHKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static OPBAJAHKLKH GBAAOFDIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x4C92930", Offset = "0x4C91930", VA = "0x184C92930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override DateTime HFBLAMHLPMC
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4C929A0", Offset = "0x4C919A0", VA = "0x184C929A0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override float JNOBMJFOFHD
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4C92990", Offset = "0x4C91990", VA = "0x184C92990", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x4C92A90", Offset = "0x4C91A90", VA = "0x184C92A90")]
		public CJJMGGKJJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static OPBAJAHKLKH NBEJLFJMMKM;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static OPBAJAHKLKH BNBEJHJGDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4C95610", Offset = "0x4C94610", VA = "0x184C95610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract DateTime HFBLAMHLPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public abstract float JNOBMJFOFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	protected OPBAJAHKLKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class KIIEICGLEHF : global::CPIDDKEIFLB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4C94BB0", Offset = "0x4C93BB0", VA = "0x184C94BB0")]
	public KIIEICGLEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CPIDDKEIFLB<T> : global::NHJNCCCICOA<T>, OJIPOCLKJMJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task PLJAJCMBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x14076E0", Offset = "0x14066E0", VA = "0x1814076E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private HFADLOCOGOG OIEBLMBHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x140A260", Offset = "0x1409260", VA = "0x18140A260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1D729C0", Offset = "0x1D719C0", VA = "0x181D729C0")]
	public CPIDDKEIFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class OAHGPDDBCOB : global::JEFAICGCEHL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4C955C0", Offset = "0x4C945C0", VA = "0x184C955C0")]
	public OAHGPDDBCOB(Exception OADAOAPKMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JEFAICGCEHL<T> : global::NHJNCCCICOA<T>, OJIPOCLKJMJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private Task PLJAJCMBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x14076E0", Offset = "0x14066E0", VA = "0x1814076E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private HFADLOCOGOG OIEBLMBHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x140A260", Offset = "0x1409260", VA = "0x18140A260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x330BC80", Offset = "0x330AC80", VA = "0x18330BC80")]
	public JEFAICGCEHL(Exception OADAOAPKMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface OJIPOCLKJMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	[NotNull]
	Task MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	[NotNull]
	HFADLOCOGOG OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface NHJNCCCICOA<T> : OJIPOCLKJMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	[NotNull]
	new Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[NotNull]
	new global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class KMIBJECAJDO<TTask, T> : global::NHJNCCCICOA<T>, OJIPOCLKJMJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BINOMKCAIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public global::KMIBJECAJDO<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public BINOMKCAIFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static bool JAPNMPFGEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Task<T> OBCCEHBGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly CancellationTokenSource BEMMKBBNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool MGKCHJEDODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SynchronizationContext ELHJBJACOBC;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> MBANOJJCPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task PLJAJCMBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::PKODKNLJGEP<T> OGDMGCJENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private HFADLOCOGOG OIEBLMBHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1623420", Offset = "0x1622420", VA = "0x181623420", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool PNLEBEDNKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6D38D0", Offset = "0x6D28D0", VA = "0x1806D38D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x393AA20", Offset = "0x3939A20", VA = "0x18393AA20")]
	static KMIBJECAJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x393AB90", Offset = "0x3939B90", VA = "0x18393AB90")]
	protected KMIBJECAJDO(TTask OBCCEHBGMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x393A440", Offset = "0x3939440", VA = "0x18393A440", Slot = "1")]
	~KMIBJECAJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x393A410", Offset = "0x3939410", VA = "0x18393A410", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x393A580", Offset = "0x3939580", VA = "0x18393A580")]
	private void GPGHDCEFFGO(bool OOCNOGHMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T MDPFJACDHFB(TTask KGIFIDFCBCJ);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NMNJJEMHOIO();

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x393A860", Offset = "0x3939860", VA = "0x18393A860")]
	[CompilerGenerated]
	private void HGHBHJDBBKE(object GLCBACNALCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HEKKCAHBOND : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly Type NCKNGJHPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string OOKJNEDHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly bool CKJBOEPDPDC;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4C94A70", Offset = "0x4C93A70", VA = "0x184C94A70")]
	public HEKKCAHBOND(Type NIHLIJBPIID, string BKCKKNLMBAN, bool GCPEPIFDAIL = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x594770", Offset = "0x593770", VA = "0x180594770")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5B25B0", Offset = "0x5B15B0", VA = "0x1805B25B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public T this[int APEAIJJLBLJ, int BAKKDPDJGDH]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2468340", Offset = "0x2467340", VA = "0x182468340")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x24683E0", Offset = "0x24673E0", VA = "0x1824683E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x24682B0", Offset = "0x24672B0", VA = "0x1824682B0")]
		public Array2D(uint GPPALIDPAOJ, uint HBKDNCCDNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2468230", Offset = "0x2467230", VA = "0x182468230")]
		public void BNEMLHGGHNK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4C91AC0", Offset = "0x4C90AC0", VA = "0x184C91AC0")]
		public Array2DVector3(uint GPPALIDPAOJ, uint HBKDNCCDNCO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class AGMHEPCFBOK
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const int AIODBANILEK = -1;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const int BJPGFFEEGCP = 0;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DefaultMember("Item")]
public class EIIKLAMBHDF<THandle, TValue> : IDisposable where THandle : struct, ONPIFBCILPJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<THandle> CGBADKJGLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<TValue> FHAIKLIGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Func<TValue> CBEBOCOKCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TValue> JFJOMDFMKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int IBNJJIMMBMP;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TValue PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1C46870", Offset = "0x1C45870", VA = "0x181C46870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE28F0", Offset = "0x1CE18F0", VA = "0x181CE28F0")]
	public EIIKLAMBHDF(Action<TValue> JFJOMDFMKFD, [Optional] Func<TValue> CBEBOCOKCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2030", Offset = "0x1CE1030", VA = "0x181CE2030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD0FC0", Offset = "0x3DCFFC0", VA = "0x183DD0FC0")]
	public THandle JHOEBDGEJAE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1CE22C0", Offset = "0x1CE12C0", VA = "0x181CE22C0")]
	public THandle IONNJMGFDPB(TValue MFBIHMKFNKA)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2470", Offset = "0x1CE1470", VA = "0x181CE2470")]
	public bool JPAMCOIJOBL(THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1CE27A0", Offset = "0x1CE17A0", VA = "0x181CE27A0")]
	public bool MOKFFIOFCLL(THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1CE25E0", Offset = "0x1CE15E0", VA = "0x181CE25E0")]
	public bool KKACOOPIDFN(THandle FJNPOOOECPJ, out TValue MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1CE20F0", Offset = "0x1CE10F0", VA = "0x181CE20F0")]
	public TValue FLCFGOMKECP(THandle FJNPOOOECPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2140", Offset = "0x1CE1140", VA = "0x181CE2140")]
	public bool HJIKHAFGDCE(THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1CE28C0", Offset = "0x1CE18C0", VA = "0x181CE28C0")]
	private THandle OLPLOCJFGDA(int CFANIPEBCPB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1E00", Offset = "0x1CE0E00", VA = "0x181CE1E00")]
	private TValue AGCFOHCOPCO(int CFANIPEBCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2880", Offset = "0x1CE1880", VA = "0x181CE2880")]
	private void MPFEHCJBFEN(int CFANIPEBCPB, in THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE20B0", Offset = "0x1CE10B0", VA = "0x181CE20B0")]
	private void FINDIOADIDM(int CFANIPEBCPB, in TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1EB0", Offset = "0x1CE0EB0", VA = "0x181CE1EB0")]
	private THandle BPHELOCGMOE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2520", Offset = "0x1CE1520", VA = "0x181CE2520")]
	private void KGOOGDAJAII(THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1DF0", Offset = "0x1CE0DF0", VA = "0x181CE1DF0")]
	private int ABHJLFLOGIL(int CEHIIEKHBCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1FC0", Offset = "0x1CE0FC0", VA = "0x181CE1FC0")]
	private bool CGAFMEDMOHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x726D60", Offset = "0x725D60", VA = "0x180726D60")]
	private void HMBOALFDFBB(THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1E30", Offset = "0x1CE0E30", VA = "0x181CE1E30")]
	private bool AHNNHLHJIHI(out THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1CE21F0", Offset = "0x1CE11F0", VA = "0x181CE21F0")]
	private bool IMCGOJLNCLE(out THandle FJNPOOOECPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1FD0", Offset = "0x1CE0FD0", VA = "0x181CE1FD0")]
	private void DFIKHFEONMP(THandle FJNPOOOECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2680", Offset = "0x1CE1680", VA = "0x181CE2680")]
	private void MDBOMMDFBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface ONPIFBCILPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int MPBCIHFGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int JJMKFDIMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface OINIFKJKGPO<T> : ONPIFBCILPJ, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class ELIEKGJGIIG
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2098210", Offset = "0x2097210", VA = "0x182098210")]
	public static bool POFKFEFGGPI<T>(this T FJNPOOOECPJ) where T : struct, ONPIFBCILPJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class BFCLAGKEKNI
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private enum NAFIJBDIGHD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int MNKLNMHPAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool OOAPLMMOFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NAFIJBDIGHD CJJBKHDOFPA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool HAOGDNGPDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4C91B60", Offset = "0x4C90B60", VA = "0x184C91B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool BAKMAHIBJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4C91B20", Offset = "0x4C90B20", VA = "0x184C91B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4C92900", Offset = "0x4C91900", VA = "0x184C92900")]
	public BFCLAGKEKNI(bool OOAPLMMOFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4C91FB0", Offset = "0x4C90FB0", VA = "0x184C91FB0")]
	public void JHACFFHGIOA(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4C92540", Offset = "0x4C91540", VA = "0x184C92540")]
	public void KHBLAPKOPBE(int MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4C927D0", Offset = "0x4C917D0", VA = "0x184C927D0")]
	public void PACMCKKPKBP(uint KDMOIPMIEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4C91B40", Offset = "0x4C90B40", VA = "0x184C91B40")]
	public void CEHJCFGKCLI(bool OHKLJBLFOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4C91F70", Offset = "0x4C90F70", VA = "0x184C91F70")]
	public void HOLOGFAPIBF(long LACLNGNLGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4C91F30", Offset = "0x4C90F30", VA = "0x184C91F30")]
	public void EICEODGDMMM(ulong IGECKMJOJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4C92760", Offset = "0x4C91760", VA = "0x184C92760")]
	public void LNPEPBGGLOJ(string ADPHNNDAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4C925F0", Offset = "0x4C915F0", VA = "0x184C925F0")]
	public void LCOCKNIDJNA(Enum OADAOAPKMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4C927E0", Offset = "0x4C917E0", VA = "0x184C927E0")]
	public void POLJJNIICFJ(IList DPOGJPHIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2710F50", Offset = "0x270FF50", VA = "0x182710F50")]
	public void MANIAMAADGB<T, U>(Dictionary<T, U> CDJNOPFDFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4C91B70", Offset = "0x4C90B70", VA = "0x184C91B70")]
	private void DMAHKCKJFIJ(IDictionary CDJNOPFDFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4C924D0", Offset = "0x4C914D0", VA = "0x184C924D0")]
	public int JNHBJDMKHLK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4C92680", Offset = "0x4C91680", VA = "0x184C92680")]
	public short LEMKNBFEJAH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4C91B30", Offset = "0x4C90B30", VA = "0x184C91B30")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4C926F0", Offset = "0x4C916F0", VA = "0x184C926F0")]
	private void LHCIGOIMIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class KFFLHNDGAEO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal class ODMEBLIFMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode EBOHMGAPLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public TNode HNINKJAJDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public NAEJIGJGMFF OHIDPFBACFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<NAEJIGJGMFF> OKNIBCJGGNN;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public ODMEBLIFMDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal struct NAEJIGJGMFF : IComparable<NAEJIGJGMFF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int PEMFPBGDFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public TClaimant NNJLMOPKJFF;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xC16560", Offset = "0xC15560", VA = "0x180C16560")]
		public NAEJIGJGMFF(int PEMFPBGDFNJ, TClaimant NNJLMOPKJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2B95560", Offset = "0x2B94560", VA = "0x182B95560")]
		public bool OBONPAIAMCL(in NAEJIGJGMFF GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2B95550", Offset = "0x2B94550", VA = "0x182B95550")]
		public bool ELMHODMCJMO(in NAEJIGJGMFF GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2B95540", Offset = "0x2B94540", VA = "0x182B95540", Slot = "4")]
		public int CompareTo(NAEJIGJGMFF GKBKHIIEFAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2B955C0", Offset = "0x2B945C0", VA = "0x182B955C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum OLJHOPPODEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class EIEABMANNLF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::KFFLHNDGAEO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1703C90", Offset = "0x1702C90", VA = "0x181703C90")]
		[DebuggerHidden]
		public EIEABMANNLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2B84490", Offset = "0x2B83490", VA = "0x182B84490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2B84650", Offset = "0x2B83650", VA = "0x182B84650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2B84570", Offset = "0x2B83570", VA = "0x182B84570", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x14122F0", Offset = "0x14112F0", VA = "0x1814122F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly global::KNLFFMDGOJH<ODMEBLIFMDD> FNPLPBPNNKI;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly global::KNLFFMDGOJH<List<NAEJIGJGMFF>> DBFKNIKMIEL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int NINJJDNBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal readonly Dictionary<TClaimant, TNode> BJAKOOLNPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal readonly Dictionary<TNode, ODMEBLIFMDD> PINCLKLHCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private OLJHOPPODEA MLBEKKOCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool DOGKKFFGKFM;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode COKOIMAHPPF(TNode HCLJNIDPDDK);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IOOMPBKDKCA(TNode HCLJNIDPDDK, TClaimant LNMBBLAKCIJ, TClaimant CLCGLKCKEBM);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2B90780", Offset = "0x2B8F780", VA = "0x182B90780")]
	public KFFLHNDGAEO(OLJHOPPODEA MLBEKKOCNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F700", Offset = "0x2B8E700", VA = "0x182B8F700")]
	public void EDPILGFGMNN(TNode HCLJNIDPDDK, TNode NMIEICEKHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FFE0", Offset = "0x2B8EFE0", VA = "0x182B8FFE0")]
	public void HNIPJPFKIAI(TClaimant NNJLMOPKJFF, TNode MGGOIIKDFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F4A0", Offset = "0x2B8E4A0", VA = "0x182B8F4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FD80", Offset = "0x2B8ED80", VA = "0x182B8FD80")]
	private void HFLLEIPMLGK(TClaimant NNJLMOPKJFF, TNode PDOCFPMNNEP, TNode MGGOIIKDFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2B90350", Offset = "0x2B8F350", VA = "0x182B90350")]
	private int IKFDBCCEMGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F060", Offset = "0x2B8E060", VA = "0x182B8F060")]
	private void AFIMLPECDDG(TClaimant NNJLMOPKJFF, TNode IEIMPPPOHFM, TNode JJBLMEHAEFO, int ADKPJALDKLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2B90490", Offset = "0x2B8F490", VA = "0x182B90490")]
	private void KJMODNKNMMA(NAEJIGJGMFF COFIPGENMLP, ODMEBLIFMDD LKNKLDCMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2B900E0", Offset = "0x2B8F0E0", VA = "0x182B900E0")]
	private void IDIJIPBBGAE(TClaimant NNJLMOPKJFF, TNode IEIMPPPOHFM, TNode JJBLMEHAEFO, int ADKPJALDKLA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2B90520", Offset = "0x2B8F520", VA = "0x182B90520")]
	private void NBDHFODCAFK(NAEJIGJGMFF COFIPGENMLP, TNode HCLJNIDPDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FC80", Offset = "0x2B8EC80", VA = "0x182B8FC80")]
	private void GGJFPFENGGK(NAEJIGJGMFF COFIPGENMLP, ODMEBLIFMDD LKNKLDCMLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EF20", Offset = "0x2B8DF20", VA = "0x182B8EF20")]
	private void AADJKDMNBLI(ODMEBLIFMDD LKNKLDCMLBJ, bool MCJMIFGIFHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F840", Offset = "0x2B8E840", VA = "0x182B8F840")]
	private void FGNNMMENJDI(ODMEBLIFMDD LKNKLDCMLBJ, TNode NMIEICEKHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2B903C0", Offset = "0x2B8F3C0", VA = "0x182B903C0")]
	[IteratorStateMachine(typeof(global::KFFLHNDGAEO<, >.EIEABMANNLF))]
	private IEnumerable<TNode> JIDFFNCGFEL(TNode IEIMPPPOHFM, TNode JJBLMEHAEFO, bool HMLOFKGNHCH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F780", Offset = "0x2B8E780", VA = "0x182B8F780")]
	private ODMEBLIFMDD EIDMBFEMFFL(TNode HCLJNIDPDDK, TNode HNINKJAJDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F310", Offset = "0x2B8E310", VA = "0x182B8F310")]
	private ODMEBLIFMDD CIPNFIHKJCL(TNode HCLJNIDPDDK, TNode HNINKJAJDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FE20", Offset = "0x2B8EE20", VA = "0x182B8FE20")]
	private void HJHAIHAMFJD(ODMEBLIFMDD LKNKLDCMLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class LOKMBFDFBBI<T> : IEnumerable<global::LOKMBFDFBBI<T>.CICAEPGOJOG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct CICAEPGOJOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T MFBIHMKFNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int CFANIPEBCPB;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class EFJMKBHEKNO : IEnumerator<CICAEPGOJOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private global::LOKMBFDFBBI<T> EHEAKAJJFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int CFANIPEBCPB;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x22584C0", Offset = "0x22574C0", VA = "0x1822584C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public CICAEPGOJOG LFOABFNFCIP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x3700CE0", Offset = "0x36FFCE0", VA = "0x183700CE0", Slot = "4")]
			get
			{
				return default(CICAEPGOJOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x252AA10", Offset = "0x2529A10", VA = "0x18252AA10")]
		public EFJMKBHEKNO(global::LOKMBFDFBBI<T> EHEAKAJJFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3700C50", Offset = "0x36FFC50", VA = "0x183700C50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xB6C8B0", Offset = "0xB6B8B0", VA = "0x180B6C8B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AF0", Offset = "0x8F8AF0", VA = "0x1808F9AF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct NHBDEPKGADE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool FLIEOIPAEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public T MFBIHMKFNKA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int HMGIAHPBGIL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Dictionary<T, int> BEPFPHIFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NHBDEPKGADE[] IDCBCHHALAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CBGPPAKBKFL;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x16FBAB0", Offset = "0x16FAAB0", VA = "0x1816FBAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x370A7A0", Offset = "0x37097A0", VA = "0x18370A7A0")]
	public static global::LOKMBFDFBBI<T> MONAKNLGJEJ(CICAEPGOJOG[] KMPJJNLEEIE, bool NMNDMGJDNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x370AC00", Offset = "0x3709C00", VA = "0x18370AC00")]
	public LOKMBFDFBBI(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1E56330", Offset = "0x1E55330", VA = "0x181E56330")]
	public bool MOKBLDMAJLJ(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x370A570", Offset = "0x3709570", VA = "0x18370A570")]
	public bool DBABMHEGJBL(int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x370A350", Offset = "0x3709350", VA = "0x18370A350")]
	public bool CDHEDEIGJMA(Func<T, bool> OKKBNEOGAHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x370A5D0", Offset = "0x37095D0", VA = "0x18370A5D0")]
	public int HCPCGNLKGEO(T MFBIHMKFNKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x3709FF0", Offset = "0x3708FF0", VA = "0x183709FF0")]
	public T AGCFOHCOPCO(int CFANIPEBCPB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x370A300", Offset = "0x3709300", VA = "0x18370A300")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x370A0B0", Offset = "0x37090B0", VA = "0x18370A0B0")]
	public bool BGBJIKPDFEG(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x370A0D0", Offset = "0x37090D0", VA = "0x18370A0D0")]
	public bool BGBJIKPDFEG(T MFBIHMKFNKA, int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x370A6D0", Offset = "0x37096D0", VA = "0x18370A6D0")]
	public bool JPAMCOIJOBL(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x370A060", Offset = "0x3709060", VA = "0x18370A060")]
	public bool AKGGEDBEDOG(int CFANIPEBCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x370A620", Offset = "0x3709620", VA = "0x18370A620")]
	private void IGOCCBLCPFH(int CFANIPEBCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x370A400", Offset = "0x3709400", VA = "0x18370A400")]
	public CICAEPGOJOG[] CINJAKHIFFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x370A750", Offset = "0x3709750", VA = "0x18370A750")]
	private int MMABGFKMFNF(int HKONJCKHNHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x370AB80", Offset = "0x3709B80", VA = "0x18370AB80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x370AB80", Offset = "0x3709B80", VA = "0x18370AB80", Slot = "4")]
	private IEnumerator<CICAEPGOJOG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KNLFFMDGOJH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly Stack<T> PAJHPAKOEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<T> ALDNJFCDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int JKGIDKMPKOE;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int AJGKJILBEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2468480", Offset = "0x2467480", VA = "0x182468480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int OEJAOIIIMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x24688E0", Offset = "0x24678E0", VA = "0x1824688E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x393AFE0", Offset = "0x3939FE0", VA = "0x18393AFE0")]
	public static global::KNLFFMDGOJH<T> ACDGHIPBBPJ(int FFHMMNBBJIL = 0, int JKGIDKMPKOE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x393B560", Offset = "0x393A560", VA = "0x18393B560")]
	public static global::KNLFFMDGOJH<T> JFBLJFEKLOJ(int FFHMMNBBJIL = 0, int JKGIDKMPKOE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x393BA60", Offset = "0x393AA60", VA = "0x18393BA60")]
	public KNLFFMDGOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x393B8D0", Offset = "0x393A8D0", VA = "0x18393B8D0")]
	public KNLFFMDGOJH(int FFHMMNBBJIL, int JKGIDKMPKOE = int.MaxValue, bool EADHAADLFIN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x393B630", Offset = "0x393A630", VA = "0x18393B630")]
	public T KBMCDAMBKBM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x393B810", Offset = "0x393A810", VA = "0x18393B810")]
	public void PFICBFAAIAB(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x393B400", Offset = "0x393A400", VA = "0x18393B400")]
	private void FKMMDOHKEKD(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x393B1C0", Offset = "0x393A1C0", VA = "0x18393B1C0")]
	private void ENNHGPLGIMA(T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x393B4C0", Offset = "0x393A4C0", VA = "0x18393B4C0")]
	[Conditional("DEBUG_BUILD")]
	private void JBMJHBEJEBA(T HLPIADCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x393B760", Offset = "0x393A760", VA = "0x18393B760")]
	[Conditional("DEBUG_BUILD")]
	private void LKPPBFEOIPO(T HLPIADCDEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x393B0B0", Offset = "0x393A0B0", VA = "0x18393B0B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x393B1E0", Offset = "0x393A1E0", VA = "0x18393B1E0")]
	private void FEHJDDJPFMG(IEnumerable<T> FHAIKLIGKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class HNONIKHNIAE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<int, T> OBBCJBEKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private T HCCMBKBGAND;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public virtual T MAOBAKDEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool IKOBEMDIJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3199730", Offset = "0x3198730", VA = "0x183199730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x3199770", Offset = "0x3198770", VA = "0x183199770")]
	public bool OKEGCOKGHHP(T MFBIHMKFNKA, int PEMFPBGDFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x31991D0", Offset = "0x31981D0", VA = "0x1831991D0")]
	public bool EKLFHNDDCHK(int PEMFPBGDFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3199230", Offset = "0x3198230", VA = "0x183199230")]
	public T MHAMMMHDKPG(int IBDGABPGKBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3198FD0", Offset = "0x3197FD0", VA = "0x183198FD0")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x3199030", Offset = "0x3198030", VA = "0x183199030")]
	private bool DCDJDNGGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3199700", Offset = "0x3198700", VA = "0x183199700")]
	public bool OADACMKKJNG(int PEMFPBGDFNJ, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3199830", Offset = "0x3198830", VA = "0x183199830")]
	public HNONIKHNIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BBOLAJFGAKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	protected struct OALIDBPBKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public T CIFMBHMEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int FCAGPCJEOGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	protected readonly List<OALIDBPBKPI> OGFGMOHGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T ILGDOGHOLPL;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1C46DB0", Offset = "0x1C45DB0", VA = "0x181C46DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x32DA780", Offset = "0x32D9780", VA = "0x1832DA780")]
	public bool CDHEDEIGJMA(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x32DAC50", Offset = "0x32D9C50", VA = "0x1832DAC50")]
	public void IONNJMGFDPB(T MFBIHMKFNKA, int PEMFPBGDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x32DACF0", Offset = "0x32D9CF0", VA = "0x1832DACF0")]
	public bool JPAMCOIJOBL(T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x32DA720", Offset = "0x32D9720", VA = "0x1832DA720")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x32DAE10", Offset = "0x32D9E10", VA = "0x1832DAE10")]
	public T LJGMCDKALNL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x32DABE0", Offset = "0x32D9BE0", VA = "0x1832DABE0")]
	public T HIHJJMBDNIA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x32DA9D0", Offset = "0x32D99D0", VA = "0x1832DA9D0")]
	private void DIPMBAGDIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x32DAEA0", Offset = "0x32D9EA0", VA = "0x1832DAEA0")]
	public BBOLAJFGAKA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[PAOKLKEFIEK(ELHMLMEGENM.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x4C96190", Offset = "0x4C95190", VA = "0x184C96190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4C96660", Offset = "0x4C95660", VA = "0x184C96660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x4C96480", Offset = "0x4C95480", VA = "0x184C96480")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4C96800", Offset = "0x4C95800", VA = "0x184C96800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C96050", Offset = "0x4C95050", VA = "0x184C96050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4C96520", Offset = "0x4C95520", VA = "0x184C96520")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4C96340", Offset = "0x4C95340", VA = "0x184C96340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4C95FB0", Offset = "0x4C94FB0", VA = "0x184C95FB0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface FOLLCMPNIHI
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class ResourcePrefabReference<T> : FOLLCMPNIHI where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x247CE30", Offset = "0x247BE30", VA = "0x18247CE30", Slot = "4")]
		public virtual T BNPMELKEHHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FLHOGBKOLPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Dictionary<byte, DLGPNEBEOHB> JKCCECLKNBE;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DLGPNEBEOHB IEAJJMBGGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x595020", Offset = "0x594020", VA = "0x180595020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551490", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 BKEHFPINNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xC66350", Offset = "0xC65350", VA = "0x180C66350")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E555E0", Offset = "0x1E545E0", VA = "0x181E555E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Vector2 NDELDOJOOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xDD0C40", Offset = "0xDCFC40", VA = "0x180DD0C40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDD0CD0", Offset = "0xDCFCD0", VA = "0x180DD0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector2 CKBOCLCBPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x4C93F70", Offset = "0x4C92F70", VA = "0x184C93F70")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4C93F90", Offset = "0x4C92F90", VA = "0x184C93F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int IOHIHHEOEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEE0", Offset = "0x5BDEE0", VA = "0x1805BEEE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x726D60", Offset = "0x725D60", VA = "0x180726D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4C940A0", Offset = "0x4C930A0", VA = "0x184C940A0")]
	public FLHOGBKOLPD(Bounds CNHJLDCNPLF, Vector2[] EMLHFDKIBFL, int IHCFPBKGNLM, byte HKONJCKHNHA, float KGGJGAKHLBP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4C938A0", Offset = "0x4C928A0", VA = "0x184C938A0")]
	public DLGPNEBEOHB BNGOHIAFBDF(byte CFANIPEBCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C93FB0", Offset = "0x4C92FB0", VA = "0x184C93FB0")]
	public void OFFHMGDFBCD(Vector3 HKHJMHKLNGP, float LBMJIPDOPHA, float BPNPGJLDNFO, ref List<byte> LNBLEMLJALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C93900", Offset = "0x4C92900", VA = "0x184C93900")]
	public void IOHILFNMPBD(DLGPNEBEOHB.JNHHCFABGJO GFMFEAGKBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4C93920", Offset = "0x4C92920", VA = "0x184C93920")]
	private DLGPNEBEOHB LADEPALGAIN(byte CFANIPEBCPB, DLGPNEBEOHB.LILHJBIOFCO AJHJPMNOCKD, DLGPNEBEOHB HNINKJAJDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4C93A50", Offset = "0x4C92A50", VA = "0x184C93A50")]
	private void LKLIBJFDFNF(DLGPNEBEOHB HNINKJAJDDL, Vector2[] EMLHFDKIBFL, int JJCOGDKKHPM, int BJNPMBDLGJL, int NMJPGMCAOHB, int NDJPDEIAICB, float KGGJGAKHLBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DLGPNEBEOHB
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum LILHJBIOFCO
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum JNHHCFABGJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte MLEJCNHKNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public Vector3 BCBLMKFHAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Vector3 NBHCNACMKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3 BJEGEAICIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Vector3 NDBKNGPDPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public LILHJBIOFCO FLAJFDCHFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public DLGPNEBEOHB PAIJNEEMEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public List<DLGPNEBEOHB> JJDIIMCKGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool IHEMKFENCDC;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4C93350", Offset = "0x4C92350", VA = "0x184C93350")]
	public DLGPNEBEOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C932F0", Offset = "0x4C922F0", VA = "0x184C932F0")]
	public DLGPNEBEOHB(byte DDEJHPOCOHL, LILHJBIOFCO AJHJPMNOCKD, DLGPNEBEOHB HNINKJAJDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C92F60", Offset = "0x4C91F60", VA = "0x184C92F60")]
	public void GIDFGAEEKPL(DLGPNEBEOHB PPMKNBDKPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010")]
	public void IOHILFNMPBD(int IDGDPHLODEH, JNHHCFABGJO GFMFEAGKBFB, int BNLGPNOKFCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4C93060", Offset = "0x4C92060", VA = "0x184C93060")]
	public void OFFHMGDFBCD(List<byte> LNBLEMLJALE, Vector3 HKHJMHKLNGP, float LBMJIPDOPHA, float BPNPGJLDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4C93000", Offset = "0x4C92000", VA = "0x184C93000")]
	public bool NAIFPHOHEMD(Vector3 DICGPBMCFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4C92F20", Offset = "0x4C91F20", VA = "0x184C92F20")]
	public bool FIBMPEPNGJB(Vector3 DICGPBMCFJD, float NEGAIAIJGIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class IHLLLFEBCML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly Dictionary<T, object> KFEPAACFODC;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x16F89A0", Offset = "0x16F79A0", VA = "0x1816F89A0")]
	public bool BCHBCPBDNOD(T AJHCCDOFFFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x16F8A30", Offset = "0x16F7A30", VA = "0x1816F8A30")]
	public bool BCHBCPBDNOD(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x16F89D0", Offset = "0x16F79D0", VA = "0x1816F89D0")]
	public bool BCHBCPBDNOD(T AJHCCDOFFFG, object JGMHCJIBOFB, out object MIBKBCGIIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x16F88D0", Offset = "0x16F78D0", VA = "0x1816F88D0")]
	public bool AAJOBGDBHHB(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x16F8A70", Offset = "0x16F7A70", VA = "0x1816F8A70")]
	public bool FDPOLKLFLIC(T AJHCCDOFFFG, object JGMHCJIBOFB, out object MIBKBCGIIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x16F8910", Offset = "0x16F7910", VA = "0x1816F8910")]
	public bool AAJOBGDBHHB(T AJHCCDOFFFG, object JGMHCJIBOFB, out object MIBKBCGIIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x16F8AB0", Offset = "0x16F7AB0", VA = "0x1816F8AB0")]
	public void ICKJDPHGBLD(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x16F8AE0", Offset = "0x16F7AE0", VA = "0x1816F8AE0")]
	public void MIIAJJKDCIG(T AJHCCDOFFFG, object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x16F8B80", Offset = "0x16F7B80", VA = "0x1816F8B80")]
	public IHLLLFEBCML()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct HLMNOOAOIJP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private readonly List<Component> DPOGJPHIACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private readonly bool MJLKOPMDDPB;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xE02FF0", Offset = "0xE01FF0", VA = "0x180E02FF0")]
			public HLMNOOAOIJP(List<Component> DPOGJPHIACD, bool MJLKOPMDDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x246DFD0", Offset = "0x246CFD0", VA = "0x18246DFD0")]
			public GEIPCAAEIPN<T> EGDKACNFMBB()
			{
				return default(GEIPCAAEIPN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x246E040", Offset = "0x246D040", VA = "0x18246E040", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x246E040", Offset = "0x246D040", VA = "0x18246E040", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public struct GEIPCAAEIPN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private readonly List<Component> DPOGJPHIACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private readonly bool MJLKOPMDDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int CFANIPEBCPB;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public T LFOABFNFCIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x246DE70", Offset = "0x246CE70", VA = "0x18246DE70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x246DE00", Offset = "0x246CE00", VA = "0x18246DE00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x246DE40", Offset = "0x246CE40", VA = "0x18246DE40")]
			public GEIPCAAEIPN(List<Component> DPOGJPHIACD, bool MJLKOPMDDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x246DD30", Offset = "0x246CD30", VA = "0x18246DD30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x246DD40", Offset = "0x246CD40", VA = "0x18246DD40", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x246DDF0", Offset = "0x246CDF0", VA = "0x18246DDF0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x4C984C0", Offset = "0x4C974C0", VA = "0x184C984C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x4C98480", Offset = "0x4C97480", VA = "0x184C98480")]
		public ToolHierarchyCache(GameObject MILFJDDFCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4C97CF0", Offset = "0x4C96CF0", VA = "0x184C97CF0")]
		private void EMFGCIHFDBD(GameObject MILFJDDFCJD, bool GFIOFEMPBAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4C97E10", Offset = "0x4C96E10", VA = "0x184C97E10")]
		public static void EMFGCIHFDBD(GameObject MILFJDDFCJD, ref ToolHierarchyCache MFCNIHPOHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x4C97F90", Offset = "0x4C96F90", VA = "0x184C97F90")]
		public void KMHMPGAMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x4C983D0", Offset = "0x4C973D0", VA = "0x184C983D0")]
		public void NMALNLEBFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x186F7F0", Offset = "0x186E7F0", VA = "0x18186F7F0")]
		public void OKKCAHOECKG<T>(Action<T> DJBODGKMGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4C98060", Offset = "0x4C97060", VA = "0x184C98060")]
		public Component LBILJMFOKPD(Type DMBEFJIHONB, bool MJLKOPMDDPB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x15EDEE0", Offset = "0x15ECEE0", VA = "0x1815EDEE0")]
		public T LBILJMFOKPD<T>(bool MJLKOPMDDPB = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x4C97C60", Offset = "0x4C96C60", VA = "0x184C97C60")]
		public HLMNOOAOIJP<Component> EIFAKEMCADD(Type DMBEFJIHONB, bool MJLKOPMDDPB = false)
		{
			return default(HLMNOOAOIJP<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2056F30", Offset = "0x2055F30", VA = "0x182056F30")]
		public HLMNOOAOIJP<T> EIFAKEMCADD<T>(bool MJLKOPMDDPB = false) where T : class
		{
			return default(HLMNOOAOIJP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4C98120", Offset = "0x4C97120", VA = "0x184C98120")]
		public List<Component> LDIJDDOFNBK(Type DMBEFJIHONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4C97EA0", Offset = "0x4C96EA0", VA = "0x184C97EA0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FMMKCBAOFKA, ToolHierarchyCache HPNMBFKMIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4C97F20", Offset = "0x4C96F20", VA = "0x184C97F20", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OMILIKJDDEJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class FDGDJOILLNJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int FFHMMNBBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int ABLOAKJOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<T> POAAANHIJLJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2468480", Offset = "0x2467480", VA = "0x182468480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public T BODDCIMCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x302D710", Offset = "0x302C710", VA = "0x18302D710")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public T BMOFFNMMELM
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x302D4A0", Offset = "0x302C4A0", VA = "0x18302D4A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public T DEIGKLCIGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x302D990", Offset = "0x302C990", VA = "0x18302D990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x302D9E0", Offset = "0x302C9E0", VA = "0x18302D9E0")]
	public FDGDJOILLNJ(int FFHMMNBBJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x302D560", Offset = "0x302C560", VA = "0x18302D560")]
	public void IONNJMGFDPB(T ACKELKANIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x302D460", Offset = "0x302C460", VA = "0x18302D460")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x302D830", Offset = "0x302C830", VA = "0x18302D830")]
	public void MLPGNGJGJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x302D8D0", Offset = "0x302C8D0", VA = "0x18302D8D0")]
	public void PFKGGJODGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x302D550", Offset = "0x302C550", VA = "0x18302D550")]
	public void IHPGFDANMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class GEFCLDLCIKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool MIAACIGJENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Action DJBODGKMGGL;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public static GEFCLDLCIKC OIEOMEANLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x4C946A0", Offset = "0x4C936A0", VA = "0x184C946A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool OPGCJKPKIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5550C0", Offset = "0x5540C0", VA = "0x1805550C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xB9CB40", Offset = "0xB9BB40", VA = "0x180B9CB40")]
	public GEFCLDLCIKC(Action DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4C94680", Offset = "0x4C93680", VA = "0x184C94680")]
	public void GLIJLNLELKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4C94680", Offset = "0x4C93680", VA = "0x184C94680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class LJFEHNFEACP
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010")]
	public static void MADBMDMFNLL(PNCONINMAHM DLHKADEDHJJ, string FKNOJLALCPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class HFLGMHECNDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct KIMHDECCLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int FCAGPCJEOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public T CIFMBHMEFPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<object, KIMHDECCLKC> OBBCJBEKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private T HCCMBKBGAND;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public virtual T MAOBAKDEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xC66350", Offset = "0xC65350", VA = "0x180C66350", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1E555E0", Offset = "0x1E545E0", VA = "0x181E555E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool IKOBEMDIJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x334EF20", Offset = "0x334DF20", VA = "0x18334EF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public object BMFLNDCOGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x334F450", Offset = "0x334E450", VA = "0x18334F450")]
	public bool OKEGCOKGHHP(T MFBIHMKFNKA, object JGMHCJIBOFB, int PEMFPBGDFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x334E8E0", Offset = "0x334D8E0", VA = "0x18334E8E0")]
	public bool EKLFHNDDCHK(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x334EA90", Offset = "0x334DA90", VA = "0x18334EA90")]
	public bool OADACMKKJNG(object JGMHCJIBOFB, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x16FAE50", Offset = "0x16F9E50", VA = "0x1816FAE50")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x37718A0", Offset = "0x37708A0", VA = "0x1837718A0")]
	private bool DCDJDNGGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3199830", Offset = "0x3198830", VA = "0x183199830")]
	public HFLGMHECNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class DHEFPCOPCFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Dictionary<object, float> OBBCJBEKBGL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float EGGIIEAFEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7625C0", Offset = "0x7615C0", VA = "0x1807625C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA02B90", Offset = "0xA01B90", VA = "0x180A02B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4C92E30", Offset = "0x4C91E30", VA = "0x184C92E30")]
	public void OKEGCOKGHHP(float MFBIHMKFNKA, object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4C92CA0", Offset = "0x4C91CA0", VA = "0x184C92CA0")]
	public void EKLFHNDDCHK(object JGMHCJIBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4C92D10", Offset = "0x4C91D10", VA = "0x184C92D10")]
	private void MIBOCGECEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4C92EA0", Offset = "0x4C91EA0", VA = "0x184C92EA0")]
	public DHEFPCOPCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public sealed class PNCONINMAHM
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class ACEGLMIDFMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly string EIACMKPPFNI;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		private ACEGLMIDFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5B9040", Offset = "0x5B8040", VA = "0x1805B9040")]
		public ACEGLMIDFMM(string EIACMKPPFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4C91A70", Offset = "0x4C90A70", VA = "0x184C91A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class LOLFKBPFPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public LOLFKBPFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x4C951E0", Offset = "0x4C941E0", VA = "0x184C951E0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly HashSet<object> KBNFMJDHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int IDPKBGIOAHP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool PGBNKFDCFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4C95D60", Offset = "0x4C94D60", VA = "0x184C95D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int GJEPFFENNCK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD70", Offset = "0x5BAD70", VA = "0x1805BBD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4C95C60", Offset = "0x4C94C60", VA = "0x184C95C60")]
	public bool IONNJMGFDPB(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x4C95CE0", Offset = "0x4C94CE0", VA = "0x184C95CE0")]
	public bool JPAMCOIJOBL(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4C95C00", Offset = "0x4C94C00", VA = "0x184C95C00")]
	public bool CDHEDEIGJMA(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x4C95D70", Offset = "0x4C94D70", VA = "0x184C95D70")]
	public void OILPLPNCDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4C95DD0", Offset = "0x4C94DD0", VA = "0x184C95DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x4C95F40", Offset = "0x4C94F40", VA = "0x184C95F40")]
	public PNCONINMAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class HHDMCKJAKFM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct BBJDKKMJMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float PNBNHPKCNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T CIFMBHMEFPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<object, BBJDKKMJMDO> OBBCJBEKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T BCLJIOEEKCG;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public virtual T EMDECIAJHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xB8FF70", Offset = "0xB8EF70", VA = "0x180B8FF70", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xB8F6F0", Offset = "0xB8E6F0", VA = "0x180B8F6F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public object GNBJHJKMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6768A0", Offset = "0x6758A0", VA = "0x1806768A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x561BD0", Offset = "0x560BD0", VA = "0x180561BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool IKOBEMDIJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3351BE0", Offset = "0x3350BE0", VA = "0x183351BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3351D00", Offset = "0x3350D00", VA = "0x183351D00")]
	public bool OKEGCOKGHHP(T MFBIHMKFNKA, object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3351900", Offset = "0x3350900", VA = "0x183351900")]
	public bool EKLFHNDDCHK(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x16FAE50", Offset = "0x16F9E50", VA = "0x1816FAE50")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3351B00", Offset = "0x3350B00", VA = "0x183351B00")]
	public bool OADACMKKJNG(object JGMHCJIBOFB, out T MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3351520", Offset = "0x3350520", VA = "0x183351520")]
	private bool DCDJDNGGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x33521F0", Offset = "0x33511F0", VA = "0x1833521F0")]
	public HHDMCKJAKFM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4C94BF0", Offset = "0x4C93BF0", VA = "0x184C94BF0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4C94CF0", Offset = "0x4C93CF0", VA = "0x184C94CF0")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
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
