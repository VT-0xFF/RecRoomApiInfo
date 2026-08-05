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
public class DDMGFAGFCKI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	public DDMGFAGFCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, FCPHMKKNAOD, CAKADHOHIKD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MNONHEHGNJF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
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
	[DGNHMCLGJOI]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[DGNHMCLGJOI]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6486E40", Offset = "0x6485640", VA = "0x186486E40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6486E00", Offset = "0x6485600", VA = "0x186486E00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6486E80", Offset = "0x6485680", VA = "0x186486E80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6487050", Offset = "0x6485850", VA = "0x186487050")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6486FC0", Offset = "0x64857C0", VA = "0x186486FC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x118F400", Offset = "0x118DC00", VA = "0x18118F400")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1145040", Offset = "0x1143840", VA = "0x181145040")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6486DC0", Offset = "0x64855C0", VA = "0x186486DC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6486F30", Offset = "0x6485730", VA = "0x186486F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6486800", Offset = "0x6485000", VA = "0x186486800")]
	public void CopyBounds(SavedExtents HAKPJJGEGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6486D20", Offset = "0x6485520", VA = "0x186486D20")]
	public void SetLocalSpaceBounds(Bounds ECNHKDFDGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1484600", Offset = "0x1482E00", VA = "0x181484600")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6486D10", Offset = "0x6485510", VA = "0x186486D10")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64868F0", Offset = "0x64850F0", VA = "0x1864868F0")]
	private void ILHDDHIANCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6486AE0", Offset = "0x64852E0", VA = "0x186486AE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64861C0", Offset = "0x64849C0", VA = "0x1864861C0")]
	public static void CalculateLocalBoundsFor(GameObject IMPKIJJJHKI, out Bounds ECNHKDFDGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6486830", Offset = "0x6485030", VA = "0x186486830")]
	private static void FIHPFIPOLLI(Bounds JBKIIGINOKM, Color FCOOKAEOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6486D40", Offset = "0x6485540", VA = "0x186486D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F30", Offset = "0x6F4730", VA = "0x1806F5F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xFCF9A0", Offset = "0xFCE1A0", VA = "0x180FCF9A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA91820", Offset = "0xA90020", VA = "0x180A91820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "4")]
	public virtual void DPOBEPMBPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
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
	[DDMGFAGFCKI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43548E0", Offset = "0x43530E0", VA = "0x1843548E0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4354010", Offset = "0x4352810", VA = "0x184354010", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4354E20", Offset = "0x4353620", VA = "0x184354E20")]
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
	private sealed class MFEENLAFJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public MFEENLAFJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0FC0", Offset = "0x2DAF7C0", VA = "0x182DB0FC0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DDMGFAGFCKI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x149BD80", Offset = "0x149A580", VA = "0x18149BD80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x149BDB0", Offset = "0x149A5B0", VA = "0x18149BDB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x149BCD0", Offset = "0x149A4D0", VA = "0x18149BCD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey NHBANLNJEIH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x149BD30", Offset = "0x149A530", VA = "0x18149BD30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x149BBD0", Offset = "0x149A3D0", VA = "0x18149BBD0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x149B720", Offset = "0x1499F20", VA = "0x18149B720", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x149AF40", Offset = "0x1499740", VA = "0x18149AF40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x149ABF0", Offset = "0x14993F0", VA = "0x18149ABF0", Slot = "14")]
	protected virtual string HCEMLEAHLDD(TKeyVal PBBAEBKCOHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x149AAD0", Offset = "0x14992D0", VA = "0x18149AAD0", Slot = "4")]
	public bool ContainsKey(TKey NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x149BAC0", Offset = "0x149A2C0", VA = "0x18149BAC0", Slot = "5")]
	public bool TryGetValue(TKey NHBANLNJEIH, out TVal NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x149AB00", Offset = "0x1499300", VA = "0x18149AB00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x149AB00", Offset = "0x1499300", VA = "0x18149AB00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x149BAF0", Offset = "0x149A2F0", VA = "0x18149BAF0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EKOKDGONHLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OHFHMEEBAIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public OHFHMEEBAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x31F3030", Offset = "0x31F1830", VA = "0x1831F3030")]
		internal bool <GetSamples>b__0(global::JLNALEJLLLA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float EIKKPKLAAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float MNFJGHBNMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::JLNALEJLLLA<float, T>> PFIFFBGJHBC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GOGCIPKKPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32C0830", Offset = "0x32BF030", VA = "0x1832C0830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x32C0CC0", Offset = "0x32BF4C0", VA = "0x1832C0CC0")]
	public EKOKDGONHLB(float HPFLLGCAMDE, float FIFJIIDNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32C08B0", Offset = "0x32BF0B0", VA = "0x1832C08B0")]
	public bool EKNDEFBNPJA(float ILJBLEGFDIO, T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32C0B70", Offset = "0x32BF370", VA = "0x1832C0B70")]
	public int HLMGLONANDG(float ILJBLEGFDIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32C0470", Offset = "0x32BEC70", VA = "0x1832C0470")]
	public IEnumerable<T> APMFEPIOAGF(float ILJBLEGFDIO, [Optional] float? KFJBEDAJNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x32C0C90", Offset = "0x32BF490", VA = "0x1832C0C90")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x32C0BD0", Offset = "0x32BF3D0", VA = "0x1832C0BD0")]
	private void MAEBKNBDKAM(float ILJBLEGFDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class EFGHCCNJFEG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NIMFFOCIMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T PPNOOBBHMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float BJPKJKFHFAB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float HBMNGLNHJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> PKCPMJEMCMF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int HJACEMKKCPJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NIMFFOCIMAK[] CIMBPHJAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int HOEOMOPHICO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float EADFPOIFLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDD98A0", Offset = "0xDD80A0", VA = "0x180DD98A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDD98B0", Offset = "0xDD80B0", VA = "0x180DD98B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x32AE080", Offset = "0x32AC880", VA = "0x1832AE080")]
	public EFGHCCNJFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x32AE0B0", Offset = "0x32AC8B0", VA = "0x1832AE0B0")]
	public EFGHCCNJFEG(int GIGKIGNPJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x32ACD70", Offset = "0x32AB570", VA = "0x1832ACD70")]
	public void LGCDELLOPGJ(float ILJBLEGFDIO, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x32AD6C0", Offset = "0x32ABEC0", VA = "0x1832AD6C0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x32ACE50", Offset = "0x32AB650", VA = "0x1832ACE50")]
	public bool LKFPMHPFLAH(float DMNOELPOJOF, float OBOPMEEOJLK, out T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32AD970", Offset = "0x32AC170", VA = "0x1832AD970")]
	public bool MMMJEBFLBKH(float DMNOELPOJOF, float OBOPMEEOJLK, out T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x32ADDD0", Offset = "0x32AC5D0", VA = "0x1832ADDD0")]
	public void PAEKGLHDLPA(float DMNOELPOJOF, float OBOPMEEOJLK, List<T> DNLJJNDPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x32ADC90", Offset = "0x32AC490", VA = "0x1832ADC90")]
	private int MNJJFBDECCJ(int HKFLFFDILHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x32AD3E0", Offset = "0x32ABBE0", VA = "0x1832AD3E0")]
	private void MAGDMGJGDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GOCCNPFNPGE();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ODHLPMHMIEO(T EHDPPFDCEJK, T NPIMFLIIAHF, float KFEBAJCAAOE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DDNHBOFCIDM(T NPHADDCNBHE, float KFEBAJCAAOE);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EDKDNIODHEF(T EHDPPFDCEJK, T NPIMFLIIAHF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T DIAPCHAJDFL(T EHDPPFDCEJK, T NPIMFLIIAHF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BNIAEAFBENI : global::EFGHCCNJFEG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x104D8B0", Offset = "0x104C0B0", VA = "0x18104D8B0", Slot = "4")]
	protected override Vector3 GOCCNPFNPGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1BCCF70", Offset = "0x1BCB770", VA = "0x181BCCF70", Slot = "5")]
	protected override Vector3 ODHLPMHMIEO(Vector3 EHDPPFDCEJK, Vector3 NPIMFLIIAHF, float KFEBAJCAAOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x647FE20", Offset = "0x647E620", VA = "0x18647FE20", Slot = "6")]
	protected override Vector3 DDNHBOFCIDM(Vector3 NPHADDCNBHE, float KFEBAJCAAOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x647FEF0", Offset = "0x647E6F0", VA = "0x18647FEF0", Slot = "7")]
	protected override Vector3 EDKDNIODHEF(Vector3 EHDPPFDCEJK, Vector3 NPIMFLIIAHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x647FE80", Offset = "0x647E680", VA = "0x18647FE80", Slot = "8")]
	protected override Vector3 DIAPCHAJDFL(Vector3 EHDPPFDCEJK, Vector3 NPIMFLIIAHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x647FF70", Offset = "0x647E770", VA = "0x18647FF70")]
	public BNIAEAFBENI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PHJIPAODBIB : global::EFGHCCNJFEG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6485150", Offset = "0x6483950", VA = "0x186485150")]
	public PHJIPAODBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64850E0", Offset = "0x64838E0", VA = "0x1864850E0")]
	public PHJIPAODBIB(int GIGKIGNPJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x116C6B0", Offset = "0x116AEB0", VA = "0x18116C6B0", Slot = "4")]
	protected override float GOCCNPFNPGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3A58E00", Offset = "0x3A57600", VA = "0x183A58E00", Slot = "5")]
	protected override float ODHLPMHMIEO(float EHDPPFDCEJK, float NPIMFLIIAHF, float KFEBAJCAAOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x52D8600", Offset = "0x52D6E00", VA = "0x1852D8600", Slot = "6")]
	protected override float DDNHBOFCIDM(float NPHADDCNBHE, float KFEBAJCAAOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30AB2F0", Offset = "0x30A9AF0", VA = "0x1830AB2F0", Slot = "7")]
	protected override float EDKDNIODHEF(float EHDPPFDCEJK, float NPIMFLIIAHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x64850D0", Offset = "0x64838D0", VA = "0x1864850D0", Slot = "8")]
	protected override float DIAPCHAJDFL(float EHDPPFDCEJK, float NPIMFLIIAHF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AEDBIJBFABH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x17F2E00", Offset = "0x17F1600", VA = "0x1817F2E00")]
	public static global::PFDKBIMNFKG<T1> OJONNLHFKNA<T1>(T1 LJFBPNBJABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x17F2890", Offset = "0x17F1090", VA = "0x1817F2890")]
	public static global::JLNALEJLLLA<T1, T2> OJONNLHFKNA<T1, T2>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x17F2900", Offset = "0x17F1100", VA = "0x1817F2900")]
	public static global::OPBPJJABAEG<T1, T2, T3> OJONNLHFKNA<T1, T2, T3>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x17F2C70", Offset = "0x17F1470", VA = "0x1817F2C70")]
	public static global::ACFNALDIOKN<T1, T2, T3, T4> OJONNLHFKNA<T1, T2, T3, T4>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x17F2BD0", Offset = "0x17F13D0", VA = "0x1817F2BD0")]
	public static global::LAJMMAMHDCO<T1, T2, T3, T4, T5> OJONNLHFKNA<T1, T2, T3, T4, T5>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x17F2B20", Offset = "0x17F1320", VA = "0x1817F2B20")]
	public static global::PBGDKFPPJKG<T1, T2, T3, T4, T5, T6> OJONNLHFKNA<T1, T2, T3, T4, T5, T6>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE, T6 HPAPNODEEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x17F2A60", Offset = "0x17F1260", VA = "0x1817F2A60")]
	public static global::HLMCLHKIBKF<T1, T2, T3, T4, T5, T6, T7> OJONNLHFKNA<T1, T2, T3, T4, T5, T6, T7>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE, T6 HPAPNODEEDI, T7 FGJFDNICFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x17F2990", Offset = "0x17F1190", VA = "0x1817F2990")]
	public static global::PFNLCPFJPMB<T1, T2, T3, T4, T5, T6, T7, T8> OJONNLHFKNA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE, T6 HPAPNODEEDI, T7 FGJFDNICFMJ, T8 LOJKPCMLMBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x17F27F0", Offset = "0x17F0FF0", VA = "0x1817F27F0")]
	[IteratorStateMachine(typeof(LIEAOCLFIIK))]
	public static IEnumerable<global::JLNALEJLLLA<T1, T2>> CDGEODIFNIN<T1, T2>(IEnumerable<T1> HDPOKDCLGGE, IEnumerable<T2> JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x17F2730", Offset = "0x17F0F30", VA = "0x1817F2730")]
	[IteratorStateMachine(typeof(OHKAIAPKGGG))]
	public static IEnumerable<global::OPBPJJABAEG<T1, T2, T3>> CDGEODIFNIN<T1, T2, T3>(IEnumerable<T1> HDPOKDCLGGE, IEnumerable<T2> JBKIIGINOKM, IEnumerable<T3> FCOOKAEOJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x870E90", Offset = "0x86F690", VA = "0x180870E90")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x870E60", Offset = "0x86F660", VA = "0x180870E60")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD, int EABMDOLMJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x870E40", Offset = "0x86F640", VA = "0x180870E40")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD, int EABMDOLMJEM, int LHDLOAFNMPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x870E70", Offset = "0x86F670", VA = "0x180870E70")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD, int EABMDOLMJEM, int LHDLOAFNMPM, int INICEBHHFHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x647DF10", Offset = "0x647C710", VA = "0x18647DF10")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD, int EABMDOLMJEM, int LHDLOAFNMPM, int INICEBHHFHJ, int GEHIOPBOLHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x647DF30", Offset = "0x647C730", VA = "0x18647DF30")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD, int EABMDOLMJEM, int LHDLOAFNMPM, int INICEBHHFHJ, int GEHIOPBOLHP, int BAONFHLKKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x647DEE0", Offset = "0x647C6E0", VA = "0x18647DEE0")]
	internal static int NKKGKFLHEHJ(int IIKKPNCKKBD, int OEHDDHLBLFD, int EABMDOLMJEM, int LHDLOAFNMPM, int INICEBHHFHJ, int GEHIOPBOLHP, int BAONFHLKKEK, int JIHKGLOMEGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PFDKBIMNFKG<T1> : IComparable<global::PFDKBIMNFKG<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
	public PFDKBIMNFKG(T1 LJFBPNBJABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B550", Offset = "0x2F09D50", VA = "0x182F0B550", Slot = "4")]
	public int CompareTo(global::PFDKBIMNFKG<T1> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B5C0", Offset = "0x2F09DC0", VA = "0x182F0B5C0", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x921470", Offset = "0x91FC70", VA = "0x180921470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B660", Offset = "0x2F09E60", VA = "0x182F0B660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JLNALEJLLLA<T1, T2> : IComparable<global::JLNALEJLLLA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25B15C0", Offset = "0x25AFDC0", VA = "0x1825B15C0")]
	public JLNALEJLLLA(T1 LJFBPNBJABB, T2 ADBPHNKNNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x25AF830", Offset = "0x25AE030", VA = "0x1825AF830", Slot = "4")]
	public int CompareTo(global::JLNALEJLLLA<T1, T2> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25AFF90", Offset = "0x25AE790", VA = "0x1825AFF90", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25B0380", Offset = "0x25AEB80", VA = "0x1825B0380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x25B0A70", Offset = "0x25AF270", VA = "0x1825B0A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OPBPJJABAEG<T1, T2, T3> : IComparable<global::OPBPJJABAEG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 NGLAEAMFOGJ;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x35757C0", Offset = "0x3573FC0", VA = "0x1835757C0")]
	public OPBPJJABAEG(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3574FB0", Offset = "0x35737B0", VA = "0x183574FB0", Slot = "4")]
	public int CompareTo(global::OPBPJJABAEG<T1, T2, T3> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x35751B0", Offset = "0x35739B0", VA = "0x1835751B0", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x35754A0", Offset = "0x3573CA0", VA = "0x1835754A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3575610", Offset = "0x3573E10", VA = "0x183575610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ACFNALDIOKN<T1, T2, T3, T4> : IComparable<global::ACFNALDIOKN<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 NGLAEAMFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 DJGGPCBMDGO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2623060", Offset = "0x2621860", VA = "0x182623060")]
	public ACFNALDIOKN(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26F8720", Offset = "0x26F6F20", VA = "0x1826F8720", Slot = "4")]
	public int CompareTo(global::ACFNALDIOKN<T1, T2, T3, T4> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26F8860", Offset = "0x26F7060", VA = "0x1826F8860", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26F8980", Offset = "0x26F7180", VA = "0x1826F8980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x26F8A40", Offset = "0x26F7240", VA = "0x1826F8A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LAJMMAMHDCO<T1, T2, T3, T4, T5> : IComparable<global::LAJMMAMHDCO<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 NGLAEAMFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 DJGGPCBMDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 FPLDOIJMOBO;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F500", Offset = "0x1C5DD00", VA = "0x181C5F500")]
	public LAJMMAMHDCO(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5EFF0", Offset = "0x1C5D7F0", VA = "0x181C5EFF0", Slot = "4")]
	public int CompareTo(global::LAJMMAMHDCO<T1, T2, T3, T4, T5> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F170", Offset = "0x1C5D970", VA = "0x181C5F170", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F2B0", Offset = "0x1C5DAB0", VA = "0x181C5F2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F3B0", Offset = "0x1C5DBB0", VA = "0x181C5F3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PBGDKFPPJKG<T1, T2, T3, T4, T5, T6> : IComparable<global::PBGDKFPPJKG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 NGLAEAMFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 DJGGPCBMDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 FPLDOIJMOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 JPOPOIBIPDL;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2F06C40", Offset = "0x2F05440", VA = "0x182F06C40")]
	public PBGDKFPPJKG(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE, T6 HPAPNODEEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F06680", Offset = "0x2F04E80", VA = "0x182F06680", Slot = "4")]
	public int CompareTo(global::PBGDKFPPJKG<T1, T2, T3, T4, T5, T6> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F06840", Offset = "0x2F05040", VA = "0x182F06840", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F069B0", Offset = "0x2F051B0", VA = "0x182F069B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2F06AD0", Offset = "0x2F052D0", VA = "0x182F06AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HLMCLHKIBKF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::HLMCLHKIBKF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 NGLAEAMFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 DJGGPCBMDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 FPLDOIJMOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 JPOPOIBIPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 BCOPNKLCOHO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39F06C0", Offset = "0x39EEEC0", VA = "0x1839F06C0")]
	public HLMCLHKIBKF(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE, T6 HPAPNODEEDI, T7 FGJFDNICFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39F0040", Offset = "0x39EE840", VA = "0x1839F0040", Slot = "4")]
	public int CompareTo(global::HLMCLHKIBKF<T1, T2, T3, T4, T5, T6, T7> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39F0240", Offset = "0x39EEA40", VA = "0x1839F0240", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39F03E0", Offset = "0x39EEBE0", VA = "0x1839F03E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39F0530", Offset = "0x39EED30", VA = "0x1839F0530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PFNLCPFJPMB<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::PFNLCPFJPMB<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 KGBLNJFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 HPIFEGGHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 NGLAEAMFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 DJGGPCBMDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 FPLDOIJMOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 JPOPOIBIPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 BCOPNKLCOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 BKBIGFBIIAM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2F108D0", Offset = "0x2F0F0D0", VA = "0x182F108D0")]
	public PFNLCPFJPMB(T1 LJFBPNBJABB, T2 ADBPHNKNNGF, T3 PNNLJNEPEGF, T4 CMHKELBBIBG, T5 PCCEIEBMFHE, T6 HPAPNODEEDI, T7 FGJFDNICFMJ, T8 LOJKPCMLMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F101A0", Offset = "0x2F0E9A0", VA = "0x182F101A0", Slot = "4")]
	public int CompareTo(global::PFNLCPFJPMB<T1, T2, T3, T4, T5, T6, T7, T8> HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F103F0", Offset = "0x2F0EBF0", VA = "0x182F103F0", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F105B0", Offset = "0x2F0EDB0", VA = "0x182F105B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F10720", Offset = "0x2F0EF20", VA = "0x182F10720", Slot = "3")]
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
	public T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x25AAD70", Offset = "0x25A9570", VA = "0x1825AAD70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8B00", Offset = "0x3FD7300", VA = "0x183FD8B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float HGCBFGNBPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xF423A0", Offset = "0xF40BA0", VA = "0x180F423A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8BC0", Offset = "0x3FD73C0", VA = "0x183FD8BC0")]
	public T DCFBHHEGKCP(float KFEBAJCAAOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8F90", Offset = "0x3FD7790", VA = "0x183FD8F90")]
	public T FGOOJMLCHEM(float KFEBAJCAAOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ODHLPMHMIEO(T EHDPPFDCEJK, T NPIMFLIIAHF, float KFEBAJCAAOE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A58E00", Offset = "0x3A57600", VA = "0x183A58E00", Slot = "4")]
	protected override float ODHLPMHMIEO(float EHDPPFDCEJK, float NPIMFLIIAHF, float KFEBAJCAAOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6480F70", Offset = "0x647F770", VA = "0x186480F70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1BCCF70", Offset = "0x1BCB770", VA = "0x181BCCF70", Slot = "4")]
	protected override Vector3 ODHLPMHMIEO(Vector3 EHDPPFDCEJK, Vector3 NPIMFLIIAHF, float KFEBAJCAAOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6488000", Offset = "0x6486800", VA = "0x186488000")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6480A80", Offset = "0x647F280", VA = "0x186480A80", Slot = "4")]
	protected override Color ODHLPMHMIEO(Color EHDPPFDCEJK, Color NPIMFLIIAHF, float KFEBAJCAAOE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6480AD0", Offset = "0x647F2D0", VA = "0x186480AD0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NBDHKHOBDLO : global::CILOHBCIGJO<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6481F70", Offset = "0x6480770", VA = "0x186481F70")]
	public NBDHKHOBDLO(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6481F10", Offset = "0x6480710", VA = "0x186481F10")]
	public NBDHKHOBDLO(GBIBFOAKJHH[] EMOPCAELCKI, bool PKDIIHJAKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6481EA0", Offset = "0x64806A0", VA = "0x186481EA0", Slot = "6")]
	protected override uint PDCGPFJCAKJ(uint MNONHEHGNJF, string NPHADDCNBHE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AFHFAKDHMHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public AFHFAKDHMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CALFMHLLPOH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HBICBDECLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public HBICBDECLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x364DE00", Offset = "0x364C600", VA = "0x18364DE00")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PLDAKALPIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int ANKFEJJAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int HDHCHMIBJMI;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xC21E90", Offset = "0xC20690", VA = "0x180C21E90")]
	private CALFMHLLPOH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GMIBHMEPOLN, int PIMOHEJJOGN, int GLGBEAFMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28BCC10", Offset = "0x28BB410", VA = "0x1828BCC10")]
	public static global::CALFMHLLPOH<T> HHEHBEMBBBF()
	{
		return default(global::CALFMHLLPOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28BD210", Offset = "0x28BBA10", VA = "0x1828BD210")]
	public (int, int, Task<T>) PLIHJKPOFFD(int PGFCNIKGMKP, [Optional] CancellationToken DIEJHKIAFPL, double GEINLHGIKPG = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x28BCD00", Offset = "0x28BB500", VA = "0x1828BCD00")]
	public void MCGAKDCEEAB(int PGFCNIKGMKP, int GLGBEAFMMEG, in T KGFIMLECODA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DGDLNGBHKMH
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6480B10", Offset = "0x647F310", VA = "0x186480B10")]
	public static global::CALFMHLLPOH<HKDLOMPDCOH> HHEHBEMBBBF()
	{
		return default(global::CALFMHLLPOH<HKDLOMPDCOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6480B60", Offset = "0x647F360", VA = "0x186480B60")]
	public static void MCGAKDCEEAB(this in global::CALFMHLLPOH<HKDLOMPDCOH> DCJNPPINKOA, int PGFCNIKGMKP, int GLGBEAFMMEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class DEGHBPDIOJB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> HCFJHLGDICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> GLLBMCNOLBO;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x17FF070", Offset = "0x17FD870", VA = "0x1817FF070", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> LDOHNILHBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x259CC80", Offset = "0x259B480", VA = "0x18259CC80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NEOBFKOCKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2997F40", Offset = "0x2996740", VA = "0x182997F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A86420", Offset = "0x3A84C20", VA = "0x183A86420", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A86460", Offset = "0x3A84C60", VA = "0x183A86460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A86180", Offset = "0x3A84980", VA = "0x183A86180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A85750", Offset = "0x3A83F50", VA = "0x183A85750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A85460", Offset = "0x3A83C60", VA = "0x183A85460", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A86250", Offset = "0x3A84A50", VA = "0x183A86250", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A85270", Offset = "0x3A83A70", VA = "0x183A85270", Slot = "9")]
	public void Add(TKey NHBANLNJEIH, TVal NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A85230", Offset = "0x3A83A30", VA = "0x183A85230", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A854C0", Offset = "0x3A83CC0", VA = "0x183A854C0", Slot = "8")]
	public bool ContainsKey(TKey NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A854F0", Offset = "0x3A83CF0", VA = "0x183A854F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A861C0", Offset = "0x3A849C0", VA = "0x183A861C0", Slot = "10")]
	public bool Remove(TKey NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A861F0", Offset = "0x3A849F0", VA = "0x183A861F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26F9A20", Offset = "0x26F8220", VA = "0x1826F9A20", Slot = "11")]
	public bool TryGetValue(TKey NHBANLNJEIH, out TVal NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x28D19D0", Offset = "0x28D01D0", VA = "0x1828D19D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A85550", Offset = "0x3A83D50", VA = "0x183A85550", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A85F50", Offset = "0x3A84750", VA = "0x183A85F50")]
	public void LGCDELLOPGJ(TVal EAPKDOJGNBJ, TKey NHBANLNJEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A85F90", Offset = "0x3A84790", VA = "0x183A85F90")]
	public void LGCDELLOPGJ(KeyValuePair<TVal, TKey> FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A855E0", Offset = "0x3A83DE0", VA = "0x183A855E0")]
	public bool FABHEPOAOEC(TVal NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A85800", Offset = "0x3A84000", VA = "0x183A85800")]
	public bool JEBNAOILLLF(KeyValuePair<TVal, TKey> FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A85160", Offset = "0x3A83960", VA = "0x183A85160")]
	public bool ALIFOBNBCOA(TVal NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A85160", Offset = "0x3A83960", VA = "0x183A85160")]
	public bool ALIFOBNBCOA(KeyValuePair<TVal, TKey> FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A85620", Offset = "0x3A83E20", VA = "0x183A85620")]
	public bool FEEDILOKHNP(TVal NHBANLNJEIH, out TKey NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A860C0", Offset = "0x3A848C0", VA = "0x183A860C0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> LIDFOPJFLKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A85870", Offset = "0x3A84070", VA = "0x183A85870")]
	private void KOMKMMNGMDK(TKey NHBANLNJEIH, TVal EAPKDOJGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A853C0", Offset = "0x3A83BC0", VA = "0x183A853C0")]
	private void CKAJPMGIAKJ(TKey NHBANLNJEIH, TVal EAPKDOJGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A85BC0", Offset = "0x3A843C0", VA = "0x183A85BC0")]
	private bool LELMLBOJMBP(TKey NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A85A20", Offset = "0x3A84220", VA = "0x183A85A20")]
	private bool LELMLBOJMBP(TVal EAPKDOJGNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A86340", Offset = "0x3A84B40", VA = "0x183A86340")]
	public DEGHBPDIOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class MLELHMEGIKO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::MLELHMEGIKO<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x317C1C0", Offset = "0x317A9C0", VA = "0x18317C1C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3142140", Offset = "0x3140940", VA = "0x183142140")]
		public Enumerator(global::MLELHMEGIKO<T> DNLJJNDPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x31797A0", Offset = "0x3177FA0", VA = "0x1831797A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x317B6F0", Offset = "0x3179EF0", VA = "0x18317B6F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3178B10", Offset = "0x3177310", VA = "0x183178B10")]
		private void DLFDBIOLEKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] GOEABKOLGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int HCGAJDKMOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int CPNFMMNJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int OGPINCOPHCL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7BD0", Offset = "0x2FB63D0", VA = "0x182FB7BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2FB8410", Offset = "0x2FB6C10", VA = "0x182FB8410")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2FB7DE0", Offset = "0x2FB65E0", VA = "0x182FB7DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FB95D0", Offset = "0x2FB7DD0", VA = "0x182FB95D0")]
	public MLELHMEGIKO(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8200", Offset = "0x2FB6A00", VA = "0x182FB8200")]
	public void LGCDELLOPGJ(T KFEBAJCAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FB8D70", Offset = "0x2FB7570", VA = "0x182FB8D70")]
	public void OGMEKNCJPGN(IEnumerable<T> EGAOMEOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FB82C0", Offset = "0x2FB6AC0", VA = "0x182FB82C0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7D50", Offset = "0x2FB6550", VA = "0x182FB7D50")]
	public void HBJGFNBGCFM(int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7C10", Offset = "0x2FB6410", VA = "0x182FB7C10")]
	public void FGDFMJOKMJJ(int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7690", Offset = "0x2FB5E90", VA = "0x182FB7690")]
	public void ACOIELJIDEH(T[] CIMBPHJAHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7CA0", Offset = "0x2FB64A0", VA = "0x182FB7CA0")]
	public Enumerator GCCEKDHECEG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9450", Offset = "0x2FB7C50", VA = "0x182FB9450", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9450", Offset = "0x2FB7C50", VA = "0x182FB9450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9180", Offset = "0x2FB7980", VA = "0x182FB9180")]
	private int PJBLHHCLLAA(int LHHBOCAHDEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9060", Offset = "0x2FB7860", VA = "0x182FB9060")]
	private int OMAPIJEINPJ(int LHHBOCAHDEE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class DNIIODMFODN<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> PLIDKCANPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> JFMIKHFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> ILDIPGPCFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4A40", Offset = "0x2BC3240", VA = "0x182BC4A40", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4AE0", Offset = "0x2BC32E0", VA = "0x182BC4AE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BC49E0", Offset = "0x2BC31E0", VA = "0x182BC49E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA600", Offset = "0x2AF8E00", VA = "0x182AFA600")]
	public DNIIODMFODN(Func<Internal, External> PLIDKCANPFF, Func<External, Internal> JFMIKHFBGLM, bool DICFAHGJIHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4750", Offset = "0x2BC2F50", VA = "0x182BC4750", Slot = "6")]
	public int IndexOf(External FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2BC43D0", Offset = "0x2BC2BD0", VA = "0x182BC43D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4430", Offset = "0x2BC2C30", VA = "0x182BC4430", Slot = "13")]
	public bool Contains(External FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC44C0", Offset = "0x2BC2CC0", VA = "0x182BC44C0", Slot = "14")]
	public void CopyTo(External[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4340", Offset = "0x2BC2B40", VA = "0x182BC4340", Slot = "11")]
	public void Add(External FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4840", Offset = "0x2BC3040", VA = "0x182BC4840", Slot = "7")]
	public void Insert(int LHHBOCAHDEE, External FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4950", Offset = "0x2BC3150", VA = "0x182BC4950", Slot = "15")]
	public bool Remove(External FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC48E0", Offset = "0x2BC30E0", VA = "0x182BC48E0", Slot = "8")]
	public void RemoveAt(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC46E0", Offset = "0x2BC2EE0", VA = "0x182BC46E0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2700150", Offset = "0x26FE950", VA = "0x182700150", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class EEBNJEIAJNF<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> PLIDKCANPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> ILDIPGPCFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x32A5600", Offset = "0x32A3E00", VA = "0x1832A5600", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x32A55A0", Offset = "0x32A3DA0", VA = "0x1832A55A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
	public EEBNJEIAJNF(Func<Internal, External> PLIDKCANPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x32A5550", Offset = "0x32A3D50", VA = "0x1832A5550")]
	public EEBNJEIAJNF(IReadOnlyList<Internal> HGPMCGJIADE, Func<Internal, External> PLIDKCANPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x32A52C0", Offset = "0x32A3AC0", VA = "0x1832A52C0")]
	public void ACOIELJIDEH(External[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x32A54E0", Offset = "0x32A3CE0", VA = "0x1832A54E0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x261A270", Offset = "0x2618A70", VA = "0x18261A270", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class NMELFNIBJBI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> ILDIPGPCFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA160", Offset = "0x2AF8960", VA = "0x182AFA160", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA100", Offset = "0x2AF8900", VA = "0x182AFA100", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
	public NMELFNIBJBI(IReadOnlyList<Internal> HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA060", Offset = "0x2AF8860", VA = "0x182AFA060")]
	public bool JEBNAOILLLF(External FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9DC0", Offset = "0x2AF85C0", VA = "0x182AF9DC0")]
	public void ACOIELJIDEH(External[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9FF0", Offset = "0x2AF87F0", VA = "0x182AF9FF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2700150", Offset = "0x26FE950", VA = "0x182700150", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class EGBDEOJPEMF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PPAJIAOKFMD(object[] OBPCMKOMOOP);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected EGBDEOJPEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class GLFHAHIBOEC<T> : EGBDEOJPEMF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct MEFHLEEJFKP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum MMFHPHEOPPM
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
		public MMFHPHEOPPM EHPFPOFFCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T BEHJPKINPFB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int LLELHEKMKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool CBJNEAGGINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool DBKAHLKMHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> BOJHALLFPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<MEFHLEEJFKP> NENJDBFPKEP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BBCGGCLKLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2733790", Offset = "0x2731F90", VA = "0x182733790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2733B80", Offset = "0x2732380", VA = "0x182733B80")]
	protected GLFHAHIBOEC(bool DBKAHLKMHMM, bool CBJNEAGGINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x27337D0", Offset = "0x2731FD0", VA = "0x1827337D0")]
	protected bool KNACEPHLNOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2733AC0", Offset = "0x27322C0", VA = "0x182733AC0")]
	protected void NBGGKKMGACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x27335E0", Offset = "0x2731DE0", VA = "0x1827335E0")]
	protected void BBOJNEJCPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2A67900", Offset = "0x2A66100", VA = "0x182A67900")]
	private static void MDPNKMILNLD<U>(ref List<U> HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2733850", Offset = "0x2732050", VA = "0x182733850", Slot = "5")]
	public void LGCDELLOPGJ(T BEHJPKINPFB, bool MBIBPNDFCEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x27334A0", Offset = "0x2731CA0", VA = "0x1827334A0", Slot = "6")]
	public void ALIFOBNBCOA(T BEHJPKINPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x27339B0", Offset = "0x27321B0", VA = "0x1827339B0")]
	public void MMLFENDEPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FHBEMPALNLK
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class IFEOEDLAFMF : global::GLFHAHIBOEC<Action>, FHBEMPALNLK
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x64813E0", Offset = "0x647FBE0", VA = "0x1864813E0")]
	public IFEOEDLAFMF(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6481100", Offset = "0x647F900", VA = "0x186481100")]
	public void GGGAHLBBAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6481370", Offset = "0x647FB70", VA = "0x186481370", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64810A0", Offset = "0x647F8A0", VA = "0x1864810A0")]
	public static IFEOEDLAFMF EEMNIOEABIB(IFEOEDLAFMF GHMMIGIGJDL, Action BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6481310", Offset = "0x647FB10", VA = "0x186481310")]
	public static IFEOEDLAFMF GIAMMBAMJJM(IFEOEDLAFMF GHMMIGIGJDL, Action BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LCHOIDFBAMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action<T> BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action<T> BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CNOGLFLGNKP<T> : global::GLFHAHIBOEC<Action<T>>, global::LCHOIDFBAMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x272F900", Offset = "0x272E100", VA = "0x18272F900")]
	public CNOGLFLGNKP(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x30D0910", Offset = "0x30CF110", VA = "0x1830D0910")]
	public void GGGAHLBBAJC(T KFEBAJCAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x30D25C0", Offset = "0x30D0DC0", VA = "0x1830D25C0", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x30CF630", Offset = "0x30CDE30", VA = "0x1830CF630")]
	public static global::CNOGLFLGNKP<T> EEMNIOEABIB(global::CNOGLFLGNKP<T> GHMMIGIGJDL, Action<T> BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x30D1220", Offset = "0x30CFA20", VA = "0x1830D1220")]
	public static global::CNOGLFLGNKP<T> GIAMMBAMJJM(global::CNOGLFLGNKP<T> GHMMIGIGJDL, Action<T> BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OOOBPAACHEP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action<T, U> BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action<T, U> BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KPNCHACHCHE<T, U> : global::GLFHAHIBOEC<Action<T, U>>, global::OOOBPAACHEP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x272F900", Offset = "0x272E100", VA = "0x18272F900")]
	public KPNCHACHCHE(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FB90", Offset = "0x2A3E390", VA = "0x182A3FB90")]
	public void GGGAHLBBAJC(T KFEBAJCAAOE, U ADJKLOAELAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2A43ED0", Offset = "0x2A426D0", VA = "0x182A43ED0", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FAF0", Offset = "0x2A3E2F0", VA = "0x182A3FAF0")]
	public static global::KPNCHACHCHE<T, U> EEMNIOEABIB(global::KPNCHACHCHE<T, U> GHMMIGIGJDL, Action<T, U> BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2A42300", Offset = "0x2A40B00", VA = "0x182A42300")]
	public static global::KPNCHACHCHE<T, U> GIAMMBAMJJM(global::KPNCHACHCHE<T, U> GHMMIGIGJDL, Action<T, U> BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DMFDLKEPNBB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action<T, U, V> BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action<T, U, V> BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class NLJCKAEHOJE<T, U, V> : global::GLFHAHIBOEC<Action<T, U, V>>, global::DMFDLKEPNBB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x272F900", Offset = "0x272E100", VA = "0x18272F900")]
	public NLJCKAEHOJE(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2AF68E0", Offset = "0x2AF50E0", VA = "0x182AF68E0")]
	public void GGGAHLBBAJC(T KFEBAJCAAOE, U ADJKLOAELAL, V BKHPIBPDKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7660", Offset = "0x2AF5E60", VA = "0x182AF7660", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4A30", Offset = "0x2AF3230", VA = "0x182AF4A30")]
	public static global::NLJCKAEHOJE<T, U, V> EEMNIOEABIB(global::NLJCKAEHOJE<T, U, V> GHMMIGIGJDL, Action<T, U, V> BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6B40", Offset = "0x2AF5340", VA = "0x182AF6B40")]
	public static global::NLJCKAEHOJE<T, U, V> GIAMMBAMJJM(global::NLJCKAEHOJE<T, U, V> GHMMIGIGJDL, Action<T, U, V> BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DLPPKDHGLHJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action<T, U, V, W> BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action<T, U, V, W> BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class DDHKDKABNBG<T, U, V, W> : global::GLFHAHIBOEC<Action<T, U, V, W>>, global::DLPPKDHGLHJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x272F900", Offset = "0x272E100", VA = "0x18272F900")]
	public DDHKDKABNBG(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3A825E0", Offset = "0x3A80DE0", VA = "0x183A825E0")]
	public void GGGAHLBBAJC(T KFEBAJCAAOE, U ADJKLOAELAL, V BKHPIBPDKLA, W CBDPMHLACML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3A84770", Offset = "0x3A82F70", VA = "0x183A84770", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3A81F90", Offset = "0x3A80790", VA = "0x183A81F90")]
	public static global::DDHKDKABNBG<T, U, V, W> EEMNIOEABIB(global::DDHKDKABNBG<T, U, V, W> GHMMIGIGJDL, Action<T, U, V, W> BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3A83530", Offset = "0x3A81D30", VA = "0x183A83530")]
	public static global::DDHKDKABNBG<T, U, V, W> GIAMMBAMJJM(global::DDHKDKABNBG<T, U, V, W> GHMMIGIGJDL, Action<T, U, V, W> BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface ODGAHADHEMH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action<T, U, V, W, X> BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action<T, U, V, W, X> BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class GJBAJODPLII<T, U, V, W, X> : global::GLFHAHIBOEC<Action<T, U, V, W, X>>, global::ODGAHADHEMH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x272F900", Offset = "0x272E100", VA = "0x18272F900")]
	public GJBAJODPLII(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x272EC90", Offset = "0x272D490", VA = "0x18272EC90")]
	public void GGGAHLBBAJC(T KFEBAJCAAOE, U ADJKLOAELAL, V BKHPIBPDKLA, W CBDPMHLACML, X NGMFABJMIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x272F2F0", Offset = "0x272DAF0", VA = "0x18272F2F0", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x272EBF0", Offset = "0x272D3F0", VA = "0x18272EBF0")]
	public static global::GJBAJODPLII<T, U, V, W, X> EEMNIOEABIB(global::GJBAJODPLII<T, U, V, W, X> GHMMIGIGJDL, Action<T, U, V, W, X> BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x272F250", Offset = "0x272DA50", VA = "0x18272F250")]
	public static global::GJBAJODPLII<T, U, V, W, X> GIAMMBAMJJM(global::GJBAJODPLII<T, U, V, W, X> GHMMIGIGJDL, Action<T, U, V, W, X> BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GHLFLJENMMB<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCDELLOPGJ(Action<T, U, V, W, X, Y> BEHJPKINPFB, bool MBIBPNDFCEC = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALIFOBNBCOA(Action<T, U, V, W, X, Y> BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class AOODBBGCILM<T, U, V, W, X, Y> : global::GLFHAHIBOEC<Action<T, U, V, W, X, Y>>, global::GHLFLJENMMB<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x272F900", Offset = "0x272E100", VA = "0x18272F900")]
	public AOODBBGCILM(bool DBKAHLKMHMM = false, bool CBJNEAGGINF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3860", Offset = "0x2EA2060", VA = "0x182EA3860")]
	public void GGGAHLBBAJC(T KFEBAJCAAOE, U ADJKLOAELAL, V BKHPIBPDKLA, W CBDPMHLACML, X NGMFABJMIHP, Y OMDBFFDAOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4590", Offset = "0x2EA2D90", VA = "0x182EA4590", Slot = "4")]
	public override void PPAJIAOKFMD(object[] OBPCMKOMOOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3510", Offset = "0x2EA1D10", VA = "0x182EA3510")]
	public static global::AOODBBGCILM<T, U, V, W, X, Y> EEMNIOEABIB(global::AOODBBGCILM<T, U, V, W, X, Y> GHMMIGIGJDL, Action<T, U, V, W, X, Y> BEHJPKINPFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3E30", Offset = "0x2EA2630", VA = "0x182EA3E30")]
	public static global::AOODBBGCILM<T, U, V, W, X, Y> GIAMMBAMJJM(global::AOODBBGCILM<T, U, V, W, X, Y> GHMMIGIGJDL, Action<T, U, V, W, X, Y> BEHJPKINPFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class PHCIMBJCIEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct GAGACLHHEBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::PHCIMBJCIEF<T> CBEGLNKMLOP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T PPNOOBBHMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3786200", Offset = "0x3784A00", VA = "0x183786200")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3786220", Offset = "0x3784A20", VA = "0x183786220", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD70", Offset = "0x8AA570", VA = "0x1808ABD70")]
		public GAGACLHHEBC(global::PHCIMBJCIEF<T> CBEGLNKMLOP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct FGLEMBNNKFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<GAGACLHHEBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::PHCIMBJCIEF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2C77810", Offset = "0x2C76010", VA = "0x182C77810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1ED36B0", Offset = "0x1ED1EB0", VA = "0x181ED36B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BJCMJKPEKKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<GAGACLHHEBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::PHCIMBJCIEF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F7E0", Offset = "0x3D2DFE0", VA = "0x183D2F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1ED36B0", Offset = "0x1ED1EB0", VA = "0x181ED36B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim EHGAENAKDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T HCHJCGLJAKL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int BFEGMLNJLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2F12AB0", Offset = "0x2F112B0", VA = "0x182F12AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2F13140", Offset = "0x2F11940", VA = "0x182F13140")]
	public PHCIMBJCIEF(in T HCHJCGLJAKL, int DDAKJBKCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2F13070", Offset = "0x2F11870", VA = "0x182F13070")]
	public PHCIMBJCIEF(in T HCHJCGLJAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2F12A70", Offset = "0x2F11270", VA = "0x182F12A70")]
	public GAGACLHHEBC AACMAOMGFDD()
	{
		return default(GAGACLHHEBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2F12A30", Offset = "0x2F11230", VA = "0x182F12A30")]
	public GAGACLHHEBC AACMAOMGFDD(CancellationToken DIEJHKIAFPL)
	{
		return default(GAGACLHHEBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2F12F10", Offset = "0x2F11710", VA = "0x182F12F10")]
	[AsyncStateMachine(typeof(global::PHCIMBJCIEF<>.FGLEMBNNKFJ))]
	public Task<GAGACLHHEBC> PKHGEFLAJFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2F12C40", Offset = "0x2F11440", VA = "0x182F12C40")]
	[AsyncStateMachine(typeof(global::PHCIMBJCIEF<>.BJCMJKPEKKE))]
	public Task<GAGACLHHEBC> PKHGEFLAJFF(CancellationToken DIEJHKIAFPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MAPIADMEEJA
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6481AF0", Offset = "0x64802F0", VA = "0x186481AF0")]
	public static global::PHCIMBJCIEF<HKDLOMPDCOH> HHEHBEMBBBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6481B50", Offset = "0x6480350", VA = "0x186481B50")]
	public static global::PHCIMBJCIEF<HKDLOMPDCOH> HHEHBEMBBBF(int DDAKJBKCLDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x17F2E00", Offset = "0x17F1600", VA = "0x1817F2E00")]
	public static global::PHCIMBJCIEF<T> HHEHBEMBBBF<T>(in T HCHJCGLJAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24F3CE0", Offset = "0x24F24E0", VA = "0x1824F3CE0")]
	public static global::PHCIMBJCIEF<T> HHEHBEMBBBF<T>(in T HCHJCGLJAKL, int DDAKJBKCLDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CHLFPNDBOOG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> IJOOKJHJLJF(TRequest ODNHKCNDAKN, CancellationToken DIEJHKIAFPL);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum LGELFJCGGHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class CAGBJIOCDPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float EIDFAAJICIC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan MPKCDDBCOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int KIAECFNABLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LGELFJCGGHI GJPIGIGIPFK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly CAGBJIOCDPP KKHIANFEDKJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float LEHONFFBBFF
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3B8F4A0", Offset = "0x3B8DCA0", VA = "0x183B8F4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan FBHAGCKFFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3B8F660", Offset = "0x3B8DE60", VA = "0x183B8F660")]
		public CAGBJIOCDPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct HNOHAPODEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest ODNHKCNDAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken DIEJHKIAFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> MEHGOGHLHOM;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x324CA30", Offset = "0x324B230", VA = "0x18324CA30")]
		public HNOHAPODEMG(TRequest ODNHKCNDAKN, TaskCompletionSource<TResult> MEHGOGHLHOM, CancellationToken DIEJHKIAFPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CCPDPBNGFAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public CCPDPBNGFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x17FF070", Offset = "0x17FD870", VA = "0x1817FF070")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ENANLKLFEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::CHLFPNDBOOG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x14931D0", Offset = "0x14919D0", VA = "0x1814931D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct EKIJLAFENHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::CHLFPNDBOOG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HNOHAPODEMG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x32BADD0", Offset = "0x32B95D0", VA = "0x1832BADD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CDJIOBBPNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<HNOHAPODEMG> NOIHNILPAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CAGBJIOCDPP DCILAGGIJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IJOOKJHJLJF GKIHIBEKDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task KGNNLEGCHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BOPCPAHBHAO;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x28D0A30", Offset = "0x28CF230", VA = "0x1828D0A30")]
	public CHLFPNDBOOG(IJOOKJHJLJF GKIHIBEKDOI, [Optional] CAGBJIOCDPP DCILAGGIJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x28CFC00", Offset = "0x28CE400", VA = "0x1828CFC00")]
	public Task<TResult> NGOBNJLCPPF(TRequest ODNHKCNDAKN, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x28CFB70", Offset = "0x28CE370", VA = "0x1828CFB70")]
	private void NDAINJDCACH(HNOHAPODEMG MNDCCJDBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x28D0310", Offset = "0x28CEB10", VA = "0x1828D0310")]
	[AsyncStateMachine(typeof(global::CHLFPNDBOOG<, >.ENANLKLFEME))]
	private Task OEIEJOGFLAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x28CF330", Offset = "0x28CDB30", VA = "0x1828CF330")]
	private HNOHAPODEMG ELOFHGKBDPI()
	{
		return default(HNOHAPODEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x28CF1D0", Offset = "0x28CD9D0", VA = "0x1828CF1D0")]
	[AsyncStateMachine(typeof(global::CHLFPNDBOOG<, >.EKIJLAFENHK))]
	private Task CMONOPMPFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x28D0610", Offset = "0x28CEE10", VA = "0x1828D0610")]
	private void PAHDPNMAIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x28CF2F0", Offset = "0x28CDAF0", VA = "0x1828CF2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KLFMFOECKOE<TKey, TVal> : global::CAHPOBNDHNN<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int BOLMCEIJBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> FONNCDGJKDC;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int CKBMEOKMIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2A321D0", Offset = "0x2A309D0", VA = "0x182A321D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int JDPNGOEJGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2A32200", Offset = "0x2A30A00", VA = "0x182A32200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A320F0", Offset = "0x2A308F0", VA = "0x182A320F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2A327A0", Offset = "0x2A30FA0", VA = "0x182A327A0")]
	public KLFMFOECKOE(int EBGHKBFPDCN, [Optional] FMCJPGLBGAG LMBFLKJCDHM, [Optional] IEqualityComparer<TKey> HHLFLINLOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2A322D0", Offset = "0x2A30AD0", VA = "0x182A322D0")]
	public void HGDIODJAFPJ(TKey NHBANLNJEIH, TVal NPHADDCNBHE, bool IJEDNLALEEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2A32150", Offset = "0x2A30950", VA = "0x182A32150")]
	public bool DCDHKLBKKKH(TKey NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2A32230", Offset = "0x2A30A30", VA = "0x182A32230", Slot = "6")]
	public override bool FEEDILOKHNP(TKey KCDMBNOPKKB, out TVal NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2A32480", Offset = "0x2A30C80", VA = "0x182A32480")]
	public bool JEOGNLEDNKG(TKey NHBANLNJEIH, TVal NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2A32370", Offset = "0x2A30B70", VA = "0x182A32370")]
	public bool HPFOHNNBECN(TKey NHBANLNJEIH, TVal NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2A32730", Offset = "0x2A30F30", VA = "0x182A32730", Slot = "7")]
	public override void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2A32690", Offset = "0x2A30E90", VA = "0x182A32690")]
	private bool MDFPHNIOEGN(TKey NHBANLNJEIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class CAHPOBNDHNN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int FMCJPGLBGAG(TKey NHBANLNJEIH, TVal NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PFLEHCNCOGL
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey PPKFCNPJALC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal PPNOOBBHMAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FNJAAMNIGIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6F71B0", Offset = "0x6F59B0", VA = "0x1806F71B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA18B00", Offset = "0xA17300", VA = "0x180A18B00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime GPKJMKFDCBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xDCE1D0", Offset = "0xDCC9D0", VA = "0x180DCE1D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F100E0", Offset = "0x2F0E8E0", VA = "0x182F100E0")]
		public PFLEHCNCOGL(TKey NHBANLNJEIH, TVal EAPKDOJGNBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int GOPLAKFNANG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<PFLEHCNCOGL>> ELLECDPDHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<PFLEHCNCOGL> LKDBNEKNAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly FMCJPGLBGAG LMBFLKJCDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan EKLABJONIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly BFPBJGJBNGP EIODGDIFONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HJHKPCGJMKC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LBDHOLBKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6D5020", Offset = "0x6D3820", VA = "0x1806D5020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool BPMNHHHIKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x28BC230", Offset = "0x28BAA30", VA = "0x1828BC230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int CKBMEOKMIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x92AFD0", Offset = "0x9297D0", VA = "0x18092AFD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int FCKFNIPNJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2672FC0", Offset = "0x26717C0", VA = "0x182672FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2618250", Offset = "0x2616A50", VA = "0x182618250", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> LDOHNILHBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x28BC510", Offset = "0x28BAD10", VA = "0x1828BC510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B91950", Offset = "0x3B90150", VA = "0x183B91950")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x28DE180", Offset = "0x28DC980", VA = "0x1828DE180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3B91C10", Offset = "0x3B90410", VA = "0x183B91C10")]
	public CAHPOBNDHNN(int EBGHKBFPDCN, [Optional] FMCJPGLBGAG LMBFLKJCDHM, [Optional] IEqualityComparer<TKey> HHLFLINLOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x28BCB70", Offset = "0x28BB370", VA = "0x1828BCB70")]
	public CAHPOBNDHNN(TimeSpan EKLABJONIBB, [Optional] IEqualityComparer<TKey> HHLFLINLOME, [Optional] BFPBJGJBNGP EIODGDIFONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x28BCBC0", Offset = "0x28BB3C0", VA = "0x1828BCBC0")]
	public CAHPOBNDHNN(int EBGHKBFPDCN, TimeSpan EKLABJONIBB, [Optional] IEqualityComparer<TKey> HHLFLINLOME, [Optional] BFPBJGJBNGP EIODGDIFONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3B91F60", Offset = "0x3B90760", VA = "0x183B91F60")]
	public CAHPOBNDHNN(int EBGHKBFPDCN, FMCJPGLBGAG LMBFLKJCDHM, TimeSpan EKLABJONIBB, [Optional] IEqualityComparer<TKey> HHLFLINLOME, [Optional] BFPBJGJBNGP EIODGDIFONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3B91560", Offset = "0x3B8FD60", VA = "0x183B91560")]
	public void HCOMBMDIJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F9A0", Offset = "0x3B8E1A0", VA = "0x183B8F9A0")]
	public void BJPKOCBPDKP(TKey NHBANLNJEIH, TVal NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B8F6D0", Offset = "0x3B8DED0", VA = "0x183B8F6D0")]
	public bool ALIFOBNBCOA(TKey NHBANLNJEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B916E0", Offset = "0x3B8FEE0", VA = "0x183B916E0")]
	private TVal HEJAGBNBHFE(TKey KCDMBNOPKKB)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B905E0", Offset = "0x3B8EDE0", VA = "0x183B905E0", Slot = "6")]
	public virtual bool FEEDILOKHNP(TKey KCDMBNOPKKB, out TVal NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x28BC730", Offset = "0x28BAF30", VA = "0x1828BC730", Slot = "7")]
	public virtual void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B901B0", Offset = "0x3B8E9B0", VA = "0x183B901B0")]
	private bool EPNBAHEDBGE(PFLEHCNCOGL PFGDJDMOIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B911A0", Offset = "0x3B8F9A0", VA = "0x183B911A0")]
	private void FFBOOCOJKHP(LinkedListNode<PFLEHCNCOGL> MDHOMCMFHOD, TVal PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3B90930", Offset = "0x3B8F130", VA = "0x183B90930")]
	private void FENFGKNKPAA(TKey NHBANLNJEIH, TVal NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B8FDA0", Offset = "0x3B8E5A0", VA = "0x183B8FDA0")]
	private void CFAAKDPBBFA(PFLEHCNCOGL PFGDJDMOIBA, TVal PMHHEDOHMIJ, int LEENEPJNFPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class HNOCEADFAMF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> HGPMCGJIADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> DBOJFICDANO;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x17FF070", Offset = "0x17FD870", VA = "0x1817FF070", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A61780", Offset = "0x2A5FF80", VA = "0x182A61780", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x324C8B0", Offset = "0x324B0B0", VA = "0x18324C8B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x29AC680", Offset = "0x29AAE80", VA = "0x1829AC680", Slot = "11")]
	public void Add(T FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x324C3D0", Offset = "0x324ABD0", VA = "0x18324C3D0")]
	public bool KIPDGIEJLFO(T FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x324C6C0", Offset = "0x324AEC0", VA = "0x18324C6C0", Slot = "15")]
	public bool Remove(T FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x26F9970", Offset = "0x26F8170", VA = "0x1826F9970", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2705850", Offset = "0x2704050", VA = "0x182705850", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x324BFB0", Offset = "0x324A7B0", VA = "0x18324BFB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x1498260", Offset = "0x1496A60", VA = "0x181498260", Slot = "13")]
	public bool Contains(T FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x324C010", Offset = "0x324A810", VA = "0x18324C010", Slot = "14")]
	public void CopyTo(T[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x324C210", Offset = "0x324AA10", VA = "0x18324C210", Slot = "6")]
	public int IndexOf(T FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x324C310", Offset = "0x324AB10", VA = "0x18324C310", Slot = "7")]
	public void Insert(int LHHBOCAHDEE, T FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x324C520", Offset = "0x324AD20", VA = "0x18324C520", Slot = "8")]
	public void RemoveAt(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x324C070", Offset = "0x324A870", VA = "0x18324C070")]
	public void FCALJBKACDO(Predicate<T> GPMCECCEKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x324C040", Offset = "0x324A840", VA = "0x18324C040")]
	public void EEHNICGMFPD(Comparison<T> FBKMCCDFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x324C7D0", Offset = "0x324AFD0", VA = "0x18324C7D0")]
	public HNOCEADFAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CILIPMDHGPN
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6480460", Offset = "0x647EC60", VA = "0x186480460")]
	public static Vector3 EBGEDKIKOGA(this GameObject IMPKIJJJHKI, float CNJNNKIBNGD)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
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
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2BD3D50", Offset = "0x2BD2550", VA = "0x182BD3D50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x64875C0", Offset = "0x6485DC0", VA = "0x1864875C0")]
		public SerializedGuid(in Guid CNMALJMHIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6487460", Offset = "0x6485C60", VA = "0x186487460")]
		public static SerializedGuid KPOFOILCLDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x64873D0", Offset = "0x6485BD0", VA = "0x1864873D0")]
		public static SerializedGuid IJEPGOPEHFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x64870E0", Offset = "0x64858E0", VA = "0x1864870E0")]
		public bool BIJBAFFKCJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6487590", Offset = "0x6485D90", VA = "0x186487590", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x64874F0", Offset = "0x6485CF0", VA = "0x1864874F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6487330", Offset = "0x6485B30", VA = "0x186487330")]
		public bool GKAHDDHENKO(in Guid CNMALJMHIOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x64871A0", Offset = "0x64859A0", VA = "0x1864871A0", Slot = "7")]
		public bool Equals(SerializedGuid HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6487250", Offset = "0x6485A50", VA = "0x186487250", Slot = "0")]
		public override bool Equals(object BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x64873C0", Offset = "0x6485BC0", VA = "0x1864873C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6487170", Offset = "0x6485970", VA = "0x186487170", Slot = "6")]
		public int CompareTo(SerializedGuid HAKPJJGEGOM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class LJGOHKGDKIF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type LCGAAHLHHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string HGFEOCEPEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool BMECIJICPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool FOLHHADLNCH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6481A80", Offset = "0x6480280", VA = "0x186481A80")]
	public LJGOHKGDKIF(Type FLGFHNICLAI, string MKDJMNOHLJF, bool MBBBKKHEALC = false, bool CLMABHCEHAA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface KMBBAPLFIMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface GLIHEFGOPID<T> : KMBBAPLFIMM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KFHFMPFPKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string DFIAEGGBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GLIHEFGOPID<T> JFDDNALMBFK(Action<T> KAGAGLGHILD);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GLIHEFGOPID<T> CENAMJFDANK(Action<T> KAGAGLGHILD);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::GLIHEFGOPID<T> EKPCEKLMEBB(Action<T, T> KPNGFLPLOHF);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GLIHEFGOPID<T> MMPNHEKHGBG(Action<T, T> KPNGFLPLOHF);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::GLIHEFGOPID<T> PJEOOKJILKC(Action<string> AMFAGHOLBAB);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::GLIHEFGOPID<T> JLBCEELBIGF(Action<string> AMFAGHOLBAB);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HCKINCGDELE<T> : global::GLIHEFGOPID<T>, KMBBAPLFIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::KPNCHACHCHE<T, T> MPOLAECCFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::CNOGLFLGNKP<T> BOFLEHNJECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::CNOGLFLGNKP<string> DLEEKEKFOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string EMPPPODHBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T KGFIMLECODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HIBGILMLKMN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1818FD0", Offset = "0x18177D0", VA = "0x181818FD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KFHFMPFPKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A0560", Offset = "0x79ED60", VA = "0x1807A0560", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string DFIAEGGBNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x106E360", Offset = "0x106CB60", VA = "0x18106E360", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x364F2C0", Offset = "0x364DAC0", VA = "0x18364F2C0")]
	private void LPDBNOLGMBP(T HBMMCJPOJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x364F110", Offset = "0x364D910", VA = "0x18364F110")]
	private void FGNIIHAPJAI(string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x364F3B0", Offset = "0x364DBB0", VA = "0x18364F3B0")]
	public void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x364F0C0", Offset = "0x364D8C0", VA = "0x18364F0C0", Slot = "6")]
	public global::GLIHEFGOPID<T> EKPCEKLMEBB(Action<T, T> KPNGFLPLOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x364F360", Offset = "0x364DB60", VA = "0x18364F360", Slot = "7")]
	public global::GLIHEFGOPID<T> MMPNHEKHGBG(Action<T, T> KPNGFLPLOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x364F1C0", Offset = "0x364D9C0", VA = "0x18364F1C0", Slot = "4")]
	public global::GLIHEFGOPID<T> JFDDNALMBFK(Action<T> KPNGFLPLOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x364F070", Offset = "0x364D870", VA = "0x18364F070", Slot = "5")]
	public global::GLIHEFGOPID<T> CENAMJFDANK(Action<T> KAGAGLGHILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x364F460", Offset = "0x364DC60", VA = "0x18364F460", Slot = "8")]
	public global::GLIHEFGOPID<T> PJEOOKJILKC(Action<string> AMFAGHOLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x364F250", Offset = "0x364DA50", VA = "0x18364F250", Slot = "9")]
	public global::GLIHEFGOPID<T> JLBCEELBIGF(Action<string> AMFAGHOLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x364F500", Offset = "0x364DD00", VA = "0x18364F500")]
	public HCKINCGDELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class CAJCHEIEEIE
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EMJBAPKONDF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::GLIHEFGOPID<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::OGBIEJAIDCG<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public EMJBAPKONDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1492A70", Offset = "0x1491270", VA = "0x181492A70")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F31E90", Offset = "0x1F30690", VA = "0x181F31E90")]
	public static global::FGLDKEJLAKB<T> JCAOJAAFFGN<T>(this global::GLIHEFGOPID<T> MBPJALBNIHI, Action<T> MKOFIMIHGLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IDCECOPBNKH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct LPNLNBNKDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long JIMOHJNGFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long LMMJLDEONNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int OCOEGPAGAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int HPBEIGMMLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool GAEDKMHBPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string JKFEHLNHDCG;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0860", Offset = "0x2FEF060", VA = "0x182FF0860")]
		public LPNLNBNKDOO(long JIMOHJNGFLA, int OCOEGPAGAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2FF08D0", Offset = "0x2FEF0D0", VA = "0x182FF08D0")]
		public LPNLNBNKDOO(long JIMOHJNGFLA, long LMMJLDEONNA, int OCOEGPAGAHG, int HPBEIGMMLFN, bool GAEDKMHBPEG, string JKFEHLNHDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0680", Offset = "0x2FEEE80", VA = "0x182FF0680")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CFGCNFHFMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0760", Offset = "0x2FEEF60", VA = "0x182FF0760")]
		public int LPBJKKGDCOP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0840", Offset = "0x2FEF040", VA = "0x182FF0840")]
		public int OHAKEMCKDCA(int GFCMCAAPHJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2FF06F0", Offset = "0x2FEEEF0", VA = "0x182FF06F0")]
		public double KNMDLLCIPGB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2FF07B0", Offset = "0x2FEEFB0", VA = "0x182FF07B0")]
		public LPNLNBNKDOO OBOBBBOLPAI(long LMMJLDEONNA, int HPBEIGMMLFN)
		{
			return default(LPNLNBNKDOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class NFFBCAHKINE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey PPKFCNPJALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::IDCECOPBNKH<TKey> KBGFBMKMFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<NFFBCAHKINE> BFIBIOKBFMN;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string LFHHFEECOLH
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2730DD0", Offset = "0x272F5D0", VA = "0x182730DD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x28E28D0", Offset = "0x28E10D0", VA = "0x1828E28D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<NFFBCAHKINE> MLJAFDCPLNK
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x34B7500", Offset = "0x34B5D00", VA = "0x1834B7500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LPNLNBNKDOO KLBNOFENEEC
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x17917E0", Offset = "0x178FFE0", VA = "0x1817917E0")]
			[CompilerGenerated]
			get
			{
				return default(LPNLNBNKDOO);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x34B78C0", Offset = "0x34B60C0", VA = "0x1834B78C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x34B78F0", Offset = "0x34B60F0", VA = "0x1834B78F0")]
		internal NFFBCAHKINE(global::IDCECOPBNKH<TKey> KBGFBMKMFNL, TKey NHBANLNJEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x34B77B0", Offset = "0x34B5FB0", VA = "0x1834B77B0")]
		public NFFBCAHKINE HFCBJPDJBBE(TKey NHBANLNJEIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x34B76D0", Offset = "0x34B5ED0", VA = "0x1834B76D0")]
		public void GEIHBJPCFKM(TKey NHBANLNJEIH, Action<NFFBCAHKINE> BEHJPKINPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x21CA120", Offset = "0x21C8920", VA = "0x1821CA120")]
		public T GEIHBJPCFKM<T>(TKey NHBANLNJEIH, Func<NFFBCAHKINE, T> MBJOEFPNKEP)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x21C9FB0", Offset = "0x21C87B0", VA = "0x1821C9FB0")]
		[AsyncStateMachine(typeof(JJCADJBPGIC))]
		public Task<T> BJBCLDGHHMI<T>(TKey NHBANLNJEIH, Func<NFFBCAHKINE, Task<T>> MBJOEFPNKEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x34B7520", Offset = "0x34B5D20", VA = "0x1834B7520", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IGEKDJNCAKN : IEnumerable<(TKey, List<TKey>, LPNLNBNKDOO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LPNLNBNKDOO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, LPNLNBNKDOO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::IDCECOPBNKH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, LPNLNBNKDOO timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, LPNLNBNKDOO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1814F10", Offset = "0x1813710", VA = "0x181814F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LPNLNBNKDOO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1814FB0", Offset = "0x18137B0", VA = "0x181814FB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x18150C0", Offset = "0x18138C0", VA = "0x1818150C0")]
		[DebuggerHidden]
		public IGEKDJNCAKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1815010", Offset = "0x1813810", VA = "0x181815010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1814BA0", Offset = "0x18133A0", VA = "0x181814BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1815070", Offset = "0x1813870", VA = "0x181815070")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1814F70", Offset = "0x1813770", VA = "0x181814F70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1814E50", Offset = "0x1813650", VA = "0x181814E50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LPNLNBNKDOO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1814F40", Offset = "0x1813740", VA = "0x181814F40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CDLPFCIGLJF : IEnumerable<(TKey, List<TKey>, LPNLNBNKDOO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LPNLNBNKDOO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, LPNLNBNKDOO timerEntry) <>2__current;

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
		private NFFBCAHKINE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public NFFBCAHKINE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::IDCECOPBNKH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<NFFBCAHKINE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, LPNLNBNKDOO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, LPNLNBNKDOO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1814F10", Offset = "0x1813710", VA = "0x181814F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LPNLNBNKDOO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x28C99C0", Offset = "0x28C81C0", VA = "0x1828C99C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x18150C0", Offset = "0x18138C0", VA = "0x1818150C0")]
		[DebuggerHidden]
		public CDLPFCIGLJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x28C9A20", Offset = "0x28C8220", VA = "0x1828C9A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x28C92D0", Offset = "0x28C7AD0", VA = "0x1828C92D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x28C9AC0", Offset = "0x28C82C0", VA = "0x1828C9AC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B20", Offset = "0x28C8320", VA = "0x1828C9B20")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x28C9980", Offset = "0x28C8180", VA = "0x1828C9980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x28C9870", Offset = "0x28C8070", VA = "0x1828C9870", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LPNLNBNKDOO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x28C9950", Offset = "0x28C8150", VA = "0x1828C9950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, LPNLNBNKDOO> NNEJGHEIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, LPNLNBNKDOO> NGHFCIDCHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::IDCECOPBNKH<TKey>> JHBJAGNKOAC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string KPAPNHICEDD = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly NFFBCAHKINE BOOEABAHDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool IFDCADIMIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int CPIBMNMAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch LKLCJCFHEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int KFGCPGHEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string PMMJJKBJCAC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NFFBCAHKINE GOPPCEFEAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string LFHHFEECOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x180BC90", Offset = "0x180A490", VA = "0x18180BC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long ADIFNBPEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x180BE20", Offset = "0x180A620", VA = "0x18180BE20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int AMIECDDHLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x180BE60", Offset = "0x180A660", VA = "0x18180BE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x180BFF0", Offset = "0x180A7F0", VA = "0x18180BFF0")]
	public IDCECOPBNKH(TKey FBJIAJMPFOB, [Optional] int? OCOEGPAGAHG, [Optional][CanBeNull] Stopwatch LKLCJCFHEKM, [Optional] Action<TKey, LPNLNBNKDOO> NNEJGHEIHEO, [Optional] Action<TKey, LPNLNBNKDOO> NGHFCIDCHCP, [Optional] Action<global::IDCECOPBNKH<TKey>> JHBJAGNKOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x180BCF0", Offset = "0x180A4F0", VA = "0x18180BCF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x180BD80", Offset = "0x180A580", VA = "0x18180BD80")]
	public void FLIOKADGAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x180BE40", Offset = "0x180A640", VA = "0x18180BE40")]
	public void PHFIJKIEHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x180BF60", Offset = "0x180A760", VA = "0x18180BF60")]
	[IteratorStateMachine(typeof(global::IDCECOPBNKH<>.IGEKDJNCAKN))]
	public IEnumerable<(TKey, List<TKey>, LPNLNBNKDOO)> POCHNDHGGHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x180BE90", Offset = "0x180A690", VA = "0x18180BE90")]
	[IteratorStateMachine(typeof(global::IDCECOPBNKH<>.CDLPFCIGLJF))]
	private IEnumerable<(TKey, List<TKey>, LPNLNBNKDOO)> POCHNDHGGHO(List<TKey> EKLHOMDDPCF, NFFBCAHKINE DKBAMHCEEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x180BDA0", Offset = "0x180A5A0", VA = "0x18180BDA0")]
	private (long, int) HECJINGLDMN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class FGHKFPKLCOL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BBHCPGEBKBB(global::IDCECOPBNKH<TKey> KBGFBMKMFNL);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	protected FGHKFPKLCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class POFKDKCEAGH<TKey> : global::FGHKFPKLCOL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string FJJCNBCLAJH(TKey NHBANLNJEIH);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x310A8C0", Offset = "0x31090C0", VA = "0x18310A8C0")]
	protected string FMNAHOIAFPA(double GOJGFEJCFBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x310A860", Offset = "0x3109060", VA = "0x18310A860")]
	protected string BKBEOCGEFFG(int BEAHNJAKJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x310A930", Offset = "0x3109130", VA = "0x18310A930")]
	private static string ICHJCEGDJBP(TKey NHBANLNJEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x310A680", Offset = "0x3108E80", VA = "0x18310A680", Slot = "4")]
	public override string BBHCPGEBKBB(global::IDCECOPBNKH<TKey> KBGFBMKMFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x310A730", Offset = "0x3108F30", VA = "0x18310A730")]
	public string BBHCPGEBKBB(global::IDCECOPBNKH<TKey> KBGFBMKMFNL, [NotNull] FJJCNBCLAJH MNMLJHAOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HFIDCPNGIHE(global::IDCECOPBNKH<TKey> KBGFBMKMFNL, [NotNull] FJJCNBCLAJH MNMLJHAOKOC);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2700150", Offset = "0x26FE950", VA = "0x182700150")]
	protected POFKDKCEAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class ONKDMOAEPPB<TKey> : global::FGHKFPKLCOL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string BGPGMBNOCII(TKey NHBANLNJEIH);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int MOJKHPLFDAJ = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string KCOOCOAGBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double NMLIBBGMEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool DFDKKNNFEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int OEHGJBHHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> EPCKPHOLLAB;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x356FB60", Offset = "0x356E360", VA = "0x18356FB60")]
	private static string ICHJCEGDJBP(TKey NHBANLNJEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x356FE30", Offset = "0x356E630", VA = "0x18356FE30")]
	public ONKDMOAEPPB(string KCOOCOAGBOM = "F2", double NMLIBBGMEBC = double.MaxValue, bool DFDKKNNFEDE = false, int OEHGJBHHJIO = int.MaxValue, [Optional] ISet<string> EPCKPHOLLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x356F3F0", Offset = "0x356DBF0", VA = "0x18356F3F0", Slot = "4")]
	public override Dictionary<string, string> BBHCPGEBKBB(global::IDCECOPBNKH<TKey> KBGFBMKMFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x356FBA0", Offset = "0x356E3A0", VA = "0x18356FBA0")]
	private bool OIFJEBGBIFP(string GJOCAOOPEDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x356F4A0", Offset = "0x356DCA0", VA = "0x18356F4A0")]
	public Dictionary<string, string> BBHCPGEBKBB(global::IDCECOPBNKH<TKey> KBGFBMKMFNL, BGPGMBNOCII MNMLJHAOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x356FC80", Offset = "0x356E480", VA = "0x18356FC80")]
	private string PLKJJHKLHCB(StringBuilder CNFOLELIEAD, List<TKey> AJKPMIHIMIB, BGPGMBNOCII MNMLJHAOKOC, bool ONFOOPIFOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x356F9E0", Offset = "0x356E1E0", VA = "0x18356F9E0")]
	private static void COBGAHIDHGH(StringBuilder LMEHMNGDMOG, string PAJHFDJIGFM, bool KOPIFLIDBIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KLIJJMNOCAN<TKey> : global::POFKDKCEAGH<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BNGAFBPFADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public FJJCNBCLAJH keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::KLIJJMNOCAN<TKey> PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int JGHNIFFOLGL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] ELFHDOINJNO;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2A33E40", Offset = "0x2A32640", VA = "0x182A33E40")]
	private KLIJJMNOCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A32DD0", Offset = "0x2A315D0", VA = "0x182A32DD0", Slot = "5")]
	protected override string HFIDCPNGIHE(global::IDCECOPBNKH<TKey> KBGFBMKMFNL, FJJCNBCLAJH MNMLJHAOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A33C50", Offset = "0x2A32450", VA = "0x182A33C50")]
	[CompilerGenerated]
	internal static string NAEDIIOEBIA(string GHCCPDAPGIO, TKey NHBANLNJEIH, ref BNGAFBPFADB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class KMLMGFICECM<TKey> : global::POFKDKCEAGH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class PNPJJEPHECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public FJJCNBCLAJH keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public PNPJJEPHECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2724440", Offset = "0x2722C40", VA = "0x182724440")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A34620", Offset = "0x2A32E20", VA = "0x182A34620", Slot = "5")]
	protected override string HFIDCPNGIHE(global::IDCECOPBNKH<TKey> KBGFBMKMFNL, FJJCNBCLAJH MNMLJHAOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x26F9B90", Offset = "0x26F8390", VA = "0x1826F9B90")]
	public KMLMGFICECM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class FMEJDGCMLHA : global::IDCECOPBNKH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PEIEKJKIHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<FMEJDGCMLHA> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PEIEKJKIHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6485040", Offset = "0x6483840", VA = "0x186485040")]
		internal void <Wrap>b__0(global::IDCECOPBNKH<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6480E20", Offset = "0x647F620", VA = "0x186480E20")]
	public FMEJDGCMLHA([Optional] string OKDCKFGCNIL, [Optional] int? OCOEGPAGAHG, [Optional] Stopwatch LKLCJCFHEKM, [Optional] Action<string, LPNLNBNKDOO> NNEJGHEIHEO, [Optional] Action<string, LPNLNBNKDOO> NGHFCIDCHCP, [Optional] Action<FMEJDGCMLHA> JHBJAGNKOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6480D40", Offset = "0x647F540", VA = "0x186480D40")]
	private static Action<global::IDCECOPBNKH<string>> GEIHBJPCFKM(Action<FMEJDGCMLHA> MKOFIMIHGLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class BFPBJGJBNGP
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class AHOEOPIJIMH : BFPBJGJBNGP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static BFPBJGJBNGP PDCOCJBICGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x647DFC0", Offset = "0x647C7C0", VA = "0x18647DFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime FDHEMEADEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x647E020", Offset = "0x647C820", VA = "0x18647E020", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float HJFINJEKCEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x647E070", Offset = "0x647C870", VA = "0x18647E070", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x647E120", Offset = "0x647C920", VA = "0x18647E120")]
		public AHOEOPIJIMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static BFPBJGJBNGP KJMGBNNPMIB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static BFPBJGJBNGP KKHIANFEDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x647E350", Offset = "0x647CB50", VA = "0x18647E350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime FDHEMEADEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float HJFINJEKCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected BFPBJGJBNGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NPLEALAIAJK : global::KDENOFEGEKL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6482D50", Offset = "0x6481550", VA = "0x186482D50")]
	public NPLEALAIAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KDENOFEGEKL<T> : global::FHFGABMPMPC<T>, CJMAKIMALDJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> CCBPDJBMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task OEPAFDJICHI
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1611780", Offset = "0x160FF80", VA = "0x181611780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::FGLDKEJLAKB<T> HNBAMGOFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private LDGADANDBIO MHJBAABDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x106DC30", Offset = "0x106C430", VA = "0x18106DC30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x25EF770", Offset = "0x25EDF70", VA = "0x1825EF770")]
	public KDENOFEGEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EMFIAFGLAFD : global::PNBCPDMMPHE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6480BE0", Offset = "0x647F3E0", VA = "0x186480BE0")]
	public EMFIAFGLAFD(Exception ODBOKKABIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PNBCPDMMPHE<T> : global::FHFGABMPMPC<T>, CJMAKIMALDJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> CCBPDJBMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task OEPAFDJICHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1611780", Offset = "0x160FF80", VA = "0x181611780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::FGLDKEJLAKB<T> HNBAMGOFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private LDGADANDBIO MHJBAABDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x106DC30", Offset = "0x106C430", VA = "0x18106DC30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x37183B0", Offset = "0x3716BB0", VA = "0x1837183B0")]
	public PNBCPDMMPHE(Exception ODBOKKABIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface CJMAKIMALDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task CCBPDJBMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	LDGADANDBIO HNBAMGOFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface FHFGABMPMPC<T> : CJMAKIMALDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> CCBPDJBMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::FGLDKEJLAKB<T> HNBAMGOFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class FOFOIDCLPFN<TTask, T> : global::FHFGABMPMPC<T>, CJMAKIMALDJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class GJDFDNCHPCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::FOFOIDCLPFN<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public GJDFDNCHPCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool AHOOJNOFJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> MEIEEDMLHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource GABGOINNOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool IFDCADIMIGO;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> CCBPDJBMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task OEPAFDJICHI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::FGLDKEJLAKB<T> HNBAMGOFKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private LDGADANDBIO MHJBAABDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x25B5720", Offset = "0x25B3F20", VA = "0x1825B5720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool IFJHKPDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2998E00", Offset = "0x2997600", VA = "0x182998E00")]
	static FOFOIDCLPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x29990E0", Offset = "0x29978E0", VA = "0x1829990E0")]
	protected FOFOIDCLPFN(TTask MEIEEDMLHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2998880", Offset = "0x2997080", VA = "0x182998880", Slot = "1")]
	~FOFOIDCLPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2998850", Offset = "0x2997050", VA = "0x182998850", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2998AC0", Offset = "0x29972C0", VA = "0x182998AC0")]
	private void IPHJFMDKADM(bool LENLJPJHELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T DPMCBKJPMDO(TTask MEHKOKNAJIG);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void EJFNGBBMKJG();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface JECLDOOKEDH
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float GLINBOGOIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BAAAHBMCLCN INMOHDJHPEA;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class NCFPHIGAPPP : JECLDOOKEDH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct BJDKCPODIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float HKCEAJHPIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float BBDBACIODGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool HOFMIBPEMEM;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float FNJAAMNIGIL
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x647FB50", Offset = "0x647E350", VA = "0x18647FB50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x647FCE0", Offset = "0x647E4E0", VA = "0x18647FCE0")]
		public BJDKCPODIDC(float DAOIPFCHFFJ, float FBIOFODCNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x647FB60", Offset = "0x647E360", VA = "0x18647FB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class MCIIIAILKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NCFPHIGAPPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MCIIIAILKIE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int EBGHKBFPDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int INDOGCJMIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly JECLDOOKEDH[] HCBAIMBDEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly BAAAHBMCLCN[] GHFACKFNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly BJDKCPODIDC[] PAFHIBGEMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private BJDKCPODIDC LMCKFMCIJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly OPFODIOMFFE BIJMIEHANEO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BJDKCPODIDC KEFACDOLDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EED0", Offset = "0x4B0D6D0", VA = "0x184B0EED0")]
		get
		{
			return default(BJDKCPODIDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float GLINBOGOIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6482400", Offset = "0x6480C00", VA = "0x186482400", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BAAAHBMCLCN INMOHDJHPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6482340", Offset = "0x6480B40", VA = "0x186482340", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x64821E0", Offset = "0x64809E0", VA = "0x1864821E0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6482870", Offset = "0x6481070", VA = "0x186482870")]
	public NCFPHIGAPPP(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6481FC0", Offset = "0x64807C0", VA = "0x186481FC0")]
	public OPFODIOMFFE BFFMFGJABGO(BJDKCPODIDC EGAOMEOCDIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6482420", Offset = "0x6480C20", VA = "0x186482420")]
	public void JDPGPBFBMLN(JECLDOOKEDH HBMBDKLJLHH, [Optional] BJDKCPODIDC GKBNHNFGHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x64822A0", Offset = "0x6480AA0", VA = "0x1864822A0")]
	internal int FDIMGBOHNMI(JECLDOOKEDH JJNAIFFFOOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x64822F0", Offset = "0x6480AF0", VA = "0x1864822F0")]
	internal BJDKCPODIDC FGBEIPOINOD(int LHHBOCAHDEE)
	{
		return default(BJDKCPODIDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6482050", Offset = "0x6480850", VA = "0x186482050", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void BAAAHBMCLCN(float HKJFLOMMHGC);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class HACNMELKGFH
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float NHKPEJIMDIK = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class MJEGKHPCJHL
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class NGLIIOPMGPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly JECLDOOKEDH JJNAIFFFOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly BAAAHBMCLCN MKOFIMIHGLL;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6482A40", Offset = "0x6481240", VA = "0x186482A40")]
		public NGLIIOPMGPE(JECLDOOKEDH JJNAIFFFOOL, BAAAHBMCLCN MKOFIMIHGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x64829F0", Offset = "0x64811F0", VA = "0x1864829F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6481C50", Offset = "0x6480450", VA = "0x186481C50")]
	internal static bool DEMPHDJFKLO(float HDPOKDCLGGE, float JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x49467E0", Offset = "0x4944FE0", VA = "0x1849467E0")]
	internal static float EMIMDILDEHO(float HDPOKDCLGGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6481CD0", Offset = "0x64804D0", VA = "0x186481CD0")]
	public static IDisposable NCINNJLBCCP(this JECLDOOKEDH JJNAIFFFOOL, BAAAHBMCLCN MKOFIMIHGLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OPFODIOMFFE : JECLDOOKEDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float HKJFLOMMHGC;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GLINBOGOIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x118F400", Offset = "0x118DC00", VA = "0x18118F400", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x64848B0", Offset = "0x64830B0", VA = "0x1864848B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BAAAHBMCLCN INMOHDJHPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6484970", Offset = "0x6483170", VA = "0x186484970", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6484810", Offset = "0x6483010", VA = "0x186484810", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public OPFODIOMFFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class ILMLPKFCPPC
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x64814E0", Offset = "0x647FCE0", VA = "0x1864814E0")]
	[NotNull]
	public static byte[] BCKNHJDHJHP(this FCPHMKKNAOD JOBPBMFHPFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6481550", Offset = "0x647FD50", VA = "0x186481550")]
	[NotNull]
	public static byte[] BCKNHJDHJHP(this FCPHMKKNAOD JOBPBMFHPFM, HashAlgorithmName DCFILECPFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x64817D0", Offset = "0x647FFD0", VA = "0x1864817D0")]
	public static bool IAKPLMDPJIK([CanBeNull] this FCPHMKKNAOD JOBPBMFHPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6481630", Offset = "0x647FE30", VA = "0x186481630")]
	public static bool IAKPLMDPJIK([CanBeNull] this FCPHMKKNAOD JOBPBMFHPFM, out string EMPPPODHBFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x64815C0", Offset = "0x647FDC0", VA = "0x1864815C0")]
	private static string DIEANAIHKLI([CanBeNull] byte[] EBBNNMNMLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6481960", Offset = "0x6480160", VA = "0x186481960")]
	private static bool MIHFLKKCBJB([NotNull] FCPHMKKNAOD JOBPBMFHPFM, [CanBeNull] out byte[] CEPNIBMPBMC, [CanBeNull] out byte[] KJLICAJJEIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class CNBICIBLBEP
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6480960", Offset = "0x647F160", VA = "0x186480960")]
	[NotNull]
	public static byte[] BCKNHJDHJHP(this CAKADHOHIKD ONDOOLOIJPE, byte[] IBANLCKMMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6480730", Offset = "0x647EF30", VA = "0x186480730")]
	[NotNull]
	public static byte[] BCKNHJDHJHP(this CAKADHOHIKD ONDOOLOIJPE, HashAlgorithmName DCFILECPFKK, byte[] IBANLCKMMDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface CAKADHOHIKD
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MNONHEHGNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface FCPHMKKNAOD : CAKADHOHIKD
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] CMMOOINLCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] MPHFKMLLNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object PCIFEOJGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class BGKMBDKNGJF
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class COKIALDNIIJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6480A00", Offset = "0x647F200", VA = "0x186480A00")]
		public COKIALDNIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x64809A0", Offset = "0x647F1A0", VA = "0x1864809A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte MNHKPDCCONB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte LLGJMHLAFEM = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> NKOIEPCELPJ;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool AHCKECPMGAC;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F28190", Offset = "0x1F26990", VA = "0x181F28190")]
	[Conditional("UNITY_EDITOR")]
	private static void LNLEGLNCEOM<T>(params T[] IOMPKFBADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x647EEC0", Offset = "0x647D6C0", VA = "0x18647EEC0")]
	public static IDisposable IJJCILGOIEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x647EFC0", Offset = "0x647D7C0", VA = "0x18647EFC0")]
	public static void KNBACIIDMHL(this IncrementalHash BELMOLGEAAK, [CanBeNull] GameObject IMPKIJJJHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F279D0", Offset = "0x1F261D0", VA = "0x181F279D0")]
	public static void KNBACIIDMHL<T>(this IncrementalHash BELMOLGEAAK, [CanBeNull] T DMKJFEIEPGB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F27940", Offset = "0x1F26140", VA = "0x181F27940")]
	public static void KEFEAJOLBAC<T>(this IncrementalHash BELMOLGEAAK, [CanBeNull] T ONDOOLOIJPE) where T : CAKADHOHIKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F28480", Offset = "0x1F26C80", VA = "0x181F28480")]
	public static void NJMGJANJEIA<T>(this IncrementalHash BELMOLGEAAK, [CanBeNull] IList<T> FIJLFEHMLFO) where T : CAKADHOHIKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x647F0B0", Offset = "0x647D8B0", VA = "0x18647F0B0")]
	private static bool LENKHACNECI([CanBeNull] CAKADHOHIKD ONDOOLOIJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x647E550", Offset = "0x647CD50", VA = "0x18647E550")]
	public static void BPMLGPEHKOL(this IncrementalHash MNONHEHGNJF, [CanBeNull] string HKGALBDAABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x647EB20", Offset = "0x647D320", VA = "0x18647EB20")]
	public static void EBOJMKMLGBL(this IncrementalHash MNONHEHGNJF, long IEAJFCBKBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x647F370", Offset = "0x647DB70", VA = "0x18647F370")]
	public static void PHNMAOPKHHC(this IncrementalHash MNONHEHGNJF, int EKEALIHCBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x647E7E0", Offset = "0x647CFE0", VA = "0x18647E7E0")]
	public static void DIACLLEKLNK(this IncrementalHash MNONHEHGNJF, short OMDALNNFPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x647E9B0", Offset = "0x647D1B0", VA = "0x18647E9B0")]
	public static void EBFEBKJOINA(this IncrementalHash MNONHEHGNJF, byte GGKKDHIMBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x647E5B0", Offset = "0x647CDB0", VA = "0x18647E5B0")]
	public static void CBAIINKNGOA(this IncrementalHash MNONHEHGNJF, bool KNJPJLGBKBL, bool CPOFDLPGJHI = false, bool NKBHBGHMOJM = false, bool ACJPIJCOGFN = false, bool CLLIIBDJBBC = false, bool CKGCHANKOFP = false, bool ALAGDEJDHAN = false, bool PICCFDJGEFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F27AA0", Offset = "0x1F262A0", VA = "0x181F27AA0")]
	public static void LCBEKFBKAKM<T>(this IncrementalHash MNONHEHGNJF, T BOHGFMIOFJE) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x647E780", Offset = "0x647CF80", VA = "0x18647E780")]
	public static void CGBDMFJNBJE(this IncrementalHash MNONHEHGNJF, float OHCDIIHEFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x647EF60", Offset = "0x647D760", VA = "0x18647EF60")]
	public static void KFOFKIBNDGE(this IncrementalHash MNONHEHGNJF, double PMMINBMEIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x647E4E0", Offset = "0x647CCE0", VA = "0x18647E4E0")]
	public static void BHGKLPBIPMP(this IncrementalHash MNONHEHGNJF, ulong ADIACEJCEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x647EE60", Offset = "0x647D660", VA = "0x18647EE60")]
	public static void IFGPCPLHPBM(this IncrementalHash MNONHEHGNJF, uint NEMAEIJNGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x647F140", Offset = "0x647D940", VA = "0x18647F140")]
	public static void MALIIBMMKLF(this IncrementalHash MNONHEHGNJF, ushort AELMAHGOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x647ECF0", Offset = "0x647D4F0", VA = "0x18647ECF0")]
	public static void FNDFOCDPOOJ(this IncrementalHash MNONHEHGNJF, Vector3 BBPLHCKAJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x647F1B0", Offset = "0x647D9B0", VA = "0x18647F1B0")]
	public static void NOHEBBBBOFD(this IncrementalHash MNONHEHGNJF, Quaternion AKFJHNHDLEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GNDECFMOAHK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type LCGAAHLHHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string HGFEOCEPEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool BMECIJICPIC;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6480FB0", Offset = "0x647F7B0", VA = "0x186480FB0")]
	public GNDECFMOAHK(Type FLGFHNICLAI, string MKDJMNOHLJF, bool MBBBKKHEALC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class AMBNBJAEGOH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x647E200", Offset = "0x647CA00", VA = "0x18647E200")]
	public AMBNBJAEGOH(string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x647E180", Offset = "0x647C980", VA = "0x18647E180")]
	public AMBNBJAEGOH(string EPAIMCEIMPA, Exception MIPCKLGKFJE)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6EB790", Offset = "0x6E9F90", VA = "0x1806EB790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int AOKAFHMCMMJ, int JMJAHAEGGMI]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x35E2620", Offset = "0x35E0E20", VA = "0x1835E2620")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x35E26C0", Offset = "0x35E0EC0", VA = "0x1835E26C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x35E2590", Offset = "0x35E0D90", VA = "0x1835E2590")]
		public Array2D(uint HOAILLMFABM, uint APOJLADNFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x35E2510", Offset = "0x35E0D10", VA = "0x1835E2510")]
		public void MMLFENDEPMM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x647E270", Offset = "0x647CA70", VA = "0x18647E270")]
		public Array2DVector3(uint HOAILLMFABM, uint APOJLADNFJD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct PJOEGCAHOHD
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool ICNJNJEFLLJ(string FBBIKBFEDIE, PJOEGCAHOHD FEBGHAHKIPH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int BOHGFMIOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string OOPECBKCMEI;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x64854F0", Offset = "0x6483CF0", VA = "0x1864854F0")]
	public static Dictionary<string, PJOEGCAHOHD> NMDAMMAPEOK(Type IPEHBAMCGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x64851C0", Offset = "0x64839C0", VA = "0x1864851C0")]
	public static Dictionary<string, PJOEGCAHOHD> NAGLDHOFDFN(Type IPEHBAMCGNG, ICNJNJEFLLJ EEKMHJNEFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x64857E0", Offset = "0x6483FE0", VA = "0x1864857E0")]
	public static Dictionary<int, string> PHGHIOMJALJ(Dictionary<string, PJOEGCAHOHD> KJFIHMLIKBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class ADAKJEKAPKL
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int EDKAAKOIILD = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int BJCDJJFGFEP = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class NMAGGNFKDKP<THandle, TValue> : IDisposable where THandle : struct, NHMOKLKPBCB where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<THandle> CLIFHNNOFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<TValue> HIFHKLOJLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Func<TValue> APLLAHPLMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Action<TValue> GPLDAKPHNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int JIJANJBHPGN;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AF95A0", Offset = "0x2AF7DA0", VA = "0x182AF95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9860", Offset = "0x2AF8060", VA = "0x182AF9860")]
	public NMAGGNFKDKP(Action<TValue> GPLDAKPHNNF, [Optional] Func<TValue> APLLAHPLMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8EF0", Offset = "0x2AF76F0", VA = "0x182AF8EF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AF95D0", Offset = "0x2AF7DD0", VA = "0x182AF95D0")]
	public THandle OJONNLHFKNA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9470", Offset = "0x2AF7C70", VA = "0x182AF9470")]
	public THandle LGCDELLOPGJ(TValue NPHADDCNBHE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8CE0", Offset = "0x2AF74E0", VA = "0x182AF8CE0")]
	public bool ALIFOBNBCOA(THandle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9040", Offset = "0x2AF7840", VA = "0x182AF9040")]
	public bool FOAPFFHPHEB(THandle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9110", Offset = "0x2AF7910", VA = "0x182AF9110")]
	public bool GKBJHBOCHEL(THandle AEGKMFNDGLH, out TValue NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AF91B0", Offset = "0x2AF79B0", VA = "0x182AF91B0")]
	public TValue HEJAGBNBHFE(THandle AEGKMFNDGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF93B0", Offset = "0x2AF7BB0", VA = "0x182AF93B0")]
	public bool JONADHNAPOD(THandle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8CB0", Offset = "0x2AF74B0", VA = "0x182AF8CB0")]
	private THandle AKOEOGIAJAI(int LHHBOCAHDEE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9310", Offset = "0x2AF7B10", VA = "0x182AF9310")]
	private TValue JCAOJAAFFGN(int LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8D90", Offset = "0x2AF7590", VA = "0x182AF8D90")]
	private void CNMBJJDFNLN(int LHHBOCAHDEE, in THandle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AF94E0", Offset = "0x2AF7CE0", VA = "0x182AF94E0")]
	private void LPDBNOLGMBP(int LHHBOCAHDEE, in TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9200", Offset = "0x2AF7A00", VA = "0x182AF9200")]
	private THandle IEEIDLPBLAA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AF97B0", Offset = "0x2AF7FB0", VA = "0x182AF97B0")]
	private void PINMAMMNINN(THandle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9460", Offset = "0x2AF7C60", VA = "0x182AF9460")]
	private int KPADFNJPIPF(int OGPINCOPHCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9340", Offset = "0x2AF7B40", VA = "0x182AF9340")]
	private bool JIGHLCIBDIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x73C580", Offset = "0x73AD80", VA = "0x18073C580")]
	private void GOEKKOKNAIG(THandle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9520", Offset = "0x2AF7D20", VA = "0x182AF9520")]
	private bool NGHKBDCKLFP(out THandle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8F70", Offset = "0x2AF7770", VA = "0x182AF8F70")]
	private bool EAENCJEEJFK(out THandle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2AF9350", Offset = "0x2AF7B50", VA = "0x182AF9350")]
	private void JLCPAPOCFMN(THandle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8DD0", Offset = "0x2AF75D0", VA = "0x182AF8DD0")]
	private void DKGJLALNNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface NHMOKLKPBCB
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface DOCOAIDEBOB<T> : NHMOKLKPBCB, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class MOADILNINKO
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xCF3A50", Offset = "0xCF2250", VA = "0x180CF3A50")]
	public static bool HKJMOKEJKKL<T>(this T AEGKMFNDGLH, T HAKPJJGEGOM) where T : struct, NHMOKLKPBCB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6440", Offset = "0x2AA4C40", VA = "0x182AA6440")]
	public static bool HOFMIBPEMEM<T>(this T AEGKMFNDGLH) where T : struct, NHMOKLKPBCB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6481D90", Offset = "0x6480590", VA = "0x186481D90")]
	public static string IIPFCPJHIGK(this NHMOKLKPBCB AEGKMFNDGLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class OLPHBAPELAL
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum MFLLDIEDFDC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int MNONHEHGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool MACMCFPLOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private MFLLDIEDFDC DMJFIAAGODA;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool BOMLFOCAALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6483D10", Offset = "0x6482510", VA = "0x186483D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool KHPNDLANENF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x64840C0", Offset = "0x64828C0", VA = "0x1864840C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x64847E0", Offset = "0x6482FE0", VA = "0x1864847E0")]
	public OLPHBAPELAL(bool MACMCFPLOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6484160", Offset = "0x6482960", VA = "0x186484160")]
	public void PEFKKMAFGFJ(object BFHAMCLNCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6484020", Offset = "0x6482820", VA = "0x186484020")]
	public void NFKOODHIFPK(int NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6483E00", Offset = "0x6482600", VA = "0x186483E00")]
	public void IMFNDGEEIHM(uint MELCLAMGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6483F40", Offset = "0x6482740", VA = "0x186483F40")]
	public void LNBMPPKDAIC(bool KHGMHPAKPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6483FE0", Offset = "0x64827E0", VA = "0x186483FE0")]
	public void MPDJJPJMAHH(long MILLDFOBCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6483CD0", Offset = "0x64824D0", VA = "0x186483CD0")]
	public void GIJOPHKCCNL(ulong BMMBFIMMPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6483D20", Offset = "0x6482520", VA = "0x186483D20")]
	public void HHANIKELCAB(string AOEMKAJNLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x64840D0", Offset = "0x64828D0", VA = "0x1864840D0")]
	public void OJPICOCCHHM(Enum ODBOKKABIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6483E10", Offset = "0x6482610", VA = "0x186483E10")]
	public void LFMDIJAJDKH(IList HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x228E910", Offset = "0x228D110", VA = "0x18228E910")]
	public void AGGNCHCHAOE<T, U>(Dictionary<T, U> FBJCBJAIECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6483960", Offset = "0x6482160", VA = "0x186483960")]
	private void GCJIJFECPIB(IDictionary FBJCBJAIECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x64838F0", Offset = "0x64820F0", VA = "0x1864838F0")]
	public int DJJOLLEGGDM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6483D90", Offset = "0x6482590", VA = "0x186483D90")]
	public short ICHECCKBOGJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6483FD0", Offset = "0x64827D0", VA = "0x186483FD0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6483F60", Offset = "0x6482760", VA = "0x186483F60")]
	private void MJBBFCGDKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class NBHMDICHKCK<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class HDGJIECLIKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode DCJNPPINKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode FAAJOMIIHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NIEBBJGEJJG NNANCGDEKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<NIEBBJGEJJG> PLDNKLELKKL;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public HDGJIECLIKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct NIEBBJGEJJG : IComparable<NIEBBJGEJJG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int PPMAMPIHEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public TClaimant ICOBODMAPLJ;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7000B0", Offset = "0x6FE8B0", VA = "0x1807000B0")]
		public NIEBBJGEJJG(int PPMAMPIHEGB, TClaimant ICOBODMAPLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x34C5E20", Offset = "0x34C4620", VA = "0x1834C5E20")]
		public bool KANPLCOKICH(in NIEBBJGEJJG HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x34C5E80", Offset = "0x34C4680", VA = "0x1834C5E80")]
		public bool KOHOFDKOFAN(in NIEBBJGEJJG HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x34C5E10", Offset = "0x34C4610", VA = "0x1834C5E10", Slot = "4")]
		public int CompareTo(NIEBBJGEJJG HAKPJJGEGOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x34C5E90", Offset = "0x34C4690", VA = "0x1834C5E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum MCFGGPBADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IGHMLNBKCBJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public global::NBHMDICHKCK<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1815300", Offset = "0x1813B00", VA = "0x181815300")]
		[DebuggerHidden]
		public IGHMLNBKCBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1815100", Offset = "0x1813900", VA = "0x181815100", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x18152C0", Offset = "0x1813AC0", VA = "0x1818152C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x18151E0", Offset = "0x18139E0", VA = "0x1818151E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x106C130", Offset = "0x106A930", VA = "0x18106C130", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::GJGIMLGOJLB<HDGJIECLIKH> MJIHJICPEAA;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::GJGIMLGOJLB<List<NIEBBJGEJJG>> GOIEFNMCLNK;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int DCDLODDAAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TClaimant, TNode> MCKDOEFFFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TNode, HDGJIECLIKH> JHAEJLBMDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private MCFGGPBADGJ BCBFMICMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PHLGOOAEONB(TNode KFMDDCEOFLE);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JIBDKFNAKBD(TNode KFMDDCEOFLE, TClaimant CLCOGCPKJDB, TClaimant ECHAKJAMCON);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2E3CE90", Offset = "0x2E3B690", VA = "0x182E3CE90")]
	public NBHMDICHKCK(MCFGGPBADGJ BCBFMICMNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2E3BCD0", Offset = "0x2E3A4D0", VA = "0x182E3BCD0")]
	public void ECPDHAGGFPC(TNode KFMDDCEOFLE, TNode ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2E3CAA0", Offset = "0x2E3B2A0", VA = "0x182E3CAA0")]
	public void OFNGOAIKGFL(TClaimant ICOBODMAPLJ, TNode LLAHDBNDEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3BA70", Offset = "0x2E3A270", VA = "0x182E3BA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C8F0", Offset = "0x2E3B0F0", VA = "0x182E3C8F0")]
	private void LFKCBCJBECK(TClaimant ICOBODMAPLJ, TNode DIGODEFNFOH, TNode LLAHDBNDEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B850", Offset = "0x2E3A050", VA = "0x182E3B850")]
	private int CDEKANEHLMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C640", Offset = "0x2E3AE40", VA = "0x182E3C640")]
	private void LBKOPPFFCEM(TClaimant ICOBODMAPLJ, TNode LCAJGOLIEBE, TNode NAFEMOBEBGH, int PKOGMNNGOOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C5B0", Offset = "0x2E3ADB0", VA = "0x182E3C5B0")]
	private void JHNJCHBPOBJ(NIEBBJGEJJG HGKPKGCKOFC, HDGJIECLIKH BMBLDMPPAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2E3BD50", Offset = "0x2E3A550", VA = "0x182E3BD50")]
	private void EFIKADFBNMN(TClaimant ICOBODMAPLJ, TNode LCAJGOLIEBE, TNode NAFEMOBEBGH, int PKOGMNNGOOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B740", Offset = "0x2E39F40", VA = "0x182E3B740")]
	private void BBDPAOJMCID(NIEBBJGEJJG HGKPKGCKOFC, TNode KFMDDCEOFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C320", Offset = "0x2E3AB20", VA = "0x182E3C320")]
	private void FMLFCMBAAEG(NIEBBJGEJJG HGKPKGCKOFC, HDGJIECLIKH BMBLDMPPAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C990", Offset = "0x2E3B190", VA = "0x182E3C990")]
	private void MBPKFNHILND(HDGJIECLIKH BMBLDMPPAAE, bool NDKHEGDNBPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2E3BFB0", Offset = "0x2E3A7B0", VA = "0x182E3BFB0")]
	private void EIKEHBCKLKB(HDGJIECLIKH BMBLDMPPAAE, TNode ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C4E0", Offset = "0x2E3ACE0", VA = "0x182E3C4E0")]
	[IteratorStateMachine(typeof(global::NBHMDICHKCK<, >.IGHMLNBKCBJ))]
	private IEnumerable<TNode> JGLMMOFMPIH(TNode LCAJGOLIEBE, TNode NAFEMOBEBGH, bool EANNDCGJFME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C420", Offset = "0x2E3AC20", VA = "0x182E3C420")]
	private HDGJIECLIKH IFMLKALDMAL(TNode KFMDDCEOFLE, TNode FAAJOMIIHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2E3CBA0", Offset = "0x2E3B3A0", VA = "0x182E3CBA0")]
	private HDGJIECLIKH OKNBLCPPMOI(TNode KFMDDCEOFLE, TNode FAAJOMIIHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B8B0", Offset = "0x2E3A0B0", VA = "0x182E3B8B0")]
	private void DJDLABJINOC(HDGJIECLIKH BMBLDMPPAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class CILOHBCIGJO<T> : IEnumerable<global::CILOHBCIGJO<T>.GBIBFOAKJHH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct GBIBFOAKJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public T NPHADDCNBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int LHHBOCAHDEE;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class PCGNKEBCFBI : IEnumerator<GBIBFOAKJHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private global::CILOHBCIGJO<T> JFGKCBHLINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int LHHBOCAHDEE;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x10624B0", Offset = "0x1060CB0", VA = "0x1810624B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public GBIBFOAKJHH ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2F06E60", Offset = "0x2F05660", VA = "0x182F06E60", Slot = "4")]
			get
			{
				return default(GBIBFOAKJHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6D9060", Offset = "0x6D7860", VA = "0x1806D9060")]
		public PCGNKEBCFBI(global::CILOHBCIGJO<T> JFGKCBHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2F06DE0", Offset = "0x2F055E0", VA = "0x182F06DE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6D9050", Offset = "0x6D7850", VA = "0x1806D9050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xC0FDA0", Offset = "0xC0E5A0", VA = "0x180C0FDA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct JLHOIEKHNLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool MFGCODBPDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T NPHADDCNBHE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int PNMDIPBHHBM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<T, int> CHDHFIFCIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private JLHOIEKHNLG[] DFOAGPGLCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private int OMPLHGLGIFH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int PBLHOPBGKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D90", Offset = "0x6F4590", VA = "0x1806F5D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x86DCE0", Offset = "0x86C4E0", VA = "0x18086DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x17FF070", Offset = "0x17FD870", VA = "0x1817FF070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x28D54B0", Offset = "0x28D3CB0", VA = "0x1828D54B0")]
	public CILOHBCIGJO(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x28D5590", Offset = "0x28D3D90", VA = "0x1828D5590")]
	public CILOHBCIGJO(GBIBFOAKJHH[] EMOPCAELCKI, bool PKDIIHJAKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x28D44B0", Offset = "0x28D2CB0", VA = "0x1828D44B0")]
	public int GJOILHIIMMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x28D3DC0", Offset = "0x28D25C0", VA = "0x1828D3DC0")]
	private int COMCOAMKPNC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x28D4FE0", Offset = "0x28D37E0", VA = "0x1828D4FE0", Slot = "6")]
	protected virtual uint PDCGPFJCAKJ(uint MNONHEHGNJF, T NPHADDCNBHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x28D4F70", Offset = "0x28D3770", VA = "0x1828D4F70")]
	public bool NMLBCGMOIKM(T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28D4DF0", Offset = "0x28D35F0", VA = "0x1828D4DF0")]
	public bool LIIEAAMBFPO(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x28D45E0", Offset = "0x28D2DE0", VA = "0x1828D45E0")]
	public bool JEBNAOILLLF(Func<T, bool> EPGENEEAIGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28D4E40", Offset = "0x28D3640", VA = "0x1828D4E40")]
	public int MCHCCKJHAGM(T NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x28D4520", Offset = "0x28D2D20", VA = "0x1828D4520")]
	public T JCAOJAAFFGN(int LHHBOCAHDEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x28D4EF0", Offset = "0x28D36F0", VA = "0x1828D4EF0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x28D4B90", Offset = "0x28D3390", VA = "0x1828D4B90")]
	public bool KIPDGIEJLFO(T NPHADDCNBHE, bool CEFOAABLMBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x28D4990", Offset = "0x28D3190", VA = "0x1828D4990")]
	public bool KIPDGIEJLFO(T NPHADDCNBHE, int LHHBOCAHDEE, bool CEFOAABLMBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x28D3C90", Offset = "0x28D2490", VA = "0x1828D3C90")]
	public bool ALIFOBNBCOA(T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x28D41B0", Offset = "0x28D29B0", VA = "0x1828D41B0")]
	public bool DCPLCAPJDEC(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x28D4BD0", Offset = "0x28D33D0", VA = "0x1828D4BD0")]
	private void LELMLBOJMBP(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x28D4370", Offset = "0x28D2B70", VA = "0x1828D4370")]
	public GBIBFOAKJHH[] DDHHGNBIMIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x28D3D20", Offset = "0x28D2520", VA = "0x1828D3D20")]
	private int ANKBEMEFCNE(int HCGAJDKMOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x28D5030", Offset = "0x28D3830", VA = "0x1828D5030", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x28D5030", Offset = "0x28D3830", VA = "0x1828D5030", Slot = "4")]
	private IEnumerator<GBIBFOAKJHH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct KHGLFMKAPAH<Handle> where Handle : NHMOKLKPBCB, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct MJPIKFMHCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly global::KHGLFMKAPAH<Handle> LDPBJIJFPPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int LHHBOCAHDEE;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int MECCEOIJLLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2FB1820", Offset = "0x2FB0020", VA = "0x182FB1820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle BABNKADGGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2FB0EA0", Offset = "0x2FAF6A0", VA = "0x182FB0EA0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1C60", Offset = "0x2FB0460", VA = "0x182FB1C60")]
		public MJPIKFMHCBD(global::KHGLFMKAPAH<Handle> LDPBJIJFPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1680", Offset = "0x2FAFE80", VA = "0x182FB1680")]
		public LMKPAEHENAK HHEHBEMBBBF(in LMKPAEHENAK OJHEBILAHKN)
		{
			return default(LMKPAEHENAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2FB15E0", Offset = "0x2FAFDE0", VA = "0x182FB15E0")]
		public CGMNGHJIGBG HHEHBEMBBBF(in CGMNGHJIGBG OJHEBILAHKN)
		{
			return default(CGMNGHJIGBG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2FB14C0", Offset = "0x2FAFCC0", VA = "0x182FB14C0")]
		public bool GNDCJMNCJLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1B20", Offset = "0x2FB0320", VA = "0x182FB1B20")]
		private int LMAADGFOKNH(string EPAIMCEIMPA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0AA0", Offset = "0x2FAF2A0", VA = "0x182FB0AA0")]
		private Handle DHABKMJMMCN(string EPAIMCEIMPA)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct LMKPAEHENAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private MJPIKFMHCBD IFNCOKHOLNM;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2FE83D0", Offset = "0x2FE6BD0", VA = "0x182FE83D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x28CEED0", Offset = "0x28CD6D0", VA = "0x1828CEED0")]
		public LMKPAEHENAK(global::KHGLFMKAPAH<Handle> LDPBJIJFPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x28CEDD0", Offset = "0x28CD5D0", VA = "0x1828CEDD0")]
		public bool GNDCJMNCJLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8410", Offset = "0x2FE6C10", VA = "0x182FE8410")]
		public LMKPAEHENAK GCCEKDHECEG()
		{
			return default(LMKPAEHENAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct CGMNGHJIGBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MJPIKFMHCBD IFNCOKHOLNM;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x28CED10", Offset = "0x28CD510", VA = "0x1828CED10")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x28CEED0", Offset = "0x28CD6D0", VA = "0x1828CEED0")]
		public CGMNGHJIGBG(global::KHGLFMKAPAH<Handle> LDPBJIJFPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x28CEDD0", Offset = "0x28CD5D0", VA = "0x1828CEDD0")]
		public bool GNDCJMNCJLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x28CED50", Offset = "0x28CD550", VA = "0x1828CED50")]
		public CGMNGHJIGBG GCCEKDHECEG()
		{
			return default(CGMNGHJIGBG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> LPKFMJCCDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> JPPLGPBICHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int NDFHFGFLMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int AKONAIFHPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool GCKPDOGEGPL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool IMLDPEBIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int LBDHOLBKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2607820", Offset = "0x2606020", VA = "0x182607820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int AABABPEKCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5010", Offset = "0x6D3810", VA = "0x1806D5010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CPLJAAJNJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5010", Offset = "0x6D3810", VA = "0x1806D5010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LMKPAEHENAK KNMFOEIHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x26062F0", Offset = "0x2604AF0", VA = "0x1826062F0")]
		get
		{
			return default(LMKPAEHENAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public CGMNGHJIGBG EOJEJNOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2606980", Offset = "0x2605180", VA = "0x182606980")]
		get
		{
			return default(CGMNGHJIGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2608A80", Offset = "0x2607280", VA = "0x182608A80")]
	public KHGLFMKAPAH(int DKJBFNPJKJK, Allocator OODGOAPHOCI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2607020", Offset = "0x2605820", VA = "0x182607020")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x191E050", Offset = "0x191C850", VA = "0x18191E050")]
	public static int KPADFNJPIPF(int BKHPIBPDKLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2607E60", Offset = "0x2606660", VA = "0x182607E60")]
	public static bool MLJKLENLKBJ(int BKHPIBPDKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x26087B0", Offset = "0x2606FB0", VA = "0x1826087B0")]
	public static bool OOBBGACKIKE(int BKHPIBPDKLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2608250", Offset = "0x2606A50", VA = "0x182608250")]
	public bool NGAHLCAAIJJ(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2606A20", Offset = "0x2605220", VA = "0x182606A20")]
	public bool HIGGOMKBEPM(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2607550", Offset = "0x2605D50", VA = "0x182607550")]
	public bool JBGHBGCFLGN(Handle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2605370", Offset = "0x2603B70", VA = "0x182605370")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BJNIFPJBNLL(Handle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2606150", Offset = "0x2604950", VA = "0x182606150")]
	public Handle BOKEKHKKBHO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2605070", Offset = "0x2603870", VA = "0x182605070")]
	public void AIIGJCNFIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2608730", Offset = "0x2606F30", VA = "0x182608730")]
	public void OCIMCKMMDDJ(Handle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x26087C0", Offset = "0x2606FC0", VA = "0x1826087C0")]
	public bool PAIMNCLKKKO(Handle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0")]
	private bool LEMKGOMGDNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2604620", Offset = "0x2602E20", VA = "0x182604620")]
	private bool AAIHCILKCIL(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2607B80", Offset = "0x2606380", VA = "0x182607B80")]
	private void MLAGJOLAJJJ(out int LHHBOCAHDEE, out int OGPINCOPHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x26066F0", Offset = "0x2604EF0", VA = "0x1826066F0")]
	private void DADKPFHIHCA(Handle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2607750", Offset = "0x2605F50", VA = "0x182607750")]
	private void KBEFHFMLMAK(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2607E70", Offset = "0x2606670", VA = "0x182607E70")]
	private bool NCOMIDLLCFN(out int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x26067F0", Offset = "0x2604FF0", VA = "0x1826067F0")]
	private static Handle EHOOKIBMNMM(int LHHBOCAHDEE, int OGPINCOPHCL)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct IBOAEEDDPMB<Handle, T> where Handle : NHMOKLKPBCB, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private global::KHGLFMKAPAH<Handle> JLKALLEIINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private T[] CKDGGKFHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Action<T> IDNBILAGOII;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IMLDPEBIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1807470", Offset = "0x1805C70", VA = "0x181807470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int LBDHOLBKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x18073B0", Offset = "0x1805BB0", VA = "0x1818073B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x18052A0", Offset = "0x1803AA0", VA = "0x1818052A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1807530", Offset = "0x1805D30", VA = "0x181807530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x1807590", Offset = "0x1805D90", VA = "0x181807590")]
	public IBOAEEDDPMB(int DKJBFNPJKJK, [Optional] Action<T> IDNBILAGOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1806B80", Offset = "0x1805380", VA = "0x181806B80")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x1806D80", Offset = "0x1805580", VA = "0x181806D80")]
	public bool JBGHBGCFLGN(Handle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BJNIFPJBNLL(Handle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1806A30", Offset = "0x1805230", VA = "0x181806A30")]
	public T HEJAGBNBHFE(Handle AEGKMFNDGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x1806980", Offset = "0x1805180", VA = "0x181806980")]
	public bool GKBJHBOCHEL(Handle AEGKMFNDGLH, out T BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x18053F0", Offset = "0x1803BF0", VA = "0x1818053F0")]
	public void BJPKOCBPDKP(Handle AEGKMFNDGLH, T HFFBOCIFCID, out T HMFGMOFAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x18052D0", Offset = "0x1803AD0", VA = "0x1818052D0")]
	public void BJPKOCBPDKP(Handle AEGKMFNDGLH, T HFFBOCIFCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1806570", Offset = "0x1804D70", VA = "0x181806570")]
	public bool GGODOINIDBK(Handle AEGKMFNDGLH, T HFFBOCIFCID, out T HMFGMOFAMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x18061B0", Offset = "0x18049B0", VA = "0x1818061B0")]
	public bool GGODOINIDBK(Handle AEGKMFNDGLH, T HFFBOCIFCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x1807140", Offset = "0x1805940", VA = "0x181807140")]
	public Handle LGCDELLOPGJ(T BFHAMCLNCKB)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1805710", Offset = "0x1803F10", VA = "0x181805710")]
	public void FCALJBKACDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x1805100", Offset = "0x1803900", VA = "0x181805100")]
	public void ALIFOBNBCOA(Handle AEGKMFNDGLH, out T HMFGMOFAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1804CB0", Offset = "0x18034B0", VA = "0x181804CB0")]
	public void ALIFOBNBCOA(Handle AEGKMFNDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1804740", Offset = "0x1802F40", VA = "0x181804740")]
	public bool AGBHGIPKAHC(Handle AEGKMFNDGLH, out T HMFGMOFAMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1804580", Offset = "0x1802D80", VA = "0x181804580")]
	public bool AGBHGIPKAHC(Handle AEGKMFNDGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x18056B0", Offset = "0x1803EB0", VA = "0x1818056B0")]
	private T DCPLCAPJDEC(int LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1806E70", Offset = "0x1805670", VA = "0x181806E70")]
	private void KHJOJBFPAAN(int AJEHGHAKFLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class GJGIMLGOJLB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<T> LDPBJIJFPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<T> FJLNKMFPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int JPEBPPPJGCE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int EHDAGJECHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2730DD0", Offset = "0x272F5D0", VA = "0x182730DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int JHJANLHJFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x17FE080", Offset = "0x17FC880", VA = "0x1817FE080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2730AF0", Offset = "0x272F2F0", VA = "0x182730AF0")]
	public static global::GJGIMLGOJLB<T> GJBNELPPHDC(int EBGHKBFPDCN = 0, int JPEBPPPJGCE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2730E00", Offset = "0x272F600", VA = "0x182730E00")]
	public static global::GJGIMLGOJLB<T> OPOLBNIAEHP(int EBGHKBFPDCN = 0, int JPEBPPPJGCE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2731200", Offset = "0x272FA00", VA = "0x182731200")]
	public GJGIMLGOJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2731070", Offset = "0x272F870", VA = "0x182731070")]
	public GJGIMLGOJLB(int EBGHKBFPDCN, int JPEBPPPJGCE = int.MaxValue, bool FJDGOCEKPPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2730F60", Offset = "0x272F760", VA = "0x182730F60")]
	public T PGMJAIHGBCK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x27307E0", Offset = "0x272EFE0", VA = "0x1827307E0")]
	public void BBLGJGOPDHE(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2730930", Offset = "0x272F130", VA = "0x182730930")]
	private void CAJENMHFDOD(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2730890", Offset = "0x272F090", VA = "0x182730890")]
	private void BIAKPGFECCD(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x27308B0", Offset = "0x272F0B0", VA = "0x1827308B0")]
	[Conditional("DEBUG_BUILD")]
	private void BODFPBAOMEP(T IGPJBJAAPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2730ED0", Offset = "0x272F6D0", VA = "0x182730ED0")]
	[Conditional("DEBUG_BUILD")]
	private void PEFPCCOIONE(T IGPJBJAAPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2730A00", Offset = "0x272F200", VA = "0x182730A00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2730BC0", Offset = "0x272F3C0", VA = "0x182730BC0")]
	private void HJPPAJONIEE(IEnumerable<T> HIFHKLOJLMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class OCPKNPFNIPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private Dictionary<int, T> OCGEHIBMPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T KHFPBBIGPJG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T LCFAFHOFBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool FGMANIIINBB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x36A9A20", Offset = "0x36A8220", VA = "0x1836A9A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x36A9AF0", Offset = "0x36A82F0", VA = "0x1836A9AF0")]
	public bool FENFGKNKPAA(T NPHADDCNBHE, int PPMAMPIHEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x36A9A60", Offset = "0x36A8260", VA = "0x1836A9A60")]
	public bool EENKDCDPDEH(int PPMAMPIHEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x36A9DB0", Offset = "0x36A85B0", VA = "0x1836A9DB0")]
	public T JNDFOPDCANG(int ENDBIDOLPNH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x36A9FA0", Offset = "0x36A87A0", VA = "0x1836A9FA0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x36AA000", Offset = "0x36A8800", VA = "0x1836AA000")]
	private bool OFPONFNEPHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x36A9AC0", Offset = "0x36A82C0", VA = "0x1836A9AC0")]
	public bool FEEDILOKHNP(int PPMAMPIHEGB, out T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x36AA1A0", Offset = "0x36A89A0", VA = "0x1836AA1A0")]
	public OCPKNPFNIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class LCBCHKGEHGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct GIGPEPJOMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T PPNOOBBHMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int FNGEIJLLAKM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<GIGPEPJOMIM> GOEABKOLGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T DNDNCIDDAOG;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x17FF070", Offset = "0x17FD870", VA = "0x1817FF070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D380", Offset = "0x1C6BB80", VA = "0x181C6D380")]
	public bool JEBNAOILLLF(T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D600", Offset = "0x1C6BE00", VA = "0x181C6D600")]
	public void LGCDELLOPGJ(T NPHADDCNBHE, int PPMAMPIHEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D030", Offset = "0x1C6B830", VA = "0x181C6D030")]
	public bool ALIFOBNBCOA(T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D6A0", Offset = "0x1C6BEA0", VA = "0x181C6D6A0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D590", Offset = "0x1C6BD90", VA = "0x181C6D590")]
	public T LEEKIPAAPDG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D150", Offset = "0x1C6B950", VA = "0x181C6D150")]
	public T ELOFHGKBDPI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D1C0", Offset = "0x1C6B9C0", VA = "0x181C6D1C0")]
	private void HGAANCIBABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D700", Offset = "0x1C6BF00", VA = "0x181C6D700")]
	public LCBCHKGEHGG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x6485C40", Offset = "0x6484440", VA = "0x186485C40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x6485FD0", Offset = "0x64847D0", VA = "0x186485FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x6485E50", Offset = "0x6484650", VA = "0x186485E50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x6486130", Offset = "0x6484930", VA = "0x186486130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x6485B60", Offset = "0x6484360", VA = "0x186485B60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x6485EF0", Offset = "0x64846F0", VA = "0x186485EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6485D70", Offset = "0x6484570", VA = "0x186485D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6485B10", Offset = "0x6484310", VA = "0x186485B10")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface ANLCBPPDDKA
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : ANLCBPPDDKA where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x295BA60", Offset = "0x295A260", VA = "0x18295BA60", Slot = "4")]
		public virtual T NJPKDACAEMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class OIFALENMOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Dictionary<byte, BNMDOMJLDMB> LDJEAJGAMIF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BNMDOMJLDMB LBLHBEBIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 NLBPBJONHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1161850", Offset = "0x1160050", VA = "0x181161850")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x71ED20", Offset = "0x71D520", VA = "0x18071ED20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 PJGANPCKPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x18185D0", Offset = "0x1816DD0", VA = "0x1818185D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0x9FF760", VA = "0x180A00F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 CIFHBPOBKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6482E90", Offset = "0x6481690", VA = "0x186482E90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE995C0", Offset = "0xE97DC0", VA = "0x180E995C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int CFCCKJLIOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D50E0", Offset = "0x6D38E0", VA = "0x1806D50E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x73C580", Offset = "0x73AD80", VA = "0x18073C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6483490", Offset = "0x6481C90", VA = "0x186483490")]
	public OIFALENMOLB(Bounds LOAMMONCMOL, Vector2[] EBKNECAHHPM, int AIDMLHMHMPF, byte HCGAJDKMOED, float BFGFPJJBIAL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6483030", Offset = "0x6481830", VA = "0x186483030")]
	public BNMDOMJLDMB MMHDHNPCDOD(byte LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6482D90", Offset = "0x6481590", VA = "0x186482D90")]
	public void BAEPOFNCJFI(Vector3 LMLCHIPKJPI, float KGEIPJFJMII, float LGCICLDJIHD, ref List<byte> GDOOJEECKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6482EB0", Offset = "0x64816B0", VA = "0x186482EB0")]
	public void BKFDAHDPMOO(BNMDOMJLDMB.OLANMADFJKJ ONPNCEJKDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6482ED0", Offset = "0x64816D0", VA = "0x186482ED0")]
	private BNMDOMJLDMB IEBHLPNEAMJ(byte LHHBOCAHDEE, BNMDOMJLDMB.BAOADOHBBND JNLFKAPABNL, BNMDOMJLDMB FAAJOMIIHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6483090", Offset = "0x6481890", VA = "0x186483090")]
	private void PICKFDMINJH(BNMDOMJLDMB FAAJOMIIHED, Vector2[] EBKNECAHHPM, int CILBFLDIPCE, int INKEFCKAHLB, int NIBMPHDPLPJ, int FNECMAPAHKD, float BFGFPJJBIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class BNMDOMJLDMB
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum BAOADOHBBND
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum OLANMADFJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public byte HJBBBJOEKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 ELHKBFLEJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 FNJAAMNIGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 DCPAHJDKFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 JABGELPKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public BAOADOHBBND JHGKMPGJFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public BNMDOMJLDMB MINIKDOMMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<BNMDOMJLDMB> ABHPGFMMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public bool HDLJNFBKHFJ;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6480440", Offset = "0x647EC40", VA = "0x186480440")]
	public BNMDOMJLDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x64803E0", Offset = "0x647EBE0", VA = "0x1864803E0")]
	public BNMDOMJLDMB(byte MKEJJPNNCOG, BAOADOHBBND JNLFKAPABNL, BNMDOMJLDMB FAAJOMIIHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6480320", Offset = "0x647EB20", VA = "0x186480320")]
	public void NCDGFNDBKNE(BNMDOMJLDMB PLIEEOJAEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public void BKFDAHDPMOO(int ILKAODLHENI, OLANMADFJKJ ONPNCEJKDMA, int DLBKLHDLMDL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6480030", Offset = "0x647E830", VA = "0x186480030")]
	public void BAEPOFNCJFI(List<byte> GDOOJEECKGD, Vector3 LMLCHIPKJPI, float KGEIPJFJMII, float LGCICLDJIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x647FFE0", Offset = "0x647E7E0", VA = "0x18647FFE0")]
	public bool AMGMACAHMOM(Vector3 JHCOKPMEFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x64802E0", Offset = "0x647EAE0", VA = "0x1864802E0")]
	public bool IGCKDJFMOGG(Vector3 JHCOKPMEFAB, float LLJIJIJAFAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class CMNDEDGODBF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Dictionary<T, object> NBODFKBEEPN;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2724440", Offset = "0x2722C40", VA = "0x182724440")]
	public bool KJACDCJHEGJ(T HPLCCPKFJDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x28D75D0", Offset = "0x28D5DD0", VA = "0x1828D75D0")]
	public bool KJACDCJHEGJ(T HPLCCPKFJDJ, object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x28D7610", Offset = "0x28D5E10", VA = "0x1828D7610")]
	public bool KJACDCJHEGJ(T HPLCCPKFJDJ, object JPCLKLIDFBB, out object LHPKLEOKAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x28D7420", Offset = "0x28D5C20", VA = "0x1828D7420")]
	public bool BOBPMJMAMPB(T HPLCCPKFJDJ, object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x28D74F0", Offset = "0x28D5CF0", VA = "0x1828D74F0")]
	public bool EOFJCLMHMNA(T HPLCCPKFJDJ, object JPCLKLIDFBB, out object LHPKLEOKAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x28D7460", Offset = "0x28D5C60", VA = "0x1828D7460")]
	public bool BOBPMJMAMPB(T HPLCCPKFJDJ, object JPCLKLIDFBB, out object LHPKLEOKAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x28D73F0", Offset = "0x28D5BF0", VA = "0x1828D73F0")]
	public void AGKBLOCGIBB(T HPLCCPKFJDJ, object JPCLKLIDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x28D7530", Offset = "0x28D5D30", VA = "0x1828D7530")]
	public void IMKILLCLLPE(T HPLCCPKFJDJ, object JPCLKLIDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x28D7670", Offset = "0x28D5E70", VA = "0x1828D7670")]
	public CMNDEDGODBF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public struct NFDEHICFCFC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> HGPMCGJIADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool ADAJHJNOOOJ;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A2F50", Offset = "0x8A1750", VA = "0x1808A2F50")]
			public NFDEHICFCFC(List<Component> HGPMCGJIADE, bool ADAJHJNOOOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x34B7330", Offset = "0x34B5B30", VA = "0x1834B7330")]
			public IGMDIOCNPDI<T> GCCEKDHECEG()
			{
				return default(IGMDIOCNPDI<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x34B73A0", Offset = "0x34B5BA0", VA = "0x1834B73A0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x34B73A0", Offset = "0x34B5BA0", VA = "0x1834B73A0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct IGMDIOCNPDI<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly List<Component> HGPMCGJIADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly bool ADAJHJNOOOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private int LHHBOCAHDEE;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T ILEBONKALNP
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x18182B0", Offset = "0x1816AB0", VA = "0x1818182B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x1818240", Offset = "0x1816A40", VA = "0x181818240", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x1818280", Offset = "0x1816A80", VA = "0x181818280")]
			public IGMDIOCNPDI(List<Component> HGPMCGJIADE, bool ADAJHJNOOOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x1818170", Offset = "0x1816970", VA = "0x181818170", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x1818180", Offset = "0x1816980", VA = "0x181818180", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1818230", Offset = "0x1816A30", VA = "0x181818230", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x6487EA0", Offset = "0x64866A0", VA = "0x186487EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6487E60", Offset = "0x6486660", VA = "0x186487E60")]
		public ToolHierarchyCache(GameObject HFJAINPDLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6487BF0", Offset = "0x64863F0", VA = "0x186487BF0")]
		private void ODGJJHFNDHJ(GameObject HFJAINPDLBF, bool HMGJFCJOMJC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6487D50", Offset = "0x6486550", VA = "0x186487D50")]
		public static void ODGJJHFNDHJ(GameObject HFJAINPDLBF, ref ToolHierarchyCache KOOFLAHMFBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x6487BE0", Offset = "0x64863E0", VA = "0x186487BE0")]
		public void LNPEMMMGCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6487AC0", Offset = "0x64862C0", VA = "0x186487AC0")]
		public void JGHPNBOKGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CD20", Offset = "0x2C5B520", VA = "0x182C5CD20")]
		public void DJAKOFHBGCP<T>(Action<T> BEHJPKINPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x6487B10", Offset = "0x6486310", VA = "0x186487B10")]
		public Component JOOFHGJFMJM(Type EHPFPOFFCEJ, bool ADAJHJNOOOJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C5D080", Offset = "0x2C5B880", VA = "0x182C5D080")]
		public T JOOFHGJFMJM<T>(bool ADAJHJNOOOJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x64879C0", Offset = "0x64861C0", VA = "0x1864879C0")]
		public NFDEHICFCFC<Component> GMMKGALMPGM(Type EHPFPOFFCEJ, bool ADAJHJNOOOJ = false)
		{
			return default(NFDEHICFCFC<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C5CFB0", Offset = "0x2C5B7B0", VA = "0x182C5CFB0")]
		public NFDEHICFCFC<T> GMMKGALMPGM<T>(bool ADAJHJNOOOJ = false) where T : class
		{
			return default(NFDEHICFCFC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x6487670", Offset = "0x6485E70", VA = "0x186487670")]
		public List<Component> FJNBIPPNLKO(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x64875F0", Offset = "0x6485DF0", VA = "0x1864875F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache NGMFABJMIHP, ToolHierarchyCache OMDBFFDAOFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6487A40", Offset = "0x6486240", VA = "0x186487A40", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BFHAMCLNCKB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class MABEBBBCPKH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int EBGHKBFPDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int IGJCMPBLNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<T> GDAMMKPBIEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2730DD0", Offset = "0x272F5D0", VA = "0x182730DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T MHBDBPNPBIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D93FE0", Offset = "0x2D927E0", VA = "0x182D93FE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T PCIEFLDPAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D93C10", Offset = "0x2D92410", VA = "0x182D93C10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T IKKJIGGPKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D93CC0", Offset = "0x2D924C0", VA = "0x182D93CC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D94110", Offset = "0x2D92910", VA = "0x182D94110")]
	public MABEBBBCPKH(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D93E40", Offset = "0x2D92640", VA = "0x182D93E40")]
	public void LGCDELLOPGJ(T INLIAGFMJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D93F20", Offset = "0x2D92720", VA = "0x182D93F20")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D94070", Offset = "0x2D92870", VA = "0x182D94070")]
	public void OPHIOJKCGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D93BC0", Offset = "0x2D923C0", VA = "0x182D93BC0")]
	public void CJLNMLDMDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D93CB0", Offset = "0x2D924B0", VA = "0x182D93CB0")]
	public void FMENIDNADNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class IHBKGKEDMKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool JPGEFINMABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private Action BEHJPKINPFB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static IHBKGKEDMKP HKANNLGHAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6481460", Offset = "0x647FC60", VA = "0x186481460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CJGGNOKILDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D9250", Offset = "0x6D7A50", VA = "0x1806D9250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xC0FD00", Offset = "0xC0E500", VA = "0x180C0FD00")]
	public IHBKGKEDMKP(Action BEHJPKINPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6481440", Offset = "0x647FC40", VA = "0x186481440")]
	public void MNPDJHGOCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6481440", Offset = "0x647FC40", VA = "0x186481440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class PMJEHIHHIMD
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6485990", Offset = "0x6484190", VA = "0x186485990")]
	public static void JPBDJMOHDKF(BGPIKFBGOJB NMLPMEPFPBC, string ODADNIFPCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	public static void JPBDJMOHDKF(IEnumerable<object> BPHLNCHBAFC, string ODADNIFPCPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class FPNHOCKDJIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct MPLPNNKKPEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int FNGEIJLLAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public T PPNOOBBHMAN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<object, MPLPNNKKPEH> OCGEHIBMPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly EqualityComparer<T> KECGKCEEPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private T KHFPBBIGPJG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T LCFAFHOFBJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05400", VA = "0x180C06C00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x25C3720", Offset = "0x25C1F20", VA = "0x1825C3720", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FGMANIIINBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x299B130", Offset = "0x2999930", VA = "0x18299B130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object FHPCODINIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x299BCA0", Offset = "0x299A4A0", VA = "0x18299BCA0")]
	public bool FENFGKNKPAA(T NPHADDCNBHE, object JPCLKLIDFBB, int PPMAMPIHEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x299B160", Offset = "0x2999960", VA = "0x18299B160")]
	public bool EENKDCDPDEH(object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x299B370", Offset = "0x2999B70", VA = "0x18299B370")]
	public bool FEEDILOKHNP(object JPCLKLIDFBB, out T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x26F2750", Offset = "0x26F0F50", VA = "0x1826F2750")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x299DC80", Offset = "0x299C480", VA = "0x18299DC80")]
	private bool OFPONFNEPHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x29A0140", Offset = "0x299E940", VA = "0x1829A0140")]
	public FPNHOCKDJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class NOHKAKINBKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<object, float> OCGEHIBMPLA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float EBANNBPAOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x118F400", Offset = "0x118DC00", VA = "0x18118F400")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE056E0", Offset = "0xE03EE0", VA = "0x180E056E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6482C60", Offset = "0x6481460", VA = "0x186482C60")]
	public void FENFGKNKPAA(float NPHADDCNBHE, object JPCLKLIDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6482AD0", Offset = "0x64812D0", VA = "0x186482AD0")]
	public void EENKDCDPDEH(object JPCLKLIDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6482B40", Offset = "0x6481340", VA = "0x186482B40")]
	private void FCNFJCKBCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6482CD0", Offset = "0x64814D0", VA = "0x186482CD0")]
	public NOHKAKINBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class FBDKOKCOMIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string FFOOJNCCACJ;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	public FBDKOKCOMIL(string KOELFFJHFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6480C80", Offset = "0x647F480", VA = "0x186480C80")]
	public FBDKOKCOMIL(UnityEngine.Object NGLOMOIDNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6480C30", Offset = "0x647F430", VA = "0x186480C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class BGPIKFBGOJB
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class ACMHGFFFOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ACMHGFFFOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x647DE30", Offset = "0x647C630", VA = "0x18647DE30")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private HashSet<object> BPHLNCHBAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int NIIKKCNFHAO;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> NGDMMBNHFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x647F8C0", Offset = "0x647E0C0", VA = "0x18647F8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GFNAMFBPCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x647F840", Offset = "0x647E040", VA = "0x18647F840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x647F750", Offset = "0x647DF50", VA = "0x18647F750")]
	public bool LGCDELLOPGJ(object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x647F650", Offset = "0x647DE50", VA = "0x18647F650")]
	public bool ALIFOBNBCOA(object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x647F6F0", Offset = "0x647DEF0", VA = "0x18647F6F0")]
	public bool JEBNAOILLLF(object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x647F850", Offset = "0x647E050", VA = "0x18647F850")]
	public void NEMPAMGCCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x647F990", Offset = "0x647E190", VA = "0x18647F990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BGPIKFBGOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class AAIILOAEPLK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct ELPBBFKKFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float BJPKJKFHFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T PPNOOBBHMAN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Dictionary<object, ELPBBFKKFBI> OCGEHIBMPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T CLNKCEFBDHO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T CHCDEAKBPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xFD8070", Offset = "0xFD6870", VA = "0x180FD8070", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1792320", Offset = "0x1790B20", VA = "0x181792320", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object POALGAAINFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool FGMANIIINBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x26F1E50", Offset = "0x26F0650", VA = "0x1826F1E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x26F2230", Offset = "0x26F0A30", VA = "0x1826F2230")]
	public bool FENFGKNKPAA(T NPHADDCNBHE, object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x26F1E90", Offset = "0x26F0690", VA = "0x1826F1E90")]
	public bool EENKDCDPDEH(object JPCLKLIDFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x26F2750", Offset = "0x26F0F50", VA = "0x1826F2750")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x26F1EF0", Offset = "0x26F06F0", VA = "0x1826F1EF0")]
	public bool FEEDILOKHNP(object JPCLKLIDFBB, out T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x26F2A80", Offset = "0x26F1280", VA = "0x1826F2A80")]
	private bool OFPONFNEPHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x26F3DE0", Offset = "0x26F25E0", VA = "0x1826F3DE0")]
	public AAIILOAEPLK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6484D60", Offset = "0x6483560", VA = "0x186484D60")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6484A10", Offset = "0x6483210", VA = "0x186484A10")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
