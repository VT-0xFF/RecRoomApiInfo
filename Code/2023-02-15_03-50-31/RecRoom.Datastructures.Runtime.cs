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
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7260B0", Offset = "0x7254B0", VA = "0x1807260B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JBFGBNAHGLM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6395640", Offset = "0x6394A40", VA = "0x186395640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6395600", Offset = "0x6394A00", VA = "0x186395600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6395680", Offset = "0x6394A80", VA = "0x186395680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6395850", Offset = "0x6394C50", VA = "0x186395850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63957C0", Offset = "0x6394BC0", VA = "0x1863957C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D17E0", Offset = "0x8D0BE0", VA = "0x1808D17E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63955C0", Offset = "0x63949C0", VA = "0x1863955C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6395730", Offset = "0x6394B30", VA = "0x186395730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6395000", Offset = "0x6394400", VA = "0x186395000")]
	public void CopyBounds(SavedExtents IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6395520", Offset = "0x6394920", VA = "0x186395520")]
	public void SetLocalSpaceBounds(Bounds MPEANMMCLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA9C650", Offset = "0xA9BA50", VA = "0x180A9C650")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6395320", Offset = "0x6394720", VA = "0x186395320")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6395330", Offset = "0x6394730", VA = "0x186395330")]
	private void PELJFMGLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63950F0", Offset = "0x63944F0", VA = "0x1863950F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63949C0", Offset = "0x6393DC0", VA = "0x1863949C0")]
	public static void CalculateLocalBoundsFor(GameObject OOKBNBHDPPG, out Bounds MPEANMMCLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6395030", Offset = "0x6394430", VA = "0x186395030")]
	private static void DLAOKEDFEAN(Bounds GPHMIGDKMEO, Color ECKJDAFJMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6395540", Offset = "0x6394940", VA = "0x186395540")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7532B0", Offset = "0x7526B0", VA = "0x1807532B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C9980", Offset = "0x9C8D80", VA = "0x1809C9980")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x11AC990", Offset = "0x11ABD90", VA = "0x1811AC990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public virtual void EIPMKEANDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
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
	[Cpp2IlInjected.Address(RVA = "0x374CE40", Offset = "0x374C240", VA = "0x18374CE40", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x374C570", Offset = "0x374B970", VA = "0x18374C570", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x374D380", Offset = "0x374C780", VA = "0x18374D380")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public ABHBLGJNBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C696E0", Offset = "0x3C68AE0", VA = "0x183C696E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1B74E20", Offset = "0x1B74220", VA = "0x181B74E20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1B74E50", Offset = "0x1B74250", VA = "0x181B74E50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1B74D70", Offset = "0x1B74170", VA = "0x181B74D70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey EBOEHIFNNLM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1B74DD0", Offset = "0x1B741D0", VA = "0x181B74DD0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1B74C70", Offset = "0x1B74070", VA = "0x181B74C70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B747C0", Offset = "0x1B73BC0", VA = "0x181B747C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B73FE0", Offset = "0x1B733E0", VA = "0x181B73FE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B73C30", Offset = "0x1B73030", VA = "0x181B73C30", Slot = "14")]
	protected virtual string LDLDEFGLAMA(TKeyVal BGEBDBGJEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B73B70", Offset = "0x1B72F70", VA = "0x181B73B70", Slot = "4")]
	public bool ContainsKey(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1B74B60", Offset = "0x1B73F60", VA = "0x181B74B60", Slot = "5")]
	public bool TryGetValue(TKey EBOEHIFNNLM, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B73BA0", Offset = "0x1B72FA0", VA = "0x181B73BA0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B73BA0", Offset = "0x1B72FA0", VA = "0x181B73BA0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B74B90", Offset = "0x1B73F90", VA = "0x181B74B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public BPJLAJCAFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x29C6640", Offset = "0x29C5A40", VA = "0x1829C6640")]
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
		[Cpp2IlInjected.Address(RVA = "0x4169820", Offset = "0x4168C20", VA = "0x184169820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x416A330", Offset = "0x4169730", VA = "0x18416A330")]
	public OGNMHJOMPGA(float KBCDBEKKNPO, float FELOBOLCFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4169A90", Offset = "0x4168E90", VA = "0x184169A90")]
	public bool MKNCJIJMBLP(float KMIINHDMOMG, T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41698A0", Offset = "0x4168CA0", VA = "0x1841698A0")]
	public int DKKJGFGFLNH(float KMIINHDMOMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4169BF0", Offset = "0x4168FF0", VA = "0x184169BF0")]
	public IEnumerable<T> NCALKJHOKGP(float KMIINHDMOMG, [Optional] float? DOJJALFIBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4169900", Offset = "0x4168D00", VA = "0x184169900")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x416A270", Offset = "0x4169670", VA = "0x18416A270")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C9260", Offset = "0x9C8660", VA = "0x1809C9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x30D32D0", Offset = "0x30D26D0", VA = "0x1830D32D0")]
	public KCFHBGMBAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x30D31F0", Offset = "0x30D25F0", VA = "0x1830D31F0")]
	public KCFHBGMBAOE(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30D2250", Offset = "0x30D1650", VA = "0x1830D2250")]
	public void AOHLLDNPMGN(float KMIINHDMOMG, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x30D2330", Offset = "0x30D1730", VA = "0x1830D2330")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x30D2940", Offset = "0x30D1D40", VA = "0x1830D2940")]
	public bool KBBEPKEKBAH(float BIAABCJFCOF, float FCBPNNJMMEP, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x30D2E80", Offset = "0x30D2280", VA = "0x1830D2E80")]
	public bool MMMINKCLCLA(float BIAABCJFCOF, float FCBPNNJMMEP, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x30D1F90", Offset = "0x30D1390", VA = "0x1830D1F90")]
	public void ALHEJEIPAGK(float BIAABCJFCOF, float FCBPNNJMMEP, List<T> IEGPGBKLAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x30D2760", Offset = "0x30D1B60", VA = "0x1830D2760")]
	private int KBAFGKABEFI(int GJEBFGNBDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x30D2720", Offset = "0x30D1B20", VA = "0x1830D2720")]
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
	[Cpp2IlInjected.Address(RVA = "0x977D60", Offset = "0x977160", VA = "0x180977D60", Slot = "4")]
	protected override Vector3 ICPKICIIKML()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E81BE0", Offset = "0x1E80FE0", VA = "0x181E81BE0", Slot = "5")]
	protected override Vector3 EIHDCBGNLJA(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6391C60", Offset = "0x6391060", VA = "0x186391C60", Slot = "6")]
	protected override Vector3 JEECLGDGEGL(Vector3 JFBPNBNBHOE, float EHIBGNPGILO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6391BE0", Offset = "0x6390FE0", VA = "0x186391BE0", Slot = "7")]
	protected override Vector3 CDNJLMPCJGE(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6391CC0", Offset = "0x63910C0", VA = "0x186391CC0", Slot = "8")]
	protected override Vector3 MHBJHNKBGCD(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6391D30", Offset = "0x6391130", VA = "0x186391D30")]
	public MBMHGCOEFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NNNGGMCAFHN : global::KCFHBGMBAOE<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63930F0", Offset = "0x63924F0", VA = "0x1863930F0")]
	public NNNGGMCAFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6393080", Offset = "0x6392480", VA = "0x186393080")]
	public NNNGGMCAFHN(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8A7F90", Offset = "0x8A7390", VA = "0x1808A7F90", Slot = "4")]
	protected override float ICPKICIIKML()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x9A9F80", Offset = "0x9A9380", VA = "0x1809A9F80", Slot = "5")]
	protected override float EIHDCBGNLJA(float KPCLHBOMAKO, float NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55BBAC0", Offset = "0x55BAEC0", VA = "0x1855BBAC0", Slot = "6")]
	protected override float JEECLGDGEGL(float JFBPNBNBHOE, float EHIBGNPGILO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5060", Offset = "0x2FB4460", VA = "0x182FB5060", Slot = "7")]
	protected override float CDNJLMPCJGE(float KPCLHBOMAKO, float NFBNADMIDIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6393070", Offset = "0x6392470", VA = "0x186393070", Slot = "8")]
	protected override float MHBJHNKBGCD(float KPCLHBOMAKO, float NFBNADMIDIB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FNMJEBADKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x213E180", Offset = "0x213D580", VA = "0x18213E180")]
	public static global::GNFIDJBBCLK<T1> BFPHDDBHNEE<T1>(T1 LKGIEGAGLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3773AE0", Offset = "0x3772EE0", VA = "0x183773AE0")]
	public static global::CGNKCLLPIIA<T1, T2> BFPHDDBHNEE<T1, T2>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3773B50", Offset = "0x3772F50", VA = "0x183773B50")]
	public static global::IKNJBNHALAG<T1, T2, T3> BFPHDDBHNEE<T1, T2, T3>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C456B0", Offset = "0x2C44AB0", VA = "0x182C456B0")]
	public static global::ILIMDPEEDPH<T1, T2, T3, T4> BFPHDDBHNEE<T1, T2, T3, T4>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x304D680", Offset = "0x304CA80", VA = "0x18304D680")]
	public static global::MJIAMBELINB<T1, T2, T3, T4, T5> BFPHDDBHNEE<T1, T2, T3, T4, T5>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3773D70", Offset = "0x3773170", VA = "0x183773D70")]
	public static global::AMCIMMNGFGH<T1, T2, T3, T4, T5, T6> BFPHDDBHNEE<T1, T2, T3, T4, T5, T6>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3773CB0", Offset = "0x37730B0", VA = "0x183773CB0")]
	public static global::IACIPAJNMCA<T1, T2, T3, T4, T5, T6, T7> BFPHDDBHNEE<T1, T2, T3, T4, T5, T6, T7>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3773BE0", Offset = "0x3772FE0", VA = "0x183773BE0")]
	public static global::LGPDFFLANKE<T1, T2, T3, T4, T5, T6, T7, T8> BFPHDDBHNEE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH, T8 DBAAKPDJDFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2403260", Offset = "0x2402660", VA = "0x182403260")]
	[IteratorStateMachine(typeof(IALELLEAPCF))]
	public static IEnumerable<global::CGNKCLLPIIA<T1, T2>> LNPNOJJEGNN<T1, T2>(IEnumerable<T1> FAMKPEGNHFC, IEnumerable<T2> GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2403440", Offset = "0x2402840", VA = "0x182403440")]
	[IteratorStateMachine(typeof(FGEAJMJCELG))]
	public static IEnumerable<global::IKNJBNHALAG<T1, T2, T3>> LNPNOJJEGNN<T1, T2, T3>(IEnumerable<T1> FAMKPEGNHFC, IEnumerable<T2> GPHMIGDKMEO, IEnumerable<T3> ECKJDAFJMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xC957F0", Offset = "0xC94BF0", VA = "0x180C957F0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC957C0", Offset = "0xC94BC0", VA = "0x180C957C0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC957A0", Offset = "0xC94BA0", VA = "0x180C957A0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC957D0", Offset = "0xC94BD0", VA = "0x180C957D0")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x638FD80", Offset = "0x638F180", VA = "0x18638FD80")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH, int ELKADCKDDAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x638FD20", Offset = "0x638F120", VA = "0x18638FD20")]
	internal static int GJLENIIHBPP(int KDMPFFHPLAJ, int JGNOIAHBEPG, int GPONFDNEBBB, int INIDEMDCIMB, int IPKKFGNPEDH, int ELKADCKDDAE, int JCOCNJEGKMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x638FD50", Offset = "0x638F150", VA = "0x18638FD50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E850", VA = "0x182B7F450")]
	public GNFIDJBBCLK(T1 LKGIEGAGLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4096870", Offset = "0x4095C70", VA = "0x184096870", Slot = "4")]
	public int CompareTo(global::GNFIDJBBCLK<T1> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x40968E0", Offset = "0x4095CE0", VA = "0x1840968E0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x802D90", Offset = "0x802190", VA = "0x180802D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4096980", Offset = "0x4095D80", VA = "0x184096980", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x31C98F0", Offset = "0x31C8CF0", VA = "0x1831C98F0")]
	public CGNKCLLPIIA(T1 LKGIEGAGLED, T2 DAJGNIAIJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3376240", Offset = "0x3375640", VA = "0x183376240", Slot = "4")]
	public int CompareTo(global::CGNKCLLPIIA<T1, T2> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x33769C0", Offset = "0x3375DC0", VA = "0x1833769C0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3376DB0", Offset = "0x33761B0", VA = "0x183376DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3377870", Offset = "0x3376C70", VA = "0x183377870", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B89DC0", Offset = "0x2B891C0", VA = "0x182B89DC0")]
	public IKNJBNHALAG(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B895B0", Offset = "0x2B889B0", VA = "0x182B895B0", Slot = "4")]
	public int CompareTo(global::IKNJBNHALAG<T1, T2, T3> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B897B0", Offset = "0x2B88BB0", VA = "0x182B897B0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B89A10", Offset = "0x2B88E10", VA = "0x182B89A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B89B00", Offset = "0x2B88F00", VA = "0x182B89B00", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B8DAC0", Offset = "0x2B8CEC0", VA = "0x182B8DAC0")]
	public ILIMDPEEDPH(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D670", Offset = "0x2B8CA70", VA = "0x182B8D670", Slot = "4")]
	public int CompareTo(global::ILIMDPEEDPH<T1, T2, T3, T4> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D7B0", Offset = "0x2B8CBB0", VA = "0x182B8D7B0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D8D0", Offset = "0x2B8CCD0", VA = "0x182B8D8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D990", Offset = "0x2B8CD90", VA = "0x182B8D990", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3AA5AA0", Offset = "0x3AA4EA0", VA = "0x183AA5AA0")]
	public MJIAMBELINB(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5590", Offset = "0x3AA4990", VA = "0x183AA5590", Slot = "4")]
	public int CompareTo(global::MJIAMBELINB<T1, T2, T3, T4, T5> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5710", Offset = "0x3AA4B10", VA = "0x183AA5710", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5850", Offset = "0x3AA4C50", VA = "0x183AA5850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5950", Offset = "0x3AA4D50", VA = "0x183AA5950", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D8C370", Offset = "0x3D8B770", VA = "0x183D8C370")]
	public AMCIMMNGFGH(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BDB0", Offset = "0x3D8B1B0", VA = "0x183D8BDB0", Slot = "4")]
	public int CompareTo(global::AMCIMMNGFGH<T1, T2, T3, T4, T5, T6> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BF70", Offset = "0x3D8B370", VA = "0x183D8BF70", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C0E0", Offset = "0x3D8B4E0", VA = "0x183D8C0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C200", Offset = "0x3D8B600", VA = "0x183D8C200", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x27AC640", Offset = "0x27ABA40", VA = "0x1827AC640")]
	public IACIPAJNMCA(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x27ABFC0", Offset = "0x27AB3C0", VA = "0x1827ABFC0", Slot = "4")]
	public int CompareTo(global::IACIPAJNMCA<T1, T2, T3, T4, T5, T6, T7> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x27AC1C0", Offset = "0x27AB5C0", VA = "0x1827AC1C0", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x27AC360", Offset = "0x27AB760", VA = "0x1827AC360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x27AC4B0", Offset = "0x27AB8B0", VA = "0x1827AC4B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x469C660", Offset = "0x469BA60", VA = "0x18469C660")]
	public LGPDFFLANKE(T1 LKGIEGAGLED, T2 DAJGNIAIJAL, T3 HBFINBAAGHF, T4 PEOLOECEKFC, T5 BJMBBCMJMLA, T6 EEEDDMOCLDD, T7 PDMNIDPAOAH, T8 DBAAKPDJDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x469BF30", Offset = "0x469B330", VA = "0x18469BF30", Slot = "4")]
	public int CompareTo(global::LGPDFFLANKE<T1, T2, T3, T4, T5, T6, T7, T8> IHIJPIJNLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x469C180", Offset = "0x469B580", VA = "0x18469C180", Slot = "0")]
	public override bool Equals(object IHIJPIJNLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x469C340", Offset = "0x469B740", VA = "0x18469C340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x469C4B0", Offset = "0x469B8B0", VA = "0x18469C4B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C3000", Offset = "0x24C2400", VA = "0x1824C3000")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x45C6770", Offset = "0x45C5B70", VA = "0x1845C6770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KDAANCAKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x797670", Offset = "0x796A70", VA = "0x180797670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46C3940", Offset = "0x46C2D40", VA = "0x1846C3940")]
	public T PKPJGNNLGLE(float EHIBGNPGILO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46C3650", Offset = "0x46C2A50", VA = "0x1846C3650")]
	public T EKLIGNLKJPB(float EHIBGNPGILO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EIHDCBGNLJA(T KPCLHBOMAKO, T NFBNADMIDIB, float EHIBGNPGILO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x9A9F80", Offset = "0x9A9380", VA = "0x1809A9F80", Slot = "4")]
	protected override float EIHDCBGNLJA(float KPCLHBOMAKO, float NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x638FDA0", Offset = "0x638F1A0", VA = "0x18638FDA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E81BE0", Offset = "0x1E80FE0", VA = "0x181E81BE0", Slot = "4")]
	protected override Vector3 EIHDCBGNLJA(Vector3 KPCLHBOMAKO, Vector3 NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x63967E0", Offset = "0x6395BE0", VA = "0x1863967E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x638F340", Offset = "0x638E740", VA = "0x18638F340", Slot = "4")]
	protected override Color EIHDCBGNLJA(Color KPCLHBOMAKO, Color NFBNADMIDIB, float EHIBGNPGILO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x638F390", Offset = "0x638E790", VA = "0x18638F390")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PKCIFHOFKIO : global::APIIJKMDDNE<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6394260", Offset = "0x6393660", VA = "0x186394260")]
	public PKCIFHOFKIO(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x63942B0", Offset = "0x63936B0", VA = "0x1863942B0")]
	public PKCIFHOFKIO(KIDKIGHNFGJ[] NHOGNDHLIKK, bool AMBLPFKLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x63941F0", Offset = "0x63935F0", VA = "0x1863941F0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public POINEOHJOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A2C0", Offset = "0x3C696C0", VA = "0x183C6A2C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xA93A00", Offset = "0xA92E00", VA = "0x180A93A00")]
	private GINABHBDCHI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DBKHNNFFFBI, int POBGPMBGFJI, int DAPJGJIMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A210", Offset = "0x3D79610", VA = "0x183D7A210")]
	public static global::GINABHBDCHI<T> GDHAFJANMPF()
	{
		return default(global::GINABHBDCHI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B160", Offset = "0x3D7A560", VA = "0x183D7B160")]
	public (int, int, Task<T>) PIDPKAEICBI(int NOJAHDOHDIN, [Optional] CancellationToken OLHHOODBFDC, double EONMILEOIME = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D79D00", Offset = "0x3D79100", VA = "0x183D79D00")]
	public void EMPPCHDBPDC(int NOJAHDOHDIN, int DAPJGJIMAOA, in T APCBFLNDMMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BFHBEPHLHII
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x638E200", Offset = "0x638D600", VA = "0x18638E200")]
	public static global::GINABHBDCHI<CHLMDABNGKB> GDHAFJANMPF()
	{
		return default(global::GINABHBDCHI<CHLMDABNGKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x638E180", Offset = "0x638D580", VA = "0x18638E180")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BC540", Offset = "0x29BB940", VA = "0x1829BC540", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GJBOPCKCLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D95F40", Offset = "0x2D95340", VA = "0x182D95F40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> EIKMMLDOIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D95F70", Offset = "0x2D95370", VA = "0x182D95F70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D95ED0", Offset = "0x2D952D0", VA = "0x182D95ED0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D95FD0", Offset = "0x2D953D0", VA = "0x182D95FD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D953F0", Offset = "0x2D947F0", VA = "0x182D953F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D95020", Offset = "0x2D94420", VA = "0x182D95020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D94E60", Offset = "0x2D94260", VA = "0x182D94E60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D95CD0", Offset = "0x2D950D0", VA = "0x182D95CD0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D94CD0", Offset = "0x2D940D0", VA = "0x182D94CD0", Slot = "9")]
	public void Add(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D94D10", Offset = "0x2D94110", VA = "0x182D94D10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D94EC0", Offset = "0x2D942C0", VA = "0x182D94EC0", Slot = "8")]
	public bool ContainsKey(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D94F20", Offset = "0x2D94320", VA = "0x182D94F20", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D95C40", Offset = "0x2D95040", VA = "0x182D95C40", Slot = "10")]
	public bool Remove(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D95CA0", Offset = "0x2D950A0", VA = "0x182D95CA0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D95DC0", Offset = "0x2D951C0", VA = "0x182D95DC0", Slot = "11")]
	public bool TryGetValue(TKey EBOEHIFNNLM, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D951B0", Offset = "0x2D945B0", VA = "0x182D951B0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D94F80", Offset = "0x2D94380", VA = "0x182D94F80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D94B80", Offset = "0x2D93F80", VA = "0x182D94B80")]
	public void AOHLLDNPMGN(TVal GBADNLAFNJL, TKey EBOEHIFNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D94B40", Offset = "0x2D93F40", VA = "0x182D94B40")]
	public void AOHLLDNPMGN(KeyValuePair<TVal, TKey> KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D950D0", Offset = "0x2D944D0", VA = "0x182D950D0")]
	public bool GOBLPAEKFAO(TVal EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D95140", Offset = "0x2D94540", VA = "0x182D95140")]
	public bool GPEECKGOEKF(KeyValuePair<TVal, TKey> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D94D50", Offset = "0x2D94150", VA = "0x182D94D50")]
	public bool BCBAFCFKBLF(TVal EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D94D50", Offset = "0x2D94150", VA = "0x182D94D50")]
	public bool BCBAFCFKBLF(KeyValuePair<TVal, TKey> KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D94DF0", Offset = "0x2D941F0", VA = "0x182D94DF0")]
	public bool CPKINNFJFHF(TVal EBOEHIFNNLM, out TKey JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D95330", Offset = "0x2D94730", VA = "0x182D95330")]
	public IEnumerator<KeyValuePair<TVal, TKey>> KEDLLJBBBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D958E0", Offset = "0x2D94CE0", VA = "0x182D958E0")]
	private void MFEHIIJNMGD(TKey EBOEHIFNNLM, TVal GBADNLAFNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D95B10", Offset = "0x2D94F10", VA = "0x182D95B10")]
	private void NPKHMDCFAPB(TKey EBOEHIFNNLM, TVal GBADNLAFNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D95430", Offset = "0x2D94830", VA = "0x182D95430")]
	private bool LNMDDPEGOLO(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D95680", Offset = "0x2D94A80", VA = "0x182D95680")]
	private bool LNMDDPEGOLO(TVal GBADNLAFNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D95DF0", Offset = "0x2D951F0", VA = "0x182D95DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x39CA420", Offset = "0x39C9820", VA = "0x1839CA420", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x39CC410", Offset = "0x39CB810", VA = "0x1839CC410")]
		public Enumerator(global::MBLCFMBJBBP<T> IEGPGBKLAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x39C5030", Offset = "0x39C4430", VA = "0x1839C5030", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x39C7EC0", Offset = "0x39C72C0", VA = "0x1839C7EC0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x39C7790", Offset = "0x39C6B90", VA = "0x1839C7790")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E20E0", Offset = "0x40E14E0", VA = "0x1840E20E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x40E2010", Offset = "0x40E1410", VA = "0x1840E2010")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x40E19B0", Offset = "0x40E0DB0", VA = "0x1840E19B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x40E28A0", Offset = "0x40E1CA0", VA = "0x1840E28A0")]
	public MBLCFMBJBBP(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x40E1610", Offset = "0x40E0A10", VA = "0x1840E1610")]
	public void AOHLLDNPMGN(T EHIBGNPGILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x40E0D00", Offset = "0x40E0100", VA = "0x1840E0D00")]
	public void ALLOANNJLKE(IEnumerable<T> LABCOKBJJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x40E1990", Offset = "0x40E0D90", VA = "0x1840E1990")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x40E1900", Offset = "0x40E0D00", VA = "0x1840E1900")]
	public void BOILOPKCDHM(int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x40E2120", Offset = "0x40E1520", VA = "0x1840E2120")]
	public void ODBBFOEBEGJ(int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x40E2330", Offset = "0x40E1730", VA = "0x1840E2330")]
	public void PDCLCNAPIPC(T[] PFCDNINKMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x40E0960", Offset = "0x40DFD60", VA = "0x1840E0960")]
	public Enumerator AHIPNMLLDNB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x40E2720", Offset = "0x40E1B20", VA = "0x1840E2720", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x40E2720", Offset = "0x40E1B20", VA = "0x1840E2720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x40E1C90", Offset = "0x40E1090", VA = "0x1840E1C90")]
	private int KNFJIOIOLNF(int BELCAJFDAHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x40E21B0", Offset = "0x40E15B0", VA = "0x1840E21B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x810300", Offset = "0x80F700", VA = "0x180810300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x27BDFC0", Offset = "0x27BD3C0", VA = "0x1827BDFC0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27BE060", Offset = "0x27BD460", VA = "0x1827BE060", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x27BDF60", Offset = "0x27BD360", VA = "0x1827BDF60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x27BDED0", Offset = "0x27BD2D0", VA = "0x1827BDED0")]
	public IEICLPEFHJN(Func<Internal, External> CFOONEMCGLN, Func<External, Internal> KMABJOABNLB, bool LPKIEPPBIHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27BDC40", Offset = "0x27BD040", VA = "0x1827BDC40", Slot = "6")]
	public int IndexOf(External KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27BD8C0", Offset = "0x27BCCC0", VA = "0x1827BD8C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27BD920", Offset = "0x27BCD20", VA = "0x1827BD920", Slot = "13")]
	public bool Contains(External KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27BD9B0", Offset = "0x27BCDB0", VA = "0x1827BD9B0", Slot = "14")]
	public void CopyTo(External[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27BD830", Offset = "0x27BCC30", VA = "0x1827BD830", Slot = "11")]
	public void Add(External KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27BDD30", Offset = "0x27BD130", VA = "0x1827BDD30", Slot = "7")]
	public void Insert(int BELCAJFDAHD, External KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x27BDE40", Offset = "0x27BD240", VA = "0x1827BDE40", Slot = "15")]
	public bool Remove(External KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x27BDDD0", Offset = "0x27BD1D0", VA = "0x1827BDDD0", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x27BDBD0", Offset = "0x27BCFD0", VA = "0x1827BDBD0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x27ACB20", Offset = "0x27ABF20", VA = "0x1827ACB20", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6BF0", Offset = "0x3FC5FF0", VA = "0x183FC6BF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6B90", Offset = "0x3FC5F90", VA = "0x183FC6B90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E850", VA = "0x182B7F450")]
	public MOIMMBJPNMO(Func<Internal, External> CFOONEMCGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6B40", Offset = "0x3FC5F40", VA = "0x183FC6B40")]
	public MOIMMBJPNMO(IReadOnlyList<Internal> NHOGENNANEB, Func<Internal, External> CFOONEMCGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6920", Offset = "0x3FC5D20", VA = "0x183FC6920")]
	public void PDCLCNAPIPC(External[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3FC68B0", Offset = "0x3FC5CB0", VA = "0x183FC68B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x29C86B0", Offset = "0x29C7AB0", VA = "0x1829C86B0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x48D0FF0", Offset = "0x48D03F0", VA = "0x1848D0FF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x48D0F90", Offset = "0x48D0390", VA = "0x1848D0F90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E850", VA = "0x182B7F450")]
	public JPHCLNDJNNG(IReadOnlyList<Internal> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x48D0C50", Offset = "0x48D0050", VA = "0x1848D0C50")]
	public bool GPEECKGOEKF(External KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x48D0D60", Offset = "0x48D0160", VA = "0x1848D0D60")]
	public void PDCLCNAPIPC(External[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x48D0CF0", Offset = "0x48D00F0", VA = "0x1848D0CF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x27ACB20", Offset = "0x27ABF20", VA = "0x1827ACB20", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3398DB0", Offset = "0x33981B0", VA = "0x183398DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3398DF0", Offset = "0x33981F0", VA = "0x183398DF0")]
	protected PHFJFINDCAB(bool HLDFGNCKGGB, bool FLPFCLMBPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3398C70", Offset = "0x3398070", VA = "0x183398C70")]
	protected bool HBBBEBGACDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3398CF0", Offset = "0x33980F0", VA = "0x183398CF0")]
	protected void ICIODNMJKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x33989B0", Offset = "0x3397DB0", VA = "0x1833989B0")]
	protected void DGGEPBMFKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x42D22B0", Offset = "0x42D16B0", VA = "0x1842D22B0")]
	private static void HLCBFCGGDPA<U>(ref List<U> NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3398710", Offset = "0x3397B10", VA = "0x183398710", Slot = "5")]
	public void AOHLLDNPMGN(T GPNJNMLGIEN, bool AKKFHGAIPNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3398870", Offset = "0x3397C70", VA = "0x183398870", Slot = "6")]
	public void BCBAFCFKBLF(T GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3398B60", Offset = "0x3397F60", VA = "0x183398B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x638F060", Offset = "0x638E460", VA = "0x18638F060")]
	public CBKLEJNNKJH(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x638EDF0", Offset = "0x638E1F0", VA = "0x18638EDF0")]
	public void KICKDGJKECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x638ED20", Offset = "0x638E120", VA = "0x18638ED20", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x638ED90", Offset = "0x638E190", VA = "0x18638ED90")]
	public static CBKLEJNNKJH FOACHAMOMCH(CBKLEJNNKJH GDGMMGHMPIA, Action GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x638F000", Offset = "0x638E400", VA = "0x18638F000")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7EBE0", VA = "0x182B7F7E0")]
	public KOEHNDLKDFN(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2E81EC0", Offset = "0x2E812C0", VA = "0x182E81EC0")]
	public void KICKDGJKECN(T EHIBGNPGILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2E7F600", Offset = "0x2E7EA00", VA = "0x182E7F600", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2E804F0", Offset = "0x2E7F8F0", VA = "0x182E804F0")]
	public static global::KOEHNDLKDFN<T> FOACHAMOMCH(global::KOEHNDLKDFN<T> GDGMMGHMPIA, Action<T> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2E820E0", Offset = "0x2E814E0", VA = "0x182E820E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7EBE0", VA = "0x182B7F7E0")]
	public NKKFEABOGLC(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3B32B20", Offset = "0x3B31F20", VA = "0x183B32B20")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3568CF0", Offset = "0x35680F0", VA = "0x183568CF0", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3569560", Offset = "0x3568960", VA = "0x183569560")]
	public static global::NKKFEABOGLC<T, U> FOACHAMOMCH(global::NKKFEABOGLC<T, U> GDGMMGHMPIA, Action<T, U> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x356A380", Offset = "0x3569780", VA = "0x18356A380")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7EBE0", VA = "0x182B7F7E0")]
	public FKFOHAFACOF(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBA70", Offset = "0x2FFAE70", VA = "0x182FFBA70")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2FF8260", Offset = "0x2FF7660", VA = "0x182FF8260", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9BC0", Offset = "0x2FF8FC0", VA = "0x182FF9BC0")]
	public static global::FKFOHAFACOF<T, U, V> FOACHAMOMCH(global::FKFOHAFACOF<T, U, V> GDGMMGHMPIA, Action<T, U, V> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBCD0", Offset = "0x2FFB0D0", VA = "0x182FFBCD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7EBE0", VA = "0x182B7F7E0")]
	public NKBDDKEOJNM(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3566EA0", Offset = "0x35662A0", VA = "0x183566EA0")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB, W ONCKMLEEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x35653A0", Offset = "0x35647A0", VA = "0x1835653A0", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3565DE0", Offset = "0x35651E0", VA = "0x183565DE0")]
	public static global::NKBDDKEOJNM<T, U, V, W> FOACHAMOMCH(global::NKBDDKEOJNM<T, U, V, W> GDGMMGHMPIA, Action<T, U, V, W> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3567380", Offset = "0x3566780", VA = "0x183567380")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7EBE0", VA = "0x182B7F7E0")]
	public FGGMMFHCHKG(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF6D0", Offset = "0x2FEEAD0", VA = "0x182FEF6D0")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB, W ONCKMLEEMNO, X BIAIPPDLOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF340", Offset = "0x2FEE740", VA = "0x182FEF340", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF630", Offset = "0x2FEEA30", VA = "0x182FEF630")]
	public static global::FGGMMFHCHKG<T, U, V, W, X> FOACHAMOMCH(global::FGGMMFHCHKG<T, U, V, W, X> GDGMMGHMPIA, Action<T, U, V, W, X> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2FEFC90", Offset = "0x2FEF090", VA = "0x182FEFC90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7EBE0", VA = "0x182B7F7E0")]
	public FPDFBJHKGOH(bool HLDFGNCKGGB = false, bool FLPFCLMBPEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD8260", Offset = "0x3CD7660", VA = "0x183CD8260")]
	public void KICKDGJKECN(T EHIBGNPGILO, U ICAOKLMLEIO, V AEOKKHKBMBB, W ONCKMLEEMNO, X BIAIPPDLOMD, Y ECJDGGJBGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7860", Offset = "0x3CD6C60", VA = "0x183CD7860", Slot = "4")]
	public override void FMEEHNNGJAF(object[] FKNKEJLLBEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7F10", Offset = "0x3CD7310", VA = "0x183CD7F10")]
	public static global::FPDFBJHKGOH<T, U, V, W, X, Y> FOACHAMOMCH(global::FPDFBJHKGOH<T, U, V, W, X, Y> GDGMMGHMPIA, Action<T, U, V, W, X, Y> GPNJNMLGIEN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3CD8830", Offset = "0x3CD7C30", VA = "0x183CD8830")]
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
			[Cpp2IlInjected.Address(RVA = "0x3395DB0", Offset = "0x33951B0", VA = "0x183395DB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3395D80", Offset = "0x3395180", VA = "0x183395D80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x30DCB40", Offset = "0x30DBF40", VA = "0x1830DCB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x27E20A0", Offset = "0x27E14A0", VA = "0x1827E20A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D8FA90", Offset = "0x3D8EE90", VA = "0x183D8FA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x27E20A0", Offset = "0x27E14A0", VA = "0x1827E20A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x36AA090", Offset = "0x36A9490", VA = "0x1836AA090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x36AA180", Offset = "0x36A9580", VA = "0x1836AA180")]
	public GCMHCAIPOAB(in T FLEJODBNJFG, int KPGHBELDCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x36AA150", Offset = "0x36A9550", VA = "0x1836AA150")]
	public GCMHCAIPOAB(in T FLEJODBNJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x36AA010", Offset = "0x36A9410", VA = "0x1836AA010")]
	public PFHAPGJMIHD DLIFFOEPCGK()
	{
		return default(PFHAPGJMIHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x36AA050", Offset = "0x36A9450", VA = "0x1836AA050")]
	public PFHAPGJMIHD DLIFFOEPCGK(CancellationToken OLHHOODBFDC)
	{
		return default(PFHAPGJMIHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x36A9EB0", Offset = "0x36A92B0", VA = "0x1836A9EB0")]
	[AsyncStateMachine(typeof(global::GCMHCAIPOAB<>.KINOJAKMHLL))]
	public Task<PFHAPGJMIHD> DCHJKDKHMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x36A9A70", Offset = "0x36A8E70", VA = "0x1836A9A70")]
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
	[Cpp2IlInjected.Address(RVA = "0x6392EB0", Offset = "0x63922B0", VA = "0x186392EB0")]
	public static global::GCMHCAIPOAB<CHLMDABNGKB> GDHAFJANMPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6392F10", Offset = "0x6392310", VA = "0x186392F10")]
	public static global::GCMHCAIPOAB<CHLMDABNGKB> GDHAFJANMPF(int KPGHBELDCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x213E180", Offset = "0x213D580", VA = "0x18213E180")]
	public static global::GCMHCAIPOAB<T> GDHAFJANMPF<T>(in T FLEJODBNJFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x304D580", Offset = "0x304C980", VA = "0x18304D580")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FC1730", Offset = "0x3FC0B30", VA = "0x183FC1730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan CKJEKDMEJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1880", Offset = "0x3FC0C80", VA = "0x183FC1880")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FC9650", Offset = "0x3FC8A50", VA = "0x183FC9650")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public PPDBFGDMHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x29BC540", Offset = "0x29BB940", VA = "0x1829BC540")]
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
		[Cpp2IlInjected.Address(RVA = "0x469CDF0", Offset = "0x469C1F0", VA = "0x18469CDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EDC730", Offset = "0x3EDBB30", VA = "0x183EDC730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3384390", Offset = "0x3383790", VA = "0x183384390")]
	public CJKFHLCLKLH(HOBFBFJLEOH GGDLLOJGMIH, [Optional] MNDONGBLOKI KJILDGNKAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3383510", Offset = "0x3382910", VA = "0x183383510")]
	public Task<TResult> FLBAHFMCKLI(TRequest EFADACBHMKC, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x33841C0", Offset = "0x33835C0", VA = "0x1833841C0")]
	private void OJPBFOMAEBK(MPEOEJOOIKE DDLOCPDNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3382D10", Offset = "0x3382110", VA = "0x183382D10")]
	[AsyncStateMachine(typeof(global::CJKFHLCLKLH<, >.LHICDCNGHOE))]
	private Task BEPFDAIBCBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3383760", Offset = "0x3382B60", VA = "0x183383760")]
	private MPEOEJOOIKE IFMCFFLHEJM()
	{
		return default(MPEOEJOOIKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3383E60", Offset = "0x3383260", VA = "0x183383E60")]
	[AsyncStateMachine(typeof(global::CJKFHLCLKLH<, >.DLLGJHMHJLN))]
	private Task OBBDHADMBCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3382C40", Offset = "0x3382040", VA = "0x183382C40")]
	private void ACBKABPFPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3383010", Offset = "0x3382410", VA = "0x183383010", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4032F60", Offset = "0x4032360", VA = "0x184032F60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int BBJJHKOCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4033430", Offset = "0x4032830", VA = "0x184033430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x40333D0", Offset = "0x40327D0", VA = "0x1840333D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4033460", Offset = "0x4032860", VA = "0x184033460")]
	public JAKACKENDND(int DOMGBHGFPFL, [Optional] EOBLDDNPDIC EEKMHLEEPKM, [Optional] IEqualityComparer<TKey> BKMCLMNONDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4033330", Offset = "0x4032730", VA = "0x184033330")]
	public void KKNJKGFPPBG(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE, bool JEEBINHFMEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4033000", Offset = "0x4032400", VA = "0x184033000")]
	public bool GCDFGPPINMC(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4032DB0", Offset = "0x40321B0", VA = "0x184032DB0", Slot = "6")]
	public override bool CPKINNFJFHF(TKey DPKBBCLKPCA, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4033080", Offset = "0x4032480", VA = "0x184033080")]
	public bool GHKAKIKICPH(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4032E50", Offset = "0x4032250", VA = "0x184032E50")]
	public bool DABEJHOJHML(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4032F90", Offset = "0x4032390", VA = "0x184032F90", Slot = "7")]
	public override void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4033290", Offset = "0x4032690", VA = "0x184033290")]
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
			[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FAANOCEKAPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AD0", Offset = "0x6EFED0", VA = "0x1806F0AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x6F0C30", Offset = "0x6F0030", VA = "0x1806F0C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime AOPAHHGHKON
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xC26900", Offset = "0xC25D00", VA = "0x180C26900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x30B59E0", Offset = "0x30B4DE0", VA = "0x1830B59E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x702550", Offset = "0x701950", VA = "0x180702550")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B88680", Offset = "0x2B87A80", VA = "0x182B88680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int PCCDIDJHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C70", Offset = "0x6E8070", VA = "0x1806E8C70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int OCCKKIPCFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B86770", Offset = "0x2B85B70", VA = "0x182B86770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x29B5750", Offset = "0x29B4B50", VA = "0x1829B5750", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GJBOPCKCLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B86550", Offset = "0x2B85950", VA = "0x182B86550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B87E60", Offset = "0x2B87260", VA = "0x182B87E60")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B86840", Offset = "0x2B85C40", VA = "0x182B86840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2B88B80", Offset = "0x2B87F80", VA = "0x182B88B80")]
	public IJOEEHHBALN(int DOMGBHGFPFL, [Optional] EOBLDDNPDIC EEKMHLEEPKM, [Optional] IEqualityComparer<TKey> BKMCLMNONDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2B88B30", Offset = "0x2B87F30", VA = "0x182B88B30")]
	public IJOEEHHBALN(TimeSpan EBLKNHBCAOH, [Optional] IEqualityComparer<TKey> BKMCLMNONDI, [Optional] IFDFHCOPJLI OJOHLAOHCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2B88C50", Offset = "0x2B88050", VA = "0x182B88C50")]
	public IJOEEHHBALN(int DOMGBHGFPFL, TimeSpan EBLKNHBCAOH, [Optional] IEqualityComparer<TKey> BKMCLMNONDI, [Optional] IFDFHCOPJLI OJOHLAOHCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2B88CA0", Offset = "0x2B880A0", VA = "0x182B88CA0")]
	public IJOEEHHBALN(int DOMGBHGFPFL, EOBLDDNPDIC EEKMHLEEPKM, TimeSpan EBLKNHBCAOH, [Optional] IEqualityComparer<TKey> BKMCLMNONDI, [Optional] IFDFHCOPJLI OJOHLAOHCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2B86260", Offset = "0x2B85660", VA = "0x182B86260")]
	public void DOMNEEHKMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B873D0", Offset = "0x2B867D0", VA = "0x182B873D0")]
	public void HDECKBNAIGA(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B855A0", Offset = "0x2B849A0", VA = "0x182B855A0")]
	public bool BCBAFCFKBLF(TKey EBOEHIFNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B87550", Offset = "0x2B86950", VA = "0x182B87550")]
	private TVal JLPNHBINJFC(TKey DPKBBCLKPCA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B85870", Offset = "0x2B84C70", VA = "0x182B85870", Slot = "6")]
	public virtual bool CPKINNFJFHF(TKey DPKBBCLKPCA, out TVal JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B867A0", Offset = "0x2B85BA0", VA = "0x182B867A0", Slot = "7")]
	public virtual void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B85EB0", Offset = "0x2B852B0", VA = "0x182B85EB0")]
	private bool DIMMCANMGLL(DBDGNICINLN CEPDMCOICON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B86AC0", Offset = "0x2B85EC0", VA = "0x182B86AC0")]
	private void HAPNGBAEBNA(LinkedListNode<DBDGNICINLN> LNJFPGADGBO, TVal FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B880B0", Offset = "0x2B874B0", VA = "0x182B880B0")]
	private void NGEDLHPEMJP(TKey EBOEHIFNNLM, TVal JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B87CC0", Offset = "0x2B870C0", VA = "0x182B87CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BC540", Offset = "0x29BB940", VA = "0x1829BC540", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MOFPKJBOIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2718E30", Offset = "0x2718230", VA = "0x182718E30", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x591D970", Offset = "0x591CD70", VA = "0x18591D970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x30DB940", Offset = "0x30DAD40", VA = "0x1830DB940", Slot = "11")]
	public void Add(T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x591D3A0", Offset = "0x591C7A0", VA = "0x18591D3A0")]
	public bool PJJKMDOPJFF(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x591D6C0", Offset = "0x591CAC0", VA = "0x18591D6C0", Slot = "15")]
	public bool Remove(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x40E6330", Offset = "0x40E5730", VA = "0x1840E6330", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4FD0", Offset = "0x2FE43D0", VA = "0x182FE4FD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x591CFE0", Offset = "0x591C3E0", VA = "0x18591CFE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x30D7780", Offset = "0x30D6B80", VA = "0x1830D7780", Slot = "13")]
	public bool Contains(T KDBGGIOGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x591D040", Offset = "0x591C440", VA = "0x18591D040", Slot = "14")]
	public void CopyTo(T[] PFCDNINKMFA, int POHDMEMKCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D95F10", Offset = "0x2D95310", VA = "0x182D95F10", Slot = "6")]
	public int IndexOf(T KDBGGIOGPDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x591D070", Offset = "0x591C470", VA = "0x18591D070", Slot = "7")]
	public void Insert(int BELCAJFDAHD, T KDBGGIOGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x591D5F0", Offset = "0x591C9F0", VA = "0x18591D5F0", Slot = "8")]
	public void RemoveAt(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x591D200", Offset = "0x591C600", VA = "0x18591D200")]
	public void LCGKNLKJPOD(Predicate<T> LBFFHLHDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x591D4F0", Offset = "0x591C8F0", VA = "0x18591D4F0")]
	public void POJEELMDDHA(Comparison<T> GLABACABLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x591D7D0", Offset = "0x591CBD0", VA = "0x18591D7D0")]
	public BBIFAGPELIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OIPEDCJNKPC
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6393CC0", Offset = "0x63930C0", VA = "0x186393CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA917F0", Offset = "0xA90BF0", VA = "0x180A917F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6395DC0", Offset = "0x63951C0", VA = "0x186395DC0")]
		public SerializedGuid(in Guid JHHPNHDNIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x63958E0", Offset = "0x6394CE0", VA = "0x1863958E0")]
		public static SerializedGuid ANDCPBJPFDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6395B30", Offset = "0x6394F30", VA = "0x186395B30")]
		public static SerializedGuid GHNFBOLKIAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6395BD0", Offset = "0x6394FD0", VA = "0x186395BD0")]
		public bool LBAPGGCGMJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6395D90", Offset = "0x6395190", VA = "0x186395D90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6395CF0", Offset = "0x63950F0", VA = "0x186395CF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6395C60", Offset = "0x6395060", VA = "0x186395C60")]
		public bool MHAKOGLEHCF(in Guid JHHPNHDNIID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x63959A0", Offset = "0x6394DA0", VA = "0x1863959A0", Slot = "7")]
		public bool Equals(SerializedGuid IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6395A50", Offset = "0x6394E50", VA = "0x186395A50", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6395BC0", Offset = "0x6394FC0", VA = "0x186395BC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6395970", Offset = "0x6394D70", VA = "0x186395970", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6390E50", Offset = "0x6390250", VA = "0x186390E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x27ACBD0", Offset = "0x27ABFD0", VA = "0x1827ACBD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DBOCGLGOLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4370", Offset = "0x6E3770", VA = "0x1806E4370", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string PGEKAPMFDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E21370", Offset = "0x1E20770", VA = "0x181E21370", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8490", Offset = "0x3AA7890", VA = "0x183AA8490")]
	private void IPPIKBINFON(T KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA83E0", Offset = "0x3AA77E0", VA = "0x183AA83E0")]
	private void IMDIAFIKPEI(string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA82E0", Offset = "0x3AA76E0", VA = "0x183AA82E0")]
	public void FNNEKAKKIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3AA81B0", Offset = "0x3AA75B0", VA = "0x183AA81B0", Slot = "6")]
	public global::OALNAIIMFOB<T> DACKOADOFDA(Action<T, T> EOPHMAOEMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8200", Offset = "0x3AA7600", VA = "0x183AA8200", Slot = "7")]
	public global::OALNAIIMFOB<T> DLOLAOLJEOG(Action<T, T> EOPHMAOEMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8250", Offset = "0x3AA7650", VA = "0x183AA8250", Slot = "4")]
	public global::OALNAIIMFOB<T> DOMKPKPOLGE(Action<T> EOPHMAOEMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8390", Offset = "0x3AA7790", VA = "0x183AA8390", Slot = "5")]
	public global::OALNAIIMFOB<T> HAJAADMAJJJ(Action<T> ENAOKCIKOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8530", Offset = "0x3AA7930", VA = "0x183AA8530", Slot = "8")]
	public global::OALNAIIMFOB<T> JCPOKIKALJL(Action<string> ADHNHGBFKDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8140", Offset = "0x3AA7540", VA = "0x183AA8140", Slot = "9")]
	public global::OALNAIIMFOB<T> BPFGDPMEDFD(Action<string> ADHNHGBFKDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA85D0", Offset = "0x3AA79D0", VA = "0x183AA85D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public CJGHBLGKAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x33829A0", Offset = "0x3381DA0", VA = "0x1833829A0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3894DE0", Offset = "0x38941E0", VA = "0x183894DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FF78D0", Offset = "0x2FF6CD0", VA = "0x182FF78D0")]
		public FJAAKIDABOG(long AGIKNLKPKBN, int GEJGIFKJKDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2FF7940", Offset = "0x2FF6D40", VA = "0x182FF7940")]
		public FJAAKIDABOG(long AGIKNLKPKBN, long CIFLBMEEAIK, int GEJGIFKJKDE, int DEKKDMGDHBN, bool KDPIPFJCNKO, string BLLLMFLEANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2FF77A0", Offset = "0x2FF6BA0", VA = "0x182FF77A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void GACGIMAKPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2FF7810", Offset = "0x2FF6C10", VA = "0x182FF7810")]
		public int HHKGEJOLKLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2FF7780", Offset = "0x2FF6B80", VA = "0x182FF7780")]
		public int CIEMEPEKCBL(int OMLHGKAPFFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2FF7860", Offset = "0x2FF6C60", VA = "0x182FF7860")]
		public double PAOPMBMPAPO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2FF76F0", Offset = "0x2FF6AF0", VA = "0x182FF76F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x27AD3F0", Offset = "0x27AC7F0", VA = "0x1827AD3F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x27AD1D0", Offset = "0x27AC5D0", VA = "0x1827AD1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<IBIDBCAPHMG> LILCAAEDFCG
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x27ACFD0", Offset = "0x27AC3D0", VA = "0x1827ACFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public FJAAKIDABOG EMOEBNEKHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xA38890", Offset = "0xA37C90", VA = "0x180A38890")]
			[CompilerGenerated]
			get
			{
				return default(FJAAKIDABOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x27AD1A0", Offset = "0x27AC5A0", VA = "0x1827AD1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x27AD420", Offset = "0x27AC820", VA = "0x1827AD420")]
		internal IBIDBCAPHMG(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, TKey EBOEHIFNNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x27AD200", Offset = "0x27AC600", VA = "0x1827AD200")]
		public IBIDBCAPHMG KBFAMICJOCG(TKey EBOEHIFNNLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x27AD310", Offset = "0x27AC710", VA = "0x1827AD310")]
		public void PEGNHJMNEDP(TKey EBOEHIFNNLM, Action<IBIDBCAPHMG> GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x271E8F0", Offset = "0x271DCF0", VA = "0x18271E8F0")]
		public T PEGNHJMNEDP<T>(TKey EBOEHIFNNLM, Func<IBIDBCAPHMG, T> NLNOCEEAFDB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x271E780", Offset = "0x271DB80", VA = "0x18271E780")]
		[AsyncStateMachine(typeof(JMBIDELFEAK))]
		public Task<T> FEGADBBIBFF<T>(TKey EBOEHIFNNLM, Func<IBIDBCAPHMG, Task<T>> NLNOCEEAFDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x27ACFF0", Offset = "0x27AC3F0", VA = "0x1827ACFF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DFF9B0", Offset = "0x2DFEDB0", VA = "0x182DFF9B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DFFA50", Offset = "0x2DFEE50", VA = "0x182DFFA50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFB00", Offset = "0x2DFEF00", VA = "0x182DFFB00")]
		[DebuggerHidden]
		public ONFHHHNBIHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7E70", Offset = "0x2DF7270", VA = "0x182DF7E70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF640", Offset = "0x2DFEA40", VA = "0x182DFF640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFAB0", Offset = "0x2DFEEB0", VA = "0x182DFFAB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFA10", Offset = "0x2DFEE10", VA = "0x182DFFA10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF8F0", Offset = "0x2DFECF0", VA = "0x182DFF8F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FJAAKIDABOG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF9E0", Offset = "0x2DFEDE0", VA = "0x182DFF9E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DFF9B0", Offset = "0x2DFEDB0", VA = "0x182DFF9B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3600780", Offset = "0x35FFB80", VA = "0x183600780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFB00", Offset = "0x2DFEF00", VA = "0x182DFFB00")]
		[DebuggerHidden]
		public OANEPPHKJFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x36007E0", Offset = "0x35FFBE0", VA = "0x1836007E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x36000C0", Offset = "0x35FF4C0", VA = "0x1836000C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3600880", Offset = "0x35FFC80", VA = "0x183600880")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x36008E0", Offset = "0x35FFCE0", VA = "0x1836008E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3600740", Offset = "0x35FFB40", VA = "0x183600740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3600660", Offset = "0x35FFA60", VA = "0x183600660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FJAAKIDABOG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x334D670", Offset = "0x334CA70", VA = "0x18334D670", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3559060", Offset = "0x3558460", VA = "0x183559060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long OOOGFDBMHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x35590E0", Offset = "0x35584E0", VA = "0x1835590E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int ADNNJNMDHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3559030", Offset = "0x3558430", VA = "0x183559030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3559100", Offset = "0x3558500", VA = "0x183559100")]
	public NEKDBCPDAGF(TKey MFKNILKDMKP, [Optional] int? GEJGIFKJKDE, [Optional][CanBeNull] Stopwatch FFELKINKGLC, [Optional] Action<TKey, FJAAKIDABOG> POIIAKAPAGJ, [Optional] Action<TKey, FJAAKIDABOG> HALNCOMALDH, [Optional] Action<global::NEKDBCPDAGF<TKey>> NMFJJDHGGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3558F20", Offset = "0x3558320", VA = "0x183558F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3558DA0", Offset = "0x35581A0", VA = "0x183558DA0")]
	public void AFODNHEHIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x35590C0", Offset = "0x35584C0", VA = "0x1835590C0")]
	public void HHGHNCHKNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3558E90", Offset = "0x3558290", VA = "0x183558E90")]
	[IteratorStateMachine(typeof(global::NEKDBCPDAGF<>.ONFHHHNBIHB))]
	public IEnumerable<(TKey, List<TKey>, FJAAKIDABOG)> APIJFAKAMEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3558DC0", Offset = "0x35581C0", VA = "0x183558DC0")]
	[IteratorStateMachine(typeof(global::NEKDBCPDAGF<>.OANEPPHKJFC))]
	private IEnumerable<(TKey, List<TKey>, FJAAKIDABOG)> APIJFAKAMEC(List<TKey> BENGLHDIHMD, IBIDBCAPHMG LAJGOLIDBHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3558FB0", Offset = "0x35583B0", VA = "0x183558FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
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
	[Cpp2IlInjected.Address(RVA = "0x30D3580", Offset = "0x30D2980", VA = "0x1830D3580")]
	protected string PLLDIIHGKNE(double MCMFMFMGLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x30D3300", Offset = "0x30D2700", VA = "0x1830D3300")]
	protected string CCGKKFOMFHM(int ONAAJNMAJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x30D3360", Offset = "0x30D2760", VA = "0x1830D3360")]
	private static string ELFNJLCHHPL(TKey EBOEHIFNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x30D34D0", Offset = "0x30D28D0", VA = "0x1830D34D0", Slot = "4")]
	public override string OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x30D33A0", Offset = "0x30D27A0", VA = "0x1830D33A0")]
	public string OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, [NotNull] IBBFHLKLAGJ JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BDADEAIOMOJ(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, [NotNull] IBBFHLKLAGJ JDJHIFPLGNN);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x27ACB20", Offset = "0x27ABF20", VA = "0x1827ACB20")]
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
	[Cpp2IlInjected.Address(RVA = "0x41650F0", Offset = "0x41644F0", VA = "0x1841650F0")]
	private static string ELFNJLCHHPL(TKey EBOEHIFNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x41659B0", Offset = "0x4164DB0", VA = "0x1841659B0")]
	public OFPPPNHOLLI(string GBICJNFHDGA = "F2", double LOHHPIBJLAB = double.MaxValue, bool IAMLAJCBEKB = false, int KNHMENPJIBG = int.MaxValue, [Optional] ISet<string> OCNEEPLLLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4165900", Offset = "0x4164D00", VA = "0x184165900", Slot = "4")]
	public override Dictionary<string, string> OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x41652E0", Offset = "0x41646E0", VA = "0x1841652E0")]
	private bool KIKFGGMBGMM(string HAOEMAHMLJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x41653C0", Offset = "0x41647C0", VA = "0x1841653C0")]
	public Dictionary<string, string> OCHFPAHIEMA(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, IFFMFMIPFCL JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x4165130", Offset = "0x4164530", VA = "0x184165130")]
	private string JFKGBFJFDPP(StringBuilder ECHJJCHBKGC, List<TKey> JCBKMBBBINF, IFFMFMIPFCL JDJHIFPLGNN, bool CKDFAEKFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x4164F70", Offset = "0x4164370", VA = "0x184164F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2FFCE80", Offset = "0x2FFC280", VA = "0x182FFCE80")]
	private FKHEANCINAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBD70", Offset = "0x2FFB170", VA = "0x182FFBD70", Slot = "5")]
	protected override string BDADEAIOMOJ(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, IBBFHLKLAGJ JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2FFCC90", Offset = "0x2FFC090", VA = "0x182FFCC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public NNBELGJFMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5B30", Offset = "0x2DF4F30", VA = "0x182DF5B30")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2E7BF70", Offset = "0x2E7B370", VA = "0x182E7BF70", Slot = "5")]
	protected override string BDADEAIOMOJ(global::NEKDBCPDAGF<TKey> HHEDADBLDNA, IBBFHLKLAGJ JDJHIFPLGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C860", Offset = "0x2E7BC60", VA = "0x182E7C860")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LIJPJKEOJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6390EC0", Offset = "0x63902C0", VA = "0x186390EC0")]
		internal void <Wrap>b__0(global::NEKDBCPDAGF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6390800", Offset = "0x638FC00", VA = "0x186390800")]
	public JJIGCMKLMDK([Optional] string HHHMCDPDAKB, [Optional] int? GEJGIFKJKDE, [Optional] Stopwatch FFELKINKGLC, [Optional] Action<string, FJAAKIDABOG> POIIAKAPAGJ, [Optional] Action<string, FJAAKIDABOG> HALNCOMALDH, [Optional] Action<JJIGCMKLMDK> NMFJJDHGGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6390720", Offset = "0x638FB20", VA = "0x186390720")]
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
			[Cpp2IlInjected.Address(RVA = "0x6390FB0", Offset = "0x63903B0", VA = "0x186390FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6390F60", Offset = "0x6390360", VA = "0x186390F60", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float FMIIHKKAPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x6390F50", Offset = "0x6390350", VA = "0x186390F50", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x63910B0", Offset = "0x63904B0", VA = "0x1863910B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6390590", Offset = "0x638F990", VA = "0x186390590")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected IFDFHCOPJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EMKGDHPGMPH : global::PMJJKANDPJE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x638FA00", Offset = "0x638EE00", VA = "0x18638FA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F535C0", Offset = "0x1F529C0", VA = "0x181F535C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E20C40", Offset = "0x1E20040", VA = "0x181E20C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4C53030", Offset = "0x4C52430", VA = "0x184C53030")]
	public PMJJKANDPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GGPAAAFILEH : global::DLFLJDAHOKP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x638FDE0", Offset = "0x638F1E0", VA = "0x18638FDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F535C0", Offset = "0x1F529C0", VA = "0x181F535C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E20C40", Offset = "0x1E20040", VA = "0x181E20C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x32EFC40", Offset = "0x32EF040", VA = "0x1832EFC40")]
	public DLFLJDAHOKP(Exception LBPJAILMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
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
	private sealed class HLOBIOLFGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::JPDKBAIGBDI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public HLOBIOLFGGN()
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext JDBDELDGCLP;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> JDLFEMNJEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task IPIPBJAONCF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::HCPIAAEIKCB<T> NKJMNAHLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E2EC50", Offset = "0x1E2E050", VA = "0x181E2EC50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ACLLOIKFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x48CD060", Offset = "0x48CC460", VA = "0x1848CD060")]
	static JPDKBAIGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x48CD340", Offset = "0x48CC740", VA = "0x1848CD340")]
	protected JPDKBAIGBDI(TTask DLDNMMGIFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x48CCD10", Offset = "0x48CC110", VA = "0x1848CCD10", Slot = "1")]
	~JPDKBAIGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x48CCC90", Offset = "0x48CC090", VA = "0x1848CCC90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x48CCEF0", Offset = "0x48CC2F0", VA = "0x1848CCEF0")]
	private void MEDMFBCNDEL(bool MGLOCBABFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CLGGPKGDNCK(TTask NPDLLEIFPOH);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BLOMEJCJHEJ();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x48CCCC0", Offset = "0x48CC0C0", VA = "0x1848CCCC0")]
	[CompilerGenerated]
	private void FEPPAAGIEEP(object CFMAPONGMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface MOKBCDABHAA
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
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
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float MKFHLJKEIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float LOGLKLOEMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool HGGGGBFNODB;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float FAANOCEKAPG
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x638DE50", Offset = "0x638D250", VA = "0x18638DE50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x638DFE0", Offset = "0x638D3E0", VA = "0x18638DFE0")]
		public APNICENGONC(float IDCHKLCNMBN, float HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x638DE60", Offset = "0x638D260", VA = "0x18638DE60", Slot = "3")]
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
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public BNJMAHNLHOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GIOOFCKCJBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int DOMGBHGFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int MMLKICDLBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly MOKBCDABHAA[] JCDLNEDKDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CODHJHFLGDA[] FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly APNICENGONC[] GHADDOLNNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private APNICENGONC ACEPLLGOHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly CINGNOEIMGI PJMABKGKPNI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public APNICENGONC CIDGCMPHAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x10D5790", Offset = "0x10D4B90", VA = "0x1810D5790")]
		get
		{
			return default(APNICENGONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x638EA20", Offset = "0x638DE20", VA = "0x18638EA20", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CODHJHFLGDA NGDDPGHLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x638E960", Offset = "0x638DD60", VA = "0x18638E960", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x638EA40", Offset = "0x638DE40", VA = "0x18638EA40", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x638EB00", Offset = "0x638DF00", VA = "0x18638EB00")]
	public BNJMAHNLHOH(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x638E8D0", Offset = "0x638DCD0", VA = "0x18638E8D0")]
	public CINGNOEIMGI KDFIEFKKMHJ(APNICENGONC LABCOKBJJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x638E250", Offset = "0x638D650", VA = "0x18638E250")]
	public void BLGFMDILEFB(MOKBCDABHAA IFOLDAANCOD, [Optional] APNICENGONC LNGDECOMGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x638E880", Offset = "0x638DC80", VA = "0x18638E880")]
	internal int EDAEEPKFCFE(MOKBCDABHAA FKBBHHNBKCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x638E6A0", Offset = "0x638DAA0", VA = "0x18638E6A0")]
	internal APNICENGONC BMFBLEJMBIM(int BELCAJFDAHD)
	{
		return default(APNICENGONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x638E6F0", Offset = "0x638DAF0", VA = "0x18638E6F0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void CODHJHFLGDA(float CJKLDKLIPFL);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class BGDFPCGBKMI
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float LHGJILDOHLF = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NIIKHKMAGIJ
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class HPGNMHMLHAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly MOKBCDABHAA FKBBHHNBKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly CODHJHFLGDA IGAMPECHIKO;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6390500", Offset = "0x638F900", VA = "0x186390500")]
		public HPGNMHMLHAM(MOKBCDABHAA FKBBHHNBKCO, CODHJHFLGDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x63904B0", Offset = "0x638F8B0", VA = "0x1863904B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6391F10", Offset = "0x6391310", VA = "0x186391F10")]
	internal static bool OEDNEGNGAKO(float FAMKPEGNHFC, float GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x106E2A0", Offset = "0x106D6A0", VA = "0x18106E2A0")]
	internal static float JGLDIENJFPJ(float FAMKPEGNHFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6391E50", Offset = "0x6391250", VA = "0x186391E50")]
	public static IDisposable CIDOBIEHMNO(this MOKBCDABHAA FKBBHHNBKCO, CODHJHFLGDA IGAMPECHIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CINGNOEIMGI : MOKBCDABHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float CJKLDKLIPFL;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ENIDNKJMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x638F0C0", Offset = "0x638E4C0", VA = "0x18638F0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CODHJHFLGDA NGDDPGHLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x638F180", Offset = "0x638E580", VA = "0x18638F180", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x638F220", Offset = "0x638E620", VA = "0x18638F220", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public CINGNOEIMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class AEILGLBIKDD
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x638C6A0", Offset = "0x638BAA0", VA = "0x18638C6A0")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this ENAGGHAOLAL BHJMJJKKDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x638C630", Offset = "0x638BA30", VA = "0x18638C630")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this ENAGGHAOLAL BHJMJJKKDOH, HashAlgorithmName IMHFNICJMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x638C780", Offset = "0x638BB80", VA = "0x18638C780")]
	public static bool KKOKIOFELAC([CanBeNull] this ENAGGHAOLAL BHJMJJKKDOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x638C910", Offset = "0x638BD10", VA = "0x18638C910")]
	public static bool KKOKIOFELAC([CanBeNull] this ENAGGHAOLAL BHJMJJKKDOH, out string GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x638C710", Offset = "0x638BB10", VA = "0x18638C710")]
	private static string KAPLPPJKPJM([CanBeNull] byte[] NPNCGJAPKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x638CAB0", Offset = "0x638BEB0", VA = "0x18638CAB0")]
	private static bool OJNANLHOMPH([NotNull] ENAGGHAOLAL BHJMJJKKDOH, [CanBeNull] out byte[] MBJPBHGMHCH, [CanBeNull] out byte[] JAPFOKIIDFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class LMCDJDMCNJB
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6391970", Offset = "0x6390D70", VA = "0x186391970")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this APFDKEDKPKG KFDKPBACEBP, byte[] FOKLNJIODCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x63919B0", Offset = "0x6390DB0", VA = "0x1863919B0")]
	[NotNull]
	public static byte[] HMKFNGMMJAI(this APFDKEDKPKG KFDKPBACEBP, HashAlgorithmName IMHFNICJMAD, byte[] FOKLNJIODCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface APFDKEDKPKG
{
	[Cpp2IlInjected.Token(Token = "0x60002A6")]
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
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] HEIICJFONGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object FBPPFAEANOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
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
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6394170", Offset = "0x6393570", VA = "0x186394170")]
		public PEKOBOJFIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6394110", Offset = "0x6393510", VA = "0x186394110", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte EKNGCOLFJLI = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte ENODDIFDBHG = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> HBFNMECGFLJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool GJGIGNEJFGC;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x213FDB0", Offset = "0x213F1B0", VA = "0x18213FDB0")]
	[Conditional("UNITY_EDITOR")]
	private static void JFEINKEKFBL<T>(params T[] NPADKDANDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x638DB50", Offset = "0x638CF50", VA = "0x18638DB50")]
	public static IDisposable OKPECPHEMDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x638DBF0", Offset = "0x638CFF0", VA = "0x18638DBF0")]
	public static void PBBGPJFBGCA(this IncrementalHash LCFEJBNGOGL, [CanBeNull] GameObject OOKBNBHDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2140820", Offset = "0x213FC20", VA = "0x182140820")]
	public static void PBBGPJFBGCA<T>(this IncrementalHash LCFEJBNGOGL, [CanBeNull] T BGHFDNDJKMA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x21400A0", Offset = "0x213F4A0", VA = "0x1821400A0")]
	public static void LACDLJBNBFG<T>(this IncrementalHash LCFEJBNGOGL, [CanBeNull] T KFDKPBACEBP) where T : APFDKEDKPKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x21408F0", Offset = "0x213FCF0", VA = "0x1821408F0")]
	public static void PDGMBPCOHDJ<T>(this IncrementalHash LCFEJBNGOGL, [CanBeNull] IList<T> JMHFAPKIONK) where T : APFDKEDKPKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x638D140", Offset = "0x638C540", VA = "0x18638D140")]
	private static bool IJPBFOMBFEC([CanBeNull] APFDKEDKPKG KFDKPBACEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x638CCE0", Offset = "0x638C0E0", VA = "0x18638CCE0")]
	public static void AJLJMJHJLDL(this IncrementalHash JBFGBNAHGLM, [CanBeNull] string JANIMIPHCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x638D1D0", Offset = "0x638C5D0", VA = "0x18638D1D0")]
	public static void JIFJCFNJFCF(this IncrementalHash JBFGBNAHGLM, long CLJILDJGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x638D7B0", Offset = "0x638CBB0", VA = "0x18638D7B0")]
	public static void MHFIBNODIPM(this IncrementalHash JBFGBNAHGLM, int FNDBFJAJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x638D5E0", Offset = "0x638C9E0", VA = "0x18638D5E0")]
	public static void MELGLIJBLIB(this IncrementalHash JBFGBNAHGLM, short NGODBMKMKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x638D980", Offset = "0x638CD80", VA = "0x18638D980")]
	public static void NIJHGEIAENH(this IncrementalHash JBFGBNAHGLM, byte KBIBJDBKOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x638D3A0", Offset = "0x638C7A0", VA = "0x18638D3A0")]
	public static void KMPLICCDBIO(this IncrementalHash JBFGBNAHGLM, bool AEPOPKPJCOE, bool DCCOHNBHFGM = false, bool NHGPEANGCPA = false, bool NHIMDBJFFFO = false, bool MHHIDBABAGG = false, bool DFLFKOIGHOI = false, bool AOAKIEFDEOJ = false, bool BHCHKIPNEHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2140130", Offset = "0x213F530", VA = "0x182140130")]
	public static void LIBLNFGGGFL<T>(this IncrementalHash JBFGBNAHGLM, T DMFNAHIEMBA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x638DAF0", Offset = "0x638CEF0", VA = "0x18638DAF0")]
	public static void OJPLBKDPNPB(this IncrementalHash JBFGBNAHGLM, float OFACBICCAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x638DCE0", Offset = "0x638D0E0", VA = "0x18638DCE0")]
	public static void PFEOBKPLOPL(this IncrementalHash JBFGBNAHGLM, double FGIDAJOEDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x638D570", Offset = "0x638C970", VA = "0x18638D570")]
	public static void LBJHJOILCHM(this IncrementalHash JBFGBNAHGLM, ulong KIALGBJEAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x638D0E0", Offset = "0x638C4E0", VA = "0x18638D0E0")]
	public static void HAHDGCEAAIF(this IncrementalHash JBFGBNAHGLM, uint JOGIKMMLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x638D070", Offset = "0x638C470", VA = "0x18638D070")]
	public static void EEAJOLIDOCN(this IncrementalHash JBFGBNAHGLM, ushort KBOOAFCFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x638CD40", Offset = "0x638C140", VA = "0x18638CD40")]
	public static void CCLCBNGGAOB(this IncrementalHash JBFGBNAHGLM, Vector3 EEFGELIHOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x638CEB0", Offset = "0x638C2B0", VA = "0x18638CEB0")]
	public static void DKDPLAAKGME(this IncrementalHash JBFGBNAHGLM, Quaternion KJHIGMBMAAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GLDMLLCBCHB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type HMCFOOEHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string JIOJAMDNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool AJCNCODPLGP;

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x638FEC0", Offset = "0x638F2C0", VA = "0x18638FEC0")]
	public GLDMLLCBCHB(Type NLICPLBEHKH, string CELGNCCMEMG, bool EJJGFHPEBEP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NLNCEFPHMPB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6393000", Offset = "0x6392400", VA = "0x186393000")]
	public NLNCEFPHMPB(string DENPJAMCNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6392F80", Offset = "0x6392380", VA = "0x186392F80")]
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
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x7532A0", Offset = "0x7526A0", VA = "0x1807532A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int BHOLCDOGKAG, int CLEANIGJHKK]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x422EB00", Offset = "0x422DF00", VA = "0x18422EB00")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x422EBA0", Offset = "0x422DFA0", VA = "0x18422EBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x422EA70", Offset = "0x422DE70", VA = "0x18422EA70")]
		public Array2D(uint HMEFMFINFBK, uint OELIKJHOPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x422E9F0", Offset = "0x422DDF0", VA = "0x18422E9F0")]
		public void FPNLAFLJCKH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x638E120", Offset = "0x638D520", VA = "0x18638E120")]
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
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public int DMFNAHIEMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public string IGIHBIGMNMI;

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6391110", Offset = "0x6390510", VA = "0x186391110")]
	public static Dictionary<string, LLCHHDIIONL> IAIOEEKBGKI(Type IKGFLIHEFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6391400", Offset = "0x6390800", VA = "0x186391400")]
	public static Dictionary<string, LLCHHDIIONL> ILMBEDJDCFH(Type IKGFLIHEFNM, LLEANIBKGCP CEEALNPBOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6391730", Offset = "0x6390B30", VA = "0x186391730")]
	public static Dictionary<int, string> JEJEMLFDDGN(Dictionary<string, LLCHHDIIONL> GEMNKBDIDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class IDNGODILFMO
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int KFEDDPHALBE = -1;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public const int ELKLMHMNDPN = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class DMAGMEFKJPD<THandle, TValue> : IDisposable where THandle : struct, IGCGKLPONMN where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<THandle> OFODIKGIPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly List<TValue> NEAFDAHPCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Func<TValue> PGFOLDPKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly Action<TValue> NLOIHLKPOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private int HJJGIOCLLNI;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D94DC0", Offset = "0x2D941C0", VA = "0x182D94DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3EDE230", Offset = "0x3EDD630", VA = "0x183EDE230")]
	public DMAGMEFKJPD(Action<TValue> NLOIHLKPOII, [Optional] Func<TValue> PGFOLDPKJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDBE0", Offset = "0x3EDCFE0", VA = "0x183EDDBE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD9C0", Offset = "0x3EDCDC0", VA = "0x183EDD9C0")]
	public THandle BFPHDDBHNEE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD8A0", Offset = "0x3EDCCA0", VA = "0x183EDD8A0")]
	public THandle AOHLLDNPMGN(TValue JFBPNBNBHOE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD910", Offset = "0x3EDCD10", VA = "0x183EDD910")]
	public bool BCBAFCFKBLF(THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD6B0", Offset = "0x3EDCAB0", VA = "0x183EDD6B0")]
	public bool ACJHDFNHANL(THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDDA0", Offset = "0x3EDD1A0", VA = "0x183EDDDA0")]
	public bool GIGJNHOBOLH(THandle KJNCDAGJAPF, out TValue JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDF90", Offset = "0x3EDD390", VA = "0x183EDDF90")]
	public TValue JLPNHBINJFC(THandle KJNCDAGJAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDCC0", Offset = "0x3EDD0C0", VA = "0x183EDDCC0")]
	public bool EOKNMHALCBJ(THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDD70", Offset = "0x3EDD170", VA = "0x183EDDD70")]
	private THandle FDJHBNGAEOB(int BELCAJFDAHD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDF10", Offset = "0x3EDD310", VA = "0x183EDDF10")]
	private TValue HNFKECKMLCA(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDBA0", Offset = "0x3EDCFA0", VA = "0x183EDDBA0")]
	private void CCNLBODNLNK(int BELCAJFDAHD, in THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDF50", Offset = "0x3EDD350", VA = "0x183EDDF50")]
	private void IPPIKBINFON(int BELCAJFDAHD, in TValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3EDE120", Offset = "0x3EDD520", VA = "0x183EDE120")]
	private THandle PALHANMFGMC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDFF0", Offset = "0x3EDD3F0", VA = "0x183EDDFF0")]
	private void KHPJFLPBAPH(THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDF40", Offset = "0x3EDD340", VA = "0x183EDDF40")]
	private int IEFOOMJNBIG(int FLPPPNDNNNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDFE0", Offset = "0x3EDD3E0", VA = "0x183EDDFE0")]
	private bool KEIIKGBICPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x85FD40", Offset = "0x85F140", VA = "0x18085FD40")]
	private void HFFHGOCAHBC(THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x3EDE0A0", Offset = "0x3EDD4A0", VA = "0x183EDE0A0")]
	private bool KKNONGPIPHG(out THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDE40", Offset = "0x3EDD240", VA = "0x183EDDE40")]
	private bool HFGFOPNNMHJ(out THandle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDC60", Offset = "0x3EDD060", VA = "0x183EDDC60")]
	private void EHFLHMNOIEE(THandle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD780", Offset = "0x3EDCB80", VA = "0x183EDD780")]
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
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
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
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1195D70", Offset = "0x1195170", VA = "0x181195D70")]
	public static bool JBLGPDCHNCE<T>(this T KJNCDAGJAPF, T IHIJPIJNLJM) where T : struct, IGCGKLPONMN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x213FDA0", Offset = "0x213F1A0", VA = "0x18213FDA0")]
	public static bool HGGGGBFNODB<T>(this T KJNCDAGJAPF) where T : struct, IGCGKLPONMN
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x638CBD0", Offset = "0x638BFD0", VA = "0x18638CBD0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int JBFGBNAHGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool KGPDAGOOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private KMNLOMEIIIA BGHMFEPCABE;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool FLDDEHNHNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6392B20", Offset = "0x6391F20", VA = "0x186392B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool GBECMOGKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6392020", Offset = "0x6391420", VA = "0x186392020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6392E80", Offset = "0x6392280", VA = "0x186392E80")]
	public NJJKLJNMLFD(bool KGPDAGOOCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x63924A0", Offset = "0x63918A0", VA = "0x1863924A0")]
	public void IFFNIDAFKKE(object ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6392D70", Offset = "0x6392170", VA = "0x186392D70")]
	public void OKAJIOIFACM(int JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6392B30", Offset = "0x6391F30", VA = "0x186392B30")]
	public void INHHJPJHCNH(uint FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6392C20", Offset = "0x6392020", VA = "0x186392C20")]
	public void LKDKNCDAGCI(bool BGCBODNMJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63920B0", Offset = "0x63914B0", VA = "0x1863920B0")]
	public void GNIAHJGIDEB(long FLPONIKCHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63920F0", Offset = "0x63914F0", VA = "0x1863920F0")]
	public void IBMLKELFBHP(ulong ICOIOJAFHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6392030", Offset = "0x6391430", VA = "0x186392030")]
	public void EDJIMIEPDOC(string IGMDKJEALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6391F90", Offset = "0x6391390", VA = "0x186391F90")]
	public void AABLDCHOGOC(Enum LBPJAILMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6392C40", Offset = "0x6392040", VA = "0x186392C40")]
	public void LKOGDHBBODE(IList NHOGENNANEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3896780", Offset = "0x3895B80", VA = "0x183896780")]
	public void PAGGCFFEJKM<T, U>(Dictionary<T, U> PNHOLEPOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6392130", Offset = "0x6391530", VA = "0x186392130")]
	private void IDCCFDKBKCB(IDictionary PNHOLEPOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6392E10", Offset = "0x6392210", VA = "0x186392E10")]
	public int PGCEGNGINJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6392B40", Offset = "0x6391F40", VA = "0x186392B40")]
	public short JNIIBCCKCPJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x63920A0", Offset = "0x63914A0", VA = "0x1863920A0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6392BB0", Offset = "0x6391FB0", VA = "0x186392BB0")]
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
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode PKCJMFFNILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public TNode GPFONCECPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public MPDELGLAEDI JHMACGKJPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public List<MPDELGLAEDI> JDCAFEIJIPB;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public DDCOEKBIIPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct MPDELGLAEDI : IComparable<MPDELGLAEDI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int GPAIJDKOODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public TClaimant ONJGKHCHKAP;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7E39E0", Offset = "0x7E2DE0", VA = "0x1807E39E0")]
		public MPDELGLAEDI(int GPAIJDKOODN, TClaimant ONJGKHCHKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9490", Offset = "0x3FC8890", VA = "0x183FC9490")]
		public bool ACPJANCMILI(in MPDELGLAEDI IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9500", Offset = "0x3FC8900", VA = "0x183FC9500")]
		public bool GCIBNLALCNP(in MPDELGLAEDI IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3FC94F0", Offset = "0x3FC88F0", VA = "0x183FC94F0", Slot = "4")]
		public int CompareTo(MPDELGLAEDI IHIJPIJNLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9510", Offset = "0x3FC8910", VA = "0x183FC9510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum KBPJPPAABNK
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class KMLBIKBIBHE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public global::ABGBPKLPFIF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x27ACB90", Offset = "0x27ABF90", VA = "0x1827ACB90")]
		[DebuggerHidden]
		public KMLBIKBIBHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AD30", Offset = "0x2E7A130", VA = "0x182E7AD30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AEF0", Offset = "0x2E7A2F0", VA = "0x182E7AEF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2E7AE10", Offset = "0x2E7A210", VA = "0x182E7AE10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F140", Offset = "0x1E1E540", VA = "0x181E1F140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::HHAKGOLNCEJ<DDCOEKBIIPJ> GNIFCAPOLJC;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly global::HHAKGOLNCEJ<List<MPDELGLAEDI>> GIJOPMNCIOC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static int OFLNHNPKAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TClaimant, TNode> KDOPCDJLPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	internal readonly Dictionary<TNode, DDCOEKBIIPJ> KGPOODCOIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private KBPJPPAABNK PDGDINPCGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode MODGPLDICAF(TNode MCFKDIFOJAH);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void OEEEEGOKJCE(TNode MCFKDIFOJAH, TClaimant KIKOIBLODKP, TClaimant GEDDAPIAPCP);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3C69160", Offset = "0x3C68560", VA = "0x183C69160")]
	public ABGBPKLPFIF(KBPJPPAABNK PDGDINPCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3C67E90", Offset = "0x3C67290", VA = "0x183C67E90")]
	public void DHCCFJOJPDP(TNode MCFKDIFOJAH, TNode DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3C68260", Offset = "0x3C67660", VA = "0x183C68260")]
	public void HMIFPFBDINB(TClaimant ONJGKHCHKAP, TNode HIEKNBNAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3C67F10", Offset = "0x3C67310", VA = "0x183C67F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3C68970", Offset = "0x3C67D70", VA = "0x183C68970")]
	private void JOOBPJPGMJD(TClaimant ONJGKHCHKAP, TNode KFIAEHJPLMO, TNode HIEKNBNAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3C68170", Offset = "0x3C67570", VA = "0x183C68170")]
	private int EHALJIFBDOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3C67A10", Offset = "0x3C66E10", VA = "0x183C67A10")]
	private void BLKPIGADKKM(TClaimant ONJGKHCHKAP, TNode HNPABJHODAB, TNode OBMJAGNFCGF, int FPNOLPFEFHF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3C681D0", Offset = "0x3C675D0", VA = "0x183C681D0")]
	private void EHNNLIPBKBB(MPDELGLAEDI LLDJPODDJIM, DDCOEKBIIPJ CHHHJJOHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3C68AE0", Offset = "0x3C67EE0", VA = "0x183C68AE0")]
	private void MFJELCKLLHM(TClaimant ONJGKHCHKAP, TNode HNPABJHODAB, TNode OBMJAGNFCGF, int FPNOLPFEFHF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3C686D0", Offset = "0x3C67AD0", VA = "0x183C686D0")]
	private void HPOFIHGJJDM(MPDELGLAEDI LLDJPODDJIM, TNode MCFKDIFOJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3C68D40", Offset = "0x3C68140", VA = "0x183C68D40")]
	private void MMLCKHLEMOO(MPDELGLAEDI LLDJPODDJIM, DDCOEKBIIPJ CHHHJJOHKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3C67CC0", Offset = "0x3C670C0", VA = "0x183C67CC0")]
	private void CBMHNNCHLCJ(DDCOEKBIIPJ CHHHJJOHKAH, bool BDIIENFLABM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3C68360", Offset = "0x3C67760", VA = "0x183C68360")]
	private void HNFBJIKPBMH(DDCOEKBIIPJ CHHHJJOHKAH, TNode DPPABCPODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3C68A10", Offset = "0x3C67E10", VA = "0x183C68A10")]
	[IteratorStateMachine(typeof(global::ABGBPKLPFIF<, >.KMLBIKBIBHE))]
	private IEnumerable<TNode> KKPNNFICENA(TNode HNPABJHODAB, TNode OBMJAGNFCGF, bool PLMCFKKECLN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3C67DD0", Offset = "0x3C671D0", VA = "0x183C67DD0")]
	private DDCOEKBIIPJ DGABHIKAOAJ(TNode MCFKDIFOJAH, TNode GPFONCECPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3C687E0", Offset = "0x3C67BE0", VA = "0x183C687E0")]
	private DDCOEKBIIPJ JEHJDCDCEHI(TNode MCFKDIFOJAH, TNode GPFONCECPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3C68E40", Offset = "0x3C68240", VA = "0x183C68E40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public T JFBPNBNBHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int BELCAJFDAHD;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class CHMFKIFBBBK : IEnumerator<KIDKIGHNFGJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private global::APIIJKMDDNE<T> KFCGKKLOJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x1B75380", Offset = "0x1B74780", VA = "0x181B75380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public KIDKIGHNFGJ CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x337A200", Offset = "0x3379600", VA = "0x18337A200", Slot = "4")]
			get
			{
				return default(KIDKIGHNFGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x7828A0", VA = "0x1807834A0")]
		public CHMFKIFBBBK(global::APIIJKMDDNE<T> KFCGKKLOJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x337A040", Offset = "0x3379440", VA = "0x18337A040", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x783490", Offset = "0x782890", VA = "0x180783490", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xD06190", Offset = "0xD05590", VA = "0x180D06190", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct LKGJBJNKINM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool BMMBELIGAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T JFBPNBNBHOE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private const int DCFNPNDIGEP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly Dictionary<T, int> GDLEAIMFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private LKGJBJNKINM[] HFHOJJHOMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private int BPLLJGNFOAP;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int JCBGBNDIEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7976B0", Offset = "0x796AB0", VA = "0x1807976B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A90", Offset = "0x8D0E90", VA = "0x1808D1A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x29BC540", Offset = "0x29BB940", VA = "0x1829BC540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3D94250", Offset = "0x3D93650", VA = "0x183D94250")]
	public APIIJKMDDNE(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3D94330", Offset = "0x3D93730", VA = "0x183D94330")]
	public APIIJKMDDNE(KIDKIGHNFGJ[] NHOGNDHLIKK, bool AMBLPFKLINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3D93CF0", Offset = "0x3D930F0", VA = "0x183D93CF0")]
	public int OPAGCAMIPEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3D92F80", Offset = "0x3D92380", VA = "0x183D92F80")]
	private int BIGFJCLKJFF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3D92F30", Offset = "0x3D92330", VA = "0x183D92F30", Slot = "6")]
	protected virtual uint BFOAGILFNAM(uint JBFGBNAHGLM, T JFBPNBNBHOE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3D92DB0", Offset = "0x3D921B0", VA = "0x183D92DB0")]
	public bool AHIFANOCFHG(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3D93AD0", Offset = "0x3D92ED0", VA = "0x183D93AD0")]
	public bool LMGDNPELKHM(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3D93550", Offset = "0x3D92950", VA = "0x183D93550")]
	public bool GPEECKGOEKF(Func<T, bool> OCOPNGDLHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3D933C0", Offset = "0x3D927C0", VA = "0x183D933C0")]
	public int BNBABBHNIFD(T JFBPNBNBHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3D93620", Offset = "0x3D92A20", VA = "0x183D93620")]
	public T HNFKECKMLCA(int BELCAJFDAHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3D93420", Offset = "0x3D92820", VA = "0x183D93420")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3D93F60", Offset = "0x3D93360", VA = "0x183D93F60")]
	public bool PJJKMDOPJFF(T JFBPNBNBHOE, bool JPGEOMLDEBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3D93D60", Offset = "0x3D93160", VA = "0x183D93D60")]
	public bool PJJKMDOPJFF(T JFBPNBNBHOE, int BELCAJFDAHD, bool JPGEOMLDEBP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3D92EA0", Offset = "0x3D922A0", VA = "0x183D92EA0")]
	public bool BCBAFCFKBLF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3D93780", Offset = "0x3D92B80", VA = "0x183D93780")]
	public bool LDKAFBDIKPM(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3D93B20", Offset = "0x3D92F20", VA = "0x183D93B20")]
	private void LNMDDPEGOLO(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3D93940", Offset = "0x3D92D40", VA = "0x183D93940")]
	public KIDKIGHNFGJ[] LHBPEMIBDMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x3D936E0", Offset = "0x3D92AE0", VA = "0x183D936E0")]
	private int KFHJOKBOAAP(int IIEPBAFMLKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3D941D0", Offset = "0x3D935D0", VA = "0x183D941D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3D941D0", Offset = "0x3D935D0", VA = "0x183D941D0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly global::AMBDHPNCLNH<Handle> KCNKHHKBABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int BELCAJFDAHD;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int JFOEPHAPCOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x336DB50", Offset = "0x336CF50", VA = "0x18336DB50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle KJELKMEACHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x336CEC0", Offset = "0x336C2C0", VA = "0x18336CEC0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x336DF50", Offset = "0x336D350", VA = "0x18336DF50")]
		public CEEENEPMIBE(global::AMBDHPNCLNH<Handle> KCNKHHKBABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x336D940", Offset = "0x336CD40", VA = "0x18336D940")]
		public CDEJAMICDDN GDHAFJANMPF(in CDEJAMICDDN IGJFJCHKKMF)
		{
			return default(CDEJAMICDDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x336D8A0", Offset = "0x336CCA0", VA = "0x18336D8A0")]
		public CPJNGBOBJMB GDHAFJANMPF(in CPJNGBOBJMB IGJFJCHKKMF)
		{
			return default(CPJNGBOBJMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x336D420", Offset = "0x336C820", VA = "0x18336D420")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x336DA60", Offset = "0x336CE60", VA = "0x18336DA60")]
		private int KBDOLLNBJDB(string DENPJAMCNLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x336D2E0", Offset = "0x336C6E0", VA = "0x18336D2E0")]
		private Handle CCPNAJKKIJC(string DENPJAMCNLD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct CDEJAMICDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private CEEENEPMIBE CNGPLNBDNJO;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3368EF0", Offset = "0x33682F0", VA = "0x183368EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x3368FF0", Offset = "0x33683F0", VA = "0x183368FF0")]
		public CDEJAMICDDN(global::AMBDHPNCLNH<Handle> KCNKHHKBABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3368E30", Offset = "0x3368230", VA = "0x183368E30")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3368D70", Offset = "0x3368170", VA = "0x183368D70")]
		public CDEJAMICDDN AHIPNMLLDNB()
		{
			return default(CDEJAMICDDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct CPJNGBOBJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private CEEENEPMIBE CNGPLNBDNJO;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle CDKNNCCNMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x39FFA40", Offset = "0x39FEE40", VA = "0x1839FFA40")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x39FFA80", Offset = "0x39FEE80", VA = "0x1839FFA80")]
		public CPJNGBOBJMB(global::AMBDHPNCLNH<Handle> KCNKHHKBABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x39FF940", Offset = "0x39FED40", VA = "0x1839FF940")]
		public bool DJDPPDACCLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x39FF800", Offset = "0x39FEC00", VA = "0x1839FF800")]
		public CPJNGBOBJMB AHIPNMLLDNB()
		{
			return default(CPJNGBOBJMB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> IFHEIOGEEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private NativeList<int> MENALNAABHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int NBEIDPFFLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int KJHMDCLCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private bool HJEPHADFHBH;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x3D87FF0", Offset = "0x3D873F0", VA = "0x183D87FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int NINNFJJMKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FODEPNCFMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E0", Offset = "0x6DFCE0", VA = "0x1806E08E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public CDEJAMICDDN NBBOCJAFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3D89EE0", Offset = "0x3D892E0", VA = "0x183D89EE0")]
		get
		{
			return default(CDEJAMICDDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public CPJNGBOBJMB FMBLCKKJDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x3D875F0", Offset = "0x3D869F0", VA = "0x183D875F0")]
		get
		{
			return default(CPJNGBOBJMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BAB0", Offset = "0x3D8AEB0", VA = "0x183D8BAB0")]
	public AMBDHPNCLNH(int LKPMBDDHJLN, Allocator OPBLDCCKGEG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B140", Offset = "0x3D8A540", VA = "0x183D8B140")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x25B1AC0", Offset = "0x25B0EC0", VA = "0x1825B1AC0")]
	public static int IEFOOMJNBIG(int AEOKKHKBMBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3D87E10", Offset = "0x3D87210", VA = "0x183D87E10")]
	public static bool CKJBAMBDBAJ(int AEOKKHKBMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BAA0", Offset = "0x3D8AEA0", VA = "0x183D8BAA0")]
	public static bool PGCAGFKPGHH(int AEOKKHKBMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A480", Offset = "0x3D89880", VA = "0x183D8A480")]
	public bool JNNIBACKGDO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AF60", Offset = "0x3D8A360", VA = "0x183D8AF60")]
	public bool LNEMALGLAAN(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3D87950", Offset = "0x3D86D50", VA = "0x183D87950")]
	public bool BMELDGHKLID(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3D88C70", Offset = "0x3D88070", VA = "0x183D88C70")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void EBFKHKFHELL(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AB30", Offset = "0x3D89F30", VA = "0x183D8AB30")]
	public Handle LFPJPDPDGFA()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3D89BE0", Offset = "0x3D88FE0", VA = "0x183D89BE0")]
	public void GIEIEOBLMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A740", Offset = "0x3D89B40", VA = "0x183D8A740")]
	public void LEGBHEDDNBM(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3D87740", Offset = "0x3D86B40", VA = "0x183D87740")]
	public bool AINNPHJCHFA(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280")]
	private bool OBLHGNNDMBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B440", Offset = "0x3D8A840", VA = "0x183D8B440")]
	private bool OAAGMJOOFBO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3D880B0", Offset = "0x3D874B0", VA = "0x183D880B0")]
	private void DGNGLIHBGOD(out int BELCAJFDAHD, out int FLPPPNDNNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B600", Offset = "0x3D8AA00", VA = "0x183D8B600")]
	private void OMGOGAJFPCD(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B9B0", Offset = "0x3D8ADB0", VA = "0x183D8B9B0")]
	private void PBNHCDLIAPO(int BELCAJFDAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A030", Offset = "0x3D89430", VA = "0x183D8A030")]
	private bool IHJCKAMMHKA(out int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3D87E20", Offset = "0x3D87220", VA = "0x183D87E20")]
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
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private global::AMBDHPNCLNH<Handle> ONOELOKBECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private T[] PLHNPENEFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Action<T> MDDBJCOLLEN;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DJGPJELDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x4035350", Offset = "0x4034750", VA = "0x184035350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int AFIKAHDKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x4035400", Offset = "0x4034800", VA = "0x184035400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x4036620", Offset = "0x4035A20", VA = "0x184036620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x4036530", Offset = "0x4035930", VA = "0x184036530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x4036990", Offset = "0x4035D90", VA = "0x184036990")]
	public JBJIOMDHKBO(int LKPMBDDHJLN, [Optional] Action<T> MDDBJCOLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x4036650", Offset = "0x4035A50", VA = "0x184036650")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4034A50", Offset = "0x4033E50", VA = "0x184034A50")]
	public bool BMELDGHKLID(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void EBFKHKFHELL(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x4035B50", Offset = "0x4034F50", VA = "0x184035B50")]
	public T JLPNHBINJFC(Handle KJNCDAGJAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x4035530", Offset = "0x4034930", VA = "0x184035530")]
	public bool GIGJNHOBOLH(Handle KJNCDAGJAPF, out T ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x4035AB0", Offset = "0x4034EB0", VA = "0x184035AB0")]
	public void HDECKBNAIGA(Handle KJNCDAGJAPF, T CIBNIAIDCIA, out T LILKDLOOKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x4035840", Offset = "0x4034C40", VA = "0x184035840")]
	public void HDECKBNAIGA(Handle KJNCDAGJAPF, T CIBNIAIDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x4034650", Offset = "0x4033A50", VA = "0x184034650")]
	public bool BFDDADMOHJF(Handle KJNCDAGJAPF, T CIBNIAIDCIA, out T LILKDLOOKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x4034570", Offset = "0x4033970", VA = "0x184034570")]
	public bool BFDDADMOHJF(Handle KJNCDAGJAPF, T CIBNIAIDCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x40339D0", Offset = "0x4032DD0", VA = "0x1840339D0")]
	public Handle AOHLLDNPMGN(T ADHHHFDPAPI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x40362A0", Offset = "0x40356A0", VA = "0x1840362A0")]
	public void LCGKNLKJPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x4033F50", Offset = "0x4033350", VA = "0x184033F50")]
	public void BCBAFCFKBLF(Handle KJNCDAGJAPF, out T LILKDLOOKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x4033BD0", Offset = "0x4032FD0", VA = "0x184033BD0")]
	public void BCBAFCFKBLF(Handle KJNCDAGJAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x4034D00", Offset = "0x4034100", VA = "0x184034D00")]
	public bool BNBGIAPEJPA(Handle KJNCDAGJAPF, out T LILKDLOOKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x4034C20", Offset = "0x4034020", VA = "0x184034C20")]
	public bool BNBGIAPEJPA(Handle KJNCDAGJAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x40364D0", Offset = "0x40358D0", VA = "0x1840364D0")]
	private T LDKAFBDIKPM(int BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x4035280", Offset = "0x4034680", VA = "0x184035280")]
	private void CDEPEGAJOEL(int KFFPMHLOCGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class HHAKGOLNCEJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<T> KCNKHHKBABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<T> JGBPLHIGKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly int MDGGJHOMJLF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int KINODLLBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x27AD3F0", Offset = "0x27AC7F0", VA = "0x1827AD3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int HNKDMGLCKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2B98AE0", Offset = "0x2B97EE0", VA = "0x182B98AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x31C4610", Offset = "0x31C3A10", VA = "0x1831C4610")]
	public static global::HHAKGOLNCEJ<T> IBABHHJNEFB(int DOMGBHGFPFL = 0, int MDGGJHOMJLF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x31C4950", Offset = "0x31C3D50", VA = "0x1831C4950")]
	public static global::HHAKGOLNCEJ<T> MMKDCHDPEMJ(int DOMGBHGFPFL = 0, int MDGGJHOMJLF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x31C4A20", Offset = "0x31C3E20", VA = "0x1831C4A20")]
	public HHAKGOLNCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x31C4A60", Offset = "0x31C3E60", VA = "0x1831C4A60")]
	public HHAKGOLNCEJ(int DOMGBHGFPFL, int MDGGJHOMJLF = int.MaxValue, bool PFMDOJMJBGP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x31C4230", Offset = "0x31C3630", VA = "0x1831C4230")]
	public T CFEAHEFCMFG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x31C44B0", Offset = "0x31C38B0", VA = "0x1831C44B0")]
	public void FLEJEMANDND(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x31C4880", Offset = "0x31C3C80", VA = "0x1831C4880")]
	private void KIFDAIOLDPH(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x31C4560", Offset = "0x31C3960", VA = "0x1831C4560")]
	private void GDFEPCNABMI(T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x31C4430", Offset = "0x31C3830", VA = "0x1831C4430")]
	[Conditional("DEBUG_BUILD")]
	private void EDEDJLKAFOF(T KGNPGKACACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x31C4580", Offset = "0x31C3980", VA = "0x1831C4580")]
	[Conditional("DEBUG_BUILD")]
	private void HOFAGCJLBCI(T KGNPGKACACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x31C4340", Offset = "0x31C3740", VA = "0x1831C4340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x31C46E0", Offset = "0x31C3AE0", VA = "0x1831C46E0")]
	private void IBAFOFHMBFM(IEnumerable<T> NEAFDAHPCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class JMOOGGEJPNP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private Dictionary<int, T> NNHLPFPPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T GKDFEFOANAJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T KOCBOPKKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA00", Offset = "0x6EAE00", VA = "0x1806EBA00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool KMCLIBBOANB
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7210", Offset = "0x3EB6610", VA = "0x183EB7210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7840", Offset = "0x3EB6C40", VA = "0x183EB7840")]
	public bool NGEDLHPEMJP(T JFBPNBNBHOE, int GPAIJDKOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB78A0", Offset = "0x3EB6CA0", VA = "0x183EB78A0")]
	public bool NPEEJGJDMJO(int GPAIJDKOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB75F0", Offset = "0x3EB69F0", VA = "0x183EB75F0")]
	public T MLGOONLHDPP(int FJOIEIFJGFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB71B0", Offset = "0x3EB65B0", VA = "0x183EB71B0")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7250", Offset = "0x3EB6650", VA = "0x183EB7250")]
	private bool LJCHLODFIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7180", Offset = "0x3EB6580", VA = "0x183EB7180")]
	public bool CPKINNFJFHF(int GPAIJDKOODN, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3EB7900", Offset = "0x3EB6D00", VA = "0x183EB7900")]
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
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public T ALAOEPGGPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int HLLFENPOLCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly List<NOFGKPEBAIH> GGPNCMCBJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private T GBAOMCHKOJM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x29BC540", Offset = "0x29BB940", VA = "0x1829BC540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3368170", Offset = "0x3367570", VA = "0x183368170")]
	public bool GPEECKGOEKF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3367D90", Offset = "0x3367190", VA = "0x183367D90")]
	public void AOHLLDNPMGN(T JFBPNBNBHOE, int GPAIJDKOODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3367E30", Offset = "0x3367230", VA = "0x183367E30")]
	public bool BCBAFCFKBLF(T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3367F50", Offset = "0x3367350", VA = "0x183367F50")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x33683F0", Offset = "0x33677F0", VA = "0x1833683F0")]
	public T JJDMDKJAPLL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3368380", Offset = "0x3367780", VA = "0x183368380")]
	public T IFMCFFLHEJM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3367FB0", Offset = "0x33673B0", VA = "0x183367FB0")]
	private void GDMJJNDHIOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3368460", Offset = "0x3367860", VA = "0x183368460")]
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
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x6394440", Offset = "0x6393840", VA = "0x186394440")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x63947D0", Offset = "0x6393BD0", VA = "0x1863947D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x6394650", Offset = "0x6393A50", VA = "0x186394650")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x6394930", Offset = "0x6393D30", VA = "0x186394930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x6394360", Offset = "0x6393760", VA = "0x186394360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x63946F0", Offset = "0x6393AF0", VA = "0x1863946F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x6394570", Offset = "0x6393970", VA = "0x186394570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x6394310", Offset = "0x6393710", VA = "0x186394310")]
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
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x32A7060", Offset = "0x32A6460", VA = "0x1832A7060", Slot = "4")]
		public virtual T LBAKFIDNOCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class OHCENCPLKOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly Dictionary<byte, HOKFMIOIKKE> FCOOAEGJLKF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public HOKFMIOIKKE OKHMJMJCKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F10", Offset = "0x6E1310", VA = "0x1806E1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 NJOBNPCFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA31A20", Offset = "0xA30E20", VA = "0x180A31A20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x825170", VA = "0x180825D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 GOIGGHLCGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xD42C30", Offset = "0xD42030", VA = "0x180D42C30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B1730", VA = "0x1808B2330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 EOLNHGLDCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6393160", Offset = "0x6392560", VA = "0x186393160")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x803E00", Offset = "0x803200", VA = "0x180803E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int PKKCJNGCBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x77F5B0", Offset = "0x77E9B0", VA = "0x18077F5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x85FD40", Offset = "0x85F140", VA = "0x18085FD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6393860", Offset = "0x6392C60", VA = "0x186393860")]
	public OHCENCPLKOF(Bounds OBPNGALAMPP, Vector2[] KLKIJJENBNB, int JOOPDHLKCEM, byte IIEPBAFMLKK, float FBHMMGFJMCI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6393800", Offset = "0x6392C00", VA = "0x186393800")]
	public HOKFMIOIKKE NAPEFCHJKJP(byte BELCAJFDAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6393180", Offset = "0x6392580", VA = "0x186393180")]
	public void FBGLCHEEJIO(Vector3 DACBJNCMNFL, float IAKELFPACDK, float BBMLHIHJNDH, ref List<byte> JAOGCCIMGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x63937E0", Offset = "0x6392BE0", VA = "0x1863937E0")]
	public void LFKFEFPABOE(HOKFMIOIKKE.BDNAGOAKKOP INEGJNMDHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6393680", Offset = "0x6392A80", VA = "0x186393680")]
	private HOKFMIOIKKE IPNHBMFENBL(byte BELCAJFDAHD, HOKFMIOIKKE.CNKDEHEFBOO LKAOOJDJIPP, HOKFMIOIKKE GPFONCECPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6393280", Offset = "0x6392680", VA = "0x186393280")]
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
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum BDNAGOAKKOP
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public byte FFBMMDAJDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 AMANMAOICGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 FAANOCEKAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 MOAFIOFPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Vector3 NCAGIBBIJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public CNKDEHEFBOO LOPDNLDOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public HOKFMIOIKKE EMIBHNNCMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<HOKFMIOIKKE> GFPINFCDABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public bool CDJKBCPIKPG;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6390430", Offset = "0x638F830", VA = "0x186390430")]
	public HOKFMIOIKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6390450", Offset = "0x638F850", VA = "0x186390450")]
	public HOKFMIOIKKE(byte LIKFEBDBPON, CNKDEHEFBOO LKAOOJDJIPP, HOKFMIOIKKE GPFONCECPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6390330", Offset = "0x638F730", VA = "0x186390330")]
	public void FIMHIJJNHNG(HOKFMIOIKKE LKJGCNCCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
	public void LFKFEFPABOE(int EOAEKJAAIPM, BDNAGOAKKOP INEGJNMDHFD, int ILNABJAHFCJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6390080", Offset = "0x638F480", VA = "0x186390080")]
	public void FBGLCHEEJIO(List<byte> JAOGCCIMGFI, Vector3 DACBJNCMNFL, float IAKELFPACDK, float BBMLHIHJNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6390030", Offset = "0x638F430", VA = "0x186390030")]
	public bool AJCHOIMAGDF(Vector3 CKJEELMDBEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x63903F0", Offset = "0x638F7F0", VA = "0x1863903F0")]
	public bool GBJCJNKDICF(Vector3 CKJEELMDBEC, float CNPAMALNLED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class HABDCCDALMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Dictionary<T, object> PINBOJOFMLE;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2DF5B30", Offset = "0x2DF4F30", VA = "0x182DF5B30")]
	public bool HINNCPFAINB(T DBIABDAKFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4386940", Offset = "0x4385D40", VA = "0x184386940")]
	public bool HINNCPFAINB(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x4386980", Offset = "0x4385D80", VA = "0x184386980")]
	public bool HINNCPFAINB(T DBIABDAKFAD, object AJDBKDIMOHA, out object FNBPLALMHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4386A80", Offset = "0x4385E80", VA = "0x184386A80")]
	public bool KFBLNPEFLLE(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4386900", Offset = "0x4385D00", VA = "0x184386900")]
	public bool CBJEBHDJFGL(T DBIABDAKFAD, object AJDBKDIMOHA, out object FNBPLALMHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4386AC0", Offset = "0x4385EC0", VA = "0x184386AC0")]
	public bool KFBLNPEFLLE(T DBIABDAKFAD, object AJDBKDIMOHA, out object FNBPLALMHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4386B50", Offset = "0x4385F50", VA = "0x184386B50")]
	public void NCCDFLIHNBA(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x43869E0", Offset = "0x4385DE0", VA = "0x1843869E0")]
	public void HJJKPCLJIKM(T DBIABDAKFAD, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x4386B80", Offset = "0x4385F80", VA = "0x184386B80")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool IGHGBNPCCBC;

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xDC1E70", Offset = "0xDC1270", VA = "0x180DC1E70")]
			public IDPDODLFHCO(List<Component> NHOGENNANEB, bool IGHGBNPCCBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x27AEC40", Offset = "0x27AE040", VA = "0x1827AEC40")]
			public GJBEOBMHNPL<T> AHIPNMLLDNB()
			{
				return default(GJBEOBMHNPL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x27AECB0", Offset = "0x27AE0B0", VA = "0x1827AECB0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x27AECB0", Offset = "0x27AE0B0", VA = "0x1827AECB0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct GJBEOBMHNPL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly List<Component> NHOGENNANEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private readonly bool IGHGBNPCCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private int BELCAJFDAHD;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T CDKNNCCNMFD
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x3D7BCA0", Offset = "0x3D7B0A0", VA = "0x183D7BCA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x3D7BC30", Offset = "0x3D7B030", VA = "0x183D7BC30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x3D7BC70", Offset = "0x3D7B070", VA = "0x183D7BC70")]
			public GJBEOBMHNPL(List<Component> NHOGENNANEB, bool IGHGBNPCCBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x3D7BB70", Offset = "0x3D7AF70", VA = "0x183D7BB70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x3D7BB80", Offset = "0x3D7AF80", VA = "0x183D7BB80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x39C4030", Offset = "0x39C3430", VA = "0x1839C4030", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x6396680", Offset = "0x6395A80", VA = "0x186396680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6396640", Offset = "0x6395A40", VA = "0x186396640")]
		public ToolHierarchyCache(GameObject GODCAKDBDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6395ED0", Offset = "0x63952D0", VA = "0x186395ED0")]
		private void BNACPANAOEJ(GameObject GODCAKDBDMK, bool BIOMHNNIJHG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x6395E40", Offset = "0x6395240", VA = "0x186395E40")]
		public static void BNACPANAOEJ(GameObject GODCAKDBDMK, ref ToolHierarchyCache LDNMOPPGONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x63961B0", Offset = "0x63955B0", VA = "0x1863961B0")]
		public void IIPALCLEFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x6395DF0", Offset = "0x63951F0", VA = "0x186395DF0")]
		public void AFBEOFPBPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x304A360", Offset = "0x3049760", VA = "0x18304A360")]
		public void GGJBBKGCINF<T>(Action<T> GPNJNMLGIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x63964F0", Offset = "0x63958F0", VA = "0x1863964F0")]
		public Component ONMNKEHMJMC(Type DDJDPMGLPAE, bool IGHGBNPCCBC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x304A5F0", Offset = "0x30499F0", VA = "0x18304A5F0")]
		public T ONMNKEHMJMC<T>(bool IGHGBNPCCBC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x6396030", Offset = "0x6395430", VA = "0x186396030")]
		public IDPDODLFHCO<Component> DHAGCPFANNK(Type DDJDPMGLPAE, bool IGHGBNPCCBC = false)
		{
			return default(IDPDODLFHCO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x304A290", Offset = "0x3049690", VA = "0x18304A290")]
		public IDPDODLFHCO<T> DHAGCPFANNK<T>(bool IGHGBNPCCBC = false) where T : class
		{
			return default(IDPDODLFHCO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x63961C0", Offset = "0x63955C0", VA = "0x1863961C0")]
		public List<Component> JLEKAEPPCHB(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x63960B0", Offset = "0x63954B0", VA = "0x1863960B0", Slot = "4")]
		public bool Equals(ToolHierarchyCache BIAIPPDLOMD, ToolHierarchyCache ECJDGGJBGPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x6396130", Offset = "0x6395530", VA = "0x186396130", Slot = "5")]
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
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int DOMGBHGFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private int MIEDFHAKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private List<T> HIMJHOIKJJP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x27AD3F0", Offset = "0x27AC7F0", VA = "0x1827AD3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T IAKIEBOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x48D14D0", Offset = "0x48D08D0", VA = "0x1848D14D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T OOLEEMKFBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x48D1350", Offset = "0x48D0750", VA = "0x1848D1350")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T FOPGEGMKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x48D12B0", Offset = "0x48D06B0", VA = "0x1848D12B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x48D1600", Offset = "0x48D0A00", VA = "0x1848D1600")]
	public JPOFMHNALJB(int DOMGBHGFPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x48D1180", Offset = "0x48D0580", VA = "0x1848D1180")]
	public void AOHLLDNPMGN(T LPEDBFFNHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x48D1400", Offset = "0x48D0800", VA = "0x1848D1400")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x48D1560", Offset = "0x48D0960", VA = "0x1848D1560")]
	public void LDPKPIHHAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x48D13B0", Offset = "0x48D07B0", VA = "0x1848D13B0")]
	public void EMABCDLGOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x48D1440", Offset = "0x48D0840", VA = "0x1848D1440")]
	public void GNDKDDKLEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class BNLAEBBLKFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private bool MBJIKICFIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Action GPNJNMLGIEN;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static BNLAEBBLKFG DJPHNFJALMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x638EC80", Offset = "0x638E080", VA = "0x18638EC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DGCFKLDJJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x75DD10", Offset = "0x75D110", VA = "0x18075DD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BB810", Offset = "0x7BAC10", VA = "0x1807BB810")]
	public BNLAEBBLKFG(Action GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x638ED00", Offset = "0x638E100", VA = "0x18638ED00")]
	public void HPPHODAOIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x638ED00", Offset = "0x638E100", VA = "0x18638ED00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class PEBODCKDPAJ
{
	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6393F90", Offset = "0x6393390", VA = "0x186393F90")]
	public static void GJHBLEBFPEE(JMMOMAJEGFM NCCBGLBIJME, string JBKKHCGIODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int HLLFENPOLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public T ALAOEPGGPNI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<object, NECDCJCJLJD> NNHLPFPPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly EqualityComparer<T> BDMKCBLLBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private T GKDFEFOANAJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T KOCBOPKKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x752ED0", Offset = "0x7522D0", VA = "0x180752ED0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7530D0", Offset = "0x7524D0", VA = "0x1807530D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KMCLIBBOANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E270", Offset = "0x1B6D670", VA = "0x181B6E270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object LGEDLJEPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1B70DF0", Offset = "0x1B701F0", VA = "0x181B70DF0")]
	public bool NGEDLHPEMJP(T JFBPNBNBHOE, object AJDBKDIMOHA, int GPAIJDKOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1B71390", Offset = "0x1B70790", VA = "0x181B71390")]
	public bool NPEEJGJDMJO(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E130", Offset = "0x1B6D530", VA = "0x181B6E130")]
	public bool CPKINNFJFHF(object AJDBKDIMOHA, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E240", Offset = "0x1B6D640", VA = "0x181B6E240")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x3680860", Offset = "0x367FC60", VA = "0x183680860")]
	private bool LJCHLODFIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1B71470", Offset = "0x1B70870", VA = "0x181B71470")]
	public EPCHBNCLBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class EOFHNFMEECA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private Dictionary<object, float> NNHLPFPPKBD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PMPKOLJLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8A55E0", Offset = "0x8A49E0", VA = "0x1808A55E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8A55F0", Offset = "0x8A49F0", VA = "0x1808A55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x638FB60", Offset = "0x638EF60", VA = "0x18638FB60")]
	public void NGEDLHPEMJP(float JFBPNBNBHOE, object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x638FBD0", Offset = "0x638EFD0", VA = "0x18638FBD0")]
	public void NPEEJGJDMJO(object AJDBKDIMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x638FA40", Offset = "0x638EE40", VA = "0x18638FA40")]
	private void BGHOCDNJPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x638FC40", Offset = "0x638F040", VA = "0x18638FC40")]
	public EOFHNFMEECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class GLKHMHJFJLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string BPFLBPAPLGF;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	public GLKHMHJFJLG(string KPKMEHAGLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x638FF70", Offset = "0x638F370", VA = "0x18638FF70")]
	public GLKHMHJFJLG(UnityEngine.Object AKKAEOIONAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x638FF20", Offset = "0x638F320", VA = "0x18638FF20", Slot = "3")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public NCOKBONBMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6391DA0", Offset = "0x63911A0", VA = "0x186391DA0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private HashSet<object> BAMMKKCEACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private int HNAILKMCLOH;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> EKIDKKGDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6390BC0", Offset = "0x638FFC0", VA = "0x186390BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool EPILLKKPCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6390B50", Offset = "0x638FF50", VA = "0x186390B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int HGPJFHAOHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6390950", Offset = "0x638FD50", VA = "0x186390950")]
	public bool AOHLLDNPMGN(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6390A40", Offset = "0x638FE40", VA = "0x186390A40")]
	public bool BCBAFCFKBLF(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6390B60", Offset = "0x638FF60", VA = "0x186390B60")]
	public bool GPEECKGOEKF(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x6390AE0", Offset = "0x638FEE0", VA = "0x186390AE0")]
	public void CDBDGLKLAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6390C90", Offset = "0x6390090", VA = "0x186390C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public float IODEKHGIHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public T ALAOEPGGPNI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Dictionary<object, EMLFANLHPLB> NNHLPFPPKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private T LIHFJFKMFBI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T HNMBPJGAKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA39E0", Offset = "0x1AA2DE0", VA = "0x181AA39E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x230D880", Offset = "0x230CC80", VA = "0x18230D880", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object DKPHKFMBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KMCLIBBOANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x354B280", Offset = "0x354A680", VA = "0x18354B280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x354C9F0", Offset = "0x354BDF0", VA = "0x18354C9F0")]
	public bool NGEDLHPEMJP(T JFBPNBNBHOE, object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x354CEF0", Offset = "0x354C2F0", VA = "0x18354CEF0")]
	public bool NPEEJGJDMJO(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E240", Offset = "0x1B6D640", VA = "0x181B6E240")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x354B200", Offset = "0x354A600", VA = "0x18354B200")]
	public bool CPKINNFJFHF(object AJDBKDIMOHA, out T JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x354C270", Offset = "0x354B670", VA = "0x18354C270")]
	private bool LJCHLODFIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x354CF50", Offset = "0x354C350", VA = "0x18354CF50")]
	public NBBJJOCKJND()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x638F3D0", Offset = "0x638E7D0", VA = "0x18638F3D0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x638F4E0", Offset = "0x638E8E0", VA = "0x18638F4E0")]
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

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
