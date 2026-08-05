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
public class PNPKAGGOGPE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	public PNPKAGGOGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, ENAGGHAOLAL, APFDKEDKPKG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E00", Offset = "0x7E5000", VA = "0x1807E5E00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JBFGBNAHGLM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE21BA0", Offset = "0xE20DA0", VA = "0x180E21BA0")]
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
	[DJGGFMCNHBJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[DJGGFMCNHBJ]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6358EE0", Offset = "0x63580E0", VA = "0x186358EE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6358EA0", Offset = "0x63580A0", VA = "0x186358EA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6358F20", Offset = "0x6358120", VA = "0x186358F20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63590F0", Offset = "0x63582F0", VA = "0x1863590F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6359060", Offset = "0x6358260", VA = "0x186359060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1281E70", Offset = "0x1281070", VA = "0x181281E70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1281E60", Offset = "0x1281060", VA = "0x181281E60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6358E60", Offset = "0x6358060", VA = "0x186358E60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6358FD0", Offset = "0x63581D0", VA = "0x186358FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63588A0", Offset = "0x6357AA0", VA = "0x1863588A0")]
	public void CopyBounds(SavedExtents IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6358DC0", Offset = "0x6357FC0", VA = "0x186358DC0")]
	public void SetLocalSpaceBounds(Bounds MPEANMMCLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x122FE30", Offset = "0x122F030", VA = "0x18122FE30")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6358BC0", Offset = "0x6357DC0", VA = "0x186358BC0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6358BD0", Offset = "0x6357DD0", VA = "0x186358BD0")]
	private void PELJFMGLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6358990", Offset = "0x6357B90", VA = "0x186358990")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6358260", Offset = "0x6357460", VA = "0x186358260")]
	public static void CalculateLocalBoundsFor(GameObject OOKBNBHDPPG, out Bounds MPEANMMCLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63588D0", Offset = "0x6357AD0", VA = "0x1863588D0")]
	private static void DLAOKEDFEAN(Bounds GPHMIGDKMEO, Color ECKJDAFJMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6358DE0", Offset = "0x6357FE0", VA = "0x186358DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E7130", VA = "0x1806E7F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1227440", Offset = "0x1226640", VA = "0x181227440")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA838C0", Offset = "0xA82AC0", VA = "0x180A838C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public virtual void EIPMKEANDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
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
	[PNPKAGGOGPE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2FDCD60", Offset = "0x2FDBF60", VA = "0x182FDCD60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC490", Offset = "0x2FDB690", VA = "0x182FDC490", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDD2A0", Offset = "0x2FDC4A0", VA = "0x182FDD2A0")]
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
	private sealed class ABHBLGJNBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public ABHBLGJNBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33E9D60", Offset = "0x33E8F60", VA = "0x1833E9D60")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PNPKAGGOGPE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D069D0", Offset = "0x1D05BD0", VA = "0x181D069D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D06A00", Offset = "0x1D05C00", VA = "0x181D06A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D06920", Offset = "0x1D05B20", VA = "0x181D06920", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey EBOEHIFNNLM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D06980", Offset = "0x1D05B80", VA = "0x181D06980", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D06820", Offset = "0x1D05A20", VA = "0x181D06820", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D06370", Offset = "0x1D05570", VA = "0x181D06370", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D05B90", Offset = "0x1D04D90", VA = "0x181D05B90", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D057E0", Offset = "0x1D049E0", VA = "0x181D057E0", Slot = "14")]
	protected virtual string LDLDEFGLAMA(TKeyVal BGEBDBGJEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1D05720", Offset = "0x1D04920", VA = "0x181D05720", Slot = "4")]
	public bool ContainsKey(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1D06710", Offset = "0x1D05910", VA = "0x181D06710", Slot = "5")]
	public bool TryGetValue(TKey EBOEHIFNNLM, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1D05750", Offset = "0x1D04950", VA = "0x181D05750", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1D05750", Offset = "0x1D04950", VA = "0x181D05750", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D06740", Offset = "0x1D05940", VA = "0x181D06740")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OGNMHJOMPGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BPJLAJCAFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public BPJLAJCAFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x22994A0", Offset = "0x22986A0", VA = "0x1822994A0")]
		internal bool <GetSamples>b__0(global::CGNKCLLPIIA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float BBPFJJCADCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float NGNGCONGICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::CGNKCLLPIIA<float, T>> PKAJFDHGMJK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JMAIMEBBADI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x38225D0", Offset = "0x38217D0", VA = "0x1838225D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38230E0", Offset = "0x38222E0", VA = "0x1838230E0")]
	public OGNMHJOMPGA(float KBCDBEKKNPO, float FELOBOLCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3822840", Offset = "0x3821A40", VA = "0x183822840")]
	public bool MKNCJIJMBLP(float KMIINHDMOMG, T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3822650", Offset = "0x3821850", VA = "0x183822650")]
	public int DKKJGFGFLNH(float KMIINHDMOMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38229A0", Offset = "0x3821BA0", VA = "0x1838229A0")]
	public IEnumerable<T> NCALKJHOKGP(float KMIINHDMOMG, [Optional] float? DOJJALFIBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38226B0", Offset = "0x38218B0", VA = "0x1838226B0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3823020", Offset = "0x3822220", VA = "0x183823020")]
	private void OAGOBBKMDDL(float KMIINHDMOMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KCFHBGMBAOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DGNNEDKPDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T ALAOEPGGPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float IODEKHGIHBF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float AHKOLGPKLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> KIAGPGIEFEA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int NIPLKHIDJAD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private DGNNEDKPDIE[] PFCDNINKMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int EHHFNDCHKHK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float HAPEMOBDDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x10EC7E0", Offset = "0x10EB9E0", VA = "0x1810EC7E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x10EC7C0", Offset = "0x10EB9C0", VA = "0x1810EC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2343390", Offset = "0x2342590", VA = "0x182343390")]
	public KCFHBGMBAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x23432B0", Offset = "0x23424B0", VA = "0x1823432B0")]
	public KCFHBGMBAOE(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCA40", Offset = "0x2DBBC40", VA = "0x182DBCA40")]
	public void AOHLLDNPMGN(float KMIINHDMOMG, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCB20", Offset = "0x2DBBD20", VA = "0x182DBCB20")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCC70", Offset = "0x2DBBE70", VA = "0x182DBCC70")]
	public bool KBBEPKEKBAH(float BIAABCJFCOF, float FCBPNNJMMEP, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCE30", Offset = "0x2DBC030", VA = "0x182DBCE30")]
	public bool MMMINKCLCLA(float BIAABCJFCOF, float FCBPNNJMMEP, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC920", Offset = "0x2DBBB20", VA = "0x182DBC920")]
	public void ALHEJEIPAGK(float BIAABCJFCOF, float FCBPNNJMMEP, List<T> IEGPGBKLAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2342B50", Offset = "0x2341D50", VA = "0x182342B50")]
	private int KBAFGKABEFI(int GJEBFGNBDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2342B10", Offset = "0x2341D10", VA = "0x182342B10")]
	private void GEJPNNGGDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ICPKICIIKML();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T EIHDCBGNLJA(T KPCLHBOMAKO, T NFBNADMIDIB, float EHIBGNPGILO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JEECLGDGEGL(T JFBPNBNBHOE, float EHIBGNPGILO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CDNJLMPCJGE(T KPCLHBOMAKO, T NFBNADMIDIB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MHBJHNKBGCD(T KPCLHBOMAKO, T NFBNADMIDIB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MBMHGCOEFOJ : global::KCFHBGMBAOE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x115B020", Offset = "0x115A220", VA = "0x18115B020", Slot = "4")]
	protected override Vector3 ICPKICIIKML()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x140DDB0", Offset = "0x140CFB0", VA = "0x18140DDB0", Slot = "5")]
	protected override Vector3 EIHDCBGNLJA(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6355500", Offset = "0x6354700", VA = "0x186355500", Slot = "6")]
	protected override Vector3 JEECLGDGEGL(Vector3 JFBPNBNBHOE, float EHIBGNPGILO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6355480", Offset = "0x6354680", VA = "0x186355480", Slot = "7")]
	protected override Vector3 CDNJLMPCJGE(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6355560", Offset = "0x6354760", VA = "0x186355560", Slot = "8")]
	protected override Vector3 MHBJHNKBGCD(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63555D0", Offset = "0x63547D0", VA = "0x1863555D0")]
	public MBMHGCOEFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NNNGGMCAFHN : global::KCFHBGMBAOE<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6356990", Offset = "0x6355B90", VA = "0x186356990")]
	public NNNGGMCAFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6356920", Offset = "0x6355B20", VA = "0x186356920")]
	public NNNGGMCAFHN(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1079270", Offset = "0x1078470", VA = "0x181079270", Slot = "4")]
	protected override float ICPKICIIKML()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x38BA9B0", Offset = "0x38B9BB0", VA = "0x1838BA9B0", Slot = "5")]
	protected override float EIHDCBGNLJA(float KPCLHBOMAKO, float NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5425210", Offset = "0x5424410", VA = "0x185425210", Slot = "6")]
	protected override float JEECLGDGEGL(float JFBPNBNBHOE, float EHIBGNPGILO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x258D480", Offset = "0x258C680", VA = "0x18258D480", Slot = "7")]
	protected override float CDNJLMPCJGE(float KPCLHBOMAKO, float NFBNADMIDIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6356910", Offset = "0x6355B10", VA = "0x186356910", Slot = "8")]
	protected override float MHBJHNKBGCD(float KPCLHBOMAKO, float NFBNADMIDIB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FNMJEBADKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2476BE0", Offset = "0x2475DE0", VA = "0x182476BE0")]
	public static global::GNFIDJBBCLK<T1> BFPHDDBHNEE<T1>(T1 LKGIEGAGLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2EAEBB0", Offset = "0x2EADDB0", VA = "0x182EAEBB0")]
	public static global::CGNKCLLPIIA<T1, T2> BFPHDDBHNEE<T1, T2>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2EAEC20", Offset = "0x2EADE20", VA = "0x182EAEC20")]
	public static global::IKNJBNHALAG<T1, T2, T3> BFPHDDBHNEE<T1, T2, T3>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x255A430", Offset = "0x2559630", VA = "0x18255A430")]
	public static global::ILIMDPEEDPH<T1, T2, T3, T4> BFPHDDBHNEE<T1, T2, T3, T4>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x247BFC0", Offset = "0x247B1C0", VA = "0x18247BFC0")]
	public static global::MJIAMBELINB<T1, T2, T3, T4, T5> BFPHDDBHNEE<T1, T2, T3, T4, T5>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2EAEE40", Offset = "0x2EAE040", VA = "0x182EAEE40")]
	public static global::AMCIMMNGFGH<T1, T2, T3, T4, T5, T6> BFPHDDBHNEE<T1, T2, T3, T4, T5, T6>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EAED80", Offset = "0x2EADF80", VA = "0x182EAED80")]
	public static global::IACIPAJNMCA<T1, T2, T3, T4, T5, T6, T7> BFPHDDBHNEE<T1, T2, T3, T4, T5, T6, T7>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2EAECB0", Offset = "0x2EADEB0", VA = "0x182EAECB0")]
	public static global::LGPDFFLANKE<T1, T2, T3, T4, T5, T6, T7, T8> BFPHDDBHNEE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH, T8 DBAAKPDJDFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x18DAF20", Offset = "0x18DA120", VA = "0x1818DAF20")]
	[IteratorStateMachine(typeof(IALELLEAPCF))]
	public static IEnumerable<global::CGNKCLLPIIA<T1, T2>> LNPNOJJEGNN<T1, T2>(IEnumerable<T1> FAMKPEGNHFC, IEnumerable<T2> GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x18DB100", Offset = "0x18DA300", VA = "0x1818DB100")]
	[IteratorStateMachine(typeof(FGEAJMJCELG))]
	public static IEnumerable<global::IKNJBNHALAG<T1, T2, T3>> LNPNOJJEGNN<T1, T2, T3>(IEnumerable<T1> FAMKPEGNHFC, IEnumerable<T2> GPHMIGDKMEO, IEnumerable<T3> ECKJDAFJMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x862ED0", Offset = "0x8620D0", VA = "0x180862ED0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8620A0", VA = "0x180862EA0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x862E80", Offset = "0x862080", VA = "0x180862E80")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x862EB0", Offset = "0x8620B0", VA = "0x180862EB0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6353620", Offset = "0x6352820", VA = "0x186353620")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH, int ELKADCKDDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63535C0", Offset = "0x63527C0", VA = "0x1863535C0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH, int ELKADCKDDAE, int JCOCNJEGKMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x63527F0", VA = "0x1863535F0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH, int ELKADCKDDAE, int JCOCNJEGKMO, int CNOIMFDAMDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GNFIDJBBCLK<T1> : IComparable<global::GNFIDJBBCLK<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1CD01B0", Offset = "0x1CCF3B0", VA = "0x181CD01B0")]
	public GNFIDJBBCLK(T1 LKGIEGAGLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32EF660", Offset = "0x32EE860", VA = "0x1832EF660", Slot = "4")]
	public int CompareTo(global::GNFIDJBBCLK<T1> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x32EF6D0", Offset = "0x32EE8D0", VA = "0x1832EF6D0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x913510", Offset = "0x912710", VA = "0x180913510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x32EF770", Offset = "0x32EE970", VA = "0x1832EF770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CGNKCLLPIIA<T1, T2> : IComparable<global::CGNKCLLPIIA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7C00", Offset = "0x2AF6E00", VA = "0x182AF7C00")]
	public CGNKCLLPIIA(T1 LKGIEGAGLED, T2 DAJGNIAIJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF61F0", Offset = "0x2AF53F0", VA = "0x182AF61F0", Slot = "4")]
	public int CompareTo(global::CGNKCLLPIIA<T1, T2> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6970", Offset = "0x2AF5B70", VA = "0x182AF6970", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6D60", Offset = "0x2AF5F60", VA = "0x182AF6D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7820", Offset = "0x2AF6A20", VA = "0x182AF7820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IKNJBNHALAG<T1, T2, T3> : IComparable<global::IKNJBNHALAG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 FHJHCDLGCNN;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F771E0", Offset = "0x1F763E0", VA = "0x181F771E0")]
	public IKNJBNHALAG(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F76D60", Offset = "0x1F75F60", VA = "0x181F76D60", Slot = "4")]
	public int CompareTo(global::IKNJBNHALAG<T1, T2, T3> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F76E60", Offset = "0x1F76060", VA = "0x181F76E60", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F76FD0", Offset = "0x1F761D0", VA = "0x181F76FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F77030", Offset = "0x1F76230", VA = "0x181F77030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ILIMDPEEDPH<T1, T2, T3, T4> : IComparable<global::ILIMDPEEDPH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 FHJHCDLGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 LFENLIFMPPI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2656D70", Offset = "0x2655F70", VA = "0x182656D70")]
	public ILIMDPEEDPH(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27E2120", Offset = "0x27E1320", VA = "0x1827E2120", Slot = "4")]
	public int CompareTo(global::ILIMDPEEDPH<T1, T2, T3, T4> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27E2260", Offset = "0x27E1460", VA = "0x1827E2260", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27E2380", Offset = "0x27E1580", VA = "0x1827E2380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27E2440", Offset = "0x27E1640", VA = "0x1827E2440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MJIAMBELINB<T1, T2, T3, T4, T5> : IComparable<global::MJIAMBELINB<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 FHJHCDLGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 LFENLIFMPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 NNEABCMPKIA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C9C0", Offset = "0x2E6BBC0", VA = "0x182E6C9C0")]
	public MJIAMBELINB(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C4B0", Offset = "0x2E6B6B0", VA = "0x182E6C4B0", Slot = "4")]
	public int CompareTo(global::MJIAMBELINB<T1, T2, T3, T4, T5> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C630", Offset = "0x2E6B830", VA = "0x182E6C630", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C770", Offset = "0x2E6B970", VA = "0x182E6C770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C870", Offset = "0x2E6BA70", VA = "0x182E6C870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AMCIMMNGFGH<T1, T2, T3, T4, T5, T6> : IComparable<global::AMCIMMNGFGH<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 FHJHCDLGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 LFENLIFMPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 NNEABCMPKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 LODLAFDACND;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x338CAA0", Offset = "0x338BCA0", VA = "0x18338CAA0")]
	public AMCIMMNGFGH(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x338C4E0", Offset = "0x338B6E0", VA = "0x18338C4E0", Slot = "4")]
	public int CompareTo(global::AMCIMMNGFGH<T1, T2, T3, T4, T5, T6> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x338C6A0", Offset = "0x338B8A0", VA = "0x18338C6A0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x338C810", Offset = "0x338BA10", VA = "0x18338C810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x338C930", Offset = "0x338BB30", VA = "0x18338C930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IACIPAJNMCA<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::IACIPAJNMCA<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 FHJHCDLGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 LFENLIFMPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 NNEABCMPKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 LODLAFDACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 EBHKLNOKIFG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3431B20", Offset = "0x3430D20", VA = "0x183431B20")]
	public IACIPAJNMCA(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x34314A0", Offset = "0x34306A0", VA = "0x1834314A0", Slot = "4")]
	public int CompareTo(global::IACIPAJNMCA<T1, T2, T3, T4, T5, T6, T7> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34316A0", Offset = "0x34308A0", VA = "0x1834316A0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3431840", Offset = "0x3430A40", VA = "0x183431840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3431990", Offset = "0x3430B90", VA = "0x183431990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LGPDFFLANKE<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::LGPDFFLANKE<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 OENGCIIGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 CDCDDNCFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 FHJHCDLGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 LFENLIFMPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 NNEABCMPKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 LODLAFDACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 EBHKLNOKIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 IPHFHMLPKIF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x37E08E0", Offset = "0x37DFAE0", VA = "0x1837E08E0")]
	public LGPDFFLANKE(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH, T8 DBAAKPDJDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37E01B0", Offset = "0x37DF3B0", VA = "0x1837E01B0", Slot = "4")]
	public int CompareTo(global::LGPDFFLANKE<T1, T2, T3, T4, T5, T6, T7, T8> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37E0400", Offset = "0x37DF600", VA = "0x1837E0400", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37E05C0", Offset = "0x37DF7C0", VA = "0x1837E05C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37E0730", Offset = "0x37DF930", VA = "0x1837E0730", Slot = "3")]
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
	public T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1ABFEB0", Offset = "0x1ABF0B0", VA = "0x181ABFEB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A9D0", Offset = "0x3E29BD0", VA = "0x183E2A9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KDAANCAKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x10AC120", Offset = "0x10AB320", VA = "0x1810AC120")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E2ACD0", Offset = "0x3E29ED0", VA = "0x183E2ACD0")]
	public T PKPJGNNLGLE(float EHIBGNPGILO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A9E0", Offset = "0x3E29BE0", VA = "0x183E2A9E0")]
	public T EKLIGNLKJPB(float EHIBGNPGILO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EIHDCBGNLJA(T KPCLHBOMAKO, T NFBNADMIDIB, float EHIBGNPGILO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x38BA9B0", Offset = "0x38B9BB0", VA = "0x1838BA9B0", Slot = "4")]
	protected override float EIHDCBGNLJA(float KPCLHBOMAKO, float NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6353640", Offset = "0x6352840", VA = "0x186353640")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x140DDB0", Offset = "0x140CFB0", VA = "0x18140DDB0", Slot = "4")]
	protected override Vector3 EIHDCBGNLJA(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x635A0A0", Offset = "0x63592A0", VA = "0x18635A0A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6352BE0", Offset = "0x6351DE0", VA = "0x186352BE0", Slot = "4")]
	protected override Color EIHDCBGNLJA(Color KPCLHBOMAKO, Color NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6352C30", Offset = "0x6351E30", VA = "0x186352C30")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PKCIFHOFKIO : global::APIIJKMDDNE<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6357B00", Offset = "0x6356D00", VA = "0x186357B00")]
	public PKCIFHOFKIO(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6357B50", Offset = "0x6356D50", VA = "0x186357B50")]
	public PKCIFHOFKIO(KIDKIGHNFGJ[] NHOGNDHLIKK, bool AMBLPFKLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6357A90", Offset = "0x6356C90", VA = "0x186357A90", Slot = "6")]
	protected override uint BFOAGILFNAM(uint JBFGBNAHGLM, string JFBPNBNBHOE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FFMLKJBCAIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public FFMLKJBCAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct GINABHBDCHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class POINEOHJOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public POINEOHJOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x33EA940", Offset = "0x33E9B40", VA = "0x1833EA940")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DOABCFLPMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int INANNCEMPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int OFFJGDOLBED;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xC13F30", Offset = "0xC13130", VA = "0x180C13F30")]
	private GINABHBDCHI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DBKHNNFFFBI, int POBGPMBGFJI, int DAPJGJIMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x35BF690", Offset = "0x35BE890", VA = "0x1835BF690")]
	public static global::GINABHBDCHI<T> GDHAFJANMPF()
	{
		return default(global::GINABHBDCHI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x35C05E0", Offset = "0x35BF7E0", VA = "0x1835C05E0")]
	public (int, int, Task<T>) PIDPKAEICBI(int NOJAHDOHDIN, [Optional] CancellationToken OLHHOODBFDC, double EONMILEOIME = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x35BF180", Offset = "0x35BE380", VA = "0x1835BF180")]
	public void EMPPCHDBPDC(int NOJAHDOHDIN, int DAPJGJIMAOA, in T APCBFLNDMMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BFHBEPHLHII
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6351AA0", Offset = "0x6350CA0", VA = "0x186351AA0")]
	public static global::GINABHBDCHI<CHLMDABNGKB> GDHAFJANMPF()
	{
		return default(global::GINABHBDCHI<CHLMDABNGKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6351A20", Offset = "0x6350C20", VA = "0x186351A20")]
	public static void EMPPCHDBPDC(this in global::GINABHBDCHI<CHLMDABNGKB> PKCJMFFNILJ, int NOJAHDOHDIN, int DAPJGJIMAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class LBNKKKIHALP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> GHIBMCOJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> IDLOBIOHGIJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CA80", Offset = "0x1F6BC80", VA = "0x181F6CA80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GJBOPCKCLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x239EB30", Offset = "0x239DD30", VA = "0x18239EB30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> EIKMMLDOIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2350B10", Offset = "0x234FD10", VA = "0x182350B10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x35E56A0", Offset = "0x35E48A0", VA = "0x1835E56A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x35E5710", Offset = "0x35E4910", VA = "0x1835E5710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x35E4BF0", Offset = "0x35E3DF0", VA = "0x1835E4BF0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x35E48A0", Offset = "0x35E3AA0", VA = "0x1835E48A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x35E46E0", Offset = "0x35E38E0", VA = "0x1835E46E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x35E54D0", Offset = "0x35E46D0", VA = "0x1835E54D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x35E4580", Offset = "0x35E3780", VA = "0x1835E4580", Slot = "9")]
	public void Add(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x35E45C0", Offset = "0x35E37C0", VA = "0x1835E45C0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x35E4740", Offset = "0x35E3940", VA = "0x1835E4740", Slot = "8")]
	public bool ContainsKey(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x35E47A0", Offset = "0x35E39A0", VA = "0x1835E47A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x35E5440", Offset = "0x35E4640", VA = "0x1835E5440", Slot = "10")]
	public bool Remove(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x35E54A0", Offset = "0x35E46A0", VA = "0x1835E54A0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A15C10", Offset = "0x2A14E10", VA = "0x182A15C10", Slot = "11")]
	public bool TryGetValue(TKey EBOEHIFNNLM, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x239E5D0", Offset = "0x239D7D0", VA = "0x18239E5D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x35E4800", Offset = "0x35E3A00", VA = "0x1835E4800", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x35E4460", Offset = "0x35E3660", VA = "0x1835E4460")]
	public void AOHLLDNPMGN(TVal GBADNLAFNJL, TKey EBOEHIFNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x35E4420", Offset = "0x35E3620", VA = "0x1835E4420")]
	public void AOHLLDNPMGN(KeyValuePair<TVal, TKey> KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x35E4950", Offset = "0x35E3B50", VA = "0x1835E4950")]
	public bool GOBLPAEKFAO(TVal EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x35E49C0", Offset = "0x35E3BC0", VA = "0x1835E49C0")]
	public bool GPEECKGOEKF(KeyValuePair<TVal, TKey> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x35E4600", Offset = "0x35E3800", VA = "0x1835E4600")]
	public bool BCBAFCFKBLF(TVal EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x35E4600", Offset = "0x35E3800", VA = "0x1835E4600")]
	public bool BCBAFCFKBLF(KeyValuePair<TVal, TKey> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x35E4670", Offset = "0x35E3870", VA = "0x1835E4670")]
	public bool CPKINNFJFHF(TVal EBOEHIFNNLM, out TKey JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x35E4B30", Offset = "0x35E3D30", VA = "0x1835E4B30")]
	public IEnumerator<KeyValuePair<TVal, TKey>> KEDLLJBBBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x35E50E0", Offset = "0x35E42E0", VA = "0x1835E50E0")]
	private void MFEHIIJNMGD(TKey EBOEHIFNNLM, TVal GBADNLAFNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x35E5310", Offset = "0x35E4510", VA = "0x1835E5310")]
	private void NPKHMDCFAPB(TKey EBOEHIFNNLM, TVal GBADNLAFNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x35E4C30", Offset = "0x35E3E30", VA = "0x1835E4C30")]
	private bool LNMDDPEGOLO(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x35E4E80", Offset = "0x35E4080", VA = "0x1835E4E80")]
	private bool LNMDDPEGOLO(TVal GBADNLAFNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x35E55C0", Offset = "0x35E47C0", VA = "0x1835E55C0")]
	public LBNKKKIHALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class MBLCFMBJBBP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::MBLCFMBJBBP<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3197FD0", Offset = "0x31971D0", VA = "0x183197FD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x30BF5A0", Offset = "0x30BE7A0", VA = "0x1830BF5A0")]
		public Enumerator(global::MBLCFMBJBBP<T> IEGPGBKLAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3194750", Offset = "0x3193950", VA = "0x183194750", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3196710", Offset = "0x3195910", VA = "0x183196710", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x31963B0", Offset = "0x31955B0", VA = "0x1831963B0")]
		private void OHFIMEDJOOC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] GGPNCMCBJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int IIEPBAFMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int NAAOAKOALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int FLPPPNDNNNB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8F90", Offset = "0x3AE8190", VA = "0x183AE8F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8EC0", Offset = "0x3AE80C0", VA = "0x183AE8EC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8860", Offset = "0x3AE7A60", VA = "0x183AE8860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9750", Offset = "0x3AE8950", VA = "0x183AE9750")]
	public MBLCFMBJBBP(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3AE84C0", Offset = "0x3AE76C0", VA = "0x183AE84C0")]
	public void AOHLLDNPMGN(T EHIBGNPGILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7BB0", Offset = "0x3AE6DB0", VA = "0x183AE7BB0")]
	public void ALLOANNJLKE(IEnumerable<T> LABCOKBJJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8840", Offset = "0x3AE7A40", VA = "0x183AE8840")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE87B0", Offset = "0x3AE79B0", VA = "0x183AE87B0")]
	public void BOILOPKCDHM(int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8FD0", Offset = "0x3AE81D0", VA = "0x183AE8FD0")]
	public void ODBBFOEBEGJ(int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE91E0", Offset = "0x3AE83E0", VA = "0x183AE91E0")]
	public void PDCLCNAPIPC(T[] PFCDNINKMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7810", Offset = "0x3AE6A10", VA = "0x183AE7810")]
	public Enumerator AHIPNMLLDNB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE95D0", Offset = "0x3AE87D0", VA = "0x183AE95D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3AE95D0", Offset = "0x3AE87D0", VA = "0x183AE95D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8B40", Offset = "0x3AE7D40", VA = "0x183AE8B40")]
	private int KNFJIOIOLNF(int BELCAJFDAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9060", Offset = "0x3AE8260", VA = "0x183AE9060")]
	private int OGOBDIACIBG(int BELCAJFDAHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class IEICLPEFHJN<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> KMABJOABNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> GMAHEAKKDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x781170", Offset = "0x780370", VA = "0x180781170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1F67510", Offset = "0x1F66710", VA = "0x181F67510", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1F675B0", Offset = "0x1F667B0", VA = "0x181F675B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1F674B0", Offset = "0x1F666B0", VA = "0x181F674B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1F67420", Offset = "0x1F66620", VA = "0x181F67420")]
	public IEICLPEFHJN(Func<Internal, External> CFOONEMCGLN, Func<External, Internal> KMABJOABNLB, bool LPKIEPPBIHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1F67110", Offset = "0x1F66310", VA = "0x181F67110", Slot = "6")]
	public int IndexOf(External KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1F66D30", Offset = "0x1F65F30", VA = "0x181F66D30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1F66D90", Offset = "0x1F65F90", VA = "0x181F66D90", Slot = "13")]
	public bool Contains(External KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1F66E20", Offset = "0x1F66020", VA = "0x181F66E20", Slot = "14")]
	public void CopyTo(External[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1F66CA0", Offset = "0x1F65EA0", VA = "0x181F66CA0", Slot = "11")]
	public void Add(External KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1F67200", Offset = "0x1F66400", VA = "0x181F67200", Slot = "7")]
	public void Insert(int BELCAJFDAHD, External KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1F67360", Offset = "0x1F66560", VA = "0x181F67360", Slot = "15")]
	public bool Remove(External KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1F672A0", Offset = "0x1F664A0", VA = "0x181F672A0", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1F67040", Offset = "0x1F66240", VA = "0x181F67040", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1F673F0", Offset = "0x1F665F0", VA = "0x181F673F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MOIMMBJPNMO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> CFOONEMCGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> GMAHEAKKDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3085790", Offset = "0x3084990", VA = "0x183085790", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3085730", Offset = "0x3084930", VA = "0x183085730", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1CD01B0", Offset = "0x1CCF3B0", VA = "0x181CD01B0")]
	public MOIMMBJPNMO(Func<Internal, External> CFOONEMCGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x30856E0", Offset = "0x30848E0", VA = "0x1830856E0")]
	public MOIMMBJPNMO(IReadOnlyList<Internal> NHOGENNANEB, Func<Internal, External> CFOONEMCGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x30854C0", Offset = "0x30846C0", VA = "0x1830854C0")]
	public void PDCLCNAPIPC(External[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3085450", Offset = "0x3084650", VA = "0x183085450", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x229B510", Offset = "0x229A710", VA = "0x18229B510", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class JPHCLNDJNNG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> NHOGENNANEB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> GMAHEAKKDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9EBB0", Offset = "0x2D9DDB0", VA = "0x182D9EBB0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2D9EB50", Offset = "0x2D9DD50", VA = "0x182D9EB50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD01B0", Offset = "0x1CCF3B0", VA = "0x181CD01B0")]
	public JPHCLNDJNNG(IReadOnlyList<Internal> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E810", Offset = "0x2D9DA10", VA = "0x182D9E810")]
	public bool GPEECKGOEKF(External KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E920", Offset = "0x2D9DB20", VA = "0x182D9E920")]
	public void PDCLCNAPIPC(External[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E8B0", Offset = "0x2D9DAB0", VA = "0x182D9E8B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1F673F0", Offset = "0x1F665F0", VA = "0x181F673F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class CGKKAJLAKLK
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FMEEHNNGJAF(object[] FKNKEJLLBEP);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	protected CGKKAJLAKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class PHFJFINDCAB<T> : CGKKAJLAKLK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct CLGCNLDMKOK
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum JDBAPPMNEJA
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
		public JDBAPPMNEJA DDJDPMGLPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T GPNJNMLGIEN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int KPADEDNIJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool FLPFCLMBPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool HLDFGNCKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> OPKHEJFBOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<CLGCNLDMKOK> OFKMLHJKAOM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JHPECFFAFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x32996B0", Offset = "0x32988B0", VA = "0x1832996B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x32996F0", Offset = "0x32988F0", VA = "0x1832996F0")]
	protected PHFJFINDCAB(bool HLDFGNCKGGB, bool FLPFCLMBPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3299570", Offset = "0x3298770", VA = "0x183299570")]
	protected bool HBBBEBGACDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x32995F0", Offset = "0x32987F0", VA = "0x1832995F0")]
	protected void ICIODNMJKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x32992B0", Offset = "0x32984B0", VA = "0x1832992B0")]
	protected void DGGEPBMFKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C82D80", Offset = "0x3C81F80", VA = "0x183C82D80")]
	private static void HLCBFCGGDPA<U>(ref List<U> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3299010", Offset = "0x3298210", VA = "0x183299010", Slot = "5")]
	public void AOHLLDNPMGN(T GPNJNMLGIEN, bool AKKFHGAIPNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3299170", Offset = "0x3298370", VA = "0x183299170", Slot = "6")]
	public void BCBAFCFKBLF(T GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3299460", Offset = "0x3298660", VA = "0x183299460")]
	public void FPNLAFLJCKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DKFBFKKMGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class CBKLEJNNKJH : global::PHFJFINDCAB<Action>, DKFBFKKMGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6352900", Offset = "0x6351B00", VA = "0x186352900")]
	public CBKLEJNNKJH(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6352690", Offset = "0x6351890", VA = "0x186352690")]
	public void KICKDGJKECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x63525C0", Offset = "0x63517C0", VA = "0x1863525C0", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6352630", Offset = "0x6351830", VA = "0x186352630")]
	public static CBKLEJNNKJH FOACHAMOMCH(CBKLEJNNKJH GDGMMGHMPIA, Action GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x63528A0", Offset = "0x6351AA0", VA = "0x1863528A0")]
	public static CBKLEJNNKJH ONNNIIHIBPF(CBKLEJNNKJH GDGMMGHMPIA, Action GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NEGEFNAIJIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action<T> GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action<T> GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KOEHNDLKDFN<T> : global::PHFJFINDCAB<Action<T>>, global::NEGEFNAIJIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE30", Offset = "0x1F6C030", VA = "0x181F6CE30")]
	public KOEHNDLKDFN(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x31BA2F0", Offset = "0x31B94F0", VA = "0x1831BA2F0")]
	public void KICKDGJKECN(T EHIBGNPGILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2359B40", Offset = "0x2358D40", VA = "0x182359B40", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x235A220", Offset = "0x2359420", VA = "0x18235A220")]
	public static global::KOEHNDLKDFN<T> FOACHAMOMCH(global::KOEHNDLKDFN<T> GDGMMGHMPIA, Action<T> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x235B0D0", Offset = "0x235A2D0", VA = "0x18235B0D0")]
	public static global::KOEHNDLKDFN<T> ONNNIIHIBPF(global::KOEHNDLKDFN<T> GDGMMGHMPIA, Action<T> GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IEGFDDAMIMN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action<T, U> GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action<T, U> GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NKKFEABOGLC<T, U> : global::PHFJFINDCAB<Action<T, U>>, global::IEGFDDAMIMN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE30", Offset = "0x1F6C030", VA = "0x181F6CE30")]
	public NKKFEABOGLC(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2B77800", Offset = "0x2B76A00", VA = "0x182B77800")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2B76050", Offset = "0x2B75250", VA = "0x182B76050", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2B76C20", Offset = "0x2B75E20", VA = "0x182B76C20")]
	public static global::NKKFEABOGLC<T, U> FOACHAMOMCH(global::NKKFEABOGLC<T, U> GDGMMGHMPIA, Action<T, U> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2B77C80", Offset = "0x2B76E80", VA = "0x182B77C80")]
	public static global::NKKFEABOGLC<T, U> ONNNIIHIBPF(global::NKKFEABOGLC<T, U> GDGMMGHMPIA, Action<T, U> GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LFMBLNHEACF<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action<T, U, V> GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action<T, U, V> GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class FKFOHAFACOF<T, U, V> : global::PHFJFINDCAB<Action<T, U, V>>, global::LFMBLNHEACF<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE30", Offset = "0x1F6C030", VA = "0x181F6CE30")]
	public FKFOHAFACOF(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x23B0BB0", Offset = "0x23AFDB0", VA = "0x1823B0BB0")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x23AD3A0", Offset = "0x23AC5A0", VA = "0x1823AD3A0", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x23AED00", Offset = "0x23ADF00", VA = "0x1823AED00")]
	public static global::FKFOHAFACOF<T, U, V> FOACHAMOMCH(global::FKFOHAFACOF<T, U, V> GDGMMGHMPIA, Action<T, U, V> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x23B0E10", Offset = "0x23B0010", VA = "0x1823B0E10")]
	public static global::FKFOHAFACOF<T, U, V> ONNNIIHIBPF(global::FKFOHAFACOF<T, U, V> GDGMMGHMPIA, Action<T, U, V> GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IFHEMOODFEM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action<T, U, V, W> GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action<T, U, V, W> GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class NKBDDKEOJNM<T, U, V, W> : global::PHFJFINDCAB<Action<T, U, V, W>>, global::IFHEMOODFEM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE30", Offset = "0x1F6C030", VA = "0x181F6CE30")]
	public NKBDDKEOJNM(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2B73EA0", Offset = "0x2B730A0", VA = "0x182B73EA0")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB, W ONCKMLEEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2B723A0", Offset = "0x2B715A0", VA = "0x182B723A0", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2B72DE0", Offset = "0x2B71FE0", VA = "0x182B72DE0")]
	public static global::NKBDDKEOJNM<T, U, V, W> FOACHAMOMCH(global::NKBDDKEOJNM<T, U, V, W> GDGMMGHMPIA, Action<T, U, V, W> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2B74380", Offset = "0x2B73580", VA = "0x182B74380")]
	public static global::NKBDDKEOJNM<T, U, V, W> ONNNIIHIBPF(global::NKBDDKEOJNM<T, U, V, W> GDGMMGHMPIA, Action<T, U, V, W> GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PJICMPKHLEF<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action<T, U, V, W, X> GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action<T, U, V, W, X> GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class FGGMMFHCHKG<T, U, V, W, X> : global::PHFJFINDCAB<Action<T, U, V, W, X>>, global::PJICMPKHLEF<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE30", Offset = "0x1F6C030", VA = "0x181F6CE30")]
	public FGGMMFHCHKG(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x23A4810", Offset = "0x23A3A10", VA = "0x1823A4810")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB, W ONCKMLEEMNO, X BIAIPPDLOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x23A4480", Offset = "0x23A3680", VA = "0x1823A4480", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x23A4770", Offset = "0x23A3970", VA = "0x1823A4770")]
	public static global::FGGMMFHCHKG<T, U, V, W, X> FOACHAMOMCH(global::FGGMMFHCHKG<T, U, V, W, X> GDGMMGHMPIA, Action<T, U, V, W, X> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x23A4DD0", Offset = "0x23A3FD0", VA = "0x1823A4DD0")]
	public static global::FGGMMFHCHKG<T, U, V, W, X> ONNNIIHIBPF(global::FGGMMFHCHKG<T, U, V, W, X> GDGMMGHMPIA, Action<T, U, V, W, X> GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MAKHJNHHAJJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(Action<T, U, V, W, X, Y> GPNJNMLGIEN, bool AKKFHGAIPNM = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCBAFCFKBLF(Action<T, U, V, W, X, Y> GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class FPDFBJHKGOH<T, U, V, W, X, Y> : global::PHFJFINDCAB<Action<T, U, V, W, X, Y>>, global::MAKHJNHHAJJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE30", Offset = "0x1F6C030", VA = "0x181F6CE30")]
	public FPDFBJHKGOH(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x304A140", Offset = "0x3049340", VA = "0x18304A140")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB, W ONCKMLEEMNO, X BIAIPPDLOMD, Y ECJDGGJBGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3049740", Offset = "0x3048940", VA = "0x183049740", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3049DF0", Offset = "0x3048FF0", VA = "0x183049DF0")]
	public static global::FPDFBJHKGOH<T, U, V, W, X, Y> FOACHAMOMCH(global::FPDFBJHKGOH<T, U, V, W, X, Y> GDGMMGHMPIA, Action<T, U, V, W, X, Y> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x304A710", Offset = "0x3049910", VA = "0x18304A710")]
	public static global::FPDFBJHKGOH<T, U, V, W, X, Y> ONNNIIHIBPF(global::FPDFBJHKGOH<T, U, V, W, X, Y> GDGMMGHMPIA, Action<T, U, V, W, X, Y> GPNJNMLGIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class GCMHCAIPOAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct PFHAPGJMIHD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::GCMHCAIPOAB<T> CEHNCIAOMOC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T ALAOEPGGPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x32966B0", Offset = "0x32958B0", VA = "0x1832966B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3296680", Offset = "0x3295880", VA = "0x183296680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x89DDB0", Offset = "0x89CFB0", VA = "0x18089DDB0")]
		public PFHAPGJMIHD(global::GCMHCAIPOAB<T> CEHNCIAOMOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KINOJAKMHLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<PFHAPGJMIHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::GCMHCAIPOAB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x234CE70", Offset = "0x234C070", VA = "0x18234CE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1DA54A0", Offset = "0x1DA46A0", VA = "0x181DA54A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct APBMLGBEMGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<PFHAPGJMIHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::GCMHCAIPOAB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x33901C0", Offset = "0x338F3C0", VA = "0x1833901C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA54A0", Offset = "0x1DA46A0", VA = "0x181DA54A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim GCKGKGFEOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T FLEJODBNJFG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int DPNODFPKPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0200", Offset = "0x2BAF400", VA = "0x182BB0200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2BB02F0", Offset = "0x2BAF4F0", VA = "0x182BB02F0")]
	public GCMHCAIPOAB(in T FLEJODBNJFG, int KPGHBELDCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2BB02C0", Offset = "0x2BAF4C0", VA = "0x182BB02C0")]
	public GCMHCAIPOAB(in T FLEJODBNJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0180", Offset = "0x2BAF380", VA = "0x182BB0180")]
	public PFHAPGJMIHD DLIFFOEPCGK()
	{
		return default(PFHAPGJMIHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2BB01C0", Offset = "0x2BAF3C0", VA = "0x182BB01C0")]
	public PFHAPGJMIHD DLIFFOEPCGK(CancellationToken OLHHOODBFDC)
	{
		return default(PFHAPGJMIHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0020", Offset = "0x2BAF220", VA = "0x182BB0020")]
	[AsyncStateMachine(typeof(global::GCMHCAIPOAB<>.KINOJAKMHLL))]
	public Task<PFHAPGJMIHD> DCHJKDKHMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFBE0", Offset = "0x2BAEDE0", VA = "0x182BAFBE0")]
	[AsyncStateMachine(typeof(global::GCMHCAIPOAB<>.APBMLGBEMGP))]
	public Task<PFHAPGJMIHD> DCHJKDKHMMF(CancellationToken OLHHOODBFDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NKOMAPDLOOJ
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6356750", Offset = "0x6355950", VA = "0x186356750")]
	public static global::GCMHCAIPOAB<CHLMDABNGKB> GDHAFJANMPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x63567B0", Offset = "0x63559B0", VA = "0x1863567B0")]
	public static global::GCMHCAIPOAB<CHLMDABNGKB> GDHAFJANMPF(int KPGHBELDCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2476BE0", Offset = "0x2475DE0", VA = "0x182476BE0")]
	public static global::GCMHCAIPOAB<T> GDHAFJANMPF<T>(in T FLEJODBNJFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x247BEC0", Offset = "0x247B0C0", VA = "0x18247BEC0")]
	public static global::GCMHCAIPOAB<T> GDHAFJANMPF<T>(in T FLEJODBNJFG, int KPGHBELDCAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CJKFHLCLKLH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> HOBFBFJLEOH(TRequest EFADACBHMKC, CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum LFOBHDCHFDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class MNDONGBLOKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float ODJJGEOPOAB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan MBFDNCNICLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int JGDNJKDHFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LFOBHDCHFDI EEBDFLPJHAH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly MNDONGBLOKI HMBHBEDALCN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float INGELJOMELD
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2E72D60", Offset = "0x2E71F60", VA = "0x182E72D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan CKJEKDMEJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2E72EB0", Offset = "0x2E720B0", VA = "0x182E72EB0")]
		public MNDONGBLOKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct MPEOEJOOIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest EFADACBHMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken OLHHOODBFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> IDBDDCGJDGM;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x30881F0", Offset = "0x30873F0", VA = "0x1830881F0")]
		public MPEOEJOOIKE(TRequest EFADACBHMKC, TaskCompletionSource<TResult> IDBDDCGJDGM, CancellationToken OLHHOODBFDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PPDBFGDMHAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public PPDBFGDMHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CA80", Offset = "0x1F6BC80", VA = "0x181F6CA80")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct LHICDCNGHOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::CJKFHLCLKLH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x37E1070", Offset = "0x37E0270", VA = "0x1837E1070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct DLLGJHMHJLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::CJKFHLCLKLH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private MPEOEJOOIKE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2A1AF10", Offset = "0x2A1A110", VA = "0x182A1AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CEOHGGNKKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<MPEOEJOOIKE> AJGEMBACFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MNDONGBLOKI KJILDGNKAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HOBFBFJLEOH GGDLLOJGMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task LKPFBBBPDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int NAGKKGCHOEE;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2B04C80", Offset = "0x2B03E80", VA = "0x182B04C80")]
	public CJKFHLCLKLH(HOBFBFJLEOH GGDLLOJGMIH, [Optional] MNDONGBLOKI KJILDGNKAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2B03E00", Offset = "0x2B03000", VA = "0x182B03E00")]
	public Task<TResult> FLBAHFMCKLI(TRequest EFADACBHMKC, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2B04AB0", Offset = "0x2B03CB0", VA = "0x182B04AB0")]
	private void OJPBFOMAEBK(MPEOEJOOIKE DDLOCPDNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2B03600", Offset = "0x2B02800", VA = "0x182B03600")]
	[AsyncStateMachine(typeof(global::CJKFHLCLKLH<, >.LHICDCNGHOE))]
	private Task BEPFDAIBCBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2B04050", Offset = "0x2B03250", VA = "0x182B04050")]
	private MPEOEJOOIKE IFMCFFLHEJM()
	{
		return default(MPEOEJOOIKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2B04750", Offset = "0x2B03950", VA = "0x182B04750")]
	[AsyncStateMachine(typeof(global::CJKFHLCLKLH<, >.DLLGJHMHJLN))]
	private Task OBBDHADMBCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2B03530", Offset = "0x2B02730", VA = "0x182B03530")]
	private void ACBKABPFPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2B03900", Offset = "0x2B02B00", VA = "0x182B03900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class JAKACKENDND<TKey, TVal> : global::IJOEEHHBALN<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int MAAJBNPJAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> LDHOBKNOBJE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int PCCDIDJHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x30C2A00", Offset = "0x30C1C00", VA = "0x1830C2A00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int BBJJHKOCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x30C2ED0", Offset = "0x30C20D0", VA = "0x1830C2ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x30C2E70", Offset = "0x30C2070", VA = "0x1830C2E70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x30C2F00", Offset = "0x30C2100", VA = "0x1830C2F00")]
	public JAKACKENDND(int DOMGBHGFPFL, [Optional] EOBLDDNPDIC EEKMHLEEPKM, [Optional] IEqualityComparer<TKey> BKMCLMNONDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x30C2DD0", Offset = "0x30C1FD0", VA = "0x1830C2DD0")]
	public void KKNJKGFPPBG(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE, bool JEEBINHFMEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x30C2AA0", Offset = "0x30C1CA0", VA = "0x1830C2AA0")]
	public bool GCDFGPPINMC(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x30C2850", Offset = "0x30C1A50", VA = "0x1830C2850", Slot = "6")]
	public override bool CPKINNFJFHF(TKey DPKBBCLKPCA, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x30C2B20", Offset = "0x30C1D20", VA = "0x1830C2B20")]
	public bool GHKAKIKICPH(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x30C28F0", Offset = "0x30C1AF0", VA = "0x1830C28F0")]
	public bool DABEJHOJHML(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x30C2A30", Offset = "0x30C1C30", VA = "0x1830C2A30", Slot = "7")]
	public override void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x30C2D30", Offset = "0x30C1F30", VA = "0x1830C2D30")]
	private bool HMEJNHKPLHB(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class IJOEEHHBALN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int EOBLDDNPDIC(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DBDGNICINLN
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey EGNKEKCMBBI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal ALAOEPGGPNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FAANOCEKAPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6E91B0", Offset = "0x6E83B0", VA = "0x1806E91B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA0ABA0", Offset = "0xA09DA0", VA = "0x180A0ABA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime AOPAHHGHKON
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xDD9C60", Offset = "0xDD8E60", VA = "0x180DD9C60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2959FF0", Offset = "0x29591F0", VA = "0x182959FF0")]
		public DBDGNICINLN(TKey EBOEHIFNNLM, TVal GBADNLAFNJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int NBONNJPLJJC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<DBDGNICINLN>> GPFCHDKPAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<DBDGNICINLN> AEEMMECOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly EOBLDDNPDIC EEKMHLEEPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan EBLKNHBCAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IFDFHCOPJLI OJOHLAOHCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int OGLDMFMEBKF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6C7020", Offset = "0x6C6220", VA = "0x1806C7020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool MALJKJCCLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1F75E30", Offset = "0x1F75030", VA = "0x181F75E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int PCCDIDJHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x91D070", Offset = "0x91C270", VA = "0x18091D070", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int OCCKKIPCFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1CCEFF0", Offset = "0x1CCE1F0", VA = "0x181CCEFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1F75650", Offset = "0x1F74850", VA = "0x181F75650", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GJBOPCKCLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1F73D00", Offset = "0x1F72F00", VA = "0x181F73D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F755E0", Offset = "0x1F747E0", VA = "0x181F755E0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F73FC0", Offset = "0x1F731C0", VA = "0x181F73FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1F76330", Offset = "0x1F75530", VA = "0x181F76330")]
	public IJOEEHHBALN(int DOMGBHGFPFL, [Optional] EOBLDDNPDIC EEKMHLEEPKM, [Optional] IEqualityComparer<TKey> BKMCLMNONDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1F762E0", Offset = "0x1F754E0", VA = "0x181F762E0")]
	public IJOEEHHBALN(TimeSpan EBLKNHBCAOH, [Optional] IEqualityComparer<TKey> BKMCLMNONDI, [Optional] IFDFHCOPJLI OJOHLAOHCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1F76400", Offset = "0x1F75600", VA = "0x181F76400")]
	public IJOEEHHBALN(int DOMGBHGFPFL, TimeSpan EBLKNHBCAOH, [Optional] IEqualityComparer<TKey> BKMCLMNONDI, [Optional] IFDFHCOPJLI OJOHLAOHCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1F76450", Offset = "0x1F75650", VA = "0x181F76450")]
	public IJOEEHHBALN(int DOMGBHGFPFL, EOBLDDNPDIC EEKMHLEEPKM, TimeSpan EBLKNHBCAOH, [Optional] IEqualityComparer<TKey> BKMCLMNONDI, [Optional] IFDFHCOPJLI OJOHLAOHCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1F73A10", Offset = "0x1F72C10", VA = "0x181F73A10")]
	public void DOMNEEHKMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F74B50", Offset = "0x1F73D50", VA = "0x181F74B50")]
	public void HDECKBNAIGA(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F72D50", Offset = "0x1F71F50", VA = "0x181F72D50")]
	public bool BCBAFCFKBLF(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F74CD0", Offset = "0x1F73ED0", VA = "0x181F74CD0")]
	private TVal JLPNHBINJFC(TKey DPKBBCLKPCA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F73020", Offset = "0x1F72220", VA = "0x181F73020", Slot = "6")]
	public virtual bool CPKINNFJFHF(TKey DPKBBCLKPCA, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F73F20", Offset = "0x1F73120", VA = "0x181F73F20", Slot = "7")]
	public virtual void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F73660", Offset = "0x1F72860", VA = "0x181F73660")]
	private bool DIMMCANMGLL(DBDGNICINLN CEPDMCOICON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F74240", Offset = "0x1F73440", VA = "0x181F74240")]
	private void HAPNGBAEBNA(LinkedListNode<DBDGNICINLN> LNJFPGADGBO, TVal FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F75860", Offset = "0x1F74A60", VA = "0x181F75860")]
	private void NGEDLHPEMJP(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F75440", Offset = "0x1F74640", VA = "0x181F75440")]
	private void JMCCAPCGIFI(DBDGNICINLN CEPDMCOICON, TVal FPEGOFLFPHJ, int HBBFBJDJKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class BBIFAGPELIA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> NHOGENNANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> NMEIHNMDFNA;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CA80", Offset = "0x1F6BC80", VA = "0x181F6CA80", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1CE19F0", Offset = "0x1CE0BF0", VA = "0x181CE19F0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E3DA50", Offset = "0x3E3CC50", VA = "0x183E3DA50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x234B800", Offset = "0x234AA00", VA = "0x18234B800", Slot = "11")]
	public void Add(T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D480", Offset = "0x3E3C680", VA = "0x183E3D480")]
	public bool PJJKMDOPJFF(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D7A0", Offset = "0x3E3C9A0", VA = "0x183E3D7A0", Slot = "15")]
	public bool Remove(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AED1E0", Offset = "0x3AEC3E0", VA = "0x183AED1E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2399FD0", Offset = "0x23991D0", VA = "0x182399FD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D0C0", Offset = "0x3E3C2C0", VA = "0x183E3D0C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x23474B0", Offset = "0x23466B0", VA = "0x1823474B0", Slot = "13")]
	public bool Contains(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D120", Offset = "0x3E3C320", VA = "0x183E3D120", Slot = "14")]
	public void CopyTo(T[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x35E56E0", Offset = "0x35E48E0", VA = "0x1835E56E0", Slot = "6")]
	public int IndexOf(T KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D150", Offset = "0x3E3C350", VA = "0x183E3D150", Slot = "7")]
	public void Insert(int BELCAJFDAHD, T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D6D0", Offset = "0x3E3C8D0", VA = "0x183E3D6D0", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D2E0", Offset = "0x3E3C4E0", VA = "0x183E3D2E0")]
	public void LCGKNLKJPOD(Predicate<T> LBFFHLHDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D5D0", Offset = "0x3E3C7D0", VA = "0x183E3D5D0")]
	public void POJEELMDDHA(Comparison<T> GLABACABLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D8B0", Offset = "0x3E3CAB0", VA = "0x183E3D8B0")]
	public BBIFAGPELIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OIPEDCJNKPC
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6357560", Offset = "0x6356760", VA = "0x186357560")]
	public static Vector3 JCJGFBMOFOI(this GameObject OOKBNBHDPPG, float HEOCGFACHJE)
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
			[Cpp2IlInjected.Address(RVA = "0x2AB4740", Offset = "0x2AB3940", VA = "0x182AB4740")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6359660", Offset = "0x6358860", VA = "0x186359660")]
		public SerializedGuid(in Guid JHHPNHDNIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6359180", Offset = "0x6358380", VA = "0x186359180")]
		public static SerializedGuid ANDCPBJPFDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x63593D0", Offset = "0x63585D0", VA = "0x1863593D0")]
		public static SerializedGuid GHNFBOLKIAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6359470", Offset = "0x6358670", VA = "0x186359470")]
		public bool LBAPGGCGMJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6359630", Offset = "0x6358830", VA = "0x186359630", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6359590", Offset = "0x6358790", VA = "0x186359590", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6359500", Offset = "0x6358700", VA = "0x186359500")]
		public bool MHAKOGLEHCF(in Guid JHHPNHDNIID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6359240", Offset = "0x6358440", VA = "0x186359240", Slot = "7")]
		public bool Equals(SerializedGuid IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x63592F0", Offset = "0x63584F0", VA = "0x1863592F0", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6359460", Offset = "0x6358660", VA = "0x186359460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6359210", Offset = "0x6358410", VA = "0x186359210", Slot = "6")]
		public int CompareTo(SerializedGuid IHIJPIJNLJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KGAHMPONAEO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type HMCFOOEHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string JIOJAMDNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool AJCNCODPLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool FEPAIJABKPB;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x63546F0", Offset = "0x63538F0", VA = "0x1863546F0")]
	public KGAHMPONAEO(Type NLICPLBEHKH, string CELGNCCMEMG, bool EJJGFHPEBEP = false, bool CHDBBMFINBB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface MGALIDPAIPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface OALNAIIMFOB<T> : MGALIDPAIPH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DBOCGLGOLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string PGEKAPMFDAO
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
	global::OALNAIIMFOB<T> DOMKPKPOLGE(Action<T> ENAOKCIKOHA);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OALNAIIMFOB<T> HAJAADMAJJJ(Action<T> ENAOKCIKOHA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::OALNAIIMFOB<T> DACKOADOFDA(Action<T, T> EOPHMAOEMMJ);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::OALNAIIMFOB<T> DLOLAOLJEOG(Action<T, T> EOPHMAOEMMJ);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::OALNAIIMFOB<T> JCPOKIKALJL(Action<string> ADHNHGBFKDN);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OALNAIIMFOB<T> BPFGDPMEDFD(Action<string> ADHNHGBFKDN);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JCBAPIENNBE<T> : global::OALNAIIMFOB<T>, MGALIDPAIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::NKKFEABOGLC<T, T> ADEIMNLHEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::KOEHNDLKDFN<T> FAMEHELBDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::KOEHNDLKDFN<string> OOALHDENLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string GNLLAOFLEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T APCBFLNDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool KLOBKBIEICL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2356910", Offset = "0x2355B10", VA = "0x182356910", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DBOCGLGOLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x792540", Offset = "0x791740", VA = "0x180792540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string PGEKAPMFDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x239EB00", Offset = "0x239DD00", VA = "0x18239EB00", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x30C7930", Offset = "0x30C6B30", VA = "0x1830C7930")]
	private void IPPIKBINFON(T KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x30C7880", Offset = "0x30C6A80", VA = "0x1830C7880")]
	private void IMDIAFIKPEI(string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x30C7780", Offset = "0x30C6980", VA = "0x1830C7780")]
	public void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x30C7650", Offset = "0x30C6850", VA = "0x1830C7650", Slot = "6")]
	public global::OALNAIIMFOB<T> DACKOADOFDA(Action<T, T> EOPHMAOEMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x30C76A0", Offset = "0x30C68A0", VA = "0x1830C76A0", Slot = "7")]
	public global::OALNAIIMFOB<T> DLOLAOLJEOG(Action<T, T> EOPHMAOEMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x30C76F0", Offset = "0x30C68F0", VA = "0x1830C76F0", Slot = "4")]
	public global::OALNAIIMFOB<T> DOMKPKPOLGE(Action<T> EOPHMAOEMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x30C7830", Offset = "0x30C6A30", VA = "0x1830C7830", Slot = "5")]
	public global::OALNAIIMFOB<T> HAJAADMAJJJ(Action<T> ENAOKCIKOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x30C79D0", Offset = "0x30C6BD0", VA = "0x1830C79D0", Slot = "8")]
	public global::OALNAIIMFOB<T> JCPOKIKALJL(Action<string> ADHNHGBFKDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x30C75E0", Offset = "0x30C67E0", VA = "0x1830C75E0", Slot = "9")]
	public global::OALNAIIMFOB<T> BPFGDPMEDFD(Action<string> ADHNHGBFKDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x30C7A70", Offset = "0x30C6C70", VA = "0x1830C7A70")]
	public JCBAPIENNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NHGBKAHFIGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CJGHBLGKAII<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::OALNAIIMFOB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::ACKLAEJEFDC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public CJGHBLGKAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B03010", Offset = "0x2B02210", VA = "0x182B03010")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A9D0", Offset = "0x2D49BD0", VA = "0x182D4A9D0")]
	public static global::HCPIAAEIKCB<T> HNFKECKMLCA<T>(this global::OALNAIIMFOB<T> ALEGDJMMPIJ, Action<T> IGAMPECHIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NEKDBCPDAGF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct FJAAKIDABOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long AGIKNLKPKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long CIFLBMEEAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int GEJGIFKJKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int DEKKDMGDHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool KDPIPFJCNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string BLLLMFLEANI;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x23ACA10", Offset = "0x23ABC10", VA = "0x1823ACA10")]
		public FJAAKIDABOG(long AGIKNLKPKBN, int GEJGIFKJKDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x23ACA80", Offset = "0x23ABC80", VA = "0x1823ACA80")]
		public FJAAKIDABOG(long AGIKNLKPKBN, long CIFLBMEEAIK, int GEJGIFKJKDE, int DEKKDMGDHBN, bool KDPIPFJCNKO, string BLLLMFLEANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x23AC8E0", Offset = "0x23ABAE0", VA = "0x1823AC8E0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void GACGIMAKPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x23AC950", Offset = "0x23ABB50", VA = "0x1823AC950")]
		public int HHKGEJOLKLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x23AC8C0", Offset = "0x23ABAC0", VA = "0x1823AC8C0")]
		public int CIEMEPEKCBL(int OMLHGKAPFFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x23AC9A0", Offset = "0x23ABBA0", VA = "0x1823AC9A0")]
		public double PAOPMBMPAPO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x23AC830", Offset = "0x23ABA30", VA = "0x1823AC830")]
		public FJAAKIDABOG AFNJJILHOLA(long CIFLBMEEAIK, int DEKKDMGDHBN)
		{
			return default(FJAAKIDABOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class IBIDBCAPHMG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey EGNKEKCMBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::NEKDBCPDAGF<TKey> HHEDADBLDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<IBIDBCAPHMG> FLEAFNDAOGA;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string ODFCEFCJIOM
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x254EB40", Offset = "0x254DD40", VA = "0x18254EB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2F53A70", Offset = "0x2F52C70", VA = "0x182F53A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<IBIDBCAPHMG> LILCAAEDFCG
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x34320B0", Offset = "0x34312B0", VA = "0x1834320B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public FJAAKIDABOG EMOEBNEKHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xFBDE10", Offset = "0xFBD010", VA = "0x180FBDE10")]
			[CompilerGenerated]
			get
			{
				return default(FJAAKIDABOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x3432280", Offset = "0x3431480", VA = "0x183432280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x34324A0", Offset = "0x34316A0", VA = "0x1834324A0")]
		internal IBIDBCAPHMG(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, TKey EBOEHIFNNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x34322B0", Offset = "0x34314B0", VA = "0x1834322B0")]
		public IBIDBCAPHMG KBFAMICJOCG(TKey EBOEHIFNNLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x34323C0", Offset = "0x34315C0", VA = "0x1834323C0")]
		public void PEGNHJMNEDP(TKey EBOEHIFNNLM, Action<IBIDBCAPHMG> GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1CE76A0", Offset = "0x1CE68A0", VA = "0x181CE76A0")]
		public T PEGNHJMNEDP<T>(TKey EBOEHIFNNLM, Func<IBIDBCAPHMG, T> NLNOCEEAFDB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7530", Offset = "0x1CE6730", VA = "0x181CE7530")]
		[AsyncStateMachine(typeof(JMBIDELFEAK))]
		public Task<T> FEGADBBIBFF<T>(TKey EBOEHIFNNLM, Func<IBIDBCAPHMG, Task<T>> NLNOCEEAFDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x34320D0", Offset = "0x34312D0", VA = "0x1834320D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ONFHHHNBIHB : IEnumerable<(TKey, List<TKey>, FJAAKIDABOG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FJAAKIDABOG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, FJAAKIDABOG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::NEKDBCPDAGF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, FJAAKIDABOG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, FJAAKIDABOG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2653800", Offset = "0x2652A00", VA = "0x182653800", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FJAAKIDABOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2653870", Offset = "0x2652A70", VA = "0x182653870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2653920", Offset = "0x2652B20", VA = "0x182653920")]
		[DebuggerHidden]
		public ONFHHHNBIHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x264BFC0", Offset = "0x264B1C0", VA = "0x18264BFC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2653490", Offset = "0x2652690", VA = "0x182653490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x26538D0", Offset = "0x2652AD0", VA = "0x1826538D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2653830", Offset = "0x2652A30", VA = "0x182653830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2653740", Offset = "0x2652940", VA = "0x182653740", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FJAAKIDABOG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1CD1160", Offset = "0x1CD0360", VA = "0x181CD1160", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class OANEPPHKJFC : IEnumerable<(TKey, List<TKey>, FJAAKIDABOG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FJAAKIDABOG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, FJAAKIDABOG timerEntry) <>2__current;

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
		private IBIDBCAPHMG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IBIDBCAPHMG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::NEKDBCPDAGF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<IBIDBCAPHMG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, FJAAKIDABOG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, FJAAKIDABOG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2653800", Offset = "0x2652A00", VA = "0x182653800", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FJAAKIDABOG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2BA98D0", Offset = "0x2BA8AD0", VA = "0x182BA98D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2653920", Offset = "0x2652B20", VA = "0x182653920")]
		[DebuggerHidden]
		public OANEPPHKJFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9930", Offset = "0x2BA8B30", VA = "0x182BA9930", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9210", Offset = "0x2BA8410", VA = "0x182BA9210", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2BA99D0", Offset = "0x2BA8BD0", VA = "0x182BA99D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9A30", Offset = "0x2BA8C30", VA = "0x182BA9A30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9890", Offset = "0x2BA8A90", VA = "0x182BA9890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2BA97B0", Offset = "0x2BA89B0", VA = "0x182BA97B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FJAAKIDABOG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2684E80", Offset = "0x2684080", VA = "0x182684E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, FJAAKIDABOG> POIIAKAPAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, FJAAKIDABOG> HALNCOMALDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::NEKDBCPDAGF<TKey>> NMFJJDHGGIH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string JHBEOBJPDBD = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly IBIDBCAPHMG BLFEOFLBDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool NPIEAKJHFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int JBKEGCAOCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch FFELKINKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int OIGCEHCCOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string CNEBFHGGJJD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IBIDBCAPHMG HHHJJNFNNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string ODFCEFCJIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C70D0", Offset = "0x6C62D0", VA = "0x1806C70D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B67240", Offset = "0x2B66440", VA = "0x182B67240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long OOOGFDBMHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B672C0", Offset = "0x2B664C0", VA = "0x182B672C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int ADNNJNMDHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B67210", Offset = "0x2B66410", VA = "0x182B67210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B672E0", Offset = "0x2B664E0", VA = "0x182B672E0")]
	public NEKDBCPDAGF(TKey MFKNILKDMKP, [Optional] int? GEJGIFKJKDE, [Optional][CanBeNull] Stopwatch FFELKINKGLC, [Optional] Action<TKey, FJAAKIDABOG> POIIAKAPAGJ, [Optional] Action<TKey, FJAAKIDABOG> HALNCOMALDH, [Optional] Action<global::NEKDBCPDAGF<TKey>> NMFJJDHGGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B67100", Offset = "0x2B66300", VA = "0x182B67100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B66F80", Offset = "0x2B66180", VA = "0x182B66F80")]
	public void AFODNHEHIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B672A0", Offset = "0x2B664A0", VA = "0x182B672A0")]
	public void HHGHNCHKNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2B67070", Offset = "0x2B66270", VA = "0x182B67070")]
	[IteratorStateMachine(typeof(global::NEKDBCPDAGF<>.ONFHHHNBIHB))]
	public IEnumerable<(TKey, List<TKey>, FJAAKIDABOG)> APIJFAKAMEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2B66FA0", Offset = "0x2B661A0", VA = "0x182B66FA0")]
	[IteratorStateMachine(typeof(global::NEKDBCPDAGF<>.OANEPPHKJFC))]
	private IEnumerable<(TKey, List<TKey>, FJAAKIDABOG)> APIJFAKAMEC(List<TKey> BENGLHDIHMD, IBIDBCAPHMG LAJGOLIDBHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2B67190", Offset = "0x2B66390", VA = "0x182B67190")]
	private (long, int) FFIGBGBIJIB()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class FOCIFMEKBHD<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	protected FOCIFMEKBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class KCMCCJCHJNG<TKey> : global::FOCIFMEKBHD<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string IBBFHLKLAGJ(TKey EBOEHIFNNLM);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2343640", Offset = "0x2342840", VA = "0x182343640")]
	protected string PLLDIIHGKNE(double MCMFMFMGLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x23433C0", Offset = "0x23425C0", VA = "0x1823433C0")]
	protected string CCGKKFOMFHM(int ONAAJNMAJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2343420", Offset = "0x2342620", VA = "0x182343420")]
	private static string ELFNJLCHHPL(TKey EBOEHIFNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2343590", Offset = "0x2342790", VA = "0x182343590", Slot = "4")]
	public override string OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2343460", Offset = "0x2342660", VA = "0x182343460")]
	public string OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, [NotNull] IBBFHLKLAGJ JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BDADEAIOMOJ(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, [NotNull] IBBFHLKLAGJ JDJHIFPLGNN);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1F673F0", Offset = "0x1F665F0", VA = "0x181F673F0")]
	protected KCMCCJCHJNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class OFPPPNHOLLI<TKey> : global::FOCIFMEKBHD<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string IFFMFMIPFCL(TKey EBOEHIFNNLM);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int IBFLFBOHCBG = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string GBICJNFHDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double LOHHPIBJLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool IAMLAJCBEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int KNHMENPJIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> OCNEEPLLLBJ;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x381DEA0", Offset = "0x381D0A0", VA = "0x18381DEA0")]
	private static string ELFNJLCHHPL(TKey EBOEHIFNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x381E760", Offset = "0x381D960", VA = "0x18381E760")]
	public OFPPPNHOLLI(string GBICJNFHDGA = "F2", double LOHHPIBJLAB = double.MaxValue, bool IAMLAJCBEKB = false, int KNHMENPJIBG = int.MaxValue, [Optional] ISet<string> OCNEEPLLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x381E6B0", Offset = "0x381D8B0", VA = "0x18381E6B0", Slot = "4")]
	public override Dictionary<string, string> OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x381E090", Offset = "0x381D290", VA = "0x18381E090")]
	private bool KIKFGGMBGMM(string HAOEMAHMLJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x381E170", Offset = "0x381D370", VA = "0x18381E170")]
	public Dictionary<string, string> OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, IFFMFMIPFCL JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x381DEE0", Offset = "0x381D0E0", VA = "0x18381DEE0")]
	private string JFKGBFJFDPP(StringBuilder ECHJJCHBKGC, List<TKey> JCBKMBBBINF, IFFMFMIPFCL JDJHIFPLGNN, bool CKDFAEKFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x381DD20", Offset = "0x381CF20", VA = "0x18381DD20")]
	private static void EFFPCIHDBIJ(StringBuilder CKIEOLNAAIJ, string LDMNBJAKKDE, bool PDBNCOLOBCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FKHEANCINAL<TKey> : global::KCMCCJCHJNG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct AENHINPJLAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public IBBFHLKLAGJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::FKHEANCINAL<TKey> HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int JNEBBFJBBCO = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] FGIBBCOPDNM;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x23B1FC0", Offset = "0x23B11C0", VA = "0x1823B1FC0")]
	private FKHEANCINAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x23B0EB0", Offset = "0x23B00B0", VA = "0x1823B0EB0", Slot = "5")]
	protected override string BDADEAIOMOJ(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, IBBFHLKLAGJ JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x23B1DD0", Offset = "0x23B0FD0", VA = "0x1823B1DD0")]
	[CompilerGenerated]
	internal static string PJHJBPGJLBH(string OCLDCFMHHBO, TKey EBOEHIFNNLM, ref AENHINPJLAH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class KNLJMFEKHHP<TKey> : global::KCMCCJCHJNG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NNBELGJFMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IBBFHLKLAGJ keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public NNBELGJFMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1CCF630", Offset = "0x1CCE830", VA = "0x181CCF630")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2356DC0", Offset = "0x2355FC0", VA = "0x182356DC0", Slot = "5")]
	protected override string BDADEAIOMOJ(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, IBBFHLKLAGJ JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x23576B0", Offset = "0x23568B0", VA = "0x1823576B0")]
	public KNLJMFEKHHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class JJIGCMKLMDK : global::NEKDBCPDAGF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class LIJPJKEOJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<JJIGCMKLMDK> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public LIJPJKEOJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6354760", Offset = "0x6353960", VA = "0x186354760")]
		internal void <Wrap>b__0(global::NEKDBCPDAGF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x63540A0", Offset = "0x63532A0", VA = "0x1863540A0")]
	public JJIGCMKLMDK([Optional] string HHHMCDPDAKB, [Optional] int? GEJGIFKJKDE, [Optional] Stopwatch FFELKINKGLC, [Optional] Action<string, FJAAKIDABOG> POIIAKAPAGJ, [Optional] Action<string, FJAAKIDABOG> HALNCOMALDH, [Optional] Action<JJIGCMKLMDK> NMFJJDHGGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6353FC0", Offset = "0x63531C0", VA = "0x186353FC0")]
	private static Action<global::NEKDBCPDAGF<string>> PEGNHJMNEDP(Action<JJIGCMKLMDK> IGAMPECHIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class IFDFHCOPJLI
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class LKKNPJCEHKD : IFDFHCOPJLI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static IFDFHCOPJLI HNEIEBONIJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x6354850", Offset = "0x6353A50", VA = "0x186354850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime JBNOJDFEAAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x6354800", Offset = "0x6353A00", VA = "0x186354800", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float FMIIHKKAPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x63547F0", Offset = "0x63539F0", VA = "0x1863547F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6354950", Offset = "0x6353B50", VA = "0x186354950")]
		public LKKNPJCEHKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static IFDFHCOPJLI DLCHBMDLAEI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static IFDFHCOPJLI HMBHBEDALCN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6353E30", Offset = "0x6353030", VA = "0x186353E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime JBNOJDFEAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float FMIIHKKAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	protected IFDFHCOPJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EMKGDHPGMPH : global::PMJJKANDPJE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x63532A0", Offset = "0x63524A0", VA = "0x1863532A0")]
	public EMKGDHPGMPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PMJJKANDPJE<T> : global::KDDHCJEKEOC<T>, HKCEDMFMCPJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> JDLFEMNJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task IPIPBJAONCF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1764C70", Offset = "0x1763E70", VA = "0x181764C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private PMOAFBNPLHC MCBFIENEHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CAB0", Offset = "0x1F6BCB0", VA = "0x181F6CAB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4547CF0", Offset = "0x4546EF0", VA = "0x184547CF0")]
	public PMJJKANDPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GGPAAAFILEH : global::DLFLJDAHOKP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6353680", Offset = "0x6352880", VA = "0x186353680")]
	public GGPAAAFILEH(Exception LBPJAILMLKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class DLFLJDAHOKP<T> : global::KDDHCJEKEOC<T>, HKCEDMFMCPJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> JDLFEMNJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task IPIPBJAONCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1764C70", Offset = "0x1763E70", VA = "0x181764C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private PMOAFBNPLHC MCBFIENEHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CAB0", Offset = "0x1F6BCB0", VA = "0x181F6CAB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2A18A90", Offset = "0x2A17C90", VA = "0x182A18A90")]
	public DLFLJDAHOKP(Exception LBPJAILMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface HKCEDMFMCPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task JDLFEMNJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	PMOAFBNPLHC NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface KDDHCJEKEOC<T> : HKCEDMFMCPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> JDLFEMNJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class JPDKBAIGBDI<TTask, T> : global::KDDHCJEKEOC<T>, HKCEDMFMCPJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class AIHMCCGDPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::JPDKBAIGBDI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public AIHMCCGDPED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool LNOPCMACCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> DLDNMMGIFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource BMLBNCLOPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool NPIEAKJHFPJ;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> JDLFEMNJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task IPIPBJAONCF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private PMOAFBNPLHC MCBFIENEHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x246D140", Offset = "0x246C340", VA = "0x18246D140", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A2C0", Offset = "0x2D994C0", VA = "0x182D9A2C0")]
	static JPDKBAIGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A5A0", Offset = "0x2D997A0", VA = "0x182D9A5A0")]
	protected JPDKBAIGBDI(TTask DLDNMMGIFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2D99EB0", Offset = "0x2D990B0", VA = "0x182D99EB0", Slot = "1")]
	~JPDKBAIGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2D99E80", Offset = "0x2D99080", VA = "0x182D99E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A0F0", Offset = "0x2D992F0", VA = "0x182D9A0F0")]
	private void MEDMFBCNDEL(bool MGLOCBABFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CLGGPKGDNCK(TTask NPDLLEIFPOH);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BLOMEJCJHEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface MOKBCDABHAA
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CODHJHFLGDA NGDDPGHLDGB;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class BNJMAHNLHOH : MOKBCDABHAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct APNICENGONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float MKFHLJKEIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float LOGLKLOEMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool HGGGGBFNODB;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float FAANOCEKAPG
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x63516F0", Offset = "0x63508F0", VA = "0x1863516F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6351880", Offset = "0x6350A80", VA = "0x186351880")]
		public APNICENGONC(float IDCHKLCNMBN, float HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6351700", Offset = "0x6350900", VA = "0x186351700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GIOOFCKCJBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public BNJMAHNLHOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public GIOOFCKCJBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int DOMGBHGFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int MMLKICDLBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly MOKBCDABHAA[] JCDLNEDKDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CODHJHFLGDA[] FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly APNICENGONC[] GHADDOLNNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private APNICENGONC ACEPLLGOHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly CINGNOEIMGI PJMABKGKPNI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public APNICENGONC CIDGCMPHAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4A7A2B0", Offset = "0x4A794B0", VA = "0x184A7A2B0")]
		get
		{
			return default(APNICENGONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x63522C0", Offset = "0x63514C0", VA = "0x1863522C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CODHJHFLGDA NGDDPGHLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6352200", Offset = "0x6351400", VA = "0x186352200", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x63522E0", Offset = "0x63514E0", VA = "0x1863522E0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x63523A0", Offset = "0x63515A0", VA = "0x1863523A0")]
	public BNJMAHNLHOH(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6352170", Offset = "0x6351370", VA = "0x186352170")]
	public CINGNOEIMGI KDFIEFKKMHJ(APNICENGONC LABCOKBJJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6351AF0", Offset = "0x6350CF0", VA = "0x186351AF0")]
	public void BLGFMDILEFB(MOKBCDABHAA IFOLDAANCOD, [Optional] APNICENGONC LNGDECOMGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6352120", Offset = "0x6351320", VA = "0x186352120")]
	internal int EDAEEPKFCFE(MOKBCDABHAA FKBBHHNBKCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6351F40", Offset = "0x6351140", VA = "0x186351F40")]
	internal APNICENGONC BMFBLEJMBIM(int BELCAJFDAHD)
	{
		return default(APNICENGONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6351F90", Offset = "0x6351190", VA = "0x186351F90", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void CODHJHFLGDA(float CJKLDKLIPFL);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class BGDFPCGBKMI
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float LHGJILDOHLF = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NIIKHKMAGIJ
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class HPGNMHMLHAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly MOKBCDABHAA FKBBHHNBKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly CODHJHFLGDA IGAMPECHIKO;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6353DA0", Offset = "0x6352FA0", VA = "0x186353DA0")]
		public HPGNMHMLHAM(MOKBCDABHAA FKBBHHNBKCO, CODHJHFLGDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6353D50", Offset = "0x6352F50", VA = "0x186353D50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x63557B0", Offset = "0x63549B0", VA = "0x1863557B0")]
	internal static bool OEDNEGNGAKO(float FAMKPEGNHFC, float GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x49D7B20", Offset = "0x49D6D20", VA = "0x1849D7B20")]
	internal static float JGLDIENJFPJ(float FAMKPEGNHFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x63556F0", Offset = "0x63548F0", VA = "0x1863556F0")]
	public static IDisposable CIDOBIEHMNO(this MOKBCDABHAA FKBBHHNBKCO, CODHJHFLGDA IGAMPECHIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CINGNOEIMGI : MOKBCDABHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float CJKLDKLIPFL;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1281E70", Offset = "0x1281070", VA = "0x181281E70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6352960", Offset = "0x6351B60", VA = "0x186352960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CODHJHFLGDA NGDDPGHLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6352A20", Offset = "0x6351C20", VA = "0x186352A20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6352AC0", Offset = "0x6351CC0", VA = "0x186352AC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public CINGNOEIMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class AEILGLBIKDD
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x634FF40", Offset = "0x634F140", VA = "0x18634FF40")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this ENAGGHAOLAL BHJMJJKKDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x634FED0", Offset = "0x634F0D0", VA = "0x18634FED0")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this ENAGGHAOLAL BHJMJJKKDOH, HashAlgorithmName IMHFNICJMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6350020", Offset = "0x634F220", VA = "0x186350020")]
	public static bool KKOKIOFELAC([CanBeNull] this ENAGGHAOLAL BHJMJJKKDOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63501B0", Offset = "0x634F3B0", VA = "0x1863501B0")]
	public static bool KKOKIOFELAC([CanBeNull] this ENAGGHAOLAL BHJMJJKKDOH, out string GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x634FFB0", Offset = "0x634F1B0", VA = "0x18634FFB0")]
	private static string KAPLPPJKPJM([CanBeNull] byte[] NPNCGJAPKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6350350", Offset = "0x634F550", VA = "0x186350350")]
	private static bool OJNANLHOMPH([NotNull] ENAGGHAOLAL BHJMJJKKDOH, [CanBeNull] out byte[] MBJPBHGMHCH, [CanBeNull] out byte[] JAPFOKIIDFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class LMCDJDMCNJB
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6355210", Offset = "0x6354410", VA = "0x186355210")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this APFDKEDKPKG KFDKPBACEBP, byte[] FOKLNJIODCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6355250", Offset = "0x6354450", VA = "0x186355250")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this APFDKEDKPKG KFDKPBACEBP, HashAlgorithmName IMHFNICJMAD, byte[] FOKLNJIODCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface APFDKEDKPKG
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JBFGBNAHGLM);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface ENAGGHAOLAL : APFDKEDKPKG
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] IABLLFHBBPI
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
	byte[] HEIICJFONGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object FBPPFAEANOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class AFPKFHLADAI
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class PEKOBOJFIJH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6357A10", Offset = "0x6356C10", VA = "0x186357A10")]
		public PEKOBOJFIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x63579B0", Offset = "0x6356BB0", VA = "0x1863579B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte EKNGCOLFJLI = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte ENODDIFDBHG = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> HBFNMECGFLJ;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool GJGIGNEJFGC;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x269EB50", Offset = "0x269DD50", VA = "0x18269EB50")]
	[Conditional("UNITY_EDITOR")]
	private static void JFEINKEKFBL<T>(params T[] NPADKDANDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x63513F0", Offset = "0x63505F0", VA = "0x1863513F0")]
	public static IDisposable OKPECPHEMDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6351490", Offset = "0x6350690", VA = "0x186351490")]
	public static void PBBGPJFBGCA(this IncrementalHash LCFEJBNGOGL, [CanBeNull] GameObject OOKBNBHDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x269F5C0", Offset = "0x269E7C0", VA = "0x18269F5C0")]
	public static void PBBGPJFBGCA<T>(this IncrementalHash LCFEJBNGOGL, [CanBeNull] T BGHFDNDJKMA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x269EE40", Offset = "0x269E040", VA = "0x18269EE40")]
	public static void LACDLJBNBFG<T>(this IncrementalHash LCFEJBNGOGL, [CanBeNull] T KFDKPBACEBP) where T : APFDKEDKPKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x269F690", Offset = "0x269E890", VA = "0x18269F690")]
	public static void PDGMBPCOHDJ<T>(this IncrementalHash LCFEJBNGOGL, [CanBeNull] IList<T> JMHFAPKIONK) where T : APFDKEDKPKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63509E0", Offset = "0x634FBE0", VA = "0x1863509E0")]
	private static bool IJPBFOMBFEC([CanBeNull] APFDKEDKPKG KFDKPBACEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6350580", Offset = "0x634F780", VA = "0x186350580")]
	public static void AJLJMJHJLDL(this IncrementalHash JBFGBNAHGLM, [CanBeNull] string JANIMIPHCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6350A70", Offset = "0x634FC70", VA = "0x186350A70")]
	public static void JIFJCFNJFCF(this IncrementalHash JBFGBNAHGLM, long CLJILDJGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6351050", Offset = "0x6350250", VA = "0x186351050")]
	public static void MHFIBNODIPM(this IncrementalHash JBFGBNAHGLM, int FNDBFJAJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6350E80", Offset = "0x6350080", VA = "0x186350E80")]
	public static void MELGLIJBLIB(this IncrementalHash JBFGBNAHGLM, short NGODBMKMKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6351220", Offset = "0x6350420", VA = "0x186351220")]
	public static void NIJHGEIAENH(this IncrementalHash JBFGBNAHGLM, byte KBIBJDBKOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6350C40", Offset = "0x634FE40", VA = "0x186350C40")]
	public static void KMPLICCDBIO(this IncrementalHash JBFGBNAHGLM, bool AEPOPKPJCOE, bool DCCOHNBHFGM = false, bool NHGPEANGCPA = false, bool NHIMDBJFFFO = false, bool MHHIDBABAGG = false, bool DFLFKOIGHOI = false, bool AOAKIEFDEOJ = false, bool BHCHKIPNEHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x269EED0", Offset = "0x269E0D0", VA = "0x18269EED0")]
	public static void LIBLNFGGGFL<T>(this IncrementalHash JBFGBNAHGLM, T DMFNAHIEMBA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6351390", Offset = "0x6350590", VA = "0x186351390")]
	public static void OJPLBKDPNPB(this IncrementalHash JBFGBNAHGLM, float OFACBICCAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6351580", Offset = "0x6350780", VA = "0x186351580")]
	public static void PFEOBKPLOPL(this IncrementalHash JBFGBNAHGLM, double FGIDAJOEDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6350E10", Offset = "0x6350010", VA = "0x186350E10")]
	public static void LBJHJOILCHM(this IncrementalHash JBFGBNAHGLM, ulong KIALGBJEAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6350980", Offset = "0x634FB80", VA = "0x186350980")]
	public static void HAHDGCEAAIF(this IncrementalHash JBFGBNAHGLM, uint JOGIKMMLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6350910", Offset = "0x634FB10", VA = "0x186350910")]
	public static void EEAJOLIDOCN(this IncrementalHash JBFGBNAHGLM, ushort KBOOAFCFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63505E0", Offset = "0x634F7E0", VA = "0x1863505E0")]
	public static void CCLCBNGGAOB(this IncrementalHash JBFGBNAHGLM, Vector3 EEFGELIHOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6350750", Offset = "0x634F950", VA = "0x186350750")]
	public static void DKDPLAAKGME(this IncrementalHash JBFGBNAHGLM, Quaternion KJHIGMBMAAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GLDMLLCBCHB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type HMCFOOEHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string JIOJAMDNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool AJCNCODPLGP;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6353760", Offset = "0x6352960", VA = "0x186353760")]
	public GLDMLLCBCHB(Type NLICPLBEHKH, string CELGNCCMEMG, bool EJJGFHPEBEP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NLNCEFPHMPB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x63568A0", Offset = "0x6355AA0", VA = "0x1863568A0")]
	public NLNCEFPHMPB(string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6356820", Offset = "0x6355A20", VA = "0x186356820")]
	public NLNCEFPHMPB(string DENPJAMCNLD, Exception LOPPGFLFDNH)
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
			[Cpp2IlInjected.Address(RVA = "0x6C7040", Offset = "0x6C6240", VA = "0x1806C7040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6DD790", Offset = "0x6DC990", VA = "0x1806DD790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int BHOLCDOGKAG, int CLEANIGJHKK]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3B59C90", Offset = "0x3B58E90", VA = "0x183B59C90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3B59D30", Offset = "0x3B58F30", VA = "0x183B59D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B59C00", Offset = "0x3B58E00", VA = "0x183B59C00")]
		public Array2D(uint HMEFMFINFBK, uint OELIKJHOPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B59B80", Offset = "0x3B58D80", VA = "0x183B59B80")]
		public void FPNLAFLJCKH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x63519C0", Offset = "0x6350BC0", VA = "0x1863519C0")]
		public Array2DVector3(uint HMEFMFINFBK, uint OELIKJHOPLF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LLCHHDIIONL
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool LLEANIBKGCP(string GHMEDKLCOJI, LLCHHDIIONL COHNKJDFFCP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int DMFNAHIEMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string IGIHBIGMNMI;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x63549B0", Offset = "0x6353BB0", VA = "0x1863549B0")]
	public static Dictionary<string, LLCHHDIIONL> IAIOEEKBGKI(Type IKGFLIHEFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6354CA0", Offset = "0x6353EA0", VA = "0x186354CA0")]
	public static Dictionary<string, LLCHHDIIONL> ILMBEDJDCFH(Type IKGFLIHEFNM, LLEANIBKGCP CEEALNPBOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6354FD0", Offset = "0x63541D0", VA = "0x186354FD0")]
	public static Dictionary<int, string> JEJEMLFDDGN(Dictionary<string, LLCHHDIIONL> GEMNKBDIDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class IDNGODILFMO
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int KFEDDPHALBE = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int ELKLMHMNDPN = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class DMAGMEFKJPD<THandle, TValue> : IDisposable where THandle : struct, IGCGKLPONMN where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<THandle> OFODIKGIPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<TValue> NEAFDAHPCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Func<TValue> PGFOLDPKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Action<TValue> NLOIHLKPOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int HJJGIOCLLNI;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2351930", Offset = "0x2350B30", VA = "0x182351930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A1CA10", Offset = "0x2A1BC10", VA = "0x182A1CA10")]
	public DMAGMEFKJPD(Action<TValue> NLOIHLKPOII, [Optional] Func<TValue> PGFOLDPKJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C3C0", Offset = "0x2A1B5C0", VA = "0x182A1C3C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C1A0", Offset = "0x2A1B3A0", VA = "0x182A1C1A0")]
	public THandle BFPHDDBHNEE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C080", Offset = "0x2A1B280", VA = "0x182A1C080")]
	public THandle AOHLLDNPMGN(TValue JFBPNBNBHOE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C0F0", Offset = "0x2A1B2F0", VA = "0x182A1C0F0")]
	public bool BCBAFCFKBLF(THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BE90", Offset = "0x2A1B090", VA = "0x182A1BE90")]
	public bool ACJHDFNHANL(THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C580", Offset = "0x2A1B780", VA = "0x182A1C580")]
	public bool GIGJNHOBOLH(THandle KJNCDAGJAPF, out TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C770", Offset = "0x2A1B970", VA = "0x182A1C770")]
	public TValue JLPNHBINJFC(THandle KJNCDAGJAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C4A0", Offset = "0x2A1B6A0", VA = "0x182A1C4A0")]
	public bool EOKNMHALCBJ(THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C550", Offset = "0x2A1B750", VA = "0x182A1C550")]
	private THandle FDJHBNGAEOB(int BELCAJFDAHD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C6F0", Offset = "0x2A1B8F0", VA = "0x182A1C6F0")]
	private TValue HNFKECKMLCA(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C380", Offset = "0x2A1B580", VA = "0x182A1C380")]
	private void CCNLBODNLNK(int BELCAJFDAHD, in THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C730", Offset = "0x2A1B930", VA = "0x182A1C730")]
	private void IPPIKBINFON(int BELCAJFDAHD, in TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C900", Offset = "0x2A1BB00", VA = "0x182A1C900")]
	private THandle PALHANMFGMC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C7D0", Offset = "0x2A1B9D0", VA = "0x182A1C7D0")]
	private void KHPJFLPBAPH(THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C720", Offset = "0x2A1B920", VA = "0x182A1C720")]
	private int IEFOOMJNBIG(int FLPPPNDNNNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C7C0", Offset = "0x2A1B9C0", VA = "0x182A1C7C0")]
	private bool KEIIKGBICPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x72E640", Offset = "0x72D840", VA = "0x18072E640")]
	private void HFFHGOCAHBC(THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C880", Offset = "0x2A1BA80", VA = "0x182A1C880")]
	private bool KKNONGPIPHG(out THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C620", Offset = "0x2A1B820", VA = "0x182A1C620")]
	private bool HFGFOPNNMHJ(out THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C440", Offset = "0x2A1B640", VA = "0x182A1C440")]
	private void EHFLHMNOIEE(THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A1BF60", Offset = "0x2A1B160", VA = "0x182A1BF60")]
	private void ADPPKBDIBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface IGCGKLPONMN
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int DMLEMNEAJDL
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
public interface BDDOIGLJFOK<T> : IGCGKLPONMN, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class AFEKOGJJCGM
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xCE5680", Offset = "0xCE4880", VA = "0x180CE5680")]
	public static bool JBLGPDCHNCE<T>(this T KJNCDAGJAPF, T IHIJPIJNLJM) where T : struct, IGCGKLPONMN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x269EB40", Offset = "0x269DD40", VA = "0x18269EB40")]
	public static bool HGGGGBFNODB<T>(this T KJNCDAGJAPF) where T : struct, IGCGKLPONMN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6350470", Offset = "0x634F670", VA = "0x186350470")]
	public static string DPANOHEKMNP(this IGCGKLPONMN KJNCDAGJAPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class NJJKLJNMLFD
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum KMNLOMEIIIA : byte
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
	private int JBFGBNAHGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool KGPDAGOOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private KMNLOMEIIIA BGHMFEPCABE;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool FLDDEHNHNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x63563C0", Offset = "0x63555C0", VA = "0x1863563C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool GBECMOGKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x63558C0", Offset = "0x6354AC0", VA = "0x1863558C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6356720", Offset = "0x6355920", VA = "0x186356720")]
	public NJJKLJNMLFD(bool KGPDAGOOCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6355D40", Offset = "0x6354F40", VA = "0x186355D40")]
	public void IFFNIDAFKKE(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6356610", Offset = "0x6355810", VA = "0x186356610")]
	public void OKAJIOIFACM(int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x63563D0", Offset = "0x63555D0", VA = "0x1863563D0")]
	public void INHHJPJHCNH(uint FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x63564C0", Offset = "0x63556C0", VA = "0x1863564C0")]
	public void LKDKNCDAGCI(bool BGCBODNMJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6355950", Offset = "0x6354B50", VA = "0x186355950")]
	public void GNIAHJGIDEB(long FLPONIKCHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6355990", Offset = "0x6354B90", VA = "0x186355990")]
	public void IBMLKELFBHP(ulong ICOIOJAFHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63558D0", Offset = "0x6354AD0", VA = "0x1863558D0")]
	public void EDJIMIEPDOC(string IGMDKJEALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6355830", Offset = "0x6354A30", VA = "0x186355830")]
	public void AABLDCHOGOC(Enum LBPJAILMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x63564E0", Offset = "0x63556E0", VA = "0x1863564E0")]
	public void LKOGDHBBODE(IList NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C370", Offset = "0x2D4B570", VA = "0x182D4C370")]
	public void PAGGCFFEJKM<T, U>(Dictionary<T, U> PNHOLEPOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x63559D0", Offset = "0x6354BD0", VA = "0x1863559D0")]
	private void IDCCFDKBKCB(IDictionary PNHOLEPOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x63566B0", Offset = "0x63558B0", VA = "0x1863566B0")]
	public int PGCEGNGINJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x63563E0", Offset = "0x63555E0", VA = "0x1863563E0")]
	public short JNIIBCCKCPJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6355940", Offset = "0x6354B40", VA = "0x186355940")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6356450", Offset = "0x6355650", VA = "0x186356450")]
	private void KBNKOKFKHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class ABGBPKLPFIF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class DDCOEKBIIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode PKCJMFFNILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode GPFONCECPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public MPDELGLAEDI JHMACGKJPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<MPDELGLAEDI> JDCAFEIJIPB;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public DDCOEKBIIPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct MPDELGLAEDI : IComparable<MPDELGLAEDI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int GPAIJDKOODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public TClaimant ONJGKHCHKAP;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6F20B0", Offset = "0x6F12B0", VA = "0x1806F20B0")]
		public MPDELGLAEDI(int GPAIJDKOODN, TClaimant ONJGKHCHKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3088030", Offset = "0x3087230", VA = "0x183088030")]
		public bool ACPJANCMILI(in MPDELGLAEDI IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x30880A0", Offset = "0x30872A0", VA = "0x1830880A0")]
		public bool GCIBNLALCNP(in MPDELGLAEDI IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3088090", Offset = "0x3087290", VA = "0x183088090", Slot = "4")]
		public int CompareTo(MPDELGLAEDI IHIJPIJNLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x30880B0", Offset = "0x30872B0", VA = "0x1830880B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum KBPJPPAABNK
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class KMLBIKBIBHE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::ABGBPKLPFIF<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2355D10", Offset = "0x2354F10", VA = "0x182355D10")]
		[DebuggerHidden]
		public KMLBIKBIBHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2355B10", Offset = "0x2354D10", VA = "0x182355B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2355CD0", Offset = "0x2354ED0", VA = "0x182355CD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2355BF0", Offset = "0x2354DF0", VA = "0x182355BF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2355820", Offset = "0x2354A20", VA = "0x182355820", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::HHAKGOLNCEJ<DDCOEKBIIPJ> GNIFCAPOLJC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::HHAKGOLNCEJ<List<MPDELGLAEDI>> GIJOPMNCIOC;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int OFLNHNPKAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TClaimant, TNode> KDOPCDJLPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TNode, DDCOEKBIIPJ> KGPOODCOIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private KBPJPPAABNK PDGDINPCGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode MODGPLDICAF(TNode MCFKDIFOJAH);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OEEEEGOKJCE(TNode MCFKDIFOJAH, TClaimant KIKOIBLODKP, TClaimant GEDDAPIAPCP);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x33E97E0", Offset = "0x33E89E0", VA = "0x1833E97E0")]
	public ABGBPKLPFIF(KBPJPPAABNK PDGDINPCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x33E8510", Offset = "0x33E7710", VA = "0x1833E8510")]
	public void DHCCFJOJPDP(TNode MCFKDIFOJAH, TNode DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x33E88E0", Offset = "0x33E7AE0", VA = "0x1833E88E0")]
	public void HMIFPFBDINB(TClaimant ONJGKHCHKAP, TNode HIEKNBNAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x33E8590", Offset = "0x33E7790", VA = "0x1833E8590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x33E8FF0", Offset = "0x33E81F0", VA = "0x1833E8FF0")]
	private void JOOBPJPGMJD(TClaimant ONJGKHCHKAP, TNode KFIAEHJPLMO, TNode HIEKNBNAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x33E87F0", Offset = "0x33E79F0", VA = "0x1833E87F0")]
	private int EHALJIFBDOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x33E8090", Offset = "0x33E7290", VA = "0x1833E8090")]
	private void BLKPIGADKKM(TClaimant ONJGKHCHKAP, TNode HNPABJHODAB, TNode OBMJAGNFCGF, int FPNOLPFEFHF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x33E8850", Offset = "0x33E7A50", VA = "0x1833E8850")]
	private void EHNNLIPBKBB(MPDELGLAEDI LLDJPODDJIM, DDCOEKBIIPJ CHHHJJOHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x33E9160", Offset = "0x33E8360", VA = "0x1833E9160")]
	private void MFJELCKLLHM(TClaimant ONJGKHCHKAP, TNode HNPABJHODAB, TNode OBMJAGNFCGF, int FPNOLPFEFHF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x33E8D50", Offset = "0x33E7F50", VA = "0x1833E8D50")]
	private void HPOFIHGJJDM(MPDELGLAEDI LLDJPODDJIM, TNode MCFKDIFOJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x33E93C0", Offset = "0x33E85C0", VA = "0x1833E93C0")]
	private void MMLCKHLEMOO(MPDELGLAEDI LLDJPODDJIM, DDCOEKBIIPJ CHHHJJOHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x33E8340", Offset = "0x33E7540", VA = "0x1833E8340")]
	private void CBMHNNCHLCJ(DDCOEKBIIPJ CHHHJJOHKAH, bool BDIIENFLABM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x33E89E0", Offset = "0x33E7BE0", VA = "0x1833E89E0")]
	private void HNFBJIKPBMH(DDCOEKBIIPJ CHHHJJOHKAH, TNode DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x33E9090", Offset = "0x33E8290", VA = "0x1833E9090")]
	[IteratorStateMachine(typeof(global::ABGBPKLPFIF<, >.KMLBIKBIBHE))]
	private IEnumerable<TNode> KKPNNFICENA(TNode HNPABJHODAB, TNode OBMJAGNFCGF, bool PLMCFKKECLN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x33E8450", Offset = "0x33E7650", VA = "0x1833E8450")]
	private DDCOEKBIIPJ DGABHIKAOAJ(TNode MCFKDIFOJAH, TNode GPFONCECPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x33E8E60", Offset = "0x33E8060", VA = "0x1833E8E60")]
	private DDCOEKBIIPJ JEHJDCDCEHI(TNode MCFKDIFOJAH, TNode GPFONCECPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x33E94C0", Offset = "0x33E86C0", VA = "0x1833E94C0")]
	private void PABGDDLIJFL(DDCOEKBIIPJ CHHHJJOHKAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class APIIJKMDDNE<T> : IEnumerable<global::APIIJKMDDNE<T>.KIDKIGHNFGJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct KIDKIGHNFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public T JFBPNBNBHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int BELCAJFDAHD;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class CHMFKIFBBBK : IEnumerator<KIDKIGHNFGJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private global::APIIJKMDDNE<T> KFCGKKLOJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x14F52E0", Offset = "0x14F44E0", VA = "0x1814F52E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public KIDKIGHNFGJ CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2AFA870", Offset = "0x2AF9A70", VA = "0x182AFA870", Slot = "4")]
			get
			{
				return default(KIDKIGHNFGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6CB060", Offset = "0x6CA260", VA = "0x1806CB060")]
		public CHMFKIFBBBK(global::APIIJKMDDNE<T> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA6B0", Offset = "0x2AF98B0", VA = "0x182AFA6B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6CB050", Offset = "0x6CA250", VA = "0x1806CB050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xC01E40", Offset = "0xC01040", VA = "0x180C01E40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct LKGJBJNKINM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool BMMBELIGAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T JFBPNBNBHOE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int DCFNPNDIGEP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<T, int> GDLEAIMFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private LKGJBJNKINM[] HFHOJJHOMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private int BPLLJGNFOAP;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int JCBGBNDIEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D90", Offset = "0x6E6F90", VA = "0x1806E7D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x85FD20", Offset = "0x85EF20", VA = "0x18085FD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CA80", Offset = "0x1F6BC80", VA = "0x181F6CA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3394E30", Offset = "0x3394030", VA = "0x183394E30")]
	public APIIJKMDDNE(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3394F10", Offset = "0x3394110", VA = "0x183394F10")]
	public APIIJKMDDNE(KIDKIGHNFGJ[] NHOGNDHLIKK, bool AMBLPFKLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x33948D0", Offset = "0x3393AD0", VA = "0x1833948D0")]
	public int OPAGCAMIPEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3393B60", Offset = "0x3392D60", VA = "0x183393B60")]
	private int BIGFJCLKJFF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3393B10", Offset = "0x3392D10", VA = "0x183393B10", Slot = "6")]
	protected virtual uint BFOAGILFNAM(uint JBFGBNAHGLM, T JFBPNBNBHOE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3393990", Offset = "0x3392B90", VA = "0x183393990")]
	public bool AHIFANOCFHG(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x33946B0", Offset = "0x33938B0", VA = "0x1833946B0")]
	public bool LMGDNPELKHM(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3394130", Offset = "0x3393330", VA = "0x183394130")]
	public bool GPEECKGOEKF(Func<T, bool> OCOPNGDLHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3393FA0", Offset = "0x33931A0", VA = "0x183393FA0")]
	public int BNBABBHNIFD(T JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3394200", Offset = "0x3393400", VA = "0x183394200")]
	public T HNFKECKMLCA(int BELCAJFDAHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3394000", Offset = "0x3393200", VA = "0x183394000")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3394B40", Offset = "0x3393D40", VA = "0x183394B40")]
	public bool PJJKMDOPJFF(T JFBPNBNBHOE, bool JPGEOMLDEBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3394940", Offset = "0x3393B40", VA = "0x183394940")]
	public bool PJJKMDOPJFF(T JFBPNBNBHOE, int BELCAJFDAHD, bool JPGEOMLDEBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3393A80", Offset = "0x3392C80", VA = "0x183393A80")]
	public bool BCBAFCFKBLF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3394360", Offset = "0x3393560", VA = "0x183394360")]
	public bool LDKAFBDIKPM(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3394700", Offset = "0x3393900", VA = "0x183394700")]
	private void LNMDDPEGOLO(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3394520", Offset = "0x3393720", VA = "0x183394520")]
	public KIDKIGHNFGJ[] LHBPEMIBDMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x33942C0", Offset = "0x33934C0", VA = "0x1833942C0")]
	private int KFHJOKBOAAP(int IIEPBAFMLKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x3394DB0", Offset = "0x3393FB0", VA = "0x183394DB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3394DB0", Offset = "0x3393FB0", VA = "0x183394DB0", Slot = "4")]
	private IEnumerator<KIDKIGHNFGJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct AMBDHPNCLNH<Handle> where Handle : IGCGKLPONMN, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct CEEENEPMIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly global::AMBDHPNCLNH<Handle> KCNKHHKBABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int JFOEPHAPCOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2AEDE60", Offset = "0x2AED060", VA = "0x182AEDE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle KJELKMEACHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2AED200", Offset = "0x2AEC400", VA = "0x182AED200")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE260", Offset = "0x2AED460", VA = "0x182AEE260")]
		public CEEENEPMIBE(global::AMBDHPNCLNH<Handle> KCNKHHKBABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDC80", Offset = "0x2AECE80", VA = "0x182AEDC80")]
		public CDEJAMICDDN GDHAFJANMPF(in CDEJAMICDDN IGJFJCHKKMF)
		{
			return default(CDEJAMICDDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDBE0", Offset = "0x2AECDE0", VA = "0x182AEDBE0")]
		public CPJNGBOBJMB GDHAFJANMPF(in CPJNGBOBJMB IGJFJCHKKMF)
		{
			return default(CPJNGBOBJMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2AED760", Offset = "0x2AEC960", VA = "0x182AED760")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDD70", Offset = "0x2AECF70", VA = "0x182AEDD70")]
		private int KBDOLLNBJDB(string DENPJAMCNLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2AED620", Offset = "0x2AEC820", VA = "0x182AED620")]
		private Handle CCPNAJKKIJC(string DENPJAMCNLD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct CDEJAMICDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private CEEENEPMIBE CNGPLNBDNJO;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3BD4150", Offset = "0x3BD3350", VA = "0x183BD4150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F3A0", Offset = "0x2F1E5A0", VA = "0x182F1F3A0")]
		public CDEJAMICDDN(global::AMBDHPNCLNH<Handle> KCNKHHKBABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F260", Offset = "0x2F1E460", VA = "0x182F1F260")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD40D0", Offset = "0x3BD32D0", VA = "0x183BD40D0")]
		public CDEJAMICDDN AHIPNMLLDNB()
		{
			return default(CDEJAMICDDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct CPJNGBOBJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private CEEENEPMIBE CNGPLNBDNJO;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2F1F360", Offset = "0x2F1E560", VA = "0x182F1F360")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F3A0", Offset = "0x2F1E5A0", VA = "0x182F1F3A0")]
		public CPJNGBOBJMB(global::AMBDHPNCLNH<Handle> KCNKHHKBABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F260", Offset = "0x2F1E460", VA = "0x182F1F260")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F120", Offset = "0x2F1E320", VA = "0x182F1F120")]
		public CPJNGBOBJMB AHIPNMLLDNB()
		{
			return default(CPJNGBOBJMB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> IFHEIOGEEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> MENALNAABHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int NBEIDPFFLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int KJHMDCLCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool HJEPHADFHBH;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3388720", Offset = "0x3387920", VA = "0x183388720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int NINNFJJMKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6C7010", Offset = "0x6C6210", VA = "0x1806C7010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FODEPNCFMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7010", Offset = "0x6C6210", VA = "0x1806C7010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public CDEJAMICDDN NBBOCJAFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x338A610", Offset = "0x3389810", VA = "0x18338A610")]
		get
		{
			return default(CDEJAMICDDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public CPJNGBOBJMB FMBLCKKJDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3387D20", Offset = "0x3386F20", VA = "0x183387D20")]
		get
		{
			return default(CPJNGBOBJMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x338C1E0", Offset = "0x338B3E0", VA = "0x18338C1E0")]
	public AMBDHPNCLNH(int LKPMBDDHJLN, Allocator OPBLDCCKGEG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x338B870", Offset = "0x338AA70", VA = "0x18338B870")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1D3A3C0", Offset = "0x1D395C0", VA = "0x181D3A3C0")]
	public static int IEFOOMJNBIG(int AEOKKHKBMBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3388540", Offset = "0x3387740", VA = "0x183388540")]
	public static bool CKJBAMBDBAJ(int AEOKKHKBMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x338C1D0", Offset = "0x338B3D0", VA = "0x18338C1D0")]
	public static bool PGCAGFKPGHH(int AEOKKHKBMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x338ABB0", Offset = "0x3389DB0", VA = "0x18338ABB0")]
	public bool JNNIBACKGDO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x338B690", Offset = "0x338A890", VA = "0x18338B690")]
	public bool LNEMALGLAAN(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3388080", Offset = "0x3387280", VA = "0x183388080")]
	public bool BMELDGHKLID(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x33893A0", Offset = "0x33885A0", VA = "0x1833893A0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void EBFKHKFHELL(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x338B260", Offset = "0x338A460", VA = "0x18338B260")]
	public Handle LFPJPDPDGFA()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x338A310", Offset = "0x3389510", VA = "0x18338A310")]
	public void GIEIEOBLMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x338AE70", Offset = "0x338A070", VA = "0x18338AE70")]
	public void LEGBHEDDNBM(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3387E70", Offset = "0x3387070", VA = "0x183387E70")]
	public bool AINNPHJCHFA(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80")]
	private bool OBLHGNNDMBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x338BB70", Offset = "0x338AD70", VA = "0x18338BB70")]
	private bool OAAGMJOOFBO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x33887E0", Offset = "0x33879E0", VA = "0x1833887E0")]
	private void DGNGLIHBGOD(out int BELCAJFDAHD, out int FLPPPNDNNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x338BD30", Offset = "0x338AF30", VA = "0x18338BD30")]
	private void OMGOGAJFPCD(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x338C0E0", Offset = "0x338B2E0", VA = "0x18338C0E0")]
	private void PBNHCDLIAPO(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x338A760", Offset = "0x3389960", VA = "0x18338A760")]
	private bool IHJCKAMMHKA(out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3388550", Offset = "0x3387750", VA = "0x183388550")]
	private static Handle CNGCEICEEDM(int BELCAJFDAHD, int FLPPPNDNNNB)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct JBJIOMDHKBO<Handle, T> where Handle : IGCGKLPONMN, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private global::AMBDHPNCLNH<Handle> ONOELOKBECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private T[] PLHNPENEFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Action<T> MDDBJCOLLEN;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x30C4E80", Offset = "0x30C4080", VA = "0x1830C4E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x30C4F30", Offset = "0x30C4130", VA = "0x1830C4F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x30C6150", Offset = "0x30C5350", VA = "0x1830C6150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x30C6060", Offset = "0x30C5260", VA = "0x1830C6060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x30C64C0", Offset = "0x30C56C0", VA = "0x1830C64C0")]
	public JBJIOMDHKBO(int LKPMBDDHJLN, [Optional] Action<T> MDDBJCOLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x30C6180", Offset = "0x30C5380", VA = "0x1830C6180")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x30C4580", Offset = "0x30C3780", VA = "0x1830C4580")]
	public bool BMELDGHKLID(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void EBFKHKFHELL(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x30C5680", Offset = "0x30C4880", VA = "0x1830C5680")]
	public T JLPNHBINJFC(Handle KJNCDAGJAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x30C5060", Offset = "0x30C4260", VA = "0x1830C5060")]
	public bool GIGJNHOBOLH(Handle KJNCDAGJAPF, out T ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x30C55E0", Offset = "0x30C47E0", VA = "0x1830C55E0")]
	public void HDECKBNAIGA(Handle KJNCDAGJAPF, T CIBNIAIDCIA, out T LILKDLOOKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x30C5370", Offset = "0x30C4570", VA = "0x1830C5370")]
	public void HDECKBNAIGA(Handle KJNCDAGJAPF, T CIBNIAIDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x30C4180", Offset = "0x30C3380", VA = "0x1830C4180")]
	public bool BFDDADMOHJF(Handle KJNCDAGJAPF, T CIBNIAIDCIA, out T LILKDLOOKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x30C40A0", Offset = "0x30C32A0", VA = "0x1830C40A0")]
	public bool BFDDADMOHJF(Handle KJNCDAGJAPF, T CIBNIAIDCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x30C3500", Offset = "0x30C2700", VA = "0x1830C3500")]
	public Handle AOHLLDNPMGN(T ADHHHFDPAPI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x30C5DD0", Offset = "0x30C4FD0", VA = "0x1830C5DD0")]
	public void LCGKNLKJPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30C3A80", Offset = "0x30C2C80", VA = "0x1830C3A80")]
	public void BCBAFCFKBLF(Handle KJNCDAGJAPF, out T LILKDLOOKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x30C3700", Offset = "0x30C2900", VA = "0x1830C3700")]
	public void BCBAFCFKBLF(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x30C4830", Offset = "0x30C3A30", VA = "0x1830C4830")]
	public bool BNBGIAPEJPA(Handle KJNCDAGJAPF, out T LILKDLOOKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x30C4750", Offset = "0x30C3950", VA = "0x1830C4750")]
	public bool BNBGIAPEJPA(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x30C6000", Offset = "0x30C5200", VA = "0x1830C6000")]
	private T LDKAFBDIKPM(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x30C4DB0", Offset = "0x30C3FB0", VA = "0x1830C4DB0")]
	private void CDEPEGAJOEL(int KFFPMHLOCGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class HHAKGOLNCEJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<T> KCNKHHKBABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<T> JGBPLHIGKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int MDGGJHOMJLF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int KINODLLBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x254EB40", Offset = "0x254DD40", VA = "0x18254EB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int HNKDMGLCKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x27EDA00", Offset = "0x27ECC00", VA = "0x1827EDA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5FD0", Offset = "0x2BE51D0", VA = "0x182BE5FD0")]
	public static global::HHAKGOLNCEJ<T> IBABHHJNEFB(int DOMGBHGFPFL = 0, int MDGGJHOMJLF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6380", Offset = "0x2BE5580", VA = "0x182BE6380")]
	public static global::HHAKGOLNCEJ<T> MMKDCHDPEMJ(int DOMGBHGFPFL = 0, int MDGGJHOMJLF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6450", Offset = "0x2BE5650", VA = "0x182BE6450")]
	public HHAKGOLNCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6490", Offset = "0x2BE5690", VA = "0x182BE6490")]
	public HHAKGOLNCEJ(int DOMGBHGFPFL, int MDGGJHOMJLF = int.MaxValue, bool PFMDOJMJBGP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5BF0", Offset = "0x2BE4DF0", VA = "0x182BE5BF0")]
	public T CFEAHEFCMFG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5E70", Offset = "0x2BE5070", VA = "0x182BE5E70")]
	public void FLEJEMANDND(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2BE62B0", Offset = "0x2BE54B0", VA = "0x182BE62B0")]
	private void KIFDAIOLDPH(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5F20", Offset = "0x2BE5120", VA = "0x182BE5F20")]
	private void GDFEPCNABMI(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5DF0", Offset = "0x2BE4FF0", VA = "0x182BE5DF0")]
	[Conditional("DEBUG_BUILD")]
	private void EDEDJLKAFOF(T KGNPGKACACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5F40", Offset = "0x2BE5140", VA = "0x182BE5F40")]
	[Conditional("DEBUG_BUILD")]
	private void HOFAGCJLBCI(T KGNPGKACACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5D00", Offset = "0x2BE4F00", VA = "0x182BE5D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2BE60A0", Offset = "0x2BE52A0", VA = "0x182BE60A0")]
	private void IBAFOFHMBFM(IEnumerable<T> NEAFDAHPCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class JMOOGGEJPNP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private Dictionary<int, T> NNHLPFPPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T GKDFEFOANAJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T KOCBOPKKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool KMCLIBBOANB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3B23F60", Offset = "0x3B23160", VA = "0x183B23F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3B24590", Offset = "0x3B23790", VA = "0x183B24590")]
	public bool NGEDLHPEMJP(T JFBPNBNBHOE, int GPAIJDKOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3B245F0", Offset = "0x3B237F0", VA = "0x183B245F0")]
	public bool NPEEJGJDMJO(int GPAIJDKOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3B24340", Offset = "0x3B23540", VA = "0x183B24340")]
	public T MLGOONLHDPP(int FJOIEIFJGFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3B23F00", Offset = "0x3B23100", VA = "0x183B23F00")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3B23FA0", Offset = "0x3B231A0", VA = "0x183B23FA0")]
	private bool LJCHLODFIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3B23ED0", Offset = "0x3B230D0", VA = "0x183B23ED0")]
	public bool CPKINNFJFHF(int GPAIJDKOODN, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B24650", Offset = "0x3B23850", VA = "0x183B24650")]
	public JMOOGGEJPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class CAPFAPJNBHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct NOFGKPEBAIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T ALAOEPGGPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int HLLFENPOLCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<NOFGKPEBAIH> GGPNCMCBJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T GBAOMCHKOJM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CA80", Offset = "0x1F6BC80", VA = "0x181F6CA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3510", Offset = "0x3BD2710", VA = "0x183BD3510")]
	public bool GPEECKGOEKF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3130", Offset = "0x3BD2330", VA = "0x183BD3130")]
	public void AOHLLDNPMGN(T JFBPNBNBHOE, int GPAIJDKOODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BD31D0", Offset = "0x3BD23D0", VA = "0x183BD31D0")]
	public bool BCBAFCFKBLF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3BD32F0", Offset = "0x3BD24F0", VA = "0x183BD32F0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3790", Offset = "0x3BD2990", VA = "0x183BD3790")]
	public T JJDMDKJAPLL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3720", Offset = "0x3BD2920", VA = "0x183BD3720")]
	public T IFMCFFLHEJM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3350", Offset = "0x3BD2550", VA = "0x183BD3350")]
	private void GDMJJNDHIOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3800", Offset = "0x3BD2A00", VA = "0x183BD3800")]
	public CAPFAPJNBHO()
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
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x6357CE0", Offset = "0x6356EE0", VA = "0x186357CE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x6358070", Offset = "0x6357270", VA = "0x186358070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x6357EF0", Offset = "0x63570F0", VA = "0x186357EF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x63581D0", Offset = "0x63573D0", VA = "0x1863581D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x6357C00", Offset = "0x6356E00", VA = "0x186357C00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x6357F90", Offset = "0x6357190", VA = "0x186357F90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6357E10", Offset = "0x6357010", VA = "0x186357E10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6357BB0", Offset = "0x6356DB0", VA = "0x186357BB0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface EJKGGKBONBP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : EJKGGKBONBP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x26D9B50", Offset = "0x26D8D50", VA = "0x1826D9B50", Slot = "4")]
		public virtual T LBAKFIDNOCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class OHCENCPLKOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Dictionary<byte, HOKFMIOIKKE> FCOOAEGJLKF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public HOKFMIOIKKE OKHMJMJCKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 NJOBNPCFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x151FCF0", Offset = "0x151EEF0", VA = "0x18151FCF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x710CD0", Offset = "0x70FED0", VA = "0x180710CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 GOIGGHLCGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1D03010", Offset = "0x1D02210", VA = "0x181D03010")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F3000", Offset = "0x9F2200", VA = "0x1809F3000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 EOLNHGLDCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6356A00", Offset = "0x6355C00", VA = "0x186356A00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xEACBD0", Offset = "0xEABDD0", VA = "0x180EACBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int PKKCJNGCBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C70E0", Offset = "0x6C62E0", VA = "0x1806C70E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x72E640", Offset = "0x72D840", VA = "0x18072E640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6357100", Offset = "0x6356300", VA = "0x186357100")]
	public OHCENCPLKOF(Bounds OBPNGALAMPP, Vector2[] KLKIJJENBNB, int JOOPDHLKCEM, byte IIEPBAFMLKK, float FBHMMGFJMCI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x63570A0", Offset = "0x63562A0", VA = "0x1863570A0")]
	public HOKFMIOIKKE NAPEFCHJKJP(byte BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6356A20", Offset = "0x6355C20", VA = "0x186356A20")]
	public void FBGLCHEEJIO(Vector3 DACBJNCMNFL, float IAKELFPACDK, float BBMLHIHJNDH, ref List<byte> JAOGCCIMGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6357080", Offset = "0x6356280", VA = "0x186357080")]
	public void LFKFEFPABOE(HOKFMIOIKKE.BDNAGOAKKOP INEGJNMDHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6356F20", Offset = "0x6356120", VA = "0x186356F20")]
	private HOKFMIOIKKE IPNHBMFENBL(byte BELCAJFDAHD, HOKFMIOIKKE.CNKDEHEFBOO LKAOOJDJIPP, HOKFMIOIKKE GPFONCECPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6356B20", Offset = "0x6355D20", VA = "0x186356B20")]
	private void HCFKEOIIBBN(HOKFMIOIKKE GPFONCECPBK, Vector2[] KLKIJJENBNB, int HKFJDFAJKAD, int DHECHLGBIHJ, int CFNNCPKFKOL, int DOAGNJOPOMP, float FBHMMGFJMCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class HOKFMIOIKKE
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum CNKDEHEFBOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum BDNAGOAKKOP
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
	public byte FFBMMDAJDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 AMANMAOICGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 FAANOCEKAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 MOAFIOFPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 NCAGIBBIJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public CNKDEHEFBOO LOPDNLDOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public HOKFMIOIKKE EMIBHNNCMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<HOKFMIOIKKE> GFPINFCDABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public bool CDJKBCPIKPG;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6353CD0", Offset = "0x6352ED0", VA = "0x186353CD0")]
	public HOKFMIOIKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6353CF0", Offset = "0x6352EF0", VA = "0x186353CF0")]
	public HOKFMIOIKKE(byte LIKFEBDBPON, CNKDEHEFBOO LKAOOJDJIPP, HOKFMIOIKKE GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6353BD0", Offset = "0x6352DD0", VA = "0x186353BD0")]
	public void FIMHIJJNHNG(HOKFMIOIKKE LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public void LFKFEFPABOE(int EOAEKJAAIPM, BDNAGOAKKOP INEGJNMDHFD, int ILNABJAHFCJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6353920", Offset = "0x6352B20", VA = "0x186353920")]
	public void FBGLCHEEJIO(List<byte> JAOGCCIMGFI, Vector3 DACBJNCMNFL, float IAKELFPACDK, float BBMLHIHJNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x63538D0", Offset = "0x6352AD0", VA = "0x1863538D0")]
	public bool AJCHOIMAGDF(Vector3 CKJEELMDBEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6353C90", Offset = "0x6352E90", VA = "0x186353C90")]
	public bool GBJCJNKDICF(Vector3 CKJEELMDBEC, float CNPAMALNLED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class HABDCCDALMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Dictionary<T, object> PINBOJOFMLE;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF630", Offset = "0x1CCE830", VA = "0x181CCF630")]
	public bool HINNCPFAINB(T DBIABDAKFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5040", Offset = "0x3BF4240", VA = "0x183BF5040")]
	public bool HINNCPFAINB(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5080", Offset = "0x3BF4280", VA = "0x183BF5080")]
	public bool HINNCPFAINB(T DBIABDAKFAD, object AJDBKDIMOHA, out object FNBPLALMHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5180", Offset = "0x3BF4380", VA = "0x183BF5180")]
	public bool KFBLNPEFLLE(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5000", Offset = "0x3BF4200", VA = "0x183BF5000")]
	public bool CBJEBHDJFGL(T DBIABDAKFAD, object AJDBKDIMOHA, out object FNBPLALMHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3BF51C0", Offset = "0x3BF43C0", VA = "0x183BF51C0")]
	public bool KFBLNPEFLLE(T DBIABDAKFAD, object AJDBKDIMOHA, out object FNBPLALMHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5250", Offset = "0x3BF4450", VA = "0x183BF5250")]
	public void NCCDFLIHNBA(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BF50E0", Offset = "0x3BF42E0", VA = "0x183BF50E0")]
	public void HJJKPCLJIKM(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5280", Offset = "0x3BF4480", VA = "0x183BF5280")]
	public HABDCCDALMN()
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
		public struct IDPDODLFHCO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool IGHGBNPCCBC;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x894F90", Offset = "0x894190", VA = "0x180894F90")]
			public IDPDODLFHCO(List<Component> NHOGENNANEB, bool IGHGBNPCCBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x3433B60", Offset = "0x3432D60", VA = "0x183433B60")]
			public GJBEOBMHNPL<T> AHIPNMLLDNB()
			{
				return default(GJBEOBMHNPL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x3433BD0", Offset = "0x3432DD0", VA = "0x183433BD0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x3433BD0", Offset = "0x3432DD0", VA = "0x183433BD0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct GJBEOBMHNPL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly List<Component> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly bool IGHGBNPCCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private int BELCAJFDAHD;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T CDKNNCCNMFD
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x35C1120", Offset = "0x35C0320", VA = "0x1835C1120", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x35C10B0", Offset = "0x35C02B0", VA = "0x1835C10B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x35C10F0", Offset = "0x35C02F0", VA = "0x1835C10F0")]
			public GJBEOBMHNPL(List<Component> NHOGENNANEB, bool IGHGBNPCCBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x35C0FF0", Offset = "0x35C01F0", VA = "0x1835C0FF0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x35C1000", Offset = "0x35C0200", VA = "0x1835C1000", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x30B8910", Offset = "0x30B7B10", VA = "0x1830B8910", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6359F40", Offset = "0x6359140", VA = "0x186359F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6359F00", Offset = "0x6359100", VA = "0x186359F00")]
		public ToolHierarchyCache(GameObject GODCAKDBDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6359770", Offset = "0x6358970", VA = "0x186359770")]
		private void BNACPANAOEJ(GameObject GODCAKDBDMK, bool BIOMHNNIJHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x63596E0", Offset = "0x63588E0", VA = "0x1863596E0")]
		public static void BNACPANAOEJ(GameObject GODCAKDBDMK, ref ToolHierarchyCache LDNMOPPGONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x6359A50", Offset = "0x6358C50", VA = "0x186359A50")]
		public void IIPALCLEFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6359690", Offset = "0x6358890", VA = "0x186359690")]
		public void AFBEOFPBPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x24788F0", Offset = "0x2477AF0", VA = "0x1824788F0")]
		public void GGJBBKGCINF<T>(Action<T> GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x6359DB0", Offset = "0x6358FB0", VA = "0x186359DB0")]
		public Component ONMNKEHMJMC(Type DDJDPMGLPAE, bool IGHGBNPCCBC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2478B80", Offset = "0x2477D80", VA = "0x182478B80")]
		public T ONMNKEHMJMC<T>(bool IGHGBNPCCBC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x63598D0", Offset = "0x6358AD0", VA = "0x1863598D0")]
		public IDPDODLFHCO<Component> DHAGCPFANNK(Type DDJDPMGLPAE, bool IGHGBNPCCBC = false)
		{
			return default(IDPDODLFHCO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2478820", Offset = "0x2477A20", VA = "0x182478820")]
		public IDPDODLFHCO<T> DHAGCPFANNK<T>(bool IGHGBNPCCBC = false) where T : class
		{
			return default(IDPDODLFHCO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x6359A60", Offset = "0x6358C60", VA = "0x186359A60")]
		public List<Component> JLEKAEPPCHB(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x6359950", Offset = "0x6358B50", VA = "0x186359950", Slot = "4")]
		public bool Equals(ToolHierarchyCache BIAIPPDLOMD, ToolHierarchyCache ECJDGGJBGPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x63599D0", Offset = "0x6358BD0", VA = "0x1863599D0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ADHHHFDPAPI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class JPOFMHNALJB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int DOMGBHGFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int MIEDFHAKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<T> HIMJHOIKJJP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x254EB40", Offset = "0x254DD40", VA = "0x18254EB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T IAKIEBOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F090", Offset = "0x2D9E290", VA = "0x182D9F090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T OOLEEMKFBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D9EF10", Offset = "0x2D9E110", VA = "0x182D9EF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T FOPGEGMKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D9EE70", Offset = "0x2D9E070", VA = "0x182D9EE70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F1C0", Offset = "0x2D9E3C0", VA = "0x182D9F1C0")]
	public JPOFMHNALJB(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9ED40", Offset = "0x2D9DF40", VA = "0x182D9ED40")]
	public void AOHLLDNPMGN(T LPEDBFFNHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9EFC0", Offset = "0x2D9E1C0", VA = "0x182D9EFC0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F120", Offset = "0x2D9E320", VA = "0x182D9F120")]
	public void LDPKPIHHAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D9EF70", Offset = "0x2D9E170", VA = "0x182D9EF70")]
	public void EMABCDLGOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F000", Offset = "0x2D9E200", VA = "0x182D9F000")]
	public void GNDKDDKLEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class BNLAEBBLKFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool MBJIKICFIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private Action GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static BNLAEBBLKFG DJPHNFJALMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6352520", Offset = "0x6351720", VA = "0x186352520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DGCFKLDJJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB250", Offset = "0x6CA450", VA = "0x1806CB250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xC01DA0", Offset = "0xC00FA0", VA = "0x180C01DA0")]
	public BNLAEBBLKFG(Action GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x63525A0", Offset = "0x63517A0", VA = "0x1863525A0")]
	public void HPPHODAOIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63525A0", Offset = "0x63517A0", VA = "0x1863525A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class PEBODCKDPAJ
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6357830", Offset = "0x6356A30", VA = "0x186357830")]
	public static void GJHBLEBFPEE(JMMOMAJEGFM NCCBGLBIJME, string JBKKHCGIODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0")]
	public static void GJHBLEBFPEE(IEnumerable<object> BAMMKKCEACG, string JBKKHCGIODG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class EPCHBNCLBLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct NECDCJCJLJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int HLLFENPOLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public T ALAOEPGGPNI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<object, NECDCJCJLJD> NNHLPFPPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly EqualityComparer<T> BDMKCBLLBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private T GKDFEFOANAJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T KOCBOPKKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xBF8CA0", Offset = "0xBF7EA0", VA = "0x180BF8CA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE5B0", Offset = "0x1CFD7B0", VA = "0x181CFE5B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KMCLIBBOANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE670", Offset = "0x1CFD870", VA = "0x181CFE670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object LGEDLJEPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1D02960", Offset = "0x1D01B60", VA = "0x181D02960")]
	public bool NGEDLHPEMJP(T JFBPNBNBHOE, object AJDBKDIMOHA, int GPAIJDKOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1D02F80", Offset = "0x1D02180", VA = "0x181D02F80")]
	public bool NPEEJGJDMJO(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE220", Offset = "0x1CFD420", VA = "0x181CFE220")]
	public bool CPKINNFJFHF(object AJDBKDIMOHA, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE640", Offset = "0x1CFD840", VA = "0x181CFE640")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1CFEFE0", Offset = "0x1CFE1E0", VA = "0x181CFEFE0")]
	private bool LJCHLODFIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1D03040", Offset = "0x1D02240", VA = "0x181D03040")]
	public EPCHBNCLBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class EOFHNFMEECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<object, float> NNHLPFPPKBD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PMPKOLJLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1281E70", Offset = "0x1281070", VA = "0x181281E70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE23400", Offset = "0xE22600", VA = "0x180E23400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6353400", Offset = "0x6352600", VA = "0x186353400")]
	public void NGEDLHPEMJP(float JFBPNBNBHOE, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6353470", Offset = "0x6352670", VA = "0x186353470")]
	public void NPEEJGJDMJO(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x63532E0", Offset = "0x63524E0", VA = "0x1863532E0")]
	private void BGHOCDNJPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x63534E0", Offset = "0x63526E0", VA = "0x1863534E0")]
	public EOFHNFMEECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class GLKHMHJFJLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string BPFLBPAPLGF;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F40", Offset = "0x6C7140", VA = "0x1806C7F40")]
	public GLKHMHJFJLG(string KPKMEHAGLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6353810", Offset = "0x6352A10", VA = "0x186353810")]
	public GLKHMHJFJLG(UnityEngine.Object AKKAEOIONAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x63537C0", Offset = "0x63529C0", VA = "0x1863537C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class JMMOMAJEGFM
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class NCOKBONBMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public NCOKBONBMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6355640", Offset = "0x6354840", VA = "0x186355640")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private HashSet<object> BAMMKKCEACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int HNAILKMCLOH;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6354460", Offset = "0x6353660", VA = "0x186354460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool EPILLKKPCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x63543F0", Offset = "0x63535F0", VA = "0x1863543F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x63541F0", Offset = "0x63533F0", VA = "0x1863541F0")]
	public bool AOHLLDNPMGN(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x63542E0", Offset = "0x63534E0", VA = "0x1863542E0")]
	public bool BCBAFCFKBLF(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6354400", Offset = "0x6353600", VA = "0x186354400")]
	public bool GPEECKGOEKF(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6354380", Offset = "0x6353580", VA = "0x186354380")]
	public void CDBDGLKLAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x6354530", Offset = "0x6353730", VA = "0x186354530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public JMMOMAJEGFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class NBBJJOCKJND<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct EMLFANLHPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float IODEKHGIHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T ALAOEPGGPNI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Dictionary<object, EMLFANLHPLB> NNHLPFPPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T LIHFJFKMFBI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T HNMBPJGAKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xFBF1B0", Offset = "0xFBE3B0", VA = "0x180FBF1B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xFBE950", Offset = "0xFBDB50", VA = "0x180FBE950", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object DKPHKFMBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KMCLIBBOANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2B58260", Offset = "0x2B57460", VA = "0x182B58260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2B599D0", Offset = "0x2B58BD0", VA = "0x182B599D0")]
	public bool NGEDLHPEMJP(T JFBPNBNBHOE, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2B59ED0", Offset = "0x2B590D0", VA = "0x182B59ED0")]
	public bool NPEEJGJDMJO(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE640", Offset = "0x1CFD840", VA = "0x181CFE640")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2B581E0", Offset = "0x2B573E0", VA = "0x182B581E0")]
	public bool CPKINNFJFHF(object AJDBKDIMOHA, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x2B59250", Offset = "0x2B58450", VA = "0x182B59250")]
	private bool LJCHLODFIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2B59F30", Offset = "0x2B59130", VA = "0x182B59F30")]
	public NBBJJOCKJND()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6352C70", Offset = "0x6351E70", VA = "0x186352C70")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6352D80", Offset = "0x6351F80", VA = "0x186352D80")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
