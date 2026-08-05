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
public class NLLJGFDDCNF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	public NLLJGFDDCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, DMHOLEFNLMF, IPADMLFCGON, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NFFMFBOGLMH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE1BFB0", Offset = "0xE1A9B0", VA = "0x180E1BFB0")]
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
	[FONLJFLPJDE]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[FONLJFLPJDE]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x636A030", Offset = "0x6368A30", VA = "0x18636A030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6369FF0", Offset = "0x63689F0", VA = "0x186369FF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x636A070", Offset = "0x6368A70", VA = "0x18636A070")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x636A240", Offset = "0x6368C40", VA = "0x18636A240")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x636A1B0", Offset = "0x6368BB0", VA = "0x18636A1B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x11DE660", Offset = "0x11DD060", VA = "0x1811DE660")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xF3B940", Offset = "0xF3A340", VA = "0x180F3B940")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6369FB0", Offset = "0x63689B0", VA = "0x186369FB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x636A120", Offset = "0x6368B20", VA = "0x18636A120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6369CA0", Offset = "0x63686A0", VA = "0x186369CA0")]
	public void CopyBounds(SavedExtents DFHJPOKNFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6369F10", Offset = "0x6368910", VA = "0x186369F10")]
	public void SetLocalSpaceBounds(Bounds DFIPCDNNMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x124C770", Offset = "0x124B170", VA = "0x18124C770")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6369F00", Offset = "0x6368900", VA = "0x186369F00")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63693B0", Offset = "0x6367DB0", VA = "0x1863693B0")]
	private void AMGCALLJMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6369CD0", Offset = "0x63686D0", VA = "0x186369CD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6369660", Offset = "0x6368060", VA = "0x186369660")]
	public static void CalculateLocalBoundsFor(GameObject KEHOIMKGHCH, out Bounds DFIPCDNNMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63695A0", Offset = "0x6367FA0", VA = "0x1863695A0")]
	private static void CLMLIIIGKME(Bounds DLAMIJMLOOE, Color LKLPGHLLEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6369F30", Offset = "0x6368930", VA = "0x186369F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F30", Offset = "0x6E0930", VA = "0x1806E1F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x106A050", Offset = "0x1068A50", VA = "0x18106A050")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA7D860", Offset = "0xA7C260", VA = "0x180A7D860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public virtual void PNILHPELICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
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
	[NLLJGFDDCNF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D34970", Offset = "0x3D33370", VA = "0x183D34970", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D340A0", Offset = "0x3D32AA0", VA = "0x183D340A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D34EB0", Offset = "0x3D338B0", VA = "0x183D34EB0")]
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
	private sealed class PFNFHCJOMDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public PFNFHCJOMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3143B40", Offset = "0x3142540", VA = "0x183143B40")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[NLLJGFDDCNF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x17A9160", Offset = "0x17A7B60", VA = "0x1817A9160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x17A9190", Offset = "0x17A7B90", VA = "0x1817A9190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x17A90B0", Offset = "0x17A7AB0", VA = "0x1817A90B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey AJPNMLHDHNM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x17A9110", Offset = "0x17A7B10", VA = "0x1817A9110", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x17A8FB0", Offset = "0x17A79B0", VA = "0x1817A8FB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x17A8B00", Offset = "0x17A7500", VA = "0x1817A8B00", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x17A8320", Offset = "0x17A6D20", VA = "0x1817A8320", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x17A7FD0", Offset = "0x17A69D0", VA = "0x1817A7FD0", Slot = "14")]
	protected virtual string LAEGNIFHFBF(TKeyVal LEFFAHKMIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x17A7EB0", Offset = "0x17A68B0", VA = "0x1817A7EB0", Slot = "4")]
	public bool ContainsKey(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x17A8EA0", Offset = "0x17A78A0", VA = "0x1817A8EA0", Slot = "5")]
	public bool TryGetValue(TKey AJPNMLHDHNM, out TVal MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x17A7EE0", Offset = "0x17A68E0", VA = "0x1817A7EE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x17A7EE0", Offset = "0x17A68E0", VA = "0x1817A7EE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x17A8ED0", Offset = "0x17A78D0", VA = "0x1817A8ED0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IBMFLGHEPKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EFDJCEGNGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public EFDJCEGNGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2423A10", Offset = "0x2422410", VA = "0x182423A10")]
		internal bool <GetSamples>b__0(global::JEMIEBFNHFJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float FLOIHJOLAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float BCCPNHIGMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::JEMIEBFNHFJ<float, T>> PEOOOJPMEBB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GHOEBJGMONO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4458C80", Offset = "0x4457680", VA = "0x184458C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4459670", Offset = "0x4458070", VA = "0x184459670")]
	public IBMFLGHEPKF(float PPKNHBCMJAE, float ECGEKFFEMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4458D00", Offset = "0x4457700", VA = "0x184458D00")]
	public bool NEOIIPICMKE(float AHOJLECBNNM, T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4458AE0", Offset = "0x44574E0", VA = "0x184458AE0")]
	public int BNHECNJKAEB(float AHOJLECBNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4459330", Offset = "0x4457D30", VA = "0x184459330")]
	public IEnumerable<T> NOOAPKAKFNL(float AHOJLECBNNM, [Optional] float? CPGPIFEDNJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4458FC0", Offset = "0x44579C0", VA = "0x184458FC0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4458B40", Offset = "0x4457540", VA = "0x184458B40")]
	private void EABNEPEKANF(float AHOJLECBNNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PGBBDBNFOFI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CFAJBNIMCNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T ACPLDDIHALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float KMLBJNLHNEG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float JPFGKLEKJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> IJAKOIIBIOM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int GJNFAGNLFJP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CFAJBNIMCNM[] GNPHBMKMMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int HLJNPGNHBKC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float CKCHPBDLOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1161940", Offset = "0x1160340", VA = "0x181161940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1161950", Offset = "0x1160350", VA = "0x181161950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3145130", Offset = "0x3143B30", VA = "0x183145130")]
	public PGBBDBNFOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3145160", Offset = "0x3143B60", VA = "0x183145160")]
	public PGBBDBNFOFI(int HGBOOPNCHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3144130", Offset = "0x3142B30", VA = "0x183144130")]
	public void CPLOAHMOJFD(float AHOJLECBNNM, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3144F90", Offset = "0x3143990", VA = "0x183144F90")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x31443B0", Offset = "0x3142DB0", VA = "0x1831443B0")]
	public bool KBIPLOLDOKP(float AGFKMBIACDJ, float JEPAAOAFCCM, out T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3143F90", Offset = "0x3142990", VA = "0x183143F90")]
	public bool AIIGLEMBJKL(float AGFKMBIACDJ, float JEPAAOAFCCM, out T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3144A90", Offset = "0x3143490", VA = "0x183144A90")]
	public void NDPCHKPNOHN(float AGFKMBIACDJ, float JEPAAOAFCCM, List<T> DFIIPKJNKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3144100", Offset = "0x3142B00", VA = "0x183144100")]
	private int BHLHACMMFOK(int NIKMMCFFLFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3144940", Offset = "0x3143340", VA = "0x183144940")]
	private void LAOPMBMKEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OGLEPOLOOAO();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T EMBJDDBPNKC(T CIEDPJMPBGL, T FAJJLJONDOF, float KNGDLMLNDII);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BIGHCNHKHOC(T MNIAGKNOHEJ, float KNGDLMLNDII);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T POHDCIIKJCO(T CIEDPJMPBGL, T FAJJLJONDOF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T JBCFPMBGPEL(T CIEDPJMPBGL, T FAJJLJONDOF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FDELAHCOKIM : global::PGBBDBNFOFI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1521670", Offset = "0x1520070", VA = "0x181521670", Slot = "4")]
	protected override Vector3 OGLEPOLOOAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x122F130", Offset = "0x122DB30", VA = "0x18122F130", Slot = "5")]
	protected override Vector3 EMBJDDBPNKC(Vector3 CIEDPJMPBGL, Vector3 FAJJLJONDOF, float KNGDLMLNDII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6362C00", Offset = "0x6361600", VA = "0x186362C00", Slot = "6")]
	protected override Vector3 BIGHCNHKHOC(Vector3 MNIAGKNOHEJ, float KNGDLMLNDII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6362CD0", Offset = "0x63616D0", VA = "0x186362CD0", Slot = "7")]
	protected override Vector3 POHDCIIKJCO(Vector3 CIEDPJMPBGL, Vector3 FAJJLJONDOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6362C60", Offset = "0x6361660", VA = "0x186362C60", Slot = "8")]
	protected override Vector3 JBCFPMBGPEL(Vector3 CIEDPJMPBGL, Vector3 FAJJLJONDOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6362D50", Offset = "0x6361750", VA = "0x186362D50")]
	public FDELAHCOKIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EPGEDIJBLNG : global::PGBBDBNFOFI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6362B20", Offset = "0x6361520", VA = "0x186362B20")]
	public EPGEDIJBLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6362B90", Offset = "0x6361590", VA = "0x186362B90")]
	public EPGEDIJBLNG(int HGBOOPNCHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "4")]
	protected override float OGLEPOLOOAO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3932920", Offset = "0x3931320", VA = "0x183932920", Slot = "5")]
	protected override float EMBJDDBPNKC(float CIEDPJMPBGL, float FAJJLJONDOF, float KNGDLMLNDII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x53E7AE0", Offset = "0x53E64E0", VA = "0x1853E7AE0", Slot = "6")]
	protected override float BIGHCNHKHOC(float MNIAGKNOHEJ, float KNGDLMLNDII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2937EF0", Offset = "0x29368F0", VA = "0x182937EF0", Slot = "7")]
	protected override float POHDCIIKJCO(float CIEDPJMPBGL, float FAJJLJONDOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6362B10", Offset = "0x6361510", VA = "0x186362B10", Slot = "8")]
	protected override float JBCFPMBGPEL(float CIEDPJMPBGL, float FAJJLJONDOF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EBBEELINNHF
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D566A0", Offset = "0x1D550A0", VA = "0x181D566A0")]
	public static global::AANEBLPHHFK<T1> GANMJPNFBJN<T1>(T1 NAKJJENCIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22ECC40", Offset = "0x22EB640", VA = "0x1822ECC40")]
	public static global::JEMIEBFNHFJ<T1, T2> GANMJPNFBJN<T1, T2>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22ECCB0", Offset = "0x22EB6B0", VA = "0x1822ECCB0")]
	public static global::BDKAGNLNBBH<T1, T2, T3> GANMJPNFBJN<T1, T2, T3>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x223C7C0", Offset = "0x223B1C0", VA = "0x18223C7C0")]
	public static global::JHJJKINGNBC<T1, T2, T3, T4> GANMJPNFBJN<T1, T2, T3, T4>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x22ECF80", Offset = "0x22EB980", VA = "0x1822ECF80")]
	public static global::EHAPINNMMGD<T1, T2, T3, T4, T5> GANMJPNFBJN<T1, T2, T3, T4, T5>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22ECED0", Offset = "0x22EB8D0", VA = "0x1822ECED0")]
	public static global::GEPFKEEIGOE<T1, T2, T3, T4, T5, T6> GANMJPNFBJN<T1, T2, T3, T4, T5, T6>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM, T6 EIGAOHMAJKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x22ECE10", Offset = "0x22EB810", VA = "0x1822ECE10")]
	public static global::GGILNCMHECG<T1, T2, T3, T4, T5, T6, T7> GANMJPNFBJN<T1, T2, T3, T4, T5, T6, T7>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM, T6 EIGAOHMAJKF, T7 MCMPIMBDFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22ECD40", Offset = "0x22EB740", VA = "0x1822ECD40")]
	public static global::HJHOPKMIKAN<T1, T2, T3, T4, T5, T6, T7, T8> GANMJPNFBJN<T1, T2, T3, T4, T5, T6, T7, T8>(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM, T6 EIGAOHMAJKF, T7 MCMPIMBDFIH, T8 NMOAHONHAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1A31E40", Offset = "0x1A30840", VA = "0x181A31E40")]
	[IteratorStateMachine(typeof(GDKFELHPJED))]
	public static IEnumerable<global::JEMIEBFNHFJ<T1, T2>> BILDAGMGIDJ<T1, T2>(IEnumerable<T1> PKEMCIANHMO, IEnumerable<T2> DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A32020", Offset = "0x1A30A20", VA = "0x181A32020")]
	[IteratorStateMachine(typeof(ICPJAJICNHO))]
	public static IEnumerable<global::BDKAGNLNBBH<T1, T2, T3>> BILDAGMGIDJ<T1, T2, T3>(IEnumerable<T1> PKEMCIANHMO, IEnumerable<T2> DLAMIJMLOOE, IEnumerable<T3> LKLPGHLLEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x85CED0", Offset = "0x85B8D0", VA = "0x18085CED0")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85CEA0", Offset = "0x85B8A0", VA = "0x18085CEA0")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE, int PDFPHAEDKAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85CE80", Offset = "0x85B880", VA = "0x18085CE80")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE, int PDFPHAEDKAE, int MJIJPKJIPFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85CEB0", Offset = "0x85B8B0", VA = "0x18085CEB0")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE, int PDFPHAEDKAE, int MJIJPKJIPFN, int FGGJFOOHLGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6362910", Offset = "0x6361310", VA = "0x186362910")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE, int PDFPHAEDKAE, int MJIJPKJIPFN, int FGGJFOOHLGO, int FAGPHAODLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6362930", Offset = "0x6361330", VA = "0x186362930")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE, int PDFPHAEDKAE, int MJIJPKJIPFN, int FGGJFOOHLGO, int FAGPHAODLMO, int BOLGNCCNPNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6362960", Offset = "0x6361360", VA = "0x186362960")]
	internal static int BPHKNMODEFM(int GCIHNHCBONL, int PKMMAEJBLJE, int PDFPHAEDKAE, int MJIJPKJIPFN, int FGGJFOOHLGO, int FAGPHAODLMO, int BOLGNCCNPNG, int FLONIOEEGKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AANEBLPHHFK<T1> : IComparable<global::AANEBLPHHFK<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDD290", VA = "0x181FDE890")]
	public AANEBLPHHFK(T1 NAKJJENCIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x35A3010", Offset = "0x35A1A10", VA = "0x1835A3010", Slot = "4")]
	public int CompareTo(global::AANEBLPHHFK<T1> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x35A3080", Offset = "0x35A1A80", VA = "0x1835A3080", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90BEB0", VA = "0x18090D4B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x35A3120", Offset = "0x35A1B20", VA = "0x1835A3120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JEMIEBFNHFJ<T1, T2> : IComparable<global::JEMIEBFNHFJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A53BB0", Offset = "0x2A525B0", VA = "0x182A53BB0")]
	public JEMIEBFNHFJ(T1 NAKJJENCIOG, T2 OCFOCJOEDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x30BAC00", Offset = "0x30B9600", VA = "0x1830BAC00", Slot = "4")]
	public int CompareTo(global::JEMIEBFNHFJ<T1, T2> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x30BAEB0", Offset = "0x30B98B0", VA = "0x1830BAEB0", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x30BBA70", Offset = "0x30BA470", VA = "0x1830BBA70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x30BC000", Offset = "0x30BAA00", VA = "0x1830BC000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BDKAGNLNBBH<T1, T2, T3> : IComparable<global::BDKAGNLNBBH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 APEJEJDEMGM;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26CA2D0", Offset = "0x26C8CD0", VA = "0x1826CA2D0")]
	public BDKAGNLNBBH(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26C9AC0", Offset = "0x26C84C0", VA = "0x1826C9AC0", Slot = "4")]
	public int CompareTo(global::BDKAGNLNBBH<T1, T2, T3> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x26C9CC0", Offset = "0x26C86C0", VA = "0x1826C9CC0", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x26C9FB0", Offset = "0x26C89B0", VA = "0x1826C9FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x26CA010", Offset = "0x26C8A10", VA = "0x1826CA010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JHJJKINGNBC<T1, T2, T3, T4> : IComparable<global::JHJJKINGNBC<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 APEJEJDEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 IEJDIMNBGHO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2435400", Offset = "0x2433E00", VA = "0x182435400")]
	public JHJJKINGNBC(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31642D0", Offset = "0x3162CD0", VA = "0x1831642D0", Slot = "4")]
	public int CompareTo(global::JHJJKINGNBC<T1, T2, T3, T4> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3164410", Offset = "0x3162E10", VA = "0x183164410", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3164530", Offset = "0x3162F30", VA = "0x183164530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31645F0", Offset = "0x3162FF0", VA = "0x1831645F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EHAPINNMMGD<T1, T2, T3, T4, T5> : IComparable<global::EHAPINNMMGD<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 APEJEJDEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 IEJDIMNBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 OGODGNMNIPM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x23AC060", Offset = "0x23AAA60", VA = "0x1823AC060")]
	public EHAPINNMMGD(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2427C20", Offset = "0x2426620", VA = "0x182427C20", Slot = "4")]
	public int CompareTo(global::EHAPINNMMGD<T1, T2, T3, T4, T5> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2427DA0", Offset = "0x24267A0", VA = "0x182427DA0", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2427EE0", Offset = "0x24268E0", VA = "0x182427EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2427FE0", Offset = "0x24269E0", VA = "0x182427FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GEPFKEEIGOE<T1, T2, T3, T4, T5, T6> : IComparable<global::GEPFKEEIGOE<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 APEJEJDEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 IEJDIMNBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 OGODGNMNIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 FBELDJOEPPA;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3124EA0", Offset = "0x31238A0", VA = "0x183124EA0")]
	public GEPFKEEIGOE(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM, T6 EIGAOHMAJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31248E0", Offset = "0x31232E0", VA = "0x1831248E0", Slot = "4")]
	public int CompareTo(global::GEPFKEEIGOE<T1, T2, T3, T4, T5, T6> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3124AA0", Offset = "0x31234A0", VA = "0x183124AA0", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3124C10", Offset = "0x3123610", VA = "0x183124C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3124D30", Offset = "0x3123730", VA = "0x183124D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GGILNCMHECG<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::GGILNCMHECG<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 APEJEJDEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 IEJDIMNBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 OGODGNMNIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 FBELDJOEPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 DOGOMMFBBJJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x31258E0", Offset = "0x31242E0", VA = "0x1831258E0")]
	public GGILNCMHECG(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM, T6 EIGAOHMAJKF, T7 MCMPIMBDFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3125260", Offset = "0x3123C60", VA = "0x183125260", Slot = "4")]
	public int CompareTo(global::GGILNCMHECG<T1, T2, T3, T4, T5, T6, T7> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3125460", Offset = "0x3123E60", VA = "0x183125460", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3125600", Offset = "0x3124000", VA = "0x183125600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3125750", Offset = "0x3124150", VA = "0x183125750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HJHOPKMIKAN<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::HJHOPKMIKAN<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 IHMMNMMBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 PNMAOABCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 APEJEJDEMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 IEJDIMNBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 OGODGNMNIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 FBELDJOEPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 DOGOMMFBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 EHJBDEAKDOO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5E20", Offset = "0x3BA4820", VA = "0x183BA5E20")]
	public HJHOPKMIKAN(T1 NAKJJENCIOG, T2 OCFOCJOEDLE, T3 NIHLLLOOHJO, T4 GPCIGCPPDNO, T5 FHPNKEINKNM, T6 EIGAOHMAJKF, T7 MCMPIMBDFIH, T8 NMOAHONHAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3BA56F0", Offset = "0x3BA40F0", VA = "0x183BA56F0", Slot = "4")]
	public int CompareTo(global::HJHOPKMIKAN<T1, T2, T3, T4, T5, T6, T7, T8> DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5940", Offset = "0x3BA4340", VA = "0x183BA5940", Slot = "0")]
	public override bool Equals(object DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5B00", Offset = "0x3BA4500", VA = "0x183BA5B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5C70", Offset = "0x3BA4670", VA = "0x183BA5C70", Slot = "3")]
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
	public T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B520", Offset = "0x2B29F20", VA = "0x182B2B520")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C510", Offset = "0x3D4AF10", VA = "0x183D4C510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FBCOAHCDJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x11375D0", Offset = "0x1135FD0", VA = "0x1811375D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C000", Offset = "0x3D4AA00", VA = "0x183D4C000")]
	public T ANGAFKAEOLL(float KNGDLMLNDII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C3F0", Offset = "0x3D4ADF0", VA = "0x183D4C3F0")]
	public T KFLFJNECGIE(float KNGDLMLNDII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EMBJDDBPNKC(T CIEDPJMPBGL, T FAJJLJONDOF, float KNGDLMLNDII);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3932920", Offset = "0x3931320", VA = "0x183932920", Slot = "4")]
	protected override float EMBJDDBPNKC(float CIEDPJMPBGL, float FAJJLJONDOF, float KNGDLMLNDII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6362DC0", Offset = "0x63617C0", VA = "0x186362DC0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x122F130", Offset = "0x122DB30", VA = "0x18122F130", Slot = "4")]
	protected override Vector3 EMBJDDBPNKC(Vector3 CIEDPJMPBGL, Vector3 FAJJLJONDOF, float KNGDLMLNDII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x636B1F0", Offset = "0x6369BF0", VA = "0x18636B1F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6362020", Offset = "0x6360A20", VA = "0x186362020", Slot = "4")]
	protected override Color EMBJDDBPNKC(Color CIEDPJMPBGL, Color FAJJLJONDOF, float KNGDLMLNDII)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6362070", Offset = "0x6360A70", VA = "0x186362070")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EHKJIEGPDEE : global::DBAHNGPJFGA<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6362A60", Offset = "0x6361460", VA = "0x186362A60")]
	public EHKJIEGPDEE(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6362AB0", Offset = "0x63614B0", VA = "0x186362AB0")]
	public EHKJIEGPDEE(EINABFPIHNP[] HKGGAIEHDCM, bool MILJDFGEMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x63629F0", Offset = "0x63613F0", VA = "0x1863629F0", Slot = "6")]
	protected override uint HLJGLLDFFKD(uint NFFMFBOGLMH, string MNIAGKNOHEJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KGACGPKDMHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KGACGPKDMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JJOKNOKCBNG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BGFEADHICOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public BGFEADHICOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x254E8B0", Offset = "0x254D2B0", VA = "0x18254E8B0")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DKKEONNBBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EDLGCGFOLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int BMDNPNDPDEO;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xC0DED0", Offset = "0xC0C8D0", VA = "0x180C0DED0")]
	private JJOKNOKCBNG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GKJFNCNNLLO, int JONBEJNHECF, int PLPPGBBMDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3168FF0", Offset = "0x31679F0", VA = "0x183168FF0")]
	public static global::JJOKNOKCBNG<T> EEKKKHPKBPD()
	{
		return default(global::JJOKNOKCBNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x316A450", Offset = "0x3168E50", VA = "0x18316A450")]
	public (int, int, Task<T>) NPMIBCGMFLD(int NHIJJLFOFCH, [Optional] CancellationToken KAKEKEHNCME, double JODKGBAPGIB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3169280", Offset = "0x3167C80", VA = "0x183169280")]
	public void NLAPGOIJMIK(int NHIJJLFOFCH, int PLPPGBBMDBN, in T OAFMFLFMLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JPFGFFLADGN
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6366FF0", Offset = "0x63659F0", VA = "0x186366FF0")]
	public static global::JJOKNOKCBNG<OHKLLNGFCGP> EEKKKHPKBPD()
	{
		return default(global::JJOKNOKCBNG<OHKLLNGFCGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6367040", Offset = "0x6365A40", VA = "0x186367040")]
	public static void NLAPGOIJMIK(this in global::JJOKNOKCBNG<OHKLLNGFCGP> DCIIOIKIJFP, int NHIJJLFOFCH, int PLPPGBBMDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class DPAECLBNJLA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> MNFBGCEEGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> OKJEFHDMKOA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2217480", Offset = "0x2215E80", VA = "0x182217480", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> PIEMOEPPCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x26E09C0", Offset = "0x26DF3C0", VA = "0x1826E09C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> GOPDNEMJACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2778440", Offset = "0x2776E40", VA = "0x182778440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x32A79B0", Offset = "0x32A63B0", VA = "0x1832A79B0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x32A79F0", Offset = "0x32A63F0", VA = "0x1832A79F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x32A6890", Offset = "0x32A5290", VA = "0x1832A6890")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x32A6700", Offset = "0x32A5100", VA = "0x1832A6700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32A6C30", Offset = "0x32A5630", VA = "0x1832A6C30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x32A7880", Offset = "0x32A6280", VA = "0x1832A7880", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x32A67B0", Offset = "0x32A51B0", VA = "0x1832A67B0", Slot = "9")]
	public void Add(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x32A6820", Offset = "0x32A5220", VA = "0x1832A6820", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x32A6C90", Offset = "0x32A5690", VA = "0x1832A6C90", Slot = "8")]
	public bool ContainsKey(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x32A6CC0", Offset = "0x32A56C0", VA = "0x1832A6CC0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x32A7750", Offset = "0x32A6150", VA = "0x1832A7750", Slot = "10")]
	public bool Remove(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x32A7780", Offset = "0x32A6180", VA = "0x1832A7780", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4BE0", Offset = "0x2EB35E0", VA = "0x182EB4BE0", Slot = "11")]
	public bool TryGetValue(TKey AJPNMLHDHNM, out TVal MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA800", Offset = "0x2EA9200", VA = "0x182EAA800", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x32A6D50", Offset = "0x32A5750", VA = "0x1832A6D50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x32A6BF0", Offset = "0x32A55F0", VA = "0x1832A6BF0")]
	public void CPLOAHMOJFD(TVal NJHLDPLGBEK, TKey AJPNMLHDHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x32A6B40", Offset = "0x32A5540", VA = "0x1832A6B40")]
	public void CPLOAHMOJFD(KeyValuePair<TVal, TKey> DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x32A6A10", Offset = "0x32A5410", VA = "0x1832A6A10")]
	public bool CKGLBKMGGPC(TVal AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x32A6DE0", Offset = "0x32A57E0", VA = "0x1832A6DE0")]
	public bool GGIBFCBBJNK(KeyValuePair<TVal, TKey> DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x32A76E0", Offset = "0x32A60E0", VA = "0x1832A76E0")]
	public bool OLCIACFECIH(TVal AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x32A76E0", Offset = "0x32A60E0", VA = "0x1832A76E0")]
	public bool OLCIACFECIH(KeyValuePair<TVal, TKey> DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x32A6A80", Offset = "0x32A5480", VA = "0x1832A6A80")]
	public bool CKMNFEFPOIP(TVal AJPNMLHDHNM, out TKey MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x32A6950", Offset = "0x32A5350", VA = "0x1832A6950")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CHIFDHCGKHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x32A7400", Offset = "0x32A5E00", VA = "0x1832A7400")]
	private void LGKFELJEIMH(TKey AJPNMLHDHNM, TVal NJHLDPLGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x32A7640", Offset = "0x32A6040", VA = "0x1832A7640")]
	private void MMPIBJFGNHJ(TKey AJPNMLHDHNM, TVal NJHLDPLGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x32A71F0", Offset = "0x32A5BF0", VA = "0x1832A71F0")]
	private bool JOGLKIKOOLG(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x32A7050", Offset = "0x32A5A50", VA = "0x1832A7050")]
	private bool JOGLKIKOOLG(TVal NJHLDPLGBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x32A78D0", Offset = "0x32A62D0", VA = "0x1832A78D0")]
	public DPAECLBNJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class BJANJJGPDIC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::BJANJJGPDIC<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x30DCEE0", Offset = "0x30DB8E0", VA = "0x1830DCEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x30DDD20", Offset = "0x30DC720", VA = "0x1830DDD20")]
		public Enumerator(global::BJANJJGPDIC<T> DFIIPKJNKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x30D7830", Offset = "0x30D6230", VA = "0x1830D7830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x30DA4D0", Offset = "0x30D8ED0", VA = "0x1830DA4D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x30D6D90", Offset = "0x30D5790", VA = "0x1830D6D90")]
		private void LOEDBINEJDP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] PDHGIAOOCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int FHINICACAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int KIGPBFEMNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int FMHBAJCDDEI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x318C2C0", Offset = "0x318ACC0", VA = "0x18318C2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x318AED0", Offset = "0x31898D0", VA = "0x18318AED0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x318AD00", Offset = "0x3189700", VA = "0x18318AD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x318CB50", Offset = "0x318B550", VA = "0x18318CB50")]
	public BJANJJGPDIC(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x318BC40", Offset = "0x318A640", VA = "0x18318BC40")]
	public void CPLOAHMOJFD(T KNGDLMLNDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x318B270", Offset = "0x3189C70", VA = "0x18318B270")]
	public void BIFBNKEJGFP(IEnumerable<T> FKCNIJHFEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x318C300", Offset = "0x318AD00", VA = "0x18318C300")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x318C320", Offset = "0x318AD20", VA = "0x18318C320")]
	public void OFEEKDDGAEB(int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x318BE70", Offset = "0x318A870", VA = "0x18318BE70")]
	public void ILADBFFPKAL(int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x318C700", Offset = "0x318B100", VA = "0x18318C700")]
	public void OLPDNNNAMFB(T[] GNPHBMKMMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x318C3F0", Offset = "0x318ADF0", VA = "0x18318C3F0")]
	public Enumerator OGILHMGHFKK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x318C9D0", Offset = "0x318B3D0", VA = "0x18318C9D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x318C9D0", Offset = "0x318B3D0", VA = "0x18318C9D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x318BFF0", Offset = "0x318A9F0", VA = "0x18318BFF0")]
	private int JHLEJEMGAMI(int GFDMFLGCBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x318C9A0", Offset = "0x318B3A0", VA = "0x18318C9A0")]
	private int PKBPHIMHLGG(int GFDMFLGCBKB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class LOAPKFAGKLK<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> JDMAAJJIAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> JIGHDAFLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> DGJJNLBHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77B170", Offset = "0x779B70", VA = "0x18077B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2999D20", Offset = "0x2998720", VA = "0x182999D20", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2999DC0", Offset = "0x29987C0", VA = "0x182999DC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2999CC0", Offset = "0x29986C0", VA = "0x182999CC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2999C30", Offset = "0x2998630", VA = "0x182999C30")]
	public LOAPKFAGKLK(Func<Internal, External> JDMAAJJIAIA, Func<External, Internal> JIGHDAFLPPD, bool IJLDOICDBDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2999950", Offset = "0x2998350", VA = "0x182999950", Slot = "6")]
	public int IndexOf(External DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x29995D0", Offset = "0x2997FD0", VA = "0x1829995D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2999630", Offset = "0x2998030", VA = "0x182999630", Slot = "13")]
	public bool Contains(External DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x29996C0", Offset = "0x29980C0", VA = "0x1829996C0", Slot = "14")]
	public void CopyTo(External[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x29994E0", Offset = "0x2997EE0", VA = "0x1829994E0", Slot = "11")]
	public void Add(External DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2999A40", Offset = "0x2998440", VA = "0x182999A40", Slot = "7")]
	public void Insert(int GFDMFLGCBKB, External DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2999BA0", Offset = "0x29985A0", VA = "0x182999BA0", Slot = "15")]
	public bool Remove(External DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2999AE0", Offset = "0x29984E0", VA = "0x182999AE0", Slot = "8")]
	public void RemoveAt(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x29998E0", Offset = "0x29982E0", VA = "0x1829998E0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2714950", Offset = "0x2713350", VA = "0x182714950", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class HLKPOHMEINN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> JDMAAJJIAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> DGJJNLBHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x35F4CD0", Offset = "0x35F36D0", VA = "0x1835F4CD0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x35F4C70", Offset = "0x35F3670", VA = "0x1835F4C70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDD290", VA = "0x181FDE890")]
	public HLKPOHMEINN(Func<Internal, External> JDMAAJJIAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x35F4C20", Offset = "0x35F3620", VA = "0x1835F4C20")]
	public HLKPOHMEINN(IReadOnlyList<Internal> OKDFPKLCDDM, Func<Internal, External> JDMAAJJIAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35F4A00", Offset = "0x35F3400", VA = "0x1835F4A00")]
	public void OLPDNNNAMFB(External[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35F4990", Offset = "0x35F3390", VA = "0x1835F4990", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x24356D0", Offset = "0x24340D0", VA = "0x1824356D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class JNBLADBMJAM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> DGJJNLBHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x31790D0", Offset = "0x3177AD0", VA = "0x1831790D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3179070", Offset = "0x3177A70", VA = "0x183179070", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDD290", VA = "0x181FDE890")]
	public JNBLADBMJAM(IReadOnlyList<Internal> OKDFPKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3178D30", Offset = "0x3177730", VA = "0x183178D30")]
	public bool GGIBFCBBJNK(External DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3178E40", Offset = "0x3177840", VA = "0x183178E40")]
	public void OLPDNNNAMFB(External[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3178DD0", Offset = "0x31777D0", VA = "0x183178DD0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2714950", Offset = "0x2713350", VA = "0x182714950", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class HKEDNMCPFKD
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AGDIINKPFKE(object[] KGNEMFGHDAD);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected HKEDNMCPFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class LNCBICKEFOG<T> : HKEDNMCPFKD
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct ACDBNPPKKCB
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum KNLNEEHPMEC
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
		public KNLNEEHPMEC MAHAMGBPDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T CKAPOBIDCEI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int KCMPBDGJMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool MBGFPMNDMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool EOMDNKHEPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> ENJHFPFGDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<ACDBNPPKKCB> HJJNPBKGGGM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ANGCILOIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2998520", Offset = "0x2996F20", VA = "0x182998520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2998720", Offset = "0x2997120", VA = "0x182998720")]
	protected LNCBICKEFOG(bool EOMDNKHEPMG, bool MBGFPMNDMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x29986A0", Offset = "0x29970A0", VA = "0x1829986A0")]
	protected bool PNDJBMIOFIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2998040", Offset = "0x2996A40", VA = "0x182998040")]
	protected void AONILPPMNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2998260", Offset = "0x2996C60", VA = "0x182998260")]
	protected void EFGBEKFCOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x236C7D0", Offset = "0x236B1D0", VA = "0x18236C7D0")]
	private static void PJJKBFIMEDC<U>(ref List<U> OKDFPKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2998100", Offset = "0x2996B00", VA = "0x182998100", Slot = "5")]
	public void CPLOAHMOJFD(T CKAPOBIDCEI, bool FAEGIDLPMDK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2998560", Offset = "0x2996F60", VA = "0x182998560", Slot = "6")]
	public void OLCIACFECIH(T CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2998410", Offset = "0x2996E10", VA = "0x182998410")]
	public void NMFIICNHENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PHJKPOHEPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class JCAAIAKPOCC : global::LNCBICKEFOG<Action>, PHJKPOHEPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6365510", Offset = "0x6363F10", VA = "0x186365510")]
	public JCAAIAKPOCC(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x63652A0", Offset = "0x6363CA0", VA = "0x1863652A0")]
	public void OOHNAJGMKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x63651D0", Offset = "0x6363BD0", VA = "0x1863651D0", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6365240", Offset = "0x6363C40", VA = "0x186365240")]
	public static JCAAIAKPOCC GAMHLIOKLMA(JCAAIAKPOCC HDGOALCGHDA, Action CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x63654B0", Offset = "0x6363EB0", VA = "0x1863654B0")]
	public static JCAAIAKPOCC PBCOCCEPJGF(JCAAIAKPOCC HDGOALCGHDA, Action CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JJINPDGLAJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action<T> CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action<T> CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CHNCEGIAGIM<T> : global::LNCBICKEFOG<Action<T>>, global::JJINPDGLAJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8EA0", Offset = "0x1FE78A0", VA = "0x181FE8EA0")]
	public CHNCEGIAGIM(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x37AD030", Offset = "0x37ABA30", VA = "0x1837AD030")]
	public void OOHNAJGMKOC(T KNGDLMLNDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x37AB720", Offset = "0x37AA120", VA = "0x1837AB720", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x24DF660", Offset = "0x24DE060", VA = "0x1824DF660")]
	public static global::CHNCEGIAGIM<T> GAMHLIOKLMA(global::CHNCEGIAGIM<T> HDGOALCGHDA, Action<T> CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24DFB90", Offset = "0x24DE590", VA = "0x1824DFB90")]
	public static global::CHNCEGIAGIM<T> PBCOCCEPJGF(global::CHNCEGIAGIM<T> HDGOALCGHDA, Action<T> CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PNHCMBCOKGH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action<T, U> CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action<T, U> CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class OMHDGNNJAPI<T, U> : global::LNCBICKEFOG<Action<T, U>>, global::PNHCMBCOKGH<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8EA0", Offset = "0x1FE78A0", VA = "0x181FE8EA0")]
	public OMHDGNNJAPI(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5BB0", Offset = "0x2EC45B0", VA = "0x182EC5BB0")]
	public void OOHNAJGMKOC(T KNGDLMLNDII, U EJBEKBOMHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2EC52A0", Offset = "0x2EC3CA0", VA = "0x182EC52A0", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5450", Offset = "0x2EC3E50", VA = "0x182EC5450")]
	public static global::OMHDGNNJAPI<T, U> GAMHLIOKLMA(global::OMHDGNNJAPI<T, U> HDGOALCGHDA, Action<T, U> CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5DF0", Offset = "0x2EC47F0", VA = "0x182EC5DF0")]
	public static global::OMHDGNNJAPI<T, U> PBCOCCEPJGF(global::OMHDGNNJAPI<T, U> HDGOALCGHDA, Action<T, U> CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CFFLMAOMEDN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action<T, U, V> CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action<T, U, V> CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BIKJMNNNOIL<T, U, V> : global::LNCBICKEFOG<Action<T, U, V>>, global::CFFLMAOMEDN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8EA0", Offset = "0x1FE78A0", VA = "0x181FE8EA0")]
	public BIKJMNNNOIL(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3188F60", Offset = "0x3187960", VA = "0x183188F60")]
	public void OOHNAJGMKOC(T KNGDLMLNDII, U EJBEKBOMHMF, V ELMMBEILPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x31875F0", Offset = "0x3185FF0", VA = "0x1831875F0", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x31882D0", Offset = "0x3186CD0", VA = "0x1831882D0")]
	public static global::BIKJMNNNOIL<T, U, V> GAMHLIOKLMA(global::BIKJMNNNOIL<T, U, V> HDGOALCGHDA, Action<T, U, V> CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x318A3E0", Offset = "0x3188DE0", VA = "0x18318A3E0")]
	public static global::BIKJMNNNOIL<T, U, V> PBCOCCEPJGF(global::BIKJMNNNOIL<T, U, V> HDGOALCGHDA, Action<T, U, V> CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NLHBDJPLPKE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action<T, U, V, W> CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action<T, U, V, W> CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class LACPMNADHJO<T, U, V, W> : global::LNCBICKEFOG<Action<T, U, V, W>>, global::NLHBDJPLPKE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8EA0", Offset = "0x1FE78A0", VA = "0x181FE8EA0")]
	public LACPMNADHJO(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7B90", Offset = "0x1FE6590", VA = "0x181FE7B90")]
	public void OOHNAJGMKOC(T KNGDLMLNDII, U EJBEKBOMHMF, V ELMMBEILPIG, W FJOCGIOEKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7310", Offset = "0x1FE5D10", VA = "0x181FE7310", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7860", Offset = "0x1FE6260", VA = "0x181FE7860")]
	public static global::LACPMNADHJO<T, U, V, W> GAMHLIOKLMA(global::LACPMNADHJO<T, U, V, W> HDGOALCGHDA, Action<T, U, V, W> CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8E00", Offset = "0x1FE7800", VA = "0x181FE8E00")]
	public static global::LACPMNADHJO<T, U, V, W> PBCOCCEPJGF(global::LACPMNADHJO<T, U, V, W> HDGOALCGHDA, Action<T, U, V, W> CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface AEKNDLDIFFP<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action<T, U, V, W, X> CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action<T, U, V, W, X> CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class BPJPCMCKOPJ<T, U, V, W, X> : global::LNCBICKEFOG<Action<T, U, V, W, X>>, global::AEKNDLDIFFP<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8EA0", Offset = "0x1FE78A0", VA = "0x181FE8EA0")]
	public BPJPCMCKOPJ(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2711F20", Offset = "0x2710920", VA = "0x182711F20")]
	public void OOHNAJGMKOC(T KNGDLMLNDII, U EJBEKBOMHMF, V ELMMBEILPIG, W FJOCGIOEKMK, X MEALLDFELFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2711870", Offset = "0x2710270", VA = "0x182711870", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2711E80", Offset = "0x2710880", VA = "0x182711E80")]
	public static global::BPJPCMCKOPJ<T, U, V, W, X> GAMHLIOKLMA(global::BPJPCMCKOPJ<T, U, V, W, X> HDGOALCGHDA, Action<T, U, V, W, X> CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x27124E0", Offset = "0x2710EE0", VA = "0x1827124E0")]
	public static global::BPJPCMCKOPJ<T, U, V, W, X> PBCOCCEPJGF(global::BPJPCMCKOPJ<T, U, V, W, X> HDGOALCGHDA, Action<T, U, V, W, X> CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JPHFCDONEHP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(Action<T, U, V, W, X, Y> CKAPOBIDCEI, bool FAEGIDLPMDK = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCIACFECIH(Action<T, U, V, W, X, Y> CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class GDKAAGHKDKH<T, U, V, W, X, Y> : global::LNCBICKEFOG<Action<T, U, V, W, X, Y>>, global::JPHFCDONEHP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8EA0", Offset = "0x1FE78A0", VA = "0x181FE8EA0")]
	public GDKAAGHKDKH(bool EOMDNKHEPMG = false, bool MBGFPMNDMHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A83F20", Offset = "0x2A82920", VA = "0x182A83F20")]
	public void OOHNAJGMKOC(T KNGDLMLNDII, U EJBEKBOMHMF, V ELMMBEILPIG, W FJOCGIOEKMK, X MEALLDFELFM, Y LOIOEMHMDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2A82EB0", Offset = "0x2A818B0", VA = "0x182A82EB0", Slot = "4")]
	public override void AGDIINKPFKE(object[] KGNEMFGHDAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A838B0", Offset = "0x2A822B0", VA = "0x182A838B0")]
	public static global::GDKAAGHKDKH<T, U, V, W, X, Y> GAMHLIOKLMA(global::GDKAAGHKDKH<T, U, V, W, X, Y> HDGOALCGHDA, Action<T, U, V, W, X, Y> CKAPOBIDCEI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2A841D0", Offset = "0x2A82BD0", VA = "0x182A841D0")]
	public static global::GDKAAGHKDKH<T, U, V, W, X, Y> PBCOCCEPJGF(global::GDKAAGHKDKH<T, U, V, W, X, Y> HDGOALCGHDA, Action<T, U, V, W, X, Y> CKAPOBIDCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LBFEGFGFGGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct FODDMFBAHIL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::LBFEGFGFGGM<T> FCJJFDLIJOC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T ACPLDDIHALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2FA7070", Offset = "0x2FA5A70", VA = "0x182FA7070")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2FA7040", Offset = "0x2FA5A40", VA = "0x182FA7040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
		public FODDMFBAHIL(global::LBFEGFGFGGM<T> FCJJFDLIJOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KPOGLOCHGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<FODDMFBAHIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::LBFEGFGFGGM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3B7CF70", Offset = "0x3B7B970", VA = "0x183B7CF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1D69B90", Offset = "0x1D68590", VA = "0x181D69B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FKIDODKBFLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<FODDMFBAHIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::LBFEGFGFGGM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x28AC8F0", Offset = "0x28AB2F0", VA = "0x1828AC8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1D69B90", Offset = "0x1D68590", VA = "0x181D69B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim EIHKFBKFJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T LIMPGHMAPAJ;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int BNOHDBDNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2547A80", Offset = "0x2546480", VA = "0x182547A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2548110", Offset = "0x2546B10", VA = "0x182548110")]
	public LBFEGFGFGGM(in T LIMPGHMAPAJ, int HPPEACFEPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x25480E0", Offset = "0x2546AE0", VA = "0x1825480E0")]
	public LBFEGFGFGGM(in T LIMPGHMAPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2547A00", Offset = "0x2546400", VA = "0x182547A00")]
	public FODDMFBAHIL AGCLGGPLHDI()
	{
		return default(FODDMFBAHIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2547A40", Offset = "0x2546440", VA = "0x182547A40")]
	public FODDMFBAHIL AGCLGGPLHDI(CancellationToken KAKEKEHNCME)
	{
		return default(FODDMFBAHIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2547EE0", Offset = "0x25468E0", VA = "0x182547EE0")]
	[AsyncStateMachine(typeof(global::LBFEGFGFGGM<>.KPOGLOCHGOH))]
	public Task<FODDMFBAHIL> JIAPFKCELLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2547AA0", Offset = "0x25464A0", VA = "0x182547AA0")]
	[AsyncStateMachine(typeof(global::LBFEGFGFGGM<>.FKIDODKBFLO))]
	public Task<FODDMFBAHIL> JIAPFKCELLK(CancellationToken KAKEKEHNCME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BPPHFBCCNGP
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6361A10", Offset = "0x6360410", VA = "0x186361A10")]
	public static global::LBFEGFGFGGM<OHKLLNGFCGP> EEKKKHPKBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6361A70", Offset = "0x6360470", VA = "0x186361A70")]
	public static global::LBFEGFGFGGM<OHKLLNGFCGP> EEKKKHPKBPD(int HPPEACFEPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1D566A0", Offset = "0x1D550A0", VA = "0x181D566A0")]
	public static global::LBFEGFGFGGM<T> EEKKKHPKBPD<T>(in T LIMPGHMAPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x267CF10", Offset = "0x267B910", VA = "0x18267CF10")]
	public static global::LBFEGFGFGGM<T> EEKKKHPKBPD<T>(in T LIMPGHMAPAJ, int HPPEACFEPMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BMBCMIAHDIP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> FFCJKCCIKIJ(TRequest NONPDGFJDAK, CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum FKIJAOKEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class HAHEHHGOFMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float OOKEKKJEMFE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan DKMIGFOCMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int LLODHOEIADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public FKIJAOKEMGM BIOIEDIJLJP;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly HAHEHHGOFMB JPMFPEEJFPH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float NKJFJAPBDBD
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3809FA0", Offset = "0x38089A0", VA = "0x183809FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan KPMOBIFGLND
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x380A010", Offset = "0x3808A10", VA = "0x18380A010")]
		public HAHEHHGOFMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct ICAAAGJFFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest NONPDGFJDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken KAKEKEHNCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> AJHPOFPBMEJ;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x445A100", Offset = "0x4458B00", VA = "0x18445A100")]
		public ICAAAGJFFHB(TRequest NONPDGFJDAK, TaskCompletionSource<TResult> AJHPOFPBMEJ, CancellationToken KAKEKEHNCME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class NDICOGLMODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public NDICOGLMODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2217480", Offset = "0x2215E80", VA = "0x182217480")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct KMPOLPBIJPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::BMBCMIAHDIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3122130", Offset = "0x3120B30", VA = "0x183122130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct DGCKJMBNNBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::BMBCMIAHDIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ICAAAGJFFHB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2594F60", Offset = "0x2593960", VA = "0x182594F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource BMNJFJBJOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<ICAAAGJFFHB> NEHICEEBNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HAHEHHGOFMB MFDIGCDICHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly FFCJKCCIKIJ AKCDFGBEMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task GGFMJHFICCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HKCMFADHAEJ;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x27091B0", Offset = "0x2707BB0", VA = "0x1827091B0")]
	public BMBCMIAHDIP(FFCJKCCIKIJ AKCDFGBEMJA, [Optional] HAHEHHGOFMB MFDIGCDICHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2707B70", Offset = "0x2706570", VA = "0x182707B70")]
	public Task<TResult> EALHHDKCKGL(TRequest NONPDGFJDAK, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2708150", Offset = "0x2706B50", VA = "0x182708150")]
	private void EBFABIICBIP(ICAAAGJFFHB KDGGANFCFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x27088B0", Offset = "0x27072B0", VA = "0x1827088B0")]
	[AsyncStateMachine(typeof(global::BMBCMIAHDIP<, >.KMPOLPBIJPO))]
	private Task IDOGFEFCACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2708F60", Offset = "0x2707960", VA = "0x182708F60")]
	private ICAAAGJFFHB KHNPNJINNFM()
	{
		return default(ICAAAGJFFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2708570", Offset = "0x2706F70", VA = "0x182708570")]
	[AsyncStateMachine(typeof(global::BMBCMIAHDIP<, >.DGCKJMBNNBN))]
	private Task GBOONLECACE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2708380", Offset = "0x2706D80", VA = "0x182708380")]
	private void FEBKCLOABKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x27078C0", Offset = "0x27062C0", VA = "0x1827078C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class HLKDDJFCCMO<TKey, TVal> : global::HAENEOGNPHE<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OPDOCKLHODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> PNJGMEKPHKH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int PJLMJEPIFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x35F47E0", Offset = "0x35F31E0", VA = "0x1835F47E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int HLGILGOMFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x35F4880", Offset = "0x35F3280", VA = "0x1835F4880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x35F46E0", Offset = "0x35F30E0", VA = "0x1835F46E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x35F48B0", Offset = "0x35F32B0", VA = "0x1835F48B0")]
	public HLKDDJFCCMO(int ADCMDGEMNDH, [Optional] GICEEKGHLDL AOEKHPLOBAE, [Optional] IEqualityComparer<TKey> ENIJNGMKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x35F43B0", Offset = "0x35F2DB0", VA = "0x1835F43B0")]
	public void DNOCKOFLFMJ(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ, bool GHDNNCHOJKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x35F4660", Offset = "0x35F3060", VA = "0x1835F4660")]
	public bool IFCKNDPHEAA(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x35F4310", Offset = "0x35F2D10", VA = "0x1835F4310", Slot = "6")]
	public override bool CKMNFEFPOIP(TKey FKMJGJDLMJG, out TVal MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x35F4450", Offset = "0x35F2E50", VA = "0x1835F4450")]
	public bool GNEKHEOIJAH(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x35F4200", Offset = "0x35F2C00", VA = "0x1835F4200")]
	public bool AFGINFDAEJG(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x35F4810", Offset = "0x35F3210", VA = "0x1835F4810", Slot = "7")]
	public override void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x35F4740", Offset = "0x35F3140", VA = "0x1835F4740")]
	private bool LJONCEHPIJE(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class HAENEOGNPHE<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int GICEEKGHLDL(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class ALIIOLAJDHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey OKLKOGDIKDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal ACPLDDIHALN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PFDAMFBILGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6E31B0", Offset = "0x6E1BB0", VA = "0x1806E31B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA04B40", Offset = "0xA03540", VA = "0x180A04B40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime DDCACOPCPFN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xDD4070", Offset = "0xDD2A70", VA = "0x180DD4070")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x308D5B0", Offset = "0x308BFB0", VA = "0x18308D5B0")]
		public ALIIOLAJDHC(TKey AJPNMLHDHNM, TVal NJHLDPLGBEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int FDNCLDOOEEL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<ALIIOLAJDHC>> BFHEGFCBGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<ALIIOLAJDHC> KCHAFKFGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly GICEEKGHLDL AOEKHPLOBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan OJIDOHGGAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IOMMIMKMGLG GINJELEJGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int JJAPDDNEKJD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MGGIOFDCCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6C1020", Offset = "0x6BFA20", VA = "0x1806C1020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool GKDJCMIGAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3808890", Offset = "0x3807290", VA = "0x183808890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int PJLMJEPIFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x917010", Offset = "0x915A10", VA = "0x180917010", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int JOBJIONNEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD700", Offset = "0x1FDC100", VA = "0x181FDD700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x25AFE50", Offset = "0x25AE850", VA = "0x1825AFE50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> PIEMOEPPCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3808370", Offset = "0x3806D70", VA = "0x183808370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3806200", Offset = "0x3804C00", VA = "0x183806200")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x239FEC0", Offset = "0x239E8C0", VA = "0x18239FEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3809B70", Offset = "0x3808570", VA = "0x183809B70")]
	public HAENEOGNPHE(int ADCMDGEMNDH, [Optional] GICEEKGHLDL AOEKHPLOBAE, [Optional] IEqualityComparer<TKey> ENIJNGMKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x38091B0", Offset = "0x3807BB0", VA = "0x1838091B0")]
	public HAENEOGNPHE(TimeSpan OJIDOHGGAHO, [Optional] IEqualityComparer<TKey> ENIJNGMKANM, [Optional] IOMMIMKMGLG GINJELEJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3809550", Offset = "0x3807F50", VA = "0x183809550")]
	public HAENEOGNPHE(int ADCMDGEMNDH, TimeSpan OJIDOHGGAHO, [Optional] IEqualityComparer<TKey> ENIJNGMKANM, [Optional] IOMMIMKMGLG GINJELEJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x38098F0", Offset = "0x38082F0", VA = "0x1838098F0")]
	public HAENEOGNPHE(int ADCMDGEMNDH, GICEEKGHLDL AOEKHPLOBAE, TimeSpan OJIDOHGGAHO, [Optional] IEqualityComparer<TKey> ENIJNGMKANM, [Optional] IOMMIMKMGLG GINJELEJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3806520", Offset = "0x3804F20", VA = "0x183806520")]
	public void BNPEJEMPPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3808AA0", Offset = "0x38074A0", VA = "0x183808AA0")]
	public void NLANNFAIKGA(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3808CB0", Offset = "0x38076B0", VA = "0x183808CB0")]
	public bool OLCIACFECIH(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3805EB0", Offset = "0x38048B0", VA = "0x183805EB0")]
	private TVal AGGAFJIIBKL(TKey FKMJGJDLMJG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3807110", Offset = "0x3805B10", VA = "0x183807110", Slot = "6")]
	public virtual bool CKMNFEFPOIP(TKey FKMJGJDLMJG, out TVal MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3808C40", Offset = "0x3807640", VA = "0x183808C40", Slot = "7")]
	public virtual void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3808590", Offset = "0x3806F90", VA = "0x183808590")]
	private bool JKOGHKEFNMC(ALIIOLAJDHC HCFDDBAPOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3807A60", Offset = "0x3806460", VA = "0x183807A60")]
	private void HPEHABFCDGI(LinkedListNode<ALIIOLAJDHC> GMONMHDEOBH, TVal ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3806C50", Offset = "0x3805650", VA = "0x183806C50")]
	private void CJGAFMKLKKJ(TKey AJPNMLHDHNM, TVal MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3807710", Offset = "0x3806110", VA = "0x183807710")]
	private void DDMHBCLDCPN(ALIIOLAJDHC HCFDDBAPOLK, TVal ONFBDMEKEAL, int IEOCOKIDJIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class PKGBCHODALJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> OKDFPKLCDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> DCHCKLMBNDB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2217480", Offset = "0x2215E80", VA = "0x182217480", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x235FD70", Offset = "0x235E770", VA = "0x18235FD70", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A55650", Offset = "0x2A54050", VA = "0x182A55650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x259F860", Offset = "0x259E260", VA = "0x18259F860", Slot = "11")]
	public void Add(T DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A55170", Offset = "0x2A53B70", VA = "0x182A55170")]
	public bool MMAIIPOKGMB(T DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A554F0", Offset = "0x2A53EF0", VA = "0x182A554F0", Slot = "15")]
	public bool Remove(T DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A54F30", Offset = "0x2A53930", VA = "0x182A54F30", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x221A520", Offset = "0x2218F20", VA = "0x18221A520", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A54E70", Offset = "0x2A53870", VA = "0x182A54E70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A54ED0", Offset = "0x2A538D0", VA = "0x182A54ED0", Slot = "13")]
	public bool Contains(T DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A54F00", Offset = "0x2A53900", VA = "0x182A54F00", Slot = "14")]
	public void CopyTo(T[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A54FB0", Offset = "0x2A539B0", VA = "0x182A54FB0", Slot = "6")]
	public int IndexOf(T DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A54FE0", Offset = "0x2A539E0", VA = "0x182A54FE0", Slot = "7")]
	public void Insert(int GFDMFLGCBKB, T DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A55390", Offset = "0x2A53D90", VA = "0x182A55390", Slot = "8")]
	public void RemoveAt(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A54DA0", Offset = "0x2A537A0", VA = "0x182A54DA0")]
	public void COONOLMCGNK(Predicate<T> CCGGCFPLCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A54CA0", Offset = "0x2A536A0", VA = "0x182A54CA0")]
	public void APBPIKENCBB(Comparison<T> HIBMDJKPDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A55570", Offset = "0x2A53F70", VA = "0x182A55570")]
	public PKGBCHODALJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IJPGPBDMJGM
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6363980", Offset = "0x6362380", VA = "0x186363980")]
	public static Vector3 MHKJNEAADLG(this GameObject KEHOIMKGHCH, float KKBAHBBHEKD)
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
			[Cpp2IlInjected.Address(RVA = "0x1E86B20", Offset = "0x1E85520", VA = "0x181E86B20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x636A7B0", Offset = "0x63691B0", VA = "0x18636A7B0")]
		public SerializedGuid(in Guid CKAFGMOJCKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x636A300", Offset = "0x6368D00", VA = "0x18636A300")]
		public static SerializedGuid EBKIDEKMJKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x636A530", Offset = "0x6368F30", VA = "0x18636A530")]
		public static SerializedGuid HMEIJNNPGEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x636A650", Offset = "0x6369050", VA = "0x18636A650")]
		public bool KGPJMFHBPHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x636A780", Offset = "0x6369180", VA = "0x18636A780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x636A6E0", Offset = "0x63690E0", VA = "0x18636A6E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x636A5C0", Offset = "0x6368FC0", VA = "0x18636A5C0")]
		public bool IHGPCKFDMJE(in Guid CKAFGMOJCKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x636A390", Offset = "0x6368D90", VA = "0x18636A390", Slot = "7")]
		public bool Equals(SerializedGuid DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x636A440", Offset = "0x6368E40", VA = "0x18636A440", Slot = "0")]
		public override bool Equals(object LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x636A520", Offset = "0x6368F20", VA = "0x18636A520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x636A2D0", Offset = "0x6368CD0", VA = "0x18636A2D0", Slot = "6")]
		public int CompareTo(SerializedGuid DFHJPOKNFFB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GALDDEGGMPP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type INGMMBHJKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string LAGOMEPJHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool BMDHCFGLCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool HMMFNGCBLJN;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6362E00", Offset = "0x6361800", VA = "0x186362E00")]
	public GALDDEGGMPP(Type CEELLOBGKOE, string DHOEDJNFGMI, bool HKHLPDFNMHJ = false, bool CKPDIHGAJNL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HBIFLGDKNFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface EGMIFIDMAHF<T> : HBIFLGDKNFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BLDNOCFCIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string CLMAGKHMOPH
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
	global::EGMIFIDMAHF<T> MNAHJKFPKCP(Action<T> MMMABNPFALI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EGMIFIDMAHF<T> DDDDIJHPMCO(Action<T> MMMABNPFALI);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::EGMIFIDMAHF<T> BDDGLLBMAKO(Action<T, T> BKJDGDNOCNK);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::EGMIFIDMAHF<T> KHNLEKGCHEK(Action<T, T> BKJDGDNOCNK);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::EGMIFIDMAHF<T> LHGOFIFGBML(Action<string> JDFAKGPPKFD);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::EGMIFIDMAHF<T> IKKPMNEGBAB(Action<string> JDFAKGPPKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ODMKCBDGELG<T> : global::EGMIFIDMAHF<T>, HBIFLGDKNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::OMHDGNNJAPI<T, T> MKBKKHNFBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::CHNCEGIAGIM<T> GLJHDNMHBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::CHNCEGIAGIM<string> MJPBOANPNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string IMHLNJJFNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T OAFMFLFMLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool FKOEGCFNMCG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x17A0E00", Offset = "0x179F800", VA = "0x1817A0E00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool BLDNOCFCIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x78C540", Offset = "0x78AF40", VA = "0x18078C540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string CLMAGKHMOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xF65A20", Offset = "0xF64420", VA = "0x180F65A20", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9EF0", Offset = "0x2EA88F0", VA = "0x182EA9EF0")]
	private void IALEDAFGJMH(T EONCDECCEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9E40", Offset = "0x2EA8840", VA = "0x182EA9E40")]
	private void DKFABIPNAJA(string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA050", Offset = "0x2EA8A50", VA = "0x182EAA050")]
	public void KNCDGFAKBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9DA0", Offset = "0x2EA87A0", VA = "0x182EA9DA0", Slot = "6")]
	public global::EGMIFIDMAHF<T> BDDGLLBMAKO(Action<T, T> BKJDGDNOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA000", Offset = "0x2EA8A00", VA = "0x182EAA000", Slot = "7")]
	public global::EGMIFIDMAHF<T> KHNLEKGCHEK(Action<T, T> BKJDGDNOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA1A0", Offset = "0x2EA8BA0", VA = "0x182EAA1A0", Slot = "4")]
	public global::EGMIFIDMAHF<T> MNAHJKFPKCP(Action<T> BKJDGDNOCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9DF0", Offset = "0x2EA87F0", VA = "0x182EA9DF0", Slot = "5")]
	public global::EGMIFIDMAHF<T> DDDDIJHPMCO(Action<T> MMMABNPFALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA100", Offset = "0x2EA8B00", VA = "0x182EAA100", Slot = "8")]
	public global::EGMIFIDMAHF<T> LHGOFIFGBML(Action<string> JDFAKGPPKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2EA9F90", Offset = "0x2EA8990", VA = "0x182EA9F90", Slot = "9")]
	public global::EGMIFIDMAHF<T> IKKPMNEGBAB(Action<string> JDFAKGPPKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA230", Offset = "0x2EA8C30", VA = "0x182EAA230")]
	public ODMKCBDGELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BPOKKKKMLOF
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class CBBKBEPDNIL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::EGMIFIDMAHF<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::MECOGDILELM<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public CBBKBEPDNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3362AA0", Offset = "0x33614A0", VA = "0x183362AA0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x267CC10", Offset = "0x267B610", VA = "0x18267CC10")]
	public static global::OHPLDOPGNGG<T> LEJAKIOEKDC<T>(this global::EGMIFIDMAHF<T> JOLNHCPIAEO, Action<T> JOIALDGLEAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class CLGKLANEGOH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct EPDEGEIGNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long MMNLBEPFGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long KGEMOGANDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int GALNBDBIGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int KDENLPNPPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool GLIKLFFFKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string HNFKJNIGEIB;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x17A5BB0", Offset = "0x17A45B0", VA = "0x1817A5BB0")]
		public EPDEGEIGNNN(long MMNLBEPFGGE, int GALNBDBIGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x17A5C20", Offset = "0x17A4620", VA = "0x1817A5C20")]
		public EPDEGEIGNNN(long MMNLBEPFGGE, long KGEMOGANDNA, int GALNBDBIGJD, int KDENLPNPPGG, bool GLIKLFFFKBC, string HNFKJNIGEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x17A5AD0", Offset = "0x17A44D0", VA = "0x1817A5AD0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void OMCDLKNNNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x17A5A80", Offset = "0x17A4480", VA = "0x1817A5A80")]
		public int LBGMHBOCPPB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x17A59D0", Offset = "0x17A43D0", VA = "0x1817A59D0")]
		public int HBCJBIHFAHE(int FPMNHEIFCGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x17A5B40", Offset = "0x17A4540", VA = "0x1817A5B40")]
		public double PADDLDOAOME()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x17A59F0", Offset = "0x17A43F0", VA = "0x1817A59F0")]
		public EPDEGEIGNNN KJDKBHGIICM(long KGEMOGANDNA, int KDENLPNPPGG)
		{
			return default(EPDEGEIGNNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class PPKCEHBLCJE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey OKLKOGDIKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::CLGKLANEGOH<TKey> CEJBHGLMENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<PPKCEHBLCJE> CBFOMANHACE;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string BFOEOEDDHGN
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x179F660", Offset = "0x179E060", VA = "0x18179F660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x179F2F0", Offset = "0x179DCF0", VA = "0x18179F2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<PPKCEHBLCJE> DLHGIFABMAA
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2762440", Offset = "0x2760E40", VA = "0x182762440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public EPDEGEIGNNN JADKEENIDAI
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xFEF3C0", Offset = "0xFEDDC0", VA = "0x180FEF3C0")]
			[CompilerGenerated]
			get
			{
				return default(EPDEGEIGNNN);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2762610", Offset = "0x2761010", VA = "0x182762610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2762720", Offset = "0x2761120", VA = "0x182762720")]
		internal PPKCEHBLCJE(global::CLGKLANEGOH<TKey> CEJBHGLMENF, TKey AJPNMLHDHNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2762330", Offset = "0x2760D30", VA = "0x182762330")]
		public PPKCEHBLCJE AFHAJKHJBKM(TKey AJPNMLHDHNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2762640", Offset = "0x2761040", VA = "0x182762640")]
		public void MJPGGNHNGBH(TKey AJPNMLHDHNM, Action<PPKCEHBLCJE> CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2803950", Offset = "0x2802350", VA = "0x182803950")]
		public T MJPGGNHNGBH<T>(TKey AJPNMLHDHNM, Func<PPKCEHBLCJE, T> BDHJENCECBN)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2803AA0", Offset = "0x28024A0", VA = "0x182803AA0")]
		[AsyncStateMachine(typeof(NBLMHOBODBG))]
		public Task<T> OGBBJOPDAMI<T>(TKey AJPNMLHDHNM, Func<PPKCEHBLCJE, Task<T>> BDHJENCECBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2762460", Offset = "0x2760E60", VA = "0x182762460", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CNAMMODCCBN : IEnumerable<(TKey, List<TKey>, EPDEGEIGNNN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EPDEGEIGNNN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, EPDEGEIGNNN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::CLGKLANEGOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, EPDEGEIGNNN timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, EPDEGEIGNNN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x24E9690", Offset = "0x24E8090", VA = "0x1824E9690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EPDEGEIGNNN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x24E9700", Offset = "0x24E8100", VA = "0x1824E9700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x24E9880", Offset = "0x24E8280", VA = "0x1824E9880")]
		[DebuggerHidden]
		public CNAMMODCCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x24E9760", Offset = "0x24E8160", VA = "0x1824E9760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x24E92B0", Offset = "0x24E7CB0", VA = "0x1824E92B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x24E97C0", Offset = "0x24E81C0", VA = "0x1824E97C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x24E96C0", Offset = "0x24E80C0", VA = "0x1824E96C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x24E95D0", Offset = "0x24E7FD0", VA = "0x1824E95D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EPDEGEIGNNN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF840", Offset = "0x1FDE240", VA = "0x181FDF840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PCGCOJHFFAA : IEnumerable<(TKey, List<TKey>, EPDEGEIGNNN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EPDEGEIGNNN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, EPDEGEIGNNN timerEntry) <>2__current;

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
		private PPKCEHBLCJE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public PPKCEHBLCJE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::CLGKLANEGOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<PPKCEHBLCJE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, EPDEGEIGNNN timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, EPDEGEIGNNN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x24E9690", Offset = "0x24E8090", VA = "0x1824E9690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EPDEGEIGNNN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x3138520", Offset = "0x3136F20", VA = "0x183138520", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x24E9880", Offset = "0x24E8280", VA = "0x1824E9880")]
		[DebuggerHidden]
		public PCGCOJHFFAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3138580", Offset = "0x3136F80", VA = "0x183138580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3137E60", Offset = "0x3136860", VA = "0x183137E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3138620", Offset = "0x3137020", VA = "0x183138620")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3138680", Offset = "0x3137080", VA = "0x183138680")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x31384E0", Offset = "0x3136EE0", VA = "0x1831384E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3138400", Offset = "0x3136E00", VA = "0x183138400", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EPDEGEIGNNN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2D028B0", Offset = "0x2D012B0", VA = "0x182D028B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, EPDEGEIGNNN> GONGMPHHFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, EPDEGEIGNNN> NEFDAHIFCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::CLGKLANEGOH<TKey>> GNKJJPENOIB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string EEBHLGGPEBB = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly PPKCEHBLCJE DDHABBJCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool IAFLCEPGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int MGLNHLEFJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch ENOCBGFIEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int HDDBDFLGPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string BLJLAAGELGO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public PPKCEHBLCJE DGBKKDBDCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string BFOEOEDDHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x24E5750", Offset = "0x24E4150", VA = "0x1824E5750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long AJDCILAOBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x24E5880", Offset = "0x24E4280", VA = "0x1824E5880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int HPBLKHBKAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x24E5830", Offset = "0x24E4230", VA = "0x1824E5830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x24E5A20", Offset = "0x24E4420", VA = "0x1824E5A20")]
	public CLGKLANEGOH(TKey ECBCBFPOKBO, [Optional] int? GALNBDBIGJD, [Optional][CanBeNull] Stopwatch ENOCBGFIEFM, [Optional] Action<TKey, EPDEGEIGNNN> GONGMPHHFCA, [Optional] Action<TKey, EPDEGEIGNNN> NEFDAHIFCPF, [Optional] Action<global::CLGKLANEGOH<TKey>> GNKJJPENOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x24E56C0", Offset = "0x24E40C0", VA = "0x1824E56C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x24E58A0", Offset = "0x24E42A0", VA = "0x1824E58A0")]
	public void OPBOCGOCLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x24E5860", Offset = "0x24E4260", VA = "0x1824E5860")]
	public void LNMOMOLKDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x24E5990", Offset = "0x24E4390", VA = "0x1824E5990")]
	[IteratorStateMachine(typeof(global::CLGKLANEGOH<>.CNAMMODCCBN))]
	public IEnumerable<(TKey, List<TKey>, EPDEGEIGNNN)> PIDIMNLIKPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x24E58C0", Offset = "0x24E42C0", VA = "0x1824E58C0")]
	[IteratorStateMachine(typeof(global::CLGKLANEGOH<>.PCGCOJHFFAA))]
	private IEnumerable<(TKey, List<TKey>, EPDEGEIGNNN)> PIDIMNLIKPL(List<TKey> NKNOOFILFKG, PPKCEHBLCJE JOMGNFOCOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x24E57B0", Offset = "0x24E41B0", VA = "0x1824E57B0")]
	private (long, int) KOCNGFGFLPC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class LPGMKKDJGNL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JHJEHFOJNLH(global::CLGKLANEGOH<TKey> CEJBHGLMENF);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	protected LPGMKKDJGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class AMHGJKGELKN<TKey> : global::LPGMKKDJGNL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string INKKDIENNCC(TKey AJPNMLHDHNM);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x308F7B0", Offset = "0x308E1B0", VA = "0x18308F7B0")]
	protected string PEJABOIKAPD(double KFMICABKLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x308F750", Offset = "0x308E150", VA = "0x18308F750")]
	protected string NHAHMLAFOLB(int MFNJCJLEOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x308F530", Offset = "0x308DF30", VA = "0x18308F530")]
	private static string EEBPPBGKONO(TKey AJPNMLHDHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x308F6A0", Offset = "0x308E0A0", VA = "0x18308F6A0", Slot = "4")]
	public override string JHJEHFOJNLH(global::CLGKLANEGOH<TKey> CEJBHGLMENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x308F570", Offset = "0x308DF70", VA = "0x18308F570")]
	public string JHJEHFOJNLH(global::CLGKLANEGOH<TKey> CEJBHGLMENF, [NotNull] INKKDIENNCC KKHIJDFOPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NPHPDMPKOMK(global::CLGKLANEGOH<TKey> CEJBHGLMENF, [NotNull] INKKDIENNCC KKHIJDFOPMB);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2714950", Offset = "0x2713350", VA = "0x182714950")]
	protected AMHGJKGELKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FBKPKACNKAH<TKey> : global::LPGMKKDJGNL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string HBMDCOHEHBI(TKey AJPNMLHDHNM);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int BNPHDGFIFNL = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string BMJPALHPFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double DFJGOKOGFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool LILFLHCDIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int PNCELGJCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> CKCLCJFLKFA;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x29FEB30", Offset = "0x29FD530", VA = "0x1829FEB30")]
	private static string EEBPPBGKONO(TKey AJPNMLHDHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x29FF570", Offset = "0x29FDF70", VA = "0x1829FF570")]
	public FBKPKACNKAH(string BMJPALHPFOM = "F2", double DFJGOKOGFHP = double.MaxValue, bool LILFLHCDIHN = false, int PNCELGJCFBK = int.MaxValue, [Optional] ISet<string> CKCLCJFLKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x29FEEA0", Offset = "0x29FD8A0", VA = "0x1829FEEA0", Slot = "4")]
	public override Dictionary<string, string> JHJEHFOJNLH(global::CLGKLANEGOH<TKey> CEJBHGLMENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x29FF490", Offset = "0x29FDE90", VA = "0x1829FF490")]
	private bool PFNCLDFADHM(string PDHAHAMLEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x29FEF50", Offset = "0x29FD950", VA = "0x1829FEF50")]
	public Dictionary<string, string> JHJEHFOJNLH(global::CLGKLANEGOH<TKey> CEJBHGLMENF, HBMDCOHEHBI KKHIJDFOPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x29FEB70", Offset = "0x29FD570", VA = "0x1829FEB70")]
	private string GLKCKACGKGH(StringBuilder IICAKKMPGCA, List<TKey> JBGNJLHBHLB, HBMDCOHEHBI KKHIJDFOPMB, bool KBFKMKDLNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x29FED20", Offset = "0x29FD720", VA = "0x1829FED20")]
	private static void JBLOJKCEJEA(StringBuilder HNEJJECMJGB, string NIECGPPBDOH, bool BMCGOBDKNFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DJNCOOLHFLE<TKey> : global::AMHGJKGELKN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct MOPEAOLOFJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public INKKDIENNCC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::DJNCOOLHFLE<TKey> FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int NPHKHCLLMPC = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] BNLKMOGGGMK;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x259CFB0", Offset = "0x259B9B0", VA = "0x18259CFB0")]
	private DJNCOOLHFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x259BFC0", Offset = "0x259A9C0", VA = "0x18259BFC0", Slot = "5")]
	protected override string NPHPDMPKOMK(global::CLGKLANEGOH<TKey> CEJBHGLMENF, INKKDIENNCC KKHIJDFOPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x259BED0", Offset = "0x259A8D0", VA = "0x18259BED0")]
	[CompilerGenerated]
	internal static string NDAMMIHMLHA(string LDHLGBCIINP, TKey AJPNMLHDHNM, ref MOPEAOLOFJP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FFLDBOFJDNA<TKey> : global::AMHGJKGELKN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JOBPBAGIPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public INKKDIENNCC keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public JOBPBAGIPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x179EF20", Offset = "0x179D920", VA = "0x18179EF20")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x289D860", Offset = "0x289C260", VA = "0x18289D860", Slot = "5")]
	protected override string NPHPDMPKOMK(global::CLGKLANEGOH<TKey> CEJBHGLMENF, INKKDIENNCC KKHIJDFOPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x289E150", Offset = "0x289CB50", VA = "0x18289E150")]
	public FFLDBOFJDNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class PCEGMMLJOMM : global::CLGKLANEGOH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class DFCDEFCENAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<PCEGMMLJOMM> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public DFCDEFCENAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x63620B0", Offset = "0x6360AB0", VA = "0x1863620B0")]
		internal void <Wrap>b__0(global::CLGKLANEGOH<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6368BB0", Offset = "0x63675B0", VA = "0x186368BB0")]
	public PCEGMMLJOMM([Optional] string MDBGHLCIKCD, [Optional] int? GALNBDBIGJD, [Optional] Stopwatch ENOCBGFIEFM, [Optional] Action<string, EPDEGEIGNNN> GONGMPHHFCA, [Optional] Action<string, EPDEGEIGNNN> NEFDAHIFCPF, [Optional] Action<PCEGMMLJOMM> GNKJJPENOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6368AD0", Offset = "0x63674D0", VA = "0x186368AD0")]
	private static Action<global::CLGKLANEGOH<string>> MJPGGNHNGBH(Action<PCEGMMLJOMM> JOIALDGLEAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class IOMMIMKMGLG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class LDFPKJBJDJN : IOMMIMKMGLG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static IOMMIMKMGLG FMAHKEPPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x63677F0", Offset = "0x63661F0", VA = "0x1863677F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime PEHBKGBBCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x6367850", Offset = "0x6366250", VA = "0x186367850", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float PEJJDLPCLAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x63677E0", Offset = "0x63661E0", VA = "0x1863677E0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6367940", Offset = "0x6366340", VA = "0x186367940")]
		public LDFPKJBJDJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static IOMMIMKMGLG APGOCDONFGH;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static IOMMIMKMGLG JPMFPEEJFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6363C50", Offset = "0x6362650", VA = "0x186363C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime PEHBKGBBCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float PEJJDLPCLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected IOMMIMKMGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CIEOBIHHDDH : global::FDMFIDJKIFH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6361AE0", Offset = "0x63604E0", VA = "0x186361AE0")]
	public CIEOBIHHDDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FDMFIDJKIFH<T> : global::FGGCDBFMPJN<T>, ANEOGICIPNL, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> AHDPPJNKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task IBCPPKGEEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1757C60", Offset = "0x1756660", VA = "0x181757C60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::OHPLDOPGNGG<T> MNADFFFIHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private GPMDAFELAJF FFKCDNJMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xF64BF0", Offset = "0xF635F0", VA = "0x180F64BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2899AB0", Offset = "0x28984B0", VA = "0x182899AB0")]
	public FDMFIDJKIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IHEHCOCMKEG : global::AHDLLEGAFDM<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6363930", Offset = "0x6362330", VA = "0x186363930")]
	public IHEHCOCMKEG(Exception NJOLKOHDHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class AHDLLEGAFDM<T> : global::FGGCDBFMPJN<T>, ANEOGICIPNL, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> AHDPPJNKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task IBCPPKGEEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1757C60", Offset = "0x1756660", VA = "0x181757C60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::OHPLDOPGNGG<T> MNADFFFIHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private GPMDAFELAJF FFKCDNJMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xF64BF0", Offset = "0xF635F0", VA = "0x180F64BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x306E0F0", Offset = "0x306CAF0", VA = "0x18306E0F0")]
	public AHDLLEGAFDM(Exception NJOLKOHDHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface ANEOGICIPNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task AHDPPJNKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	GPMDAFELAJF MNADFFFIHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface FGGCDBFMPJN<T> : ANEOGICIPNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> AHDPPJNKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::OHPLDOPGNGG<T> MNADFFFIHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class EIGHLKEFJGL<TTask, T> : global::FGGCDBFMPJN<T>, ANEOGICIPNL, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class AGCAFHLFFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::EIGHLKEFJGL<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public AGCAFHLFFEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool DIJLCKIJDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> MBOEJHPPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource FPCHIMCODNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool IAFLCEPGHIO;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> AHDPPJNKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task IBCPPKGEEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::OHPLDOPGNGG<T> MNADFFFIHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private GPMDAFELAJF FFKCDNJMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2435F60", Offset = "0x2434960", VA = "0x182435F60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2435F90", Offset = "0x2434990", VA = "0x182435F90")]
	static EIGHLKEFJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x24363E0", Offset = "0x2434DE0", VA = "0x1824363E0")]
	protected EIGHLKEFJGL(TTask MBOEJHPPHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2435B50", Offset = "0x2434550", VA = "0x182435B50", Slot = "1")]
	~EIGHLKEFJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2435B20", Offset = "0x2434520", VA = "0x182435B20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2435BC0", Offset = "0x24345C0", VA = "0x182435BC0")]
	private void JGBMECMGNKO(bool PEKJIMNOLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BHPMOFBLJGB(TTask GPLNHJIONKG);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void IOBAACGHNFF();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FBJINOEDIAP
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float CEANHDGLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CJKDEHHCCDO GBJJCCBNLMG;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class LFKPEHEHBKJ : FBJINOEDIAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct MHBGCFEDDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float DAFLDHNIGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float PEEPHPNHDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool MPANJOCJMHO;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float PFDAMFBILGD
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x6368640", Offset = "0x6367040", VA = "0x186368640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x63687D0", Offset = "0x63671D0", VA = "0x1863687D0")]
		public MHBGCFEDDBC(float AGNHLFMCFOJ, float PGDLDMBJJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6368650", Offset = "0x6367050", VA = "0x186368650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class KCONPFKBDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public LFKPEHEHBKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KCONPFKBDFN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int ADCMDGEMNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KLNPPPLAODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly FBJINOEDIAP[] LOOLEEDPHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CJKDEHHCCDO[] EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MHBGCFEDDBC[] GALMGELPJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private MHBGCFEDDBC BJOCINHLHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly ACIKGHAHCMJ EKANGKIIHNA;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MHBGCFEDDBC KNIEIFENALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4A38080", Offset = "0x4A36A80", VA = "0x184A38080")]
		get
		{
			return default(MHBGCFEDDBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CEANHDGLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x63679F0", Offset = "0x63663F0", VA = "0x1863679F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CJKDEHHCCDO GBJJCCBNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6367C60", Offset = "0x6366660", VA = "0x186367C60", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6367BA0", Offset = "0x63665A0", VA = "0x186367BA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6368250", Offset = "0x6366C50", VA = "0x186368250")]
	public LFKPEHEHBKJ(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6367D20", Offset = "0x6366720", VA = "0x186367D20")]
	public ACIKGHAHCMJ JJLNPAIJBBI(MHBGCFEDDBC FKCNIJHFEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6367DB0", Offset = "0x63667B0", VA = "0x186367DB0")]
	public void LLAFMDGPABK(FBJINOEDIAP FMNPMPICCPE, [Optional] MHBGCFEDDBC DBGHHHENJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6368200", Offset = "0x6366C00", VA = "0x186368200")]
	internal int ODPHFPELANF(FBJINOEDIAP PANLNJOJEJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63679A0", Offset = "0x63663A0", VA = "0x1863679A0")]
	internal MHBGCFEDDBC AJDKFMBOMED(int GFDMFLGCBKB)
	{
		return default(MHBGCFEDDBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6367A10", Offset = "0x6366410", VA = "0x186367A10", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void CJKDEHHCCDO(float HDBBGEBNOID);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class EOABCBNKMJG
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float AENDFJCOGDE = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class IBFNLBAMOFM
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class ICOJKAEGHCJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly FBJINOEDIAP PANLNJOJEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly CJKDEHHCCDO JOIALDGLEAK;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6363300", Offset = "0x6361D00", VA = "0x186363300")]
		public ICOJKAEGHCJ(FBJINOEDIAP PANLNJOJEJC, CJKDEHHCCDO JOIALDGLEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x63632B0", Offset = "0x6361CB0", VA = "0x1863632B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6363170", Offset = "0x6361B70", VA = "0x186363170")]
	internal static bool OIEOKOEOIIK(float PKEMCIANHMO, float DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x49BA730", Offset = "0x49B9130", VA = "0x1849BA730")]
	internal static float BEJLKMMDOOA(float PKEMCIANHMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x63631F0", Offset = "0x6361BF0", VA = "0x1863631F0")]
	public static IDisposable PMMPLHJJFFF(this FBJINOEDIAP PANLNJOJEJC, CJKDEHHCCDO JOIALDGLEAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class ACIKGHAHCMJ : FBJINOEDIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float HDBBGEBNOID;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float CEANHDGLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x11DE660", Offset = "0x11DD060", VA = "0x1811DE660", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6361160", Offset = "0x635FB60", VA = "0x186361160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CJKDEHHCCDO GBJJCCBNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x63610C0", Offset = "0x635FAC0", VA = "0x1863610C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6361020", Offset = "0x635FA20", VA = "0x186361020", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ACIKGHAHCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class IFIDNBKAHOP
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6363520", Offset = "0x6361F20", VA = "0x186363520")]
	[NotNull]
	public static byte[] BOBNKCFNOPK(this DMHOLEFNLMF GBKIEGPLJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x63634B0", Offset = "0x6361EB0", VA = "0x1863634B0")]
	[NotNull]
	public static byte[] BOBNKCFNOPK(this DMHOLEFNLMF GBKIEGPLJAM, HashAlgorithmName AICANJMJPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x63637A0", Offset = "0x63621A0", VA = "0x1863637A0")]
	public static bool NKCKJKDIJNN([CanBeNull] this DMHOLEFNLMF GBKIEGPLJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6363600", Offset = "0x6362000", VA = "0x186363600")]
	public static bool NKCKJKDIJNN([CanBeNull] this DMHOLEFNLMF GBKIEGPLJAM, out string IMHLNJJFNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6363590", Offset = "0x6361F90", VA = "0x186363590")]
	private static string DHDABMKJAGF([CanBeNull] byte[] FMIGDHLBIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6363390", Offset = "0x6361D90", VA = "0x186363390")]
	private static bool AKGGIJEPAED([NotNull] DMHOLEFNLMF GBKIEGPLJAM, [CanBeNull] out byte[] HMDNBKGOHME, [CanBeNull] out byte[] BIADPOMKEIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class MACHIDCJPIN
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x63683D0", Offset = "0x6366DD0", VA = "0x1863683D0")]
	[NotNull]
	public static byte[] BOBNKCFNOPK(this IPADMLFCGON IAEEOILEDAE, byte[] NLFHFOIILEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6368410", Offset = "0x6366E10", VA = "0x186368410")]
	[NotNull]
	public static byte[] BOBNKCFNOPK(this IPADMLFCGON IAEEOILEDAE, HashAlgorithmName AICANJMJPOE, byte[] NLFHFOIILEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface IPADMLFCGON
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NFFMFBOGLMH);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface DMHOLEFNLMF : IPADMLFCGON
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] BBOJGNJCJAM
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
	byte[] DKLONOBNJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object CJEFLDGDMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class IPEBECAFNGP
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class BKDPELBDJIF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6361990", Offset = "0x6360390", VA = "0x186361990")]
		public BKDPELBDJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6361930", Offset = "0x6360330", VA = "0x186361930", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte FJLJANODMOB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte OIJOIAIJABH = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> KMHFGCCOLBA;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool JCOBGENCAEP;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x223F2C0", Offset = "0x223DCC0", VA = "0x18223F2C0")]
	[Conditional("UNITY_EDITOR")]
	private static void DKFHDCBINGM<T>(params T[] GIJBOEINEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6364B70", Offset = "0x6363570", VA = "0x186364B70")]
	public static IDisposable MPDCJFJGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63641C0", Offset = "0x6362BC0", VA = "0x1863641C0")]
	public static void HDEIBOMGBBG(this IncrementalHash FCAFDIHGDLI, [CanBeNull] GameObject KEHOIMKGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x223FAA0", Offset = "0x223E4A0", VA = "0x18223FAA0")]
	public static void HDEIBOMGBBG<T>(this IncrementalHash FCAFDIHGDLI, [CanBeNull] T DCIOCIFFEAC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x223FA10", Offset = "0x223E410", VA = "0x18223FA10")]
	public static void HBDHHJEJHFP<T>(this IncrementalHash FCAFDIHGDLI, [CanBeNull] T IAEEOILEDAE) where T : IPADMLFCGON
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x223F5B0", Offset = "0x223DFB0", VA = "0x18223F5B0")]
	public static void ELGCJBIEPHL<T>(this IncrementalHash FCAFDIHGDLI, [CanBeNull] IList<T> FNINBJDHKJF) where T : IPADMLFCGON
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63640D0", Offset = "0x6362AD0", VA = "0x1863640D0")]
	private static bool GGPNJFIBKLN([CanBeNull] IPADMLFCGON IAEEOILEDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6364160", Offset = "0x6362B60", VA = "0x186364160")]
	public static void GKKEKNPLLLK(this IncrementalHash NFFMFBOGLMH, [CanBeNull] string KPENIGGIMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6364320", Offset = "0x6362D20", VA = "0x186364320")]
	public static void JNFBAGEPELP(this IncrementalHash NFFMFBOGLMH, long ECKMAGBAIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63644F0", Offset = "0x6362EF0", VA = "0x1863644F0")]
	public static void KMLANJHDBBN(this IncrementalHash NFFMFBOGLMH, int NHJEFFHPBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6364830", Offset = "0x6363230", VA = "0x186364830")]
	public static void LGMLNPFFOML(this IncrementalHash NFFMFBOGLMH, short ABIGLGGEKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63646C0", Offset = "0x63630C0", VA = "0x1863646C0")]
	public static void KNLBCGFMOBJ(this IncrementalHash NFFMFBOGLMH, byte LEOLMBDHJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6364C70", Offset = "0x6363670", VA = "0x186364C70")]
	public static void OCEPPICBJMG(this IncrementalHash NFFMFBOGLMH, bool GJFAEDEJFGD, bool DHOFBBBLDLI = false, bool GDEHNCEINFN = false, bool GONLIGOMELL = false, bool CPDOFCGLAFN = false, bool EIHPIJMIJKN = false, bool PGFPLBHFCHP = false, bool LLHJEOANIHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x223EBD0", Offset = "0x223D5D0", VA = "0x18223EBD0")]
	public static void BDOKFPBEDHA<T>(this IncrementalHash NFFMFBOGLMH, T CCNFFIHKIBA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6364000", Offset = "0x6362A00", VA = "0x186364000")]
	public static void EGAGHBLOJPC(this IncrementalHash NFFMFBOGLMH, float PLCEAKGBPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6363DE0", Offset = "0x63627E0", VA = "0x186363DE0")]
	public static void AMPACDMIOKG(this IncrementalHash NFFMFBOGLMH, double ADEKKJFJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6364060", Offset = "0x6362A60", VA = "0x186364060")]
	public static void FKPHCJJDKJC(this IncrementalHash NFFMFBOGLMH, ulong PPOMKACNIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6364C10", Offset = "0x6363610", VA = "0x186364C10")]
	public static void OAJOBKANEBA(this IncrementalHash NFFMFBOGLMH, uint MJFPIKJAMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x63642B0", Offset = "0x6362CB0", VA = "0x1863642B0")]
	public static void ICNHHCLMCHA(this IncrementalHash NFFMFBOGLMH, ushort DCLCJDDOBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6364A00", Offset = "0x6363400", VA = "0x186364A00")]
	public static void LOBKAIINGCC(this IncrementalHash NFFMFBOGLMH, Vector3 KIHPCNHFHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6363E40", Offset = "0x6362840", VA = "0x186363E40")]
	public static void CJAJPBKEJMM(this IncrementalHash NFFMFBOGLMH, Quaternion OKOEHHKJHHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class EFBKIIJJAMJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type INGMMBHJKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string LAGOMEPJHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool BMDHCFGLCBE;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6362990", Offset = "0x6361390", VA = "0x186362990")]
	public EFBKIIJJAMJ(Type CEELLOBGKOE, string DHOEDJNFGMI, bool HKHLPDFNMHJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HOMKKLPDFHK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6363100", Offset = "0x6361B00", VA = "0x186363100")]
	public HOMKKLPDFHK(string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6363080", Offset = "0x6361A80", VA = "0x186363080")]
	public HOMKKLPDFHK(string EJEIJOMMNGK, Exception ELDKAOAIPEP)
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
			[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6D7790", Offset = "0x6D6190", VA = "0x1806D7790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int ALJNHCKDPKB, int OLDPGFBGPGG]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3822770", Offset = "0x3821170", VA = "0x183822770")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x3822810", Offset = "0x3821210", VA = "0x183822810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x38226E0", Offset = "0x38210E0", VA = "0x1838226E0")]
		public Array2D(uint BPPJIBCDENC, uint GKJBEJDBHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3822660", Offset = "0x3821060", VA = "0x183822660")]
		public void NMFIICNHENP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x63617C0", Offset = "0x63601C0", VA = "0x1863617C0")]
		public Array2DVector3(uint BPPJIBCDENC, uint GKJBEJDBHAL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EAPIMBHAJCF
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool GANJIHGGBBI(string LKNILPPPBAD, EAPIMBHAJCF EFGMMIBNCOM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int CCNFFIHKIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string FGMMKBMEKDL;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6362620", Offset = "0x6361020", VA = "0x186362620")]
	public static Dictionary<string, EAPIMBHAJCF> ODLMMPDFEIC(Type GGPEGKHIBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6362140", Offset = "0x6360B40", VA = "0x186362140")]
	public static Dictionary<string, EAPIMBHAJCF> GLEOMMFPBPL(Type GGPEGKHIBNM, GANJIHGGBBI JDFCNDJEKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6362470", Offset = "0x6360E70", VA = "0x186362470")]
	public static Dictionary<int, string> HJMDNLALGCF(Dictionary<string, EAPIMBHAJCF> MMPIIAHIKHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class GBFNCIDHBKG
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int MBBMEBNILLK = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int LNJABLLNHHF = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class PMHDFBOBOFM<THandle, TValue> : IDisposable where THandle : struct, HOKCJDBMKAA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<THandle> ODGNPDGECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<TValue> ONNHMDKNLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Func<TValue> JFAGBHGNNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Action<TValue> HOKLJLKDDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int KKHNLJOKLCO;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x24E66E0", Offset = "0x24E50E0", VA = "0x1824E66E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E550", Offset = "0x2A5CF50", VA = "0x182A5E550")]
	public PMHDFBOBOFM(Action<TValue> HOKLJLKDDAI, [Optional] Func<TValue> JFAGBHGNNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DBD0", Offset = "0x2A5C5D0", VA = "0x182A5DBD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DE00", Offset = "0x2A5C800", VA = "0x182A5DE00")]
	public THandle GANMJPNFBJN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DAE0", Offset = "0x2A5C4E0", VA = "0x182A5DAE0")]
	public THandle CPLOAHMOJFD(TValue MNIAGKNOHEJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E4A0", Offset = "0x2A5CEA0", VA = "0x182A5E4A0")]
	public bool OLCIACFECIH(THandle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E3D0", Offset = "0x2A5CDD0", VA = "0x182A5E3D0")]
	public bool NJKFKCNNMGK(THandle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DA20", Offset = "0x2A5C420", VA = "0x182A5DA20")]
	public bool BHPOPCGLBJN(THandle BIONDBIGACN, out TValue MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D9D0", Offset = "0x2A5C3D0", VA = "0x182A5D9D0")]
	public TValue AGGAFJIIBKL(THandle BIONDBIGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DC50", Offset = "0x2A5C650", VA = "0x182A5DC50")]
	public bool FDOEJMJEMDK(THandle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E150", Offset = "0x2A5CB50", VA = "0x182A5E150")]
	private THandle JPOBCPPKODN(int GFDMFLGCBKB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E2D0", Offset = "0x2A5CCD0", VA = "0x182A5E2D0")]
	private TValue LEJAKIOEKDC(int GFDMFLGCBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E180", Offset = "0x2A5CB80", VA = "0x182A5E180")]
	private void KOHJFJBOGPG(int GFDMFLGCBKB, in THandle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF40", Offset = "0x2A5C940", VA = "0x182A5DF40")]
	private void IALEDAFGJMH(int GFDMFLGCBKB, in TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E1C0", Offset = "0x2A5CBC0", VA = "0x182A5E1C0")]
	private THandle LACBDLLLCPH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E0A0", Offset = "0x2A5CAA0", VA = "0x182A5E0A0")]
	private void JIPCIMMNJLC(THandle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DAD0", Offset = "0x2A5C4D0", VA = "0x182A5DAD0")]
	private int CFKPOEMLIJC(int FMHBAJCDDEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DAC0", Offset = "0x2A5C4C0", VA = "0x182A5DAC0")]
	private bool CEAKIPKGAPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x728640", Offset = "0x727040", VA = "0x180728640")]
	private void NFMEBKKGHAK(THandle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DB50", Offset = "0x2A5C550", VA = "0x182A5DB50")]
	private bool DPOHPFBPMFF(out THandle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E300", Offset = "0x2A5CD00", VA = "0x182A5E300")]
	private bool NCIIPBCOBLF(out THandle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DD00", Offset = "0x2A5C700", VA = "0x182A5DD00")]
	private void GAJJGCHHBOO(THandle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF80", Offset = "0x2A5C980", VA = "0x182A5DF80")]
	private void IDPFEJPNKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface HOKCJDBMKAA
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int BNNADFINGPC
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
public interface HFJJIJCEKGL<T> : HOKCJDBMKAA, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class NECGENNHCDL
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xCDFA90", Offset = "0xCDE490", VA = "0x180CDFA90")]
	public static bool OPODMNFKOHD<T>(this T BIONDBIGACN, T DFHJPOKNFFB) where T : struct, HOKCJDBMKAA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BF14A0", Offset = "0x2BEFEA0", VA = "0x182BF14A0")]
	public static bool MPANJOCJMHO<T>(this T BIONDBIGACN) where T : struct, HOKCJDBMKAA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6368910", Offset = "0x6367310", VA = "0x186368910")]
	public static string ENHNAJEOGMF(this HOKCJDBMKAA BIONDBIGACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JMPKOLOIGBC
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum MJJJEPGFAIB : byte
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
	private int NFFMFBOGLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool MFLFFMKJFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private MJJJEPGFAIB MKPFHFLNAEL;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool FHLENDJALHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6366450", Offset = "0x6364E50", VA = "0x186366450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool AJBDHPIOEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6365E80", Offset = "0x6364880", VA = "0x186365E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6366460", Offset = "0x6364E60", VA = "0x186366460")]
	public JMPKOLOIGBC(bool MFLFFMKJFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6365730", Offset = "0x6364130", VA = "0x186365730")]
	public void FHIHMHDIFEK(object LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x63663B0", Offset = "0x6364DB0", VA = "0x1863663B0")]
	public void PGNDBAPEFEK(int MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6365720", Offset = "0x6364120", VA = "0x186365720")]
	public void FACCDAGEHAJ(uint AIMOGEDNDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6365E60", Offset = "0x6364860", VA = "0x186365E60")]
	public void GPBHBCDEFDL(bool MKIEHNLMNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6365DB0", Offset = "0x63647B0", VA = "0x186365DB0")]
	public void GEBIEDIMOPH(long IPNLNIMMJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63656E0", Offset = "0x63640E0", VA = "0x1863656E0")]
	public void ENCGDEDJKOG(ulong EKAGLGJOLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6365DF0", Offset = "0x63647F0", VA = "0x186365DF0")]
	public void GGONDMKFINC(string OMLJENAFGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6365650", Offset = "0x6364050", VA = "0x186365650")]
	public void EIECLOALIPA(Enum NJOLKOHDHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6366280", Offset = "0x6364C80", VA = "0x186366280")]
	public void OBBCPLCMBEJ(IList OKDFPKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x25BF430", Offset = "0x25BDE30", VA = "0x1825BF430")]
	public void GFEFKOAOHML<T, U>(Dictionary<T, U> MGCOBICJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6365F00", Offset = "0x6364900", VA = "0x186365F00")]
	private void JKLBMJFBFCH(IDictionary MGCOBICJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6365E90", Offset = "0x6364890", VA = "0x186365E90")]
	public int HNPMLBJOMHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6365570", Offset = "0x6363F70", VA = "0x186365570")]
	public short AGGJAEAGFAA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6366270", Offset = "0x6364C70", VA = "0x186366270")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x63655E0", Offset = "0x6363FE0", VA = "0x1863655E0")]
	private void BFGFJGEBHIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class ABPIIMCFDMH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class PPNJDIKKIIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode DCIIOIKIJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode ELGBIOMPEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public DIAGAJCPFGP IGMAFPJOAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<DIAGAJCPFGP> IEGHLLNKLBD;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public PPNJDIKKIIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct DIAGAJCPFGP : IComparable<DIAGAJCPFGP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int OIHCLELFNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public TClaimant FFHJCEPNAHF;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC0B0", Offset = "0x6EAAB0", VA = "0x1806EC0B0")]
		public DIAGAJCPFGP(int OIHCLELFNKN, TClaimant FFHJCEPNAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x259A250", Offset = "0x2598C50", VA = "0x18259A250")]
		public bool PAJLFFKFKFF(in DIAGAJCPFGP DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x259A240", Offset = "0x2598C40", VA = "0x18259A240")]
		public bool LFMKNGEJFMB(in DIAGAJCPFGP DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x259A230", Offset = "0x2598C30", VA = "0x18259A230", Slot = "4")]
		public int CompareTo(DIAGAJCPFGP DFHJPOKNFFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x259A2B0", Offset = "0x2598CB0", VA = "0x18259A2B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum DDCMCEDGKLH
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class JLGJLFEBGNO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::ABPIIMCFDMH<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAFE0", Offset = "0x1FE99E0", VA = "0x181FEAFE0")]
		[DebuggerHidden]
		public JLGJLFEBGNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x316BDA0", Offset = "0x316A7A0", VA = "0x18316BDA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x316BF60", Offset = "0x316A960", VA = "0x18316BF60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x316BE80", Offset = "0x316A880", VA = "0x18316BE80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xF630F0", Offset = "0xF61AF0", VA = "0x180F630F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::FGCNGIFBGIG<PPNJDIKKIIF> NFFABIMKJNF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::FGCNGIFBGIG<List<DIAGAJCPFGP>> JJGOEHOLBIF;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int NMKDCBFHJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TClaimant, TNode> MNIEIIJADOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TNode, PPNJDIKKIIF> FALDJPKOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private DDCMCEDGKLH HLAMMHNAHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode CBCDGOOOFFP(TNode MMAGBLNBOEG);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HBKOPIMAODM(TNode MMAGBLNBOEG, TClaimant OCDJKFAIAMO, TClaimant NINFIMLICBP);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x35A49A0", Offset = "0x35A33A0", VA = "0x1835A49A0")]
	public ABPIIMCFDMH(DDCMCEDGKLH HLAMMHNAHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x35A3610", Offset = "0x35A2010", VA = "0x1835A3610")]
	public void CIABDFLKBFH(TNode MMAGBLNBOEG, TNode DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x35A4240", Offset = "0x35A2C40", VA = "0x1835A4240")]
	public void KOAADNFEAIC(TClaimant FFHJCEPNAHF, TNode POBLOFHDHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x35A3690", Offset = "0x35A2090", VA = "0x1835A3690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x35A4440", Offset = "0x35A2E40", VA = "0x1835A4440")]
	private void NCCPLIBDBDL(TClaimant FFHJCEPNAHF, TNode BMHEAPCEADM, TNode POBLOFHDHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x35A38F0", Offset = "0x35A22F0", VA = "0x1835A38F0")]
	private int EBPHPFDANHO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x35A3250", Offset = "0x35A1C50", VA = "0x1835A3250")]
	private void AHMAIFIMFDI(TClaimant FFHJCEPNAHF, TNode ICGBMLEMBKL, TNode OBNNKPFGMNE, int JCDMOEFGABE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x35A47B0", Offset = "0x35A31B0", VA = "0x1835A47B0")]
	private void PJMNBPMMIOI(DIAGAJCPFGP ABDHLOPHNDE, PPNJDIKKIIF GOADIACIEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x35A3F10", Offset = "0x35A2910", VA = "0x1835A3F10")]
	private void HKACMDMPENP(TClaimant FFHJCEPNAHF, TNode ICGBMLEMBKL, TNode OBNNKPFGMNE, int JCDMOEFGABE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x35A3500", Offset = "0x35A1F00", VA = "0x1835A3500")]
	private void BABDKMJHCDC(DIAGAJCPFGP ABDHLOPHNDE, TNode MMAGBLNBOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x35A4340", Offset = "0x35A2D40", VA = "0x1835A4340")]
	private void MOCHAPGMADO(DIAGAJCPFGP ABDHLOPHNDE, PPNJDIKKIIF GOADIACIEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x35A44E0", Offset = "0x35A2EE0", VA = "0x1835A44E0")]
	private void NMANJJKMHIF(PPNJDIKKIIF GOADIACIEED, bool POCCPAMFLIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x35A3A10", Offset = "0x35A2410", VA = "0x1835A3A10")]
	private void FKCPCHHGNLF(PPNJDIKKIIF GOADIACIEED, TNode DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x35A4170", Offset = "0x35A2B70", VA = "0x1835A4170")]
	[IteratorStateMachine(typeof(global::ABPIIMCFDMH<, >.JLGJLFEBGNO))]
	private IEnumerable<TNode> KHGMDNMBMCL(TNode ICGBMLEMBKL, TNode OBNNKPFGMNE, bool EIMGHONEOMO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x35A3950", Offset = "0x35A2350", VA = "0x1835A3950")]
	private PPNJDIKKIIF ELFAFNKPDLM(TNode MMAGBLNBOEG, TNode ELGBIOMPEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x35A3D80", Offset = "0x35A2780", VA = "0x1835A3D80")]
	private PPNJDIKKIIF HDJJLFNGBHG(TNode MMAGBLNBOEG, TNode ELGBIOMPEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x35A45F0", Offset = "0x35A2FF0", VA = "0x1835A45F0")]
	private void OJAJCOCGDCC(PPNJDIKKIIF GOADIACIEED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class DBAHNGPJFGA<T> : IEnumerable<global::DBAHNGPJFGA<T>.EINABFPIHNP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct EINABFPIHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public T MNIAGKNOHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int GFDMFLGCBKB;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class KPEPOIHANBG : IEnumerator<EINABFPIHNP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private global::DBAHNGPJFGA<T> INLJGFGAJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int GFDMFLGCBKB;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xF567B0", Offset = "0xF551B0", VA = "0x180F567B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public EINABFPIHNP PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3B7CA80", Offset = "0x3B7B480", VA = "0x183B7CA80", Slot = "4")]
			get
			{
				return default(EINABFPIHNP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6C5060", Offset = "0x6C3A60", VA = "0x1806C5060")]
		public KPEPOIHANBG(global::DBAHNGPJFGA<T> INLJGFGAJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3B7C980", Offset = "0x3B7B380", VA = "0x183B7C980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6C5050", Offset = "0x6C3A50", VA = "0x1806C5050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xBFBDE0", Offset = "0xBFA7E0", VA = "0x180BFBDE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct LFJJILIBDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool DBGEHLNJDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T MNIAGKNOHEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int DKNFDBJDJCL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<T, int> OOENFEAOACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private LFJJILIBDMN[] FIBDBAEMKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private int IJFJJNMKNFH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int FPHCGCBAHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D90", Offset = "0x6E0790", VA = "0x1806E1D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x859D20", Offset = "0x858720", VA = "0x180859D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2217480", Offset = "0x2215E80", VA = "0x182217480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2586B00", Offset = "0x2585500", VA = "0x182586B00")]
	public DBAHNGPJFGA(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2586BE0", Offset = "0x25855E0", VA = "0x182586BE0")]
	public DBAHNGPJFGA(EINABFPIHNP[] HKGGAIEHDCM, bool MILJDFGEMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x25861B0", Offset = "0x2584BB0", VA = "0x1825861B0")]
	public int OKLHDDJFIME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2585AC0", Offset = "0x25844C0", VA = "0x182585AC0")]
	private int LMGPADOKLNL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2585510", Offset = "0x2583F10", VA = "0x182585510", Slot = "6")]
	protected virtual uint HLJGLLDFFKD(uint NFFMFBOGLMH, T MNIAGKNOHEJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x25857F0", Offset = "0x25841F0", VA = "0x1825857F0")]
	public bool LEKCALACIAI(T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2586630", Offset = "0x2585030", VA = "0x182586630")]
	public bool PLOCCNLBCDK(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2585260", Offset = "0x2583C60", VA = "0x182585260")]
	public bool GGIBFCBBJNK(Func<T, bool> GLGBBCABHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x25853E0", Offset = "0x2583DE0", VA = "0x1825853E0")]
	public int GIPIKMBEIPJ(T MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2585760", Offset = "0x2584160", VA = "0x182585760")]
	public T LEJAKIOEKDC(int GFDMFLGCBKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2586130", Offset = "0x2584B30", VA = "0x182586130")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2585EF0", Offset = "0x25848F0", VA = "0x182585EF0")]
	public bool MMAIIPOKGMB(T MNIAGKNOHEJ, bool JFDCBPPJECO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2585F30", Offset = "0x2584930", VA = "0x182585F30")]
	public bool MMAIIPOKGMB(T MNIAGKNOHEJ, int GFDMFLGCBKB, bool JFDCBPPJECO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x25862A0", Offset = "0x2584CA0", VA = "0x1825862A0")]
	public bool OLCIACFECIH(T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2585490", Offset = "0x2583E90", VA = "0x182585490")]
	public bool GNBOGKPOKGD(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2585610", Offset = "0x2584010", VA = "0x182585610")]
	private void JOGLKIKOOLG(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2586330", Offset = "0x2584D30", VA = "0x182586330")]
	public EINABFPIHNP[] PCHEOIJAOFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2585880", Offset = "0x2584280", VA = "0x182585880")]
	private int LIFBAEMKAGI(int FHINICACAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2586680", Offset = "0x2585080", VA = "0x182586680", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2586680", Offset = "0x2585080", VA = "0x182586680", Slot = "4")]
	private IEnumerator<EINABFPIHNP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct BJFNHPCENLK<Handle> where Handle : HOKCJDBMKAA, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct DIDJGKOIAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly global::BJFNHPCENLK<Handle> FAKFJCKANAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int GFDMFLGCBKB;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int BAFLABLGFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x259AB20", Offset = "0x2599520", VA = "0x18259AB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle NENMGDEEOEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x259B240", Offset = "0x2599C40", VA = "0x18259B240")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x259B4E0", Offset = "0x2599EE0", VA = "0x18259B4E0")]
		public DIDJGKOIAHD(global::BJFNHPCENLK<Handle> FAKFJCKANAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x259A980", Offset = "0x2599380", VA = "0x18259A980")]
		public PPELANNFALC EEKKKHPKBPD(in PPELANNFALC PAGKANKNAEA)
		{
			return default(PPELANNFALC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x259A8E0", Offset = "0x25992E0", VA = "0x18259A8E0")]
		public IFOJHEDHFJJ EEKKKHPKBPD(in IFOJHEDHFJJ PAGKANKNAEA)
		{
			return default(IFOJHEDHFJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x259A460", Offset = "0x2598E60", VA = "0x18259A460")]
		public bool DPJIJDLDGKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x259A320", Offset = "0x2598D20", VA = "0x18259A320")]
		private int DNPLEOBFIMJ(string EJEIJOMMNGK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x259B3A0", Offset = "0x2599DA0", VA = "0x18259B3A0")]
		private Handle LEFJNOIEDNO(string EJEIJOMMNGK)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct PPELANNFALC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private DIDJGKOIAHD PLIPHJGFADA;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x27621B0", Offset = "0x2760BB0", VA = "0x1827621B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2219A70", Offset = "0x2218470", VA = "0x182219A70")]
		public PPELANNFALC(global::BJFNHPCENLK<Handle> FAKFJCKANAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2219870", Offset = "0x2218270", VA = "0x182219870")]
		public bool DPJIJDLDGKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x27622B0", Offset = "0x2760CB0", VA = "0x1827622B0")]
		public PPELANNFALC OGILHMGHFKK()
		{
			return default(PPELANNFALC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct IFOJHEDHFJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private DIDJGKOIAHD PLIPHJGFADA;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2219970", Offset = "0x2218370", VA = "0x182219970")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2219A70", Offset = "0x2218470", VA = "0x182219A70")]
		public IFOJHEDHFJJ(global::BJFNHPCENLK<Handle> FAKFJCKANAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2219870", Offset = "0x2218270", VA = "0x182219870")]
		public bool DPJIJDLDGKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x22199F0", Offset = "0x22183F0", VA = "0x1822199F0")]
		public IFOJHEDHFJJ OGILHMGHFKK()
		{
			return default(IFOJHEDHFJJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> OIPNILIOGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> PHNGKDDOBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int COIDCGOGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int GFMJBGBNMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool DKBLDPLJONJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int MGGIOFDCCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3190030", Offset = "0x318EA30", VA = "0x183190030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int AIELLAMCPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1010", Offset = "0x6BFA10", VA = "0x1806C1010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CKOMLLIANFD
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6C1010", Offset = "0x6BFA10", VA = "0x1806C1010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public PPELANNFALC ALMNGNHCNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x318F450", Offset = "0x318DE50", VA = "0x18318F450")]
		get
		{
			return default(PPELANNFALC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IFOJHEDHFJJ AAGFGDFCNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3190FE0", Offset = "0x318F9E0", VA = "0x183190FE0")]
		get
		{
			return default(IFOJHEDHFJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3191480", Offset = "0x318FE80", VA = "0x183191480")]
	public BJFNHPCENLK(int OEJLGALKADP, Allocator GGPAKDMJHLJ = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3190950", Offset = "0x318F350", VA = "0x183190950")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1015950", Offset = "0x1014350", VA = "0x181015950")]
	public static int CFKPOEMLIJC(int ELMMBEILPIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x318EAF0", Offset = "0x318D4F0", VA = "0x18318EAF0")]
	public static bool DGELMENHDJO(int ELMMBEILPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x318EF80", Offset = "0x318D980", VA = "0x18318EF80")]
	public static bool ELAOEBDFHAM(int ELMMBEILPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x318EC20", Offset = "0x318D620", VA = "0x18318EC20")]
	public bool DPPOLGCEDDI(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3190190", Offset = "0x318EB90", VA = "0x183190190")]
	public bool JALJOJDFGLO(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x318FAB0", Offset = "0x318E4B0", VA = "0x18318FAB0")]
	public bool IGHGALHNDFA(Handle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x318DBA0", Offset = "0x318C5A0", VA = "0x18318DBA0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BIPGIDDNCOI(Handle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x318F2B0", Offset = "0x318DCB0", VA = "0x18318F2B0")]
	public Handle HBBHAJFGPBJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x318E4F0", Offset = "0x318CEF0", VA = "0x18318E4F0")]
	public void DBGLFNFDOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3190DE0", Offset = "0x318F7E0", VA = "0x183190DE0")]
	public void KGCKFCGEKGC(Handle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x318CFC0", Offset = "0x318B9C0", VA = "0x18318CFC0")]
	public bool ADOAHMNLEOC(Handle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80")]
	private bool ECKONFLIFFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x318F050", Offset = "0x318DA50", VA = "0x18318F050")]
	private bool GIBGCPOKLEL(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x318F7D0", Offset = "0x318E1D0", VA = "0x18318F7D0")]
	private void ICLEEHOEPGK(out int GFDMFLGCBKB, out int FMHBAJCDDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3190850", Offset = "0x318F250", VA = "0x183190850")]
	private void JEEOJCLAJPG(Handle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3191170", Offset = "0x318FB70", VA = "0x183191170")]
	private void LJKJCHEGJDI(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x31913D0", Offset = "0x318FDD0", VA = "0x1831913D0")]
	private bool PAFEGJJMKGO(out int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3190C50", Offset = "0x318F650", VA = "0x183190C50")]
	private static Handle JPILEDMLBHC(int GFDMFLGCBKB, int FMHBAJCDDEI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct PJDAAKMMIMP<Handle, T> where Handle : HOKCJDBMKAA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private global::BJFNHPCENLK<Handle> MOBKBBMDOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private T[] IPJBBJCFMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Action<T> HGKMGJFEADE;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x314F990", Offset = "0x314E390", VA = "0x18314F990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int MGGIOFDCCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x314FBA0", Offset = "0x314E5A0", VA = "0x18314FBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x314FEA0", Offset = "0x314E8A0", VA = "0x18314FEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x314E180", Offset = "0x314CB80", VA = "0x18314E180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x31514B0", Offset = "0x314FEB0", VA = "0x1831514B0")]
	public PJDAAKMMIMP(int OEJLGALKADP, [Optional] Action<T> HGKMGJFEADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x314FE10", Offset = "0x314E810", VA = "0x18314FE10")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x314FB10", Offset = "0x314E510", VA = "0x18314FB10")]
	public bool IGHGALHNDFA(Handle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BIPGIDDNCOI(Handle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x314E0C0", Offset = "0x314CAC0", VA = "0x18314E0C0")]
	public T AGGAFJIIBKL(Handle BIONDBIGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x314E4B0", Offset = "0x314CEB0", VA = "0x18314E4B0")]
	public bool BHPOPCGLBJN(Handle BIONDBIGACN, out T LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x314FFA0", Offset = "0x314E9A0", VA = "0x18314FFA0")]
	public void NLANNFAIKGA(Handle BIONDBIGACN, T MAAKHLKFLIM, out T OEAFKJINNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3150040", Offset = "0x314EA40", VA = "0x183150040")]
	public void NLANNFAIKGA(Handle BIONDBIGACN, T MAAKHLKFLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x31510C0", Offset = "0x314FAC0", VA = "0x1831510C0")]
	public bool PCGCFIEHINB(Handle BIONDBIGACN, T MAAKHLKFLIM, out T OEAFKJINNBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3150C50", Offset = "0x314F650", VA = "0x183150C50")]
	public bool PCGCFIEHINB(Handle BIONDBIGACN, T MAAKHLKFLIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x314F150", Offset = "0x314DB50", VA = "0x18314F150")]
	public Handle CPLOAHMOJFD(T LAFPICAOEAI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x314E560", Offset = "0x314CF60", VA = "0x18314E560")]
	public void COONOLMCGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x31508A0", Offset = "0x314F2A0", VA = "0x1831508A0")]
	public void OLCIACFECIH(Handle BIONDBIGACN, out T OEAFKJINNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3150520", Offset = "0x314EF20", VA = "0x183150520")]
	public void OLCIACFECIH(Handle BIONDBIGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x314F6B0", Offset = "0x314E0B0", VA = "0x18314F6B0")]
	public bool EFBFINKLJEO(Handle BIONDBIGACN, out T OEAFKJINNBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x314F5D0", Offset = "0x314DFD0", VA = "0x18314F5D0")]
	public bool EFBFINKLJEO(Handle BIONDBIGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x314F9C0", Offset = "0x314E3C0", VA = "0x18314F9C0")]
	private T GNBOGKPOKGD(int GFDMFLGCBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x314FED0", Offset = "0x314E8D0", VA = "0x18314FED0")]
	private void KMGAMBDOMKB(int DLFBNHIJNGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class FGCNGIFBGIG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<T> FAKFJCKANAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<T> EAOBNNJEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int BKNCAPMNKKG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int ADNKBGKFJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x179F660", Offset = "0x179E060", VA = "0x18179F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int BPBDAOLKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x289EAC0", Offset = "0x289D4C0", VA = "0x18289EAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x289E690", Offset = "0x289D090", VA = "0x18289E690")]
	public static global::FGCNGIFBGIG<T> GECKKAJODBP(int ADCMDGEMNDH = 0, int BKNCAPMNKKG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x289E2D0", Offset = "0x289CCD0", VA = "0x18289E2D0")]
	public static global::FGCNGIFBGIG<T> ADEGKKLLLFG(int ADCMDGEMNDH = 0, int BKNCAPMNKKG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x289EAF0", Offset = "0x289D4F0", VA = "0x18289EAF0")]
	public FGCNGIFBGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x289EB30", Offset = "0x289D530", VA = "0x18289EB30")]
	public FGCNGIFBGIG(int ADCMDGEMNDH, int BKNCAPMNKKG = int.MaxValue, bool DBMEJBFHGJE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x289E760", Offset = "0x289D160", VA = "0x18289E760")]
	public T ILJCNBFDKFF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x289E870", Offset = "0x289D270", VA = "0x18289E870")]
	public void JJOEMGIHELE(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x289E3A0", Offset = "0x289CDA0", VA = "0x18289E3A0")]
	private void AFKMMDOPDHB(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x289E670", Offset = "0x289D070", VA = "0x18289E670")]
	private void FHLHEFLAAAB(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x289E470", Offset = "0x289CE70", VA = "0x18289E470")]
	[Conditional("DEBUG_BUILD")]
	private void BCEMPAINGPP(T JNNLPAJINAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x289E4F0", Offset = "0x289CEF0", VA = "0x18289E4F0")]
	[Conditional("DEBUG_BUILD")]
	private void CFIFPKGMFIA(T JNNLPAJINAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x289E580", Offset = "0x289CF80", VA = "0x18289E580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x289E920", Offset = "0x289D320", VA = "0x18289E920")]
	private void LMAMCGKHKNA(IEnumerable<T> ONNHMDKNLHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class ONFLPBDDMHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private Dictionary<int, T> LPNBKHDOFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T EKMBPFJPJAP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T DDJHGNMNKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool OPBFBJNLFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3D75CF0", Offset = "0x3D746F0", VA = "0x183D75CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3D75A00", Offset = "0x3D74400", VA = "0x183D75A00")]
	public bool CJGAFMKLKKJ(T MNIAGKNOHEJ, int OIHCLELFNKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3D75C90", Offset = "0x3D74690", VA = "0x183D75C90")]
	public bool GFAKBKOHHKC(int OIHCLELFNKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3D75F30", Offset = "0x3D74930", VA = "0x183D75F30")]
	public T NGKHKOEKAGI(int OJEBPIIDOHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3D76120", Offset = "0x3D74B20", VA = "0x183D76120")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3D75AF0", Offset = "0x3D744F0", VA = "0x183D75AF0")]
	private bool CMBCCDCDPJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3D75AC0", Offset = "0x3D744C0", VA = "0x183D75AC0")]
	public bool CKMNFEFPOIP(int OIHCLELFNKN, out T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D76180", Offset = "0x3D74B80", VA = "0x183D76180")]
	public ONFLPBDDMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class KLMDHAGMLDM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct OLAOOMPJALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T ACPLDDIHALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int EGCNKHAFBKM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<OLAOOMPJALP> PDHGIAOOCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T FLOHJHLKFOH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2217480", Offset = "0x2215E80", VA = "0x182217480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3121140", Offset = "0x311FB40", VA = "0x183121140")]
	public bool GGIBFCBBJNK(T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x31210A0", Offset = "0x311FAA0", VA = "0x1831210A0")]
	public void CPLOAHMOJFD(T MNIAGKNOHEJ, int OIHCLELFNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3121420", Offset = "0x311FE20", VA = "0x183121420")]
	public bool OLCIACFECIH(T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x31213C0", Offset = "0x311FDC0", VA = "0x1831213C0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3120E70", Offset = "0x311F870", VA = "0x183120E70")]
	public T ADIFMFCENCJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3121350", Offset = "0x311FD50", VA = "0x183121350")]
	public T KHNPNJINNFM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3120EE0", Offset = "0x311F8E0", VA = "0x183120EE0")]
	private void BAGKGEMLMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3121540", Offset = "0x311FF40", VA = "0x183121540")]
	public KLMDHAGMLDM()
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
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x6368E30", Offset = "0x6367830", VA = "0x186368E30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x63691C0", Offset = "0x6367BC0", VA = "0x1863691C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x6369040", Offset = "0x6367A40", VA = "0x186369040")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x6369320", Offset = "0x6367D20", VA = "0x186369320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x6368D50", Offset = "0x6367750", VA = "0x186368D50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x63690E0", Offset = "0x6367AE0", VA = "0x1863690E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6368F60", Offset = "0x6367960", VA = "0x186368F60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6368D00", Offset = "0x6367700", VA = "0x186368D00")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface JIPOJALMAMN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : JIPOJALMAMN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x26ACC70", Offset = "0x26AB670", VA = "0x1826ACC70", Slot = "4")]
		public virtual T KMCFNBGFMPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class JONHHCLMFHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Dictionary<byte, COOIJNFMABI> MNLPAOHBMCN;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public COOIJNFMABI EECHIFECBON
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 BBMGOAMAMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B710", Offset = "0x1E2A110", VA = "0x181E2B710")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x70ACD0", Offset = "0x7096D0", VA = "0x18070ACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 HFCCNDHHIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x212E550", Offset = "0x212CF50", VA = "0x18212E550")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9ECFA0", Offset = "0x9EB9A0", VA = "0x1809ECFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 OIDGLJFEHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6366B70", Offset = "0x6365570", VA = "0x186366B70")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xEA7040", Offset = "0xEA5A40", VA = "0x180EA7040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int NECMALEGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C10E0", Offset = "0x6BFAE0", VA = "0x1806C10E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x728640", Offset = "0x727040", VA = "0x180728640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6366B90", Offset = "0x6365590", VA = "0x186366B90")]
	public JONHHCLMFHF(Bounds FCAHGMFILOI, Vector2[] HAGFPFFFOPB, int ONCJADGMGPC, byte FHINICACAAN, float JIGKMIAAPFP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6366490", Offset = "0x6364E90", VA = "0x186366490")]
	public COOIJNFMABI CNJHMKJHLED(byte GFDMFLGCBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6366A70", Offset = "0x6365470", VA = "0x186366A70")]
	public void NLNBMDDNNFK(Vector3 OAALNDIAAOB, float NKJDKBHNDHA, float NJDJCKBFKJJ, ref List<byte> GMCOHGHMEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x63664F0", Offset = "0x6364EF0", VA = "0x1863664F0")]
	public void HKPMBPEEHAG(COOIJNFMABI.LAGCCJDPFDB KLIDAACIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6366910", Offset = "0x6365310", VA = "0x186366910")]
	private COOIJNFMABI LINAHECKMNF(byte GFDMFLGCBKB, COOIJNFMABI.DGBFIDGCNAE BMCHAJBEEJI, COOIJNFMABI ELGBIOMPEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6366510", Offset = "0x6364F10", VA = "0x186366510")]
	private void INLIKHFNDKO(COOIJNFMABI ELGBIOMPEHN, Vector2[] HAGFPFFFOPB, int NDNHOFKCHAA, int NHFBFNGKIGE, int LOFNAAOBPHO, int HPBAJHCNDEA, float JIGKMIAAPFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class COOIJNFMABI
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum DGBFIDGCNAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum LAGCCJDPFDB
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
	public byte OBLECFEGGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 AEJCFIHENMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 PFDAMFBILGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 BLGFKMIHAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 LKGJOKIBHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public DGBFIDGCNAE PPFBNMIOAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public COOIJNFMABI NNHCCDNOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<COOIJNFMABI> BFOCMEJGOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public bool MCILLELIPKB;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6362000", Offset = "0x6360A00", VA = "0x186362000")]
	public COOIJNFMABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6361FA0", Offset = "0x63609A0", VA = "0x186361FA0")]
	public COOIJNFMABI(byte OGGLMCNMCLJ, DGBFIDGCNAE BMCHAJBEEJI, COOIJNFMABI ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6361BA0", Offset = "0x63605A0", VA = "0x186361BA0")]
	public void IBAFGGCIFCB(COOIJNFMABI DDLMBHAEKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public void HKPMBPEEHAG(int PLOKLJIKHBD, LAGCCJDPFDB KLIDAACIPKF, int KJNJJGGHDCK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6361CF0", Offset = "0x63606F0", VA = "0x186361CF0")]
	public void NLNBMDDNNFK(List<byte> GMCOHGHMEON, Vector3 OAALNDIAAOB, float NKJDKBHNDHA, float NJDJCKBFKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6361CA0", Offset = "0x63606A0", VA = "0x186361CA0")]
	public bool JBPEBAJBHDN(Vector3 OMMEPJAJELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6361C60", Offset = "0x6360660", VA = "0x186361C60")]
	public bool IDONDOIPGFF(Vector3 OMMEPJAJELH, float NCNJMLCCFNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class EFOOMCCNIOA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Dictionary<T, object> CCAEBDKFAJC;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x179EF20", Offset = "0x179D920", VA = "0x18179EF20")]
	public bool HFFFIEGGMOL(T GELKGNEAIAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2424B00", Offset = "0x2423500", VA = "0x182424B00")]
	public bool HFFFIEGGMOL(T GELKGNEAIAE, object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2424AA0", Offset = "0x24234A0", VA = "0x182424AA0")]
	public bool HFFFIEGGMOL(T GELKGNEAIAE, object DEGCIHEAIBD, out object KEMHDDEIPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2424A60", Offset = "0x2423460", VA = "0x182424A60")]
	public bool GHEHGNLLKGM(T GELKGNEAIAE, object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2424B40", Offset = "0x2423540", VA = "0x182424B40")]
	public bool JENEJJJJGBP(T GELKGNEAIAE, object DEGCIHEAIBD, out object KEMHDDEIPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x24249D0", Offset = "0x24233D0", VA = "0x1824249D0")]
	public bool GHEHGNLLKGM(T GELKGNEAIAE, object DEGCIHEAIBD, out object KEMHDDEIPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2424900", Offset = "0x2423300", VA = "0x182424900")]
	public void DIFBOFIFDCA(T GELKGNEAIAE, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2424930", Offset = "0x2423330", VA = "0x182424930")]
	public void EJMJHFKHFED(T GELKGNEAIAE, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2424B80", Offset = "0x2423580", VA = "0x182424B80")]
	public EFOOMCCNIOA()
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
		public struct CIIKDOKHFJJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> OKDFPKLCDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool GPDIKLIGGDD;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x88EF90", Offset = "0x88D990", VA = "0x18088EF90")]
			public CIIKDOKHFJJ(List<Component> OKDFPKLCDDM, bool GPDIKLIGGDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x24E1520", Offset = "0x24DFF20", VA = "0x1824E1520")]
			public PMKNKOMJMJA<T> OGILHMGHFKK()
			{
				return default(PMKNKOMJMJA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x24E1590", Offset = "0x24DFF90", VA = "0x1824E1590", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x24E1590", Offset = "0x24DFF90", VA = "0x1824E1590", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct PMKNKOMJMJA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly List<Component> OKDFPKLCDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly bool GPDIKLIGGDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private int GFDMFLGCBKB;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T PKICFDONLKD
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x2A5E980", Offset = "0x2A5D380", VA = "0x182A5E980", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x2A5E910", Offset = "0x2A5D310", VA = "0x182A5E910", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E950", Offset = "0x2A5D350", VA = "0x182A5E950")]
			public PMKNKOMJMJA(List<Component> OKDFPKLCDDM, bool GPDIKLIGGDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E840", Offset = "0x2A5D240", VA = "0x182A5E840", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E850", Offset = "0x2A5D250", VA = "0x182A5E850", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E900", Offset = "0x2A5D300", VA = "0x182A5E900", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x636B090", Offset = "0x6369A90", VA = "0x18636B090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x636B050", Offset = "0x6369A50", VA = "0x18636B050")]
		public ToolHierarchyCache(GameObject ICDBBFEMLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x636ACB0", Offset = "0x63696B0", VA = "0x18636ACB0")]
		private void JGKFDHOAMGH(GameObject ICDBBFEMLLL, bool GONNPACEKOP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x636AE10", Offset = "0x6369810", VA = "0x18636AE10")]
		public static void JGKFDHOAMGH(GameObject ICDBBFEMLLL, ref ToolHierarchyCache MPDNFFFOBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x636AF70", Offset = "0x6369970", VA = "0x18636AF70")]
		public void NPGHMBMFFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x636AF80", Offset = "0x6369980", VA = "0x18636AF80")]
		public void OLCKOIAOJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x262DC70", Offset = "0x262C670", VA = "0x18262DC70")]
		public void DODNGOIFGFH<T>(Action<T> CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x636AEA0", Offset = "0x63698A0", VA = "0x18636AEA0")]
		public Component KDCBGCKOICO(Type MAHAMGBPDNB, bool GPDIKLIGGDD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x262DFD0", Offset = "0x262C9D0", VA = "0x18262DFD0")]
		public T KDCBGCKOICO<T>(bool GPDIKLIGGDD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x636A8E0", Offset = "0x63692E0", VA = "0x18636A8E0")]
		public CIIKDOKHFJJ<Component> HHLCCJLMPBI(Type MAHAMGBPDNB, bool GPDIKLIGGDD = false)
		{
			return default(CIIKDOKHFJJ<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x262DF00", Offset = "0x262C900", VA = "0x18262DF00")]
		public CIIKDOKHFJJ<T> HHLCCJLMPBI<T>(bool GPDIKLIGGDD = false) where T : class
		{
			return default(CIIKDOKHFJJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x636A960", Offset = "0x6369360", VA = "0x18636A960")]
		public List<Component> HKIAPNOANNJ(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x636A7E0", Offset = "0x63691E0", VA = "0x18636A7E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache MEALLDFELFM, ToolHierarchyCache LOIOEMHMDAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x636A860", Offset = "0x6369260", VA = "0x18636A860", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache LAFPICAOEAI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class AFKFKCLKGMH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int ADCMDGEMNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int NEDFEKDGABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<T> KPKJFELPMLM;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x179F660", Offset = "0x179E060", VA = "0x18179F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T HIKMHHABHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x35ABBA0", Offset = "0x35AA5A0", VA = "0x1835ABBA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T JDFOAAPGLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x35ABF10", Offset = "0x35AA910", VA = "0x1835ABF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T NKENMPDLKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x35ABEB0", Offset = "0x35AA8B0", VA = "0x1835ABEB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x35AC000", Offset = "0x35AAA00", VA = "0x1835AC000")]
	public AFKFKCLKGMH(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x35ABD80", Offset = "0x35AA780", VA = "0x1835ABD80")]
	public void CPLOAHMOJFD(T KFOCABOAINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x35ABFC0", Offset = "0x35AA9C0", VA = "0x1835ABFC0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x35ABAB0", Offset = "0x35AA4B0", VA = "0x1835ABAB0")]
	public void AMMIMHIIFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x35ABB50", Offset = "0x35AA550", VA = "0x1835ABB50")]
	public void BBOKNMCDCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x35ABFB0", Offset = "0x35AA9B0", VA = "0x1835ABFB0")]
	public void LPNFMIBKKLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class AGALGAKNBGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool FGMFMDEBPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private Action CKAPOBIDCEI;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static AGALGAKNBGO FDNIEFEGJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6361220", Offset = "0x635FC20", VA = "0x186361220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BHHMGBOFKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C5250", Offset = "0x6C3C50", VA = "0x1806C5250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xBFBD40", Offset = "0xBFA740", VA = "0x180BFBD40")]
	public AGALGAKNBGO(Action CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x63612A0", Offset = "0x635FCA0", VA = "0x1863612A0")]
	public void MILDGAMNMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63612A0", Offset = "0x635FCA0", VA = "0x1863612A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class GNFLPFDCACL
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6362F00", Offset = "0x6361900", VA = "0x186362F00")]
	public static void GIODEGAEPCC(AJDDIJFCKOM FEPNGKFEELL, string DNKPGPEFAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	public static void GIODEGAEPCC(IEnumerable<object> GLOEEIEEKAA, string DNKPGPEFAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class GKHGDENIBME<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct PJPGKLIEHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int EGCNKHAFBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public T ACPLDDIHALN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<object, PJPGKLIEHBM> LPNBKHDOFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly EqualityComparer<T> PKIJKJKIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private T EKMBPFJPJAP;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T DDJHGNMNKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xBF2C40", Offset = "0xBF1640", VA = "0x180BF2C40", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2691CE0", Offset = "0x26906E0", VA = "0x182691CE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OPBFBJNLFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x31328F0", Offset = "0x31312F0", VA = "0x1831328F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object CGIGKFIKHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x312DAA0", Offset = "0x312C4A0", VA = "0x18312DAA0")]
	public bool CJGAFMKLKKJ(T MNIAGKNOHEJ, object DEGCIHEAIBD, int OIHCLELFNKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3132880", Offset = "0x3131280", VA = "0x183132880")]
	public bool GFAKBKOHHKC(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x312E3C0", Offset = "0x312CDC0", VA = "0x18312E3C0")]
	public bool CKMNFEFPOIP(object DEGCIHEAIBD, out T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x289F320", Offset = "0x289DD20", VA = "0x18289F320")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3130250", Offset = "0x312EC50", VA = "0x183130250")]
	private bool CMBCCDCDPJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x3132950", Offset = "0x3131350", VA = "0x183132950")]
	public GKHGDENIBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class IPKHHDOMBAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<object, float> LPNBKHDOFBH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float HLMNBPNICLL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x11DE660", Offset = "0x11DD060", VA = "0x1811DE660")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE1D810", Offset = "0xE1C210", VA = "0x180E1D810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6364F50", Offset = "0x6363950", VA = "0x186364F50")]
	public void CJGAFMKLKKJ(float MNIAGKNOHEJ, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x63650E0", Offset = "0x6363AE0", VA = "0x1863650E0")]
	public void GFAKBKOHHKC(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6364FC0", Offset = "0x63639C0", VA = "0x186364FC0")]
	private void EADCFBFJEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6365150", Offset = "0x6363B50", VA = "0x186365150")]
	public IPKHHDOMBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class BCNMCHLKHFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string MEDGBKNLKPL;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	public BCNMCHLKHFL(string KPEMDPJKHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6361870", Offset = "0x6360270", VA = "0x186361870")]
	public BCNMCHLKHFL(UnityEngine.Object LKCNNOEAOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6361820", Offset = "0x6360220", VA = "0x186361820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class AJDDIJFCKOM
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class NLNHLJPIHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NLNHLJPIHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6368A20", Offset = "0x6367420", VA = "0x186368A20")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private HashSet<object> GLOEEIEEKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int IPBLINELKDJ;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> HENALIPPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6361490", Offset = "0x635FE90", VA = "0x186361490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LFBPAPAJLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6361480", Offset = "0x635FE80", VA = "0x186361480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x63612C0", Offset = "0x635FCC0", VA = "0x1863612C0")]
	public bool CPLOAHMOJFD(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6361560", Offset = "0x635FF60", VA = "0x186361560")]
	public bool OLCIACFECIH(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6361420", Offset = "0x635FE20", VA = "0x186361420")]
	public bool GGIBFCBBJNK(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x63613B0", Offset = "0x635FDB0", VA = "0x1863613B0")]
	public void DBPMBIOJNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x6361600", Offset = "0x6360000", VA = "0x186361600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public AJDDIJFCKOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class PIEOFAGIBKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct HPIOLPHHFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float KMLBJNLHNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T ACPLDDIHALN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Dictionary<object, HPIOLPHHFEP> LPNBKHDOFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T MNEJKAJEGOI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T PIFBAEHADOE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xFF0760", Offset = "0xFEF160", VA = "0x180FF0760", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xFEF400", Offset = "0xFEDE00", VA = "0x180FEF400", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object OHGDCDGCJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OPBFBJNLFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x314C670", Offset = "0x314B070", VA = "0x18314C670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x314AC40", Offset = "0x3149640", VA = "0x18314AC40")]
	public bool CJGAFMKLKKJ(T MNIAGKNOHEJ, object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x314C610", Offset = "0x314B010", VA = "0x18314C610")]
	public bool GFAKBKOHHKC(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x289F320", Offset = "0x289DD20", VA = "0x18289F320")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x314AD40", Offset = "0x3149740", VA = "0x18314AD40")]
	public bool CKMNFEFPOIP(object DEGCIHEAIBD, out T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x314BBC0", Offset = "0x314A5C0", VA = "0x18314BBC0")]
	private bool CMBCCDCDPJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x314C6B0", Offset = "0x314B0B0", VA = "0x18314C6B0")]
	public PIEOFAGIBKK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x63674A0", Offset = "0x6365EA0", VA = "0x1863674A0")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6367150", Offset = "0x6365B50", VA = "0x186367150")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
