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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DCGIKKJOOAB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public DCGIKKJOOAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, OIFLPHEDDHM, DLGGDDOJLPK, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DFIDMFGDKCM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x825B10", Offset = "0x824310", VA = "0x180825B10")]
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
	[SerializeField]
	[CJNOLJIOLAL]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[CJNOLJIOLAL]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C767E0", Offset = "0x5C74FE0", VA = "0x185C767E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C767A0", Offset = "0x5C74FA0", VA = "0x185C767A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C76820", Offset = "0x5C75020", VA = "0x185C76820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C769D0", Offset = "0x5C751D0", VA = "0x185C769D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C76940", Offset = "0x5C75140", VA = "0x185C76940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EEE70", Offset = "0x7ED670", VA = "0x1807EEE70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86DFA0", Offset = "0x86C7A0", VA = "0x18086DFA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C76760", Offset = "0x5C74F60", VA = "0x185C76760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C768B0", Offset = "0x5C750B0", VA = "0x185C768B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C76290", Offset = "0x5C74A90", VA = "0x185C76290")]
	public void CopyBounds(SavedExtents GHNNCJBDHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C766B0", Offset = "0x5C74EB0", VA = "0x185C766B0")]
	public void SetLocalSpaceBounds(Bounds FNNPLMEOMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8A0D40", Offset = "0x89F540", VA = "0x1808A0D40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C766A0", Offset = "0x5C74EA0", VA = "0x185C766A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C762C0", Offset = "0x5C74AC0", VA = "0x185C762C0")]
	private void NICJOFOEJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C76480", Offset = "0x5C74C80", VA = "0x185C76480")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C75C20", Offset = "0x5C74420", VA = "0x185C75C20")]
	public static void CalculateLocalBoundsFor(GameObject AAAOHJGLLEG, [Out] Bounds FNNPLMEOMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C75B60", Offset = "0x5C74360", VA = "0x185C75B60")]
	private static void ANKAPGMNPMH(Bounds FCOICCIGANJ, Color AKPFACEFKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C766D0", Offset = "0x5C74ED0", VA = "0x185C766D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76A380", Offset = "0x768B80", VA = "0x18076A380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCB1610", Offset = "0xCAFE10", VA = "0x180CB1610")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x406DF40", Offset = "0x406C740", VA = "0x18406DF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public virtual void GMNDJCJPHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
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
	[DCGIKKJOOAB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x406DB20", Offset = "0x406C320", VA = "0x18406DB20", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x406C7C0", Offset = "0x406AFC0", VA = "0x18406C7C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x406DE70", Offset = "0x406C670", VA = "0x18406DE70")]
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
	private sealed class OECEDLAPGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public OECEDLAPGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DB50", Offset = "0x3D7C350", VA = "0x183D7DB50")]
		internal int IACFBAPIFNC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DCGIKKJOOAB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x30439E0", Offset = "0x30421E0", VA = "0x1830439E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3043A30", Offset = "0x3042230", VA = "0x183043A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x30438E0", Offset = "0x30420E0", VA = "0x1830438E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey EBICOEDOGKC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3043980", Offset = "0x3042180", VA = "0x183043980", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x30437C0", Offset = "0x3041FC0", VA = "0x1830437C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30434E0", Offset = "0x3041CE0", VA = "0x1830434E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3042980", Offset = "0x3041180", VA = "0x183042980", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3042920", Offset = "0x3041120", VA = "0x183042920", Slot = "14")]
	protected virtual string KMGLGJHNLHG(TKeyVal AEBKPGDLHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3042800", Offset = "0x3041000", VA = "0x183042800", Slot = "4")]
	public bool ContainsKey(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3043680", Offset = "0x3041E80", VA = "0x183043680", Slot = "5")]
	public bool TryGetValue(TKey EBICOEDOGKC, [Out] TVal IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3042850", Offset = "0x3041050", VA = "0x183042850", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3042850", Offset = "0x3041050", VA = "0x183042850", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30436D0", Offset = "0x3041ED0", VA = "0x1830436D0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IGIAEHINKKJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IJCHJHBDAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IJCHJHBDAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x36658D0", Offset = "0x36640D0", VA = "0x1836658D0")]
		internal bool MJJOCAOIIGN(ENDNJFNGIKC<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float IDKPGLIEEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PEMPFHNCOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<ENDNJFNGIKC<float, T>> MAFJBGOEIBN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int ONDLOIHHHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3662210", Offset = "0x3660A10", VA = "0x183662210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3662400", Offset = "0x3660C00", VA = "0x183662400")]
	public IGIAEHINKKJ(float PGLHFJDJDHP, float BFIFOOMCOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3662080", Offset = "0x3660880", VA = "0x183662080")]
	public bool KHKEGFDDKPO(float OBAHCJJDGLP, T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3661BE0", Offset = "0x36603E0", VA = "0x183661BE0")]
	public IEnumerable<T> DDLMAELOJLC(float OBAHCJJDGLP, [Optional] float? DDNNCHMDMJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36622F0", Offset = "0x3660AF0", VA = "0x1836622F0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3662320", Offset = "0x3660B20", VA = "0x183662320")]
	private void PJCEOGIFMOI(float OBAHCJJDGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class CJMLOMKIGOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PNGCONDLFDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T GNAEIIEFOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float CLLPKPBFFJA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float HNFHGANOPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> EDMCJPBBBHM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int FKJFNBFPJBP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PNGCONDLFDC[] JMHHCKCLFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int BKNEJMHEPOG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JGHPNPEGJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA8EBD0", Offset = "0xA8D3D0", VA = "0x180A8EBD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA8EBC0", Offset = "0xA8D3C0", VA = "0x180A8EBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F850", Offset = "0x4A5E050", VA = "0x184A5F850")]
	public CJMLOMKIGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F760", Offset = "0x4A5DF60", VA = "0x184A5F760")]
	public CJMLOMKIGOA(int NBNELMONDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A5ECD0", Offset = "0x4A5D4D0", VA = "0x184A5ECD0")]
	public void EIGFNHEIDIC(float OBAHCJJDGLP, T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F380", Offset = "0x4A5DB80", VA = "0x184A5F380")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F040", Offset = "0x4A5D840", VA = "0x184A5F040")]
	public bool JCABIDKNOEI(float JHOEGDEHLMP, float DEOPBJPCPDJ, [Out] T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4A5E880", Offset = "0x4A5D080", VA = "0x184A5E880")]
	public bool DPMCAICFKID(float JHOEGDEHLMP, float DEOPBJPCPDJ, [Out] T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F5C0", Offset = "0x4A5DDC0", VA = "0x184A5F5C0")]
	public void PDMLHELICLA(float JHOEGDEHLMP, float DEOPBJPCPDJ, List<T> NBCCIHGJKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4A5ED90", Offset = "0x4A5D590", VA = "0x184A5ED90")]
	private int GNPEBDLEDKO(int NJPMPCHOINL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F240", Offset = "0x4A5DA40", VA = "0x184A5F240")]
	private void LADOAABKNJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HKACGJIKJLA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T DOOPEIKEAJN(T IFKKLLBODIE, float KIDCMEILBJC);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T IEMDHIEJFIN(T LCFOIJICGNF, T CEDMGMKLGHI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CMJEFNLEOIH(T LCFOIJICGNF, T CEDMGMKLGHI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FMKPJJBFPNE : CJMLOMKIGOA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x771AA0", Offset = "0x7702A0", VA = "0x180771AA0", Slot = "4")]
	protected override Vector3 HKACGJIKJLA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C74660", Offset = "0x5C72E60", VA = "0x185C74660", Slot = "5")]
	protected override Vector3 DOOPEIKEAJN(Vector3 IFKKLLBODIE, float KIDCMEILBJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C746A0", Offset = "0x5C72EA0", VA = "0x185C746A0", Slot = "6")]
	protected override Vector3 IEMDHIEJFIN(Vector3 LCFOIJICGNF, Vector3 CEDMGMKLGHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C745E0", Offset = "0x5C72DE0", VA = "0x185C745E0", Slot = "7")]
	protected override Vector3 CMJEFNLEOIH(Vector3 LCFOIJICGNF, Vector3 CEDMGMKLGHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C746F0", Offset = "0x5C72EF0", VA = "0x185C746F0")]
	public FMKPJJBFPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HMMLMCNBIJB
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23B5F20", Offset = "0x23B4720", VA = "0x1823B5F20")]
	public static ENDNJFNGIKC<T1, T2> GFPEABNIECK<T1, T2>(T1 PNAEGKEANBH, T2 FFHAPNBFDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23B5FA0", Offset = "0x23B47A0", VA = "0x1823B5FA0")]
	public static LOODAFKPGJM<T1, T2, T3> GFPEABNIECK<T1, T2, T3>(T1 PNAEGKEANBH, T2 FFHAPNBFDAK, T3 DBFMPNHKCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D4B0", Offset = "0x3C7BCB0", VA = "0x183C7D4B0")]
	internal static int HLGIJNOPFIN(int LLLKAOILEKL, int BEBBIIMMDMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5198AF0", Offset = "0x51972F0", VA = "0x185198AF0")]
	internal static int HLGIJNOPFIN(int LLLKAOILEKL, int BEBBIIMMDMC, int KEPKKDDGGFJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ENDNJFNGIKC<T1, T2> : IComparable<ENDNJFNGIKC<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 IOAIGELAHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 GNEBAMBFNDL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x301CA00", Offset = "0x301B200", VA = "0x18301CA00")]
	public ENDNJFNGIKC(T1 PNAEGKEANBH, T2 FFHAPNBFDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x301C5B0", Offset = "0x301ADB0", VA = "0x18301C5B0", Slot = "4")]
	public int CompareTo(ENDNJFNGIKC<T1, T2> GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x301C6A0", Offset = "0x301AEA0", VA = "0x18301C6A0", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x301C850", Offset = "0x301B050", VA = "0x18301C850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x301C8A0", Offset = "0x301B0A0", VA = "0x18301C8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LOODAFKPGJM<T1, T2, T3> : IComparable<LOODAFKPGJM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 IOAIGELAHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 GNEBAMBFNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 HJKPOFLNEPL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x39C64E0", Offset = "0x39C4CE0", VA = "0x1839C64E0")]
	public LOODAFKPGJM(T1 PNAEGKEANBH, T2 FFHAPNBFDAK, T3 DBFMPNHKCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x39C5CE0", Offset = "0x39C44E0", VA = "0x1839C5CE0", Slot = "4")]
	public int CompareTo(LOODAFKPGJM<T1, T2, T3> GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x39C5F30", Offset = "0x39C4730", VA = "0x1839C5F30", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x39C6170", Offset = "0x39C4970", VA = "0x1839C6170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x39C6320", Offset = "0x39C4B20", VA = "0x1839C6320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E402A0", Offset = "0x1E3EAA0", VA = "0x181E402A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E40490", Offset = "0x1E3EC90", VA = "0x181E40490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float EGNPNGIJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA31E80", Offset = "0xA30680", VA = "0x180A31E80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4273A90", Offset = "0x4272290", VA = "0x184273A90")]
	public T DHINMMLCFBJ(float KIDCMEILBJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4273E60", Offset = "0x4272660", VA = "0x184273E60")]
	public T MLMMGHIFFKI(float KIDCMEILBJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BFACFIBIIFC(T LCFOIJICGNF, T CEDMGMKLGHI, float KIDCMEILBJC);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C74750", Offset = "0x5C72F50", VA = "0x185C74750", Slot = "4")]
	protected override float BFACFIBIIFC(float LCFOIJICGNF, float CEDMGMKLGHI, float KIDCMEILBJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C74790", Offset = "0x5C72F90", VA = "0x185C74790")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB5A630", Offset = "0xB58E30", VA = "0x180B5A630", Slot = "4")]
	protected override Vector3 BFACFIBIIFC(Vector3 LCFOIJICGNF, Vector3 CEDMGMKLGHI, float KIDCMEILBJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C777F0", Offset = "0x5C75FF0", VA = "0x185C777F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C73370", Offset = "0x5C71B70", VA = "0x185C73370", Slot = "4")]
	protected override Color BFACFIBIIFC(Color LCFOIJICGNF, Color CEDMGMKLGHI, float KIDCMEILBJC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C73430", Offset = "0x5C71C30", VA = "0x185C73430")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GDAKAIKCEAF : CEBDNKBPGLO<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5C74840", Offset = "0x5C73040", VA = "0x185C74840")]
	public GDAKAIKCEAF(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5C747D0", Offset = "0x5C72FD0", VA = "0x185C747D0", Slot = "6")]
	protected override uint CFBKBFOHMOD(uint DFIDMFGDKCM, string IFKKLLBODIE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NGHCMHKBCJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable LNAOMADBHGP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NGHCMHKBCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CFJECFLJEPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PFLOHKPDIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ENGILDLHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int FIPGBHFBIOD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3516770", Offset = "0x3514F70", VA = "0x183516770")]
	private CFJECFLJEPF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EFCOHDDPNBJ, int GLGKEFKGPLC, int JFMEGIGPCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A521C0", Offset = "0x4A509C0", VA = "0x184A521C0")]
	public static CFJECFLJEPF<T> MJLGMKKAMEE()
	{
		return default(CFJECFLJEPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A51480", Offset = "0x4A4FC80", VA = "0x184A51480")]
	public (int, int, Task<T>) INFIDGEGICC(int PFOFIDOMOJO, [Optional] CancellationToken NCEIDHNHODH, double CDJDJMPLMGP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4A508A0", Offset = "0x4A4F0A0", VA = "0x184A508A0")]
	public void GMLHAJICGOC(int PFOFIDOMOJO, int JFMEGIGPCCP, [In] T PGNGICAKGGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NALIICEEEME
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5C74FE0", Offset = "0x5C737E0", VA = "0x185C74FE0")]
	public static CFJECFLJEPF<NLDGBPLBGDN> MJLGMKKAMEE()
	{
		return default(CFJECFLJEPF<NLDGBPLBGDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5C74F60", Offset = "0x5C73760", VA = "0x185C74F60")]
	public static void GMLHAJICGOC([In] this CFJECFLJEPF<NLDGBPLBGDN> CLEGCKJMIEA, int PFOFIDOMOJO, int JFMEGIGPCCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class FKBKMGMPLEB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> FLHILINGBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> EOCNMCHHGJO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2E90CF0", Offset = "0x2E8F4F0", VA = "0x182E90CF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FCEGNANDKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> LFGDOEDMDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3036DB0", Offset = "0x30355B0", VA = "0x183036DB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> KBMIBCAJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x33A74A0", Offset = "0x33A5CA0", VA = "0x1833A74A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x33A7440", Offset = "0x33A5C40", VA = "0x1833A7440", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x33A7500", Offset = "0x33A5D00", VA = "0x1833A7500", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x33A6A50", Offset = "0x33A5250", VA = "0x1833A6A50")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x33A6BD0", Offset = "0x33A53D0", VA = "0x1833A6BD0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x33A7270", Offset = "0x33A5A70", VA = "0x1833A7270", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x33A6960", Offset = "0x33A5160", VA = "0x1833A6960", Slot = "9")]
	public void Add(TKey EBICOEDOGKC, TVal IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x33A6990", Offset = "0x33A5190", VA = "0x1833A6990", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3382D30", Offset = "0x3381530", VA = "0x183382D30", Slot = "8")]
	public bool ContainsKey(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x33A6C60", Offset = "0x33A5460", VA = "0x1833A6C60", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x33A71F0", Offset = "0x33A59F0", VA = "0x1833A71F0", Slot = "10")]
	public bool Remove(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x33A71C0", Offset = "0x33A59C0", VA = "0x1833A71C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x33A72C0", Offset = "0x33A5AC0", VA = "0x1833A72C0", Slot = "11")]
	public bool TryGetValue(TKey EBICOEDOGKC, [Out] TVal IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x33A6F50", Offset = "0x33A5750", VA = "0x1833A6F50", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x33A6C90", Offset = "0x33A5490", VA = "0x1833A6C90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JMHHCKCLFBI, int HPIBLFHGGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x33A6FF0", Offset = "0x33A57F0", VA = "0x1833A6FF0")]
	public bool MENMFPJMHKC(TVal EBICOEDOGKC, [Out] TKey IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x33A7120", Offset = "0x33A5920", VA = "0x1833A7120")]
	private void PFJJCIMBBPI(TKey EBICOEDOGKC, TVal HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x33A6AA0", Offset = "0x33A52A0", VA = "0x1833A6AA0")]
	private void CECECMCGOOI(TKey EBICOEDOGKC, TVal HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x33A6DE0", Offset = "0x33A55E0", VA = "0x1833A6DE0")]
	private bool ECGAKJHIHOL(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x33A7300", Offset = "0x33A5B00", VA = "0x1833A7300")]
	public FKBKMGMPLEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class GPBEGOBCFLB<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private GPBEGOBCFLB<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x309FB30", Offset = "0x309E330", VA = "0x18309FB30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309EB50", VA = "0x1830A0350")]
		public Enumerator(GPBEGOBCFLB<T> NBCCIHGJKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x309D6D0", Offset = "0x309BED0", VA = "0x18309D6D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x309F030", Offset = "0x309D830", VA = "0x18309F030", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x309E890", Offset = "0x309D090", VA = "0x18309E890")]
		private void PCCCNJIKEBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] GLPBOIEKHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int GELOOBNLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OCMGJBKOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OJAHFIICKFC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x34CCC10", Offset = "0x34CB410", VA = "0x1834CCC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x34CC780", Offset = "0x34CAF80", VA = "0x1834CC780")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x34CCFB0", Offset = "0x34CB7B0", VA = "0x1834CCFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34CDA20", Offset = "0x34CC220", VA = "0x1834CDA20")]
	public GPBEGOBCFLB(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34CCEB0", Offset = "0x34CB6B0", VA = "0x1834CCEB0")]
	public void EIGFNHEIDIC(T KIDCMEILBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x34CD2C0", Offset = "0x34CBAC0", VA = "0x1834CD2C0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x34CD160", Offset = "0x34CB960", VA = "0x1834CD160")]
	public void KJOHHNHICPE(int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x34CD5C0", Offset = "0x34CBDC0", VA = "0x1834CD5C0")]
	public void POFDECGJPJO(T[] JMHHCKCLFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x34CD250", Offset = "0x34CBA50", VA = "0x1834CD250")]
	public Enumerator NNHLEKOBGNG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x34CD920", Offset = "0x34CC120", VA = "0x1834CD920", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x34CD920", Offset = "0x34CC120", VA = "0x1834CD920", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x34CC8E0", Offset = "0x34CB0E0", VA = "0x1834CC8E0")]
	private int BOHKINFMDPH(int ADMJKDLHPCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x34CCF80", Offset = "0x34CB780", VA = "0x1834CCF80")]
	private int FCLONBGDOEG(int ADMJKDLHPCI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NOOHJDGHODC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> OCCPPAEAGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> KAEOEAACCCG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC110", Offset = "0x3CCA910", VA = "0x183CCC110", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC0C0", Offset = "0x3CCA8C0", VA = "0x183CCC0C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public NOOHJDGHODC(Func<Internal, External> OCCPPAEAGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CCC070", Offset = "0x3CCA870", VA = "0x183CCC070")]
	public NOOHJDGHODC(IReadOnlyList<Internal> KAEOEAACCCG, Func<Internal, External> OCCPPAEAGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3CCBFF0", Offset = "0x3CCA7F0", VA = "0x183CCBFF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3013DB0", Offset = "0x30125B0", VA = "0x183013DB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FAFBNCGOCIM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> LMJHCOEBAEJ(TRequest FDOGBBKMGKO, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum GLIODFEAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class FIOLPPNAMDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float GEAMJDMPIFO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan HPGNODIOALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int JCCDPMFGJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GLIODFEAPPO JJPIMEDLEJD;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly FIOLPPNAMDF LMLHJGLFPJN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LPAPHFMMEIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x339C3F0", Offset = "0x339ABF0", VA = "0x18339C3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan NBHJCFPODPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x339C5B0", Offset = "0x339ADB0", VA = "0x18339C5B0")]
		public FIOLPPNAMDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct HFEEJDPBDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest FDOGBBKMGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken NCEIDHNHODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> NNCNDINJHAB;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x35235D0", Offset = "0x3521DD0", VA = "0x1835235D0")]
		public HFEEJDPBDJG(TRequest FDOGBBKMGKO, TaskCompletionSource<TResult> NNCNDINJHAB, CancellationToken NCEIDHNHODH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct AOJFAGDADGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public FAFBNCGOCIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x38A9B30", Offset = "0x38A8330", VA = "0x1838A9B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x38A9FD0", Offset = "0x38A87D0", VA = "0x1838A9FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IPPCMKLLFAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FAFBNCGOCIM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HFEEJDPBDJG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3679830", Offset = "0x3678030", VA = "0x183679830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x367A450", Offset = "0x3678C50", VA = "0x18367A450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource GNDDHCLBBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<HFEEJDPBDJG> GMDKBJKHGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FIOLPPNAMDF FJDGOELJIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LMJHCOEBAEJ AFLBLHEHIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task IPIJALHELNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int NFGNPFGOHOH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x336FED0", Offset = "0x336E6D0", VA = "0x18336FED0")]
	public FAFBNCGOCIM(LMJHCOEBAEJ AFLBLHEHIJJ, [Optional] FIOLPPNAMDF FJDGOELJIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x336F950", Offset = "0x336E150", VA = "0x18336F950")]
	public Task<TResult> NKPMNOLNGKP(TRequest FDOGBBKMGKO, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x336E910", Offset = "0x336D110", VA = "0x18336E910")]
	private void APLGHAMONJG(HFEEJDPBDJG BHLIBIDIEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x336E620", Offset = "0x336CE20", VA = "0x18336E620")]
	[AsyncStateMachine(typeof(FAFBNCGOCIM<, >.AOJFAGDADGI))]
	private Task AHKEJBKOGHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x336EFA0", Offset = "0x336D7A0", VA = "0x18336EFA0")]
	private HFEEJDPBDJG KEMKAFPHKOB()
	{
		return default(HFEEJDPBDJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x336EBE0", Offset = "0x336D3E0", VA = "0x18336EBE0")]
	[AsyncStateMachine(typeof(FAFBNCGOCIM<, >.IPPCMKLLFAJ))]
	private Task IBFNAGDCEOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x336EEB0", Offset = "0x336D6B0", VA = "0x18336EEB0")]
	private void JAGKKHCFEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x336E9B0", Offset = "0x336D1B0", VA = "0x18336E9B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class MGENNEAKLAL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> KAEOEAACCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> IBELIAGBFNP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2E90CF0", Offset = "0x2E8F4F0", VA = "0x182E90CF0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FCEGNANDKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3BA34B0", Offset = "0x3BA1CB0", VA = "0x183BA34B0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3BA35D0", Offset = "0x3BA1DD0", VA = "0x183BA35D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x33D1490", Offset = "0x33CFC90", VA = "0x1833D1490", Slot = "11")]
	public void Add(T AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2F10", Offset = "0x3BA1710", VA = "0x183BA2F10")]
	public bool NEAFHMNAKCD(T AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3280", Offset = "0x3BA1A80", VA = "0x183BA3280", Slot = "15")]
	public bool Remove(T AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3596ED0", Offset = "0x35956D0", VA = "0x183596ED0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x33D8A10", Offset = "0x33D7210", VA = "0x1833D8A10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2C80", Offset = "0x3BA1480", VA = "0x183BA2C80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2CE0", Offset = "0x3BA14E0", VA = "0x183BA2CE0", Slot = "13")]
	public bool Contains(T AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2D20", Offset = "0x3BA1520", VA = "0x183BA2D20", Slot = "14")]
	public void CopyTo(T[] JMHHCKCLFBI, int HPIBLFHGGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3935DD0", Offset = "0x39345D0", VA = "0x183935DD0", Slot = "6")]
	public int IndexOf(T AKPEBFBEHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2D50", Offset = "0x3BA1550", VA = "0x183BA2D50", Slot = "7")]
	public void Insert(int ADMJKDLHPCI, T AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3090", Offset = "0x3BA1890", VA = "0x183BA3090", Slot = "8")]
	public void RemoveAt(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BA33C0", Offset = "0x3BA1BC0", VA = "0x183BA33C0")]
	public MGENNEAKLAL()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F22C90", Offset = "0x1F21490", VA = "0x181F22C90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C76D70", Offset = "0x5C75570", VA = "0x185C76D70")]
		public SerializedGuid([In] Guid ACBJLDAEBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5C76A60", Offset = "0x5C75260", VA = "0x185C76A60")]
		public static SerializedGuid COCLCHKLKNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C76D00", Offset = "0x5C75500", VA = "0x185C76D00")]
		public static SerializedGuid PILBPDMOFBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C76BF0", Offset = "0x5C753F0", VA = "0x185C76BF0")]
		public bool LGKDCANGALE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5C76CD0", Offset = "0x5C754D0", VA = "0x185C76CD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C76C50", Offset = "0x5C75450", VA = "0x185C76C50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C76B10", Offset = "0x5C75310", VA = "0x185C76B10", Slot = "7")]
		public bool Equals(SerializedGuid GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C76B50", Offset = "0x5C75350", VA = "0x185C76B50", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C76BE0", Offset = "0x5C753E0", VA = "0x185C76BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C76AE0", Offset = "0x5C752E0", VA = "0x185C76AE0", Slot = "6")]
		public int CompareTo(SerializedGuid GHNNCJBDHKF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HJDHFKDNJFN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type GGCDAHEMMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string GHPEANPOBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool BGJHKCJKEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool ADPFJCBBOOE;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5C74890", Offset = "0x5C73090", VA = "0x185C74890")]
	public HJDHFKDNJFN(Type OFIJAMGBGPG, string BABNFGIADBM, bool HBCHBBIMOBK = false, bool PODJOLDHKOG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GJGBNJADGMM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct JJLBIEAMIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long EOIPKLMGDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long CNJNENMDKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int EDONBOCDMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int OIGLIJHCMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool NDBPOIOPLPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string KDPPPJKNEOG;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3858DD0", Offset = "0x38575D0", VA = "0x183858DD0")]
		public JJLBIEAMIEP(long EOIPKLMGDEA, int EDONBOCDMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3858DA0", Offset = "0x38575A0", VA = "0x183858DA0")]
		public JJLBIEAMIEP(long EOIPKLMGDEA, long CNJNENMDKGG, int EDONBOCDMCF, int OIGLIJHCMDE, bool NDBPOIOPLPM, string KDPPPJKNEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3858C30", Offset = "0x3857430", VA = "0x183858C30")]
		public int ADGOAGAGOHL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3858CE0", Offset = "0x38574E0", VA = "0x183858CE0")]
		public int EOHJIFCFLMC(int INNFPBMFIEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3858C80", Offset = "0x3857480", VA = "0x183858C80")]
		public double BLLKKDJDOFE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3858D00", Offset = "0x3857500", VA = "0x183858D00")]
		public JJLBIEAMIEP MAKAGGCAMNF(long CNJNENMDKGG, int OIGLIJHCMDE)
		{
			return default(JJLBIEAMIEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NJLLNAPFMFK : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct EPJNNBHKBPA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NJLLNAPFMFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<NJLLNAPFMFK, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private NJLLNAPFMFK <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x303E360", Offset = "0x303CB60", VA = "0x18303E360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x303E820", Offset = "0x303D020", VA = "0x18303E820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey MOOCGHOLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly GJGBNJADGMM<TKey> HCIPJNOFOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly PFECAMNMOCE ANEILBIOBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<NJLLNAPFMFK> JJLGBADAEFP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string CLIJNMPOHJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3CA69E0", Offset = "0x3CA51E0", VA = "0x183CA69E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<NJLLNAPFMFK> IAJODELCOEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3CA65F0", Offset = "0x3CA4DF0", VA = "0x183CA65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JJLBIEAMIEP NKNHDIFHJOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3CA69C0", Offset = "0x3CA51C0", VA = "0x183CA69C0")]
			[CompilerGenerated]
			get
			{
				return default(JJLBIEAMIEP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3CA6990", Offset = "0x3CA5190", VA = "0x183CA6990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6A10", Offset = "0x3CA5210", VA = "0x183CA6A10")]
		internal NJLLNAPFMFK(GJGBNJADGMM<TKey> HCIPJNOFOCL, TKey EBICOEDOGKC, PFECAMNMOCE ANEILBIOBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6830", Offset = "0x3CA5030", VA = "0x183CA6830")]
		public NJLLNAPFMFK GNKJBLFKAAH(TKey EBICOEDOGKC, [Optional] PFECAMNMOCE? FFPPAFHAOAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2170B90", Offset = "0x216F390", VA = "0x182170B90")]
		[AsyncStateMachine(typeof(EPJNNBHKBPA<>))]
		public Task<T> NAGAHHFPKEO<T>(TKey EBICOEDOGKC, Func<NJLLNAPFMFK, Task<T>> OBFEDEKONOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6630", Offset = "0x3CA4E30", VA = "0x183CA6630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GAIGPBIDCEC : IEnumerable<(TKey, List<TKey>, JJLBIEAMIEP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JJLBIEAMIEP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, JJLBIEAMIEP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public GJGBNJADGMM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, JJLBIEAMIEP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, JJLBIEAMIEP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3447F70", Offset = "0x3446770", VA = "0x183447F70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JJLBIEAMIEP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3447FF0", Offset = "0x34467F0", VA = "0x183447FF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3448050", Offset = "0x3446850", VA = "0x183448050")]
		[DebuggerHidden]
		public GAIGPBIDCEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3013E30", Offset = "0x3012630", VA = "0x183013E30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3447A50", Offset = "0x3446250", VA = "0x183447A50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3447A00", Offset = "0x3446200", VA = "0x183447A00")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3447FA0", Offset = "0x34467A0", VA = "0x183447FA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3447EB0", Offset = "0x34466B0", VA = "0x183447EB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JJLBIEAMIEP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2FFA4C0", Offset = "0x2FF8CC0", VA = "0x182FFA4C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KKIOCGJCBDM : IEnumerable<(TKey, List<TKey>, JJLBIEAMIEP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JJLBIEAMIEP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, JJLBIEAMIEP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NJLLNAPFMFK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NJLLNAPFMFK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GJGBNJADGMM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<NJLLNAPFMFK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, JJLBIEAMIEP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, JJLBIEAMIEP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3447F70", Offset = "0x3446770", VA = "0x183447F70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JJLBIEAMIEP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x38DBB60", Offset = "0x38DA360", VA = "0x1838DBB60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3448050", Offset = "0x3446850", VA = "0x183448050")]
		[DebuggerHidden]
		public KKIOCGJCBDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x38DBBC0", Offset = "0x38DA3C0", VA = "0x1838DBBC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x38DB250", Offset = "0x38D9A50", VA = "0x1838DB250", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x38DB1F0", Offset = "0x38D99F0", VA = "0x1838DB1F0")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x38DB190", Offset = "0x38D9990", VA = "0x1838DB190")]
		private void ADBDFKNJMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x38DBB10", Offset = "0x38DA310", VA = "0x1838DBB10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x38DBA00", Offset = "0x38DA200", VA = "0x1838DBA00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JJLBIEAMIEP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x38DBAE0", Offset = "0x38DA2E0", VA = "0x1838DBAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, JJLBIEAMIEP, PFECAMNMOCE> LLDIEDEOMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, JJLBIEAMIEP, PFECAMNMOCE> HDJPKIBBCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<GJGBNJADGMM<TKey>, PFECAMNMOCE> PJADHFIHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NJLLNAPFMFK OHDDDPLKIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool PMNGKOBCMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int DMOHGEFADPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch HAALJFBAPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int FCMCMIAKGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string HIPPLBANKCD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NJLLNAPFMFK CEFGNLOCHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string CLIJNMPOHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x762B50", Offset = "0x761350", VA = "0x180762B50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x34A90E0", Offset = "0x34A78E0", VA = "0x1834A90E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34A91C0", Offset = "0x34A79C0", VA = "0x1834A91C0")]
	public GJGBNJADGMM(TKey IKCCJOGJCPC, PFECAMNMOCE ANEILBIOBIP, [Optional] int? EDONBOCDMCF, [Optional][CanBeNull] Stopwatch HAALJFBAPIE, [Optional] Action<TKey, JJLBIEAMIEP, PFECAMNMOCE> LLDIEDEOMPM, [Optional] Action<TKey, JJLBIEAMIEP, PFECAMNMOCE> HDJPKIBBCBL, [Optional] Action<GJGBNJADGMM<TKey>, PFECAMNMOCE> PJADHFIHFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34A8EF0", Offset = "0x34A76F0", VA = "0x1834A8EF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34A9050", Offset = "0x34A7850", VA = "0x1834A9050")]
	[IteratorStateMachine(typeof(GJGBNJADGMM<>.GAIGPBIDCEC))]
	public IEnumerable<(TKey, List<TKey>, JJLBIEAMIEP)> MMOGMLAIGLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x34A8F80", Offset = "0x34A7780", VA = "0x1834A8F80")]
	[IteratorStateMachine(typeof(GJGBNJADGMM<>.KKIOCGJCBDM))]
	private IEnumerable<(TKey, List<TKey>, JJLBIEAMIEP)> MMOGMLAIGLG(List<TKey> OMHPAGCEPHJ, NJLLNAPFMFK LMLJEKENADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x34A9140", Offset = "0x34A7940", VA = "0x1834A9140")]
	private (long, int) PLOIJPHDKPH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class FGIDEGHDABA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KGFBHIEIELI(GJGBNJADGMM<TKey> HCIPJNOFOCL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected FGIDEGHDABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class PHHGPGCIBFE<TKey> : FGIDEGHDABA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string CAFMIMHFIEM(TKey EBICOEDOGKC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3E848A0", Offset = "0x3E830A0", VA = "0x183E848A0")]
	private static string AAJCNBOEPKE(TKey EBICOEDOGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3E84A30", Offset = "0x3E83230", VA = "0x183E84A30", Slot = "4")]
	public override string KGFBHIEIELI(GJGBNJADGMM<TKey> HCIPJNOFOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3E848E0", Offset = "0x3E830E0", VA = "0x183E848E0")]
	public string KGFBHIEIELI(GJGBNJADGMM<TKey> HCIPJNOFOCL, [NotNull] CAFMIMHFIEM LGGHPAANLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LNKKCFCJAKL(GJGBNJADGMM<TKey> HCIPJNOFOCL, [NotNull] CAFMIMHFIEM LGGHPAANLKN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x34B9570", Offset = "0x34B7D70", VA = "0x1834B9570")]
	protected PHHGPGCIBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class ICADOPAPFBJ<TKey> : FGIDEGHDABA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string OLMGHEDPMHN(TKey EBICOEDOGKC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string LJGPLOAPOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double IICJIFIFNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool HLHJBAAFPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int HPGKDJMFJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> CCGPLBFLJLK;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x36570B0", Offset = "0x36558B0", VA = "0x1836570B0")]
	private static string AAJCNBOEPKE(TKey EBICOEDOGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3657C20", Offset = "0x3656420", VA = "0x183657C20")]
	public ICADOPAPFBJ(string LJGPLOAPOOP = "F2", double IICJIFIFNKL = double.MaxValue, bool HLHJBAAFPHL = false, int HPGKDJMFJJC = int.MaxValue, [Optional] ISet<string> CCGPLBFLJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3657A80", Offset = "0x3656280", VA = "0x183657A80", Slot = "4")]
	public override Dictionary<string, string> KGFBHIEIELI(GJGBNJADGMM<TKey> HCIPJNOFOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3657B40", Offset = "0x3656340", VA = "0x183657B40")]
	private bool MDJCJBEGDLD(string LJJLCDNMFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3657490", Offset = "0x3655C90", VA = "0x183657490")]
	public Dictionary<string, string> KGFBHIEIELI(GJGBNJADGMM<TKey> HCIPJNOFOCL, OLMGHEDPMHN LGGHPAANLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3657250", Offset = "0x3655A50", VA = "0x183657250")]
	private string KDFDMKLBOBF(StringBuilder MLNGGFALKJN, List<TKey> EPMKCFDMGMC, OLMGHEDPMHN LGGHPAANLKN, bool MGHPLMLHOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x36570F0", Offset = "0x36558F0", VA = "0x1836570F0")]
	private static void CODLDGHCAEO(StringBuilder DKLLJGHKOMF, string BNLBCIAFEEL, bool OCHEABOCOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LEJOAAHCPEH<TKey> : PHHGPGCIBFE<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OKCOFNPGNFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CAFMIMHFIEM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static LEJOAAHCPEH<TKey> LNAOMADBHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] HAKNENJACAL;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3997770", Offset = "0x3995F70", VA = "0x183997770")]
	private LEJOAAHCPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x39966E0", Offset = "0x3994EE0", VA = "0x1839966E0", Slot = "5")]
	protected override string LNKKCFCJAKL(GJGBNJADGMM<TKey> HCIPJNOFOCL, CAFMIMHFIEM LGGHPAANLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3997540", Offset = "0x3995D40", VA = "0x183997540")]
	[CompilerGenerated]
	internal static string OAADJADMPMM(string DFBGDCJCOOF, TKey EBICOEDOGKC, OKCOFNPGNFJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class DDPGADKJAFN : GJGBNJADGMM<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BIJDKNEMEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<DDPGADKJAFN, PFECAMNMOCE> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BIJDKNEMEPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5C720D0", Offset = "0x5C708D0", VA = "0x185C720D0")]
		internal void ABHKFDPGNMG(GJGBNJADGMM<string> timer, PFECAMNMOCE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5C73530", Offset = "0x5C71D30", VA = "0x185C73530")]
	public DDPGADKJAFN(PFECAMNMOCE ANEILBIOBIP, [Optional] string BEFGAIODLPO, [Optional] int? EDONBOCDMCF, [Optional] Stopwatch HAALJFBAPIE, [Optional] Action<string, JJLBIEAMIEP, PFECAMNMOCE> LLDIEDEOMPM, [Optional] Action<string, JJLBIEAMIEP, PFECAMNMOCE> HDJPKIBBCBL, [Optional] Action<DDPGADKJAFN, PFECAMNMOCE> PJADHFIHFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5C73470", Offset = "0x5C71C70", VA = "0x185C73470")]
	private static Action<GJGBNJADGMM<string>, PFECAMNMOCE> BMFHEKICLFC(Action<DDPGADKJAFN, PFECAMNMOCE> ELLFKJCIDIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class LKIAKNBABHG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class LOGINFFKCMM : LKIAKNBABHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static LKIAKNBABHG LNAOMADBHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5C74E10", Offset = "0x5C73610", VA = "0x185C74E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float NLNBOCHJCLP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C0F4A0", Offset = "0x1C0DCA0", VA = "0x181C0F4A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5C74F10", Offset = "0x5C73710", VA = "0x185C74F10")]
		public LOGINFFKCMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static LKIAKNBABHG FEFMKKKJNKK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static LKIAKNBABHG LMLHJGLFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5C74CA0", Offset = "0x5C734A0", VA = "0x185C74CA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float NLNBOCHJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected LKIAKNBABHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PEHGCJIBBEB : JLIHELEONGK<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5C755E0", Offset = "0x5C73DE0", VA = "0x185C755E0")]
	public PEHGCJIBBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JLIHELEONGK<T> : LPPJOFCADCB<T>, PEKLKMGJCGE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> OLPHHHLJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FNFCBJEHDPL<T> DOLCDEDANML
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x385A510", Offset = "0x3858D10", VA = "0x18385A510")]
	public JLIHELEONGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GONDOJMKMDB<T> : LPPJOFCADCB<T>, PEKLKMGJCGE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> OLPHHHLJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FNFCBJEHDPL<T> DOLCDEDANML
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x34CC500", Offset = "0x34CAD00", VA = "0x1834CC500")]
	public GONDOJMKMDB(Exception EIIICLNDLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PEKLKMGJCGE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LPPJOFCADCB<T> : PEKLKMGJCGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> OLPHHHLJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	FNFCBJEHDPL<T> DOLCDEDANML
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class KBKBMCGFKEN
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool LHCKEKLJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5C74960", Offset = "0x5C73160", VA = "0x185C74960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5C74900", Offset = "0x5C73100", VA = "0x185C74900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5C749B0", Offset = "0x5C731B0", VA = "0x185C749B0")]
	static KBKBMCGFKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected KBKBMCGFKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class EMCFDHBMECI<TTask, T> : KBKBMCGFKEN, LPPJOFCADCB<T>, PEKLKMGJCGE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class FJDBGLMNPLN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public FJDBGLMNPLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2E81100", Offset = "0x2E7F900", VA = "0x182E81100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2E813D0", Offset = "0x2E7FBD0", VA = "0x182E813D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public EMCFDHBMECI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FJDBGLMNPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x339C8F0", Offset = "0x339B0F0", VA = "0x18339C8F0")]
		[AsyncStateMachine(typeof(EMCFDHBMECI<, >.FJDBGLMNPLN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> IBACFBNAMMH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> DGINPAIAOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource OOKDIBNEDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool PMNGKOBCMDF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> OLPHHHLJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FNFCBJEHDPL<T> DOLCDEDANML
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3016980", Offset = "0x3015180", VA = "0x183016980")]
	protected EMCFDHBMECI(TTask DGINPAIAOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x30168F0", Offset = "0x30150F0", VA = "0x1830168F0", Slot = "1")]
	~EMCFDHBMECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x30165F0", Offset = "0x3014DF0", VA = "0x1830165F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3016610", Offset = "0x3014E10", VA = "0x183016610")]
	private void FFAMFELMPDP(bool IHHADLILMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BNJNDINBEBC(TTask EFKNIBCNAFD);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GEFEFCFLFBM();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OKOCENMOBPK
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5C75240", Offset = "0x5C73A40", VA = "0x185C75240")]
	[NotNull]
	public static byte[] ELFPAIEHHPM(this OIFLPHEDDHM AADMJLFKPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5C751D0", Offset = "0x5C739D0", VA = "0x185C751D0")]
	[NotNull]
	public static byte[] ELFPAIEHHPM(this OIFLPHEDDHM AADMJLFKPGL, HashAlgorithmName PMIPHNNFGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5C752B0", Offset = "0x5C73AB0", VA = "0x185C752B0")]
	public static bool HHCFOMPOAFC([CanBeNull] this OIFLPHEDDHM AADMJLFKPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5C75440", Offset = "0x5C73C40", VA = "0x185C75440")]
	public static bool HHCFOMPOAFC([CanBeNull] this OIFLPHEDDHM AADMJLFKPGL, [Out] string OBDAEGBLILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5C750B0", Offset = "0x5C738B0", VA = "0x185C750B0")]
	private static bool CLEEJAIGBGG([NotNull] OIFLPHEDDHM AADMJLFKPGL, [Out][CanBeNull] byte[] CAHBDAEBIAF, [Out][CanBeNull] byte[] EMADFGIPOJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class KENMBBLCMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5C74A60", Offset = "0x5C73260", VA = "0x185C74A60")]
	[NotNull]
	public static byte[] ELFPAIEHHPM(this DLGGDDOJLPK JPDDNOHLFFO, HashAlgorithmName PMIPHNNFGDE, byte[] BEKGMGHLOFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DLGGDDOJLPK
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DFIDMFGDKCM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OIFLPHEDDHM : DLGGDDOJLPK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] CLHCGOLGHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] MABJBENAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CCGDJBLNDHN
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> GPAMJDGBEFC;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool LGCFNFEAKEO;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5C72780", Offset = "0x5C70F80", VA = "0x185C72780")]
	public static void IDNBADEKENN(this IncrementalHash KDFBGOPNNDB, [CanBeNull] GameObject AAAOHJGLLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x21F0940", Offset = "0x21EF140", VA = "0x1821F0940")]
	public static void IDNBADEKENN<T>(this IncrementalHash KDFBGOPNNDB, [CanBeNull] T ENFAJMDKEKJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x21F0A00", Offset = "0x21EF200", VA = "0x1821F0A00")]
	public static void OGENIPIDAGM<T>(this IncrementalHash KDFBGOPNNDB, [CanBeNull] T JPDDNOHLFFO) where T : DLGGDDOJLPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x21F0420", Offset = "0x21EEC20", VA = "0x1821F0420")]
	public static void DMLGCPOJJLK<T>(this IncrementalHash KDFBGOPNNDB, [CanBeNull] IList<T> IKDOFNOLNOL) where T : DLGGDDOJLPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5C72390", Offset = "0x5C70B90", VA = "0x185C72390")]
	private static bool DIBPOLDCDAA([CanBeNull] DLGGDDOJLPK JPDDNOHLFFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5C726C0", Offset = "0x5C70EC0", VA = "0x185C726C0")]
	public static void EIFKNAPOMEF(this IncrementalHash DFIDMFGDKCM, [CanBeNull] string HCLGGFHNIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5C72B40", Offset = "0x5C71340", VA = "0x185C72B40")]
	public static void LLGODLHIEML(this IncrementalHash DFIDMFGDKCM, long PEEFOIEDIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5C72160", Offset = "0x5C70960", VA = "0x185C72160")]
	public static void AMFNBJPCEPO(this IncrementalHash DFIDMFGDKCM, int JBJKAAHADBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5C72970", Offset = "0x5C71170", VA = "0x185C72970")]
	public static void KIIKGEOAODD(this IncrementalHash DFIDMFGDKCM, short HOLLEKIHJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5C72860", Offset = "0x5C71060", VA = "0x185C72860")]
	public static void JMLIPAHNIPE(this IncrementalHash DFIDMFGDKCM, byte INKPAGKGADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5C72420", Offset = "0x5C70C20", VA = "0x185C72420")]
	public static void DLAFNFAOLBO(this IncrementalHash DFIDMFGDKCM, bool EOINKAJMNFG, bool HPJCGEOMCOL = false, bool DFNOJCJFCJK = false, bool LFFNHFDMBCB = false, bool AGCCOOKNNGA = false, bool AGDOGOGMOID = false, bool BEOBNFCDJAP = false, bool OONGCOKBCFL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x21EFDF0", Offset = "0x21EE5F0", VA = "0x1821EFDF0")]
	public static void DLLHAPIBJMB<T>(this IncrementalHash DFIDMFGDKCM, T CGJOJNFDJBM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5C72720", Offset = "0x5C70F20", VA = "0x185C72720")]
	public static void GOALPFGGIOD(this IncrementalHash DFIDMFGDKCM, float KHEAPNNLLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5C72D10", Offset = "0x5C71510", VA = "0x185C72D10")]
	public static void MCBLCPILMPK(this IncrementalHash DFIDMFGDKCM, ulong PMPCGOPJPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5C72D70", Offset = "0x5C71570", VA = "0x185C72D70")]
	public static void NKBAAKBDFHF(this IncrementalHash DFIDMFGDKCM, uint KAHFKOPBABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5C72330", Offset = "0x5C70B30", VA = "0x185C72330")]
	public static void CNFBGFJLFMO(this IncrementalHash DFIDMFGDKCM, ushort MLEFAPDADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5C72590", Offset = "0x5C70D90", VA = "0x185C72590")]
	public static void EDGFONNGPAL(this IncrementalHash DFIDMFGDKCM, Vector3 EMKGGADLLEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class AJOHICNDBGK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5C72070", Offset = "0x5C70870", VA = "0x185C72070")]
	public AJOHICNDBGK(string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class MPBIPAJHAEB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class ADNGGCCAHAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode CLEGCKJMIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode KLGMOMIJPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IHIHBEPDJKF HAOAMPANBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<IHIHBEPDJKF> CEGGGPJJMLJ;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ADNGGCCAHAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct IHIHBEPDJKF : IComparable<IHIHBEPDJKF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int NKCBPBOPHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant EEJOONLAHNJ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAB95B0", Offset = "0xAB7DB0", VA = "0x180AB95B0")]
		public IHIHBEPDJKF(int NKCBPBOPHFD, TClaimant EEJOONLAHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3662F10", Offset = "0x3661710", VA = "0x183662F10")]
		public bool CNDHNBINHGE([In] IHIHBEPDJKF GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3662F80", Offset = "0x3661780", VA = "0x183662F80")]
		public bool HEIPOKHJOHO([In] IHIHBEPDJKF GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3662F70", Offset = "0x3661770", VA = "0x183662F70", Slot = "4")]
		public int CompareTo(IHIHBEPDJKF GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3662F90", Offset = "0x3661790", VA = "0x183662F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum IDFMCOGOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class BBJAENAJIPA : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MPBIPAJHAEB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public BBJAENAJIPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x45B1610", Offset = "0x45AFE10", VA = "0x1845B1610", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x45B17D0", Offset = "0x45AFFD0", VA = "0x1845B17D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45B16F0", Offset = "0x45AFEF0", VA = "0x1845B16F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x32AE6E0", Offset = "0x32ACEE0", VA = "0x1832AE6E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly JLPGMGJEBPG<ADNGGCCAHAI> FCHCCPABHFG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly JLPGMGJEBPG<List<IHIHBEPDJKF>> CJMICJFOIPB;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int MDHPMNGBKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> AICBILMOOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, ADNGGCCAHAI> CCLBJMDDHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IDFMCOGOHIA CHDCFCNHAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KAHCMOIEBOO(TNode LBKDEGBJKJF);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void INKNBFDJOGA(TNode LBKDEGBJKJF, TClaimant FICDLPDHLJH, TClaimant MNFFMLNOCBM);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A670", Offset = "0x3C58E70", VA = "0x183C5A670")]
	public MPBIPAJHAEB(IDFMCOGOHIA CHDCFCNHAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3C58F40", Offset = "0x3C57740", VA = "0x183C58F40")]
	public void DOPLLJGBPAB(TNode LBKDEGBJKJF, TNode IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A050", Offset = "0x3C58850", VA = "0x183C5A050")]
	public void OCLAGCAPBAK(TClaimant EEJOONLAHNJ, TNode JBMNFKHLBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3C58FD0", Offset = "0x3C577D0", VA = "0x183C58FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3C59A90", Offset = "0x3C58290", VA = "0x183C59A90")]
	private void ILNBBKHJMIE(TClaimant EEJOONLAHNJ, TNode KHMAIPGBJDO, TNode JBMNFKHLBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3C59570", Offset = "0x3C57D70", VA = "0x183C59570")]
	private int GMLPAKFJCJG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A170", Offset = "0x3C58970", VA = "0x183C5A170")]
	private void OKJGLFFCGHC(TClaimant EEJOONLAHNJ, TNode IEKHDPGELGI, TNode INIMKGAHAEJ, int OICHGBACMHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3C59EE0", Offset = "0x3C586E0", VA = "0x183C59EE0")]
	private void NOJMHJHBKEP(IHIHBEPDJKF DEPNHBOFPCC, ADNGGCCAHAI DJKLHFOILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3C591A0", Offset = "0x3C579A0", VA = "0x183C591A0")]
	private void FBJOPFKMHEP(TClaimant EEJOONLAHNJ, TNode IEKHDPGELGI, TNode INIMKGAHAEJ, int OICHGBACMHM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C59DD0", Offset = "0x3C585D0", VA = "0x183C59DD0")]
	private void LLPHBPHKIEC(IHIHBEPDJKF DEPNHBOFPCC, TNode LBKDEGBJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C58E50", Offset = "0x3C57650", VA = "0x183C58E50")]
	private void DIGFBBHBMGD(IHIHBEPDJKF DEPNHBOFPCC, ADNGGCCAHAI DJKLHFOILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C59CA0", Offset = "0x3C584A0", VA = "0x183C59CA0")]
	private void KDMCJJEDNGG(ADNGGCCAHAI DJKLHFOILGP, bool DEHEFKEAJKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C59750", Offset = "0x3C57F50", VA = "0x183C59750")]
	private void HLPKFGOCGGI(ADNGGCCAHAI DJKLHFOILGP, TNode IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C59F70", Offset = "0x3C58770", VA = "0x183C59F70")]
	[IteratorStateMachine(typeof(MPBIPAJHAEB<, >.BBJAENAJIPA))]
	private IEnumerable<TNode> OABDFMEAEIC(TNode IEKHDPGELGI, TNode INIMKGAHAEJ, bool ONPLMBILMAF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3C59480", Offset = "0x3C57C80", VA = "0x183C59480")]
	private ADNGGCCAHAI GDBKHKDBNGP(TNode LBKDEGBJKJF, TNode KLGMOMIJPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3C59B30", Offset = "0x3C58330", VA = "0x183C59B30")]
	private ADNGGCCAHAI JJDKCGCNMMJ(TNode LBKDEGBJKJF, TNode KLGMOMIJPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3C595E0", Offset = "0x3C57DE0", VA = "0x183C595E0")]
	private void GNDHCBCKMFK(ADNGGCCAHAI DJKLHFOILGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CEBDNKBPGLO<T> : IEnumerable<CEBDNKBPGLO<T>.LGDFOEBINJN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct LGDFOEBINJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T IFKKLLBODIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int ADMJKDLHPCI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class MHPAOEEAEHD : IEnumerator<LGDFOEBINJN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private CEBDNKBPGLO<T> OCFMFKJKCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int ADMJKDLHPCI;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3044300", Offset = "0x3042B00", VA = "0x183044300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public LGDFOEBINJN IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3BA6C60", Offset = "0x3BA5460", VA = "0x183BA6C60", Slot = "4")]
			get
			{
				return default(LGDFOEBINJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6B70", Offset = "0x3BA5370", VA = "0x183BA6B70")]
		public MHPAOEEAEHD(CEBDNKBPGLO<T> OCFMFKJKCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6A70", Offset = "0x3BA5270", VA = "0x183BA6A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30976B0", Offset = "0x3095EB0", VA = "0x1830976B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1A2A700", Offset = "0x1A28F00", VA = "0x181A2A700", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct HEHDHBIKHPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool BDKNDJAEJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T IFKKLLBODIE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int GPBEEHAPLEE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> BJCLJDBLLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HEHDHBIKHPN[] ILBHCKEJFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KEHOMKIJFOJ;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GKCLNFJOIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FB0", Offset = "0x7A07B0", VA = "0x1807A1FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7A15B0", Offset = "0x79FDB0", VA = "0x1807A15B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2E90CF0", Offset = "0x2E8F4F0", VA = "0x182E90CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B780", Offset = "0x4A49F80", VA = "0x184A4B780")]
	public CEBDNKBPGLO(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AFE0", Offset = "0x4A497E0", VA = "0x184A4AFE0")]
	public CEBDNKBPGLO(LGDFOEBINJN[] LBFNPHEMPJN, bool IMCIELLINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A7C0", Offset = "0x4A48FC0", VA = "0x184A4A7C0")]
	public int HAHAGDBJEOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A3E0", Offset = "0x4A48BE0", VA = "0x184A4A3E0")]
	private int EFIPLCNJDGI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A3B0", Offset = "0x4A48BB0", VA = "0x184A4A3B0", Slot = "6")]
	protected virtual uint CFBKBFOHMOD(uint DFIDMFGDKCM, T IFKKLLBODIE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A8A0", Offset = "0x4A490A0", VA = "0x184A4A8A0")]
	public bool HFNOFAJLEEM(T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A2B0", Offset = "0x4A48AB0", VA = "0x184A4A2B0")]
	public int ANJGBPDLBLK(T IFKKLLBODIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A9E0", Offset = "0x4A491E0", VA = "0x184A4A9E0")]
	public T MMNNIFHDOBP(int ADMJKDLHPCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AF10", Offset = "0x4A49710", VA = "0x184A4AF10")]
	public bool NEAFHMNAKCD(T IFKKLLBODIE, bool GEIAFNKHIKA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4A4ACB0", Offset = "0x4A494B0", VA = "0x184A4ACB0")]
	public bool NEAFHMNAKCD(T IFKKLLBODIE, int ADMJKDLHPCI, bool GEIAFNKHIKA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A940", Offset = "0x4A49140", VA = "0x184A4A940")]
	private int HJIJFOIJOOM(int GELOOBNLCJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AF60", Offset = "0x4A49760", VA = "0x184A4AF60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AF60", Offset = "0x4A49760", VA = "0x184A4AF60", Slot = "4")]
	private IEnumerator<LGDFOEBINJN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JLPGMGJEBPG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> LPCPKBKABCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> FIENAFAEIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int FGNPONHIGFN;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x385A820", Offset = "0x3859020", VA = "0x18385A820")]
	public static JLPGMGJEBPG<T> EMHNABLJOFM(int OLEHEDGFINF = 0, int FGNPONHIGFN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x385AF10", Offset = "0x3859710", VA = "0x18385AF10")]
	public JLPGMGJEBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x385AD70", Offset = "0x3859570", VA = "0x18385AD70")]
	public JLPGMGJEBPG(int OLEHEDGFINF, int FGNPONHIGFN = int.MaxValue, bool APHEKHCEBLI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x385ABF0", Offset = "0x38593F0", VA = "0x18385ABF0")]
	public T LDCEKDCBEDK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x385A900", Offset = "0x3859100", VA = "0x18385A900")]
	public void FBKBPDEEJFF(T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x385A600", Offset = "0x3858E00", VA = "0x18385A600")]
	private void BFCGAKHBMFH(T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x385A9D0", Offset = "0x38591D0", VA = "0x18385A9D0")]
	private void JFLDNBPDBGJ(T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x385A6E0", Offset = "0x3858EE0", VA = "0x18385A6E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x385A9F0", Offset = "0x38591F0", VA = "0x18385A9F0")]
	private void KJCJKKBLGJD(IEnumerable<T> EMKFAOJKFLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EPJGAEKOEKE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> KDNBIEKMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T DOCBPPHDIMJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T AIDAEEPKMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3039380", Offset = "0x3037B80", VA = "0x183039380")]
	public bool ILFJPJIHKEG(T IFKKLLBODIE, int NKCBPBOPHFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3039600", Offset = "0x3037E00", VA = "0x183039600")]
	public bool PKADHLMMDID(int NKCBPBOPHFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3039120", Offset = "0x3037920", VA = "0x183039120")]
	public T HGIJEOAGBGB(int JIHKCCGGMMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3039400", Offset = "0x3037C00", VA = "0x183039400")]
	private bool MBBCFLDLHPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x30395B0", Offset = "0x3037DB0", VA = "0x1830395B0")]
	public bool MENMFPJMHKC(int NKCBPBOPHFD, [Out] T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3039670", Offset = "0x3037E70", VA = "0x183039670")]
	public EPJGAEKOEKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class IDIKNJNPJIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct EAEAMCPGDFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T GNAEIIEFOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int HBNEJEFACHO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<EAEAMCPGDFM> GLPBOIEKHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T AILFFGCLELF;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2E90CF0", Offset = "0x2E8F4F0", VA = "0x182E90CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3658C00", Offset = "0x3657400", VA = "0x183658C00")]
	public bool ADJIAADNNIO(T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3658D80", Offset = "0x3657580", VA = "0x183658D80")]
	public void EIGFNHEIDIC(T IFKKLLBODIE, int NKCBPBOPHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3659000", Offset = "0x3657800", VA = "0x183659000")]
	public bool OICBJJIPNIH(T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3659150", Offset = "0x3657950", VA = "0x183659150")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3658F80", Offset = "0x3657780", VA = "0x183658F80")]
	public T JLNAJPHMLOE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3658E20", Offset = "0x3657620", VA = "0x183658E20")]
	private void EKJLJBGNLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x36591B0", Offset = "0x36579B0", VA = "0x1836591B0")]
	public IDIKNJNPJIE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[BAKIIHHMALJ(NFNIPNJABGH.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5C75760", Offset = "0x5C73F60", VA = "0x185C75760")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5C75A30", Offset = "0x5C74230", VA = "0x185C75A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C75940", Offset = "0x5C74140", VA = "0x185C75940")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C756B0", Offset = "0x5C73EB0", VA = "0x185C756B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5C75980", Offset = "0x5C74180", VA = "0x185C75980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5C75890", Offset = "0x5C74090", VA = "0x185C75890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C75620", Offset = "0x5C73E20", VA = "0x185C75620")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4035BC0", Offset = "0x40343C0", VA = "0x184035BC0", Slot = "4")]
		public virtual T HAJGDFEJHJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class EGNFAKHFIOG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, CINMPGPILOA> DJPECFGLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly JLPGMGJEBPG<CINMPGPILOA> ACOFFJIKFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool FEPPOBOBGII;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public CINMPGPILOA PJBBCKMLIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 HFDICPKLBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA30A50", Offset = "0xA2F250", VA = "0x180A30A50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD114F0", Offset = "0xD0FCF0", VA = "0x180D114F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 AJJNPMPAHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xD3CDB0", Offset = "0xD3B5B0", VA = "0x180D3CDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 MIFGFCNCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C73B60", Offset = "0x5C72360", VA = "0x185C73B60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x762A90", Offset = "0x761290", VA = "0x180762A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int PIJMABOCIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7658D0", Offset = "0x7640D0", VA = "0x1807658D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x765E60", Offset = "0x764660", VA = "0x180765E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C74150", Offset = "0x5C72950", VA = "0x185C74150")]
	public EGNFAKHFIOG(Bounds CCFLJOBLIKA, Vector2[] CDMKOEMFPPJ, int DDGFMFJEJNC, byte GELOOBNLCJF, float CDCFLLKOOLF = 0f, [Optional] JLPGMGJEBPG<CINMPGPILOA> ACOFFJIKFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5C74000", Offset = "0x5C72800", VA = "0x185C74000")]
	public CINMPGPILOA LFBDDLMGILB(byte ADMJKDLHPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5C73F30", Offset = "0x5C72730", VA = "0x185C73F30")]
	public void JPBKNBMOFAB(Vector3 OBAACBLACLC, float FDLLHPMHCEI, float JJNPJLGOJMJ, List<byte> LBNHIKDOICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A15450", Offset = "0x1A13C50", VA = "0x181A15450")]
	public void FICFCKACDPG(CINMPGPILOA.DCEDPIJMBCG JPHBDEBBAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C74060", Offset = "0x5C72860", VA = "0x185C74060")]
	public static int NJMPEDJCJLA(Vector2[] CDMKOEMFPPJ, int DDGFMFJEJNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C73680", Offset = "0x5C71E80", VA = "0x185C73680")]
	private CINMPGPILOA DFFBGEFFOJL(byte ADMJKDLHPCI, CINMPGPILOA.BOCLOACBOOJ FGNLPJIDBDN, CINMPGPILOA KLGMOMIJPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5C73B80", Offset = "0x5C72380", VA = "0x185C73B80")]
	private void IKOHDNHHFBM(CINMPGPILOA KLGMOMIJPLM, Vector2[] CDMKOEMFPPJ, int KFEFEEOILEB, int BKADLKKBCOF, int LIFJLGFBFFM, int BPNEHJLNPOJ, float CDCFLLKOOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C738E0", Offset = "0x5C720E0", VA = "0x185C738E0")]
	private void ENEEPNNMOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5C73880", Offset = "0x5C72080", VA = "0x185C73880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5C73B00", Offset = "0x5C72300", VA = "0x185C73B00", Slot = "1")]
	~EGNFAKHFIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CINMPGPILOA
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum BOCLOACBOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum DCEDPIJMBCG
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte IDAENCJFMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 OOJDEHGNOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 PHCALFNEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 JKELJMIGDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 AELNLAFCEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public BOCLOACBOOJ IGHBAGANOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public CINMPGPILOA BPJPJIKDALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<CINMPGPILOA> JMCAKMDDNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool DKPEGMGGPAJ;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C73350", Offset = "0x5C71B50", VA = "0x185C73350")]
	public CINMPGPILOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C72EE0", Offset = "0x5C716E0", VA = "0x185C72EE0")]
	public void BIJCLJDBJFN(CINMPGPILOA JDEFHCADEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	public void FICFCKACDPG(int NDJAFMGJGEA, DCEDPIJMBCG JPHBDEBBAFO, int HJOKPEKAJLH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5C73030", Offset = "0x5C71830", VA = "0x185C73030")]
	public void JPBKNBMOFAB(List<byte> LBNHIKDOICE, Vector3 OBAACBLACLC, float FDLLHPMHCEI, float JJNPJLGOJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5C73000", Offset = "0x5C71800", VA = "0x185C73000")]
	public bool HFJFHBKPKDL(Vector3 BFCEGFNGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5C73320", Offset = "0x5C71B20", VA = "0x185C73320")]
	public bool OLLNNJHCACH(Vector3 BFCEGFNGHJA, float FBKDPODMIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5C73290", Offset = "0x5C71A90", VA = "0x185C73290")]
	public void MJKJMKCCJMD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct ICIFNPFJNEH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> KAEOEAACCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool BECGBPOLOEO;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3472AB0", Offset = "0x34712B0", VA = "0x183472AB0")]
			public ICIFNPFJNEH(List<Component> KAEOEAACCCG, bool BECGBPOLOEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3658030", Offset = "0x3656830", VA = "0x183658030")]
			public PJCOPPGMCIH<T> NNHLEKOBGNG()
			{
				return default(PJCOPPGMCIH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x36580A0", Offset = "0x36568A0", VA = "0x1836580A0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x36580A0", Offset = "0x36568A0", VA = "0x1836580A0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct PJCOPPGMCIH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> KAEOEAACCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool BECGBPOLOEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int ADMJKDLHPCI;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T IODFMFKEHHG
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3E86C20", Offset = "0x3E85420", VA = "0x183E86C20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3E86BB0", Offset = "0x3E853B0", VA = "0x183E86BB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3E86BF0", Offset = "0x3E853F0", VA = "0x183E86BF0")]
			public PJCOPPGMCIH(List<Component> KAEOEAACCCG, bool BECGBPOLOEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3E86AF0", Offset = "0x3E852F0", VA = "0x183E86AF0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3E86B00", Offset = "0x3E85300", VA = "0x183E86B00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x30862E0", Offset = "0x3084AE0", VA = "0x1830862E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C771E0", Offset = "0x5C759E0", VA = "0x185C771E0")]
		private void MJKJMKCCJMD(GameObject LCKCBKEEMNI, bool HCOFOGEFGHL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C77350", Offset = "0x5C75B50", VA = "0x185C77350")]
		public static void MJKJMKCCJMD(GameObject LCKCBKEEMNI, ToolHierarchyCache PBBLGCKBEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x263E730", Offset = "0x263CF30", VA = "0x18263E730")]
		public void ICDJGNLPLNH<T>(Action<T> POMIBLHGGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x263E950", Offset = "0x263D150", VA = "0x18263E950")]
		public T OBANALOJDPL<T>(bool BECGBPOLOEO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x263E670", Offset = "0x263CE70", VA = "0x18263E670")]
		public ICIFNPFJNEH<T> BKDOJDDAKHK<T>(bool BECGBPOLOEO = false) where T : class
		{
			return default(ICIFNPFJNEH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C76E90", Offset = "0x5C75690", VA = "0x185C76E90")]
		public List<Component> MBFOABLPABK(Type BJKOKHNAAID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C76DA0", Offset = "0x5C755A0", VA = "0x185C76DA0", Slot = "4")]
		public bool Equals(ToolHierarchyCache GEKAGOANEHP, ToolHierarchyCache KFCLHHAJEPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C76E20", Offset = "0x5C75620", VA = "0x185C76E20", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ELOCHLKHPBP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class IEBNAGMKEKD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int OLEHEDGFINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int HLFOIOOOFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> KBLIOPDOHJK;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x336D700", Offset = "0x336BF00", VA = "0x18336D700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T KHHFJDADMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3659520", Offset = "0x3657D20", VA = "0x183659520")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T GBDNDPKFFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3659250", Offset = "0x3657A50", VA = "0x183659250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T BKPLEDDIBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x36597C0", Offset = "0x3657FC0", VA = "0x1836597C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x36598E0", Offset = "0x36580E0", VA = "0x1836598E0")]
	public IEBNAGMKEKD(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3659330", Offset = "0x3657B30", VA = "0x183659330")]
	public void EIGFNHEIDIC(T CALHOCIHKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x36598A0", Offset = "0x36580A0", VA = "0x1836598A0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x36596F0", Offset = "0x3657EF0", VA = "0x1836596F0")]
	public void GGCOGDINFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3659690", Offset = "0x3657E90", VA = "0x183659690")]
	public void FHFCNAGGKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3659320", Offset = "0x3657B20", VA = "0x183659320")]
	public void ECGMJMEBJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class BDJMOPPMNBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct CKMHEFKGOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int HBNEJEFACHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T GNAEIIEFOAF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, CKMHEFKGOCM> KDNBIEKMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> GBPOPMMILBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T DOCBPPHDIMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T AIDAEEPKMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD62CB0", Offset = "0xD614B0", VA = "0x180D62CB0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x45BF800", Offset = "0x45BE000", VA = "0x1845BF800", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool HKJJLGAHODE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x45BC070", Offset = "0x45BA870", VA = "0x1845BC070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object CEOOLPDCJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x45BC1F0", Offset = "0x45BA9F0", VA = "0x1845BC1F0")]
	public bool ILFJPJIHKEG(T IFKKLLBODIE, object PIPCHJCEPPJ, int NKCBPBOPHFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x45BF8D0", Offset = "0x45BE0D0", VA = "0x1845BF8D0")]
	public bool PKADHLMMDID(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x45BF680", Offset = "0x45BDE80", VA = "0x1845BF680")]
	public bool MENMFPJMHKC(object PIPCHJCEPPJ, [Out] T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x45BF8A0", Offset = "0x45BE0A0", VA = "0x1845BF8A0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x45BEDA0", Offset = "0x45BD5A0", VA = "0x1845BEDA0")]
	private bool MBBCFLDLHPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x45BF960", Offset = "0x45BE160", VA = "0x1845BF960")]
	public BDJMOPPMNBO()
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
