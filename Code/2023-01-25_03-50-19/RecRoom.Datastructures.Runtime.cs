using System;
using System.Buffers;
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
public class DMBAALHIOHD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	public DMBAALHIOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, CHMJLDKJAME, LHNLMNFPGGD, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69E140", Offset = "0x69D140", VA = "0x18069E140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A500", VA = "0x18077B500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NHBPPIHNEOH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDF0520", Offset = "0xDEF520", VA = "0x180DF0520")]
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
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[BLHJALMBACN]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[BLHJALMBACN]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1640", Offset = "0x5FC0640", VA = "0x185FC1640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1600", Offset = "0x5FC0600", VA = "0x185FC1600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1680", Offset = "0x5FC0680", VA = "0x185FC1680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1850", Offset = "0x5FC0850", VA = "0x185FC1850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC17C0", Offset = "0x5FC07C0", VA = "0x185FC17C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10998C0", Offset = "0x10988C0", VA = "0x1810998C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xE5DEE0", Offset = "0xE5CEE0", VA = "0x180E5DEE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FC15C0", Offset = "0x5FC05C0", VA = "0x185FC15C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1730", Offset = "0x5FC0730", VA = "0x185FC1730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1000", Offset = "0x5FC0000", VA = "0x185FC1000")]
	public void CopyBounds(SavedExtents KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1520", Offset = "0x5FC0520", VA = "0x185FC1520")]
	public void SetLocalSpaceBounds(Bounds HHJMILAPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x12770A0", Offset = "0x12760A0", VA = "0x1812770A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1450", Offset = "0x5FC0450", VA = "0x185FC1450")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1030", Offset = "0x5FC0030", VA = "0x185FC1030")]
	private void IAILHOPONLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1220", Offset = "0x5FC0220", VA = "0x185FC1220")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC09C0", Offset = "0x5FBF9C0", VA = "0x185FC09C0")]
	public static void CalculateLocalBoundsFor(GameObject NCAOMIEGHPA, out Bounds HHJMILAPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1460", Offset = "0x5FC0460", VA = "0x185FC1460")]
	private static void PNLLCIAHCCI(Bounds OPGAGDBKIDA, Color NKNPGFCGIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1540", Offset = "0x5FC0540", VA = "0x185FC1540")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69EF30", Offset = "0x69DF30", VA = "0x18069EF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13671A0", Offset = "0x13661A0", VA = "0x1813671A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9B0", Offset = "0xA3E9B0", VA = "0x180A3F9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public virtual void JCAFFPCMODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[DMBAALHIOHD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33F82B0", Offset = "0x33F72B0", VA = "0x1833F82B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x33F79E0", Offset = "0x33F69E0", VA = "0x1833F79E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x33F87F0", Offset = "0x33F77F0", VA = "0x1833F87F0")]
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
	private sealed class MPMKBGGGKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public MPMKBGGGKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2C98770", Offset = "0x2C97770", VA = "0x182C98770")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[DMBAALHIOHD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2022720", Offset = "0x2021720", VA = "0x182022720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2022750", Offset = "0x2021750", VA = "0x182022750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2022670", Offset = "0x2021670", VA = "0x182022670", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey PIIJMEAKDGO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x20226A0", Offset = "0x20216A0", VA = "0x1820226A0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2022570", Offset = "0x2021570", VA = "0x182022570", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2021EF0", Offset = "0x2020EF0", VA = "0x182021EF0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20215C0", Offset = "0x20205C0", VA = "0x1820215C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2021590", Offset = "0x2020590", VA = "0x182021590", Slot = "14")]
	protected virtual string MPHIIEKJONH(TKeyVal NKCAJAFJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2021470", Offset = "0x2020470", VA = "0x182021470", Slot = "4")]
	public bool ContainsKey(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2022460", Offset = "0x2021460", VA = "0x182022460", Slot = "5")]
	public bool TryGetValue(TKey PIIJMEAKDGO, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x20214A0", Offset = "0x20204A0", VA = "0x1820214A0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x20214A0", Offset = "0x20204A0", VA = "0x1820214A0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2022490", Offset = "0x2021490", VA = "0x182022490")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EFKFICJGEOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CJNLKLGPGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public CJNLKLGPGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36D0150", Offset = "0x36CF150", VA = "0x1836D0150")]
		internal bool <GetSamples>b__0(global::NLMEDIENKFM<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float EFADKHCCHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float ADEHDDLBKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::NLMEDIENKFM<float, T>> PIIPEJEMDFN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MCOJHMBLAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2738B30", Offset = "0x2737B30", VA = "0x182738B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2738C10", Offset = "0x2737C10", VA = "0x182738C10")]
	public EFKFICJGEOF(float DPKAEMPKPOH, float IOOLHIOLIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2738170", Offset = "0x2737170", VA = "0x182738170")]
	public bool HJNIDIJICNI(float MHEAKFKNGKB, T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2738BB0", Offset = "0x2737BB0", VA = "0x182738BB0")]
	public int ODEFPOKCDOI(float MHEAKFKNGKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2738770", Offset = "0x2737770", VA = "0x182738770")]
	public IEnumerable<T> JLEFFALLGLD(float MHEAKFKNGKB, [Optional] float? AEKOJPHPAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2738140", Offset = "0x2737140", VA = "0x182738140")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2738080", Offset = "0x2737080", VA = "0x182738080")]
	private void DNNIKJBNKBC(float MHEAKFKNGKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class HIDBOGGDGNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IPNPNNPELPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PGLDLDAMIHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float KOMPMKGLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> HHHHHHEKKAM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LONEOCLEALI = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private IPNPNNPELPE[] DBOPJMNFJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int LIJPLOMBEEP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float PKFPKAOLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1297C90", Offset = "0x1296C90", VA = "0x181297C90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x12A2780", Offset = "0x12A1780", VA = "0x1812A2780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E43950", Offset = "0x2E42950", VA = "0x182E43950")]
	public HIDBOGGDGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E43980", Offset = "0x2E42980", VA = "0x182E43980")]
	public HIDBOGGDGNI(int BDHBBDMMOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E42D50", Offset = "0x2E41D50", VA = "0x182E42D50")]
	public void HMNAIPBHJIK(float MHEAKFKNGKB, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2E425F0", Offset = "0x2E415F0", VA = "0x182E425F0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E42FD0", Offset = "0x2E41FD0", VA = "0x182E42FD0")]
	public bool LGKHJDICLPK(float EGGDGKGFLFK, float FBBPEGICDHA, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E428D0", Offset = "0x2E418D0", VA = "0x182E428D0")]
	public bool HMKLDOPOHNI(float EGGDGKGFLFK, float FBBPEGICDHA, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E436D0", Offset = "0x2E426D0", VA = "0x182E436D0")]
	public void OCAOIBKAMFK(float EGGDGKGFLFK, float FBBPEGICDHA, List<T> FAHBHODOFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E43560", Offset = "0x2E42560", VA = "0x182E43560")]
	private int MFNPBIMMHLO(int LFKADCPMMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E42890", Offset = "0x2E41890", VA = "0x182E42890")]
	private void HKAJLOIABIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CBEKBEBHJDE();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BAHKCJKEFPC(T JCHPGJLCOCJ, T GHMOJHOMMOK, float PHLICBNKKOO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BAMNADPGMPG(T DFEOJBAFBHE, float PHLICBNKKOO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HNFINOKIPHI(T JCHPGJLCOCJ, T GHMOJHOMMOK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T PMIIPLLOJKM(T JCHPGJLCOCJ, T GHMOJHOMMOK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IFBCFJCMCGL : global::HIDBOGGDGNI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x16863B0", Offset = "0x16853B0", VA = "0x1816863B0", Slot = "4")]
	protected override Vector3 CBEKBEBHJDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x216E280", Offset = "0x216D280", VA = "0x18216E280", Slot = "5")]
	protected override Vector3 BAHKCJKEFPC(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDE00", Offset = "0x5FBCE00", VA = "0x185FBDE00", Slot = "6")]
	protected override Vector3 BAMNADPGMPG(Vector3 DFEOJBAFBHE, float PHLICBNKKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDE60", Offset = "0x5FBCE60", VA = "0x185FBDE60", Slot = "7")]
	protected override Vector3 HNFINOKIPHI(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDEE0", Offset = "0x5FBCEE0", VA = "0x185FBDEE0", Slot = "8")]
	protected override Vector3 PMIIPLLOJKM(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDF50", Offset = "0x5FBCF50", VA = "0x185FBDF50")]
	public IFBCFJCMCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PLJLNKIJJFE : global::HIDBOGGDGNI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0230", Offset = "0x5FBF230", VA = "0x185FC0230")]
	public PLJLNKIJJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC02A0", Offset = "0x5FBF2A0", VA = "0x185FC02A0")]
	public PLJLNKIJJFE(int BDHBBDMMOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xF46410", Offset = "0xF45410", VA = "0x180F46410", Slot = "4")]
	protected override float CBEKBEBHJDE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36C9C40", Offset = "0x36C8C40", VA = "0x1836C9C40", Slot = "5")]
	protected override float BAHKCJKEFPC(float JCHPGJLCOCJ, float GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50A6DE0", Offset = "0x50A5DE0", VA = "0x1850A6DE0", Slot = "6")]
	protected override float BAMNADPGMPG(float DFEOJBAFBHE, float PHLICBNKKOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x33E1C90", Offset = "0x33E0C90", VA = "0x1833E1C90", Slot = "7")]
	protected override float HNFINOKIPHI(float JCHPGJLCOCJ, float GHMOJHOMMOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0220", Offset = "0x5FBF220", VA = "0x185FC0220", Slot = "8")]
	protected override float PMIIPLLOJKM(float JCHPGJLCOCJ, float GHMOJHOMMOK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CABAJJBOAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x22E1940", Offset = "0x22E0940", VA = "0x1822E1940")]
	public static global::IEHEHDHPHDE<T1> HJNGNBALKKN<T1>(T1 DDMFFEHANLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22E14D0", Offset = "0x22E04D0", VA = "0x1822E14D0")]
	public static global::NLMEDIENKFM<T1, T2> HJNGNBALKKN<T1, T2>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22E1540", Offset = "0x22E0540", VA = "0x1822E1540")]
	public static global::DCACKDLBAMA<T1, T2, T3> HJNGNBALKKN<T1, T2, T3>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22D8EC0", Offset = "0x22D7EC0", VA = "0x1822D8EC0")]
	public static global::PPGNBEBKLEL<T1, T2, T3, T4> HJNGNBALKKN<T1, T2, T3, T4>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x22E1810", Offset = "0x22E0810", VA = "0x1822E1810")]
	public static global::KLLPCOABIAI<T1, T2, T3, T4, T5> HJNGNBALKKN<T1, T2, T3, T4, T5>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22E1760", Offset = "0x22E0760", VA = "0x1822E1760")]
	public static global::IABIDEGAGEN<T1, T2, T3, T4, T5, T6> HJNGNBALKKN<T1, T2, T3, T4, T5, T6>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x22E16A0", Offset = "0x22E06A0", VA = "0x1822E16A0")]
	public static global::CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7> HJNGNBALKKN<T1, T2, T3, T4, T5, T6, T7>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22E15D0", Offset = "0x22E05D0", VA = "0x1822E15D0")]
	public static global::CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8> HJNGNBALKKN<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII, T8 NKOMDLHLIAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1AFC460", Offset = "0x1AFB460", VA = "0x181AFC460")]
	[IteratorStateMachine(typeof(MDENJAPPCBN))]
	public static IEnumerable<global::NLMEDIENKFM<T1, T2>> DNOPNIGFBKD<T1, T2>(IEnumerable<T1> NCNGLFNLPAG, IEnumerable<T2> OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1AFC640", Offset = "0x1AFB640", VA = "0x181AFC640")]
	[IteratorStateMachine(typeof(DFHDFCFBJJN))]
	public static IEnumerable<global::DCACKDLBAMA<T1, T2, T3>> DNOPNIGFBKD<T1, T2, T3>(IEnumerable<T1> NCNGLFNLPAG, IEnumerable<T2> OPGAGDBKIDA, IEnumerable<T3> NKNPGFCGIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x816B80", Offset = "0x815B80", VA = "0x180816B80")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x816B70", Offset = "0x815B70", VA = "0x180816B70")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x816B50", Offset = "0x815B50", VA = "0x180816B50")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA3F0", Offset = "0x5FB93F0", VA = "0x185FBA3F0")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA3A0", Offset = "0x5FB93A0", VA = "0x185FBA3A0")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB, int DLEGGOOPNOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA3C0", Offset = "0x5FB93C0", VA = "0x185FBA3C0")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB, int DLEGGOOPNOC, int LCFLCBBJNOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA410", Offset = "0x5FB9410", VA = "0x185FBA410")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB, int DLEGGOOPNOC, int LCFLCBBJNOF, int EFEOGAOCKHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IEHEHDHPHDE<T1> : IComparable<global::IEHEHDHPHDE<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1E22D40", Offset = "0x1E21D40", VA = "0x181E22D40")]
	public IEHEHDHPHDE(T1 DDMFFEHANLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2251150", Offset = "0x2250150", VA = "0x182251150", Slot = "4")]
	public int CompareTo(global::IEHEHDHPHDE<T1> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x22511C0", Offset = "0x22501C0", VA = "0x1822511C0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8C70E0", Offset = "0x8C60E0", VA = "0x1808C70E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2251260", Offset = "0x2250260", VA = "0x182251260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NLMEDIENKFM<T1, T2> : IComparable<global::NLMEDIENKFM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27A85F0", Offset = "0x27A75F0", VA = "0x1827A85F0")]
	public NLMEDIENKFM(T1 DDMFFEHANLL, T2 ONIKLPKIPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x32A49A0", Offset = "0x32A39A0", VA = "0x1832A49A0", Slot = "4")]
	public int CompareTo(global::NLMEDIENKFM<T1, T2> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x32A4E50", Offset = "0x32A3E50", VA = "0x1832A4E50", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x32A55C0", Offset = "0x32A45C0", VA = "0x1832A55C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32A5D10", Offset = "0x32A4D10", VA = "0x1832A5D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DCACKDLBAMA<T1, T2, T3> : IComparable<global::DCACKDLBAMA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2888820", Offset = "0x2887820", VA = "0x182888820")]
	public DCACKDLBAMA(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2888010", Offset = "0x2887010", VA = "0x182888010", Slot = "4")]
	public int CompareTo(global::DCACKDLBAMA<T1, T2, T3> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2888300", Offset = "0x2887300", VA = "0x182888300", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2888500", Offset = "0x2887500", VA = "0x182888500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2888670", Offset = "0x2887670", VA = "0x182888670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PPGNBEBKLEL<T1, T2, T3, T4> : IComparable<global::PPGNBEBKLEL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x26013C0", Offset = "0x26003C0", VA = "0x1826013C0")]
	public PPGNBEBKLEL(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D310", Offset = "0x2D9C310", VA = "0x182D9D310", Slot = "4")]
	public int CompareTo(global::PPGNBEBKLEL<T1, T2, T3, T4> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D450", Offset = "0x2D9C450", VA = "0x182D9D450", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D570", Offset = "0x2D9C570", VA = "0x182D9D570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D630", Offset = "0x2D9C630", VA = "0x182D9D630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KLLPCOABIAI<T1, T2, T3, T4, T5> : IComparable<global::KLLPCOABIAI<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x29509E0", Offset = "0x294F9E0", VA = "0x1829509E0")]
	public KLLPCOABIAI(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D57020", Offset = "0x2D56020", VA = "0x182D57020", Slot = "4")]
	public int CompareTo(global::KLLPCOABIAI<T1, T2, T3, T4, T5> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D571A0", Offset = "0x2D561A0", VA = "0x182D571A0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D572E0", Offset = "0x2D562E0", VA = "0x182D572E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D573E0", Offset = "0x2D563E0", VA = "0x182D573E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IABIDEGAGEN<T1, T2, T3, T4, T5, T6> : IComparable<global::IABIDEGAGEN<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 PKCNGMDFJIK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x451EB30", Offset = "0x451DB30", VA = "0x18451EB30")]
	public IABIDEGAGEN(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x451E570", Offset = "0x451D570", VA = "0x18451E570", Slot = "4")]
	public int CompareTo(global::IABIDEGAGEN<T1, T2, T3, T4, T5, T6> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x451E730", Offset = "0x451D730", VA = "0x18451E730", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x451E8A0", Offset = "0x451D8A0", VA = "0x18451E8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x451E9C0", Offset = "0x451D9C0", VA = "0x18451E9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 PKCNGMDFJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 EFLAFNBNECG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36D43E0", Offset = "0x36D33E0", VA = "0x1836D43E0")]
	public CKNJKBOHINF(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x36D3D60", Offset = "0x36D2D60", VA = "0x1836D3D60", Slot = "4")]
	public int CompareTo(global::CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x36D3F60", Offset = "0x36D2F60", VA = "0x1836D3F60", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x36D4100", Offset = "0x36D3100", VA = "0x1836D4100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x36D4250", Offset = "0x36D3250", VA = "0x1836D4250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 PKCNGMDFJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 EFLAFNBNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 OLBCBJPGBDH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x36D0C80", Offset = "0x36CFC80", VA = "0x1836D0C80")]
	public CKEELILFMGC(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII, T8 NKOMDLHLIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x36D0550", Offset = "0x36CF550", VA = "0x1836D0550", Slot = "4")]
	public int CompareTo(global::CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x36D07A0", Offset = "0x36CF7A0", VA = "0x1836D07A0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36D0960", Offset = "0x36CF960", VA = "0x1836D0960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x36D0AD0", Offset = "0x36CFAD0", VA = "0x1836D0AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x17A0980", Offset = "0x179F980", VA = "0x1817A0980")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4172F90", Offset = "0x4171F90", VA = "0x184172F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FOHMBKIIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xEA9750", Offset = "0xEA8750", VA = "0x180EA9750")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4172A80", Offset = "0x4171A80", VA = "0x184172A80")]
	public T HADNJNMEOPN(float PHLICBNKKOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4172E90", Offset = "0x4171E90", VA = "0x184172E90")]
	public T MJGNELPKOKA(float PHLICBNKKOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BAHKCJKEFPC(T JCHPGJLCOCJ, T GHMOJHOMMOK, float PHLICBNKKOO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36C9C40", Offset = "0x36C8C40", VA = "0x1836C9C40", Slot = "4")]
	protected override float BAHKCJKEFPC(float JCHPGJLCOCJ, float GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD40", Offset = "0x5FBAD40", VA = "0x185FBBD40")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x216E280", Offset = "0x216D280", VA = "0x18216E280", Slot = "4")]
	protected override Vector3 BAHKCJKEFPC(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FC27E0", Offset = "0x5FC17E0", VA = "0x185FC27E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB030", Offset = "0x5FBA030", VA = "0x185FBB030", Slot = "4")]
	protected override Color BAHKCJKEFPC(Color JCHPGJLCOCJ, Color GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB080", Offset = "0x5FBA080", VA = "0x185FBB080")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LNILIBCCIFN : global::GGMOAHGJIJD<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEF00", Offset = "0x5FBDF00", VA = "0x185FBEF00")]
	public LNILIBCCIFN(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEF50", Offset = "0x5FBDF50", VA = "0x185FBEF50")]
	public LNILIBCCIFN(BOGCLLBCKAJ[] EABPBDHKJJC, bool MNMIDHFIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEE90", Offset = "0x5FBDE90", VA = "0x185FBEE90", Slot = "6")]
	protected override uint KOOFGGDDHII(uint NHBPPIHNEOH, string DFEOJBAFBHE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PIDKKMFILAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public PIDKKMFILAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DGLBLOBNPFI
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MMKLPBPOJLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<PEFLLNEDEOA> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MMKLPBPOJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF490", Offset = "0x5FBE490", VA = "0x185FBF490")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<PEFLLNEDEOA>> CJJMAMOONDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int HNNLIBPGPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ONMJFJIJHIG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xBB4410", Offset = "0xBB3410", VA = "0x180BB4410")]
	private DGLBLOBNPFI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<PEFLLNEDEOA>> IJPHJIFNABL, int PCDIDEACGEB, int GHJCGFEINCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB0C0", Offset = "0x5FBA0C0", VA = "0x185FBB0C0")]
	public static DGLBLOBNPFI DHGKFEMNGCO()
	{
		return default(DGLBLOBNPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB140", Offset = "0x5FBA140", VA = "0x185FBB140")]
	public (int, int, Task) JELLNOMLDPM(int NMIOFDCBLLN, [Optional] CancellationToken NIEOBBGKEFJ)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB530", Offset = "0x5FBA530", VA = "0x185FBB530")]
	public void KJMDGGIMPLK(int NMIOFDCBLLN, int GHJCGFEINCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class JKKPJACIJEH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> BHKHMIPNLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> EPNBFJMNFDL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E22CE0", Offset = "0x1E21CE0", VA = "0x181E22CE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GLAEFLDOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x265C470", Offset = "0x265B470", VA = "0x18265C470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HEJJODDBBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28E6410", Offset = "0x28E5410", VA = "0x1828E6410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3653150", Offset = "0x3652150", VA = "0x183653150", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3653190", Offset = "0x3652190", VA = "0x183653190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3652040", Offset = "0x3651040", VA = "0x183652040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3652E30", Offset = "0x3651E30", VA = "0x183652E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3651EC0", Offset = "0x3650EC0", VA = "0x183651EC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3652F80", Offset = "0x3651F80", VA = "0x183652F80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3651E10", Offset = "0x3650E10", VA = "0x183651E10", Slot = "9")]
	public void Add(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3651E50", Offset = "0x3650E50", VA = "0x183651E50", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3651F20", Offset = "0x3650F20", VA = "0x183651F20", Slot = "8")]
	public bool ContainsKey(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3651F50", Offset = "0x3650F50", VA = "0x183651F50", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3652EF0", Offset = "0x3651EF0", VA = "0x183652EF0", Slot = "10")]
	public bool Remove(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3652F50", Offset = "0x3651F50", VA = "0x183652F50", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2412D10", Offset = "0x2411D10", VA = "0x182412D10", Slot = "11")]
	public bool TryGetValue(TKey PIIJMEAKDGO, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3652800", Offset = "0x3651800", VA = "0x183652800", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3651FE0", Offset = "0x3650FE0", VA = "0x183651FE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x36529D0", Offset = "0x36519D0", VA = "0x1836529D0")]
	public void HMNAIPBHJIK(TVal EKFKNNJJKLD, TKey PIIJMEAKDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3652990", Offset = "0x3651990", VA = "0x183652990")]
	public void HMNAIPBHJIK(KeyValuePair<TVal, TKey> LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3652B30", Offset = "0x3651B30", VA = "0x183652B30")]
	public bool KJCNBHBPKIJ(TVal PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x36528F0", Offset = "0x36518F0", VA = "0x1836528F0")]
	public bool HGEFFBLNLHD(KeyValuePair<TVal, TKey> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3652260", Offset = "0x3651260", VA = "0x183652260")]
	public bool FAHLDBEBGON(TVal PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3652260", Offset = "0x3651260", VA = "0x183652260")]
	public bool FAHLDBEBGON(KeyValuePair<TVal, TKey> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x36528B0", Offset = "0x36518B0", VA = "0x1836528B0")]
	public bool HADOILGNPLN(TVal PIIJMEAKDGO, out TKey DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3652DA0", Offset = "0x3651DA0", VA = "0x183652DA0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> OFFOLACLLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3652C00", Offset = "0x3651C00", VA = "0x183652C00")]
	private void KOCNLHLDBCG(TKey PIIJMEAKDGO, TVal EKFKNNJJKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36520B0", Offset = "0x36510B0", VA = "0x1836520B0")]
	private void DNPHGPLALFI(TKey PIIJMEAKDGO, TVal EKFKNNJJKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x36525F0", Offset = "0x36515F0", VA = "0x1836525F0")]
	private bool FKCAFOAMPCI(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3652450", Offset = "0x3651450", VA = "0x183652450")]
	private bool FKCAFOAMPCI(TVal EKFKNNJJKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3653070", Offset = "0x3652070", VA = "0x183653070")]
	public JKKPJACIJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class DDIGBBBLJIA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::DDIGBBBLJIA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2EE75A0", Offset = "0x2EE65A0", VA = "0x182EE75A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E1A780", Offset = "0x2E19780", VA = "0x182E1A780")]
		public Enumerator(global::DDIGBBBLJIA<T> FAHBHODOFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2EE36A0", Offset = "0x2EE26A0", VA = "0x182EE36A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2EE5B70", Offset = "0x2EE4B70", VA = "0x182EE5B70", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2EE2D90", Offset = "0x2EE1D90", VA = "0x182EE2D90")]
		private void KIFGABCEKOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] IMNHEMNOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int JHOHOEJNFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int LMEADNAFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int IIJDDKBOPLN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x288D0E0", Offset = "0x288C0E0", VA = "0x18288D0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x288D1B0", Offset = "0x288C1B0", VA = "0x18288D1B0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x288E100", Offset = "0x288D100", VA = "0x18288E100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x288E3F0", Offset = "0x288D3F0", VA = "0x18288E3F0")]
	public DDIGBBBLJIA(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x288D610", Offset = "0x288C610", VA = "0x18288D610")]
	public void HMNAIPBHJIK(T PHLICBNKKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x288C4B0", Offset = "0x288B4B0", VA = "0x18288C4B0")]
	public void BMDGMDNJPHD(IEnumerable<T> CFMHDCICDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x288D330", Offset = "0x288C330", VA = "0x18288D330")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x288D120", Offset = "0x288C120", VA = "0x18288D120")]
	public void CLGFLCCLAOK(int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x288D350", Offset = "0x288C350", VA = "0x18288D350")]
	public void FJFOOFILPIN(int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x288D780", Offset = "0x288C780", VA = "0x18288D780")]
	public void KEBDNMKLCMO(T[] DBOPJMNFJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x288D6D0", Offset = "0x288C6D0", VA = "0x18288D6D0")]
	public Enumerator HPPJKDPBNFG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x288E370", Offset = "0x288D370", VA = "0x18288E370", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x288E370", Offset = "0x288D370", VA = "0x18288E370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x288DEA0", Offset = "0x288CEA0", VA = "0x18288DEA0")]
	private int MBKHPDEENCC(int NPDGHPHAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x288D0B0", Offset = "0x288C0B0", VA = "0x18288D0B0")]
	private int BOJCBJHOKNG(int NPDGHPHAKDK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class JMHGACFPMMA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> KDMLDPACOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> CKCLLMBDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x738170", Offset = "0x737170", VA = "0x180738170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3656180", Offset = "0x3655180", VA = "0x183656180", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3656220", Offset = "0x3655220", VA = "0x183656220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3656120", Offset = "0x3655120", VA = "0x183656120", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2859500", Offset = "0x2858500", VA = "0x182859500")]
	public JMHGACFPMMA(Func<Internal, External> JLJLCNPKNHA, Func<External, Internal> KDMLDPACOFJ, bool FJBBIADFENA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3655E40", Offset = "0x3654E40", VA = "0x183655E40", Slot = "6")]
	public int IndexOf(External LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3655AC0", Offset = "0x3654AC0", VA = "0x183655AC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3655B20", Offset = "0x3654B20", VA = "0x183655B20", Slot = "13")]
	public bool Contains(External LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3655BB0", Offset = "0x3654BB0", VA = "0x183655BB0", Slot = "14")]
	public void CopyTo(External[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x36559D0", Offset = "0x36549D0", VA = "0x1836559D0", Slot = "11")]
	public void Add(External LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3655F30", Offset = "0x3654F30", VA = "0x183655F30", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, External LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3656090", Offset = "0x3655090", VA = "0x183656090", Slot = "15")]
	public bool Remove(External LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3655FD0", Offset = "0x3654FD0", VA = "0x183655FD0", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3655DD0", Offset = "0x3654DD0", VA = "0x183655DD0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x24174E0", Offset = "0x24164E0", VA = "0x1824174E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class BGCFPJOOFMG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> CKCLLMBDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69E140", Offset = "0x69D140", VA = "0x18069E140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2815220", Offset = "0x2814220", VA = "0x182815220", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28151C0", Offset = "0x28141C0", VA = "0x1828151C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1E22D40", Offset = "0x1E21D40", VA = "0x181E22D40")]
	public BGCFPJOOFMG(Func<Internal, External> JLJLCNPKNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2815170", Offset = "0x2814170", VA = "0x182815170")]
	public BGCFPJOOFMG(IReadOnlyList<Internal> DEEJEKFIHBB, Func<Internal, External> JLJLCNPKNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2814F50", Offset = "0x2813F50", VA = "0x182814F50")]
	public void KEBDNMKLCMO(External[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2814EE0", Offset = "0x2813EE0", VA = "0x182814EE0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E34C90", Offset = "0x1E33C90", VA = "0x181E34C90", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class OBOMKLFOIIM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> CKCLLMBDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x69F020", Offset = "0x69E020", VA = "0x18069F020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x26FEAA0", Offset = "0x26FDAA0", VA = "0x1826FEAA0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x26FEA40", Offset = "0x26FDA40", VA = "0x1826FEA40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1E22D40", Offset = "0x1E21D40", VA = "0x181E22D40")]
	public OBOMKLFOIIM(IReadOnlyList<Internal> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x26FE770", Offset = "0x26FD770", VA = "0x1826FE770")]
	public bool HGEFFBLNLHD(External LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x26FE810", Offset = "0x26FD810", VA = "0x1826FE810")]
	public void KEBDNMKLCMO(External[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x26FE700", Offset = "0x26FD700", VA = "0x1826FE700", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x24174E0", Offset = "0x24164E0", VA = "0x1824174E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LMCLBHOIDLK
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BDMGLGDIAIK(object[] IJPNBHGIPKF);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected LMCLBHOIDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class NKCMIKBJJDI<T> : LMCLBHOIDLK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct CJLOHOMPBBP
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum MOJHLFDJEJL
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public MOJHLFDJEJL IGEIBCJNCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T KNOLDLABLMF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int PKNDEDHNFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool DCELNLFEJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool BELFIEMNONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> MGFLHOAJMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<CJLOHOMPBBP> LBDAFFHFIMN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DACELNFABBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x32A3600", Offset = "0x32A2600", VA = "0x1832A3600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x32A3CE0", Offset = "0x32A2CE0", VA = "0x1832A3CE0")]
	protected NKCMIKBJJDI(bool BELFIEMNONK, bool DCELNLFEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x32A3950", Offset = "0x32A2950", VA = "0x1832A3950")]
	protected bool FBCGHFFPLDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x32A3640", Offset = "0x32A2640", VA = "0x1832A3640")]
	protected void ELEMAPGCLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x32A3B30", Offset = "0x32A2B30", VA = "0x1832A3B30")]
	protected void NPGBKNFOMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26CEE10", Offset = "0x26CDE10", VA = "0x1826CEE10")]
	private static void ELKHKHMMNNJ<U>(ref List<U> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x32A39D0", Offset = "0x32A29D0", VA = "0x1832A39D0", Slot = "5")]
	public void HMNAIPBHJIK(T KNOLDLABLMF, bool IDPMOFNNEIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x32A3810", Offset = "0x32A2810", VA = "0x1832A3810", Slot = "6")]
	public void FAHLDBEBGON(T KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x32A3700", Offset = "0x32A2700", VA = "0x1832A3700")]
	public void EMOCNNJJBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ACNMGHLEGGF
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FMJNLFCNDHK : global::NKCMIKBJJDI<Action>, ACNMGHLEGGF
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBCE0", Offset = "0x5FBACE0", VA = "0x185FBBCE0")]
	public FMJNLFCNDHK(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBAD0", Offset = "0x5FBAAD0", VA = "0x185FBBAD0")]
	public void PEAOLDLIGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB9A0", Offset = "0x5FBA9A0", VA = "0x185FBB9A0", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBA10", Offset = "0x5FBAA10", VA = "0x185FBBA10")]
	public static FMJNLFCNDHK LGHBHOPGAGF(FMJNLFCNDHK GGMFKINHGHM, Action KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBA70", Offset = "0x5FBAA70", VA = "0x185FBBA70")]
	public static FMJNLFCNDHK OOOBHHMAEMO(FMJNLFCNDHK GGMFKINHGHM, Action KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EIIAIBCICAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PBGGDBDIKGA<T> : global::NKCMIKBJJDI<Action<T>>, global::EIIAIBCICAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x207ACB0", Offset = "0x2079CB0", VA = "0x18207ACB0")]
	public PBGGDBDIKGA(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3463730", Offset = "0x3462730", VA = "0x183463730")]
	public void PEAOLDLIGBA(T PHLICBNKKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x34628B0", Offset = "0x34618B0", VA = "0x1834628B0", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3462A30", Offset = "0x3461A30", VA = "0x183462A30")]
	public static global::PBGGDBDIKGA<T> LGHBHOPGAGF(global::PBGGDBDIKGA<T> GGMFKINHGHM, Action<T> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3462AD0", Offset = "0x3461AD0", VA = "0x183462AD0")]
	public static global::PBGGDBDIKGA<T> OOOBHHMAEMO(global::PBGGDBDIKGA<T> GGMFKINHGHM, Action<T> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface MEFLFOKHJOE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class BKNNAJHBPLG<T, U> : global::NKCMIKBJJDI<Action<T, U>>, global::MEFLFOKHJOE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x207ACB0", Offset = "0x2079CB0", VA = "0x18207ACB0")]
	public BKNNAJHBPLG(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x41D4510", Offset = "0x41D3510", VA = "0x1841D4510")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x41D1E20", Offset = "0x41D0E20", VA = "0x1841D1E20", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x41D30F0", Offset = "0x41D20F0", VA = "0x1841D30F0")]
	public static global::BKNNAJHBPLG<T, U> LGHBHOPGAGF(global::BKNNAJHBPLG<T, U> GGMFKINHGHM, Action<T, U> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x41D3190", Offset = "0x41D2190", VA = "0x1841D3190")]
	public static global::BKNNAJHBPLG<T, U> OOOBHHMAEMO(global::BKNNAJHBPLG<T, U> GGMFKINHGHM, Action<T, U> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LPEFDHOOHFG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class OEHJHDHJDOL<T, U, V> : global::NKCMIKBJJDI<Action<T, U, V>>, global::LPEFDHOOHFG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x207ACB0", Offset = "0x2079CB0", VA = "0x18207ACB0")]
	public OEHJHDHJDOL(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x27056B0", Offset = "0x27046B0", VA = "0x1827056B0")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2703910", Offset = "0x2702910", VA = "0x182703910", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2704600", Offset = "0x2703600", VA = "0x182704600")]
	public static global::OEHJHDHJDOL<T, U, V> LGHBHOPGAGF(global::OEHJHDHJDOL<T, U, V> GGMFKINHGHM, Action<T, U, V> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x27046A0", Offset = "0x27036A0", VA = "0x1827046A0")]
	public static global::OEHJHDHJDOL<T, U, V> OOOBHHMAEMO(global::OEHJHDHJDOL<T, U, V> GGMFKINHGHM, Action<T, U, V> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ECMMBIPNMBB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V, W> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V, W> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class PFNIKCICJFJ<T, U, V, W> : global::NKCMIKBJJDI<Action<T, U, V, W>>, global::ECMMBIPNMBB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x207ACB0", Offset = "0x2079CB0", VA = "0x18207ACB0")]
	public PFNIKCICJFJ(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3471400", Offset = "0x3470400", VA = "0x183471400")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ, W AOJLCLDDLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3470D80", Offset = "0x346FD80", VA = "0x183470D80", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x34712C0", Offset = "0x34702C0", VA = "0x1834712C0")]
	public static global::PFNIKCICJFJ<T, U, V, W> LGHBHOPGAGF(global::PFNIKCICJFJ<T, U, V, W> GGMFKINHGHM, Action<T, U, V, W> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3471360", Offset = "0x3470360", VA = "0x183471360")]
	public static global::PFNIKCICJFJ<T, U, V, W> OOOBHHMAEMO(global::PFNIKCICJFJ<T, U, V, W> GGMFKINHGHM, Action<T, U, V, W> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KMCGBBGECED<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V, W, X> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V, W, X> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HPLHGOIIPJP<T, U, V, W, X> : global::NKCMIKBJJDI<Action<T, U, V, W, X>>, global::KMCGBBGECED<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x207ACB0", Offset = "0x2079CB0", VA = "0x18207ACB0")]
	public HPLHGOIIPJP(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2E489F0", Offset = "0x2E479F0", VA = "0x182E489F0")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ, W AOJLCLDDLKO, X JMDPDGBMGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2E482A0", Offset = "0x2E472A0", VA = "0x182E482A0", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2E488B0", Offset = "0x2E478B0", VA = "0x182E488B0")]
	public static global::HPLHGOIIPJP<T, U, V, W, X> LGHBHOPGAGF(global::HPLHGOIIPJP<T, U, V, W, X> GGMFKINHGHM, Action<T, U, V, W, X> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2E48950", Offset = "0x2E47950", VA = "0x182E48950")]
	public static global::HPLHGOIIPJP<T, U, V, W, X> OOOBHHMAEMO(global::HPLHGOIIPJP<T, U, V, W, X> GGMFKINHGHM, Action<T, U, V, W, X> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KKEKCDMKHJG<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V, W, X, Y> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V, W, X, Y> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class NOJPDCDMHAB<T, U, V, W, X, Y> : global::NKCMIKBJJDI<Action<T, U, V, W, X, Y>>, global::KKEKCDMKHJG<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x207ACB0", Offset = "0x2079CB0", VA = "0x18207ACB0")]
	public NOJPDCDMHAB(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4624D10", Offset = "0x4623D10", VA = "0x184624D10")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ, W AOJLCLDDLKO, X JMDPDGBMGAA, Y GKDCJKNJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x46241D0", Offset = "0x46231D0", VA = "0x1846241D0", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4624BD0", Offset = "0x4623BD0", VA = "0x184624BD0")]
	public static global::NOJPDCDMHAB<T, U, V, W, X, Y> LGHBHOPGAGF(global::NOJPDCDMHAB<T, U, V, W, X, Y> GGMFKINHGHM, Action<T, U, V, W, X, Y> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4624C70", Offset = "0x4623C70", VA = "0x184624C70")]
	public static global::NOJPDCDMHAB<T, U, V, W, X, Y> OOOBHHMAEMO(global::NOJPDCDMHAB<T, U, V, W, X, Y> GGMFKINHGHM, Action<T, U, V, W, X, Y> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JEJKEABBLJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GLEMGOGMIOB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::JEJKEABBLJL<T> NOPPIGEMPOA;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T FBCEGMCNEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2857070", Offset = "0x2856070", VA = "0x182857070")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2857040", Offset = "0x2856040", VA = "0x182857040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
		public GLEMGOGMIOB(global::JEJKEABBLJL<T> NOPPIGEMPOA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HHJMOCELEPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<GLEMGOGMIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::JEJKEABBLJL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3188570", Offset = "0x3187570", VA = "0x183188570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1E567C0", Offset = "0x1E557C0", VA = "0x181E567C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct FDGGHNBAODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<GLEMGOGMIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::JEJKEABBLJL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x23B0250", Offset = "0x23AF250", VA = "0x1823B0250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1E567C0", Offset = "0x1E557C0", VA = "0x181E567C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim OJNIKPINPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T GKFBLNLJAOM;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NCNPANIECOD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x324DDF0", Offset = "0x324CDF0", VA = "0x18324DDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x324E3B0", Offset = "0x324D3B0", VA = "0x18324E3B0")]
	public JEJKEABBLJL(in T GKFBLNLJAOM, int CHEGOGGIJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x324E4F0", Offset = "0x324D4F0", VA = "0x18324E4F0")]
	public JEJKEABBLJL(in T GKFBLNLJAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x324DD70", Offset = "0x324CD70", VA = "0x18324DD70")]
	public GLEMGOGMIOB BBNOHFILLPN()
	{
		return default(GLEMGOGMIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x324DDB0", Offset = "0x324CDB0", VA = "0x18324DDB0")]
	public GLEMGOGMIOB BBNOHFILLPN(CancellationToken NIEOBBGKEFJ)
	{
		return default(GLEMGOGMIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x324DE10", Offset = "0x324CE10", VA = "0x18324DE10")]
	[AsyncStateMachine(typeof(global::JEJKEABBLJL<>.HHJMOCELEPB))]
	public Task<GLEMGOGMIOB> MFFCMACDCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x324E0D0", Offset = "0x324D0D0", VA = "0x18324E0D0")]
	[AsyncStateMachine(typeof(global::JEJKEABBLJL<>.FDGGHNBAODI))]
	public Task<GLEMGOGMIOB> MFFCMACDCCJ(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JKCAMACMDII
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE790", Offset = "0x5FBD790", VA = "0x185FBE790")]
	public static global::JEJKEABBLJL<PEFLLNEDEOA> DHGKFEMNGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE7F0", Offset = "0x5FBD7F0", VA = "0x185FBE7F0")]
	public static global::JEJKEABBLJL<PEFLLNEDEOA> DHGKFEMNGCO(int CHEGOGGIJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22E1940", Offset = "0x22E0940", VA = "0x1822E1940")]
	public static global::JEJKEABBLJL<T> DHGKFEMNGCO<T>(in T GKFBLNLJAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x25AD9C0", Offset = "0x25AC9C0", VA = "0x1825AD9C0")]
	public static global::JEJKEABBLJL<T> DHGKFEMNGCO<T>(in T GKFBLNLJAOM, int CHEGOGGIJPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FMDELPMLIIP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> ACMCHDEEEKA(TRequest KJACHHOOFKC, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum CPFPFPDDAIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class BOMDDIMNHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float MMNPGHLCNIE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan DLAOMPLBBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int ADPBMDBFFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CPFPFPDDAIP EIMEPHMCNCL;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly BOMDDIMNHMJ DCLACCPOJAP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float OHOOMJIKAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2412700", Offset = "0x2411700", VA = "0x182412700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan EKCILDCNCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2412930", Offset = "0x2411930", VA = "0x182412930")]
		public BOMDDIMNHMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct DMKNHJCOCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest KJACHHOOFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken NIEOBBGKEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> PGKECCGGAAP;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x28DC190", Offset = "0x28DB190", VA = "0x1828DC190")]
		public DMKNHJCOCDB(TRequest KJACHHOOFKC, TaskCompletionSource<TResult> PGKECCGGAAP, CancellationToken NIEOBBGKEFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DJCIEMMLFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public DJCIEMMLFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1E22CE0", Offset = "0x1E21CE0", VA = "0x181E22CE0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CBBCEIKKHKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::FMDELPMLIIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x29BED10", Offset = "0x29BDD10", VA = "0x1829BED10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CCHDADNLHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::FMDELPMLIIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DMKNHJCOCDB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x29C01E0", Offset = "0x29BF1E0", VA = "0x1829C01E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource PPLHONOODDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<DMKNHJCOCDB> LMDBGPJDMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BOMDDIMNHMJ MAMHMNGEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ACMCHDEEEKA DGMNCLPFMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task EHELOIBLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int DLHHEOOCPPD;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2E08820", Offset = "0x2E07820", VA = "0x182E08820")]
	public FMDELPMLIIP(ACMCHDEEEKA DGMNCLPFMBC, [Optional] BOMDDIMNHMJ MAMHMNGEGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2E07010", Offset = "0x2E06010", VA = "0x182E07010")]
	public Task<TResult> FFPMKODNIDL(TRequest KJACHHOOFKC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2E074D0", Offset = "0x2E064D0", VA = "0x182E074D0")]
	private void HAOEBKIAIJJ(DMKNHJCOCDB MLGBDIFGNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2E07E70", Offset = "0x2E06E70", VA = "0x182E07E70")]
	[AsyncStateMachine(typeof(global::FMDELPMLIIP<, >.CBBCEIKKHKO))]
	private Task KCMHKOBLJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2E08420", Offset = "0x2E07420", VA = "0x182E08420")]
	private DMKNHJCOCDB PEFELEHEIIP()
	{
		return default(DMKNHJCOCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2E076A0", Offset = "0x2E066A0", VA = "0x182E076A0")]
	[AsyncStateMachine(typeof(global::FMDELPMLIIP<, >.CCHDADNLHCM))]
	private Task IHNDBHMGEKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2E07BA0", Offset = "0x2E06BA0", VA = "0x182E07BA0")]
	private void JKBMKIJFBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2E06D80", Offset = "0x2E05D80", VA = "0x182E06D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NGJABPMGFNC<TKey, TVal> : global::OKOFPBCAHLM<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KPBOMBAEKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> HLPGBJPDCPB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int MHOGNANJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x329FBA0", Offset = "0x329EBA0", VA = "0x18329FBA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int JHIENKIAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x329FBD0", Offset = "0x329EBD0", VA = "0x18329FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x329F990", Offset = "0x329E990", VA = "0x18329F990", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x329FF20", Offset = "0x329EF20", VA = "0x18329FF20")]
	public NGJABPMGFNC(int CIMAPKKBLKM, [Optional] OGCIDHKEGNI GFCEKHLMHPJ, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x329F8F0", Offset = "0x329E8F0", VA = "0x18329F8F0")]
	public void AEEHHPHACDE(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE, bool MNMAHDIPEHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x329F870", Offset = "0x329E870", VA = "0x18329F870")]
	public bool ADFLHLKLIHN(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x329FB00", Offset = "0x329EB00", VA = "0x18329FB00", Slot = "6")]
	public override bool HADOILGNPLN(TKey AONMHIKEHCL, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x329FC00", Offset = "0x329EC00", VA = "0x18329FC00")]
	public bool NIDCHIJKCBB(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x329FE10", Offset = "0x329EE10", VA = "0x18329FE10")]
	public bool PDKFNIHLGDG(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x329FA90", Offset = "0x329EA90", VA = "0x18329FA90", Slot = "7")]
	public override void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x329F9F0", Offset = "0x329E9F0", VA = "0x18329F9F0")]
	private bool EDIHAMABFKK(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class OKOFPBCAHLM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int OGCIDHKEGNI(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CJPKHHAKKLH
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey GDJDAALKGJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xC39000", Offset = "0xC38000", VA = "0x180C39000")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal FBCEGMCNEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FGDMPDNAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6A01B0", Offset = "0x69F1B0", VA = "0x1806A01B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9C6CD0", Offset = "0x9C5CD0", VA = "0x1809C6CD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime DGGACODGFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xD35030", Offset = "0xD34030", VA = "0x180D35030")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x36D0230", Offset = "0x36CF230", VA = "0x1836D0230")]
		public CJPKHHAKKLH(TKey PIIJMEAKDGO, TVal EKFKNNJJKLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int NGCIBFNGJEN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<CJPKHHAKKLH>> MJECDAAIIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<CJPKHHAKKLH> AACCDJFJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly OGCIDHKEGNI GFCEKHLMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan FOLHBICOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LOCLLINHKIG BGOMCGOKDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HHJGJNONLOJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x67E020", Offset = "0x67D020", VA = "0x18067E020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool OHALBLFMLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x25F6440", Offset = "0x25F5440", VA = "0x1825F6440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int MHOGNANJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8D0C40", Offset = "0x8CFC40", VA = "0x1808D0C40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int MIOCJKOOLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x24CBE80", Offset = "0x24CAE80", VA = "0x1824CBE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F2B0", Offset = "0x1E2E2B0", VA = "0x181E2F2B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GLAEFLDOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x25F64D0", Offset = "0x25F54D0", VA = "0x1825F64D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x25F4DB0", Offset = "0x25F3DB0", VA = "0x1825F4DB0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x25F74E0", Offset = "0x25F64E0", VA = "0x1825F74E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x25F8020", Offset = "0x25F7020", VA = "0x1825F8020")]
	public OKOFPBCAHLM(int CIMAPKKBLKM, [Optional] OGCIDHKEGNI GFCEKHLMHPJ, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x25F8140", Offset = "0x25F7140", VA = "0x1825F8140")]
	public OKOFPBCAHLM(TimeSpan FOLHBICOLAE, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG, [Optional] LOCLLINHKIG BGOMCGOKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x25F80F0", Offset = "0x25F70F0", VA = "0x1825F80F0")]
	public OKOFPBCAHLM(int CIMAPKKBLKM, TimeSpan FOLHBICOLAE, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG, [Optional] LOCLLINHKIG BGOMCGOKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x25F7DA0", Offset = "0x25F6DA0", VA = "0x1825F7DA0")]
	public OKOFPBCAHLM(int CIMAPKKBLKM, OGCIDHKEGNI GFCEKHLMHPJ, TimeSpan FOLHBICOLAE, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG, [Optional] LOCLLINHKIG BGOMCGOKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x25F6EF0", Offset = "0x25F5EF0", VA = "0x1825F6EF0")]
	public void LAHNAJAJJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x25F5830", Offset = "0x25F4830", VA = "0x1825F5830")]
	public void FAFPJPFNCCD(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x25F5A90", Offset = "0x25F4A90", VA = "0x1825F5A90")]
	public bool FAHLDBEBGON(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x25F4BB0", Offset = "0x25F3BB0", VA = "0x1825F4BB0")]
	private TVal CIGAFCHFFML(TKey AONMHIKEHCL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x25F6020", Offset = "0x25F5020", VA = "0x1825F6020", Slot = "6")]
	public virtual bool HADOILGNPLN(TKey AONMHIKEHCL, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x25F5700", Offset = "0x25F4700", VA = "0x1825F5700", Slot = "7")]
	public virtual void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x25F7360", Offset = "0x25F6360", VA = "0x1825F7360")]
	private bool OBNLMAKGDAG(CJPKHHAKKLH FFBOGLDBEDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x25F54B0", Offset = "0x25F44B0", VA = "0x1825F54B0")]
	private void ELODKBAKHBH(LinkedListNode<CJPKHHAKKLH> FNELMAJLPKO, TVal ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x25F78F0", Offset = "0x25F68F0", VA = "0x1825F78F0")]
	private void PAGNFDLBLPI(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x25F6BE0", Offset = "0x25F5BE0", VA = "0x1825F6BE0")]
	private void LACKCJBOIMF(CJPKHHAKKLH FFBOGLDBEDF, TVal ANLFJINAGJI, int AODBOJHBLIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class OBMDEILOPNL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> DEEJEKFIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> EHBHDMJAKLC;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E22CE0", Offset = "0x1E21CE0", VA = "0x181E22CE0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E6EF40", Offset = "0x1E6DF40", VA = "0x181E6EF40", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x26FE580", Offset = "0x26FD580", VA = "0x1826FE580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x26FDBA0", Offset = "0x26FCBA0", VA = "0x1826FDBA0", Slot = "11")]
	public void Add(T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x26FE150", Offset = "0x26FD150", VA = "0x1826FE150")]
	public bool PICFJGOPDMI(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x26FE420", Offset = "0x26FD420", VA = "0x1826FE420", Slot = "15")]
	public bool Remove(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x26FDE60", Offset = "0x26FCE60", VA = "0x1826FDE60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x224C800", Offset = "0x224B800", VA = "0x18224C800", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x26FDBD0", Offset = "0x26FCBD0", VA = "0x1826FDBD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x26FDC30", Offset = "0x26FCC30", VA = "0x1826FDC30", Slot = "13")]
	public bool Contains(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x26FDC60", Offset = "0x26FCC60", VA = "0x1826FDC60", Slot = "14")]
	public void CopyTo(T[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x26FDEE0", Offset = "0x26FCEE0", VA = "0x1826FDEE0", Slot = "6")]
	public int IndexOf(T LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x26FDF10", Offset = "0x26FCF10", VA = "0x1826FDF10", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x26FE1F0", Offset = "0x26FD1F0", VA = "0x1826FE1F0", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x26FDD60", Offset = "0x26FCD60", VA = "0x1826FDD60")]
	public void DDCLDBCGDHO(Predicate<T> ELHCNCOMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x26FDE30", Offset = "0x26FCE30", VA = "0x1826FDE30")]
	public void EEKEIPLAHKB(Comparison<T> PJBLKOCNNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x26FE4A0", Offset = "0x26FD4A0", VA = "0x1826FE4A0")]
	public OBMDEILOPNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HFJEEKBFOPF
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD7A0", Offset = "0x5FBC7A0", VA = "0x185FBD7A0")]
	public static Vector3 AALKFFMJOHG(this GameObject NCAOMIEGHPA, float HCDKHMHEHFM)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2C136B0", Offset = "0x2C126B0", VA = "0x182C136B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1DC0", Offset = "0x5FC0DC0", VA = "0x185FC1DC0")]
		public SerializedGuid(in Guid FBKLHONPMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1B40", Offset = "0x5FC0B40", VA = "0x185FC1B40")]
		public static SerializedGuid MJHPIDKPELG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1D30", Offset = "0x5FC0D30", VA = "0x185FC1D30")]
		public static SerializedGuid PBCPIDPDGMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1AB0", Offset = "0x5FC0AB0", VA = "0x185FC1AB0")]
		public bool HEIHABBDIFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1D00", Offset = "0x5FC0D00", VA = "0x185FC1D00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1C60", Offset = "0x5FC0C60", VA = "0x185FC1C60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1BD0", Offset = "0x5FC0BD0", VA = "0x185FC1BD0")]
		public bool NOHLHLNDIHM(in Guid FBKLHONPMNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1910", Offset = "0x5FC0910", VA = "0x185FC1910", Slot = "7")]
		public bool Equals(SerializedGuid KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FC19C0", Offset = "0x5FC09C0", VA = "0x185FC19C0", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1AA0", Offset = "0x5FC0AA0", VA = "0x185FC1AA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC18E0", Offset = "0x5FC08E0", VA = "0x185FC18E0", Slot = "6")]
		public int CompareTo(SerializedGuid KICLNADFIEK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ODDCEFEONEM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type HHJGDOONOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string DOLPENJBBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool LLNLMOIDPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool PFDMPOHDLOO;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FC00D0", Offset = "0x5FBF0D0", VA = "0x185FC00D0")]
	public ODDCEFEONEM(Type NPNDEAKJHMK, string GLBBOBHIGEF, bool LJBNACDNBAJ = false, bool CLPKENBFNFL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HOGBHLHLJNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface PGHPDFIAEFD<T> : HOGBHLHLJNA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NFGCGLFPAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string NHNFMLEJKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PGHPDFIAEFD<T> JKOEAMKPNHD(Action<T> DAHHKFPCOGH);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PGHPDFIAEFD<T> BNKDNJFAEOF(Action<T> DAHHKFPCOGH);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::PGHPDFIAEFD<T> FKGHCFALPBL(Action<T, T> JDNJBDBBLKJ);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::PGHPDFIAEFD<T> IKCMDECLNGE(Action<T, T> JDNJBDBBLKJ);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::PGHPDFIAEFD<T> MFFGPCKMDPP(Action<string> BOHIKNFJOLB);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::PGHPDFIAEFD<T> MBFCNOOKPNF(Action<string> BOHIKNFJOLB);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GDDIJDJHJBL<T> : global::PGHPDFIAEFD<T>, HOGBHLHLJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::BKNNAJHBPLG<T, T> KOCFHIDFLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::PBGGDBDIKGA<T> DBAPMBGEHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::PBGGDBDIKGA<string> BFCDNGBHMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string HMOPFJALLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T MMPEAFKIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BJLEDANDLNH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x23A2340", Offset = "0x23A1340", VA = "0x1823A2340", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NFGCGLFPAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x749540", Offset = "0x748540", VA = "0x180749540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NHNFMLEJKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2398BF0", Offset = "0x2397BF0", VA = "0x182398BF0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x39E7C80", Offset = "0x39E6C80", VA = "0x1839E7C80")]
	private void OMLKCIMPBMO(T BNKBFACGLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x39E7D20", Offset = "0x39E6D20", VA = "0x1839E7D20")]
	private void PHEMCMCOJAD(string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x39E7A30", Offset = "0x39E6A30", VA = "0x1839E7A30")]
	public void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x39E7990", Offset = "0x39E6990", VA = "0x1839E7990", Slot = "6")]
	public global::PGHPDFIAEFD<T> FKGHCFALPBL(Action<T, T> JDNJBDBBLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x39E79E0", Offset = "0x39E69E0", VA = "0x1839E79E0", Slot = "7")]
	public global::PGHPDFIAEFD<T> IKCMDECLNGE(Action<T, T> JDNJBDBBLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x39E7AE0", Offset = "0x39E6AE0", VA = "0x1839E7AE0", Slot = "4")]
	public global::PGHPDFIAEFD<T> JKOEAMKPNHD(Action<T> JDNJBDBBLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x39E7940", Offset = "0x39E6940", VA = "0x1839E7940", Slot = "5")]
	public global::PGHPDFIAEFD<T> BNKDNJFAEOF(Action<T> DAHHKFPCOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x39E7BE0", Offset = "0x39E6BE0", VA = "0x1839E7BE0", Slot = "8")]
	public global::PGHPDFIAEFD<T> MFFGPCKMDPP(Action<string> BOHIKNFJOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x39E7B70", Offset = "0x39E6B70", VA = "0x1839E7B70", Slot = "9")]
	public global::PGHPDFIAEFD<T> MBFCNOOKPNF(Action<string> BOHIKNFJOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x39E7DD0", Offset = "0x39E6DD0", VA = "0x1839E7DD0")]
	public GDDIJDJHJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OLAAOKFENHK
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class PHJJPNKMHFG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::PGHPDFIAEFD<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::OHLHHHNAFPB<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public PHJJPNKMHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D87720", Offset = "0x2D86720", VA = "0x182D87720")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x278CE20", Offset = "0x278BE20", VA = "0x18278CE20")]
	public static global::MMBCCHGMCHN<T> NAGKGPCIBKK<T>(this global::PGHPDFIAEFD<T> JDDPOOGGDFP, Action<T> KDDLOKAHKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FCHNJJOGFOB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct OAHJLKFBMHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long JKHPMALILOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long OBCLDHBFDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int HJLGLIAOLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int FNJLGCBIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool DDBCKIBFNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string BBOEMCCPBPO;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x26FA8C0", Offset = "0x26F98C0", VA = "0x1826FA8C0")]
		public OAHJLKFBMHH(long JKHPMALILOJ, int HJLGLIAOLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x26FA930", Offset = "0x26F9930", VA = "0x1826FA930")]
		public OAHJLKFBMHH(long JKHPMALILOJ, long OBCLDHBFDEN, int HJLGLIAOLCD, int FNJLGCBIPBP, bool DDBCKIBFNJI, string BBOEMCCPBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x26FA850", Offset = "0x26F9850", VA = "0x1826FA850")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PNBPNOBIFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x26FA770", Offset = "0x26F9770", VA = "0x1826FA770")]
		public int LPOIABKHBBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x26FA750", Offset = "0x26F9750", VA = "0x1826FA750")]
		public int JBDELJPCCAN(int LOGFDHKJFAO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x26FA6E0", Offset = "0x26F96E0", VA = "0x1826FA6E0")]
		public double FDKOCGHOFOE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x26FA7C0", Offset = "0x26F97C0", VA = "0x1826FA7C0")]
		public OAHJLKFBMHH MALNKALCFFP(long OBCLDHBFDEN, int FNJLGCBIPBP)
		{
			return default(OAHJLKFBMHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class NILMFDECOMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::FCHNJJOGFOB<TKey> JBAEFOFJALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<NILMFDECOMH> FHFABDLCEOB;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FPPKMBCPJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2005780", Offset = "0x2004780", VA = "0x182005780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x28941A0", Offset = "0x28931A0", VA = "0x1828941A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<NILMFDECOMH> OAIKOAKHGFO
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32A0CB0", Offset = "0x329FCB0", VA = "0x1832A0CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public OAHJLKFBMHH GOGNAMDCKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x16FD4A0", Offset = "0x16FC4A0", VA = "0x1816FD4A0")]
			[CompilerGenerated]
			get
			{
				return default(OAHJLKFBMHH);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x32A09F0", Offset = "0x329F9F0", VA = "0x1832A09F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x32A0DE0", Offset = "0x329FDE0", VA = "0x1832A0DE0")]
		internal NILMFDECOMH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, TKey PIIJMEAKDGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x32A0CD0", Offset = "0x329FCD0", VA = "0x1832A0CD0")]
		public NILMFDECOMH MNAIBJMIJAB(TKey PIIJMEAKDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x32A0A20", Offset = "0x329FA20", VA = "0x1832A0A20")]
		public void DKKKOACNPHJ(TKey PIIJMEAKDGO, Action<NILMFDECOMH> KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x26CEB50", Offset = "0x26CDB50", VA = "0x1826CEB50")]
		public T DKKKOACNPHJ<T>(TKey PIIJMEAKDGO, Func<NILMFDECOMH, T> PNCAEBHDNMM)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x26CECA0", Offset = "0x26CDCA0", VA = "0x1826CECA0")]
		[AsyncStateMachine(typeof(CLFOMKCHEJI))]
		public Task<T> OMHMKEMHOPP<T>(TKey PIIJMEAKDGO, Func<NILMFDECOMH, Task<T>> PNCAEBHDNMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B00", Offset = "0x329FB00", VA = "0x1832A0B00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LCJOPLAOBKN : IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, OAHJLKFBMHH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::FCHNJJOGFOB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, OAHJLKFBMHH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, OAHJLKFBMHH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2081AA0", Offset = "0x2080AA0", VA = "0x182081AA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OAHJLKFBMHH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2081B40", Offset = "0x2080B40", VA = "0x182081B40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2081BF0", Offset = "0x2080BF0", VA = "0x182081BF0")]
		[DebuggerHidden]
		public LCJOPLAOBKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x207FBD0", Offset = "0x207EBD0", VA = "0x18207FBD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2081730", Offset = "0x2080730", VA = "0x182081730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2081BA0", Offset = "0x2080BA0", VA = "0x182081BA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2081B00", Offset = "0x2080B00", VA = "0x182081B00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x20819E0", Offset = "0x20809E0", VA = "0x1820819E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2081AD0", Offset = "0x2080AD0", VA = "0x182081AD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JOBGHIBGCJP : IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, OAHJLKFBMHH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NILMFDECOMH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public NILMFDECOMH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::FCHNJJOGFOB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<NILMFDECOMH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, OAHJLKFBMHH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, OAHJLKFBMHH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2081AA0", Offset = "0x2080AA0", VA = "0x182081AA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OAHJLKFBMHH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x365A4C0", Offset = "0x36594C0", VA = "0x18365A4C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2081BF0", Offset = "0x2080BF0", VA = "0x182081BF0")]
		[DebuggerHidden]
		public JOBGHIBGCJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x365A520", Offset = "0x3659520", VA = "0x18365A520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3659DD0", Offset = "0x3658DD0", VA = "0x183659DD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x365A5C0", Offset = "0x36595C0", VA = "0x18365A5C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x365A620", Offset = "0x3659620", VA = "0x18365A620")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x365A480", Offset = "0x3659480", VA = "0x18365A480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x365A370", Offset = "0x3659370", VA = "0x18365A370", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x365A450", Offset = "0x3659450", VA = "0x18365A450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, OAHJLKFBMHH> LHCKHMBNGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, OAHJLKFBMHH> CBGIEHLIBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::FCHNJJOGFOB<TKey>> OAAKEMBCDNK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string OGMOKKOIIKO = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly NILMFDECOMH ELKHDHJOJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool JKEEGJNIPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int AFNNCILCJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch DELOHPFEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int NNJIKPHMBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string AEHEKHOCHCD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NILMFDECOMH HFLFMGIJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string FPPKMBCPJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x67E0D0", Offset = "0x67D0D0", VA = "0x18067E0D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x23AF280", Offset = "0x23AE280", VA = "0x1823AF280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long FIHOJLMBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x23AF2E0", Offset = "0x23AE2E0", VA = "0x1823AF2E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int OPLODEDHKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x23AF1A0", Offset = "0x23AE1A0", VA = "0x1823AF1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x23AF480", Offset = "0x23AE480", VA = "0x1823AF480")]
	public FCHNJJOGFOB(TKey FBJNOJLLOAM, [Optional] int? HJLGLIAOLCD, [Optional][CanBeNull] Stopwatch DELOHPFEPEL, [Optional] Action<TKey, OAHJLKFBMHH> LHCKHMBNGLA, [Optional] Action<TKey, OAHJLKFBMHH> CBGIEHLIBIH, [Optional] Action<global::FCHNJJOGFOB<TKey>> OAAKEMBCDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x23AF1F0", Offset = "0x23AE1F0", VA = "0x1823AF1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x23AF1D0", Offset = "0x23AE1D0", VA = "0x1823AF1D0")]
	public void CCLKNNLCIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x23AF460", Offset = "0x23AE460", VA = "0x1823AF460")]
	public void PLNENDECPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x23AF3D0", Offset = "0x23AE3D0", VA = "0x1823AF3D0")]
	[IteratorStateMachine(typeof(global::FCHNJJOGFOB<>.LCJOPLAOBKN))]
	public IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)> NGBHIEPIOIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x23AF300", Offset = "0x23AE300", VA = "0x1823AF300")]
	[IteratorStateMachine(typeof(global::FCHNJJOGFOB<>.JOBGHIBGCJP))]
	private IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)> NGBHIEPIOIG(List<TKey> JLGENJBOGCK, NILMFDECOMH KGNPFBLGGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x23AF120", Offset = "0x23AE120", VA = "0x1823AF120")]
	private (long, int) AAIHEFNLGCL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class JJMCEGKGEMO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	protected JJMCEGKGEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class ONONEANNOGA<TKey> : global::JJMCEGKGEMO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string JCJDGKCGEKD(TKey PIIJMEAKDGO);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2602170", Offset = "0x2601170", VA = "0x182602170")]
	protected string GJNKBOOOFDE(double GGOHKCCMMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2602110", Offset = "0x2601110", VA = "0x182602110")]
	protected string DECLIGLOEOL(int IDLFMEJFHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x26021E0", Offset = "0x26011E0", VA = "0x1826021E0")]
	private static string IHBGCFDOLPD(TKey PIIJMEAKDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2602220", Offset = "0x2601220", VA = "0x182602220", Slot = "4")]
	public override string KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x26022D0", Offset = "0x26012D0", VA = "0x1826022D0")]
	public string KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, [NotNull] JCJDGKCGEKD HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PCBGBBCIPME(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, [NotNull] JCJDGKCGEKD HBHOACACMCM);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x24174E0", Offset = "0x24164E0", VA = "0x1824174E0")]
	protected ONONEANNOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EEDDICAIGCD<TKey> : global::JJMCEGKGEMO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string DAFNICDKJJK(TKey PIIJMEAKDGO);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int PPBHFGJDILL = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string PAAJCMMHJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double KIHKCJEJDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool KLOIAEDCBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int CFAJLMPOEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> FAEHEOAIGMC;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x27370D0", Offset = "0x27360D0", VA = "0x1827370D0")]
	private static string IHBGCFDOLPD(TKey PIIJMEAKDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x27378B0", Offset = "0x27368B0", VA = "0x1827378B0")]
	public EEDDICAIGCD(string PAAJCMMHJBH = "F2", double KIHKCJEJDDG = double.MaxValue, bool KLOIAEDCBLK = false, int CFAJLMPOEAK = int.MaxValue, [Optional] ISet<string> FAEHEOAIGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2737650", Offset = "0x2736650", VA = "0x182737650", Slot = "4")]
	public override Dictionary<string, string> KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2736E70", Offset = "0x2735E70", VA = "0x182736E70")]
	private bool EBHPINLDHJH(string HKEFJKDOJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2737110", Offset = "0x2736110", VA = "0x182737110")]
	public Dictionary<string, string> KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, DAFNICDKJJK HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2737700", Offset = "0x2736700", VA = "0x182737700")]
	private string ONKPNAEBLHN(StringBuilder KJMJBGBGDGP, List<TKey> MFHECOKLKDI, DAFNICDKJJK HBHOACACMCM, bool BBPNMPIGEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2736F50", Offset = "0x2735F50", VA = "0x182736F50")]
	private static void HEMKNFGAKLO(StringBuilder HNJGCECEMOO, string LPMFMPJNAOH, bool OFPMIGLEBKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PJAFCOFDDKI<TKey> : global::ONONEANNOGA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct KADOJOAFMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public JCJDGKCGEKD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::PJAFCOFDDKI<TKey> JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int EABOGNFEPMK = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] MBMPIKNJCGB;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2D88B50", Offset = "0x2D87B50", VA = "0x182D88B50")]
	private PJAFCOFDDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2D87B60", Offset = "0x2D86B60", VA = "0x182D87B60", Slot = "5")]
	protected override string PCBGBBCIPME(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, JCJDGKCGEKD HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2D87A70", Offset = "0x2D86A70", VA = "0x182D87A70")]
	[CompilerGenerated]
	internal static string INKDGHJLAJO(string MMILAMMAGCG, TKey PIIJMEAKDGO, ref KADOJOAFMKO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class FPHEGEFOOKF<TKey> : global::ONONEANNOGA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class AGAGGNLHMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public JCJDGKCGEKD keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public AGAGGNLHMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2005280", Offset = "0x2004280", VA = "0x182005280")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2E13930", Offset = "0x2E12930", VA = "0x182E13930", Slot = "5")]
	protected override string PCBGBBCIPME(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, JCJDGKCGEKD HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x28594D0", Offset = "0x28584D0", VA = "0x1828594D0")]
	public FPHEGEFOOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class GGEGOGGLJPL : global::FCHNJJOGFOB<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AOLIMAGGEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<GGEGOGGLJPL> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AOLIMAGGEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8BA0", Offset = "0x5FB7BA0", VA = "0x185FB8BA0")]
		internal void <Wrap>b__0(global::FCHNJJOGFOB<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC340", Offset = "0x5FBB340", VA = "0x185FBC340")]
	public GGEGOGGLJPL([Optional] string PAOCLLJLEBE, [Optional] int? HJLGLIAOLCD, [Optional] Stopwatch DELOHPFEPEL, [Optional] Action<string, OAHJLKFBMHH> LHCKHMBNGLA, [Optional] Action<string, OAHJLKFBMHH> CBGIEHLIBIH, [Optional] Action<GGEGOGGLJPL> OAAKEMBCDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC260", Offset = "0x5FBB260", VA = "0x185FBC260")]
	private static Action<global::FCHNJJOGFOB<string>> DKKKOACNPHJ(Action<GGEGOGGLJPL> KDDLOKAHKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class LOCLLINHKIG
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class DIJMBPHLPNN : LOCLLINHKIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static LOCLLINHKIG JKCIDAEDHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB610", Offset = "0x5FBA610", VA = "0x185FBB610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime KNMMFEGBJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB680", Offset = "0x5FBA680", VA = "0x185FBB680", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float HMPMJHLCGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5FBB670", Offset = "0x5FBA670", VA = "0x185FBB670", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB770", Offset = "0x5FBA770", VA = "0x185FBB770")]
		public DIJMBPHLPNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static LOCLLINHKIG KOIJCEBCMHJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static LOCLLINHKIG DCLACCPOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5FBEFB0", Offset = "0x5FBDFB0", VA = "0x185FBEFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime KNMMFEGBJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float HMPMJHLCGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	protected LOCLLINHKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GLBABLCMFCO : global::PIGMLBGGPIP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD760", Offset = "0x5FBC760", VA = "0x185FBD760")]
	public GLBABLCMFCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PIGMLBGGPIP<T> : global::DMMEEHPGKIP<T>, FECLEKCPFKC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task PJLPMOENIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x13D7DF0", Offset = "0x13D6DF0", VA = "0x1813D7DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private CCBLCAIHLNA FGFGGHKHEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1E22D10", Offset = "0x1E21D10", VA = "0x181E22D10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2D87980", Offset = "0x2D86980", VA = "0x182D87980")]
	public PIGMLBGGPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FFINHHKKNAK : global::OHOFINJIFJG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB950", Offset = "0x5FBA950", VA = "0x185FBB950")]
	public FFINHHKKNAK(Exception PBDFKDHMIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OHOFINJIFJG<T> : global::DMMEEHPGKIP<T>, FECLEKCPFKC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task PJLPMOENIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x13D7DF0", Offset = "0x13D6DF0", VA = "0x1813D7DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private CCBLCAIHLNA FGFGGHKHEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1E22D10", Offset = "0x1E21D10", VA = "0x181E22D10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x25EBCD0", Offset = "0x25EACD0", VA = "0x1825EBCD0")]
	public OHOFINJIFJG(Exception PBDFKDHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface FECLEKCPFKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	CCBLCAIHLNA DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface DMMEEHPGKIP<T> : FECLEKCPFKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class IAIFCELGNOK<TTask, T> : global::DMMEEHPGKIP<T>, FECLEKCPFKC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class NBEDIHCOIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::IAIFCELGNOK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public NBEDIHCOIDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool DFBJBIDNPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> KLOLOJBLOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource ANGOLJLDKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool JKEEGJNIPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext DFHBOECJICB;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task PJLPMOENIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private CCBLCAIHLNA FGFGGHKHEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x22CD240", Offset = "0x22CC240", VA = "0x1822CD240", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x451F080", Offset = "0x451E080", VA = "0x18451F080")]
	static IAIFCELGNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x451F530", Offset = "0x451E530", VA = "0x18451F530")]
	protected IAIFCELGNOK(TTask KLOLOJBLOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x451ECE0", Offset = "0x451DCE0", VA = "0x18451ECE0", Slot = "1")]
	~IAIFCELGNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x451ECB0", Offset = "0x451DCB0", VA = "0x18451ECB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x451EEC0", Offset = "0x451DEC0", VA = "0x18451EEC0")]
	private void KKDFCIPLDMN(bool CAEBOCAEOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BELANHOLBFL(TTask OBEFKKHJPMC);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GBLDEPLKPKI();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x451F030", Offset = "0x451E030", VA = "0x18451F030")]
	[CompilerGenerated]
	private void MBAKOALBABH(object ONHHPHCFHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PENMGOCJCDO
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OHKJNKGALFA NHGEKJNIPNN;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CGCFOACLBLD : PENMGOCJCDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct JABJJGLEFCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float DBEFHDBAOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float CGABGKILPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool DOFAOAHKOHP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float FGDMPDNAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5FBE4C0", Offset = "0x5FBD4C0", VA = "0x185FBE4C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE650", Offset = "0x5FBD650", VA = "0x185FBE650")]
		public JABJJGLEFCF(float FHGIIAKFJFF, float APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE4D0", Offset = "0x5FBD4D0", VA = "0x185FBE4D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class NGLBIACONEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CGCFOACLBLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public NGLBIACONEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int CIMAPKKBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int LCKOCMIMECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PENMGOCJCDO[] EONMCGJCGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly OHKJNKGALFA[] ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly JABJJGLEFCF[] MCADCBFIFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JABJJGLEFCF GJMKOAKDMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly ACHCIGHCIHA LKDMIMKKLJL;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public JABJJGLEFCF KGMPILMHHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2002F70", Offset = "0x2001F70", VA = "0x182002F70")]
		get
		{
			return default(JABJJGLEFCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA730", Offset = "0x5FB9730", VA = "0x185FBA730", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OHKJNKGALFA NHGEKJNIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA750", Offset = "0x5FB9750", VA = "0x185FBA750", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA440", Offset = "0x5FB9440", VA = "0x185FBA440", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5FBACF0", Offset = "0x5FB9CF0", VA = "0x185FBACF0")]
	public CGCFOACLBLD(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA810", Offset = "0x5FB9810", VA = "0x185FBA810")]
	public ACHCIGHCIHA KIDBPNNEIAN(JABJJGLEFCF CFMHDCICDHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA8A0", Offset = "0x5FB98A0", VA = "0x185FBA8A0")]
	public void PBJEFMOADMD(PENMGOCJCDO GJALBPMAPLM, [Optional] JABJJGLEFCF GLDANKGCKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA6E0", Offset = "0x5FB96E0", VA = "0x185FBA6E0")]
	internal int FIGLOCELEJH(PENMGOCJCDO HEPDJBBCBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA500", Offset = "0x5FB9500", VA = "0x185FBA500")]
	internal JABJJGLEFCF CNBJGPONNED(int NPDGHPHAKDK)
	{
		return default(JABJJGLEFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA550", Offset = "0x5FB9550", VA = "0x185FBA550", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void OHKJNKGALFA(float JLBGCGDHKHO);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class KILDIHIIIBD
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float LKLFKLHBBNP = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class GJCDFKNIAKG
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class GKNJEFJOMPB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly PENMGOCJCDO HEPDJBBCBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly OHKJNKGALFA KDDLOKAHKOL;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD6D0", Offset = "0x5FBC6D0", VA = "0x185FBD6D0")]
		public GKNJEFJOMPB(PENMGOCJCDO HEPDJBBCBIC, OHKJNKGALFA KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD680", Offset = "0x5FBC680", VA = "0x185FBD680", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC530", Offset = "0x5FBB530", VA = "0x185FBC530")]
	internal static bool CDCCPDCAGKN(float NCNGLFNLPAG, float OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4975470", Offset = "0x4974470", VA = "0x184975470")]
	internal static float HKBKMOHPIKP(float NCNGLFNLPAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC5B0", Offset = "0x5FBB5B0", VA = "0x185FBC5B0")]
	public static IDisposable OCDFIPCFIAJ(this PENMGOCJCDO HEPDJBBCBIC, OHKJNKGALFA KDDLOKAHKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class ACHCIGHCIHA : PENMGOCJCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float JLBGCGDHKHO;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10998C0", Offset = "0x10988C0", VA = "0x1810998C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8AE0", Offset = "0x5FB7AE0", VA = "0x185FB8AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OHKJNKGALFA NHGEKJNIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8A40", Offset = "0x5FB7A40", VA = "0x185FB8A40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5FB89A0", Offset = "0x5FB79A0", VA = "0x185FB89A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ACHCIGHCIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class BBNNHBKDNGB
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8FC0", Offset = "0x5FB7FC0", VA = "0x185FB8FC0")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this CHMJLDKJAME CMHDAGCJLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9030", Offset = "0x5FB8030", VA = "0x185FB9030")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this CHMJLDKJAME CMHDAGCJLBD, HashAlgorithmName MEPKCHCGNEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8E30", Offset = "0x5FB7E30", VA = "0x185FB8E30")]
	public static bool CENICFKKIKC([CanBeNull] this CHMJLDKJAME CMHDAGCJLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8C90", Offset = "0x5FB7C90", VA = "0x185FB8C90")]
	public static bool CENICFKKIKC([CanBeNull] this CHMJLDKJAME CMHDAGCJLBD, out string HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FB91C0", Offset = "0x5FB81C0", VA = "0x185FB91C0")]
	private static string LNKJFELGOIH([CanBeNull] byte[] CCFMJPPGPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FB90A0", Offset = "0x5FB80A0", VA = "0x185FB90A0")]
	private static bool HLGLCBODIKI([NotNull] CHMJLDKJAME CMHDAGCJLBD, [CanBeNull] out byte[] GLFPGLGEHLE, [CanBeNull] out byte[] ANIAICAKNMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class MIOAEMCNGHE
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF220", Offset = "0x5FBE220", VA = "0x185FBF220")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this LHNLMNFPGGD KOCGBDMJFKC, byte[] FBJMMPJHNIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF260", Offset = "0x5FBE260", VA = "0x185FBF260")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this LHNLMNFPGGD KOCGBDMJFKC, HashAlgorithmName MEPKCHCGNEL, byte[] FBJMMPJHNIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface LHNLMNFPGGD
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NHBPPIHNEOH);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface CHMJLDKJAME : LHNLMNFPGGD
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] AMKDIDPJNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] NHCDGAFIMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object MFEPGPDJHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class BMDEMKBLDFG
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class MHGKFCOFKCG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF1A0", Offset = "0x5FBE1A0", VA = "0x185FBF1A0")]
		public MHGKFCOFKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF140", Offset = "0x5FBE140", VA = "0x185FBF140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte HLFHHOHLCCF = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte BEMIFNPKLHN = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> FGONAFOACAH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool GBLKDMDLBLD;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x22DC220", Offset = "0x22DB220", VA = "0x1822DC220")]
	[Conditional("UNITY_EDITOR")]
	private static void CDECIJIMMFC<T>(params T[] CNFKPPGBEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9890", Offset = "0x5FB8890", VA = "0x185FB9890")]
	public static IDisposable HAOHFFMMIMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9B00", Offset = "0x5FB8B00", VA = "0x185FB9B00")]
	public static void IIGCLLNNIAN(this IncrementalHash BJKHCFMFJAN, [CanBeNull] GameObject NCAOMIEGHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x22DCC90", Offset = "0x22DBC90", VA = "0x1822DCC90")]
	public static void IIGCLLNNIAN<T>(this IncrementalHash BJKHCFMFJAN, [CanBeNull] T KMJCJNGOPHM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x22DCC00", Offset = "0x22DBC00", VA = "0x1822DCC00")]
	public static void GPEAPNFMFKE<T>(this IncrementalHash BJKHCFMFJAN, [CanBeNull] T KOCGBDMJFKC) where T : LHNLMNFPGGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x22DCD60", Offset = "0x22DBD60", VA = "0x1822DCD60")]
	public static void LHAFEJLOAEL<T>(this IncrementalHash BJKHCFMFJAN, [CanBeNull] IList<T> IFHLBGACKDB) where T : LHNLMNFPGGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9290", Offset = "0x5FB8290", VA = "0x185FB9290")]
	private static bool CLNGNHODEPK([CanBeNull] LHNLMNFPGGD KOCGBDMJFKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5FB94F0", Offset = "0x5FB84F0", VA = "0x185FB94F0")]
	public static void FNLNNONBKMJ(this IncrementalHash NHBPPIHNEOH, [CanBeNull] string MOOPPHNCKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9930", Offset = "0x5FB8930", VA = "0x185FB9930")]
	public static void HJCLNJBCBCP(this IncrementalHash NHBPPIHNEOH, long CKBMFMBNAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA060", Offset = "0x5FB9060", VA = "0x185FBA060")]
	public static void PKBFANDHHBO(this IncrementalHash NHBPPIHNEOH, int FMHAGAADDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9550", Offset = "0x5FB8550", VA = "0x185FB9550")]
	public static void FODBKCJHINP(this IncrementalHash NHBPPIHNEOH, short JFBMJEKHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9380", Offset = "0x5FB8380", VA = "0x185FB9380")]
	public static void EDAONCFGCJL(this IncrementalHash NHBPPIHNEOH, byte GBCILJKLDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9E20", Offset = "0x5FB8E20", VA = "0x185FB9E20")]
	public static void OLMCAMNIMED(this IncrementalHash NHBPPIHNEOH, bool LMHFHBHPPJM, bool JHCPLIFNHEP = false, bool ADKKLJBEHGC = false, bool EBEGHPEHEAI = false, bool PEJLIPJNDHE = false, bool JIKJIFCGPCL = false, bool KHIMBDFDBCE = false, bool HPFOCOBAIBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x22DC510", Offset = "0x22DB510", VA = "0x1822DC510")]
	public static void GBMDIEHNMGO<T>(this IncrementalHash NHBPPIHNEOH, T NPAJHANNMDG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA230", Offset = "0x5FB9230", VA = "0x185FBA230")]
	public static void PKHCELFEDMO(this IncrementalHash NHBPPIHNEOH, float ALHAPPCLDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9230", Offset = "0x5FB8230", VA = "0x185FB9230")]
	public static void AKNNNBFKJHC(this IncrementalHash NHBPPIHNEOH, double DILGBHEFMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9FF0", Offset = "0x5FB8FF0", VA = "0x185FB9FF0")]
	public static void PBAMFIFFDAH(this IncrementalHash NHBPPIHNEOH, ulong ECMEIGJCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9320", Offset = "0x5FB8320", VA = "0x185FB9320")]
	public static void DKGENBFHAEJ(this IncrementalHash NHBPPIHNEOH, uint EKEABEOKBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9BF0", Offset = "0x5FB8BF0", VA = "0x185FB9BF0")]
	public static void LAOBNJHNBGG(this IncrementalHash NHBPPIHNEOH, ushort IAJBDKHFPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9720", Offset = "0x5FB8720", VA = "0x185FB9720")]
	public static void GJIBDNBNNPF(this IncrementalHash NHBPPIHNEOH, Vector3 PEKHGKEACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9C60", Offset = "0x5FB8C60", VA = "0x185FB9C60")]
	public static void MFMBIKGHMBH(this IncrementalHash NHBPPIHNEOH, Quaternion NJJOJLEDHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class GBFCMHPLPIJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type HHJGDOONOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string DOLPENJBBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool LLNLMOIDPDH;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD80", Offset = "0x5FBAD80", VA = "0x185FBBD80")]
	public GBFCMHPLPIJ(Type NPNDEAKJHMK, string GLBBOBHIGEF, bool LJBNACDNBAJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GKGLHMNCGEE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD610", Offset = "0x5FBC610", VA = "0x185FBD610")]
	public GKGLHMNCGEE(string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD590", Offset = "0x5FBC590", VA = "0x185FBD590")]
	public GKGLHMNCGEE(string LMLMHJKGDCH, Exception ACPNJFGCPAG)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x694790", Offset = "0x693790", VA = "0x180694790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int MNBBHFLLBID, int AKDMBOIHBGA]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x3387770", Offset = "0x3386770", VA = "0x183387770")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3387810", Offset = "0x3386810", VA = "0x183387810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x33876E0", Offset = "0x33866E0", VA = "0x1833876E0")]
		public Array2D(uint LBHCEBCJMEF, uint MMPBKAKMEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3387660", Offset = "0x3386660", VA = "0x183387660")]
		public void EMOCNNJJBKM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8C30", Offset = "0x5FB7C30", VA = "0x185FB8C30")]
		public Array2DVector3(uint LBHCEBCJMEF, uint MMPBKAKMEAK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class HIAFHCILFML
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int JGPBOJFCMCN = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int FJPABEMJFBF = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class JAGKIEIPGFG<THandle, TValue> : IDisposable where THandle : struct, BCAIPGNNKGO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> ANAONBGCBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> GPJMEADJCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> IKIIBNGNLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> ONMMKJGOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int CBAOIFGGBHE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F1A4B0", Offset = "0x2F194B0", VA = "0x182F1A4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AEA0", Offset = "0x2F19EA0", VA = "0x182F1AEA0")]
	public JAGKIEIPGFG(Action<TValue> ONMMKJGOBJI, [Optional] Func<TValue> IKIIBNGNLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A4E0", Offset = "0x2F194E0", VA = "0x182F1A4E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A890", Offset = "0x2F19890", VA = "0x182F1A890")]
	public THandle HJNGNBALKKN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AA70", Offset = "0x2F19A70", VA = "0x182F1AA70")]
	public THandle HMNAIPBHJIK(TValue DFEOJBAFBHE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A640", Offset = "0x2F19640", VA = "0x182F1A640")]
	public bool FAHLDBEBGON(THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AAF0", Offset = "0x2F19AF0", VA = "0x182F1AAF0")]
	public bool KGNKLNCMPDI(THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AD60", Offset = "0x2F19D60", VA = "0x182F1AD60")]
	public bool MDMOKHFDALA(THandle DCLMHANFEGK, out TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A460", Offset = "0x2F19460", VA = "0x182F1A460")]
	public TValue CIGAFCHFFML(THandle DCLMHANFEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AC70", Offset = "0x2F19C70", VA = "0x182F1AC70")]
	public bool LCJCOLBECPG(THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AE70", Offset = "0x2F19E70", VA = "0x182F1AE70")]
	private THandle POEHCFIKMHG(int NPDGHPHAKDK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AE00", Offset = "0x2F19E00", VA = "0x182F1AE00")]
	private TValue NAGKGPCIBKK(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AD20", Offset = "0x2F19D20", VA = "0x182F1AD20")]
	private void LOFOALDBIBB(int NPDGHPHAKDK, in THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AE30", Offset = "0x2F19E30", VA = "0x182F1AE30")]
	private void OMLKCIMPBMO(int NPDGHPHAKDK, in TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A2F0", Offset = "0x2F192F0", VA = "0x182F1A2F0")]
	private THandle ADLGJPHOFCG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ABC0", Offset = "0x2F19BC0", VA = "0x182F1ABC0")]
	private void LAMBGBGGJEB(THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A630", Offset = "0x2F19630", VA = "0x182F1A630")]
	private int EOPJBIGFFMC(int IIJDDKBOPLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AAE0", Offset = "0x2F19AE0", VA = "0x182F1AAE0")]
	private bool JEPJKHOAEGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E5640", Offset = "0x6E4640", VA = "0x1806E5640")]
	private void DACKAOJJPJF(THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A810", Offset = "0x2F19810", VA = "0x182F1A810")]
	private bool FIEEBHMACFK(out THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A560", Offset = "0x2F19560", VA = "0x182F1A560")]
	private bool ENFKINLJGFP(out THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A400", Offset = "0x2F19400", VA = "0x182F1A400")]
	private void CAPKJFFCDII(THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A6F0", Offset = "0x2F196F0", VA = "0x182F1A6F0")]
	private void FDOKKKKGMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface BCAIPGNNKGO
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface GAMKFLDBKPP<T> : BCAIPGNNKGO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CPPKBBJGNAO
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xC516A0", Offset = "0xC506A0", VA = "0x180C516A0")]
	public static bool JLLIFBNBAKK<T>(this T DCLMHANFEGK, T KICLNADFIEK) where T : struct, BCAIPGNNKGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x24E2590", Offset = "0x24E1590", VA = "0x1824E2590")]
	public static bool DOFAOAHKOHP<T>(this T DCLMHANFEGK) where T : struct, BCAIPGNNKGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF20", Offset = "0x5FB9F20", VA = "0x185FBAF20")]
	public static string LNHCBGDCJLG(this BCAIPGNNKGO DCLMHANFEGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class GJJNDNKNJJM
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum HIOHMNDHFJF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int NHBPPIHNEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool MJIOMEDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private HIOHMNDHFJF IDIIBDOHICE;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool BCIDCKMIEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC6E0", Offset = "0x5FBB6E0", VA = "0x185FBC6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool DPPKLEOANBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCBD0", Offset = "0x5FBBBD0", VA = "0x185FBCBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD560", Offset = "0x5FBC560", VA = "0x185FBD560")]
	public GJJNDNKNJJM(bool MJIOMEDLNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCBE0", Offset = "0x5FBBBE0", VA = "0x185FBCBE0")]
	public void LKLLINMODCO(object GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD310", Offset = "0x5FBC310", VA = "0x185FBD310")]
	public void NLGBIDBHMLG(int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC700", Offset = "0x5FBB700", VA = "0x185FBC700")]
	public void IJLCNLGMLDB(uint HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCA80", Offset = "0x5FBBA80", VA = "0x185FBCA80")]
	public void IMLACJKGPOL(bool NFPPBMLGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD2D0", Offset = "0x5FBC2D0", VA = "0x185FBD2D0")]
	public void NFEAOOMNCNB(long MKOHADONNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD4B0", Offset = "0x5FBC4B0", VA = "0x185FBD4B0")]
	public void PAIAFHLMODJ(ulong NEEHGLOEKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC670", Offset = "0x5FBB670", VA = "0x185FBC670")]
	public void CHJJFAFCBLE(string HCJLPANMOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD420", Offset = "0x5FBC420", VA = "0x185FBD420")]
	public void OMMNHNMGOIO(Enum PBDFKDHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCAA0", Offset = "0x5FBBAA0", VA = "0x185FBCAA0")]
	public void IMMGFPEMBGM(IList DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2259AA0", Offset = "0x2258AA0", VA = "0x182259AA0")]
	public void HKEAMHCDBEN<T, U>(Dictionary<T, U> JOFBGDIJCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC710", Offset = "0x5FBB710", VA = "0x185FBC710")]
	private void IKJIOKNFHLF(IDictionary JOFBGDIJCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD4F0", Offset = "0x5FBC4F0", VA = "0x185FBD4F0")]
	public int PFKCFNOJPFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD3B0", Offset = "0x5FBC3B0", VA = "0x185FBD3B0")]
	public short NMPNIHGJMEK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC6F0", Offset = "0x5FBB6F0", VA = "0x185FBC6F0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD260", Offset = "0x5FBC260", VA = "0x185FBD260")]
	private void MMGAKIBPGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class HAGJIMABILE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class FFPAFLPFDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode BLHHJNENDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode ICMEPOIJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GCAIKFILGPD KKBMLPHFFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<GCAIKFILGPD> EGOAIMIKMNF;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public FFPAFLPFDCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct GCAIKFILGPD : IComparable<GCAIKFILGPD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int BBCHOGHICAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant AFAEPPFLPJF;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6A90B0", Offset = "0x6A80B0", VA = "0x1806A90B0")]
		public GCAIKFILGPD(int BBCHOGHICAO, TClaimant AFAEPPFLPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x39E5A60", Offset = "0x39E4A60", VA = "0x1839E5A60")]
		public bool GGHOIPJFMFL(in GCAIKFILGPD KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x39E5AC0", Offset = "0x39E4AC0", VA = "0x1839E5AC0")]
		public bool POAHHAPMNPG(in GCAIKFILGPD KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x39E5A50", Offset = "0x39E4A50", VA = "0x1839E5A50", Slot = "4")]
		public int CompareTo(GCAIKFILGPD KICLNADFIEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x39E5AD0", Offset = "0x39E4AD0", VA = "0x1839E5AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum JDCBBGEIMGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class PPMJEGCJBCF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::HAGJIMABILE<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F3B0", Offset = "0x1E2E3B0", VA = "0x181E2F3B0")]
		[DebuggerHidden]
		public PPMJEGCJBCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D760", Offset = "0x2D9C760", VA = "0x182D9D760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D920", Offset = "0x2D9C920", VA = "0x182D9D920", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D840", Offset = "0x2D9C840", VA = "0x182D9D840", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2455BF0", Offset = "0x2454BF0", VA = "0x182455BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::GDKLBHINFJL<FFPAFLPFDCL> BGCAJHDEECK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::GDKLBHINFJL<List<GCAIKFILGPD>> HPJJIDJFMGH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int PKMCOLDKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> NAHPHGPEFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, FFPAFLPFDCL> CNOJJLJOLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private JDCBBGEIMGI HOEJODOFJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EKMEMACGALM(TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void ONCPJLDEGAD(TNode ABKPGPJAFGM, TClaimant MKLBCGGLLIB, TClaimant CLOJHMHPHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x317C730", Offset = "0x317B730", VA = "0x18317C730")]
	public HAGJIMABILE(JDCBBGEIMGI HOEJODOFJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x317C270", Offset = "0x317B270", VA = "0x18317C270")]
	public void LLNIIHNOMHA(TNode ABKPGPJAFGM, TNode LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x317BF50", Offset = "0x317AF50", VA = "0x18317BF50")]
	public void JHDMLMCOAFF(TClaimant AFAEPPFLPJF, TNode ABMPDDKOOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x317B710", Offset = "0x317A710", VA = "0x18317B710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x317BEB0", Offset = "0x317AEB0", VA = "0x18317BEB0")]
	private void IBFGONJICPL(TClaimant AFAEPPFLPJF, TNode IAHHHLBKAGO, TNode ABMPDDKOOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x317B6B0", Offset = "0x317A6B0", VA = "0x18317B6B0")]
	private int DIJJINCEEBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x317AFE0", Offset = "0x3179FE0", VA = "0x18317AFE0")]
	private void AIGGOGKCPKM(TClaimant AFAEPPFLPJF, TNode MFEAABGOOLB, TNode OLFCKPDOOKF, int KOOIKJAFDHK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x317C050", Offset = "0x317B050", VA = "0x18317C050")]
	private void KIOGMGLCNDM(GCAIKFILGPD GIHEIABIDBA, FFPAFLPFDCL GGCLNKGONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x317B290", Offset = "0x317A290", VA = "0x18317B290")]
	private void BCJBCJFGCHF(TClaimant AFAEPPFLPJF, TNode MFEAABGOOLB, TNode OLFCKPDOOKF, int KOOIKJAFDHK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x317BDA0", Offset = "0x317ADA0", VA = "0x18317BDA0")]
	private void IAJIAAGPBKA(GCAIKFILGPD GIHEIABIDBA, TNode ABKPGPJAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x317C2F0", Offset = "0x317B2F0", VA = "0x18317C2F0")]
	private void NJIHJPMPLCF(GCAIKFILGPD GIHEIABIDBA, FFPAFLPFDCL GGCLNKGONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x317C3F0", Offset = "0x317B3F0", VA = "0x18317C3F0")]
	private void PHLCDBGJIJM(FFPAFLPFDCL GGCLNKGONMF, bool DELEFHPFPEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x317BA30", Offset = "0x317AA30", VA = "0x18317BA30")]
	private void HHPPAKOEDEP(FFPAFLPFDCL GGCLNKGONMF, TNode LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x317C500", Offset = "0x317B500", VA = "0x18317C500")]
	[IteratorStateMachine(typeof(global::HAGJIMABILE<, >.PPMJEGCJBCF))]
	private IEnumerable<TNode> PMJPPFCPJDP(TNode MFEAABGOOLB, TNode OLFCKPDOOKF, bool GCCIPPCJFBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x317B970", Offset = "0x317A970", VA = "0x18317B970")]
	private FFPAFLPFDCL GBBMEONDHPK(TNode ABKPGPJAFGM, TNode ICMEPOIJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x317C0E0", Offset = "0x317B0E0", VA = "0x18317C0E0")]
	private FFPAFLPFDCL LLCDMJGKHFN(TNode ABKPGPJAFGM, TNode ICMEPOIJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x317B4F0", Offset = "0x317A4F0", VA = "0x18317B4F0")]
	private void BHDJHFNJODJ(FFPAFLPFDCL GGCLNKGONMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class GGMOAHGJIJD<T> : IEnumerable<global::GGMOAHGJIJD<T>.BOGCLLBCKAJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct BOGCLLBCKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T DFEOJBAFBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int NPDGHPHAKDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class BLAMBBBAKIE : IEnumerator<BOGCLLBCKAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::GGMOAHGJIJD<T> LLHCHDMLAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int NPDGHPHAKDK;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x13D6570", Offset = "0x13D5570", VA = "0x1813D6570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public BOGCLLBCKAJ JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x41D58B0", Offset = "0x41D48B0", VA = "0x1841D58B0", Slot = "4")]
			get
			{
				return default(BOGCLLBCKAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x682060", Offset = "0x681060", VA = "0x180682060")]
		public BLAMBBBAKIE(global::GGMOAHGJIJD<T> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x41D5830", Offset = "0x41D4830", VA = "0x1841D5830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x682050", Offset = "0x681050", VA = "0x180682050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xBA2320", Offset = "0xBA1320", VA = "0x180BA2320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct GFKOHILIKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool JGKMKPHAIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T DFEOJBAFBHE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int ILPGNPICNKJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> DEDDDIPEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private GFKOHILIKME[] EPDKIAILIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int EBDCDFEFBGC;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int PCDCDCNEAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x69ED90", Offset = "0x69DD90", VA = "0x18069ED90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8139D0", Offset = "0x8129D0", VA = "0x1808139D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1E22CE0", Offset = "0x1E21CE0", VA = "0x181E22CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2848310", Offset = "0x2847310", VA = "0x182848310")]
	public GGMOAHGJIJD(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2847B30", Offset = "0x2846B30", VA = "0x182847B30")]
	public GGMOAHGJIJD(BOGCLLBCKAJ[] EABPBDHKJJC, bool MNMIDHFIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2847370", Offset = "0x2846370", VA = "0x182847370")]
	public int HGFENCIFCFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2846880", Offset = "0x2845880", VA = "0x182846880")]
	private int ANGPJBGMIFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x28474B0", Offset = "0x28464B0", VA = "0x1828474B0", Slot = "6")]
	protected virtual uint KOOFGGDDHII(uint NHBPPIHNEOH, T DFEOJBAFBHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2846AB0", Offset = "0x2845AB0", VA = "0x182846AB0")]
	public bool CBNAAKOFFOO(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2847430", Offset = "0x2846430", VA = "0x182847430")]
	public bool HNGHDKPCOGD(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x28471F0", Offset = "0x28461F0", VA = "0x1828471F0")]
	public bool HGEFFBLNLHD(Func<T, bool> DBADFKHLJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2847520", Offset = "0x2846520", VA = "0x182847520")]
	public int LABEIDIDGOE(T DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2847580", Offset = "0x2846580", VA = "0x182847580")]
	public T NAGKGPCIBKK(int NPDGHPHAKDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2846E90", Offset = "0x2845E90", VA = "0x182846E90")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2847870", Offset = "0x2846870", VA = "0x182847870")]
	public bool PICFJGOPDMI(T DFEOJBAFBHE, bool PCCLFNCBDBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2847670", Offset = "0x2846670", VA = "0x182847670")]
	public bool PICFJGOPDMI(T DFEOJBAFBHE, int NPDGHPHAKDK, bool PCCLFNCBDBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2846F90", Offset = "0x2845F90", VA = "0x182846F90")]
	public bool FAHLDBEBGON(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2846DA0", Offset = "0x2845DA0", VA = "0x182846DA0")]
	public bool CCGFPBPKEDH(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2847100", Offset = "0x2846100", VA = "0x182847100")]
	private void FKCAFOAMPCI(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2846AF0", Offset = "0x2845AF0", VA = "0x182846AF0")]
	public BOGCLLBCKAJ[] CCDPKGMDNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2846DF0", Offset = "0x2845DF0", VA = "0x182846DF0")]
	private int DPBPFLDDAGG(int JHOHOEJNFBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2847AB0", Offset = "0x2846AB0", VA = "0x182847AB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2847AB0", Offset = "0x2846AB0", VA = "0x182847AB0", Slot = "4")]
	private IEnumerator<BOGCLLBCKAJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BOJMANGKCAI<Handle> where Handle : BCAIPGNNKGO, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct CIOJGEMBPKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::BOJMANGKCAI<Handle> OCHEBLLDOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int NPDGHPHAKDK;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int IBNJNCPFKDH
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0460", Offset = "0x3EAF460", VA = "0x183EB0460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle CDACAOKDPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0F60", Offset = "0x3EAFF60", VA = "0x183EB0F60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x36CA340", Offset = "0x36C9340", VA = "0x1836CA340")]
		public CIOJGEMBPKA(global::BOJMANGKCAI<Handle> OCHEBLLDOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x36C9EE0", Offset = "0x36C8EE0", VA = "0x1836C9EE0")]
		public FPLHIBPGMEF DHGKFEMNGCO(in FPLHIBPGMEF GJBHFPJIHBB)
		{
			return default(FPLHIBPGMEF);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x36C9F80", Offset = "0x36C8F80", VA = "0x1836C9F80")]
		public HKHIGBLCMNB DHGKFEMNGCO(in HKHIGBLCMNB GJBHFPJIHBB)
		{
			return default(HKHIGBLCMNB);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0850", Offset = "0x3EAF850", VA = "0x183EB0850")]
		public bool GGDHMJEBLDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0BB0", Offset = "0x3EAFBB0", VA = "0x183EB0BB0")]
		private int JDBFPFJDLCF(string LMLMHJKGDCH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x3EB07B0", Offset = "0x3EAF7B0", VA = "0x183EB07B0")]
		private Handle FGLKOMLMLGL(string LMLMHJKGDCH)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct FPLHIBPGMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private CIOJGEMBPKA MDKELAAILKF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x289C410", Offset = "0x289B410", VA = "0x18289C410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x289C5D0", Offset = "0x289B5D0", VA = "0x18289C5D0")]
		public FPLHIBPGMEF(global::BOJMANGKCAI<Handle> OCHEBLLDOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x289C450", Offset = "0x289B450", VA = "0x18289C450")]
		public bool GGDHMJEBLDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x289C550", Offset = "0x289B550", VA = "0x18289C550")]
		public FPLHIBPGMEF HPPJKDPBNFG()
		{
			return default(FPLHIBPGMEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct HKHIGBLCMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private CIOJGEMBPKA MDKELAAILKF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2E45620", Offset = "0x2E44620", VA = "0x182E45620")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x289C5D0", Offset = "0x289B5D0", VA = "0x18289C5D0")]
		public HKHIGBLCMNB(global::BOJMANGKCAI<Handle> OCHEBLLDOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x289C450", Offset = "0x289B450", VA = "0x18289C450")]
		public bool GGDHMJEBLDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2E456E0", Offset = "0x2E446E0", VA = "0x182E456E0")]
		public HKHIGBLCMNB HPPJKDPBNFG()
		{
			return default(HKHIGBLCMNB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> OIOHKJMDOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> FINENEBMGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int OPEEFEMGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int IHHCHHAKLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool BCKANAMNCJA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x240DFB0", Offset = "0x240CFB0", VA = "0x18240DFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int POIJALBHBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x67E010", Offset = "0x67D010", VA = "0x18067E010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FONEHMJPKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x67E010", Offset = "0x67D010", VA = "0x18067E010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public FPLHIBPGMEF JFJIIAFIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x240EC70", Offset = "0x240DC70", VA = "0x18240EC70")]
		get
		{
			return default(FPLHIBPGMEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HKHIGBLCMNB JLKMFALGJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x240EE90", Offset = "0x240DE90", VA = "0x18240EE90")]
		get
		{
			return default(HKHIGBLCMNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2412640", Offset = "0x2411640", VA = "0x182412640")]
	public BOJMANGKCAI(int EILLENDCLPG, Allocator AEPJLHDIHPH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x24104A0", Offset = "0x240F4A0", VA = "0x1824104A0")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x240F0D0", Offset = "0x240E0D0", VA = "0x18240F0D0")]
	public static int EOPJBIGFFMC(int BGLBBPFJJCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x240F0C0", Offset = "0x240E0C0", VA = "0x18240F0C0")]
	public static bool EEEOLFMLPON(int BGLBBPFJJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x240F3A0", Offset = "0x240E3A0", VA = "0x18240F3A0")]
	public static bool JBGMGPDFNHO(int BGLBBPFJJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2411C20", Offset = "0x2410C20", VA = "0x182411C20")]
	public bool ONBOGFLLBFO(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2411F80", Offset = "0x2410F80", VA = "0x182411F80")]
	public bool PBKJDLPJFDE(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2411860", Offset = "0x2410860", VA = "0x182411860")]
	public bool OGOOEALLGCK(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x240E030", Offset = "0x240D030", VA = "0x18240E030")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BIHEFNCICKH(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2410620", Offset = "0x240F620", VA = "0x182410620")]
	public Handle KMHFGGKEJDD()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x240FBB0", Offset = "0x240EBB0", VA = "0x18240FBB0")]
	public void JJAPGPLEGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x240F4B0", Offset = "0x240E4B0", VA = "0x18240F4B0")]
	public void JIHCMGJBFDG(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x240F0E0", Offset = "0x240E0E0", VA = "0x18240F0E0")]
	public bool GGNKKLMPHJB(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DF80", VA = "0x18076EF80")]
	private bool ONCLHNOJHIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x240ED10", Offset = "0x240DD10", VA = "0x18240ED10")]
	private bool DKFONKEBBMA(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2411070", Offset = "0x2410070", VA = "0x182411070")]
	private void MGIAMGLLLMB(out int NPDGHPHAKDK, out int IIJDDKBOPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x24111E0", Offset = "0x24101E0", VA = "0x1824111E0")]
	private void OAKAOHEGFJK(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2410230", Offset = "0x240F230", VA = "0x182410230")]
	private void JLNPDKAGPCJ(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2410AC0", Offset = "0x240FAC0", VA = "0x182410AC0")]
	private bool MCPEJGMMILF(out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x240F020", Offset = "0x240E020", VA = "0x18240F020")]
	private static Handle EDCKEGHBLOJ(int NPDGHPHAKDK, int IIJDDKBOPLN)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct AOPGFFKJFJG<Handle, T> where Handle : BCAIPGNNKGO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::BOJMANGKCAI<Handle> EKHMPFOOOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] IFKDFNCPIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> GHDICMHAJOO;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2F93BB0", Offset = "0x2F92BB0", VA = "0x182F93BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2F90B30", Offset = "0x2F8FB30", VA = "0x182F90B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2F90D20", Offset = "0x2F8FD20", VA = "0x182F90D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2F916D0", Offset = "0x2F906D0", VA = "0x182F916D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2F93CE0", Offset = "0x2F92CE0", VA = "0x182F93CE0")]
	public AOPGFFKJFJG(int EILLENDCLPG, [Optional] Action<T> GHDICMHAJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2F92F20", Offset = "0x2F91F20", VA = "0x182F92F20")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2F93B60", Offset = "0x2F92B60", VA = "0x182F93B60")]
	public bool OGOOEALLGCK(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BIHEFNCICKH(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2F90D50", Offset = "0x2F8FD50", VA = "0x182F90D50")]
	public T CIGAFCHFFML(Handle DCLMHANFEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2F93280", Offset = "0x2F92280", VA = "0x182F93280")]
	public bool MDMOKHFDALA(Handle DCLMHANFEGK, out T GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2F92270", Offset = "0x2F91270", VA = "0x182F92270")]
	public void FAFPJPFNCCD(Handle DCLMHANFEGK, T BDHNGFEHAEC, out T PEEAFOHPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2F92150", Offset = "0x2F91150", VA = "0x182F92150")]
	public void FAFPJPFNCCD(Handle DCLMHANFEGK, T BDHNGFEHAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2F91C70", Offset = "0x2F90C70", VA = "0x182F91C70")]
	public bool EIHINOPMEGD(Handle DCLMHANFEGK, T BDHNGFEHAEC, out T PEEAFOHPBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2F918B0", Offset = "0x2F908B0", VA = "0x182F918B0")]
	public bool EIHINOPMEGD(Handle DCLMHANFEGK, T BDHNGFEHAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2F92D00", Offset = "0x2F91D00", VA = "0x182F92D00")]
	public Handle HMNAIPBHJIK(T GKCPJCKCENH)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2F91040", Offset = "0x2F90040", VA = "0x182F91040")]
	public void DDCLDBCGDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2F92720", Offset = "0x2F91720", VA = "0x182F92720")]
	public void FAHLDBEBGON(Handle DCLMHANFEGK, out T PEEAFOHPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2F924B0", Offset = "0x2F914B0", VA = "0x182F924B0")]
	public void FAHLDBEBGON(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2F938B0", Offset = "0x2F928B0", VA = "0x182F938B0")]
	public bool NLMLMECNDCH(Handle DCLMHANFEGK, out T PEEAFOHPBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2F937D0", Offset = "0x2F927D0", VA = "0x182F937D0")]
	public bool NLMLMECNDCH(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2F90CC0", Offset = "0x2F8FCC0", VA = "0x182F90CC0")]
	private T CCGFPBPKEDH(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2F90BF0", Offset = "0x2F8FBF0", VA = "0x182F90BF0")]
	private void AGBJIBCDJKP(int IEGDCAKJBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class GDKLBHINFJL<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> OCHEBLLDOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> PIDPDCBGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int INEHFFCGIBJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CHAHMNGCELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2005780", Offset = "0x2004780", VA = "0x182005780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int HGPJECKDMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1E34DA0", Offset = "0x1E33DA0", VA = "0x181E34DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x39E82D0", Offset = "0x39E72D0", VA = "0x1839E82D0")]
	public static global::GDKLBHINFJL<T> GOMMDIKPAKI(int CIMAPKKBLKM = 0, int INEHFFCGIBJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x39E8630", Offset = "0x39E7630", VA = "0x1839E8630")]
	public static global::GDKLBHINFJL<T> PDDIHHPAEGM(int CIMAPKKBLKM = 0, int INEHFFCGIBJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x39E8700", Offset = "0x39E7700", VA = "0x1839E8700")]
	public GDKLBHINFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x39E8740", Offset = "0x39E7740", VA = "0x1839E8740")]
	public GDKLBHINFJL(int CIMAPKKBLKM, int INEHFFCGIBJ = int.MaxValue, bool KENKJMOBMOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x39E81C0", Offset = "0x39E71C0", VA = "0x1839E81C0")]
	public T FDGDPBGFHNH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x39E84F0", Offset = "0x39E74F0", VA = "0x1839E84F0")]
	public void MCFEKKLCLLO(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x39E8420", Offset = "0x39E7420", VA = "0x1839E8420")]
	private void JOBMLJOKCPH(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x39E7F10", Offset = "0x39E6F10", VA = "0x1839E7F10")]
	private void DAMNEEKNKHK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x39E83A0", Offset = "0x39E73A0", VA = "0x1839E83A0")]
	[Conditional("DEBUG_BUILD")]
	private void JCJPHJNAILP(T MFDBEKACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x39E85A0", Offset = "0x39E75A0", VA = "0x1839E85A0")]
	[Conditional("DEBUG_BUILD")]
	private void OILJLNNLCOB(T MFDBEKACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x39E80D0", Offset = "0x39E70D0", VA = "0x1839E80D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x39E7F30", Offset = "0x39E6F30", VA = "0x1839E7F30")]
	private void DIGFIKBBDEL(IEnumerable<T> GPJMEADJCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class CAFMOANLKFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> HEFFNNIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T KCGNLOFCJMH;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T DHEAEOAFAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x69E140", Offset = "0x69D140", VA = "0x18069E140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LIHICEFPCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x29BE500", Offset = "0x29BD500", VA = "0x1829BE500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x29BEC20", Offset = "0x29BDC20", VA = "0x1829BEC20")]
	public bool PAGNFDLBLPI(T DFEOJBAFBHE, int BBCHOGHICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x29BEB60", Offset = "0x29BDB60", VA = "0x1829BEB60")]
	public bool JFPCPHHFBIN(int BBCHOGHICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x29BE970", Offset = "0x29BD970", VA = "0x1829BE970")]
	public T HOIIGIAMKMP(int DMMLPGHJNOD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x29BE6E0", Offset = "0x29BD6E0", VA = "0x1829BE6E0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x29BE650", Offset = "0x29BD650", VA = "0x1829BE650")]
	private bool DILCFEOGGNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x29BE740", Offset = "0x29BD740", VA = "0x1829BE740")]
	public bool HADOILGNPLN(int BBCHOGHICAO, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x29BEC80", Offset = "0x29BDC80", VA = "0x1829BEC80")]
	public CAFMOANLKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class DOBMNJODFFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct OMBMHCNMJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int IMPMIBBFHDB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<OMBMHCNMJDE> IMNHEMNOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T MDHFJBNDLLJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1E22CE0", Offset = "0x1E21CE0", VA = "0x181E22CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x28DD700", Offset = "0x28DC700", VA = "0x1828DD700")]
	public bool HGEFFBLNLHD(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x28DD910", Offset = "0x28DC910", VA = "0x1828DD910")]
	public void HMNAIPBHJIK(T DFEOJBAFBHE, int BBCHOGHICAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x28DD5E0", Offset = "0x28DC5E0", VA = "0x1828DD5E0")]
	public bool FAHLDBEBGON(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x28DD580", Offset = "0x28DC580", VA = "0x1828DD580")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x28DDB70", Offset = "0x28DCB70", VA = "0x1828DDB70")]
	public T OIPGIFJHBLJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x28DDBE0", Offset = "0x28DCBE0", VA = "0x1828DDBE0")]
	public T PEFELEHEIIP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x28DD9B0", Offset = "0x28DC9B0", VA = "0x1828DD9B0")]
	private void LNOOMCBAEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x28DDC50", Offset = "0x28DCC50", VA = "0x1828DDC50")]
	public DOBMNJODFFG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0440", Offset = "0x5FBF440", VA = "0x185FC0440")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5FC07D0", Offset = "0x5FBF7D0", VA = "0x185FC07D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0650", Offset = "0x5FBF650", VA = "0x185FC0650")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0930", Offset = "0x5FBF930", VA = "0x185FC0930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0360", Offset = "0x5FBF360", VA = "0x185FC0360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5FC06F0", Offset = "0x5FBF6F0", VA = "0x185FC06F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5FC0570", Offset = "0x5FBF570", VA = "0x185FC0570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0310", Offset = "0x5FBF310", VA = "0x185FC0310")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface EJILIECFOPD
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : EJILIECFOPD where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BF55A0", Offset = "0x2BF45A0", VA = "0x182BF55A0", Slot = "4")]
		public virtual T OFNGKJJFMNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class NILLHBHCDMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, GDJDOLMHIKP> NNOEPDCOBBH;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GDJDOLMHIKP PKMPJDOJICD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x69E130", Offset = "0x69D130", VA = "0x18069E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GJMNKFLMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C10050", Offset = "0x1C0F050", VA = "0x181C10050")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CD0", Offset = "0x6C6CD0", VA = "0x1806C7CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 CNAGDMFLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1F19230", Offset = "0x1F18230", VA = "0x181F19230")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xFE6B60", Offset = "0xFE5B60", VA = "0x180FE6B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 MDHDOAHHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF6D0", Offset = "0x5FBE6D0", VA = "0x185FBF6D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xE50520", Offset = "0xE4F520", VA = "0x180E50520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int IPOHPCGLPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x67E0E0", Offset = "0x67D0E0", VA = "0x18067E0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E5640", Offset = "0x6E4640", VA = "0x1806E5640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFC70", Offset = "0x5FBEC70", VA = "0x185FBFC70")]
	public NILLHBHCDMM(Bounds MLPDBGEJDGD, Vector2[] BJEBGAMAIGH, int ONBMOMMDMAC, byte JHOHOEJNFBB, float PBCPKBHELHB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF6F0", Offset = "0x5FBE6F0", VA = "0x185FBF6F0")]
	public GDJDOLMHIKP GAGMOJEEHKD(byte NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF750", Offset = "0x5FBE750", VA = "0x185FBF750")]
	public void GANKGIAKJDP(Vector3 IJBELJOFGFA, float POKACKNENPM, float PJEHEEGEBPO, ref List<byte> COLDHDIMPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF850", Offset = "0x5FBE850", VA = "0x185FBF850")]
	public void ILOGPBDIHME(GDJDOLMHIKP.DLKDOODJJHF KAHLOPILKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF570", Offset = "0x5FBE570", VA = "0x185FBF570")]
	private GDJDOLMHIKP CPOGNLJFLJA(byte NPDGHPHAKDK, GDJDOLMHIKP.BFIOHNJJALI EMOOKJAHNFG, GDJDOLMHIKP ICMEPOIJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF870", Offset = "0x5FBE870", VA = "0x185FBF870")]
	private void JFPMBCGMHCF(GDJDOLMHIKP ICMEPOIJCJO, Vector2[] BJEBGAMAIGH, int FKJCCNIBGOI, int PGOAADFBHDM, int OMPHMPHINMI, int GADNOEADAHN, float PBCPKBHELHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class GDJDOLMHIKP
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum BFIOHNJJALI
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum DLKDOODJJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public byte OIMEPCKLHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 HNOHDNLONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 FGDMPDNAJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 GJPDODFKMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 MHPNGHKBMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public BFIOHNJJALI FJHFHNBPOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public GDJDOLMHIKP JAGJOAIDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<GDJDOLMHIKP> BBKHPAPGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool JDFECHBFKDB;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC240", Offset = "0x5FBB240", VA = "0x185FBC240")]
	public GDJDOLMHIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC1E0", Offset = "0x5FBB1E0", VA = "0x185FBC1E0")]
	public GDJDOLMHIKP(byte KCHLIHHPAKF, BFIOHNJJALI EMOOKJAHNFG, GDJDOLMHIKP ICMEPOIJCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC0D0", Offset = "0x5FBB0D0", VA = "0x185FBC0D0")]
	public void HLPNFHFHFFD(GDJDOLMHIKP ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public void ILOGPBDIHME(int AKDHDKELPJA, DLKDOODJJHF KAHLOPILKKD, int MBNPAAJIBGL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBE20", Offset = "0x5FBAE20", VA = "0x185FBBE20")]
	public void GANKGIAKJDP(List<byte> COLDHDIMPGE, Vector3 IJBELJOFGFA, float POKACKNENPM, float PJEHEEGEBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC190", Offset = "0x5FBB190", VA = "0x185FBC190")]
	public bool PFNFGCBENJD(Vector3 LMABBBKCION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBDE0", Offset = "0x5FBADE0", VA = "0x185FBBDE0")]
	public bool DFNELGKGFPO(Vector3 LMABBBKCION, float JPINNKECINB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class EHNJCDNGBMO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> PHPKGHDKIGM;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2005280", Offset = "0x2004280", VA = "0x182005280")]
	public bool FCKPKFIKHKN(T HFIAEBCEENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x20052B0", Offset = "0x20042B0", VA = "0x1820052B0")]
	public bool FCKPKFIKHKN(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x20052F0", Offset = "0x20042F0", VA = "0x1820052F0")]
	public bool FCKPKFIKHKN(T HFIAEBCEENB, object KCCFEDJJGAN, out object MFOCOHFHAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2005420", Offset = "0x2004420", VA = "0x182005420")]
	public bool PCKJKADFNHP(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2005240", Offset = "0x2004240", VA = "0x182005240")]
	public bool AOPJDILKCCN(T HFIAEBCEENB, object KCCFEDJJGAN, out object MFOCOHFHAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2005460", Offset = "0x2004460", VA = "0x182005460")]
	public bool PCKJKADFNHP(T HFIAEBCEENB, object KCCFEDJJGAN, out object MFOCOHFHAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2005350", Offset = "0x2004350", VA = "0x182005350")]
	public void HNHIKLLNOGI(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2005380", Offset = "0x2004380", VA = "0x182005380")]
	public void OLCHOBGJECE(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x20054F0", Offset = "0x20044F0", VA = "0x1820054F0")]
	public EHNJCDNGBMO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct ENHELGDMBCM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool BKEBANKBFBE;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x848BE0", Offset = "0x847BE0", VA = "0x180848BE0")]
			public ENHELGDMBCM(List<Component> DEEJEKFIHBB, bool BKEBANKBFBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2012950", Offset = "0x2011950", VA = "0x182012950")]
			public DMFHKEKDNCJ<T> HPPJKDPBNFG()
			{
				return default(DMFHKEKDNCJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x20129C0", Offset = "0x20119C0", VA = "0x1820129C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x20129C0", Offset = "0x20119C0", VA = "0x1820129C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct DMFHKEKDNCJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool BKEBANKBFBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int NPDGHPHAKDK;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T JLIFGAJEJIJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x28DAE60", Offset = "0x28D9E60", VA = "0x1828DAE60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x28DADF0", Offset = "0x28D9DF0", VA = "0x1828DADF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x28DAE30", Offset = "0x28D9E30", VA = "0x1828DAE30")]
			public DMFHKEKDNCJ(List<Component> DEEJEKFIHBB, bool BKEBANKBFBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x28DAD30", Offset = "0x28D9D30", VA = "0x1828DAD30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x28DAD40", Offset = "0x28D9D40", VA = "0x1828DAD40", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2859EA0", Offset = "0x2858EA0", VA = "0x182859EA0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x5FC2680", Offset = "0x5FC1680", VA = "0x185FC2680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2640", Offset = "0x5FC1640", VA = "0x185FC2640")]
		public ToolHierarchyCache(GameObject JLMCLCAPEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2050", Offset = "0x5FC1050", VA = "0x185FC2050")]
		private void NAGCBALDEME(GameObject JLMCLCAPEFE, bool PAKHNBOHLFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC21B0", Offset = "0x5FC11B0", VA = "0x185FC21B0")]
		public static void NAGCBALDEME(GameObject JLMCLCAPEFE, ref ToolHierarchyCache KEJPIFGMADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1E70", Offset = "0x5FC0E70", VA = "0x185FC1E70")]
		public void GFBDCONMNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2570", Offset = "0x5FC1570", VA = "0x185FC2570")]
		public void PHMALINLNIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x343D640", Offset = "0x343C640", VA = "0x18343D640")]
		public void PNPCGIKFEKI<T>(Action<T> KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1F00", Offset = "0x5FC0F00", VA = "0x185FC1F00")]
		public Component LKLGPHJLPGH(Type IGEIBCJNCHF, bool BKEBANKBFBE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x343D4F0", Offset = "0x343C4F0", VA = "0x18343D4F0")]
		public T LKLGPHJLPGH<T>(bool BKEBANKBFBE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1FD0", Offset = "0x5FC0FD0", VA = "0x185FC1FD0")]
		public ENHELGDMBCM<Component> MOAIHJDGBHJ(Type IGEIBCJNCHF, bool BKEBANKBFBE = false)
		{
			return default(ENHELGDMBCM<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x343D570", Offset = "0x343C570", VA = "0x18343D570")]
		public ENHELGDMBCM<T> MOAIHJDGBHJ<T>(bool BKEBANKBFBE = false) where T : class
		{
			return default(ENHELGDMBCM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2240", Offset = "0x5FC1240", VA = "0x185FC2240")]
		public List<Component> NMBNENDJGMA(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1DF0", Offset = "0x5FC0DF0", VA = "0x185FC1DF0", Slot = "4")]
		public bool Equals(ToolHierarchyCache JMDPDGBMGAA, ToolHierarchyCache GKDCJKNJEID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1E80", Offset = "0x5FC0E80", VA = "0x185FC1E80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GKCPJCKCENH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class KODOMBIHEOG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int CIMAPKKBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int MOHKPCELMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> FKFMFNKJNOH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2005780", Offset = "0x2004780", VA = "0x182005780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T DEAMFGIIJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D68840", Offset = "0x2D67840", VA = "0x182D68840")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DECJOHDIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D68560", Offset = "0x2D67560", VA = "0x182D68560")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T NCAHPGGLIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D684B0", Offset = "0x2D674B0", VA = "0x182D684B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D68A00", Offset = "0x2D67A00", VA = "0x182D68A00")]
	public KODOMBIHEOG(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D68640", Offset = "0x2D67640", VA = "0x182D68640")]
	public void HMNAIPBHJIK(T HHJBJIHEGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D68600", Offset = "0x2D67600", VA = "0x182D68600")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D68960", Offset = "0x2D67960", VA = "0x182D68960")]
	public void MIMDMHMKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D687F0", Offset = "0x2D677F0", VA = "0x182D687F0")]
	public void IIBHANJHHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2D68950", Offset = "0x2D67950", VA = "0x182D68950")]
	public void LDPCFHDJFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class GIJKPMPBNOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool IKCBJAJKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static GIJKPMPBNOM AHAINBALHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC4B0", Offset = "0x5FBB4B0", VA = "0x185FBC4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MIHBCEKGEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x682250", Offset = "0x681250", VA = "0x180682250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xBA2280", Offset = "0xBA1280", VA = "0x180BA2280")]
	public GIJKPMPBNOM(Action KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC490", Offset = "0x5FBB490", VA = "0x185FBC490")]
	public void NNHOADFEBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC490", Offset = "0x5FBB490", VA = "0x185FBC490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class EPJJMMBLBNG
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB7D0", Offset = "0x5FBA7D0", VA = "0x185FBB7D0")]
	public static void DGJDPPPHDAI(ILPPPAONIDE CICMPKOIDDD, string AGINFBGHHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void DGJDPPPHDAI(IEnumerable<object> BHBEGJLFINL, string AGINFBGHHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BGBABIIPLEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct ILHANJBJDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int IMPMIBBFHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T FBCEGMCNEND;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, ILHANJBJDFB> HEFFNNIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> OBNGNJGELAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T KCGNLOFCJMH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T DHEAEOAFAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xB99180", Offset = "0xB98180", VA = "0x180B99180", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x26B9590", Offset = "0x26B8590", VA = "0x1826B9590", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LIHICEFPCAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x28135B0", Offset = "0x28125B0", VA = "0x1828135B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object KGCHJOFBCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x716AE0", Offset = "0x715AE0", VA = "0x180716AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2814D50", Offset = "0x2813D50", VA = "0x182814D50")]
	public bool PAGNFDLBLPI(T DFEOJBAFBHE, object KCCFEDJJGAN, int BBCHOGHICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2814A50", Offset = "0x2813A50", VA = "0x182814A50")]
	public bool JFPCPHHFBIN(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x28149E0", Offset = "0x28139E0", VA = "0x1828149E0")]
	public bool HADOILGNPLN(object KCCFEDJJGAN, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2005C10", Offset = "0x2004C10", VA = "0x182005C10")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x375F9E0", Offset = "0x375E9E0", VA = "0x18375F9E0")]
	private bool DILCFEOGGNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2814E30", Offset = "0x2813E30", VA = "0x182814E30")]
	public BGBABIIPLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class HMPFAJJPMIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> HEFFNNIBIBN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float CDHLGCKGACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x10998C0", Offset = "0x10988C0", VA = "0x1810998C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xD74020", Offset = "0xD73020", VA = "0x180D74020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDC00", Offset = "0x5FBCC00", VA = "0x185FBDC00")]
	public void PAGNFDLBLPI(float DFEOJBAFBHE, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDB90", Offset = "0x5FBCB90", VA = "0x185FBDB90")]
	public void JFPCPHHFBIN(object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDA70", Offset = "0x5FBCA70", VA = "0x185FBDA70")]
	private void BBKOLOOHJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDC70", Offset = "0x5FBCC70", VA = "0x185FBDC70")]
	public HMPFAJJPMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class HPDGKDBFFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string BIKMAPNDGFC;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
	public HPDGKDBFFPK(string JLPHNMPIALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDD40", Offset = "0x5FBCD40", VA = "0x185FBDD40")]
	public HPDGKDBFFPK(UnityEngine.Object MIFBFGFOODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDCF0", Offset = "0x5FBCCF0", VA = "0x185FBDCF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class ILPPPAONIDE
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class CINJJBOHHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CINJJBOHHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAE70", Offset = "0x5FB9E70", VA = "0x185FBAE70")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> BHBEGJLFINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int ICCKNLNJPLL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> EGKGPIFPHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE230", Offset = "0x5FBD230", VA = "0x185FBE230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MMFCMIFFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE030", Offset = "0x5FBD030", VA = "0x185FBE030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE140", Offset = "0x5FBD140", VA = "0x185FBE140")]
	public bool HMNAIPBHJIK(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE040", Offset = "0x5FBD040", VA = "0x185FBE040")]
	public bool FAHLDBEBGON(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE0E0", Offset = "0x5FBD0E0", VA = "0x185FBE0E0")]
	public bool HGEFFBLNLHD(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDFC0", Offset = "0x5FBCFC0", VA = "0x185FBDFC0")]
	public void ADCILDKHDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE300", Offset = "0x5FBD300", VA = "0x185FBE300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public ILPPPAONIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class PFINOCCENEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct MMIODFFFGIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float PGLDLDAMIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T FBCEGMCNEND;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, MMIODFFFGIO> HEFFNNIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T ADKMANMMEGC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T AJPEAJLONCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1140320", Offset = "0x113F320", VA = "0x181140320", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x16FD4E0", Offset = "0x16FC4E0", VA = "0x1816FD4E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object LLLMCNBOGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x716AE0", Offset = "0x715AE0", VA = "0x180716AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LIHICEFPCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x34689F0", Offset = "0x34679F0", VA = "0x1834689F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x346A680", Offset = "0x3469680", VA = "0x18346A680")]
	public bool PAGNFDLBLPI(T DFEOJBAFBHE, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x346A300", Offset = "0x3469300", VA = "0x18346A300")]
	public bool JFPCPHHFBIN(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2005C10", Offset = "0x2004C10", VA = "0x182005C10")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x346A150", Offset = "0x3469150", VA = "0x18346A150")]
	public bool HADOILGNPLN(object KCCFEDJJGAN, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3468D50", Offset = "0x3467D50", VA = "0x183468D50")]
	private bool DILCFEOGGNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x346A930", Offset = "0x3469930", VA = "0x18346A930")]
	public PFINOCCENEE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEBB0", Offset = "0x5FBDBB0", VA = "0x185FBEBB0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE860", Offset = "0x5FBD860", VA = "0x185FBE860")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
