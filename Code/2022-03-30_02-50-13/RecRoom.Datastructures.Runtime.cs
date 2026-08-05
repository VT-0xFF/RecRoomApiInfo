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
public class DJFBMPDLOIC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60C540", Offset = "0x60AB40", VA = "0x18060C540")]
	public DJFBMPDLOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5980", Offset = "0x4AA3F80", VA = "0x184AA5980")]
	public byte[] BMDDIELHMJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void KCOJONKFPHK(IncrementalHash NMILPJPINAK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9E40B0", Offset = "0x9E26B0", VA = "0x1809E40B0")]
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
	[BOIIKJJBINN]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[BOIIKJJBINN]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8EC0", Offset = "0x4AA74C0", VA = "0x184AA8EC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8E80", Offset = "0x4AA7480", VA = "0x184AA8E80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8F00", Offset = "0x4AA7500", VA = "0x184AA8F00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9110", Offset = "0x4AA7710", VA = "0x184AA9110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9080", Offset = "0x4AA7680", VA = "0x184AA9080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAD6080", Offset = "0xAD4680", VA = "0x180AD6080")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB05F90", Offset = "0xB04590", VA = "0x180B05F90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8E40", Offset = "0x4AA7440", VA = "0x184AA8E40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8FF0", Offset = "0x4AA75F0", VA = "0x184AA8FF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8870", Offset = "0x4AA6E70", VA = "0x184AA8870")]
	public void CopyBounds(SavedExtents OKCILNENDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8DB0", Offset = "0x4AA73B0", VA = "0x184AA8DB0")]
	public void SetLocalSpaceBounds(Bounds BCBKMMJALGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70EF60", Offset = "0x70D560", VA = "0x18070EF60")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8DA0", Offset = "0x4AA73A0", VA = "0x184AA8DA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8960", Offset = "0x4AA6F60", VA = "0x184AA8960")]
	private void GJPANCHIPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8B70", Offset = "0x4AA7170", VA = "0x184AA8B70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4AA82B0", Offset = "0x4AA68B0", VA = "0x184AA82B0")]
	public static void CalculateLocalBoundsFor(GameObject NEBFDMDBLJL, out Bounds BCBKMMJALGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AA88A0", Offset = "0x4AA6EA0", VA = "0x184AA88A0")]
	private static void DLECLLCFPCH(Bounds KFLJJIMMFKG, Color DMCLBDHLPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8DD0", Offset = "0x4AA73D0", VA = "0x184AA8DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x520EE0", Offset = "0x51F4E0", VA = "0x180520EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5204A0", Offset = "0x51EAA0", VA = "0x1805204A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "4")]
	public virtual void FKPFMCIMFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
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
	[DJFBMPDLOIC]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB820", Offset = "0x3CD9E20", VA = "0x183CDB820", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB360", Offset = "0x3CD9960", VA = "0x183CDB360", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3CDBE20", Offset = "0x3CDA420", VA = "0x183CDBE20")]
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
	private sealed class OKFKFHCLGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public OKFKFHCLGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3115B80", Offset = "0x3114180", VA = "0x183115B80")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[DJFBMPDLOIC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3106CC0", Offset = "0x31052C0", VA = "0x183106CC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3106CF0", Offset = "0x31052F0", VA = "0x183106CF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3106C10", Offset = "0x3105210", VA = "0x183106C10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey DHLOMKIAOHC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3106C40", Offset = "0x3105240", VA = "0x183106C40", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3106B10", Offset = "0x3105110", VA = "0x183106B10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3106370", Offset = "0x3104970", VA = "0x183106370", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3105CE0", Offset = "0x31042E0", VA = "0x183105CE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3105850", Offset = "0x3103E50", VA = "0x183105850", Slot = "14")]
	protected virtual string COBCACMHLPK(TKeyVal ACPIEBCMLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26AABC0", Offset = "0x26A91C0", VA = "0x1826AABC0", Slot = "4")]
	public bool ContainsKey(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3106A00", Offset = "0x3105000", VA = "0x183106A00", Slot = "5")]
	public bool TryGetValue(TKey DHLOMKIAOHC, out TVal BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x31058E0", Offset = "0x3103EE0", VA = "0x1831058E0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31058E0", Offset = "0x3103EE0", VA = "0x1831058E0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3106A30", Offset = "0x3105030", VA = "0x183106A30")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MDAENFMKNIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AKEJCIDMLOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public AKEJCIDMLOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x34F2E20", Offset = "0x34F1420", VA = "0x1834F2E20")]
		internal bool <GetSamples>b__0(global::GCDFBPJEDJL<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float APHKNDNIIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float HHIBMMBNJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::GCDFBPJEDJL<float, T>> IKFLIIDILDJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OFBEFJNPGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x34FA6C0", Offset = "0x34F8CC0", VA = "0x1834FA6C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34FB170", Offset = "0x34F9770", VA = "0x1834FB170")]
	public MDAENFMKNIC(float JGEPBDFGIKJ, float DFFBDCDMNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34FB010", Offset = "0x34F9610", VA = "0x1834FB010")]
	public bool OAPPJCOFBJN(float CBLJCBGABHP, T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34FA5E0", Offset = "0x34F8BE0", VA = "0x1834FA5E0")]
	public int BLFIHDFFNIL(float CBLJCBGABHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34FAAB0", Offset = "0x34F90B0", VA = "0x1834FAAB0")]
	public IEnumerable<T> IBAPHHGALIJ(float CBLJCBGABHP, [Optional] float? NCBJOPABDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34FA740", Offset = "0x34F8D40", VA = "0x1834FA740")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34FADF0", Offset = "0x34F93F0", VA = "0x1834FADF0")]
	private void KJOPHOBPKFP(float CBLJCBGABHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KEIKAJEFIEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JMANNEMBGBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T KBCFGEEMGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float CMNHINIFNGN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float OKOIKJAJKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> OMLDDDAKAEN;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int BFDDOEKBELB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private JMANNEMBGBG[] ABEPAFKBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int DCJNAAMHJCO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JMJHJOHFGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB6A140", Offset = "0xB68740", VA = "0x180B6A140")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF033C0", Offset = "0xF019C0", VA = "0x180F033C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1730", Offset = "0x3EEFD30", VA = "0x183EF1730")]
	public KEIKAJEFIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1650", Offset = "0x3EEFC50", VA = "0x183EF1650")]
	public KEIKAJEFIEH(int IFBIFKFKIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0F00", Offset = "0x3EEF500", VA = "0x183EF0F00")]
	public void KNBMMGKPMNM(float CBLJCBGABHP, T BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0870", Offset = "0x3EEEE70", VA = "0x183EF0870")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0150", Offset = "0x3EEE750", VA = "0x183EF0150")]
	public bool GHLHAKNGING(float BFCOJDGIJGG, float MEGPHPIDIFI, out T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1330", Offset = "0x3EEF930", VA = "0x183EF1330")]
	public bool PAHFOPPFEPN(float BFCOJDGIJGG, float MEGPHPIDIFI, out T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0C50", Offset = "0x3EEF250", VA = "0x183EF0C50")]
	public void JGHANHMJMAL(float BFCOJDGIJGG, float MEGPHPIDIFI, List<T> PHLLKFGPDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0120", Offset = "0x3EEE720", VA = "0x183EF0120")]
	private int EAKKLOEGLMF(int AINHDELCCJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF06E0", Offset = "0x3EEECE0", VA = "0x183EF06E0")]
	private void GNDEFFLMNJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKLEJMDFDNP();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HPJBBFOEJCM(T FOJCICNGKHF, T LDAKCJFNHIL, float ODMEGCBGFOI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LNIGINDJIKM(T BABHCNCDDFB, float ODMEGCBGFOI);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FIOLELCNKKG(T FOJCICNGKHF, T LDAKCJFNHIL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T DNDIPICCKBK(T FOJCICNGKHF, T LDAKCJFNHIL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PFBNDAHCLIN : global::KEIKAJEFIEH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7680", Offset = "0x4AA5C80", VA = "0x184AA7680", Slot = "4")]
	protected override Vector3 BKLEJMDFDNP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7810", Offset = "0x4AA5E10", VA = "0x184AA7810", Slot = "5")]
	protected override Vector3 HPJBBFOEJCM(Vector3 FOJCICNGKHF, Vector3 LDAKCJFNHIL, float ODMEGCBGFOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4AA78D0", Offset = "0x4AA5ED0", VA = "0x184AA78D0", Slot = "6")]
	protected override Vector3 LNIGINDJIKM(Vector3 BABHCNCDDFB, float ODMEGCBGFOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7760", Offset = "0x4AA5D60", VA = "0x184AA7760", Slot = "7")]
	protected override Vector3 FIOLELCNKKG(Vector3 FOJCICNGKHF, Vector3 LDAKCJFNHIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4AA76F0", Offset = "0x4AA5CF0", VA = "0x184AA76F0", Slot = "8")]
	protected override Vector3 DNDIPICCKBK(Vector3 FOJCICNGKHF, Vector3 LDAKCJFNHIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7970", Offset = "0x4AA5F70", VA = "0x184AA7970")]
	public PFBNDAHCLIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KGMFOAOBECL : global::KEIKAJEFIEH<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5BD0", Offset = "0x4AA41D0", VA = "0x184AA5BD0")]
	public KGMFOAOBECL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5B60", Offset = "0x4AA4160", VA = "0x184AA5B60")]
	public KGMFOAOBECL(int IFBIFKFKIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xB77FD0", Offset = "0xB765D0", VA = "0x180B77FD0", Slot = "4")]
	protected override float BKLEJMDFDNP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5AE0", Offset = "0x4AA40E0", VA = "0x184AA5AE0", Slot = "5")]
	protected override float HPJBBFOEJCM(float FOJCICNGKHF, float LDAKCJFNHIL, float ODMEGCBGFOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E51CB0", Offset = "0x3E502B0", VA = "0x183E51CB0", Slot = "6")]
	protected override float LNIGINDJIKM(float BABHCNCDDFB, float ODMEGCBGFOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x230E6F0", Offset = "0x230CCF0", VA = "0x18230E6F0", Slot = "7")]
	protected override float FIOLELCNKKG(float FOJCICNGKHF, float LDAKCJFNHIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5AD0", Offset = "0x4AA40D0", VA = "0x184AA5AD0", Slot = "8")]
	protected override float DNDIPICCKBK(float FOJCICNGKHF, float LDAKCJFNHIL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LCEOFJFPING
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1593580", Offset = "0x1591B80", VA = "0x181593580")]
	public static global::NFLFIDMGNIG<T1> DBFOOEAJHCK<T1>(T1 DKJMDDIDILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x19A16C0", Offset = "0x199FCC0", VA = "0x1819A16C0")]
	public static global::GCDFBPJEDJL<T1, T2> DBFOOEAJHCK<T1, T2>(T1 DKJMDDIDILO, T2 BGANCHCMBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x19A1730", Offset = "0x199FD30", VA = "0x1819A1730")]
	public static global::FBBHKPHMJDM<T1, T2, T3> DBFOOEAJHCK<T1, T2, T3>(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x18AFDF0", Offset = "0x18AE3F0", VA = "0x1818AFDF0")]
	public static global::MHEDIGJICEL<T1, T2, T3, T4> DBFOOEAJHCK<T1, T2, T3, T4>(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2519530", Offset = "0x2517B30", VA = "0x182519530")]
	public static global::AKCMJGONNIC<T1, T2, T3, T4, T5> DBFOOEAJHCK<T1, T2, T3, T4, T5>(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2793FC0", Offset = "0x27925C0", VA = "0x182793FC0")]
	public static global::DKCIMDPEMCB<T1, T2, T3, T4, T5, T6> DBFOOEAJHCK<T1, T2, T3, T4, T5, T6>(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH, T6 MOFPKGOIBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2793F00", Offset = "0x2792500", VA = "0x182793F00")]
	public static global::APKIFBGFMHK<T1, T2, T3, T4, T5, T6, T7> DBFOOEAJHCK<T1, T2, T3, T4, T5, T6, T7>(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH, T6 MOFPKGOIBKF, T7 FNNJADBMKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x19A17C0", Offset = "0x199FDC0", VA = "0x1819A17C0")]
	public static global::HCCGMLEKAEO<T1, T2, T3, T4, T5, T6, T7, T8> DBFOOEAJHCK<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH, T6 MOFPKGOIBKF, T7 FNNJADBMKCH, T8 NLNBNHCHMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1503280", Offset = "0x1501880", VA = "0x181503280")]
	[IteratorStateMachine(typeof(NEAEBFCGMLF))]
	public static IEnumerable<global::GCDFBPJEDJL<T1, T2>> EHOFOOAKBBN<T1, T2>(IEnumerable<T1> CPNCDDHAPNF, IEnumerable<T2> KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x15053A0", Offset = "0x15039A0", VA = "0x1815053A0")]
	[IteratorStateMachine(typeof(BAKOPMNABCB))]
	public static IEnumerable<global::FBBHKPHMJDM<T1, T2, T3>> EHOFOOAKBBN<T1, T2, T3>(IEnumerable<T1> CPNCDDHAPNF, IEnumerable<T2> KFLJJIMMFKG, IEnumerable<T3> DMCLBDHLPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2074C20", Offset = "0x2073220", VA = "0x182074C20")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41F5F60", Offset = "0x41F4560", VA = "0x1841F5F60")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF, int KOIFGMMNFGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41F5F70", Offset = "0x41F4570", VA = "0x1841F5F70")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF, int KOIFGMMNFGA, int GLKDJAOEKFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5CD0", Offset = "0x4AA42D0", VA = "0x184AA5CD0")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF, int KOIFGMMNFGA, int GLKDJAOEKFD, int BPNMNEKHONL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5CF0", Offset = "0x4AA42F0", VA = "0x184AA5CF0")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF, int KOIFGMMNFGA, int GLKDJAOEKFD, int BPNMNEKHONL, int DIHEBDGPHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5D10", Offset = "0x4AA4310", VA = "0x184AA5D10")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF, int KOIFGMMNFGA, int GLKDJAOEKFD, int BPNMNEKHONL, int DIHEBDGPHFP, int ONBLFHKNDDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5D40", Offset = "0x4AA4340", VA = "0x184AA5D40")]
	internal static int BJFAGKNOPEO(int NFBENNFJIIM, int HMGBFHBPIPF, int KOIFGMMNFGA, int GLKDJAOEKFD, int BPNMNEKHONL, int DIHEBDGPHFP, int ONBLFHKNDDP, int HFLBCJDFIEM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NFLFIDMGNIG<T1> : IComparable<global::NFLFIDMGNIG<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x212AA00", Offset = "0x2129000", VA = "0x18212AA00")]
	public NFLFIDMGNIG(T1 DKJMDDIDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3143C70", Offset = "0x3142270", VA = "0x183143C70", Slot = "4")]
	public int CompareTo(global::NFLFIDMGNIG<T1> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3143CE0", Offset = "0x31422E0", VA = "0x183143CE0", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700000", VA = "0x180701A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3143D80", Offset = "0x3142380", VA = "0x183143D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GCDFBPJEDJL<T1, T2> : IComparable<global::GCDFBPJEDJL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x358BCC0", Offset = "0x358A2C0", VA = "0x18358BCC0")]
	public GCDFBPJEDJL(T1 DKJMDDIDILO, T2 BGANCHCMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x358A310", Offset = "0x3588910", VA = "0x18358A310", Slot = "4")]
	public int CompareTo(global::GCDFBPJEDJL<T1, T2> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x358A430", Offset = "0x3588A30", VA = "0x18358A430", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x358AEA0", Offset = "0x35894A0", VA = "0x18358AEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x358B540", Offset = "0x3589B40", VA = "0x18358B540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FBBHKPHMJDM<T1, T2, T3> : IComparable<global::FBBHKPHMJDM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 KKJHGANLPFA;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3108650", Offset = "0x3106C50", VA = "0x183108650")]
	public FBBHKPHMJDM(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3107F70", Offset = "0x3106570", VA = "0x183107F70", Slot = "4")]
	public int CompareTo(global::FBBHKPHMJDM<T1, T2, T3> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3108160", Offset = "0x3106760", VA = "0x183108160", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3108360", Offset = "0x3106960", VA = "0x183108360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x31083D0", Offset = "0x31069D0", VA = "0x1831083D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MHEDIGJICEL<T1, T2, T3, T4> : IComparable<global::MHEDIGJICEL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 KKJHGANLPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 OCBDBOMMCCB;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3512800", Offset = "0x3510E00", VA = "0x183512800")]
	public MHEDIGJICEL(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x35123D0", Offset = "0x35109D0", VA = "0x1835123D0", Slot = "4")]
	public int CompareTo(global::MHEDIGJICEL<T1, T2, T3, T4> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3512510", Offset = "0x3510B10", VA = "0x183512510", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3512630", Offset = "0x3510C30", VA = "0x183512630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x35126F0", Offset = "0x3510CF0", VA = "0x1835126F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AKCMJGONNIC<T1, T2, T3, T4, T5> : IComparable<global::AKCMJGONNIC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 KKJHGANLPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 OCBDBOMMCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 LKGBDGGOGCK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1A56320", Offset = "0x1A54920", VA = "0x181A56320")]
	public AKCMJGONNIC(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1A55E30", Offset = "0x1A54430", VA = "0x181A55E30", Slot = "4")]
	public int CompareTo(global::AKCMJGONNIC<T1, T2, T3, T4, T5> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1A55FB0", Offset = "0x1A545B0", VA = "0x181A55FB0", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1A560F0", Offset = "0x1A546F0", VA = "0x181A560F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1A561F0", Offset = "0x1A547F0", VA = "0x181A561F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DKCIMDPEMCB<T1, T2, T3, T4, T5, T6> : IComparable<global::DKCIMDPEMCB<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 KKJHGANLPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 OCBDBOMMCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 LKGBDGGOGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 AOCCHAHBJEL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CD20", Offset = "0x2C6B320", VA = "0x182C6CD20")]
	public DKCIMDPEMCB(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH, T6 MOFPKGOIBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C780", Offset = "0x2C6AD80", VA = "0x182C6C780", Slot = "4")]
	public int CompareTo(global::DKCIMDPEMCB<T1, T2, T3, T4, T5, T6> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C940", Offset = "0x2C6AF40", VA = "0x182C6C940", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CAB0", Offset = "0x2C6B0B0", VA = "0x182C6CAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CBD0", Offset = "0x2C6B1D0", VA = "0x182C6CBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class APKIFBGFMHK<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::APKIFBGFMHK<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 KKJHGANLPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 OCBDBOMMCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 LKGBDGGOGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 AOCCHAHBJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 KNJLLNGNOPN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE930", Offset = "0x2DDCF30", VA = "0x182DDE930")]
	public APKIFBGFMHK(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH, T6 MOFPKGOIBKF, T7 FNNJADBMKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE2D0", Offset = "0x2DDC8D0", VA = "0x182DDE2D0", Slot = "4")]
	public int CompareTo(global::APKIFBGFMHK<T1, T2, T3, T4, T5, T6, T7> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE4D0", Offset = "0x2DDCAD0", VA = "0x182DDE4D0", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE670", Offset = "0x2DDCC70", VA = "0x182DDE670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE7C0", Offset = "0x2DDCDC0", VA = "0x182DDE7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HCCGMLEKAEO<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::HCCGMLEKAEO<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 DGAJOPBJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 AGJPFNEILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 KKJHGANLPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 OCBDBOMMCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 LKGBDGGOGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 AOCCHAHBJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 KNJLLNGNOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 NJBLBFCPPHO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3289920", Offset = "0x3287F20", VA = "0x183289920")]
	public HCCGMLEKAEO(T1 DKJMDDIDILO, T2 BGANCHCMBNG, T3 GCHHPONELNO, T4 MGEDMCPPHFD, T5 FKHDHCBCNHH, T6 MOFPKGOIBKF, T7 FNNJADBMKCH, T8 NLNBNHCHMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3289210", Offset = "0x3287810", VA = "0x183289210", Slot = "4")]
	public int CompareTo(global::HCCGMLEKAEO<T1, T2, T3, T4, T5, T6, T7, T8> OKCILNENDLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3289460", Offset = "0x3287A60", VA = "0x183289460", Slot = "0")]
	public override bool Equals(object OKCILNENDLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3289620", Offset = "0x3287C20", VA = "0x183289620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3289790", Offset = "0x3287D90", VA = "0x183289790", Slot = "3")]
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
	public T KBCFGEEMGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E0570", Offset = "0x5DEB70", VA = "0x1805E0570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MCLNIJDAHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xB05F80", Offset = "0xB04580", VA = "0x180B05F80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x38530A0", Offset = "0x38516A0", VA = "0x1838530A0")]
	public T KKNBACPENMD(float ODMEGCBGFOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3853400", Offset = "0x3851A00", VA = "0x183853400")]
	public T KNCFAOKBFLN(float ODMEGCBGFOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HPJBBFOEJCM(T FOJCICNGKHF, T LDAKCJFNHIL, float ODMEGCBGFOI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4AA55F0", Offset = "0x4AA3BF0", VA = "0x184AA55F0", Slot = "4")]
	protected override float HPJBBFOEJCM(float FOJCICNGKHF, float LDAKCJFNHIL, float ODMEGCBGFOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5670", Offset = "0x4AA3C70", VA = "0x184AA5670")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA070", Offset = "0x4AA8670", VA = "0x184AAA070", Slot = "4")]
	protected override Vector3 HPJBBFOEJCM(Vector3 FOJCICNGKHF, Vector3 LDAKCJFNHIL, float ODMEGCBGFOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA130", Offset = "0x4AA8730", VA = "0x184AAA130")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4AA3E40", Offset = "0x4AA2440", VA = "0x184AA3E40", Slot = "4")]
	protected override Color HPJBBFOEJCM(Color FOJCICNGKHF, Color LDAKCJFNHIL, float ODMEGCBGFOI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4AA3E90", Offset = "0x4AA2490", VA = "0x184AA3E90")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class JAIPBFAENDE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] OHFGIGCFMPC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x557080", Offset = "0x555680", VA = "0x180557080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA740", Offset = "0x5F8D40", VA = "0x1805FA740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x46BCBD0", Offset = "0x46BB1D0", VA = "0x1846BCBD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46BCD90", Offset = "0x46BB390", VA = "0x1846BCD90")]
	public static global::JAIPBFAENDE<T> AOJMLHILCJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46BD320", Offset = "0x46BB920", VA = "0x1846BD320")]
	public static global::JAIPBFAENDE<T> FAMKCJJMBPC(int FMHNJGMGKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46BDD00", Offset = "0x46BC300", VA = "0x1846BDD00")]
	private JAIPBFAENDE(T[] LKKJPBMAIDF, int FMHNJGMGKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46BCEC0", Offset = "0x46BB4C0", VA = "0x1846BCEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x46BD6E0", Offset = "0x46BBCE0", VA = "0x1846BD6E0")]
	public void KNBMMGKPMNM(in T BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x46BD460", Offset = "0x46BBA60", VA = "0x1846BD460")]
	public void HFGIMBGAAGI(int ACNPMFDBMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x46BDB00", Offset = "0x46BC100", VA = "0x1846BDB00")]
	public void OKJFIGBMPNL(in T BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x46BCF30", Offset = "0x46BB530", VA = "0x1846BCF30")]
	public void EAGPOECKMAF(int IFBIFKFKIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x46BCC10", Offset = "0x46BB210", VA = "0x1846BCC10")]
	private void AGNAPJCFENG(int FMHNJGMGKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GEBOBNNBDKG
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x199DAB0", Offset = "0x199C0B0", VA = "0x18199DAB0")]
	public static global::JAIPBFAENDE<T> AOJMLHILCJB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x12D01F0", Offset = "0x12CE7F0", VA = "0x1812D01F0")]
	public static global::JAIPBFAENDE<T> FAMKCJJMBPC<T>(int FMHNJGMGKLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class ELNBKPKJHGO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> JKPGMIGAFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> NKJPMOOIMAO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BF30", Offset = "0x1A3A530", VA = "0x181A3BF30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool OAJJKPLPMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x520EC0", Offset = "0x51F4C0", VA = "0x180520EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> MHAPOGPMABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x26A94F0", Offset = "0x26A7AF0", VA = "0x1826A94F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> IABOJEDPBID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x26A9520", Offset = "0x26A7B20", VA = "0x1826A9520", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x26A94C0", Offset = "0x26A7AC0", VA = "0x1826A94C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x26A9550", Offset = "0x26A7B50", VA = "0x1826A9550", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x26A8710", Offset = "0x26A6D10", VA = "0x1826A8710")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x26A8FF0", Offset = "0x26A75F0", VA = "0x1826A8FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x26A8BE0", Offset = "0x26A71E0", VA = "0x1826A8BE0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26A9360", Offset = "0x26A7960", VA = "0x1826A9360", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x26A87A0", Offset = "0x26A6DA0", VA = "0x1826A87A0", Slot = "9")]
	public void Add(TKey DHLOMKIAOHC, TVal BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x26A8770", Offset = "0x26A6D70", VA = "0x1826A8770", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EJBKKMFFHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26A8C40", Offset = "0x26A7240", VA = "0x1826A8C40", Slot = "8")]
	public bool ContainsKey(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x26A8CA0", Offset = "0x26A72A0", VA = "0x1826A8CA0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x26A92B0", Offset = "0x26A78B0", VA = "0x1826A92B0", Slot = "10")]
	public bool Remove(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x26A92B0", Offset = "0x26A78B0", VA = "0x1826A92B0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26A93B0", Offset = "0x26A79B0", VA = "0x1826A93B0", Slot = "11")]
	public bool TryGetValue(TKey DHLOMKIAOHC, out TVal BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x26A8E10", Offset = "0x26A7410", VA = "0x1826A8E10", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x26A8CD0", Offset = "0x26A72D0", VA = "0x1826A8CD0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ABEPAFKBCKK, int NLJPHOEJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x26A8F30", Offset = "0x26A7530", VA = "0x1826A8F30")]
	public void KNBMMGKPMNM(TVal BOLPPEKOGED, TKey DHLOMKIAOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26A8F70", Offset = "0x26A7570", VA = "0x1826A8F70")]
	public void KNBMMGKPMNM(KeyValuePair<TVal, TKey> EJBKKMFFHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26A9140", Offset = "0x26A7740", VA = "0x1826A9140")]
	public bool NGLKCAMFCPE(TVal DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x26A8D60", Offset = "0x26A7360", VA = "0x1826A8D60")]
	public bool DEEPBBKBDCI(KeyValuePair<TVal, TKey> EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x269F440", Offset = "0x269DA40", VA = "0x18269F440")]
	public bool OKJFIGBMPNL(TVal DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x269F440", Offset = "0x269DA40", VA = "0x18269F440")]
	public bool OKJFIGBMPNL(KeyValuePair<TVal, TKey> EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x26A8E90", Offset = "0x26A7490", VA = "0x1826A8E90")]
	public bool JFOHOCKIKHA(TVal DHLOMKIAOHC, out TKey BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x26A8B60", Offset = "0x26A7160", VA = "0x1826A8B60")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CJHIMGJOGCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26A9030", Offset = "0x26A7630", VA = "0x1826A9030")]
	private void MCOBMFOMCOK(TKey DHLOMKIAOHC, TVal BOLPPEKOGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26A9200", Offset = "0x26A7800", VA = "0x1826A9200")]
	private void OIOOIMIDCLJ(TKey DHLOMKIAOHC, TVal BOLPPEKOGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26A87D0", Offset = "0x26A6DD0", VA = "0x1826A87D0")]
	private bool BBLFBHAHPAD(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x26A8890", Offset = "0x26A6E90", VA = "0x1826A8890")]
	private bool BBLFBHAHPAD(TVal BOLPPEKOGED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x26A93E0", Offset = "0x26A79E0", VA = "0x1826A93E0")]
	public ELNBKPKJHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class HKNKIENGFDO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::HKNKIENGFDO<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xB6A140", Offset = "0xB68740", VA = "0x180B6A140", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x29AE290", Offset = "0x29AC890", VA = "0x1829AE290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29AE540", Offset = "0x29ACB40", VA = "0x1829AE540")]
		public Enumerator(global::HKNKIENGFDO<T> PHLLKFGPDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x29ADD70", Offset = "0x29AC370", VA = "0x1829ADD70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x29ADF90", Offset = "0x29AC590", VA = "0x1829ADF90", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x29AD840", Offset = "0x29ABE40", VA = "0x1829AD840")]
		private void GEPAIMAGHDM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] NDLDJJFEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int AMGFIMAOBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int NEEOBGHMNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int FIOPGIELFCB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x29BAC00", Offset = "0x29B9200", VA = "0x1829BAC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x29BA270", Offset = "0x29B8870", VA = "0x1829BA270")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x29BB030", Offset = "0x29B9630", VA = "0x1829BB030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29BC2F0", Offset = "0x29BA8F0", VA = "0x1829BC2F0")]
	public HKNKIENGFDO(int FMHNJGMGKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x29BADB0", Offset = "0x29B93B0", VA = "0x1829BADB0")]
	public void KNBMMGKPMNM(T ODMEGCBGFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29BB4E0", Offset = "0x29B9AE0", VA = "0x1829BB4E0")]
	public void MCMEOPKLHFO(IEnumerable<T> KLBHKFLAAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x29BABE0", Offset = "0x29B91E0", VA = "0x1829BABE0")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29BA5E0", Offset = "0x29B8BE0", VA = "0x1829BA5E0")]
	public void BFABLPNIMIN(int IJIIKIBCCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x29BA3F0", Offset = "0x29B89F0", VA = "0x1829BA3F0")]
	public void AGJOEFDBOLH(int IJIIKIBCCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29BAA90", Offset = "0x29B9090", VA = "0x1829BAA90")]
	public void DAIFLKHDFFF(T[] ABEPAFKBCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x29BA480", Offset = "0x29B8A80", VA = "0x1829BA480")]
	public Enumerator AICDEAFDBPL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x29BC100", Offset = "0x29BA700", VA = "0x1829BC100", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x29BC100", Offset = "0x29BA700", VA = "0x1829BC100", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x29BB300", Offset = "0x29B9900", VA = "0x1829BB300")]
	private int MAPPPMKBKMK(int ACNPMFDBMJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x29BA670", Offset = "0x29B8C70", VA = "0x1829BA670")]
	private int DAEPLDMIOEI(int ACNPMFDBMJN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class PPIKHMJCMDM
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HKJGGPOMEJI(object[] GKCBCPKIAEB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	protected PPIKHMJCMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class EILLKPJBHPJ<T> : PPIKHMJCMDM
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	protected struct GDCGMHAJPHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum KKCBMMJEECE
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KKCBMMJEECE IPLFCJCEGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T JLOPFCBGFOB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int CPLHHNPHCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly bool BKGMELJGEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly bool APEKEBGBPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected List<T> BFFFFIDLFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<GDCGMHAJPHN> LDBJBBBIDLI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool NONBMDFFEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x26A6B40", Offset = "0x26A5140", VA = "0x1826A6B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x26A6CE0", Offset = "0x26A52E0", VA = "0x1826A6CE0")]
	protected EILLKPJBHPJ(bool APEKEBGBPHM, bool BKGMELJGEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x26A6560", Offset = "0x26A4B60", VA = "0x1826A6560")]
	protected bool ACGNDAAKGIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x26A6600", Offset = "0x26A4C00", VA = "0x1826A6600")]
	protected void EPHJAEMMMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x26A6810", Offset = "0x26A4E10", VA = "0x1826A6810")]
	protected void HPNIGOHIAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x27F98C0", Offset = "0x27F7EC0", VA = "0x1827F98C0")]
	private static void OAHBFCKJFIK<U>(ref List<U> FNOAABPNLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26A69C0", Offset = "0x26A4FC0", VA = "0x1826A69C0", Slot = "5")]
	public void KNBMMGKPMNM(T JLOPFCBGFOB, bool CIELBHNIDPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x26A6B80", Offset = "0x26A5180", VA = "0x1826A6B80", Slot = "6")]
	public void OKJFIGBMPNL(T JLOPFCBGFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x26A66E0", Offset = "0x26A4CE0", VA = "0x1826A66E0")]
	public void HPEBFGMNFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ANOBPLNFHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class OIHPFCMDIMH : global::EILLKPJBHPJ<Action>, ANOBPLNFHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4AA74A0", Offset = "0x4AA5AA0", VA = "0x184AA74A0")]
	public OIHPFCMDIMH(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4AA72E0", Offset = "0x4AA58E0", VA = "0x184AA72E0")]
	public void MEKJKDFJECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7200", Offset = "0x4AA5800", VA = "0x184AA7200", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4AA71A0", Offset = "0x4AA57A0", VA = "0x184AA71A0")]
	public static OIHPFCMDIMH AMDCKHCDALM(OIHPFCMDIMH GKCAMEGHHEK, Action JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7280", Offset = "0x4AA5880", VA = "0x184AA7280")]
	public static OIHPFCMDIMH LJKNCFLPNDJ(OIHPFCMDIMH GKCAMEGHHEK, Action JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JLHDMCEFIDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action<T> JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action<T> JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class INCACPDBFMG<T> : global::EILLKPJBHPJ<Action<T>>, global::JLHDMCEFIDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1E8B0F0", Offset = "0x1E896F0", VA = "0x181E8B0F0")]
	public INCACPDBFMG(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x272C470", Offset = "0x272AA70", VA = "0x18272C470")]
	public void MEKJKDFJECC(T ODMEGCBGFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2727980", Offset = "0x2725F80", VA = "0x182727980", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2727140", Offset = "0x2725740", VA = "0x182727140")]
	public static global::INCACPDBFMG<T> AMDCKHCDALM(global::INCACPDBFMG<T> GKCAMEGHHEK, Action<T> JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2729030", Offset = "0x2727630", VA = "0x182729030")]
	public static global::INCACPDBFMG<T> LJKNCFLPNDJ(global::INCACPDBFMG<T> GKCAMEGHHEK, Action<T> JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KFKNKBFGMKL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action<T, U> JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action<T, U> JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BMIHAABCPBG<T, U> : global::EILLKPJBHPJ<Action<T, U>>, global::KFKNKBFGMKL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1E8B0F0", Offset = "0x1E896F0", VA = "0x181E8B0F0")]
	public BMIHAABCPBG(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1E88810", Offset = "0x1E86E10", VA = "0x181E88810")]
	public void MEKJKDFJECC(T ODMEGCBGFOI, U OGHGBFAIJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1E87200", Offset = "0x1E85800", VA = "0x181E87200", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1E84F00", Offset = "0x1E83500", VA = "0x181E84F00")]
	public static global::BMIHAABCPBG<T, U> AMDCKHCDALM(global::BMIHAABCPBG<T, U> GKCAMEGHHEK, Action<T, U> JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E87700", Offset = "0x1E85D00", VA = "0x181E87700")]
	public static global::BMIHAABCPBG<T, U> LJKNCFLPNDJ(global::BMIHAABCPBG<T, U> GKCAMEGHHEK, Action<T, U> JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MLHPHHAJEDH<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action<T, U, V> JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action<T, U, V> JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class AODFDFOCPFK<T, U, V> : global::EILLKPJBHPJ<Action<T, U, V>>, global::MLHPHHAJEDH<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1E8B0F0", Offset = "0x1E896F0", VA = "0x181E8B0F0")]
	public AODFDFOCPFK(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB850", Offset = "0x2DD9E50", VA = "0x182DDB850")]
	public void MEKJKDFJECC(T ODMEGCBGFOI, U OGHGBFAIJIO, V OABGMDOBCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB550", Offset = "0x2DD9B50", VA = "0x182DDB550", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDA070", Offset = "0x2DD8670", VA = "0x182DDA070")]
	public static global::AODFDFOCPFK<T, U, V> AMDCKHCDALM(global::AODFDFOCPFK<T, U, V> GKCAMEGHHEK, Action<T, U, V> JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB7B0", Offset = "0x2DD9DB0", VA = "0x182DDB7B0")]
	public static global::AODFDFOCPFK<T, U, V> LJKNCFLPNDJ(global::AODFDFOCPFK<T, U, V> GKCAMEGHHEK, Action<T, U, V> JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EHOOBJJHKAB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action<T, U, V, W> JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action<T, U, V, W> JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PABEMGKJJBF<T, U, V, W> : global::EILLKPJBHPJ<Action<T, U, V, W>>, global::EHOOBJJHKAB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1E8B0F0", Offset = "0x1E896F0", VA = "0x181E8B0F0")]
	public PABEMGKJJBF(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2F243D0", Offset = "0x2F229D0", VA = "0x182F243D0")]
	public void MEKJKDFJECC(T ODMEGCBGFOI, U OGHGBFAIJIO, V OABGMDOBCBD, W KFADHCBNGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F223C0", Offset = "0x2F209C0", VA = "0x182F223C0", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F21E40", Offset = "0x2F20440", VA = "0x182F21E40")]
	public static global::PABEMGKJJBF<T, U, V, W> AMDCKHCDALM(global::PABEMGKJJBF<T, U, V, W> GKCAMEGHHEK, Action<T, U, V, W> JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2F23550", Offset = "0x2F21B50", VA = "0x182F23550")]
	public static global::PABEMGKJJBF<T, U, V, W> LJKNCFLPNDJ(global::PABEMGKJJBF<T, U, V, W> GKCAMEGHHEK, Action<T, U, V, W> JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JIFPAHODNPG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action<T, U, V, W, X> JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action<T, U, V, W, X> JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EFLDNEDGGKE<T, U, V, W, X> : global::EILLKPJBHPJ<Action<T, U, V, W, X>>, global::JIFPAHODNPG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1E8B0F0", Offset = "0x1E896F0", VA = "0x181E8B0F0")]
	public EFLDNEDGGKE(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26A2750", Offset = "0x26A0D50", VA = "0x1826A2750")]
	public void MEKJKDFJECC(T ODMEGCBGFOI, U OGHGBFAIJIO, V OABGMDOBCBD, W KFADHCBNGMB, X GHGHAFCMINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x26A20D0", Offset = "0x26A06D0", VA = "0x1826A20D0", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x26A1A20", Offset = "0x26A0020", VA = "0x1826A1A20")]
	public static global::EFLDNEDGGKE<T, U, V, W, X> AMDCKHCDALM(global::EFLDNEDGGKE<T, U, V, W, X> GKCAMEGHHEK, Action<T, U, V, W, X> JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x26A23A0", Offset = "0x26A09A0", VA = "0x1826A23A0")]
	public static global::EFLDNEDGGKE<T, U, V, W, X> LJKNCFLPNDJ(global::EFLDNEDGGKE<T, U, V, W, X> GKCAMEGHHEK, Action<T, U, V, W, X> JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MFCHMPFBNND<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNBMMGKPMNM(Action<T, U, V, W, X, Y> JLOPFCBGFOB, bool CIELBHNIDPF = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKJFIGBMPNL(Action<T, U, V, W, X, Y> JLOPFCBGFOB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class NNDIBDCKHMB<T, U, V, W, X, Y> : global::EILLKPJBHPJ<Action<T, U, V, W, X, Y>>, global::MFCHMPFBNND<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1E8B0F0", Offset = "0x1E896F0", VA = "0x181E8B0F0")]
	public NNDIBDCKHMB(bool APEKEBGBPHM = false, bool BKGMELJGEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x314A470", Offset = "0x3148A70", VA = "0x18314A470")]
	public void MEKJKDFJECC(T ODMEGCBGFOI, U OGHGBFAIJIO, V OABGMDOBCBD, W KFADHCBNGMB, X GHGHAFCMINB, Y PAFNDAGPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3149A50", Offset = "0x3148050", VA = "0x183149A50", Slot = "4")]
	public override void HKJGGPOMEJI(object[] GKCBCPKIAEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x31499B0", Offset = "0x3147FB0", VA = "0x1831499B0")]
	public static global::NNDIBDCKHMB<T, U, V, W, X, Y> AMDCKHCDALM(global::NNDIBDCKHMB<T, U, V, W, X, Y> GKCAMEGHHEK, Action<T, U, V, W, X, Y> JLOPFCBGFOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x314A110", Offset = "0x3148710", VA = "0x18314A110")]
	public static global::NNDIBDCKHMB<T, U, V, W, X, Y> LJKNCFLPNDJ(global::NNDIBDCKHMB<T, U, V, W, X, Y> GKCAMEGHHEK, Action<T, U, V, W, X, Y> JLOPFCBGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class IIFKGBMCNKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct OOBHICOFKBJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly global::IIFKGBMCNKO<T> IMNMMFHPPHA;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T KBCFGEEMGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x3B89A10", Offset = "0x3B88010", VA = "0x183B89A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3B899E0", Offset = "0x3B87FE0", VA = "0x183B899E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9240", Offset = "0x5E7840", VA = "0x1805E9240")]
		public OOBHICOFKBJ(global::IIFKGBMCNKO<T> IMNMMFHPPHA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FDEIPPLGBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<OOBHICOFKBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::IIFKGBMCNKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3B70C70", Offset = "0x3B6F270", VA = "0x183B70C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3B71010", Offset = "0x3B6F610", VA = "0x183B71010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JFFNAOIAKIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<OOBHICOFKBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::IIFKGBMCNKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3B89810", Offset = "0x3B87E10", VA = "0x183B89810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3B71010", Offset = "0x3B6F610", VA = "0x183B71010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly SemaphoreSlim GDBOECPIAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T HHFEGEIMKPE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int MLFNPKJPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3B893A0", Offset = "0x3B879A0", VA = "0x183B893A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3B893C0", Offset = "0x3B879C0", VA = "0x183B893C0")]
	public IIFKGBMCNKO(in T HHFEGEIMKPE, int FGKOCIGIKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x38D6860", Offset = "0x38D4E60", VA = "0x1838D6860")]
	public IIFKGBMCNKO(in T HHFEGEIMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3B89360", Offset = "0x3B87960", VA = "0x183B89360")]
	public OOBHICOFKBJ MLBMNBGAMOD()
	{
		return default(OOBHICOFKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3B89320", Offset = "0x3B87920", VA = "0x183B89320")]
	public OOBHICOFKBJ MLBMNBGAMOD(CancellationToken NJLCMLGACFJ)
	{
		return default(OOBHICOFKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3B88EC0", Offset = "0x3B874C0", VA = "0x183B88EC0")]
	[AsyncStateMachine(typeof(global::IIFKGBMCNKO<>.FDEIPPLGBAH))]
	public Task<OOBHICOFKBJ> EPEGMAFJLDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3B891A0", Offset = "0x3B877A0", VA = "0x183B891A0")]
	[AsyncStateMachine(typeof(global::IIFKGBMCNKO<>.JFFNAOIAKIB))]
	public Task<OOBHICOFKBJ> EPEGMAFJLDG(CancellationToken NJLCMLGACFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LFODCBKBGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4AA61E0", Offset = "0x4AA47E0", VA = "0x184AA61E0")]
	public static global::IIFKGBMCNKO<LBACFCGDNJA> AOJMLHILCJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6170", Offset = "0x4AA4770", VA = "0x184AA6170")]
	public static global::IIFKGBMCNKO<LBACFCGDNJA> AOJMLHILCJB(int FGKOCIGIKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1593580", Offset = "0x1591B80", VA = "0x181593580")]
	public static global::IIFKGBMCNKO<T> AOJMLHILCJB<T>(in T HHFEGEIMKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x199FB80", Offset = "0x199E180", VA = "0x18199FB80")]
	public static global::IIFKGBMCNKO<T> AOJMLHILCJB<T>(in T HHFEGEIMKPE, int FGKOCIGIKGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HLGOBGEGLGJ<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate bool GODCLHELAIM(global::HLGOBGEGLGJ<T> LEBKLFJFIIP);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BEEBPGGHDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::HLGOBGEGLGJ<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public BEEBPGGHDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x29A8120", Offset = "0x29A6720", VA = "0x1829A8120")]
		internal bool <FindNode>b__0(global::HLGOBGEGLGJ<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public T OHKKJPCGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LinkedList<global::HLGOBGEGLGJ<T>> HIJLHDAKELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public global::HLGOBGEGLGJ<T> IIGHBMDDANH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public global::HLGOBGEGLGJ<T> DGJIJHEFHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5582F0", Offset = "0x5568F0", VA = "0x1805582F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x38CC0E0", Offset = "0x38CA6E0", VA = "0x1838CC0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OPGNFIHBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x38CB1F0", Offset = "0x38C97F0", VA = "0x1838CB1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OJLALFJHCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x38CA690", Offset = "0x38C8C90", VA = "0x1838CA690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public global::HLGOBGEGLGJ<T> JLJGCJNJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x38CA710", Offset = "0x38C8D10", VA = "0x1838CA710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x38CCC40", Offset = "0x38CB240", VA = "0x1838CCC40")]
	public HLGOBGEGLGJ(T COBBJMOCKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x38CA790", Offset = "0x38C8D90", VA = "0x1838CA790")]
	public global::HLGOBGEGLGJ<T> DNDFJMJBMMA(T PLFDAMFFAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x38CAB60", Offset = "0x38C9160", VA = "0x1838CAB60")]
	public global::HLGOBGEGLGJ<T> EOPAJNLKPCF(T OLPHFOKILIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x38CC2A0", Offset = "0x38CA8A0", VA = "0x1838CC2A0")]
	public global::HLGOBGEGLGJ<T> OKJFIGBMPNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x38CAF90", Offset = "0x38C9590", VA = "0x1838CAF90")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x38CCB30", Offset = "0x38CB130", VA = "0x1838CCB30")]
	public global::HLGOBGEGLGJ<T> PMIPGKOOPGG(T KEOGPNLMCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x38CC3E0", Offset = "0x38CA9E0", VA = "0x1838CC3E0")]
	public static void PBPNNGABOLF(global::HLGOBGEGLGJ<T> MFKKLFEGCGA, GODCLHELAIM CMIBOOIMMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x35A4410", Offset = "0x35A2A10", VA = "0x1835A4410")]
	public static void PBPNNGABOLF<A>(global::HLGOBGEGLGJ<T> MFKKLFEGCGA, Func<global::HLGOBGEGLGJ<T>, A, bool> CMIBOOIMMFO, A AKMPCMIGNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x38CB770", Offset = "0x38C9D70", VA = "0x1838CB770")]
	public static string JDGEEAFDBLD(global::HLGOBGEGLGJ<T> MFKKLFEGCGA, int JHMMBJIDMDE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x38CBCB0", Offset = "0x38CA2B0", VA = "0x1838CBCB0")]
	public static global::HLGOBGEGLGJ<T> LJBANOHFBEP(global::HLGOBGEGLGJ<T> MFKKLFEGCGA, T KBIGFDPNKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CJBGLIMGGBJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate Task<TResult> JPBCCKJPKAL(TRequest FBMMFNLPKGA, CancellationToken NJLCMLGACFJ);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum MGMKAECDBJA
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class FMLKNHOBAJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const float JOBAFPMKHFK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TimeSpan PFAKLEPDGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int HIFAJJNNIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MGMKAECDBJA ABBHLLLLIMO;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly FMLKNHOBAJP ABIBAPPLLAK;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float CPBNKKHFMPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x1A39AE0", Offset = "0x1A380E0", VA = "0x181A39AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimeSpan KPDBBJJFEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1A39C30", Offset = "0x1A38230", VA = "0x181A39C30")]
		public FMLKNHOBAJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private readonly struct AMDBBFIJLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly TRequest FBMMFNLPKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly CancellationToken NJLCMLGACFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TaskCompletionSource<TResult> NHHDCDDNMHJ;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1A2CB20", Offset = "0x1A2B120", VA = "0x181A2CB20")]
		public AMDBBFIJLCJ(TRequest FBMMFNLPKGA, TaskCompletionSource<TResult> NHHDCDDNMHJ, CancellationToken NJLCMLGACFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class MIDKFMPAHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public MIDKFMPAHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BF30", Offset = "0x1A3A530", VA = "0x181A3BF30")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FMGMBAGDGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public global::CJBGLIMGGBJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1A39290", Offset = "0x1A37890", VA = "0x181A39290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x70BB80", Offset = "0x70A180", VA = "0x18070BB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EGNKIIGJAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AMDBBFIJLCJ req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::CJBGLIMGGBJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public EGNKIIGJAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1A38F90", Offset = "0x1A37590", VA = "0x181A38F90")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CancellationTokenSource IMKNMIIGMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<AMDBBFIJLCJ> EOOPGGJDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly FMLKNHOBAJP HIJNMCPPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly JPBCCKJPKAL CDAJGCNEBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Task EPPOJEBIHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int BDHFIKHHHLI;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1A363E0", Offset = "0x1A349E0", VA = "0x181A363E0")]
	public CJBGLIMGGBJ(JPBCCKJPKAL CDAJGCNEBMF, [Optional] FMLKNHOBAJP HIJNMCPPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1A35960", Offset = "0x1A33F60", VA = "0x181A35960")]
	public Task<TResult> NKFIHMANLLF(TRequest FBMMFNLPKGA, CancellationToken NJLCMLGACFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1A34850", Offset = "0x1A32E50", VA = "0x181A34850")]
	private void CCIBPAKFMII(AMDBBFIJLCJ JAPJPBNPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1A35280", Offset = "0x1A33880", VA = "0x181A35280")]
	[AsyncStateMachine(typeof(global::CJBGLIMGGBJ<, >.FMGMBAGDGJM))]
	private Task FMBJMCFONFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1A34920", Offset = "0x1A32F20", VA = "0x181A34920")]
	private AMDBBFIJLCJ FFMHGHFOOAP()
	{
		return default(AMDBBFIJLCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1A35390", Offset = "0x1A33990", VA = "0x181A35390")]
	private void KKGFNHLNGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1A348E0", Offset = "0x1A32EE0", VA = "0x181A348E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
public class EEDNHIJKJHA<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate int EJIPDNHJFCK(TKey DHLOMKIAOHC, TVal BABHCNCDDFB);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LJGBAHHHEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TKey PMLMNECINLP
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TVal KBCFGEEMGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x643F70", Offset = "0x642570", VA = "0x180643F70")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x643F80", Offset = "0x642580", VA = "0x180643F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int HNGFJBJNLAA
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x5FA700", Offset = "0x5F8D00", VA = "0x1805FA700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x5FA730", Offset = "0x5F8D30", VA = "0x1805FA730")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public DateTime PENNHIAFPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xEE90F0", Offset = "0xEE76F0", VA = "0x180EE90F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3D63E20", Offset = "0x3D62420", VA = "0x183D63E20")]
		public LJGBAHHHEGJ(TKey DHLOMKIAOHC, TVal BOLPPEKOGED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int NKFABCBKKFF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<LJGBAHHHEGJ>> KFKNNCBLEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<LJGBAHHHEGJ> CMGIJJAJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly EJIPDNHJFCK GJCHHNPOOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan LIJIEDMNBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly OMMHDCMIEDK OAOAFEKGIEA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int MNIFFIKIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x603B30", Offset = "0x602130", VA = "0x180603B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private bool JCIDPDCPGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x269F6B0", Offset = "0x269DCB0", VA = "0x18269F6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal int CCOAKOHADDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x603B40", Offset = "0x602140", VA = "0x180603B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5F8820", Offset = "0x5F6E20", VA = "0x1805F8820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1A55160", Offset = "0x1A53760", VA = "0x181A55160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerable<TKey> MHAPOGPMABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x269FBE0", Offset = "0x269E1E0", VA = "0x18269FBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public TVal HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x269F440", Offset = "0x269DA40", VA = "0x18269F440")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x269FFA0", Offset = "0x269E5A0", VA = "0x18269FFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x26A0750", Offset = "0x269ED50", VA = "0x1826A0750")]
	public EEDNHIJKJHA(int FMHNJGMGKLI, [Optional] EJIPDNHJFCK GJCHHNPOOFB, [Optional] IEqualityComparer<TKey> CMHEKFBLKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x26A0870", Offset = "0x269EE70", VA = "0x1826A0870")]
	public EEDNHIJKJHA(TimeSpan LIJIEDMNBGJ, [Optional] IEqualityComparer<TKey> CMHEKFBLKNO, [Optional] OMMHDCMIEDK OAOAFEKGIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x26A0820", Offset = "0x269EE20", VA = "0x1826A0820")]
	public EEDNHIJKJHA(int FMHNJGMGKLI, TimeSpan LIJIEDMNBGJ, [Optional] IEqualityComparer<TKey> CMHEKFBLKNO, [Optional] OMMHDCMIEDK OAOAFEKGIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3D62C30", Offset = "0x3D61230", VA = "0x183D62C30")]
	public EEDNHIJKJHA(int FMHNJGMGKLI, EJIPDNHJFCK GJCHHNPOOFB, TimeSpan LIJIEDMNBGJ, [Optional] IEqualityComparer<TKey> CMHEKFBLKNO, [Optional] OMMHDCMIEDK OAOAFEKGIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x269F470", Offset = "0x269DA70", VA = "0x18269F470")]
	public void ACLCEJDKAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3D62460", Offset = "0x3D60A60", VA = "0x183D62460")]
	public void IPGBKMGOHCG(TKey DHLOMKIAOHC, TVal BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x26A0260", Offset = "0x269E860", VA = "0x1826A0260")]
	public bool OKJFIGBMPNL(TKey DHLOMKIAOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3D62190", Offset = "0x3D60790", VA = "0x183D62190")]
	private TVal CLAMHKPLIPF(TKey OKJFKPOHENI)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x269FA80", Offset = "0x269E080", VA = "0x18269FA80")]
	public bool JFOHOCKIKHA(TKey OKJFKPOHENI, out TVal BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x269F940", Offset = "0x269DF40", VA = "0x18269F940")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3D62AA0", Offset = "0x3D610A0", VA = "0x183D62AA0")]
	private bool OMANMLBNNOD(LJGBAHHHEGJ BDINEIBBFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3D62810", Offset = "0x3D60E10", VA = "0x183D62810")]
	private void LPOPJLLMLDK(LinkedListNode<LJGBAHHHEGJ> GNMNFGKHJDB, TVal NBHLAMFDLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3D62250", Offset = "0x3D60850", VA = "0x183D62250")]
	private void GLPNNKBNMEG(TKey DHLOMKIAOHC, TVal BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3D62670", Offset = "0x3D60C70", VA = "0x183D62670")]
	private void LJJEEKOGOOE(LJGBAHHHEGJ BDINEIBBFIF, TVal NBHLAMFDLHJ, int CDGOFGNGLCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class EOMABGLJPEM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<T> FNOAABPNLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HashSet<T> BFGCIKIBEHC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BF30", Offset = "0x1A3A530", VA = "0x181A3BF30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OAJJKPLPMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x520EC0", Offset = "0x51F4C0", VA = "0x180520EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x26AA7C0", Offset = "0x26A8DC0", VA = "0x1826AA7C0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x26AA7F0", Offset = "0x26A8DF0", VA = "0x1826AA7F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1A55A50", Offset = "0x1A54050", VA = "0x181A55A50", Slot = "11")]
	public void Add(T EJBKKMFFHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x26AA420", Offset = "0x26A8A20", VA = "0x1826AA420")]
	public bool LDNJNIBFOJD(T EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x26AA660", Offset = "0x26A8C60", VA = "0x1826AA660", Slot = "15")]
	public bool Remove(T EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26A9690", Offset = "0x26A7C90", VA = "0x1826A9690", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x184EE80", Offset = "0x184D480", VA = "0x18184EE80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x26AA2A0", Offset = "0x26A88A0", VA = "0x1826AA2A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1A2D3D0", Offset = "0x1A2B9D0", VA = "0x181A2D3D0", Slot = "13")]
	public bool Contains(T EJBKKMFFHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x26AA300", Offset = "0x26A8900", VA = "0x1826AA300", Slot = "14")]
	public void CopyTo(T[] ABEPAFKBCKK, int NLJPHOEJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x26A94C0", Offset = "0x26A7AC0", VA = "0x1826A94C0", Slot = "6")]
	public int IndexOf(T EJBKKMFFHGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x26AA330", Offset = "0x26A8930", VA = "0x1826AA330", Slot = "7")]
	public void Insert(int ACNPMFDBMJN, T EJBKKMFFHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x26AA590", Offset = "0x26A8B90", VA = "0x1826AA590", Slot = "8")]
	public void RemoveAt(int ACNPMFDBMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x26AA4C0", Offset = "0x26A8AC0", VA = "0x1826AA4C0")]
	public void OIEHCLDCGBB(Predicate<T> INOFMADHJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x26AA3F0", Offset = "0x26A89F0", VA = "0x1826AA3F0")]
	public void KEHNMHPAFCJ(Comparison<T> FJNIEJHJBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x26AA6E0", Offset = "0x26A8CE0", VA = "0x1826AA6E0")]
	public EOMABGLJPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BEKCLLHFEKF
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4AA3A00", Offset = "0x4AA2000", VA = "0x184AA3A00")]
	public static Vector3 DPIDAGMNCKF(this GameObject NEBFDMDBLJL, float MFDILGBFGPG)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1D7B760", Offset = "0x1D79D60", VA = "0x181D7B760")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9650", Offset = "0x4AA7C50", VA = "0x184AA9650")]
		public SerializedGuid(in Guid LDPIEBFLPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4AA91D0", Offset = "0x4AA77D0", VA = "0x184AA91D0")]
		public static SerializedGuid EOAPJCPCJHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9500", Offset = "0x4AA7B00", VA = "0x184AA9500")]
		public static SerializedGuid MLMGJCNEJNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9470", Offset = "0x4AA7A70", VA = "0x184AA9470")]
		public bool HDKOKOGDDPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9620", Offset = "0x4AA7C20", VA = "0x184AA9620", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9580", Offset = "0x4AA7B80", VA = "0x184AA9580", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4AA93D0", Offset = "0x4AA79D0", VA = "0x184AA93D0")]
		public bool GHJICLLLDOK(in Guid LDPIEBFLPBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9250", Offset = "0x4AA7850", VA = "0x184AA9250", Slot = "7")]
		public bool Equals(SerializedGuid OKCILNENDLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4AA92F0", Offset = "0x4AA78F0", VA = "0x184AA92F0", Slot = "0")]
		public override bool Equals(object GPAMIINBFCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9460", Offset = "0x4AA7A60", VA = "0x184AA9460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4AA91A0", Offset = "0x4AA77A0", VA = "0x184AA91A0", Slot = "6")]
		public int CompareTo(SerializedGuid OKCILNENDLC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class IJHHJIGJDFP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Type AKIJAIABOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string BIIENOBPDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool BAMEJJPMPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool MLDPNGCMDFA;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5A60", Offset = "0x4AA4060", VA = "0x184AA5A60")]
	public IJHHJIGJDFP(Type BCMJBPAFDJO, string MMCKDAPDIJG, bool OPICIPFANEF = false, bool HKDPNJMPMDB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface PLKOHKBEOKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IBCCHKLALBI<T> : PLKOHKBEOKI
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	T KBCFGEEMGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool CGDFDLJKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string MHHFCGDOAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::IBCCHKLALBI<T> KDHOCPCGFEH(Action<T> NLIJALKJDKP);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::IBCCHKLALBI<T> DEPJMNFEEOP(Action<T> NLIJALKJDKP);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::IBCCHKLALBI<T> PJPCFGIJNFC(Action<T, T> CBAHJDEGDMK);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::IBCCHKLALBI<T> CGJACCGLOFD(Action<T, T> CBAHJDEGDMK);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::IBCCHKLALBI<T> EBFOMAKPHLK(Action<string> GFANBILONPL);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::IBCCHKLALBI<T> GPMDBOAEBOK(Action<string> GFANBILONPL);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NMFGODNEFNJ<T> : global::IBCCHKLALBI<T>, PLKOHKBEOKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::BMIHAABCPBG<T, T> DMJEOIMDACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::INCACPDBFMG<T> MHBCNMKFBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private global::INCACPDBFMG<string> JLJGMBDDMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private string BOAFMINDOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private T LOOEHOMEKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool CDNCABCEKPE;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public T KBCFGEEMGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2117C70", Offset = "0x2116270", VA = "0x182117C70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CGDFDLJKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x54D240", Offset = "0x54B840", VA = "0x18054D240", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string MHHFCGDOAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x595E30", Offset = "0x594430", VA = "0x180595E30", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x24F5F10", Offset = "0x24F4510", VA = "0x1824F5F10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3149560", Offset = "0x3147B60", VA = "0x183149560")]
	private void HLBMEMHCANB(T BLEEFJJFMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3149320", Offset = "0x3147920", VA = "0x183149320")]
	private void AALMJOEIHMP(string MCPECHDCOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3149690", Offset = "0x3147C90", VA = "0x183149690")]
	public void NPICCIOOEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3149740", Offset = "0x3147D40", VA = "0x183149740", Slot = "6")]
	public global::IBCCHKLALBI<T> PJPCFGIJNFC(Action<T, T> CBAHJDEGDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x31493C0", Offset = "0x31479C0", VA = "0x1831493C0", Slot = "7")]
	public global::IBCCHKLALBI<T> CGJACCGLOFD(Action<T, T> CBAHJDEGDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3149600", Offset = "0x3147C00", VA = "0x183149600", Slot = "4")]
	public global::IBCCHKLALBI<T> KDHOCPCGFEH(Action<T> CBAHJDEGDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3149410", Offset = "0x3147A10", VA = "0x183149410", Slot = "5")]
	public global::IBCCHKLALBI<T> DEPJMNFEEOP(Action<T> NLIJALKJDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3149460", Offset = "0x3147A60", VA = "0x183149460", Slot = "8")]
	public global::IBCCHKLALBI<T> EBFOMAKPHLK(Action<string> GFANBILONPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x31494F0", Offset = "0x3147AF0", VA = "0x1831494F0", Slot = "9")]
	public global::IBCCHKLALBI<T> GPMDBOAEBOK(Action<string> GFANBILONPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3149790", Offset = "0x3147D90", VA = "0x183149790")]
	public NMFGODNEFNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class ALAFBMPLBDA
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class MPKEEEIBHHM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public global::IBCCHKLALBI<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public global::CHOLDODOGCF<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public MPKEEEIBHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB140", Offset = "0x2DE9740", VA = "0x182DEB140")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x18A5E20", Offset = "0x18A4420", VA = "0x1818A5E20")]
	public static global::OGKKIDEDJHF<T> ONLBNNFAJLI<T>(this global::IBCCHKLALBI<T> PNIDBGMIEAF, Action<T> MCONDHIGJPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class OMMHDCMIEDK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BELPCMMHPIH : OMMHDCMIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static OMMHDCMIEDK KPCEMOHFCAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x4AA3CE0", Offset = "0x4AA22E0", VA = "0x184AA3CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DateTime JBGEPLLJBOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x4AA3C90", Offset = "0x4AA2290", VA = "0x184AA3C90", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override float BAPHKLKAPHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x4A9D8F0", Offset = "0x4A9BEF0", VA = "0x184A9D8F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4AA3DE0", Offset = "0x4AA23E0", VA = "0x184AA3DE0")]
		public BELPCMMHPIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static OMMHDCMIEDK MMNGPPNGEDI;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static OMMHDCMIEDK ABIBAPPLLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4AA7500", Offset = "0x4AA5B00", VA = "0x184AA7500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract DateTime JBGEPLLJBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract float BAPHKLKAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	protected OMMHDCMIEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class LAALHOCBBEI : global::LIOPGGABLAN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5C90", Offset = "0x4AA4290", VA = "0x184AA5C90")]
	public LAALHOCBBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class LIOPGGABLAN<T> : global::NJHBFIHMPAB<T>, MIMILCIKIDH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Task<T> CJDFDAGGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private Task HKEIHHGDLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x184D620", Offset = "0x184BC20", VA = "0x18184D620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public global::OGKKIDEDJHF<T> CCNPFAFCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private HAMIGNOLDMC FNDGDGNHOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1855510", Offset = "0x1853B10", VA = "0x181855510", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2753370", Offset = "0x2751970", VA = "0x182753370")]
	public LIOPGGABLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LEMOBHKCGKM : global::LGLGOKBLJEP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6120", Offset = "0x4AA4720", VA = "0x184AA6120")]
	public LEMOBHKCGKM(Exception JBAJFCDPKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LGLGOKBLJEP<T> : global::NJHBFIHMPAB<T>, MIMILCIKIDH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Task<T> CJDFDAGGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private Task HKEIHHGDLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x184D620", Offset = "0x184BC20", VA = "0x18184D620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public global::OGKKIDEDJHF<T> CCNPFAFCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private HAMIGNOLDMC FNDGDGNHOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1855510", Offset = "0x1853B10", VA = "0x181855510", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x274EDE0", Offset = "0x274D3E0", VA = "0x18274EDE0")]
	public LGLGOKBLJEP(Exception JBAJFCDPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MIMILCIKIDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	Task CJDFDAGGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[NotNull]
	HAMIGNOLDMC CCNPFAFCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NJHBFIHMPAB<T> : MIMILCIKIDH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	new Task<T> CJDFDAGGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[NotNull]
	new global::OGKKIDEDJHF<T> CCNPFAFCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class ABEHGKGOKCC<TTask, T> : global::NJHBFIHMPAB<T>, MIMILCIKIDH, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OBMAJMHGNMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::ABEHGKGOKCC<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public OBMAJMHGNMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool GGIMELPHEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Task<T> DPOKNBMKJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly CancellationTokenSource BLHKJHBEJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool AKLNNMMMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private SynchronizationContext IJJCOCIJEMG;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> CJDFDAGGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task HKEIHHGDLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::OGKKIDEDJHF<T> CCNPFAFCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private HAMIGNOLDMC FNDGDGNHOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1941780", Offset = "0x193FD80", VA = "0x181941780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool AJPPMCGFHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x54C310", Offset = "0x54A910", VA = "0x18054C310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4AB0", Offset = "0x3DB30B0", VA = "0x183DB4AB0")]
	static ABEHGKGOKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4DD0", Offset = "0x3DB33D0", VA = "0x183DB4DD0")]
	protected ABEHGKGOKCC(TTask DPOKNBMKJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3DB47B0", Offset = "0x3DB2DB0", VA = "0x183DB47B0", Slot = "1")]
	~ABEHGKGOKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3D95FC0", Offset = "0x3D945C0", VA = "0x183D95FC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3DB44D0", Offset = "0x3DB2AD0", VA = "0x183DB44D0")]
	private void BOLNPHFANNL(bool LMAJAGDCLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T DIKEJNMOHHJ(TTask HINLGOEFEEG);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LPIKLFDDBFL();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3DB48F0", Offset = "0x3DB2EF0", VA = "0x183DB48F0")]
	[CompilerGenerated]
	private void PDGBMLBOKFG(object OHMJBOCKFPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KPBHMCFNALK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Type AKIJAIABOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly string BIIENOBPDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly bool BAMEJJPMPPK;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5C30", Offset = "0x4AA4230", VA = "0x184AA5C30")]
	public KPBHMCFNALK(Type BCMJBPAFDJO, string MMCKDAPDIJG, bool OPICIPFANEF = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x520ED0", Offset = "0x51F4D0", VA = "0x180520ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x544710", Offset = "0x542D10", VA = "0x180544710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public T this[int BPOGJBAOFOB, int KIGLGAHFAJJ]
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1C69E40", Offset = "0x1C68440", VA = "0x181C69E40")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1C69EE0", Offset = "0x1C684E0", VA = "0x181C69EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1C69DB0", Offset = "0x1C683B0", VA = "0x181C69DB0")]
		public Array2D(uint NABAGIDNPBH, uint LCHOEMIECIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1C69D30", Offset = "0x1C68330", VA = "0x181C69D30")]
		public void HPEBFGMNFBA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4AA39A0", Offset = "0x4AA1FA0", VA = "0x184AA39A0")]
		public Array2DVector3(uint NABAGIDNPBH, uint LCHOEMIECIB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal static class PEDKKLBFELG
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const int PCDHLNCABIJ = -1;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const int HEPLBMHDODK = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public class IKAHPKIAKCL<THandle, TValue> : IDisposable where THandle : struct, FBPDNPPGGEH where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly List<THandle> AHBCLMOBEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<TValue> PFNEGIMMBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly Func<TValue> MCHFCGMLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly Action<TValue> MKIJEHNODIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private int MFPKDDFBJFP;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public TValue HOGHGDFMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x269F440", Offset = "0x269DA40", VA = "0x18269F440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x271BBD0", Offset = "0x271A1D0", VA = "0x18271BBD0")]
	public IKAHPKIAKCL(Action<TValue> MKIJEHNODIF, [Optional] Func<TValue> MCHFCGMLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x271B420", Offset = "0x2719A20", VA = "0x18271B420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3B89500", Offset = "0x3B87B00", VA = "0x183B89500")]
	public THandle DBFOOEAJHCK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x271B710", Offset = "0x2719D10", VA = "0x18271B710")]
	public THandle KNBMMGKPMNM(TValue BABHCNCDDFB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x271B9D0", Offset = "0x2719FD0", VA = "0x18271B9D0")]
	public bool OKJFIGBMPNL(THandle BPMOBDFOFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x271B840", Offset = "0x2719E40", VA = "0x18271B840")]
	public bool NAJICFINNHE(THandle BPMOBDFOFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x271B920", Offset = "0x2719F20", VA = "0x18271B920")]
	public bool NBBLKCIGCBJ(THandle BPMOBDFOFGO, out TValue BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x271B260", Offset = "0x2719860", VA = "0x18271B260")]
	public TValue CLAMHKPLIPF(THandle BPMOBDFOFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x271B170", Offset = "0x2719770", VA = "0x18271B170")]
	public bool AAIGAJJPACG(THandle BPMOBDFOFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x271B790", Offset = "0x2719D90", VA = "0x18271B790")]
	private THandle LLALHNJIACI(int ACNPMFDBMJN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x271BA80", Offset = "0x271A080", VA = "0x18271BA80")]
	private TValue ONLBNNFAJLI(int ACNPMFDBMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x271B220", Offset = "0x2719820", VA = "0x18271B220")]
	private void ANAMGPAIAEO(int ACNPMFDBMJN, in THandle BPMOBDFOFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x271B5B0", Offset = "0x2719BB0", VA = "0x18271B5B0")]
	private void HLBMEMHCANB(int ACNPMFDBMJN, in TValue BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x271B4A0", Offset = "0x2719AA0", VA = "0x18271B4A0")]
	private THandle HJEGLGHPPML()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x271B5F0", Offset = "0x2719BF0", VA = "0x18271B5F0")]
	private void HLDKEENENNO(THandle BPMOBDFOFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x271B9C0", Offset = "0x2719FC0", VA = "0x18271B9C0")]
	private int NBEGBAPOCFO(int FIOPGIELFCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x271B780", Offset = "0x2719D80", VA = "0x18271B780")]
	private bool LCANOHAOKEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7A06B0", Offset = "0x79ECB0", VA = "0x1807A06B0")]
	private void IAHPHDNONDB(THandle BPMOBDFOFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x271B7C0", Offset = "0x2719DC0", VA = "0x18271B7C0")]
	private bool LLNJFDHKJAG(out THandle BPMOBDFOFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x271B350", Offset = "0x2719950", VA = "0x18271B350")]
	private bool DLHEHLEEFNM(out THandle BPMOBDFOFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x271B6B0", Offset = "0x2719CB0", VA = "0x18271B6B0")]
	private void IADIKGKHMEK(THandle BPMOBDFOFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x271BAB0", Offset = "0x271A0B0", VA = "0x18271BAB0")]
	private void PFIBICJBICC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface FBPDNPPGGEH
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int NFBJLKNIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int DLLCIKOMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface NMBDKBPBKJH<T> : FBPDNPPGGEH, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class GEIHEILGFPD
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E7F0", Offset = "0x1C5CDF0", VA = "0x181C5E7F0")]
	public static bool POLCHLHJOEC<T>(this T BPMOBDFOFGO) where T : struct, FBPDNPPGGEH
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class MHNMHEIKKPN
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private enum LCHEADGHNPN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int NMILPJPINAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool BLGPPNIMBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private LCHEADGHNPN FLFOJDLIHBM;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool EKACNINBPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4AA6A20", Offset = "0x4AA5020", VA = "0x184AA6A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool KJLIJNIKDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4AA6A10", Offset = "0x4AA5010", VA = "0x184AA6A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7020", Offset = "0x4AA5620", VA = "0x184AA7020")]
	public MHNMHEIKKPN(bool BLGPPNIMBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6A90", Offset = "0x4AA5090", VA = "0x184AA6A90")]
	public void OMPOJHIPKCJ(object GPAMIINBFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6940", Offset = "0x4AA4F40", VA = "0x184AA6940")]
	public void HCEGHDALGND(int BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4AA69F0", Offset = "0x4AA4FF0", VA = "0x184AA69F0")]
	public void HJKMPKLFCCI(uint NGAKCLJPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6A70", Offset = "0x4AA5070", VA = "0x184AA6A70")]
	public void MILPLGOJIOC(bool MNHMAMMHMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6240", Offset = "0x4AA4840", VA = "0x184AA6240")]
	public void ADMGBKDGKIH(long BFOBCLPEAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6A30", Offset = "0x4AA5030", VA = "0x184AA6A30")]
	public void LEGDMJKFOCI(ulong JHFKLNGPCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6720", Offset = "0x4AA4D20", VA = "0x184AA6720")]
	public void EHLKCNFAGEO(string GKAIPLAPCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4AA68B0", Offset = "0x4AA4EB0", VA = "0x184AA68B0")]
	public void FGLJJKMGLPB(Enum JBAJFCDPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6790", Offset = "0x4AA4D90", VA = "0x184AA6790")]
	public void EHOGEPDOOHD(IList FNOAABPNLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x21F23D0", Offset = "0x21F09D0", VA = "0x1821F23D0")]
	public void JCPMBPIPEGJ<T, U>(Dictionary<T, U> GCBKJHKIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6280", Offset = "0x4AA4880", VA = "0x184AA6280")]
	private void AHCKHABPKJN(IDictionary GCBKJHKIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6FB0", Offset = "0x4AA55B0", VA = "0x184AA6FB0")]
	public int PCMCBPKODEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6640", Offset = "0x4AA4C40", VA = "0x184AA6640")]
	public short BNBOHECFLEJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6A00", Offset = "0x4AA5000", VA = "0x184AA6A00")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x4AA66B0", Offset = "0x4AA4CB0", VA = "0x184AA66B0")]
	private void DKJPMJLPFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class KFBIAFIECGF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class GNHHJPAKHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode ODBODAJNEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TNode ODFEOHMNKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AAAOEDPNEGM GJKDKMFPDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<AAAOEDPNEGM> CDBMNELPFII;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public GNHHJPAKHPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal struct AAAOEDPNEGM : IComparable<AAAOEDPNEGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int BEFFNCBJGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public TClaimant IODGIBFOJIF;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x528CF0", Offset = "0x5272F0", VA = "0x180528CF0")]
		public AAAOEDPNEGM(int BEFFNCBJGPL, TClaimant IODGIBFOJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF000", Offset = "0x3EDD600", VA = "0x183EDF000")]
		public bool AMGGECOBMDM(in AAAOEDPNEGM OKCILNENDLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF070", Offset = "0x3EDD670", VA = "0x183EDF070")]
		public bool MKMCPBBDCAB(in AAAOEDPNEGM OKCILNENDLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF060", Offset = "0x3EDD660", VA = "0x183EDF060", Slot = "4")]
		public int CompareTo(AAAOEDPNEGM OKCILNENDLC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF080", Offset = "0x3EDD680", VA = "0x183EDF080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum LODFFAJJAJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class FODHCCDPDCI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public global::KFBIAFIECGF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x210DC70", Offset = "0x210C270", VA = "0x18210DC70")]
		[DebuggerHidden]
		public FODHCCDPDCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5F80", Offset = "0x3EE4580", VA = "0x183EE5F80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6140", Offset = "0x3EE4740", VA = "0x183EE6140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6060", Offset = "0x3EE4660", VA = "0x183EE6060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1859660", Offset = "0x1857C60", VA = "0x181859660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly global::CPGHPKPNDHP<GNHHJPAKHPE> HMDDNAMOABA;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly global::CPGHPKPNDHP<List<AAAOEDPNEGM>> DAAKCJMODJL;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static int JECGKDHDNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	internal readonly Dictionary<TClaimant, TNode> NHCFEJCACLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal readonly Dictionary<TNode, GNHHJPAKHPE> DCBKFLIPKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private LODFFAJJAJM PDCJEPDONLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool CCIFJPJKBPP;

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode HINIBJPMJCP(TNode LEBKLFJFIIP);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CFJCGKDBEAA(TNode LEBKLFJFIIP, TClaimant KPPNOJMFOGA, TClaimant CBBOIIPMCGF);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2FC0", Offset = "0x3EF15C0", VA = "0x183EF2FC0")]
	public KFBIAFIECGF(LODFFAJJAJM PDCJEPDONLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1C10", Offset = "0x3EF0210", VA = "0x183EF1C10")]
	public void CIEFJLHALGF(TNode LEBKLFJFIIP, TNode KEOGPNLMCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2570", Offset = "0x3EF0B70", VA = "0x183EF2570")]
	public void FJOPLBAPIEP(TClaimant IODGIBFOJIF, TNode KBOOMNMNFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1ED0", Offset = "0x3EF04D0", VA = "0x183EF1ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3EF29C0", Offset = "0x3EF0FC0", VA = "0x183EF29C0")]
	private void ICALCJLAKIK(TClaimant IODGIBFOJIF, TNode EJJPPCKEBIM, TNode KBOOMNMNFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1D20", Offset = "0x3EF0320", VA = "0x183EF1D20")]
	private int CLBBDHEBKLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1860", Offset = "0x3EEFE60", VA = "0x183EF1860")]
	private void AGINBLBPAEC(TClaimant IODGIBFOJIF, TNode NBDAFLPKGPE, TNode FBBMNGDDNKF, int LCOHGINBFDP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1C90", Offset = "0x3EF0290", VA = "0x183EF1C90")]
	private void CLAPAPPHBAL(AAAOEDPNEGM HANGEMHNKGN, GNHHJPAKHPE AEKEBGNGJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2BF0", Offset = "0x3EF11F0", VA = "0x183EF2BF0")]
	private void OELBNPKCHFC(TClaimant IODGIBFOJIF, TNode NBDAFLPKGPE, TNode FBBMNGDDNKF, int LCOHGINBFDP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1760", Offset = "0x3EEFD60", VA = "0x183EF1760")]
	private void AELGANNBANL(AAAOEDPNEGM HANGEMHNKGN, TNode LEBKLFJFIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1B10", Offset = "0x3EF0110", VA = "0x183EF1B10")]
	private void BFFPNMEGNOK(AAAOEDPNEGM HANGEMHNKGN, GNHHJPAKHPE AEKEBGNGJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1D90", Offset = "0x3EF0390", VA = "0x183EF1D90")]
	private void DKMBCIHBEEJ(GNHHJPAKHPE AEKEBGNGJAH, bool ELALKKEIJLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2130", Offset = "0x3EF0730", VA = "0x183EF2130")]
	private void ELNMKMJACCE(GNHHJPAKHPE AEKEBGNGJAH, TNode KEOGPNLMCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2B20", Offset = "0x3EF1120", VA = "0x183EF2B20")]
	[IteratorStateMachine(typeof(global::KFBIAFIECGF<, >.FODHCCDPDCI))]
	private IEnumerable<TNode> KGJOKHKGDJH(TNode NBDAFLPKGPE, TNode FBBMNGDDNKF, bool NOBMCJAGKCH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2A60", Offset = "0x3EF1060", VA = "0x183EF2A60")]
	private GNHHJPAKHPE IODOFALIMGF(TNode LEBKLFJFIIP, TNode ODFEOHMNKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2830", Offset = "0x3EF0E30", VA = "0x183EF2830")]
	private GNHHJPAKHPE IAGFDPKAGAC(TNode LEBKLFJFIIP, TNode ODFEOHMNKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2670", Offset = "0x3EF0C70", VA = "0x183EF2670")]
	private void GDFODIAHFAK(GNHHJPAKHPE AEKEBGNGJAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class NFCNFICHMKB<T> : IEnumerable<global::NFCNFICHMKB<T>.LEPDKMLBCJG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct LEPDKMLBCJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public T BABHCNCDDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int ACNPMFDBMJN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class LJLIHAFAAKI : IEnumerator<LEPDKMLBCJG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private global::NFCNFICHMKB<T> DNDAMGEIFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int ACNPMFDBMJN;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x247F7F0", Offset = "0x247DDF0", VA = "0x18247F7F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public LEPDKMLBCJG IBJOODGOBHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x31421C0", Offset = "0x31407C0", VA = "0x1831421C0", Slot = "4")]
			get
			{
				return default(LEPDKMLBCJG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x70F020", Offset = "0x70D620", VA = "0x18070F020")]
		public LJLIHAFAAKI(global::NFCNFICHMKB<T> DNDAMGEIFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3142130", Offset = "0x3140730", VA = "0x183142130", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x70F010", Offset = "0x70D610", VA = "0x18070F010", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAA0", Offset = "0x6BC0A0", VA = "0x1806BDAA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private struct KBLIJFDGANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool DFCCMNKMPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public T BABHCNCDDFB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private const int BIOMNONDGGL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Dictionary<T, int> GFMMOJAKBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private KBLIJFDGANL[] PCGBBDFHCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int EEBEIKHAENP;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x26A94F0", Offset = "0x26A7AF0", VA = "0x1826A94F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3143190", Offset = "0x3141790", VA = "0x183143190")]
	public static global::NFCNFICHMKB<T> ELJPLDFIMBP(LEPDKMLBCJG[] ILABPBGLAKH, bool HOKNPACFEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3143B90", Offset = "0x3142190", VA = "0x183143B90")]
	public NFCNFICHMKB(int FMHNJGMGKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x20C6990", Offset = "0x20C4F90", VA = "0x1820C6990")]
	public bool BCCFJHGDBBP(T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3143030", Offset = "0x3141630", VA = "0x183143030")]
	public bool BPABEAFLBMP(int ACNPMFDBMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x31430E0", Offset = "0x31416E0", VA = "0x1831430E0")]
	public bool DEEPBBKBDCI(Func<T, bool> JJANGMINMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3143090", Offset = "0x3141690", VA = "0x183143090")]
	public int CNBJLNLGFMM(T BABHCNCDDFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3143930", Offset = "0x3141F30", VA = "0x183143930")]
	public T ONLBNNFAJLI(int ACNPMFDBMJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x31435C0", Offset = "0x3141BC0", VA = "0x1831435C0")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3143660", Offset = "0x3141C60", VA = "0x183143660")]
	public bool LDNJNIBFOJD(T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3143680", Offset = "0x3141C80", VA = "0x183143680")]
	public bool LDNJNIBFOJD(T BABHCNCDDFB, int ACNPMFDBMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x31438B0", Offset = "0x3141EB0", VA = "0x1831438B0")]
	public bool OKJFIGBMPNL(T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x3143570", Offset = "0x3141B70", VA = "0x183143570")]
	public bool HFGIMBGAAGI(int ACNPMFDBMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3142F80", Offset = "0x3141580", VA = "0x183142F80")]
	private void BBLFBHAHPAD(int ACNPMFDBMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x31439A0", Offset = "0x3141FA0", VA = "0x1831439A0")]
	public LEPDKMLBCJG[] PLNBFMOMMJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3143610", Offset = "0x3141C10", VA = "0x183143610")]
	private int KEEMPJFPBEI(int AMGFIMAOBNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3143B10", Offset = "0x3142110", VA = "0x183143B10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3143B10", Offset = "0x3142110", VA = "0x183143B10", Slot = "4")]
	private IEnumerator<LEPDKMLBCJG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CPGHPKPNDHP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Stack<T> DBDONNELEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<T> PMHJCCIPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly int HJOFGHBGLEC;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int MKMHDIFMHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1A38980", Offset = "0x1A36F80", VA = "0x181A38980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LHEPKKNMBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1A386C0", Offset = "0x1A36CC0", VA = "0x181A386C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1A38A70", Offset = "0x1A37070", VA = "0x181A38A70")]
	public static global::CPGHPKPNDHP<T> PNLBEHGJPMP(int FMHNJGMGKLI = 0, int HJOFGHBGLEC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1A388B0", Offset = "0x1A36EB0", VA = "0x181A388B0")]
	public static global::CPGHPKPNDHP<T> LNHMLJLOFMM(int FMHNJGMGKLI = 0, int HJOFGHBGLEC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1A38B40", Offset = "0x1A37140", VA = "0x181A38B40")]
	public CPGHPKPNDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1A38B80", Offset = "0x1A37180", VA = "0x181A38B80")]
	public CPGHPKPNDHP(int FMHNJGMGKLI, int HJOFGHBGLEC = int.MaxValue, bool EFIPCFNCGJP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1A38590", Offset = "0x1A36B90", VA = "0x181A38590")]
	public T GLCCHCLLOFC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1A38270", Offset = "0x1A36870", VA = "0x181A38270")]
	public void CDGIKKKIGPP(T BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1A389B0", Offset = "0x1A36FB0", VA = "0x181A389B0")]
	private void PKLNEOPNFAO(T BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1A38250", Offset = "0x1A36850", VA = "0x181A38250")]
	private void CALFGMOICKP(T BABHCNCDDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1A38330", Offset = "0x1A36930", VA = "0x181A38330")]
	[Conditional("DEBUG_BUILD")]
	private void DKELFHJDFJO(T JHNLGOFFNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1A384E0", Offset = "0x1A36AE0", VA = "0x181A384E0")]
	[Conditional("DEBUG_BUILD")]
	private void EOJNMBGIPNO(T JHNLGOFFNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1A383D0", Offset = "0x1A369D0", VA = "0x181A383D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1A386F0", Offset = "0x1A36CF0", VA = "0x181A386F0")]
	private void KPGAHADLILE(IEnumerable<T> PFNEGIMMBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MJAOPNGNJBP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Dictionary<int, T> OEFMFDLDCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private T IGHPJNAAEAG;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T LKEDLFDAJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5204A0", Offset = "0x51EAA0", VA = "0x1805204A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool GOIHBCGDGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x35130B0", Offset = "0x35116B0", VA = "0x1835130B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x3512D60", Offset = "0x3511360", VA = "0x183512D60")]
	public bool GLPNNKBNMEG(T BABHCNCDDFB, int BEFFNCBJGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x3512EB0", Offset = "0x35114B0", VA = "0x183512EB0")]
	public bool OHOGNNIPOKJ(int BEFFNCBJGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3512B00", Offset = "0x3511100", VA = "0x183512B00")]
	public T AJJCLOIJBEB(int MGAPKFICLLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x3512E20", Offset = "0x3511420", VA = "0x183512E20")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x3512F10", Offset = "0x3511510", VA = "0x183512F10")]
	private bool OMIJFCANEON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x3512E80", Offset = "0x3511480", VA = "0x183512E80")]
	public bool JFOHOCKIKHA(int BEFFNCBJGPL, out T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x34DB3C0", Offset = "0x34D99C0", VA = "0x1834DB3C0")]
	public MJAOPNGNJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class IPMJJFIIFAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	protected struct KEJFALCGECP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public T KBCFGEEMGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int AAIKKFEEOBN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	protected readonly List<KEJFALCGECP> NDLDJJFEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private T PBNNKBPLOCH;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BF30", Offset = "0x1A3A530", VA = "0x181A3BF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x272DA50", Offset = "0x272C050", VA = "0x18272DA50")]
	public bool DEEPBBKBDCI(T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x272DF80", Offset = "0x272C580", VA = "0x18272DF80")]
	public void KNBMMGKPMNM(T BABHCNCDDFB, int BEFFNCBJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x272E0B0", Offset = "0x272C6B0", VA = "0x18272E0B0")]
	public bool OKJFIGBMPNL(T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x272DD10", Offset = "0x272C310", VA = "0x18272DD10")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x272E020", Offset = "0x272C620", VA = "0x18272E020")]
	public T LBFCJCELDIP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x272DCA0", Offset = "0x272C2A0", VA = "0x18272DCA0")]
	public T FFMHGHFOOAP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x272DD70", Offset = "0x272C370", VA = "0x18272DD70")]
	private void ICJFNGEMBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x272E1D0", Offset = "0x272C7D0", VA = "0x18272E1D0")]
	public IPMJJFIIFAB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		[HBIKBANNKLO(IEPJIHIMMDL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x4AA7BB0", Offset = "0x4AA61B0", VA = "0x184AA7BB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x4AA8080", Offset = "0x4AA6680", VA = "0x184AA8080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x4AA7EA0", Offset = "0x4AA64A0", VA = "0x184AA7EA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x4AA8220", Offset = "0x4AA6820", VA = "0x184AA8220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x4AA7A70", Offset = "0x4AA6070", VA = "0x184AA7A70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x4AA7F40", Offset = "0x4AA6540", VA = "0x184AA7F40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x4AA7D60", Offset = "0x4AA6360", VA = "0x184AA7D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4AA79D0", Offset = "0x4AA5FD0", VA = "0x184AA79D0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface KGAOKBKKFCO
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public abstract class ResourcePrefabReference<T> : KGAOKBKKFCO where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1C7D680", Offset = "0x1C7BC80", VA = "0x181C7D680", Slot = "4")]
		public virtual T ALPHJPEHKOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class ECAAMICPHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly Dictionary<byte, FDJMLGDOPIE> HKPNIOPDBDP;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FDJMLGDOPIE DMJPHKLMADI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 LMEIJOJFGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xF5CE60", Offset = "0xF5B460", VA = "0x180F5CE60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x26A0E70", Offset = "0x269F470", VA = "0x1826A0E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 KLCLNBDAFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1173440", Offset = "0x1171A40", VA = "0x181173440")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x11734A0", Offset = "0x1171AA0", VA = "0x1811734A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector2 LEEMDNPELDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x34128D0", Offset = "0x3410ED0", VA = "0x1834128D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x34128F0", Offset = "0x3410EF0", VA = "0x1834128F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int POGKPJPBCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x552A90", Offset = "0x551090", VA = "0x180552A90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A06B0", Offset = "0x79ECB0", VA = "0x1807A06B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4690", Offset = "0x4AA2C90", VA = "0x184AA4690")]
	public ECAAMICPHIJ(Bounds HFBBJENCNMM, Vector2[] DMHAELEIOJL, int JIBEDIBAGJL, byte AMGFIMAOBNL, float FMHDJBNDIHO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4610", Offset = "0x4AA2C10", VA = "0x184AA4610")]
	public FDJMLGDOPIE JFBKNPHHLOI(byte ACNPMFDBMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4AA3ED0", Offset = "0x4AA24D0", VA = "0x184AA3ED0")]
	public void BAFMCIGEIEG(Vector3 PDJHCHHFEPH, float EIJDJOGLAHJ, float KCMBPOFGNLI, ref List<byte> LPMJPLAECKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4670", Offset = "0x4AA2C70", VA = "0x184AA4670")]
	public void NHGIFJBACIM(FDJMLGDOPIE.HEOEKFEGFNP HANALLCMCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4AA3FC0", Offset = "0x4AA25C0", VA = "0x184AA3FC0")]
	private FDJMLGDOPIE EHONGBABHFD(byte ACNPMFDBMJN, FDJMLGDOPIE.FIKJGJKPFDM OJJJOLNALJF, FDJMLGDOPIE ODFEOHMNKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4AA40F0", Offset = "0x4AA26F0", VA = "0x184AA40F0")]
	private void HCDOCPJJCDN(FDJMLGDOPIE ODFEOHMNKLG, Vector2[] DMHAELEIOJL, int OOJHHLLCCCK, int GGMAKADMFIG, int LPDJKPFBCDO, int NPGGJPPDMJO, float FMHDJBNDIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class FDJMLGDOPIE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum FIKJGJKPFDM
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public enum HEOEKFEGFNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public byte OLFJDNOPNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3 MDAOOFGKMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3 HNGFJBJNLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 DDEEIGMPGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 GHKIPBHPCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public FIKJGJKPFDM CBKDBOLMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public FDJMLGDOPIE DGJIJHEFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public List<FDJMLGDOPIE> AGLNCIFNKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool ILBOPLHJECG;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5570", Offset = "0x4AA3B70", VA = "0x184AA5570")]
	public FDJMLGDOPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5590", Offset = "0x4AA3B90", VA = "0x184AA5590")]
	public FDJMLGDOPIE(byte LLIGDOJCLHG, FIKJGJKPFDM OJJJOLNALJF, FDJMLGDOPIE ODFEOHMNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5430", Offset = "0x4AA3A30", VA = "0x184AA5430")]
	public void DNDFJMJBMMA(FDJMLGDOPIE JGDEMOIEFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80")]
	public void NHGIFJBACIM(int KIECOBPCGPE, HEOEKFEGFNP HANALLCMCFE, int LMMFIBFEIAE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4AA51A0", Offset = "0x4AA37A0", VA = "0x184AA51A0")]
	public void BAFMCIGEIEG(List<byte> LPMJPLAECKG, Vector3 PDJHCHHFEPH, float EIJDJOGLAHJ, float KCMBPOFGNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4AA54D0", Offset = "0x4AA3AD0", VA = "0x184AA54D0")]
	public bool KFAHKMGJAHH(Vector3 IEADBHEDFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5530", Offset = "0x4AA3B30", VA = "0x184AA5530")]
	public bool LCMLICOJGOE(Vector3 IEADBHEDFPH, float CJPABILKPFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class EDCLNFMNCKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Dictionary<T, object> CIONODACEAP;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2133340", Offset = "0x2131940", VA = "0x182133340")]
	public bool ANBBGCFLPMP(T PJODPFEBIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D1E0", Offset = "0x3D5B7E0", VA = "0x183D5D1E0")]
	public bool ANBBGCFLPMP(T PJODPFEBIFL, object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D220", Offset = "0x3D5B820", VA = "0x183D5D220")]
	public bool ANBBGCFLPMP(T PJODPFEBIFL, object FCIGEDFPCAI, out object LBMMFDFAOHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D280", Offset = "0x3D5B880", VA = "0x183D5D280")]
	public bool BGOKMANHCGF(T PJODPFEBIFL, object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D3F0", Offset = "0x3D5B9F0", VA = "0x183D5D3F0")]
	public bool BJNHPCDJJNL(T PJODPFEBIFL, object FCIGEDFPCAI, out object LBMMFDFAOHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D2C0", Offset = "0x3D5B8C0", VA = "0x183D5D2C0")]
	public bool BGOKMANHCGF(T PJODPFEBIFL, object FCIGEDFPCAI, out object LBMMFDFAOHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D430", Offset = "0x3D5BA30", VA = "0x183D5D430")]
	public void KOLCBFCPJKA(T PJODPFEBIFL, object FCIGEDFPCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D350", Offset = "0x3D5B950", VA = "0x183D5D350")]
	public void BIJMJFGHLKM(T PJODPFEBIFL, object FCIGEDFPCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D460", Offset = "0x3D5BA60", VA = "0x183D5D460")]
	public EDCLNFMNCKM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public struct EHKMOKJIKNA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly List<Component> FNOAABPNLKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private readonly bool AFEPKAMMHFG;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x669840", Offset = "0x667E40", VA = "0x180669840")]
			public EHKMOKJIKNA(List<Component> FNOAABPNLKF, bool AFEPKAMMHFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x1C6E400", Offset = "0x1C6CA00", VA = "0x181C6E400")]
			public MNJNFFLDLHN<T> AICDEAFDBPL()
			{
				return default(MNJNFFLDLHN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x1C6E470", Offset = "0x1C6CA70", VA = "0x181C6E470", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x1C6E470", Offset = "0x1C6CA70", VA = "0x181C6E470", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public struct MNJNFFLDLHN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private readonly List<Component> FNOAABPNLKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private readonly bool AFEPKAMMHFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private int ACNPMFDBMJN;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T IBJOODGOBHB
			{
				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x1C74410", Offset = "0x1C72A10", VA = "0x181C74410", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x1C743A0", Offset = "0x1C729A0", VA = "0x181C743A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x1C743E0", Offset = "0x1C729E0", VA = "0x181C743E0")]
			public MNJNFFLDLHN(List<Component> FNOAABPNLKF, bool AFEPKAMMHFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x1C742D0", Offset = "0x1C728D0", VA = "0x181C742D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x1C742E0", Offset = "0x1C728E0", VA = "0x181C742E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x1C74390", Offset = "0x1C72990", VA = "0x181C74390", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9EE0", Offset = "0x4AA84E0", VA = "0x184AA9EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9EA0", Offset = "0x4AA84A0", VA = "0x184AA9EA0")]
		public ToolHierarchyCache(GameObject NJHLFKJAKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9C90", Offset = "0x4AA8290", VA = "0x184AA9C90")]
		private void LBKBKLEKILK(GameObject NJHLFKJAKJO, bool LKEANPIHPFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9DB0", Offset = "0x4AA83B0", VA = "0x184AA9DB0")]
		public static void LBKBKLEKILK(GameObject NJHLFKJAKJO, ref ToolHierarchyCache GMGDAEPIILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9760", Offset = "0x4AA7D60", VA = "0x184AA9760")]
		public void BKCPHHHFBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9710", Offset = "0x4AA7D10", VA = "0x184AA9710")]
		public void BCLOAINMMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1907080", Offset = "0x1905680", VA = "0x181907080")]
		public void DMMPPOOBPKC<T>(Action<T> JLOPFCBGFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9830", Offset = "0x4AA7E30", VA = "0x184AA9830")]
		public Component CNAJGINFJBK(Type IPLFCJCEGLD, bool AFEPKAMMHFG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x19BD700", Offset = "0x19BBD00", VA = "0x1819BD700")]
		public T CNAJGINFJBK<T>(bool AFEPKAMMHFG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9680", Offset = "0x4AA7C80", VA = "0x184AA9680")]
		public EHKMOKJIKNA<Component> AECJANEGPMJ(Type IPLFCJCEGLD, bool AFEPKAMMHFG = false)
		{
			return default(EHKMOKJIKNA<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x251DD80", Offset = "0x251C380", VA = "0x18251DD80")]
		public EHKMOKJIKNA<T> AECJANEGPMJ<T>(bool AFEPKAMMHFG = false) where T : class
		{
			return default(EHKMOKJIKNA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x4AA99E0", Offset = "0x4AA7FE0", VA = "0x184AA99E0")]
		public List<Component> IHNHEEHHFJP(Type IPLFCJCEGLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x4AA98F0", Offset = "0x4AA7EF0", VA = "0x184AA98F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache GHGHAFCMINB, ToolHierarchyCache PAFNDAGPPJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9970", Offset = "0x4AA7F70", VA = "0x184AA9970", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GPAMIINBFCH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class LFLGECMGKEO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FMHNJGMGKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int HKPOGLEHDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private List<T> FKFOEBFELAB;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A38980", Offset = "0x1A36F80", VA = "0x181A38980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T FPPHCJKMLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x274E860", Offset = "0x274CE60", VA = "0x18274E860")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T KDINBJLAOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x274E9D0", Offset = "0x274CFD0", VA = "0x18274E9D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T NLFLGEAKDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x274EA80", Offset = "0x274D080", VA = "0x18274EA80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x274ED40", Offset = "0x274D340", VA = "0x18274ED40")]
	public LFLGECMGKEO(int FMHNJGMGKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x274EB90", Offset = "0x274D190", VA = "0x18274EB90")]
	public void KNBMMGKPMNM(T GAOODHDIKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x274EB50", Offset = "0x274D150", VA = "0x18274EB50")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x274E7C0", Offset = "0x274CDC0", VA = "0x18274E7C0")]
	public void CMNHPFOFFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x274E980", Offset = "0x274CF80", VA = "0x18274E980")]
	public void EMBJKPNOENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x274EB40", Offset = "0x274D140", VA = "0x18274EB40")]
	public void GPNLCBOMFGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MKAILFCNGDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool NOJHBDCPPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Action JLOPFCBGFOB;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public static MKAILFCNGDP CFLPGBCJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x4AA7070", Offset = "0x4AA5670", VA = "0x184AA7070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool IAIOGGPIMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x54D250", Offset = "0x54B850", VA = "0x18054D250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xD1FED0", Offset = "0xD1E4D0", VA = "0x180D1FED0")]
	public MKAILFCNGDP(Action JLOPFCBGFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7050", Offset = "0x4AA5650", VA = "0x184AA7050")]
	public void BJNNNCFMPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4AA7050", Offset = "0x4AA5650", VA = "0x184AA7050", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class DBHGDGHIIBO
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80")]
	public static void IPBOALCIMMM(LDFJDHPOJHC BEJBALFILAD, string JHLKCADIDPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class PBDLPCBMLGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct CCICDPKMJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int AAIKKFEEOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T KBCFGEEMGKN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Dictionary<object, CCICDPKMJLM> OEFMFDLDCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T IGHPJNAAEAG;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public virtual T LKEDLFDAJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xF5CE60", Offset = "0xF5B460", VA = "0x180F5CE60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x26A0E70", Offset = "0x269F470", VA = "0x1826A0E70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool GOIHBCGDGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x34DB390", Offset = "0x34D9990", VA = "0x1834DB390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public object OLFFBEFCGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E0560", Offset = "0x5DEB60", VA = "0x1805E0560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x34D5F00", Offset = "0x34D4500", VA = "0x1834D5F00")]
	public bool GLPNNKBNMEG(T BABHCNCDDFB, object FCIGEDFPCAI, int BEFFNCBJGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x34D6680", Offset = "0x34D4C80", VA = "0x1834D6680")]
	public bool OHOGNNIPOKJ(object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x34D6220", Offset = "0x34D4820", VA = "0x1834D6220")]
	public bool JFOHOCKIKHA(object FCIGEDFPCAI, out T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x34D6010", Offset = "0x34D4610", VA = "0x1834D6010")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x34DACC0", Offset = "0x34D92C0", VA = "0x1834DACC0")]
	private bool OMIJFCANEON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x34DB3C0", Offset = "0x34D99C0", VA = "0x1834DB3C0")]
	public PBDLPCBMLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class GDBLMBOJGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Dictionary<object, float> OEFMFDLDCDF;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float HLFKLGPJDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xAD6080", Offset = "0xAD4680", VA = "0x180AD6080")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9CD0C0", Offset = "0x9CB6C0", VA = "0x1809CD0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4AA57D0", Offset = "0x4AA3DD0", VA = "0x184AA57D0")]
	public void GLPNNKBNMEG(float BABHCNCDDFB, object FCIGEDFPCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5840", Offset = "0x4AA3E40", VA = "0x184AA5840")]
	public void OHOGNNIPOKJ(object FCIGEDFPCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4AA56B0", Offset = "0x4AA3CB0", VA = "0x184AA56B0")]
	private void CPKNEDCCBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4AA58B0", Offset = "0x4AA3EB0", VA = "0x184AA58B0")]
	public GDBLMBOJGOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public sealed class LDFJDHPOJHC
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class HNFJFPFOBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly string NIGDGPKOENK;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		private HNFJFPFOBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x5DD330", Offset = "0x5DB930", VA = "0x1805DD330")]
		public HNFJFPFOBFC(string NIGDGPKOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4AA5930", Offset = "0x4AA3F30", VA = "0x184AA5930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class MMAADPOACHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public MMAADPOACHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x4AA70F0", Offset = "0x4AA56F0", VA = "0x184AA70F0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly HashSet<object> ACIGDCHFKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int KKEHIKECNNG;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool JGIIIJDMFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x4AA5D70", Offset = "0x4AA4370", VA = "0x184AA5D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x557080", Offset = "0x555680", VA = "0x180557080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5E40", Offset = "0x4AA4440", VA = "0x184AA5E40")]
	public bool KNBMMGKPMNM(object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5EC0", Offset = "0x4AA44C0", VA = "0x184AA5EC0")]
	public bool OKJFIGBMPNL(object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5D80", Offset = "0x4AA4380", VA = "0x184AA5D80")]
	public bool DEEPBBKBDCI(object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5DE0", Offset = "0x4AA43E0", VA = "0x184AA5DE0")]
	public void HOLOGEPMKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4AA5F40", Offset = "0x4AA4540", VA = "0x184AA5F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4AA60B0", Offset = "0x4AA46B0", VA = "0x184AA60B0")]
	public LDFJDHPOJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class GHODONGOIEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct BOEHNDMICLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public float CMNHINIFNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public T KBCFGEEMGKN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Dictionary<object, BOEHNDMICLL> OEFMFDLDCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private T BHOBCGJJFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public virtual T OGHJACKHDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xD69150", Offset = "0xD67750", VA = "0x180D69150", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x34D5740", Offset = "0x34D3D40", VA = "0x1834D5740", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public object PFFADHNPNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5E0570", Offset = "0x5DEB70", VA = "0x1805E0570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GOIHBCGDGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DB90", Offset = "0x3B0C190", VA = "0x183B0DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3B0BD40", Offset = "0x3B0A340", VA = "0x183B0BD40")]
	public bool GLPNNKBNMEG(T BABHCNCDDFB, object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C2D0", Offset = "0x3B0A8D0", VA = "0x183B0C2D0")]
	public bool OHOGNNIPOKJ(object FCIGEDFPCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x34D6010", Offset = "0x34D4610", VA = "0x1834D6010")]
	public void HPEBFGMNFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3B0C050", Offset = "0x3B0A650", VA = "0x183B0C050")]
	public bool JFOHOCKIKHA(object FCIGEDFPCAI, out T BABHCNCDDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D450", Offset = "0x3B0BA50", VA = "0x183B0D450")]
	private bool OMIJFCANEON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3B0DBD0", Offset = "0x3B0C1D0", VA = "0x183B0DBD0")]
	public GHODONGOIEA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class EEDIADJHOAL
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static byte[] GGHPKOFMNIO;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static int KCKCMMJGOCO;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static int BOFMOMDGGBC;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static BigInteger PJEPEPBBIPN;

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public EEDIADJHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4EE0", Offset = "0x4AA34E0", VA = "0x184AA4EE0")]
	private static string IAEECNCONGN(byte[] KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4BB0", Offset = "0x4AA31B0", VA = "0x184AA4BB0")]
	public static string AGDFJGHALKO(byte[] MOPADMGKCOG, bool CNBJECBCBOC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
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
