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
public class KIJCDAJOLJD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	public KIJCDAJOLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, NIPAEPLNJMM, JDBJPKOCHPF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x736040", VA = "0x180737040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PKCNHEGJGNH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xEED600", Offset = "0xEEC600", VA = "0x180EED600")]
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
	[DEIKCOMKPHJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[DEIKCOMKPHJ]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BB00", Offset = "0x5D6AB00", VA = "0x185D6BB00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BAC0", Offset = "0x5D6AAC0", VA = "0x185D6BAC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BB40", Offset = "0x5D6AB40", VA = "0x185D6BB40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BD10", Offset = "0x5D6AD10", VA = "0x185D6BD10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BC80", Offset = "0x5D6AC80", VA = "0x185D6BC80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x11091D0", Offset = "0x11081D0", VA = "0x1811091D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1253DB0", Offset = "0x1252DB0", VA = "0x181253DB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BA80", Offset = "0x5D6AA80", VA = "0x185D6BA80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BBF0", Offset = "0x5D6ABF0", VA = "0x185D6BBF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B4C0", Offset = "0x5D6A4C0", VA = "0x185D6B4C0")]
	public void CopyBounds(SavedExtents HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B9E0", Offset = "0x5D6A9E0", VA = "0x185D6B9E0")]
	public void SetLocalSpaceBounds(Bounds MKMJKAJJCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1205BB0", Offset = "0x1204BB0", VA = "0x181205BB0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B9D0", Offset = "0x5D6A9D0", VA = "0x185D6B9D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B5B0", Offset = "0x5D6A5B0", VA = "0x185D6B5B0")]
	private void ODIMLOIMPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B7A0", Offset = "0x5D6A7A0", VA = "0x185D6B7A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AE80", Offset = "0x5D69E80", VA = "0x185D6AE80")]
	public static void CalculateLocalBoundsFor(GameObject BFJMKCMPBKG, out Bounds MKMJKAJJCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B4F0", Offset = "0x5D6A4F0", VA = "0x185D6B4F0")]
	private static void DKKOMGEFKPM(Bounds BMMLDIMMAAK, Color KDPJFGIFCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BA00", Offset = "0x5D6AA00", VA = "0x185D6BA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x656040", VA = "0x180657040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x677F30", Offset = "0x676F30", VA = "0x180677F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xFF1220", Offset = "0xFF0220", VA = "0x180FF1220")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB046F0", Offset = "0xB036F0", VA = "0x180B046F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "4")]
	public virtual void FBPMKNABHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
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
	[KIJCDAJOLJD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33048D0", Offset = "0x33038D0", VA = "0x1833048D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3304000", Offset = "0x3303000", VA = "0x183304000", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3304E10", Offset = "0x3303E10", VA = "0x183304E10")]
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
	private sealed class EFADPOCGLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public EFADPOCGLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9E850", Offset = "0x1C9D850", VA = "0x181C9E850")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[KIJCDAJOLJD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1CBC070", Offset = "0x1CBB070", VA = "0x181CBC070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1CBC0A0", Offset = "0x1CBB0A0", VA = "0x181CBC0A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1CBBFC0", Offset = "0x1CBAFC0", VA = "0x181CBBFC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey CCJNKBLKLDJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1CBBFF0", Offset = "0x1CBAFF0", VA = "0x181CBBFF0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1CBBEC0", Offset = "0x1CBAEC0", VA = "0x181CBBEC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB840", Offset = "0x1CBA840", VA = "0x181CBB840", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1CBAF10", Offset = "0x1CB9F10", VA = "0x181CBAF10", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1CBAE20", Offset = "0x1CB9E20", VA = "0x181CBAE20", Slot = "14")]
	protected virtual string FNJLMLMFBBO(TKeyVal CAHHMHDOMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1CBADC0", Offset = "0x1CB9DC0", VA = "0x181CBADC0", Slot = "4")]
	public bool ContainsKey(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1CBBDB0", Offset = "0x1CBADB0", VA = "0x181CBBDB0", Slot = "5")]
	public bool TryGetValue(TKey CCJNKBLKLDJ, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CBAE80", Offset = "0x1CB9E80", VA = "0x181CBAE80", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CBAE80", Offset = "0x1CB9E80", VA = "0x181CBAE80", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1CBBDE0", Offset = "0x1CBADE0", VA = "0x181CBBDE0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FJODBEIAGNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FEGHEBNGINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public FEGHEBNGINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2772AE0", Offset = "0x2771AE0", VA = "0x182772AE0")]
		internal bool <GetSamples>b__0(global::PMABFILABJH<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float NEECFLIOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float OPPNDEGGOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::PMABFILABJH<float, T>> JICIEFJDEKA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GKELHGEOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2840520", Offset = "0x283F520", VA = "0x182840520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28405A0", Offset = "0x283F5A0", VA = "0x1828405A0")]
	public FJODBEIAGNI(float PFEFIHOHHHJ, float IHEKBHOHGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2840340", Offset = "0x283F340", VA = "0x182840340")]
	public bool MIKLGOGDGGE(float EPNJJECKICP, T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x283FA40", Offset = "0x283EA40", VA = "0x18283FA40")]
	public int KKPPBHIPEOL(float EPNJJECKICP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x283FAA0", Offset = "0x283EAA0", VA = "0x18283FAA0")]
	public IEnumerable<T> LMFPILJPJPK(float EPNJJECKICP, [Optional] float? CGNHEIGCKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x283FA10", Offset = "0x283EA10", VA = "0x18283FA10")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2840120", Offset = "0x283F120", VA = "0x182840120")]
	private void MDCCMOFJMDE(float EPNJJECKICP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JBLGNAKMNJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PKJEMEFLGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T AAFFKFKIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PDOCOMCOHFL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float GNOFDMIJMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> FJEILAFLLJJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int NKHBPGAALFE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PKJEMEFLGJJ[] DEJEDNNJILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int OANDGKLJOPF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float EIIMCDJMMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEAC790", Offset = "0xEAB790", VA = "0x180EAC790")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEAC7A0", Offset = "0xEAB7A0", VA = "0x180EAC7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37CC860", Offset = "0x37CB860", VA = "0x1837CC860")]
	public JBLGNAKMNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37CC890", Offset = "0x37CB890", VA = "0x1837CC890")]
	public JBLGNAKMNJK(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37CBCD0", Offset = "0x37CACD0", VA = "0x1837CBCD0")]
	public void HEFJCCLOLGO(float EPNJJECKICP, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37CBE90", Offset = "0x37CAE90", VA = "0x1837CBE90")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x37CC430", Offset = "0x37CB430", VA = "0x1837CC430")]
	public bool KLCNLPGKMIO(float AEIJLDBDDCG, float EFOKDAAMCPK, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37CB3B0", Offset = "0x37CA3B0", VA = "0x1837CB3B0")]
	public bool BDBDOFMMLKL(float AEIJLDBDDCG, float EFOKDAAMCPK, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37CBAF0", Offset = "0x37CAAF0", VA = "0x1837CBAF0")]
	public void EEBOCFACPNG(float AEIJLDBDDCG, float EFOKDAAMCPK, List<T> CLABEIKAHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37CB870", Offset = "0x37CA870", VA = "0x1837CB870")]
	private int DLCMMCGHOEB(int MEADGPNFDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37CB830", Offset = "0x37CA830", VA = "0x1837CB830")]
	private void CILDGJIDJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BNMBPOAOGGL();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ELIBCCJNKOK(T AIAIDPGGDMM, T PHPKEGMGOPM, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JPODFEPGFHD(T IGJPNMBCJPK, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MCOEAJIJENK(T AIAIDPGGDMM, T PHPKEGMGOPM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BPGCONMIABP(T AIAIDPGGDMM, T PHPKEGMGOPM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PDLIGFKKOIO : global::JBLGNAKMNJK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1178430", Offset = "0x1177430", VA = "0x181178430", Slot = "4")]
	protected override Vector3 BNMBPOAOGGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x12D3DF0", Offset = "0x12D2DF0", VA = "0x1812D3DF0", Slot = "5")]
	protected override Vector3 ELIBCCJNKOK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D698F0", Offset = "0x5D688F0", VA = "0x185D698F0", Slot = "6")]
	protected override Vector3 JPODFEPGFHD(Vector3 IGJPNMBCJPK, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D69950", Offset = "0x5D68950", VA = "0x185D69950", Slot = "7")]
	protected override Vector3 MCOEAJIJENK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D69880", Offset = "0x5D68880", VA = "0x185D69880", Slot = "8")]
	protected override Vector3 BPGCONMIABP(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D699D0", Offset = "0x5D689D0", VA = "0x185D699D0")]
	public PDLIGFKKOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PHEPHJMBCCF : global::JBLGNAKMNJK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A470", Offset = "0x5D69470", VA = "0x185D6A470")]
	public PHEPHJMBCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A4E0", Offset = "0x5D694E0", VA = "0x185D6A4E0")]
	public PHEPHJMBCCF(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x111AE30", Offset = "0x1119E30", VA = "0x18111AE30", Slot = "4")]
	protected override float BNMBPOAOGGL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36674F0", Offset = "0x36664F0", VA = "0x1836674F0", Slot = "5")]
	protected override float ELIBCCJNKOK(float AIAIDPGGDMM, float PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F14920", Offset = "0x4F13920", VA = "0x184F14920", Slot = "6")]
	protected override float JPODFEPGFHD(float IGJPNMBCJPK, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27FD870", Offset = "0x27FC870", VA = "0x1827FD870", Slot = "7")]
	protected override float MCOEAJIJENK(float AIAIDPGGDMM, float PHPKEGMGOPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A460", Offset = "0x5D69460", VA = "0x185D6A460", Slot = "8")]
	protected override float BPGCONMIABP(float AIAIDPGGDMM, float PHPKEGMGOPM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCHNEANFBJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x22A1D40", Offset = "0x22A0D40", VA = "0x1822A1D40")]
	public static global::LALDAEGJJFA<T1> DAKLFHBAJIH<T1>(T1 NMINDOPCKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2533BB0", Offset = "0x2532BB0", VA = "0x182533BB0")]
	public static global::PMABFILABJH<T1, T2> DAKLFHBAJIH<T1, T2>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2533C20", Offset = "0x2532C20", VA = "0x182533C20")]
	public static global::GMGCAJLHPIK<T1, T2, T3> DAKLFHBAJIH<T1, T2, T3>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2533F90", Offset = "0x2532F90", VA = "0x182533F90")]
	public static global::CLFHCNPKBOH<T1, T2, T3, T4> DAKLFHBAJIH<T1, T2, T3, T4>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2533EF0", Offset = "0x2532EF0", VA = "0x182533EF0")]
	public static global::CAPGKAKHPDC<T1, T2, T3, T4, T5> DAKLFHBAJIH<T1, T2, T3, T4, T5>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2533E40", Offset = "0x2532E40", VA = "0x182533E40")]
	public static global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2533D80", Offset = "0x2532D80", VA = "0x182533D80")]
	public static global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6, T7>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2533CB0", Offset = "0x2532CB0", VA = "0x182533CB0")]
	public static global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6, T7, T8>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB, T8 OEMHJNGLELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x16E9D50", Offset = "0x16E8D50", VA = "0x1816E9D50")]
	[IteratorStateMachine(typeof(JGNFANIOHJJ))]
	public static IEnumerable<global::PMABFILABJH<T1, T2>> KAGONGNLDCG<T1, T2>(IEnumerable<T1> BMPDKJEHGIN, IEnumerable<T2> BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16E9F30", Offset = "0x16E8F30", VA = "0x1816E9F30")]
	[IteratorStateMachine(typeof(CNNFKOIEOMN))]
	public static IEnumerable<global::GMGCAJLHPIK<T1, T2, T3>> KAGONGNLDCG<T1, T2, T3>(IEnumerable<T1> BMPDKJEHGIN, IEnumerable<T2> BMMLDIMMAAK, IEnumerable<T3> KDPJFGIFCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x847AE0", Offset = "0x846AE0", VA = "0x180847AE0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x847AD0", Offset = "0x846AD0", VA = "0x180847AD0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x847AB0", Offset = "0x846AB0", VA = "0x180847AB0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D664E0", Offset = "0x5D654E0", VA = "0x185D664E0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D66500", Offset = "0x5D65500", VA = "0x185D66500")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D66550", Offset = "0x5D65550", VA = "0x185D66550")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN, int MAEKELKOLGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D66520", Offset = "0x5D65520", VA = "0x185D66520")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN, int MAEKELKOLGE, int IBEHKJEGGAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LALDAEGJJFA<T1> : IComparable<global::LALDAEGJJFA<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x19845E0", Offset = "0x19835E0", VA = "0x1819845E0")]
	public LALDAEGJJFA(T1 NMINDOPCKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CC69B0", Offset = "0x3CC59B0", VA = "0x183CC69B0", Slot = "4")]
	public int CompareTo(global::LALDAEGJJFA<T1> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6A20", Offset = "0x3CC5A20", VA = "0x183CC6A20", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9507A0", Offset = "0x94F7A0", VA = "0x1809507A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6AC0", Offset = "0x3CC5AC0", VA = "0x183CC6AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PMABFILABJH<T1, T2> : IComparable<global::PMABFILABJH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37C2180", Offset = "0x37C1180", VA = "0x1837C2180")]
	public PMABFILABJH(T1 NMINDOPCKDG, T2 DDEJHDMCLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37C0380", Offset = "0x37BF380", VA = "0x1837C0380", Slot = "4")]
	public int CompareTo(global::PMABFILABJH<T1, T2> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37C07C0", Offset = "0x37BF7C0", VA = "0x1837C07C0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37C1460", Offset = "0x37C0460", VA = "0x1837C1460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37C1B70", Offset = "0x37C0B70", VA = "0x1837C1B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GMGCAJLHPIK<T1, T2, T3> : IComparable<global::GMGCAJLHPIK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D90830", Offset = "0x2D8F830", VA = "0x182D90830")]
	public GMGCAJLHPIK(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D90020", Offset = "0x2D8F020", VA = "0x182D90020", Slot = "4")]
	public int CompareTo(global::GMGCAJLHPIK<T1, T2, T3> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D90310", Offset = "0x2D8F310", VA = "0x182D90310", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2D90510", Offset = "0x2D8F510", VA = "0x182D90510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D90680", Offset = "0x2D8F680", VA = "0x182D90680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CLFHCNPKBOH<T1, T2, T3, T4> : IComparable<global::CLFHCNPKBOH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27D8800", Offset = "0x27D7800", VA = "0x1827D8800")]
	public CLFHCNPKBOH(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27D83B0", Offset = "0x27D73B0", VA = "0x1827D83B0", Slot = "4")]
	public int CompareTo(global::CLFHCNPKBOH<T1, T2, T3, T4> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27D84F0", Offset = "0x27D74F0", VA = "0x1827D84F0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27D8610", Offset = "0x27D7610", VA = "0x1827D8610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27D86D0", Offset = "0x27D76D0", VA = "0x1827D86D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CAPGKAKHPDC<T1, T2, T3, T4, T5> : IComparable<global::CAPGKAKHPDC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC91C0", Offset = "0x2AC81C0", VA = "0x182AC91C0")]
	public CAPGKAKHPDC(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x35D87B0", Offset = "0x35D77B0", VA = "0x1835D87B0", Slot = "4")]
	public int CompareTo(global::CAPGKAKHPDC<T1, T2, T3, T4, T5> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35D8930", Offset = "0x35D7930", VA = "0x1835D8930", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x35D8A70", Offset = "0x35D7A70", VA = "0x1835D8A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35D8B70", Offset = "0x35D7B70", VA = "0x1835D8B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> : IComparable<global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 JJICPPMKADB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x32E1930", Offset = "0x32E0930", VA = "0x1832E1930")]
	public KHOGFEGEPPG(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x32E1370", Offset = "0x32E0370", VA = "0x1832E1370", Slot = "4")]
	public int CompareTo(global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x32E1530", Offset = "0x32E0530", VA = "0x1832E1530", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x32E16A0", Offset = "0x32E06A0", VA = "0x1832E16A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x32E17C0", Offset = "0x32E07C0", VA = "0x1832E17C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 JJICPPMKADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 OAOHENKGOEB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3347D70", Offset = "0x3346D70", VA = "0x183347D70")]
	public PLDBIEDAKMI(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x33476F0", Offset = "0x33466F0", VA = "0x1833476F0", Slot = "4")]
	public int CompareTo(global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x33478F0", Offset = "0x33468F0", VA = "0x1833478F0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3347A90", Offset = "0x3346A90", VA = "0x183347A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3347BE0", Offset = "0x3346BE0", VA = "0x183347BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 JJICPPMKADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 OAOHENKGOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 EDBFJNKKPBK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x28D2560", Offset = "0x28D1560", VA = "0x1828D2560")]
	public DEKMENFBCJI(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB, T8 OEMHJNGLELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x28D1E30", Offset = "0x28D0E30", VA = "0x1828D1E30", Slot = "4")]
	public int CompareTo(global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x28D2080", Offset = "0x28D1080", VA = "0x1828D2080", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x28D2240", Offset = "0x28D1240", VA = "0x1828D2240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x28D23B0", Offset = "0x28D13B0", VA = "0x1828D23B0", Slot = "3")]
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
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1B3BB10", Offset = "0x1B3AB10", VA = "0x181B3BB10")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B340B0", Offset = "0x3B330B0", VA = "0x183B340B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float OHKFNMEMBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x13A5560", Offset = "0x13A4560", VA = "0x1813A5560")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3B344E0", Offset = "0x3B334E0", VA = "0x183B344E0")]
	public T IDMFPCCIJGG(float MGEGOIPHNMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B34130", Offset = "0x3B33130", VA = "0x183B34130")]
	public T BELDBJKBCMF(float MGEGOIPHNMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ELIBCCJNKOK(T AIAIDPGGDMM, T PHPKEGMGOPM, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36674F0", Offset = "0x36664F0", VA = "0x1836674F0", Slot = "4")]
	protected override float ELIBCCJNKOK(float AIAIDPGGDMM, float PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D66230", Offset = "0x5D65230", VA = "0x185D66230")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x12D3DF0", Offset = "0x12D2DF0", VA = "0x1812D3DF0", Slot = "4")]
	protected override Vector3 ELIBCCJNKOK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D6CCA0", Offset = "0x5D6BCA0", VA = "0x185D6CCA0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D65B90", Offset = "0x5D64B90", VA = "0x185D65B90", Slot = "4")]
	protected override Color ELIBCCJNKOK(Color AIAIDPGGDMM, Color PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D65BE0", Offset = "0x5D64BE0", VA = "0x185D65BE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JMGENFMKBJM : global::IGFGNFBNCFM<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D674F0", Offset = "0x5D664F0", VA = "0x185D674F0")]
	public JMGENFMKBJM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D67540", Offset = "0x5D66540", VA = "0x185D67540")]
	public JMGENFMKBJM(BFKLEOLBFKE[] NGBKPJMNOJL, bool CJEDMAAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D67480", Offset = "0x5D66480", VA = "0x185D67480", Slot = "6")]
	protected override uint FAFAEFMGNCB(uint PKCNHEGJGNH, string IGJPNMBCJPK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DPNDFADNENP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public DPNDFADNENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CCFKCPBJFFM
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class INLHGLENJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<NOAPHGCLLPE> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public INLHGLENJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D67270", Offset = "0x5D66270", VA = "0x185D67270")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<NOAPHGCLLPE>> IKOMNHMPMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int NFHKMINGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ENAJEKBICDE;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCCD1E0", Offset = "0xCCC1E0", VA = "0x180CCD1E0")]
	private CCFKCPBJFFM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<NOAPHGCLLPE>> GMDNKLDPALN, int IKOLEADJCBB, int IPNILBFBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D650A0", Offset = "0x5D640A0", VA = "0x185D650A0")]
	public static CCFKCPBJFFM MIHDEIPKAKJ()
	{
		return default(CCFKCPBJFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D64CB0", Offset = "0x5D63CB0", VA = "0x185D64CB0")]
	public (int, int, Task) DAOPLKHGKIO(int KKLMLLAHIKF, [Optional] CancellationToken GPNLCIOKAPO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D64BD0", Offset = "0x5D63BD0", VA = "0x185D64BD0")]
	public void ABLFFODOBHI(int KKLMLLAHIKF, int IPNILBFBOEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class FCPKILMBEJN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> CINMFEFLEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> EOGBCNENJID;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x198D670", Offset = "0x198C670", VA = "0x18198D670", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x259C7F0", Offset = "0x259B7F0", VA = "0x18259C7F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BKNOINJLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x219DFE0", Offset = "0x219CFE0", VA = "0x18219DFE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2772720", Offset = "0x2771720", VA = "0x182772720", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2772750", Offset = "0x2771750", VA = "0x182772750", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2772100", Offset = "0x2771100", VA = "0x182772100")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2771E80", Offset = "0x2770E80", VA = "0x182771E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2771D60", Offset = "0x2770D60", VA = "0x182771D60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27725A0", Offset = "0x27715A0", VA = "0x1827725A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2771B90", Offset = "0x2770B90", VA = "0x182771B90", Slot = "9")]
	public void Add(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2771BF0", Offset = "0x2770BF0", VA = "0x182771BF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2771DC0", Offset = "0x2770DC0", VA = "0x182771DC0", Slot = "8")]
	public bool ContainsKey(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x219DA10", Offset = "0x219CA10", VA = "0x18219DA10", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2772570", Offset = "0x2771570", VA = "0x182772570", Slot = "10")]
	public bool Remove(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2772570", Offset = "0x2771570", VA = "0x182772570", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x198F090", Offset = "0x198E090", VA = "0x18198F090", Slot = "11")]
	public bool TryGetValue(TKey CCJNKBLKLDJ, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2771F90", Offset = "0x2770F90", VA = "0x182771F90", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2771E20", Offset = "0x2770E20", VA = "0x182771E20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2772080", Offset = "0x2771080", VA = "0x182772080")]
	public void HEFJCCLOLGO(TVal BIILFBFAAOF, TKey CCJNKBLKLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27720C0", Offset = "0x27710C0", VA = "0x1827720C0")]
	public void HEFJCCLOLGO(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2771F60", Offset = "0x2770F60", VA = "0x182771F60")]
	public bool GAOLFNHFINJ(TVal CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2771F00", Offset = "0x2770F00", VA = "0x182771F00")]
	public bool FKLGFCOHCLF(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2771B30", Offset = "0x2770B30", VA = "0x182771B30")]
	public bool AKJLIPOIGHF(TVal CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2771B30", Offset = "0x2770B30", VA = "0x182771B30")]
	public bool AKJLIPOIGHF(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2771C20", Offset = "0x2770C20", VA = "0x182771C20")]
	public bool CECEMJJAJEO(TVal CCJNKBLKLDJ, out TKey IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27721C0", Offset = "0x27711C0", VA = "0x1827721C0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> MBDPPCMHIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2771C50", Offset = "0x2770C50", VA = "0x182771C50")]
	private void CJMLMJJNOLA(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2771AB0", Offset = "0x2770AB0", VA = "0x182771AB0")]
	private void AKEMGCGHGMJ(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x27723C0", Offset = "0x27713C0", VA = "0x1827723C0")]
	private bool OMFGKOPAABL(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2772240", Offset = "0x2771240", VA = "0x182772240")]
	private bool OMFGKOPAABL(TVal BIILFBFAAOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2772640", Offset = "0x2771640", VA = "0x182772640")]
	public FCPKILMBEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class DODFIGEAAMK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::DODFIGEAAMK<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2DF77E0", Offset = "0x2DF67E0", VA = "0x182DF77E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8EF0", Offset = "0x2DF7EF0", VA = "0x182DF8EF0")]
		public Enumerator(global::DODFIGEAAMK<T> CLABEIKAHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A70", Offset = "0x2DF2A70", VA = "0x182DF3A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5430", Offset = "0x2DF4430", VA = "0x182DF5430", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DF47E0", Offset = "0x2DF37E0", VA = "0x182DF47E0")]
		private void NHMPMKJDMCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] IMPDEOOHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int HMJFOJBNOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int FNKNJJDKBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int JKGBPKEJAFA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3770610", Offset = "0x376F610", VA = "0x183770610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x37707A0", Offset = "0x376F7A0", VA = "0x1837707A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3770270", Offset = "0x376F270", VA = "0x183770270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3771F00", Offset = "0x3770F00", VA = "0x183771F00")]
	public DODFIGEAAMK(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3770550", Offset = "0x376F550", VA = "0x183770550")]
	public void HEFJCCLOLGO(T MGEGOIPHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3770E10", Offset = "0x376FE10", VA = "0x183770E10")]
	public void MBOIAEPEMME(IEnumerable<T> IEJLANBMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3770650", Offset = "0x376F650", VA = "0x183770650")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x376FFC0", Offset = "0x376EFC0", VA = "0x18376FFC0")]
	public void AFMOCBFFKLG(int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x37717B0", Offset = "0x37707B0", VA = "0x1837717B0")]
	public void NLNAGEFBDKO(int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3771AE0", Offset = "0x3770AE0", VA = "0x183771AE0")]
	public void PPKHELNFGHN(T[] DEJEDNNJILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x37700C0", Offset = "0x376F0C0", VA = "0x1837700C0")]
	public Enumerator BALJJOIEHDJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3771E80", Offset = "0x3770E80", VA = "0x183771E80", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3771E80", Offset = "0x3770E80", VA = "0x183771E80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x37716C0", Offset = "0x37706C0", VA = "0x1837716C0")]
	private int NKPOMEGNFJL(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x37702F0", Offset = "0x376F2F0", VA = "0x1837702F0")]
	private int FNKOOOHJHLL(int AIPHGHFENPJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class CEOPBBNBALE<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> DIDGKJLMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761B40", VA = "0x180762B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x710170", VA = "0x180711170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x35E8E60", Offset = "0x35E7E60", VA = "0x1835E8E60", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x35E8F00", Offset = "0x35E7F00", VA = "0x1835E8F00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x35E8E00", Offset = "0x35E7E00", VA = "0x1835E8E00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3336040", Offset = "0x3335040", VA = "0x183336040")]
	public CEOPBBNBALE(Func<Internal, External> DMOLCMIDIPC, Func<External, Internal> NKGCIMMLMNL, bool EFNCJMHMODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x35E8B20", Offset = "0x35E7B20", VA = "0x1835E8B20", Slot = "6")]
	public int IndexOf(External GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x35E87A0", Offset = "0x35E77A0", VA = "0x1835E87A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x35E8800", Offset = "0x35E7800", VA = "0x1835E8800", Slot = "13")]
	public bool Contains(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x35E8890", Offset = "0x35E7890", VA = "0x1835E8890", Slot = "14")]
	public void CopyTo(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x35E86B0", Offset = "0x35E76B0", VA = "0x1835E86B0", Slot = "11")]
	public void Add(External GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x35E8C10", Offset = "0x35E7C10", VA = "0x1835E8C10", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, External GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x35E8D70", Offset = "0x35E7D70", VA = "0x1835E8D70", Slot = "15")]
	public bool Remove(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35E8CB0", Offset = "0x35E7CB0", VA = "0x1835E8CB0", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x35E8AB0", Offset = "0x35E7AB0", VA = "0x1835E8AB0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5C00", Offset = "0x1CA4C00", VA = "0x181CA5C00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class JNJFGLHJIAA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> DIDGKJLMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x677020", VA = "0x180678020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2F651F0", Offset = "0x2F641F0", VA = "0x182F651F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2F65190", Offset = "0x2F64190", VA = "0x182F65190", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x19845E0", Offset = "0x19835E0", VA = "0x1819845E0")]
	public JNJFGLHJIAA(Func<Internal, External> DMOLCMIDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2F65140", Offset = "0x2F64140", VA = "0x182F65140")]
	public JNJFGLHJIAA(IReadOnlyList<Internal> LPDILHBGHIJ, Func<Internal, External> DMOLCMIDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2F64F20", Offset = "0x2F63F20", VA = "0x182F64F20")]
	public void PPKHELNFGHN(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2F64EB0", Offset = "0x2F63EB0", VA = "0x182F64EB0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x20A0AF0", Offset = "0x209FAF0", VA = "0x1820A0AF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class ENHAAEOHKMG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> DIDGKJLMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x677020", VA = "0x180678020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB37F0", Offset = "0x1CB27F0", VA = "0x181CB37F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3790", Offset = "0x1CB2790", VA = "0x181CB3790", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x19845E0", Offset = "0x19835E0", VA = "0x1819845E0")]
	public ENHAAEOHKMG(IReadOnlyList<Internal> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3450", Offset = "0x1CB2450", VA = "0x181CB3450")]
	public bool FKLGFCOHCLF(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3560", Offset = "0x1CB2560", VA = "0x181CB3560")]
	public void PPKHELNFGHN(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1CB34F0", Offset = "0x1CB24F0", VA = "0x181CB34F0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5C00", Offset = "0x1CA4C00", VA = "0x181CA5C00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class OOBIPEFEBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BOFGMCIJMOB(object[] KMLLOCJHKPB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	protected OOBIPEFEBFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class MGFMFOPAFMH<T> : OOBIPEFEBFC
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct OOANCOEDOMG
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum EHMCAOLLPOA
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
		public EHMCAOLLPOA NKICFHCCMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T CGKOOFFNHKL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int AAEDHDPJJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool IFHECGMDCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool BFGABEDFGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> NNOKMJLHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<OOANCOEDOMG> HIKNIBPGCPD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LMPMKEPAAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x293D770", Offset = "0x293C770", VA = "0x18293D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x293DBB0", Offset = "0x293CBB0", VA = "0x18293DBB0")]
	protected MGFMFOPAFMH(bool BFGABEDFGDF, bool IFHECGMDCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x293D7B0", Offset = "0x293C7B0", VA = "0x18293D7B0")]
	protected bool IHANIHNJOHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x293D940", Offset = "0x293C940", VA = "0x18293D940")]
	protected void KCDLPJCFPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x293DA00", Offset = "0x293CA00", VA = "0x18293DA00")]
	protected void OPBGBGHEECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x29C5780", Offset = "0x29C4780", VA = "0x1829C5780")]
	private static void ECHDNBIJIMA<U>(ref List<U> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x293D610", Offset = "0x293C610", VA = "0x18293D610", Slot = "5")]
	public void HEFJCCLOLGO(T CGKOOFFNHKL, bool AKNODPLKBJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x293D4D0", Offset = "0x293C4D0", VA = "0x18293D4D0", Slot = "6")]
	public void AKJLIPOIGHF(T CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x293D830", Offset = "0x293C830", VA = "0x18293D830")]
	public void IIOELKEIHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ONAKOFCPCOE
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class HOPKEKFNJGO : global::MGFMFOPAFMH<Action>, ONAKOFCPCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D66C30", Offset = "0x5D65C30", VA = "0x185D66C30")]
	public HOPKEKFNJGO(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D66A20", Offset = "0x5D65A20", VA = "0x185D66A20")]
	public void PFJMFFOKNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D668F0", Offset = "0x5D658F0", VA = "0x185D668F0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D66960", Offset = "0x5D65960", VA = "0x185D66960")]
	public static HOPKEKFNJGO KFDPIIJCIIP(HOPKEKFNJGO FCEJCCPBICH, Action CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D669C0", Offset = "0x5D659C0", VA = "0x185D669C0")]
	public static HOPKEKFNJGO MPKLCJPFEHE(HOPKEKFNJGO FCEJCCPBICH, Action CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CFMDFNLANIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DGLAMKJBKDM<T> : global::MGFMFOPAFMH<Action<T>>, global::CFMDFNLANIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9760", Offset = "0x1CA8760", VA = "0x181CA9760")]
	public DGLAMKJBKDM(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x28D7900", Offset = "0x28D6900", VA = "0x1828D7900")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x28D5DF0", Offset = "0x28D4DF0", VA = "0x1828D5DF0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x28D77C0", Offset = "0x28D67C0", VA = "0x1828D77C0")]
	public static global::DGLAMKJBKDM<T> KFDPIIJCIIP(global::DGLAMKJBKDM<T> FCEJCCPBICH, Action<T> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x28D7860", Offset = "0x28D6860", VA = "0x1828D7860")]
	public static global::DGLAMKJBKDM<T> MPKLCJPFEHE(global::DGLAMKJBKDM<T> FCEJCCPBICH, Action<T> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CNLDHNPGIHO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class LLCCCNFJKCL<T, U> : global::MGFMFOPAFMH<Action<T, U>>, global::CNLDHNPGIHO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9760", Offset = "0x1CA8760", VA = "0x181CA9760")]
	public LLCCCNFJKCL(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x300C580", Offset = "0x300B580", VA = "0x18300C580")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3009B20", Offset = "0x3008B20", VA = "0x183009B20", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x300B480", Offset = "0x300A480", VA = "0x18300B480")]
	public static global::LLCCCNFJKCL<T, U> KFDPIIJCIIP(global::LLCCCNFJKCL<T, U> FCEJCCPBICH, Action<T, U> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x300B520", Offset = "0x300A520", VA = "0x18300B520")]
	public static global::LLCCCNFJKCL<T, U> MPKLCJPFEHE(global::LLCCCNFJKCL<T, U> FCEJCCPBICH, Action<T, U> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ABAIGLNNAKP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class EJCHHEKFLCK<T, U, V> : global::MGFMFOPAFMH<Action<T, U, V>>, global::ABAIGLNNAKP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9760", Offset = "0x1CA8760", VA = "0x181CA9760")]
	public EJCHHEKFLCK(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1CA85A0", Offset = "0x1CA75A0", VA = "0x181CA85A0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6FC0", Offset = "0x1CA5FC0", VA = "0x181CA6FC0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1CA7810", Offset = "0x1CA6810", VA = "0x181CA7810")]
	public static global::EJCHHEKFLCK<T, U, V> KFDPIIJCIIP(global::EJCHHEKFLCK<T, U, V> FCEJCCPBICH, Action<T, U, V> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1CA78B0", Offset = "0x1CA68B0", VA = "0x181CA78B0")]
	public static global::EJCHHEKFLCK<T, U, V> MPKLCJPFEHE(global::EJCHHEKFLCK<T, U, V> FCEJCCPBICH, Action<T, U, V> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HMHLANANKLE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V, W> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V, W> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BPHJINJDCNI<T, U, V, W> : global::MGFMFOPAFMH<Action<T, U, V, W>>, global::HMHLANANKLE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9760", Offset = "0x1CA8760", VA = "0x181CA9760")]
	public BPHJINJDCNI(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x209AD90", Offset = "0x2099D90", VA = "0x18209AD90")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2098550", Offset = "0x2097550", VA = "0x182098550", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x20999C0", Offset = "0x20989C0", VA = "0x1820999C0")]
	public static global::BPHJINJDCNI<T, U, V, W> KFDPIIJCIIP(global::BPHJINJDCNI<T, U, V, W> FCEJCCPBICH, Action<T, U, V, W> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2099A60", Offset = "0x2098A60", VA = "0x182099A60")]
	public static global::BPHJINJDCNI<T, U, V, W> MPKLCJPFEHE(global::BPHJINJDCNI<T, U, V, W> FCEJCCPBICH, Action<T, U, V, W> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface IMJNHIOLGDG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V, W, X> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V, W, X> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FLKKAPMNAPH<T, U, V, W, X> : global::MGFMFOPAFMH<Action<T, U, V, W, X>>, global::IMJNHIOLGDG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9760", Offset = "0x1CA8760", VA = "0x181CA9760")]
	public FLKKAPMNAPH(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2843EC0", Offset = "0x2842EC0", VA = "0x182843EC0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA, X KNMKEOOODCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2843A90", Offset = "0x2842A90", VA = "0x182843A90", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2843D80", Offset = "0x2842D80", VA = "0x182843D80")]
	public static global::FLKKAPMNAPH<T, U, V, W, X> KFDPIIJCIIP(global::FLKKAPMNAPH<T, U, V, W, X> FCEJCCPBICH, Action<T, U, V, W, X> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2843E20", Offset = "0x2842E20", VA = "0x182843E20")]
	public static global::FLKKAPMNAPH<T, U, V, W, X> MPKLCJPFEHE(global::FLKKAPMNAPH<T, U, V, W, X> FCEJCCPBICH, Action<T, U, V, W, X> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MCJFKKBBPGI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V, W, X, Y> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V, W, X, Y> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class BJEBAFPKEPO<T, U, V, W, X, Y> : global::MGFMFOPAFMH<Action<T, U, V, W, X, Y>>, global::MCJFKKBBPGI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9760", Offset = "0x1CA8760", VA = "0x181CA9760")]
	public BJEBAFPKEPO(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x26CAEF0", Offset = "0x26C9EF0", VA = "0x1826CAEF0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA, X KNMKEOOODCL, Y EMKKILCIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x26CAA70", Offset = "0x26C9A70", VA = "0x1826CAA70", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x26CADB0", Offset = "0x26C9DB0", VA = "0x1826CADB0")]
	public static global::BJEBAFPKEPO<T, U, V, W, X, Y> KFDPIIJCIIP(global::BJEBAFPKEPO<T, U, V, W, X, Y> FCEJCCPBICH, Action<T, U, V, W, X, Y> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x26CAE50", Offset = "0x26C9E50", VA = "0x1826CAE50")]
	public static global::BJEBAFPKEPO<T, U, V, W, X, Y> MPKLCJPFEHE(global::BJEBAFPKEPO<T, U, V, W, X, Y> FCEJCCPBICH, Action<T, U, V, W, X, Y> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class DPDBANLLCHB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct APJLHEHHPLO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::DPDBANLLCHB<T> PLEIMFNANHP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T AAFFKFKIJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x25ABC60", Offset = "0x25AAC60", VA = "0x1825ABC60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x25ABC30", Offset = "0x25AAC30", VA = "0x1825ABC30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x887620", Offset = "0x886620", VA = "0x180887620")]
		public APJLHEHHPLO(global::DPDBANLLCHB<T> PLEIMFNANHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ADIDHHDFJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<APJLHEHHPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::DPDBANLLCHB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x258B180", Offset = "0x258A180", VA = "0x18258B180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x21D24D0", Offset = "0x21D14D0", VA = "0x1821D24D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BJCCDIFFBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<APJLHEHHPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::DPDBANLLCHB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x26CA200", Offset = "0x26C9200", VA = "0x1826CA200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x21D24D0", Offset = "0x21D14D0", VA = "0x1821D24D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim JHOIDJHANMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T ADCLMADMKEO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KGOAEFBEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3771FA0", Offset = "0x3770FA0", VA = "0x183771FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3772610", Offset = "0x3771610", VA = "0x183772610")]
	public DPDBANLLCHB(in T ADCLMADMKEO, int EOLLBDABFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x37725E0", Offset = "0x37715E0", VA = "0x1837725E0")]
	public DPDBANLLCHB(in T ADCLMADMKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x37725A0", Offset = "0x37715A0", VA = "0x1837725A0")]
	public APJLHEHHPLO KNHOBDNOPAG()
	{
		return default(APJLHEHHPLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3772560", Offset = "0x3771560", VA = "0x183772560")]
	public APJLHEHHPLO KNHOBDNOPAG(CancellationToken GPNLCIOKAPO)
	{
		return default(APJLHEHHPLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3772400", Offset = "0x3771400", VA = "0x183772400")]
	[AsyncStateMachine(typeof(global::DPDBANLLCHB<>.ADIDHHDFJJE))]
	public Task<APJLHEHHPLO> JILDGGEHMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3772120", Offset = "0x3771120", VA = "0x183772120")]
	[AsyncStateMachine(typeof(global::DPDBANLLCHB<>.BJCCDIFFBIJ))]
	public Task<APJLHEHHPLO> JILDGGEHMAG(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NNFMNCGNJLP
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D687D0", Offset = "0x5D677D0", VA = "0x185D687D0")]
	public static global::DPDBANLLCHB<NOAPHGCLLPE> MIHDEIPKAKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D68830", Offset = "0x5D67830", VA = "0x185D68830")]
	public static global::DPDBANLLCHB<NOAPHGCLLPE> MIHDEIPKAKJ(int EOLLBDABFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22A1D40", Offset = "0x22A0D40", VA = "0x1822A1D40")]
	public static global::DPDBANLLCHB<T> MIHDEIPKAKJ<T>(in T ADCLMADMKEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x25415D0", Offset = "0x25405D0", VA = "0x1825415D0")]
	public static global::DPDBANLLCHB<T> MIHDEIPKAKJ<T>(in T ADCLMADMKEO, int EOLLBDABFNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DNBNOMMLHDF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> CCGPMIENEGA(TRequest NMKJPBEONAN, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum PMNMEDJOCHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class HEACGNJJANC
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float BANILBHLOJA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan GHGEDEHCCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int MMMALNMGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public PMNMEDJOCHC BDHDDJIANPB;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly HEACGNJJANC FOBBLKPOGAD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float OBDDMCCEBCE
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2AEBED0", Offset = "0x2AEAED0", VA = "0x182AEBED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan HMADCCDOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEBFB0", Offset = "0x2AEAFB0", VA = "0x182AEBFB0")]
		public HEACGNJJANC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct MKIDIHDKCME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest NMKJPBEONAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken GPNLCIOKAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> LHCEGKDLLFP;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2946200", Offset = "0x2945200", VA = "0x182946200")]
		public MKIDIHDKCME(TRequest NMKJPBEONAN, TaskCompletionSource<TResult> LHCEGKDLLFP, CancellationToken GPNLCIOKAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IIPKFMMJLMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public IIPKFMMJLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x198D670", Offset = "0x198C670", VA = "0x18198D670")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BNGJMLIDHKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::DNBNOMMLHDF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x26DDA40", Offset = "0x26DCA40", VA = "0x1826DDA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct OACBKAOOALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::DNBNOMMLHDF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private MKIDIHDKCME <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3146190", Offset = "0x3145190", VA = "0x183146190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CAFLMMKDADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<MKIDIHDKCME> OHAAAOMNODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HEACGNJJANC FDDPIIDBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CCGPMIENEGA GCFALEHIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task LDMGDIIOMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int MNPGHNDKJHI;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3765CC0", Offset = "0x3764CC0", VA = "0x183765CC0")]
	public DNBNOMMLHDF(CCGPMIENEGA GCFALEHIFLC, [Optional] HEACGNJJANC FDDPIIDBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3764E90", Offset = "0x3763E90", VA = "0x183764E90")]
	public Task<TResult> MALNAJHIBFG(TRequest NMKJPBEONAN, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x37642D0", Offset = "0x37632D0", VA = "0x1837642D0")]
	private void ACDFKBIFHGN(MKIDIHDKCME CJGJCKBAIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x37655A0", Offset = "0x37645A0", VA = "0x1837655A0")]
	[AsyncStateMachine(typeof(global::DNBNOMMLHDF<, >.BNGJMLIDHKL))]
	private Task MCEBBCLHLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3764C40", Offset = "0x3763C40", VA = "0x183764C40")]
	private MKIDIHDKCME ICCBDBEBDBJ()
	{
		return default(MKIDIHDKCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3764670", Offset = "0x3763670", VA = "0x183764670")]
	[AsyncStateMachine(typeof(global::DNBNOMMLHDF<, >.OACBKAOOALJ))]
	private Task GFCGGNHPJCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3765A40", Offset = "0x3764A40", VA = "0x183765A40")]
	private void OGJLEIEFKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x37643F0", Offset = "0x37633F0", VA = "0x1837643F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BCJGEIEPHMJ<TKey, TVal> : global::NBIICPFMMDD<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KJIILFOGNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> EDLCOEKGMOH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int FMNPGKADBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4357CF0", Offset = "0x4356CF0", VA = "0x184357CF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int OACNGCDEPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4357CC0", Offset = "0x4356CC0", VA = "0x184357CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4357DC0", Offset = "0x4356DC0", VA = "0x184357DC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x43582D0", Offset = "0x43572D0", VA = "0x1843582D0")]
	public BCJGEIEPHMJ(int CHMDLBBFMNF, [Optional] POIMLJHIOIB BGOKELNJCKK, [Optional] IEqualityComparer<TKey> EMOGODJCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4357D20", Offset = "0x4356D20", VA = "0x184357D20")]
	public void HLAPECFMGBJ(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK, bool AFFICNKLOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4357E90", Offset = "0x4356E90", VA = "0x184357E90")]
	public bool JGFCJGCMJIK(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4357C20", Offset = "0x4356C20", VA = "0x184357C20", Slot = "6")]
	public override bool CECEMJJAJEO(TKey ANHJHIFLNAP, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4357FB0", Offset = "0x4356FB0", VA = "0x184357FB0")]
	public bool KJCKEGMFBCA(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x43581C0", Offset = "0x43571C0", VA = "0x1843581C0")]
	public bool PNCCILMHKNM(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4357E20", Offset = "0x4356E20", VA = "0x184357E20", Slot = "7")]
	public override void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4357F10", Offset = "0x4356F10", VA = "0x184357F10")]
	private bool JPMBNFDOCMI(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class NBIICPFMMDD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int POIMLJHIOIB(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class LOHNIHEMMIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey HJHOJEFKDAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal AAFFKFKIJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PANMOHPAPDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6791B0", Offset = "0x6781B0", VA = "0x1806791B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8278B0", Offset = "0x8268B0", VA = "0x1808278B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime EBOIDOANILN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xE807F0", Offset = "0xE7F7F0", VA = "0x180E807F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x307E770", Offset = "0x307D770", VA = "0x18307E770")]
		public LOHNIHEMMIG(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int JHFGACAIMJP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<LOHNIHEMMIG>> JNNBOBKGBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<LOHNIHEMMIG> KNKOFIHPGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly POIMLJHIOIB BGOKELNJCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan LMANHNCHJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly PCCFJFHBKMO BODBBFPNIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HNBJFLIKECB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x656020", VA = "0x180657020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool ODLPIEENENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x21AB820", Offset = "0x21AA820", VA = "0x1821AB820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int FMNPGKADBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x73A090", Offset = "0x739090", VA = "0x18073A090", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int KOHJDBBJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2048AF0", Offset = "0x2047AF0", VA = "0x182048AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1C966C0", Offset = "0x1C956C0", VA = "0x181C966C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x21AB2E0", Offset = "0x21AA2E0", VA = "0x1821AB2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x21AD000", Offset = "0x21AC000", VA = "0x1821AD000")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x21ABE30", Offset = "0x21AAE30", VA = "0x1821ABE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x21AE3E0", Offset = "0x21AD3E0", VA = "0x1821AE3E0")]
	public NBIICPFMMDD(int CHMDLBBFMNF, [Optional] POIMLJHIOIB BGOKELNJCKK, [Optional] IEqualityComparer<TKey> EMOGODJCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x21AE1F0", Offset = "0x21AD1F0", VA = "0x1821AE1F0")]
	public NBIICPFMMDD(TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x21AE0D0", Offset = "0x21AD0D0", VA = "0x1821AE0D0")]
	public NBIICPFMMDD(int CHMDLBBFMNF, TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x21ADE50", Offset = "0x21ACE50", VA = "0x1821ADE50")]
	public NBIICPFMMDD(int CHMDLBBFMNF, POIMLJHIOIB BGOKELNJCKK, TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x21AD840", Offset = "0x21AC840", VA = "0x1821AD840")]
	public void PGHLLDMAKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x21ADBF0", Offset = "0x21ACBF0", VA = "0x1821ADBF0")]
	public void PIGMJENILDA(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x21AB170", Offset = "0x21AA170", VA = "0x1821AB170")]
	public bool AKJLIPOIGHF(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x21AB690", Offset = "0x21AA690", VA = "0x1821AB690")]
	private TVal BOPAOPJOHPG(TKey ANHJHIFLNAP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x21ABB60", Offset = "0x21AAB60", VA = "0x1821ABB60", Slot = "6")]
	public virtual bool CECEMJJAJEO(TKey ANHJHIFLNAP, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x21AC650", Offset = "0x21AB650", VA = "0x1821AC650", Slot = "7")]
	public virtual void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x21AAD30", Offset = "0x21A9D30", VA = "0x1821AAD30")]
	private bool AFAPCIEDBMB(LOHNIHEMMIG NJLMIMMKHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x21ACB40", Offset = "0x21ABB40", VA = "0x1821ACB40")]
	private void JOOPJAFPNIA(LinkedListNode<LOHNIHEMMIG> JEJKKAMKIIN, TVal LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x21AC450", Offset = "0x21AB450", VA = "0x1821AC450")]
	private void FEJCNECMMHF(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x21AD1E0", Offset = "0x21AC1E0", VA = "0x1821AD1E0")]
	private void NBJCGENJGBF(LOHNIHEMMIG NJLMIMMKHOC, TVal LNHLJHKJGFH, int EPOAMOEJPAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class LOFDAGFECGJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> LPDILHBGHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> FOJHKDGAOEE;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x198D670", Offset = "0x198C670", VA = "0x18198D670", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x26C9220", Offset = "0x26C8220", VA = "0x1826C9220", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x307DBA0", Offset = "0x307CBA0", VA = "0x18307DBA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2946C30", Offset = "0x2945C30", VA = "0x182946C30", Slot = "11")]
	public void Add(T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x307D460", Offset = "0x307C460", VA = "0x18307D460")]
	public bool LHAEMCGIOMO(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x307D980", Offset = "0x307C980", VA = "0x18307D980", Slot = "15")]
	public bool Remove(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x28CE650", Offset = "0x28CD650", VA = "0x1828CE650", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x25ABC00", Offset = "0x25AAC00", VA = "0x1825ABC00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x307D240", Offset = "0x307C240", VA = "0x18307D240", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x30028C0", Offset = "0x30018C0", VA = "0x1830028C0", Slot = "13")]
	public bool Contains(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x307D2A0", Offset = "0x307C2A0", VA = "0x18307D2A0", Slot = "14")]
	public void CopyTo(T[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2772720", Offset = "0x2771720", VA = "0x182772720", Slot = "6")]
	public int IndexOf(T GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x307D2D0", Offset = "0x307C2D0", VA = "0x18307D2D0", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x307D750", Offset = "0x307C750", VA = "0x18307D750", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x307D680", Offset = "0x307C680", VA = "0x18307D680")]
	public void PLJGJCHOOLO(Predicate<T> ADBPGLEFIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x307D210", Offset = "0x307C210", VA = "0x18307D210")]
	public void CLOFDOFJEEC(Comparison<T> JDKEEHIDKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x307DA00", Offset = "0x307CA00", VA = "0x18307DA00")]
	public LOFDAGFECGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DOHOJBEKMME
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D65D60", Offset = "0x5D64D60", VA = "0x185D65D60")]
	public static Vector3 ELCAFCGEPFL(this GameObject BFJMKCMPBKG, float JJHKDMNGMBB)
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
			[Cpp2IlInjected.Address(RVA = "0x2F9BEA0", Offset = "0x2F9AEA0", VA = "0x182F9BEA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C280", Offset = "0x5D6B280", VA = "0x185D6C280")]
		public SerializedGuid(in Guid AJPBBJHOAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C080", Offset = "0x5D6B080", VA = "0x185D6C080")]
		public static SerializedGuid FLDLPLFNNMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C120", Offset = "0x5D6B120", VA = "0x185D6C120")]
		public static SerializedGuid OEHONHADFCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BE60", Offset = "0x5D6AE60", VA = "0x185D6BE60")]
		public bool EFLLLAPDHEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C250", Offset = "0x5D6B250", VA = "0x185D6C250", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C1B0", Offset = "0x5D6B1B0", VA = "0x185D6C1B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BDA0", Offset = "0x5D6ADA0", VA = "0x185D6BDA0")]
		public bool CHHJCFLIPIC(in Guid AJPBBJHOAOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BEF0", Offset = "0x5D6AEF0", VA = "0x185D6BEF0", Slot = "7")]
		public bool Equals(SerializedGuid HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BFA0", Offset = "0x5D6AFA0", VA = "0x185D6BFA0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C110", Offset = "0x5D6B110", VA = "0x185D6C110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BE30", Offset = "0x5D6AE30", VA = "0x185D6BE30", Slot = "6")]
		public int CompareTo(SerializedGuid HNOJKNGFFBE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AAOLBCDGNHK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type DJCNMDPDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string JGOBLMIOMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool APGEFJPOLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool GHFDBCMAFOA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D62FE0", Offset = "0x5D61FE0", VA = "0x185D62FE0")]
	public AAOLBCDGNHK(Type ICHCDGFAFMA, string HCNFPHKIIJH, bool LPNDFHNCPIB = false, bool CHEHHFOPIMA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GGKDNJONGAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface NEKADIDIOHG<T> : GGKDNJONGAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool MALHPKIFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string NJKGPGIFKGO
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
	global::NEKADIDIOHG<T> JBPBOAEOEMF(Action<T> HIHPGOGCEJL);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NEKADIDIOHG<T> APDPJHBKMKP(Action<T> HIHPGOGCEJL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::NEKADIDIOHG<T> DENKJFAEPEK(Action<T, T> IHKABJJNGEE);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::NEKADIDIOHG<T> IKOPNAELIMN(Action<T, T> IHKABJJNGEE);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::NEKADIDIOHG<T> GDMPJHEDNBP(Action<string> BNGCFDGNMDH);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NEKADIDIOHG<T> DGIDOPJGBJE(Action<string> BNGCFDGNMDH);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OOEBJBEKEBF<T> : global::NEKADIDIOHG<T>, GGKDNJONGAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::LLCCCNFJKCL<T, T> AEPJFCKEHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DGLAMKJBKDM<T> ADAEIGHIDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DGLAMKJBKDM<string> OKNKNACBOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string EGNBEILEKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BBLJKOEKFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool DLJPMLMHNBJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x26266A0", Offset = "0x26256A0", VA = "0x1826266A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MALHPKIFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x722540", Offset = "0x721540", VA = "0x180722540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NJKGPGIFKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1081A90", Offset = "0x1080A90", VA = "0x181081A90", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF920", Offset = "0x2FDE920", VA = "0x182FDF920")]
	private void OOGPKFNOLPA(T DEHKKADBBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF530", Offset = "0x2FDE530", VA = "0x182FDF530")]
	private void AIEKGKBOABF(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF6F0", Offset = "0x2FDE6F0", VA = "0x182FDF6F0")]
	public void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF630", Offset = "0x2FDE630", VA = "0x182FDF630", Slot = "6")]
	public global::NEKADIDIOHG<T> DENKJFAEPEK(Action<T, T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF840", Offset = "0x2FDE840", VA = "0x182FDF840", Slot = "7")]
	public global::NEKADIDIOHG<T> IKOPNAELIMN(Action<T, T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF890", Offset = "0x2FDE890", VA = "0x182FDF890", Slot = "4")]
	public global::NEKADIDIOHG<T> JBPBOAEOEMF(Action<T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF5E0", Offset = "0x2FDE5E0", VA = "0x182FDF5E0", Slot = "5")]
	public global::NEKADIDIOHG<T> APDPJHBKMKP(Action<T> HIHPGOGCEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF7A0", Offset = "0x2FDE7A0", VA = "0x182FDF7A0", Slot = "8")]
	public global::NEKADIDIOHG<T> GDMPJHEDNBP(Action<string> BNGCFDGNMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF680", Offset = "0x2FDE680", VA = "0x182FDF680", Slot = "9")]
	public global::NEKADIDIOHG<T> DGIDOPJGBJE(Action<string> BNGCFDGNMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF9C0", Offset = "0x2FDE9C0", VA = "0x182FDF9C0")]
	public OOEBJBEKEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class PKHJJPNIHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CKJNKICDCCO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::NEKADIDIOHG<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::BCJEBPCHCFD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public CKJNKICDCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x27D79C0", Offset = "0x27D69C0", VA = "0x1827D79C0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x327A040", Offset = "0x3279040", VA = "0x18327A040")]
	public static global::DGCAEBAFOOK<T> FMDMOKNGPIL<T>(this global::NEKADIDIOHG<T> EOLICAHLJJG, Action<T> GKAOJENLDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EHGJMLLEIHA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct LFINMJIEICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long AGIHFJLDMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long PBJEENCKMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int CJNKPBOCJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int KAILDPGMOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool BMAOLOJDNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string AJPJIDCOHMD;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9EB0", Offset = "0x2FF8EB0", VA = "0x182FF9EB0")]
		public LFINMJIEICI(long AGIHFJLDMFB, int CJNKPBOCJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9F20", Offset = "0x2FF8F20", VA = "0x182FF9F20")]
		public LFINMJIEICI(long AGIHFJLDMFB, long PBJEENCKMAH, int CJNKPBOCJNJ, int KAILDPGMOAM, bool BMAOLOJDNEG, string AJPJIDCOHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9D20", Offset = "0x2FF8D20", VA = "0x182FF9D20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void EDOKCIEOOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9CD0", Offset = "0x2FF8CD0", VA = "0x182FF9CD0")]
		public int BPCLJBHHMED()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9E90", Offset = "0x2FF8E90", VA = "0x182FF9E90")]
		public int PFOGOHBEGDD(int OOHJFEOAEOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9D90", Offset = "0x2FF8D90", VA = "0x182FF9D90")]
		public double INNDPLNJJCH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9E00", Offset = "0x2FF8E00", VA = "0x182FF9E00")]
		public LFINMJIEICI IOELEPDGGOO(long PBJEENCKMAH, int KAILDPGMOAM)
		{
			return default(LFINMJIEICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class GEKJCIHAMFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey HJHOJEFKDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::EHGJMLLEIHA<TKey> APDIGEDLLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<GEKJCIHAMFL> AMLJFCALPFI;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string HIHDLOMCAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x198F730", Offset = "0x198E730", VA = "0x18198F730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x24DFE50", Offset = "0x24DEE50", VA = "0x1824DFE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<GEKJCIHAMFL> NEAKJMIFMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x24DFF90", Offset = "0x24DEF90", VA = "0x1824DFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LFINMJIEICI CNMCDLACFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x16B4290", Offset = "0x16B3290", VA = "0x1816B4290")]
			[CompilerGenerated]
			get
			{
				return default(LFINMJIEICI);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x24DFFB0", Offset = "0x24DEFB0", VA = "0x1824DFFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x24DFFE0", Offset = "0x24DEFE0", VA = "0x1824DFFE0")]
		internal GEKJCIHAMFL(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, TKey CCJNKBLKLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x24DFE80", Offset = "0x24DEE80", VA = "0x1824DFE80")]
		public GEKJCIHAMFL NHEGBMPLEGG(TKey CCJNKBLKLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x24DFBC0", Offset = "0x24DEBC0", VA = "0x1824DFBC0")]
		public void BAJMMIABKCA(TKey CCJNKBLKLDJ, Action<GEKJCIHAMFL> CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x29BA110", Offset = "0x29B9110", VA = "0x1829BA110")]
		public T BAJMMIABKCA<T>(TKey CCJNKBLKLDJ, Func<GEKJCIHAMFL, T> LKLJLJNAKDG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x29BA200", Offset = "0x29B9200", VA = "0x1829BA200")]
		[AsyncStateMachine(typeof(EJENFOAEIOD))]
		public Task<T> NOOHLLGCOBD<T>(TKey CCJNKBLKLDJ, Func<GEKJCIHAMFL, Task<T>> LKLJLJNAKDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x24DFCA0", Offset = "0x24DECA0", VA = "0x1824DFCA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DLLOOAPEIBA : IEnumerable<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, LFINMJIEICI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::EHGJMLLEIHA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, LFINMJIEICI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, LFINMJIEICI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2D94FA0", Offset = "0x2D93FA0", VA = "0x182D94FA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LFINMJIEICI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4676400", Offset = "0x4675400", VA = "0x184676400", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2D95330", Offset = "0x2D94330", VA = "0x182D95330")]
		[DebuggerHidden]
		public DLLOOAPEIBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x19849B0", Offset = "0x19839B0", VA = "0x1819849B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4675F80", Offset = "0x4674F80", VA = "0x184675F80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4676460", Offset = "0x4675460", VA = "0x184676460")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x46763C0", Offset = "0x46753C0", VA = "0x1846763C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4676300", Offset = "0x4675300", VA = "0x184676300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LFINMJIEICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x204ABE0", Offset = "0x2049BE0", VA = "0x18204ABE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LOFFOJBNFOB : IEnumerable<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, LFINMJIEICI timerEntry) <>2__current;

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
		private GEKJCIHAMFL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GEKJCIHAMFL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::EHGJMLLEIHA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<GEKJCIHAMFL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, LFINMJIEICI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, LFINMJIEICI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2D94FA0", Offset = "0x2D93FA0", VA = "0x182D94FA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LFINMJIEICI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x307E350", Offset = "0x307D350", VA = "0x18307E350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2D95330", Offset = "0x2D94330", VA = "0x182D95330")]
		[DebuggerHidden]
		public LOFFOJBNFOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x307E3B0", Offset = "0x307D3B0", VA = "0x18307E3B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x307DC60", Offset = "0x307CC60", VA = "0x18307DC60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x307E450", Offset = "0x307D450", VA = "0x18307E450")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x307E4B0", Offset = "0x307D4B0", VA = "0x18307E4B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x307E310", Offset = "0x307D310", VA = "0x18307E310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x307E200", Offset = "0x307D200", VA = "0x18307E200", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LFINMJIEICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x307E2E0", Offset = "0x307D2E0", VA = "0x18307E2E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, LFINMJIEICI> LMGGKKPJMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, LFINMJIEICI> CNJHAMHHDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::EHGJMLLEIHA<TKey>> JILJHJDEKCH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string CGMPNCIHIFE = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly GEKJCIHAMFL IGCFMLEOBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool DGKCCECAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int BMHJFGCKOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch DCONEIAFJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int PLBBBLPILNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string FILMLELMLNC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public GEKJCIHAMFL MJDNIFGIJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string HIHDLOMCAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x6560D0", VA = "0x1806570D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0880", Offset = "0x1C9F880", VA = "0x181CA0880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long FPEHLJJEBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0860", Offset = "0x1C9F860", VA = "0x181CA0860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int KCPCEIPPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1CA08E0", Offset = "0x1C9F8E0", VA = "0x181CA08E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1CA0A90", Offset = "0x1C9FA90", VA = "0x181CA0A90")]
	public EHGJMLLEIHA(TKey LPJIDKAIAHI, [Optional] int? CJNKPBOCJNJ, [Optional][CanBeNull] Stopwatch DCONEIAFJGN, [Optional] Action<TKey, LFINMJIEICI> LMGGKKPJMLE, [Optional] Action<TKey, LFINMJIEICI> CNJHAMHHDFI, [Optional] Action<global::EHGJMLLEIHA<TKey>> JILJHJDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1CA07B0", Offset = "0x1C9F7B0", VA = "0x181CA07B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1CA0A70", Offset = "0x1C9FA70", VA = "0x181CA0A70")]
	public void OMKFLJFBNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CA0840", Offset = "0x1C9F840", VA = "0x181CA0840")]
	public void IOLANELGBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1CA09E0", Offset = "0x1C9F9E0", VA = "0x181CA09E0")]
	[IteratorStateMachine(typeof(global::EHGJMLLEIHA<>.DLLOOAPEIBA))]
	public IEnumerable<(TKey, List<TKey>, LFINMJIEICI)> NBLLALKOPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1CA0910", Offset = "0x1C9F910", VA = "0x181CA0910")]
	[IteratorStateMachine(typeof(global::EHGJMLLEIHA<>.LOFFOJBNFOB))]
	private IEnumerable<(TKey, List<TKey>, LFINMJIEICI)> NBLLALKOPIL(List<TKey> KCGMDGFIHOJ, GEKJCIHAMFL DDOOJJJHNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1CA0730", Offset = "0x1C9F730", VA = "0x181CA0730")]
	private (long, int) CGILPNJCGGN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class ABFNEAPIAFE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	protected ABFNEAPIAFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class LNOFFBLNBIO<TKey> : global::ABFNEAPIAFE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string LPCEAMJLPJC(TKey CCJNKBLKLDJ);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x307ACA0", Offset = "0x3079CA0", VA = "0x18307ACA0")]
	protected string IOOIHINPGPD(double KPHOHPEDFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x307AEF0", Offset = "0x3079EF0", VA = "0x18307AEF0")]
	protected string LDNJOGONJOF(int KMKBHIDEHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x307AC60", Offset = "0x3079C60", VA = "0x18307AC60")]
	private static string EPMCEDIGHMI(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x307AD10", Offset = "0x3079D10", VA = "0x18307AD10", Slot = "4")]
	public override string KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x307ADC0", Offset = "0x3079DC0", VA = "0x18307ADC0")]
	public string KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, [NotNull] LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, [NotNull] LPCEAMJLPJC ADMFMGGDLGH);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5C00", Offset = "0x1CA4C00", VA = "0x181CA5C00")]
	protected LNOFFBLNBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NGLJPEDJLFA<TKey> : global::ABFNEAPIAFE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string ELOIBNJHNEJ(TKey CCJNKBLKLDJ);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int FJJCBOOFHJB = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string EDAHGMBLEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double GDNOCDDMPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool OFABEKEOFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int HFMGMFPCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> PINCNCDBLJN;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFDB0", Offset = "0x2FBEDB0", VA = "0x182FBFDB0")]
	private static string EPMCEDIGHMI(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0670", Offset = "0x2FBF670", VA = "0x182FC0670")]
	public NGLJPEDJLFA(string EDAHGMBLEFA = "F2", double GDNOCDDMPPE = double.MaxValue, bool OFABEKEOFHH = false, int HFMGMFPCCCB = int.MaxValue, [Optional] ISet<string> PINCNCDBLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0330", Offset = "0x2FBF330", VA = "0x182FC0330", Slot = "4")]
	public override Dictionary<string, string> KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2FC03E0", Offset = "0x2FBF3E0", VA = "0x182FC03E0")]
	private bool MHOAAMOADMG(string LIJFPGLLLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFDF0", Offset = "0x2FBEDF0", VA = "0x182FBFDF0")]
	public Dictionary<string, string> KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, ELOIBNJHNEJ ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC04C0", Offset = "0x2FBF4C0", VA = "0x182FC04C0")]
	private string PANHNJGFHJD(StringBuilder LKFKIAFIGCP, List<TKey> MILADPHKBEN, ELOIBNJHNEJ ADMFMGGDLGH, bool EMFHALGFDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFC30", Offset = "0x2FBEC30", VA = "0x182FBFC30")]
	private static void DAAFKIGGHIB(StringBuilder LAFEBKCEJNP, string DKGFIOACDBE, bool DMCPKKLABDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FHMKBMDFHMH<TKey> : global::LNOFFBLNBIO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct NGFHONCDGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public LPCEAMJLPJC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::FHMKBMDFHMH<TKey> JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int FFHGCCFFLKB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] OALKJOLENHJ;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x283F0D0", Offset = "0x283E0D0", VA = "0x18283F0D0")]
	private FHMKBMDFHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x283DFF0", Offset = "0x283CFF0", VA = "0x18283DFF0", Slot = "5")]
	protected override string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x283EEE0", Offset = "0x283DEE0", VA = "0x18283EEE0")]
	[CompilerGenerated]
	internal static string MIEIHKJBLPF(string GPCDLKJMMCL, TKey CCJNKBLKLDJ, ref NGFHONCDGIC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class NMJMLLFNIAO<TKey> : global::LNOFFBLNBIO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CKGHNHCAIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public LPCEAMJLPJC keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public CKGHNHCAIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1984E10", Offset = "0x1983E10", VA = "0x181984E10")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2E75380", Offset = "0x2E74380", VA = "0x182E75380", Slot = "5")]
	protected override string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x28CE820", Offset = "0x28CD820", VA = "0x1828CE820")]
	public NMJMLLFNIAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class LBHPPCDHALB : global::EHGJMLLEIHA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FHMINHEPIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<LBHPPCDHALB> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public FHMINHEPIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5D661A0", Offset = "0x5D651A0", VA = "0x185D661A0")]
		internal void <Wrap>b__0(global::EHGJMLLEIHA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5D685A0", Offset = "0x5D675A0", VA = "0x185D685A0")]
	public LBHPPCDHALB([Optional] string BFFLLNCOKMN, [Optional] int? CJNKPBOCJNJ, [Optional] Stopwatch DCONEIAFJGN, [Optional] Action<string, LFINMJIEICI> LMGGKKPJMLE, [Optional] Action<string, LFINMJIEICI> CNJHAMHHDFI, [Optional] Action<LBHPPCDHALB> JILJHJDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5D684C0", Offset = "0x5D674C0", VA = "0x185D684C0")]
	private static Action<global::EHGJMLLEIHA<string>> BAJMMIABKCA(Action<LBHPPCDHALB> GKAOJENLDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class PCCFJFHBKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class AMGBIBIMKHJ : PCCFJFHBKMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static PCCFJFHBKMO JNHMLOILMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5D636E0", Offset = "0x5D626E0", VA = "0x185D636E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime EJMDHCNLACO
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5D63690", Offset = "0x5D62690", VA = "0x185D63690", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float BFPMBFEGEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5D63680", Offset = "0x5D62680", VA = "0x185D63680", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5D637E0", Offset = "0x5D627E0", VA = "0x185D637E0")]
		public AMGBIBIMKHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static PCCFJFHBKMO ILKCJFJFGGG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static PCCFJFHBKMO FOBBLKPOGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5D696F0", Offset = "0x5D686F0", VA = "0x185D696F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime EJMDHCNLACO
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float BFPMBFEGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	protected PCCFJFHBKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CNPEPHDIAMN : global::KFHMMJCAHMJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5D65B50", Offset = "0x5D64B50", VA = "0x185D65B50")]
	public CNPEPHDIAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class KFHMMJCAHMJ<T> : global::ANFKCNMPPLG<T>, JDBAPGPMFAN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1767530", Offset = "0x1766530", VA = "0x181767530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private NPIGAOPELEF CLHGDAGPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1081900", Offset = "0x1080900", VA = "0x181081900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x32D9E00", Offset = "0x32D8E00", VA = "0x1832D9E00")]
	public KFHMMJCAHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JKMEDAKMFJK : global::NOJAKAOFMOA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5D67430", Offset = "0x5D66430", VA = "0x185D67430")]
	public JKMEDAKMFJK(Exception BKGIODDNKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NOJAKAOFMOA<T> : global::ANFKCNMPPLG<T>, JDBAPGPMFAN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1767530", Offset = "0x1766530", VA = "0x181767530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private NPIGAOPELEF CLHGDAGPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1081900", Offset = "0x1080900", VA = "0x181081900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2E79740", Offset = "0x2E78740", VA = "0x182E79740")]
	public NOJAKAOFMOA(Exception BKGIODDNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface JDBAPGPMFAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	NPIGAOPELEF NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface ANFKCNMPPLG<T> : JDBAPGPMFAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class BEPDLHFOHBM<TTask, T> : global::ANFKCNMPPLG<T>, JDBAPGPMFAN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class BCMLJJAJHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::BEPDLHFOHBM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public BCMLJJAJHDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool KGKJIEADGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> JJCIEPGHDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource GKECGJILIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool DGKCCECAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext JMCKCLJAIOC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private NPIGAOPELEF CLHGDAGPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2454B00", Offset = "0x2453B00", VA = "0x182454B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761B40", VA = "0x180762B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x26C4730", Offset = "0x26C3730", VA = "0x1826C4730")]
	static BEPDLHFOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x26C4BE0", Offset = "0x26C3BE0", VA = "0x1826C4BE0")]
	protected BEPDLHFOHBM(TTask JJCIEPGHDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x26C43E0", Offset = "0x26C33E0", VA = "0x1826C43E0", Slot = "1")]
	~BEPDLHFOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x26C43B0", Offset = "0x26C33B0", VA = "0x1826C43B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x26C4450", Offset = "0x26C3450", VA = "0x1826C4450")]
	private void ICKDJJKFGLI(bool MMOPBOHIFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T LEMMBKMAEIM(TTask GLNFGOOIGIA);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OLFAPFGDFCL();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x26C4360", Offset = "0x26C3360", VA = "0x1826C4360")]
	[CompilerGenerated]
	private void ACIKEIJEINA(object EPHCHIPDIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DJABOFDMEMI
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MGLOKFBMOMI IBPFPEKACBI;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CJPAOFNIIFD : DJABOFDMEMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct GODGJDEFNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float JPAMEHCOEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float FJOJCNFIGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool PPICPACFBLI;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float PANMOHPAPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5D66580", Offset = "0x5D65580", VA = "0x185D66580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5D66710", Offset = "0x5D65710", VA = "0x185D66710")]
		public GODGJDEFNDM(float FOACNEHDHLI, float CBNJCJLIEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5D66590", Offset = "0x5D65590", VA = "0x185D66590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class JDBBCANADNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CJPAOFNIIFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public JDBBCANADNK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int CHMDLBBFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int NODMNKCOLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DJABOFDMEMI[] BGKDNKJEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MGLOKFBMOMI[] NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly GODGJDEFNDM[] FFMPLKKOONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GODGJDEFNDM KMFAKDLAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly OLCAEPENJCG NCPHIEOAAPE;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GODGJDEFNDM AONBCHMIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x21A2D00", Offset = "0x21A1D00", VA = "0x1821A2D00")]
		get
		{
			return default(GODGJDEFNDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5D65300", Offset = "0x5D64300", VA = "0x185D65300", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5D65910", Offset = "0x5D64910", VA = "0x185D65910", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5D65400", Offset = "0x5D64400", VA = "0x185D65400", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5D659D0", Offset = "0x5D649D0", VA = "0x185D659D0")]
	public CJPAOFNIIFD(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5D65320", Offset = "0x5D64320", VA = "0x185D65320")]
	public OLCAEPENJCG JLKHMCPFMIM(GODGJDEFNDM IEJLANBMLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5D654C0", Offset = "0x5D644C0", VA = "0x185D654C0")]
	public void LPDKOIBHNFN(DJABOFDMEMI LNOIHANMLEE, [Optional] GODGJDEFNDM MCJCCAPLEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5D652B0", Offset = "0x5D642B0", VA = "0x185D652B0")]
	internal int FKENAIAHEAH(DJABOFDMEMI HBCDOHJNOJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5D653B0", Offset = "0x5D643B0", VA = "0x185D653B0")]
	internal GODGJDEFNDM JNFBABGBIFI(int AIPHGHFENPJ)
	{
		return default(GODGJDEFNDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5D65120", Offset = "0x5D64120", VA = "0x185D65120", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void MGLOKFBMOMI(float OEFCMOECHGN);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class CBLIAKJDFMN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float GKJAIAGCKLM = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class DMOPFECHMMO
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class IIAPNCMBNCO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly DJABOFDMEMI HBCDOHJNOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly MGLOKFBMOMI GKAOJENLDLL;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5D66CE0", Offset = "0x5D65CE0", VA = "0x185D66CE0")]
		public IIAPNCMBNCO(DJABOFDMEMI HBCDOHJNOJM, MGLOKFBMOMI GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5D66C90", Offset = "0x5D65C90", VA = "0x185D66C90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5D65C20", Offset = "0x5D64C20", VA = "0x185D65C20")]
	internal static bool CALOBKLNFMD(float BMPDKJEHGIN, float BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4969EC0", Offset = "0x4968EC0", VA = "0x184969EC0")]
	internal static float MDOCPMOMFLF(float BMPDKJEHGIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5D65CA0", Offset = "0x5D64CA0", VA = "0x185D65CA0")]
	public static IDisposable GMLLGEOJAAA(this DJABOFDMEMI HBCDOHJNOJM, MGLOKFBMOMI GKAOJENLDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class OLCAEPENJCG : DJABOFDMEMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float OEFCMOECHGN;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x11091D0", Offset = "0x11081D0", VA = "0x1811091D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5D69400", Offset = "0x5D68400", VA = "0x185D69400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5D69560", Offset = "0x5D68560", VA = "0x185D69560", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5D694C0", Offset = "0x5D684C0", VA = "0x185D694C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public OLCAEPENJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class PFDKDLHNGHK
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A310", Offset = "0x5D69310", VA = "0x185D6A310")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this NIPAEPLNJMM PGBLJCOLKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A380", Offset = "0x5D69380", VA = "0x185D6A380")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this NIPAEPLNJMM PGBLJCOLKOA, HashAlgorithmName HKKDBKLHMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A060", Offset = "0x5D69060", VA = "0x185D6A060")]
	public static bool CMCHABMICCB([CanBeNull] this NIPAEPLNJMM PGBLJCOLKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5D69EC0", Offset = "0x5D68EC0", VA = "0x185D69EC0")]
	public static bool CMCHABMICCB([CanBeNull] this NIPAEPLNJMM PGBLJCOLKOA, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A3F0", Offset = "0x5D693F0", VA = "0x185D6A3F0")]
	private static string PALKABLKHAF([CanBeNull] byte[] HFAIGCGNPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A1F0", Offset = "0x5D691F0", VA = "0x185D6A1F0")]
	private static bool DBDKFNPBADC([NotNull] NIPAEPLNJMM PGBLJCOLKOA, [CanBeNull] out byte[] ABIOPBANALL, [CanBeNull] out byte[] DAJKGKGPPDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class GCFNCJLJLGB
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D66270", Offset = "0x5D65270", VA = "0x185D66270")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this JDBJPKOCHPF FIPIBFLOINL, byte[] MBFPOLMHNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D662B0", Offset = "0x5D652B0", VA = "0x185D662B0")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this JDBJPKOCHPF FIPIBFLOINL, HashAlgorithmName HKKDBKLHMJH, byte[] MBFPOLMHNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface JDBJPKOCHPF
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PKCNHEGJGNH);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface NIPAEPLNJMM : JDBJPKOCHPF
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] FIHFHBNGLKI
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
	byte[] CJCKGEJJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object PPGIHCAMMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class BNAPFGBLMCD
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class JCEPHOPMDCA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D67320", Offset = "0x5D66320", VA = "0x185D67320")]
		public JCEPHOPMDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D672C0", Offset = "0x5D662C0", VA = "0x185D672C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte HFFKMHHKNOL = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte PPGIBPNNLIM = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> GPMJNKBDCON;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool MALJBLEFADO;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x27BFBD0", Offset = "0x27BEBD0", VA = "0x1827BFBD0")]
	[Conditional("UNITY_EDITOR")]
	private static void OKMGHCAMKNL<T>(params T[] HIFGENFODLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D63DC0", Offset = "0x5D62DC0", VA = "0x185D63DC0")]
	public static IDisposable EOLGJDIEOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D648C0", Offset = "0x5D638C0", VA = "0x185D648C0")]
	public static void PAMGGGELPJC(this IncrementalHash MPBCJIPHAFL, [CanBeNull] GameObject BFJMKCMPBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x27BFEC0", Offset = "0x27BEEC0", VA = "0x1827BFEC0")]
	public static void PAMGGGELPJC<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] T AFOPPLDIMJL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x27BF450", Offset = "0x27BE450", VA = "0x1827BF450")]
	public static void EHIKJAPAENC<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] T FIPIBFLOINL) where T : JDBJPKOCHPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x27BFF90", Offset = "0x27BEF90", VA = "0x1827BFF90")]
	public static void PAPDJEAIPJK<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] IList<T> PEAHLGOOOIO) where T : JDBJPKOCHPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D63FD0", Offset = "0x5D62FD0", VA = "0x185D63FD0")]
	private static bool IKDGPDPCNPA([CanBeNull] JDBJPKOCHPF FIPIBFLOINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D64130", Offset = "0x5D63130", VA = "0x185D64130")]
	public static void KMJILBGMNLB(this IncrementalHash PKCNHEGJGNH, [CanBeNull] string KFCEHAILNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D64190", Offset = "0x5D63190", VA = "0x185D64190")]
	public static void KOGBMIOOMEH(this IncrementalHash PKCNHEGJGNH, long JKGNEOGOKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D63950", Offset = "0x5D62950", VA = "0x185D63950")]
	public static void AADKNOMNCLL(this IncrementalHash PKCNHEGJGNH, int FGFDCPICAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D64360", Offset = "0x5D63360", VA = "0x185D64360")]
	public static void KPLIDHECCMN(this IncrementalHash PKCNHEGJGNH, short ANFPDIMPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D64590", Offset = "0x5D63590", VA = "0x185D64590")]
	public static void NGAFDEGANNI(this IncrementalHash PKCNHEGJGNH, byte PLMOPNOHALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D63B90", Offset = "0x5D62B90", VA = "0x185D63B90")]
	public static void BNPENPIGGPL(this IncrementalHash PKCNHEGJGNH, bool CNFBDAILKKM, bool LJBGNCAJFOD = false, bool DDLFMMPIEEK = false, bool DHCJADKACEM = false, bool ACLFALACBKN = false, bool HHLHLPJHCBL = false, bool DPDPPGPPGDB = false, bool MGDBGAFAAGI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x27BF4E0", Offset = "0x27BE4E0", VA = "0x1827BF4E0")]
	public static void IGKHICHCGFB<T>(this IncrementalHash PKCNHEGJGNH, T HOBDFMBOEKJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D64530", Offset = "0x5D63530", VA = "0x185D64530")]
	public static void LIDIJHEGIDK(this IncrementalHash PKCNHEGJGNH, float JNBOKKKFNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D640D0", Offset = "0x5D630D0", VA = "0x185D640D0")]
	public static void JLOMIPMOBAN(this IncrementalHash PKCNHEGJGNH, double KLOJPDOOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D63B20", Offset = "0x5D62B20", VA = "0x185D63B20")]
	public static void APGHMLLOEHI(this IncrementalHash PKCNHEGJGNH, ulong LFFHHADNBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D63D60", Offset = "0x5D62D60", VA = "0x185D63D60")]
	public static void CKICEEAPHDE(this IncrementalHash PKCNHEGJGNH, uint GFKEJJLCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D64060", Offset = "0x5D63060", VA = "0x185D64060")]
	public static void JLJGIJFFHPP(this IncrementalHash PKCNHEGJGNH, ushort CCDPLMEOBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D63E60", Offset = "0x5D62E60", VA = "0x185D63E60")]
	public static void HGBLGCDHPJE(this IncrementalHash PKCNHEGJGNH, Vector3 NKACMCKINJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D64700", Offset = "0x5D63700", VA = "0x185D64700")]
	public static void OLJAAGAFNAI(this IncrementalHash PKCNHEGJGNH, Quaternion EKNNFKFHKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LNDPPEMEKCF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type DJCNMDPDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string JGOBLMIOMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool APGEFJPOLLJ;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D686F0", Offset = "0x5D676F0", VA = "0x185D686F0")]
	public LNDPPEMEKCF(Type ICHCDGFAFMA, string HCNFPHKIIJH, bool LPNDFHNCPIB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OLFLOAGCDHH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D69680", Offset = "0x5D68680", VA = "0x185D69680")]
	public OLFLOAGCDHH(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D69600", Offset = "0x5D68600", VA = "0x185D69600")]
	public OLFLOAGCDHH(string GOJKMEMCPDE, Exception CNFPBKCKKEC)
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
			[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x656040", VA = "0x180657040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x66D790", Offset = "0x66C790", VA = "0x18066D790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int HLAPKJLCEDC, int BOGPBFBHDOE]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x37466C0", Offset = "0x37456C0", VA = "0x1837466C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3746760", Offset = "0x3745760", VA = "0x183746760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3746630", Offset = "0x3745630", VA = "0x183746630")]
		public Array2D(uint KLFKELPFFNF, uint AGONAJNGCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x37465B0", Offset = "0x37455B0", VA = "0x1837465B0")]
		public void IIOELKEIHEG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D63840", Offset = "0x5D62840", VA = "0x185D63840")]
		public Array2DVector3(uint KLFKELPFFNF, uint AGONAJNGCCO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class FODBEJIADJN
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int KFMOONGEAEH = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int APMLOGPBPIJ = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class OHAJLNOFLKM<THandle, TValue> : IDisposable where THandle : struct, GPAFGALANDE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> AGFPEFOAJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> IOOGJNDNHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> PFLFMAIAICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> DFNIIHBCCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int EAGBLHMONMP;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2771B30", Offset = "0x2770B30", VA = "0x182771B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x315EAD0", Offset = "0x315DAD0", VA = "0x18315EAD0")]
	public OHAJLNOFLKM(Action<TValue> DFNIIHBCCOD, [Optional] Func<TValue> PFLFMAIAICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x315E4F0", Offset = "0x315D4F0", VA = "0x18315E4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x315E3A0", Offset = "0x315D3A0", VA = "0x18315E3A0")]
	public THandle DAKLFHBAJIH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x315E7D0", Offset = "0x315D7D0", VA = "0x18315E7D0")]
	public THandle HEFJCCLOLGO(TValue IGJPNMBCJPK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x315E240", Offset = "0x315D240", VA = "0x18315E240")]
	public bool AKJLIPOIGHF(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x315E090", Offset = "0x315D090", VA = "0x18315E090")]
	public bool ACKFNLGGLJE(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x315E920", Offset = "0x315D920", VA = "0x18315E920")]
	public bool KNMEGLCAMII(THandle MIGDJNOKMHC, out TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x315E2F0", Offset = "0x315D2F0", VA = "0x18315E2F0")]
	public TValue BOPAOPJOHPG(THandle MIGDJNOKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x315E160", Offset = "0x315D160", VA = "0x18315E160")]
	public bool AEBBOEKMPNE(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x315E210", Offset = "0x315D210", VA = "0x18315E210")]
	private THandle AKEDIKAPJNI(int AIPHGHFENPJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x315E690", Offset = "0x315D690", VA = "0x18315E690")]
	private TValue FMDMOKNGPIL(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x315EA40", Offset = "0x315DA40", VA = "0x18315EA40")]
	private void LLMGNABJPBK(int AIPHGHFENPJ, in THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x315EA90", Offset = "0x315DA90", VA = "0x18315EA90")]
	private void OOGPKFNOLPA(int AIPHGHFENPJ, in TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x315E6C0", Offset = "0x315D6C0", VA = "0x18315E6C0")]
	private THandle GLBGHPMKCDI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x315E440", Offset = "0x315D440", VA = "0x18315E440")]
	private void DLOAHCHNKCJ(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x315E840", Offset = "0x315D840", VA = "0x18315E840")]
	private int INGBECJDIGI(int JKGBPKEJAFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x315EA80", Offset = "0x315DA80", VA = "0x18315EA80")]
	private bool OEJPECIBDFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6BE640", Offset = "0x6BD640", VA = "0x1806BE640")]
	private void HMEPPCBJPKP(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x315E9C0", Offset = "0x315D9C0", VA = "0x18315E9C0")]
	private bool LDAAGBHHMPI(out THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x315E850", Offset = "0x315D850", VA = "0x18315E850")]
	private bool JLNIOIOMGFP(out THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x315E340", Offset = "0x315D340", VA = "0x18315E340")]
	private void COEFPBLADKG(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x315E570", Offset = "0x315D570", VA = "0x18315E570")]
	private void FJEGAPCNKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface GPAFGALANDE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int FOEMNAHJKFC
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
public interface OCGKPONDJPA<T> : GPAFGALANDE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class BPNNCKOADDC
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xD9E150", Offset = "0xD9D150", VA = "0x180D9E150")]
	public static bool KOPGOIJFDNG<T>(this T MIGDJNOKMHC, T HNOJKNGFFBE) where T : struct, GPAFGALANDE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x27C12C0", Offset = "0x27C02C0", VA = "0x1827C12C0")]
	public static bool PPICPACFBLI<T>(this T MIGDJNOKMHC) where T : struct, GPAFGALANDE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D64AC0", Offset = "0x5D63AC0", VA = "0x185D64AC0")]
	public static string JCMOJHJKPIC(this GPAFGALANDE MIGDJNOKMHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KFJBGPOMJGH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum IEPHOGLNELK : byte
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
	private int PKCNHEGJGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool OCOBBJHPBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private IEPHOGLNELK PBHDPEJBGCP;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool GHPFNDBDPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D67C30", Offset = "0x5D66C30", VA = "0x185D67C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NIGLMGEEEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D67690", Offset = "0x5D66690", VA = "0x185D67690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D68490", Offset = "0x5D67490", VA = "0x185D68490")]
	public KFJBGPOMJGH(bool OCOBBJHPBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D67CE0", Offset = "0x5D66CE0", VA = "0x185D67CE0")]
	public void OAIILMFFBEL(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D67B90", Offset = "0x5D66B90", VA = "0x185D67B90")]
	public void JOEJBFPKOLJ(int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D67680", Offset = "0x5D66680", VA = "0x185D67680")]
	public void BLAMKCFOGNJ(uint NCCNCJLDCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D67CC0", Offset = "0x5D66CC0", VA = "0x185D67CC0")]
	public void NLOPPDKPKOK(bool BIHHMPJOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D67C40", Offset = "0x5D66C40", VA = "0x185D67C40")]
	public void LNPDJAMFDLL(long MOELJPNIGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D67C80", Offset = "0x5D66C80", VA = "0x185D67C80")]
	public void MIIINPIAEFK(ulong KPLEFKIAFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D67610", Offset = "0x5D66610", VA = "0x185D67610")]
	public void ANNLPGCBPFJ(string JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D676A0", Offset = "0x5D666A0", VA = "0x185D676A0")]
	public void CKBKGKCLOOB(Enum BKGIODDNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D68360", Offset = "0x5D67360", VA = "0x185D68360")]
	public void PBCCLDBBLPO(IList LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2729D30", Offset = "0x2728D30", VA = "0x182729D30")]
	public void CGLFAJBMBNM<T, U>(Dictionary<T, U> IBHEDDBCHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D67820", Offset = "0x5D66820", VA = "0x185D67820")]
	private void IJHEMNCPIDE(IDictionary IBHEDDBCHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D67730", Offset = "0x5D66730", VA = "0x185D67730")]
	public int DBNECDHGCNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D677A0", Offset = "0x5D667A0", VA = "0x185D677A0")]
	public short GGPFADGJLCK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5D67810", Offset = "0x5D66810", VA = "0x185D67810")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D675A0", Offset = "0x5D665A0", VA = "0x185D675A0")]
	private void ACBFDNGKDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class ICFLMNMBPDL<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class DMLALCOCLHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode CFFPEBFKEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode ADECAOLBLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public OHNENLDBNBJ CJJNIEGEMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<OHNENLDBNBJ> KJJCDPLKCDG;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public DMLALCOCLHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct OHNENLDBNBJ : IComparable<OHNENLDBNBJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int HKOHGCMCHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant EPPHKPPJDLJ;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6820B0", Offset = "0x6810B0", VA = "0x1806820B0")]
		public OHNENLDBNBJ(int HKOHGCMCHKO, TClaimant EPPHKPPJDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x31E3650", Offset = "0x31E2650", VA = "0x1831E3650")]
		public bool KFNCPIDDDPI(in OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x31E3640", Offset = "0x31E2640", VA = "0x1831E3640")]
		public bool FELEKGPHEFH(in OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x31E3630", Offset = "0x31E2630", VA = "0x1831E3630", Slot = "4")]
		public int CompareTo(OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x31E36B0", Offset = "0x31E26B0", VA = "0x1831E36B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum HEONEGFGDFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ENJGCONDEEE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::ICFLMNMBPDL<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1984A60", Offset = "0x1983A60", VA = "0x181984A60")]
		[DebuggerHidden]
		public ENJGCONDEEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB38B0", Offset = "0x1CB28B0", VA = "0x181CB38B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3A70", Offset = "0x1CB2A70", VA = "0x181CB3A70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3990", Offset = "0x1CB2990", VA = "0x181CB3990", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x107FE00", Offset = "0x107EE00", VA = "0x18107FE00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::ALEKOGIBJDP<DMLALCOCLHK> MIIKKOEMAJL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::ALEKOGIBJDP<List<OHNENLDBNBJ>> KOPOIIDDIPE;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int LEEIGIEEJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> GDDIBJAKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, DMLALCOCLHK> GKEJEKPCBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private HEONEGFGDFK CIJCIMPGNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AILCCJELIAN(TNode MKLEFAMNJAC);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MNMOGPHEODB(TNode MKLEFAMNJAC, TClaimant JPGAPFKAPHL, TClaimant BFOPNPBLNGF);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1984420", Offset = "0x1983420", VA = "0x181984420")]
	public ICFLMNMBPDL(HEONEGFGDFK CIJCIMPGNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1983BA0", Offset = "0x1982BA0", VA = "0x181983BA0")]
	public void JDANKEGANBP(TNode MKLEFAMNJAC, TNode JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1984120", Offset = "0x1983120", VA = "0x181984120")]
	public void MNDDIEIPBHB(TClaimant EPPHKPPJDLJ, TNode ECHEODLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x19830E0", Offset = "0x19820E0", VA = "0x1819830E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1984220", Offset = "0x1983220", VA = "0x181984220")]
	private void NCMMPGCMBFM(TClaimant EPPHKPPJDLJ, TNode FDJMINNOJFC, TNode ECHEODLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982700", VA = "0x181983700")]
	private int FDKAHEPLLGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1983450", Offset = "0x1982450", VA = "0x181983450")]
	private void EOLMEFKPPCK(TClaimant EPPHKPPJDLJ, TNode LMOILGHACLK, TNode FMEILHGLAMN, int NEMILMGLEJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1983050", Offset = "0x1982050", VA = "0x181983050")]
	private void BOOJKOFJPDI(OHNENLDBNBJ MMEBOPCCHDA, DMLALCOCLHK MLIJNOGINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1983940", Offset = "0x1982940", VA = "0x181983940")]
	private void IKMPBHGIJHN(TClaimant EPPHKPPJDLJ, TNode LMOILGHACLK, TNode FMEILHGLAMN, int NEMILMGLEJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1983830", Offset = "0x1982830", VA = "0x181983830")]
	private void FJGNMDABFEE(OHNENLDBNBJ MMEBOPCCHDA, TNode MKLEFAMNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1982E90", Offset = "0x1981E90", VA = "0x181982E90")]
	private void AKLKNEDNFFH(OHNENLDBNBJ MMEBOPCCHDA, DMLALCOCLHK MLIJNOGINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1983340", Offset = "0x1982340", VA = "0x181983340")]
	private void EEJOGEKIEBF(DMLALCOCLHK MLIJNOGINAM, bool HKLGLCKOJDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1983C20", Offset = "0x1982C20", VA = "0x181983C20")]
	private void LONBOHKOAAL(DMLALCOCLHK MLIJNOGINAM, TNode JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1983760", Offset = "0x1982760", VA = "0x181983760")]
	[IteratorStateMachine(typeof(global::ICFLMNMBPDL<, >.ENJGCONDEEE))]
	private IEnumerable<TNode> FGINIIAEMEC(TNode LMOILGHACLK, TNode FMEILHGLAMN, bool KJIBNILOJHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1982F90", Offset = "0x1981F90", VA = "0x181982F90")]
	private DMLALCOCLHK ANAILDODKJN(TNode MKLEFAMNJAC, TNode ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1983F90", Offset = "0x1982F90", VA = "0x181983F90")]
	private DMLALCOCLHK MHNONCHFHNM(TNode MKLEFAMNJAC, TNode ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1982CD0", Offset = "0x1981CD0", VA = "0x181982CD0")]
	private void AIPIMJNNDKP(DMLALCOCLHK MLIJNOGINAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class IGFGNFBNCFM<T> : IEnumerable<global::IGFGNFBNCFM<T>.BFKLEOLBFKE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct BFKLEOLBFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T IGJPNMBCJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int AIPHGHFENPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class JLCBBEPDNNN : IEnumerator<BFKLEOLBFKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::IGFGNFBNCFM<T> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int AIPHGHFENPJ;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x1074130", Offset = "0x1073130", VA = "0x181074130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public BFKLEOLBFKE MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x2F5F540", Offset = "0x2F5E540", VA = "0x182F5F540", Slot = "4")]
			get
			{
				return default(BFKLEOLBFKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x65B060", Offset = "0x65A060", VA = "0x18065B060")]
		public JLCBBEPDNNN(global::IGFGNFBNCFM<T> AHGHAANFJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2F5F440", Offset = "0x2F5E440", VA = "0x182F5F440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x65B050", Offset = "0x65A050", VA = "0x18065B050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x898660", Offset = "0x897660", VA = "0x180898660", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct MAOBPJLOEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool BOJKHDGCBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T IGJPNMBCJPK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int FHOJOKOHPNF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> EFPAABHLGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private MAOBPJLOEAF[] DIFOGFHCHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int BPKLOPHLCGD;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int OAGFNIPJHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x677D90", Offset = "0x676D90", VA = "0x180677D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x844950", Offset = "0x843950", VA = "0x180844950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x198D670", Offset = "0x198C670", VA = "0x18198D670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x198E880", Offset = "0x198D880", VA = "0x18198E880")]
	public IGFGNFBNCFM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x198E960", Offset = "0x198D960", VA = "0x18198E960")]
	public IGFGNFBNCFM(BFKLEOLBFKE[] NGBKPJMNOJL, bool CJEDMAAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x198D200", Offset = "0x198C200", VA = "0x18198D200")]
	public int EFDGKMDLMNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x198E200", Offset = "0x198D200", VA = "0x18198E200")]
	private int OMOBMOMCFJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x198D270", Offset = "0x198C270", VA = "0x18198D270", Slot = "6")]
	protected virtual uint FAFAEFMGNCB(uint PKCNHEGJGNH, T IGJPNMBCJPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x198D580", Offset = "0x198C580", VA = "0x18198D580")]
	public bool GFFDKFLDOGB(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x198D160", Offset = "0x198C160", VA = "0x18198D160")]
	public bool DNJJODPKEOD(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x198D370", Offset = "0x198C370", VA = "0x18198D370")]
	public bool FKLGFCOHCLF(Func<T, bool> EHDENJOEBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x198D610", Offset = "0x198C610", VA = "0x18198D610")]
	public int GGKMBKAEBGM(T IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x198D440", Offset = "0x198C440", VA = "0x18198D440")]
	public T FMDMOKNGPIL(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x198D6A0", Offset = "0x198C6A0", VA = "0x18198D6A0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x198DDD0", Offset = "0x198CDD0", VA = "0x18198DDD0")]
	public bool LHAEMCGIOMO(T IGJPNMBCJPK, bool DBMEGJOBOOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x198D9D0", Offset = "0x198C9D0", VA = "0x18198D9D0")]
	public bool LHAEMCGIOMO(T IGJPNMBCJPK, int AIPHGHFENPJ, bool DBMEGJOBOOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x198CFB0", Offset = "0x198BFB0", VA = "0x18198CFB0")]
	public bool AKJLIPOIGHF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x198D500", Offset = "0x198C500", VA = "0x18198D500")]
	public bool GEPHADMCPNH(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x198DE40", Offset = "0x198CE40", VA = "0x18198DE40")]
	private void OMFGKOPAABL(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x198D890", Offset = "0x198C890", VA = "0x18198D890")]
	public BFKLEOLBFKE[] JEAKIKGHNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x198D110", Offset = "0x198C110", VA = "0x18198D110")]
	private int CDHMBNHDIMD(int HMJFOJBNOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x198E400", Offset = "0x198D400", VA = "0x18198E400", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x198E400", Offset = "0x198D400", VA = "0x18198E400", Slot = "4")]
	private IEnumerator<BFKLEOLBFKE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct JLCPNFGEOBK<Handle> where Handle : GPAFGALANDE, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct PJBKNJHEFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly global::JLCPNFGEOBK<Handle> PIDJNOBOEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int AIPHGHFENPJ;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int ILKNCHFMPMB
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x3343800", Offset = "0x3342800", VA = "0x183343800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle NHEHBINCOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3342D60", Offset = "0x3341D60", VA = "0x183342D60")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3343B80", Offset = "0x3342B80", VA = "0x183343B80")]
		public PJBKNJHEFBK(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3343AE0", Offset = "0x3342AE0", VA = "0x183343AE0")]
		public DNJLGGCBKBG MIHDEIPKAKJ(in DNJLGGCBKBG KIHDPCDCOMG)
		{
			return default(DNJLGGCBKBG);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3343A40", Offset = "0x3342A40", VA = "0x183343A40")]
		public HHMLOMLKNND MIHDEIPKAKJ(in HHMLOMLKNND KIHDPCDCOMG)
		{
			return default(HHMLOMLKNND);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x3343180", Offset = "0x3342180", VA = "0x183343180")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x3343130", Offset = "0x3342130", VA = "0x183343130")]
		private int EHIEMAAGKII(string GOJKMEMCPDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3343950", Offset = "0x3342950", VA = "0x183343950")]
		private Handle LBMNDCFMPDC(string GOJKMEMCPDE)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct DNJLGGCBKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private PJBKNJHEFBK OMLHACIHODI;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x3766590", Offset = "0x3765590", VA = "0x183766590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEE70", Offset = "0x2AFDE70", VA = "0x182AFEE70")]
		public DNJLGGCBKBG(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2AFECF0", Offset = "0x2AFDCF0", VA = "0x182AFECF0")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x3766490", Offset = "0x3765490", VA = "0x183766490")]
		public DNJLGGCBKBG BALJJOIEHDJ()
		{
			return default(DNJLGGCBKBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct HHMLOMLKNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private PJBKNJHEFBK OMLHACIHODI;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEDF0", Offset = "0x2AFDDF0", VA = "0x182AFEDF0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEE70", Offset = "0x2AFDE70", VA = "0x182AFEE70")]
		public HHMLOMLKNND(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2AFECF0", Offset = "0x2AFDCF0", VA = "0x182AFECF0")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEBF0", Offset = "0x2AFDBF0", VA = "0x182AFEBF0")]
		public HHMLOMLKNND BALJJOIEHDJ()
		{
			return default(HHMLOMLKNND);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> JPMLELKNNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> JGBKDBDBLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int CJKIABHOBKO;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2F630D0", Offset = "0x2F620D0", VA = "0x182F630D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2F62B10", Offset = "0x2F61B10", VA = "0x182F62B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int POBHNCDBPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x656010", VA = "0x180657010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ACKACKBIKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x656010", VA = "0x180657010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public DNJLGGCBKBG CAKCMHFHGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2F618B0", Offset = "0x2F608B0", VA = "0x182F618B0")]
		get
		{
			return default(DNJLGGCBKBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HHMLOMLKNND KJHLMJNOKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2F5F700", Offset = "0x2F5E700", VA = "0x182F5F700")]
		get
		{
			return default(HHMLOMLKNND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2F63A70", Offset = "0x2F62A70", VA = "0x182F63A70")]
	public JLCPNFGEOBK(int BOCABLLJGMP, Allocator JEOILJEOOOI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2F613C0", Offset = "0x2F603C0", VA = "0x182F613C0")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xFED6A0", Offset = "0xFEC6A0", VA = "0x180FED6A0")]
	public static int INGBECJDIGI(int HFMHCLGICNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F7A0", Offset = "0x2F5E7A0", VA = "0x182F5F7A0")]
	public static bool BAOIFAGJEEM(int HFMHCLGICNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2F60620", Offset = "0x2F5F620", VA = "0x182F60620")]
	public static bool FBMPFDIMJCM(int HFMHCLGICNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2F62C10", Offset = "0x2F61C10", VA = "0x182F62C10")]
	public bool LLJLJAOOPBD(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2F638C0", Offset = "0x2F628C0", VA = "0x182F638C0")]
	public bool PJJDNLFCCFI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2F62890", Offset = "0x2F61890", VA = "0x182F62890")]
	public bool KDAIOGGPNLA(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2F62070", Offset = "0x2F61070", VA = "0x182F62070")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JPLJFJIJDLO(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2F634E0", Offset = "0x2F624E0", VA = "0x182F634E0")]
	public Handle PJAPBNCMBEB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2F60C10", Offset = "0x2F5FC10", VA = "0x182F60C10")]
	public void FJFBBHGFOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2F61250", Offset = "0x2F60250", VA = "0x182F61250")]
	public void IALCHHDMNFP(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2F61630", Offset = "0x2F60630", VA = "0x182F61630")]
	public bool IHGIDBJFPED(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2F631B0", Offset = "0x2F621B0", VA = "0x182F631B0")]
	private bool PCOOKELLJJG(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2F604B0", Offset = "0x2F5F4B0", VA = "0x182F604B0")]
	private void EJMEKAMIFIO(out int AIPHGHFENPJ, out int JKGBPKEJAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2F5FCD0", Offset = "0x2F5ECD0", VA = "0x182F5FCD0")]
	private void DLGFPDHJMBK(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2F61A40", Offset = "0x2F60A40", VA = "0x182F61A40")]
	private void INHEPIOCHAN(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F910", Offset = "0x2F5E910", VA = "0x182F5F910")]
	private bool CLLDIKMGNKF(out int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2F5FED0", Offset = "0x2F5EED0", VA = "0x182F5FED0")]
	private static Handle EDLKFIKCDPF(int AIPHGHFENPJ, int JKGBPKEJAFA)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct OPFKIBDDGAC<Handle, T> where Handle : GPAFGALANDE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private global::JLCPNFGEOBK<Handle> DPMAKEKJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private T[] GGGFJPKOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Action<T> EGMBCEFPMPF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5970", Offset = "0x2FE4970", VA = "0x182FE5970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2FE57F0", Offset = "0x2FE47F0", VA = "0x182FE57F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2FE47A0", Offset = "0x2FE37A0", VA = "0x182FE47A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2FE54A0", Offset = "0x2FE44A0", VA = "0x182FE54A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE66D0", Offset = "0x2FE56D0", VA = "0x182FE66D0")]
	public OPFKIBDDGAC(int BOCABLLJGMP, [Optional] Action<T> EGMBCEFPMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE47D0", Offset = "0x2FE37D0", VA = "0x182FE47D0")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2FE52D0", Offset = "0x2FE42D0", VA = "0x182FE52D0")]
	public bool KDAIOGGPNLA(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JPLJFJIJDLO(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4250", Offset = "0x2FE3250", VA = "0x182FE4250")]
	public T BOPAOPJOHPG(Handle MIGDJNOKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5740", Offset = "0x2FE4740", VA = "0x182FE5740")]
	public bool KNMEGLCAMII(Handle MIGDJNOKMHC, out T CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5D30", Offset = "0x2FE4D30", VA = "0x182FE5D30")]
	public void PIGMJENILDA(Handle MIGDJNOKMHC, T KMCKONMJFFK, out T NALMGNHPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2FE59F0", Offset = "0x2FE49F0", VA = "0x182FE59F0")]
	public void PIGMJENILDA(Handle MIGDJNOKMHC, T KMCKONMJFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2FE50F0", Offset = "0x2FE40F0", VA = "0x182FE50F0")]
	public bool JKMDIHKOIGC(Handle MIGDJNOKMHC, T KMCKONMJFFK, out T NALMGNHPGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4C40", Offset = "0x2FE3C40", VA = "0x182FE4C40")]
	public bool JKMDIHKOIGC(Handle MIGDJNOKMHC, T KMCKONMJFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4370", Offset = "0x2FE3370", VA = "0x182FE4370")]
	public Handle HEFJCCLOLGO(T CCPIHKCBGHF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5DD0", Offset = "0x2FE4DD0", VA = "0x182FE5DD0")]
	public void PLJGJCHOOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE35F0", Offset = "0x2FE25F0", VA = "0x182FE35F0")]
	public void AKJLIPOIGHF(Handle MIGDJNOKMHC, out T NALMGNHPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3860", Offset = "0x2FE2860", VA = "0x182FE3860")]
	public void AKJLIPOIGHF(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3DF0", Offset = "0x2FE2DF0", VA = "0x182FE3DF0")]
	public bool BNPPCNDHKAP(Handle MIGDJNOKMHC, out T NALMGNHPGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4090", Offset = "0x2FE3090", VA = "0x182FE4090")]
	public bool BNPPCNDHKAP(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4310", Offset = "0x2FE3310", VA = "0x182FE4310")]
	private T GEPHADMCPNH(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4A90", Offset = "0x2FE3A90", VA = "0x182FE4A90")]
	private void JHOPBBOOCLA(int DCJPACPBNKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class ALEKOGIBJDP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<T> PIDJNOBOEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<T> AKBEBFKIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly int EPOOANDMMJL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int OHAOGCHFILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x198F730", Offset = "0x198E730", VA = "0x18198F730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int OKMJDACDFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2458C10", Offset = "0x2457C10", VA = "0x182458C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x259D110", Offset = "0x259C110", VA = "0x18259D110")]
	public static global::ALEKOGIBJDP<T> JMMOFKMJOMM(int CHMDLBBFMNF = 0, int EPOOANDMMJL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x259D290", Offset = "0x259C290", VA = "0x18259D290")]
	public static global::ALEKOGIBJDP<T> MKABKNECJPE(int CHMDLBBFMNF = 0, int EPOOANDMMJL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x259D500", Offset = "0x259C500", VA = "0x18259D500")]
	public ALEKOGIBJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x259D540", Offset = "0x259C540", VA = "0x18259D540")]
	public ALEKOGIBJDP(int CHMDLBBFMNF, int EPOOANDMMJL = int.MaxValue, bool DDEEMBNHFIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x259CF60", Offset = "0x259BF60", VA = "0x18259CF60")]
	public T FKJKJFLCNLI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x259D1E0", Offset = "0x259C1E0", VA = "0x18259D1E0")]
	public void LKKBDAMJBBO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x259CDA0", Offset = "0x259BDA0", VA = "0x18259CDA0")]
	private void CHLOBPCCNFE(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x259D0F0", Offset = "0x259C0F0", VA = "0x18259D0F0")]
	private void JHBDGFKGBHD(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x259D070", Offset = "0x259C070", VA = "0x18259D070")]
	[Conditional("DEBUG_BUILD")]
	private void FMKODGJKDKE(T FNOFBOPMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x259CD10", Offset = "0x259BD10", VA = "0x18259CD10")]
	[Conditional("DEBUG_BUILD")]
	private void CGAFMCMLFAN(T FNOFBOPMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x259CE70", Offset = "0x259BE70", VA = "0x18259CE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x259D360", Offset = "0x259C360", VA = "0x18259D360")]
	private void NMCAFHAGLON(IEnumerable<T> IOOGJNDNHCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class LIOMCBDJHJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Dictionary<int, T> FDKFBNKCKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private T OIGMABGECII;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T AKPJHHFDKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x3002D00", Offset = "0x3001D00", VA = "0x183002D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3002A40", Offset = "0x3001A40", VA = "0x183002A40")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3002C40", Offset = "0x3001C40", VA = "0x183002C40")]
	public bool GFIDHGBMMBC(int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3002F40", Offset = "0x3001F40", VA = "0x183002F40")]
	public T PEDKMDPFNBI(int FAJKJFLNAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x3002CA0", Offset = "0x3001CA0", VA = "0x183002CA0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x3002AA0", Offset = "0x3001AA0", VA = "0x183002AA0")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x30029B0", Offset = "0x30019B0", VA = "0x1830029B0")]
	public bool CECEMJJAJEO(int HKOHGCMCHKO, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2771990", Offset = "0x2770990", VA = "0x182771990")]
	public LIOMCBDJHJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class EICBINKJHDH<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct CKKOEBBKAHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T AAFFKFKIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int KBPAGHAOJMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected readonly List<CKKOEBBKAHK> IMPDEOOHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T GMOAMOOADBP;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x198D670", Offset = "0x198C670", VA = "0x18198D670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1410", Offset = "0x1CA0410", VA = "0x181CA1410")]
	public bool FKLGFCOHCLF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1620", Offset = "0x1CA0620", VA = "0x181CA1620")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK, int HKOHGCMCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1130", Offset = "0x1CA0130", VA = "0x181CA1130")]
	public bool AKJLIPOIGHF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1730", Offset = "0x1CA0730", VA = "0x181CA1730")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1790", Offset = "0x1CA0790", VA = "0x181CA1790")]
	public T PCOGBLDCONM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1CA16C0", Offset = "0x1CA06C0", VA = "0x181CA16C0")]
	public T ICCBDBEBDBJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1250", Offset = "0x1CA0250", VA = "0x181CA1250")]
	private void DMCIMOOOJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1800", Offset = "0x1CA0800", VA = "0x181CA1800")]
	public EICBINKJHDH()
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
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[KFIFBFNJECK(GHKBHIFBDKF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x5D6A900", Offset = "0x5D69900", VA = "0x185D6A900")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D6AC90", Offset = "0x5D69C90", VA = "0x185D6AC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D6AB10", Offset = "0x5D69B10", VA = "0x185D6AB10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D6ADF0", Offset = "0x5D69DF0", VA = "0x185D6ADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D6A820", Offset = "0x5D69820", VA = "0x185D6A820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5D6ABB0", Offset = "0x5D69BB0", VA = "0x185D6ABB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5D6AA30", Offset = "0x5D69A30", VA = "0x185D6AA30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D6A7D0", Offset = "0x5D697D0", VA = "0x185D6A7D0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface GHDMBMNLGPL
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : GHDMBMNLGPL where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CC71E0", Offset = "0x2CC61E0", VA = "0x182CC71E0", Slot = "4")]
		public virtual T GCFGDHINFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class OIMDLLNEAFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly Dictionary<byte, PFCMOJKBLHA> HHOIJJIHFIO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PFCMOJKBLHA BJKMKLFFFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x676130", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GAKMPLLBFML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x178ECC0", Offset = "0x178DCC0", VA = "0x18178ECC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0CD0", Offset = "0x69FCD0", VA = "0x1806A0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 IELDGPPLJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x203B500", Offset = "0x203A500", VA = "0x18203B500")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x175A4D0", Offset = "0x17594D0", VA = "0x18175A4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 MGOGNDBCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D688A0", Offset = "0x5D678A0", VA = "0x185D688A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1486E20", Offset = "0x1485E20", VA = "0x181486E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int HLILMKNMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x6570E0", Offset = "0x6560E0", VA = "0x1806570E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BE640", Offset = "0x6BD640", VA = "0x1806BE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D68FA0", Offset = "0x5D67FA0", VA = "0x185D68FA0")]
	public OIMDLLNEAFM(Bounds AMFAFDADKEK, Vector2[] DMPGLONGKPD, int IMAEPENEFAA, byte HMJFOJBNOAJ, float KLOIGECHDKI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D68A20", Offset = "0x5D67A20", VA = "0x185D68A20")]
	public PFCMOJKBLHA EIAHHAHGNPN(byte AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D68E80", Offset = "0x5D67E80", VA = "0x185D68E80")]
	public void FMCBJMBGGEK(Vector3 EIIEKPIPEEF, float AGDGJEDGMPN, float PEBBGPHOPOC, ref List<byte> PAAEMJHEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D68F80", Offset = "0x5D67F80", VA = "0x185D68F80")]
	public void JDMNBCLKEGJ(PFCMOJKBLHA.OCLGPCGPGOI IBAAEKMJMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D688C0", Offset = "0x5D678C0", VA = "0x185D688C0")]
	private PFCMOJKBLHA CMFKGPNDDDO(byte AIPHGHFENPJ, PFCMOJKBLHA.IMAAIIAEMDK DPNHOHGBFCN, PFCMOJKBLHA ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D68A80", Offset = "0x5D67A80", VA = "0x185D68A80")]
	private void FCDAGLFIEOD(PFCMOJKBLHA ADECAOLBLPJ, Vector2[] DMPGLONGKPD, int IHFLEPEELEJ, int JAOKBPPGFGL, int GLNMGEHPEGC, int OMDPLFOMPPI, float KLOIGECHDKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class PFCMOJKBLHA
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum IMAAIIAEMDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum OCLGPCGPGOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public byte MELPOBPKFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Vector3 CLHHDBNOIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 PANMOHPAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 IJGDBADCKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 KFICBHMIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public IMAAIIAEMDK MIJFFBPNKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public PFCMOJKBLHA JPFILNDPPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public List<PFCMOJKBLHA> EGKIDEBBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public bool DPFNFBGGJFO;

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D69EA0", Offset = "0x5D68EA0", VA = "0x185D69EA0")]
	public PFCMOJKBLHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D69E40", Offset = "0x5D68E40", VA = "0x185D69E40")]
	public PFCMOJKBLHA(byte FCDKMJOKGIE, IMAAIIAEMDK DPNHOHGBFCN, PFCMOJKBLHA ADECAOLBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D69D40", Offset = "0x5D68D40", VA = "0x185D69D40")]
	public void NKNHNPFFGPO(PFCMOJKBLHA NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	public void JDMNBCLKEGJ(int NBFDHJCONPH, OCLGPCGPGOI IBAAEKMJMNL, int CKFKONADBAB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D69A90", Offset = "0x5D68A90", VA = "0x185D69A90")]
	public void FMCBJMBGGEK(List<byte> PAAEMJHEMAA, Vector3 EIIEKPIPEEF, float AGDGJEDGMPN, float PEBBGPHOPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D69A40", Offset = "0x5D68A40", VA = "0x185D69A40")]
	public bool AIFMGHHDJML(Vector3 EFCGBFLJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D69E00", Offset = "0x5D68E00", VA = "0x185D69E00")]
	public bool PIAIOJAOAPK(Vector3 EFCGBFLJIDP, float GPJEONMCOLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class MHHFALIGJPC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly Dictionary<T, object> FJDDMGGGPIJ;

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x1984E10", Offset = "0x1983E10", VA = "0x181984E10")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x293E5C0", Offset = "0x293D5C0", VA = "0x18293E5C0")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x293E560", Offset = "0x293D560", VA = "0x18293E560")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x293E3B0", Offset = "0x293D3B0", VA = "0x18293E3B0")]
	public bool BMPCKDFLJDD(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x293E520", Offset = "0x293D520", VA = "0x18293E520")]
	public bool INKHBMEJKFF(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x293E3F0", Offset = "0x293D3F0", VA = "0x18293E3F0")]
	public bool BMPCKDFLJDD(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x293E380", Offset = "0x293D380", VA = "0x18293E380")]
	public void BGFFCKJLFCP(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x293E480", Offset = "0x293D480", VA = "0x18293E480")]
	public void FIKGBJLIHAO(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x293E600", Offset = "0x293D600", VA = "0x18293E600")]
	public MHHFALIGJPC()
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
		public struct BGCANLKPIMO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private readonly List<Component> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly bool DNAIHDDDAFO;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D23F0", Offset = "0x8D13F0", VA = "0x1808D23F0")]
			public BGCANLKPIMO(List<Component> LPDILHBGHIJ, bool DNAIHDDDAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x26C5A60", Offset = "0x26C4A60", VA = "0x1826C5A60")]
			public ALCFPIODMBB<T> BALJJOIEHDJ()
			{
				return default(ALCFPIODMBB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x26C5AD0", Offset = "0x26C4AD0", VA = "0x1826C5AD0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x26C5AD0", Offset = "0x26C4AD0", VA = "0x1826C5AD0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct ALCFPIODMBB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool DNAIHDDDAFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private int AIPHGHFENPJ;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T MFINOJMLAJL
			{
				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x259CB50", Offset = "0x259BB50", VA = "0x18259CB50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x259CAE0", Offset = "0x259BAE0", VA = "0x18259CAE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x259CB20", Offset = "0x259BB20", VA = "0x18259CB20")]
			public ALCFPIODMBB(List<Component> LPDILHBGHIJ, bool DNAIHDDDAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x259CA10", Offset = "0x259BA10", VA = "0x18259CA10", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x259CA20", Offset = "0x259BA20", VA = "0x18259CA20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x259CAD0", Offset = "0x259BAD0", VA = "0x18259CAD0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D6CB40", Offset = "0x5D6BB40", VA = "0x185D6CB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D6CB00", Offset = "0x5D6BB00", VA = "0x185D6CB00")]
		public ToolHierarchyCache(GameObject NLMNGLPMKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C560", Offset = "0x5D6B560", VA = "0x185D6C560")]
		private void ILMEFAAGLOH(GameObject NLMNGLPMKIH, bool EFJKFNKFDIO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C6C0", Offset = "0x5D6B6C0", VA = "0x185D6C6C0")]
		public static void ILMEFAAGLOH(GameObject NLMNGLPMKIH, ref ToolHierarchyCache BGMEKLANEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C4D0", Offset = "0x5D6B4D0", VA = "0x185D6C4D0")]
		public void GDABPBLHHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C2B0", Offset = "0x5D6B2B0", VA = "0x185D6C2B0")]
		public void BODKONPEAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x25EB530", Offset = "0x25EA530", VA = "0x1825EB530")]
		public void OCIPHBIPPGC<T>(Action<T> CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C300", Offset = "0x5D6B300", VA = "0x185D6C300")]
		public Component EAAFOKEDLAE(Type NKICFHCCMMH, bool DNAIHDDDAFO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x25EB3E0", Offset = "0x25EA3E0", VA = "0x1825EB3E0")]
		public T EAAFOKEDLAE<T>(bool DNAIHDDDAFO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C450", Offset = "0x5D6B450", VA = "0x185D6C450")]
		public BGCANLKPIMO<Component> FBDIHCHJNKN(Type NKICFHCCMMH, bool DNAIHDDDAFO = false)
		{
			return default(BGCANLKPIMO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x25EB460", Offset = "0x25EA460", VA = "0x1825EB460")]
		public BGCANLKPIMO<T> FBDIHCHJNKN<T>(bool DNAIHDDDAFO = false) where T : class
		{
			return default(BGCANLKPIMO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C750", Offset = "0x5D6B750", VA = "0x185D6C750")]
		public List<Component> MDKFECCCDEA(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C3D0", Offset = "0x5D6B3D0", VA = "0x185D6C3D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KNMKEOOODCL, ToolHierarchyCache EMKKILCIAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C4E0", Offset = "0x5D6B4E0", VA = "0x185D6C4E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CCPIHKCBGHF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class BIHBJNOIAFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private int CHMDLBBFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int AJDJHPPHOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private List<T> JJDMEICMPFG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x198F730", Offset = "0x198E730", VA = "0x18198F730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T KCJGEAHJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x26C9AC0", Offset = "0x26C8AC0", VA = "0x1826C9AC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DPIAKLCPMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x26C98D0", Offset = "0x26C88D0", VA = "0x1826C98D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T JCBNPIAHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x26C9990", Offset = "0x26C8990", VA = "0x1826C9990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x26C9B50", Offset = "0x26C8B50", VA = "0x1826C9B50")]
	public BIHBJNOIAFJ(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x26C96A0", Offset = "0x26C86A0", VA = "0x1826C96A0")]
	public void HEFJCCLOLGO(T MBKFGPPACCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x26C9850", Offset = "0x26C8850", VA = "0x1826C9850")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x26C9600", Offset = "0x26C8600", VA = "0x1826C9600")]
	public void DGLNJJPOGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x26C9940", Offset = "0x26C8940", VA = "0x1826C9940")]
	public void OLCMHINEDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x26C9930", Offset = "0x26C8930", VA = "0x1826C9930")]
	public void NOELKBPOBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class HFJELPPAOJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool JPOECBAFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private Action CGKOOFFNHKL;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static HFJELPPAOJM NKFJDGLCHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D66870", Offset = "0x5D65870", VA = "0x185D66870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MAFLJCDFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A250", VA = "0x18065B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8272E0", Offset = "0x8262E0", VA = "0x1808272E0")]
	public HFJELPPAOJM(Action CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D66850", Offset = "0x5D65850", VA = "0x185D66850")]
	public void NBKICENBLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D66850", Offset = "0x5D65850", VA = "0x185D66850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class NKDJAOAMIIC
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	public static void OJLLINHKNEF(IJEBMCPBKAP LOAFEMFAKGN, string GPPCNKPNHCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class FCMGPIFHKJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct KMJGBPEBCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int KBPAGHAOJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public T AAFFKFKIJDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<object, KMJGBPEBCIH> FDKFBNKCKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private T OIGMABGECII;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T AKPJHHFDKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEB90", Offset = "0x1CADB90", VA = "0x181CAEB90", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2771920", Offset = "0x2770920", VA = "0x182771920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object JHHBPMBHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x276CCC0", Offset = "0x276BCC0", VA = "0x18276CCC0")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, object MKDOEIGPNGM, int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2771880", Offset = "0x2770880", VA = "0x182771880")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x276C5C0", Offset = "0x276B5C0", VA = "0x18276C5C0")]
	public bool CECEMJJAJEO(object MKDOEIGPNGM, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x27718F0", Offset = "0x27708F0", VA = "0x1827718F0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x276D8D0", Offset = "0x276C8D0", VA = "0x18276D8D0")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2771990", Offset = "0x2770990", VA = "0x182771990")]
	public FCMGPIFHKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class PLPHEAOGHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Dictionary<object, float> FDKFBNKCKDM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float DBBMINEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x11091D0", Offset = "0x11081D0", VA = "0x1811091D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xF3CF50", Offset = "0xF3BF50", VA = "0x180F3CF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A550", Offset = "0x5D69550", VA = "0x185D6A550")]
	public void FEJCNECMMHF(float IGJPNMBCJPK, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A5C0", Offset = "0x5D695C0", VA = "0x185D6A5C0")]
	public void GFIDHGBMMBC(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A630", Offset = "0x5D69630", VA = "0x185D6A630")]
	private void NCKMPFFNPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A750", Offset = "0x5D69750", VA = "0x185D6A750")]
	public PLPHEAOGHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class EABJGGDLAPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly string EPECKNALOMA;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656F40", VA = "0x180657F40")]
	public EABJGGDLAPO(string MKKAPGFCJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5D660E0", Offset = "0x5D650E0", VA = "0x185D660E0")]
	public EABJGGDLAPO(UnityEngine.Object LKHBCBIAPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5D66090", Offset = "0x5D65090", VA = "0x185D66090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class IJEBMCPBKAP
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class BELENFMGBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public BELENFMGBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5D638A0", Offset = "0x5D628A0", VA = "0x185D638A0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private HashSet<object> INFHCIHNBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int BEEGPAHOIGN;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> LKLHAMANGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5D66E20", Offset = "0x5D65E20", VA = "0x185D66E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MGBIGNFKMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5D66D70", Offset = "0x5D65D70", VA = "0x185D66D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5D66F50", Offset = "0x5D65F50", VA = "0x185D66F50")]
	public bool HEFJCCLOLGO(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5D66D80", Offset = "0x5D65D80", VA = "0x185D66D80")]
	public bool AKJLIPOIGHF(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5D66EF0", Offset = "0x5D65EF0", VA = "0x185D66EF0")]
	public bool FKLGFCOHCLF(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5D67040", Offset = "0x5D66040", VA = "0x185D67040")]
	public void IHIGDLFAICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5D670B0", Offset = "0x5D660B0", VA = "0x185D670B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public IJEBMCPBKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class MDKNPIBCCIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct PMDHPEODCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float PDOCOMCOHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public T AAFFKFKIJDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Dictionary<object, PMDHPEODCBA> FDKFBNKCKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private T LBDIMDGAKJF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T PHIKHKEBFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1183480", Offset = "0x1182480", VA = "0x181183480", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x16B42D0", Offset = "0x16B32D0", VA = "0x1816B42D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object BPHBJABLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EEAE0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3021EC0", Offset = "0x3020EC0", VA = "0x183021EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x30204F0", Offset = "0x301F4F0", VA = "0x1830204F0")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3021E60", Offset = "0x3020E60", VA = "0x183021E60")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x27718F0", Offset = "0x27708F0", VA = "0x1827718F0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3020020", Offset = "0x301F020", VA = "0x183020020")]
	public bool CECEMJJAJEO(object MKDOEIGPNGM, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3020800", Offset = "0x301F800", VA = "0x183020800")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3021F00", Offset = "0x3020F00", VA = "0x183021F00")]
	public MDKNPIBCCIL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5D63050", Offset = "0x5D62050", VA = "0x185D63050")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5D63160", Offset = "0x5D62160", VA = "0x185D63160")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
