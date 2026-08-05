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
public class OJDHGHKLCGL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
	public OJDHGHKLCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, FLDIIEDDNHD, HEPGAIPANLN, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6949A0", Offset = "0x6937A0", VA = "0x1806949A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IAIMPBMLKHB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AD0", Offset = "0x6D58D0", VA = "0x1806D6AD0")]
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
	[AEOHFHBJLNK]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[AEOHFHBJLNK]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0D20", Offset = "0x5DAFB20", VA = "0x185DB0D20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0CE0", Offset = "0x5DAFAE0", VA = "0x185DB0CE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0D60", Offset = "0x5DAFB60", VA = "0x185DB0D60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0F30", Offset = "0x5DAFD30", VA = "0x185DB0F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0EA0", Offset = "0x5DAFCA0", VA = "0x185DB0EA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E9160", Offset = "0x7E7F60", VA = "0x1807E9160")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x815360", Offset = "0x814160", VA = "0x180815360")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0CA0", Offset = "0x5DAFAA0", VA = "0x185DB0CA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0E10", Offset = "0x5DAFC10", VA = "0x185DB0E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DB08D0", Offset = "0x5DAF6D0", VA = "0x185DB08D0")]
	public void CopyBounds(SavedExtents MCLIMJFDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0C00", Offset = "0x5DAFA00", VA = "0x185DB0C00")]
	public void SetLocalSpaceBounds(Bounds MOIGDNCDPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x909490", Offset = "0x908290", VA = "0x180909490")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0BF0", Offset = "0x5DAF9F0", VA = "0x185DB0BF0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DB00A0", Offset = "0x5DAEEA0", VA = "0x185DB00A0")]
	private void BLMKHGDLCFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DB09C0", Offset = "0x5DAF7C0", VA = "0x185DB09C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0290", Offset = "0x5DAF090", VA = "0x185DB0290")]
	public static void CalculateLocalBoundsFor(GameObject ENOCMPCACJI, out Bounds MOIGDNCDPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0900", Offset = "0x5DAF700", VA = "0x185DB0900")]
	private static void ECCJAHCCPND(Bounds GHDGKPNPOBN, Color EKIHFBHEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0C20", Offset = "0x5DAFA20", VA = "0x185DB0C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BA0", Offset = "0x6C09A0", VA = "0x1806C1BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894FC0", VA = "0x1808961C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE6FC70", Offset = "0xE6EA70", VA = "0x180E6FC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	public virtual void DPALNENFJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
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
	[OJDHGHKLCGL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31655F0", Offset = "0x31643F0", VA = "0x1831655F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3164D20", Offset = "0x3163B20", VA = "0x183164D20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3165B30", Offset = "0x3164930", VA = "0x183165B30")]
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
	private sealed class NNAOLMOMHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public NNAOLMOMHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BEA530", Offset = "0x2BE9330", VA = "0x182BEA530")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[OJDHGHKLCGL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x176B020", Offset = "0x1769E20", VA = "0x18176B020", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x176B050", Offset = "0x1769E50", VA = "0x18176B050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x176AF70", Offset = "0x1769D70", VA = "0x18176AF70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey BIMCDHOFDCP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x176AFD0", Offset = "0x1769DD0", VA = "0x18176AFD0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x176AE70", Offset = "0x1769C70", VA = "0x18176AE70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x176A9C0", Offset = "0x17697C0", VA = "0x18176A9C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x176A1E0", Offset = "0x1768FE0", VA = "0x18176A1E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1769DA0", Offset = "0x1768BA0", VA = "0x181769DA0", Slot = "14")]
	protected virtual string DLBAAHPGIGI(TKeyVal MOFCMNMIPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1769D70", Offset = "0x1768B70", VA = "0x181769D70", Slot = "4")]
	public bool ContainsKey(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x176AD60", Offset = "0x1769B60", VA = "0x18176AD60", Slot = "5")]
	public bool TryGetValue(TKey BIMCDHOFDCP, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1769E30", Offset = "0x1768C30", VA = "0x181769E30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1769E30", Offset = "0x1768C30", VA = "0x181769E30", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x176AD90", Offset = "0x1769B90", VA = "0x18176AD90")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DJDFKEDPPCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KOIKAOEPPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public KOIKAOEPPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3602060", Offset = "0x3600E60", VA = "0x183602060")]
		internal bool <GetSamples>b__0(global::LJNOPIFCOMG<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float IBKKIPPADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PLNLCDCDNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::LJNOPIFCOMG<float, T>> BBMLLFCPOBB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NFABGCPJENC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x364D610", Offset = "0x364C410", VA = "0x18364D610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x364DA10", Offset = "0x364C810", VA = "0x18364DA10")]
	public DJDFKEDPPCI(float GMNDMAKLFDA, float DJAHALFABJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x364D7F0", Offset = "0x364C5F0", VA = "0x18364D7F0")]
	public bool JBLKNPBAJON(float MPPFCIMADEL, T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x364D500", Offset = "0x364C300", VA = "0x18364D500")]
	public int GBGFHNGHHJD(float MPPFCIMADEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x364D1C0", Offset = "0x364BFC0", VA = "0x18364D1C0")]
	public IEnumerable<T> CMDGPBFGEDM(float MPPFCIMADEL, [Optional] float? NCLPDNPIBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x364D560", Offset = "0x364C360", VA = "0x18364D560")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x364D950", Offset = "0x364C750", VA = "0x18364D950")]
	private void OGENFFHCAHL(float MPPFCIMADEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FHOAGDMDMFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OJLKHOFBPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T AMPEKKPGHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float FCLPAKFBGCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float CCBDAKCDAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> MJNLICEKGDI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int ADBJOLLFPIJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private OJLKHOFBPLC[] EJLDCNGHIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MIKIOIHOKLA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float EMFIKIHIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x895A10", Offset = "0x894810", VA = "0x180895A10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x895AA0", Offset = "0x8948A0", VA = "0x180895AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2884370", Offset = "0x2883170", VA = "0x182884370")]
	public FHOAGDMDMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28843A0", Offset = "0x28831A0", VA = "0x1828843A0")]
	public FHOAGDMDMFC(int LBLAPKMJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2883230", Offset = "0x2882030", VA = "0x182883230")]
	public void ELGBPIMHCCH(float MPPFCIMADEL, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2883A80", Offset = "0x2882880", VA = "0x182883A80")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28834F0", Offset = "0x28822F0", VA = "0x1828834F0")]
	public bool GGNGENFAJGG(float CBBEIMNONNO, float JDNINCPFJBD, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2884180", Offset = "0x2882F80", VA = "0x182884180")]
	public bool JGNFMOIOFJN(float CBBEIMNONNO, float JDNINCPFJBD, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2883000", Offset = "0x2881E00", VA = "0x182883000")]
	public void CEINOECCFPH(float CBBEIMNONNO, float JDNINCPFJBD, List<T> NFMJIELOGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28842F0", Offset = "0x28830F0", VA = "0x1828842F0")]
	private int MNFLKNJLAKO(int KFIMLMLLABJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28834B0", Offset = "0x28822B0", VA = "0x1828834B0")]
	private void FMGPJEDLAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NPOIFJECAMF();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MOHCGNMJBMF(T MGIINGKDNDK, T GNLBKLBDKBA, float NDJEJACDKEB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CENIBHOEPBG(T GKFICKKHACC, float NDJEJACDKEB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NIPPNNMGLID(T MGIINGKDNDK, T GNLBKLBDKBA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BCAEAPDLMAO(T MGIINGKDNDK, T GNLBKLBDKBA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HINJHOCGJOE : global::FHOAGDMDMFC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x862B90", Offset = "0x861990", VA = "0x180862B90", Slot = "4")]
	protected override Vector3 NPOIFJECAMF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1B77A90", Offset = "0x1B76890", VA = "0x181B77A90", Slot = "5")]
	protected override Vector3 MOHCGNMJBMF(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC240", Offset = "0x5DAB040", VA = "0x185DAC240", Slot = "6")]
	protected override Vector3 CENIBHOEPBG(Vector3 GKFICKKHACC, float NDJEJACDKEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC2A0", Offset = "0x5DAB0A0", VA = "0x185DAC2A0", Slot = "7")]
	protected override Vector3 NIPPNNMGLID(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC1D0", Offset = "0x5DAAFD0", VA = "0x185DAC1D0", Slot = "8")]
	protected override Vector3 BCAEAPDLMAO(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC320", Offset = "0x5DAB120", VA = "0x185DAC320")]
	public HINJHOCGJOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JHPMKGMOOJA : global::FHOAGDMDMFC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB90", Offset = "0x5DAC990", VA = "0x185DADB90")]
	public JHPMKGMOOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB20", Offset = "0x5DAC920", VA = "0x185DADB20")]
	public JHPMKGMOOJA(int LBLAPKMJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EBB10", Offset = "0x7EA910", VA = "0x1807EBB10", Slot = "4")]
	protected override float NPOIFJECAMF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x894DB0", Offset = "0x893BB0", VA = "0x180894DB0", Slot = "5")]
	protected override float MOHCGNMJBMF(float MGIINGKDNDK, float GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5064820", Offset = "0x5063620", VA = "0x185064820", Slot = "6")]
	protected override float CENIBHOEPBG(float GKFICKKHACC, float NDJEJACDKEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A22DA0", Offset = "0x2A21BA0", VA = "0x182A22DA0", Slot = "7")]
	protected override float NIPPNNMGLID(float MGIINGKDNDK, float GNLBKLBDKBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB10", Offset = "0x5DAC910", VA = "0x185DADB10", Slot = "8")]
	protected override float BCAEAPDLMAO(float MGIINGKDNDK, float GNLBKLBDKBA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EMEKAMMHBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26FD490", Offset = "0x26FC290", VA = "0x1826FD490")]
	public static global::FGDHGNAGJPF<T1> GLBIKEOEKPG<T1>(T1 AKLCFJHIHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26FCF90", Offset = "0x26FBD90", VA = "0x1826FCF90")]
	public static global::LJNOPIFCOMG<T1, T2> GLBIKEOEKPG<T1, T2>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26FD000", Offset = "0x26FBE00", VA = "0x1826FD000")]
	public static global::EJLOBEOJGJG<T1, T2, T3> GLBIKEOEKPG<T1, T2, T3>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26FD370", Offset = "0x26FC170", VA = "0x1826FD370")]
	public static global::ONEAHEBEGJL<T1, T2, T3, T4> GLBIKEOEKPG<T1, T2, T3, T4>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26FD2D0", Offset = "0x26FC0D0", VA = "0x1826FD2D0")]
	public static global::NEONLNAGOAD<T1, T2, T3, T4, T5> GLBIKEOEKPG<T1, T2, T3, T4, T5>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26FD220", Offset = "0x26FC020", VA = "0x1826FD220")]
	public static global::GIHHLPNBBLF<T1, T2, T3, T4, T5, T6> GLBIKEOEKPG<T1, T2, T3, T4, T5, T6>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26FD160", Offset = "0x26FBF60", VA = "0x1826FD160")]
	public static global::ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7> GLBIKEOEKPG<T1, T2, T3, T4, T5, T6, T7>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26FD090", Offset = "0x26FBE90", VA = "0x1826FD090")]
	public static global::FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8> GLBIKEOEKPG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ, T8 EMAJAILPPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2372EF0", Offset = "0x2371CF0", VA = "0x182372EF0")]
	[IteratorStateMachine(typeof(MKHDFMGKFEH))]
	public static IEnumerable<global::LJNOPIFCOMG<T1, T2>> AGOOACLCPCI<T1, T2>(IEnumerable<T1> LEOEMBMBFBC, IEnumerable<T2> GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26FCED0", Offset = "0x26FBCD0", VA = "0x1826FCED0")]
	[IteratorStateMachine(typeof(GCHGIKLCPLD))]
	public static IEnumerable<global::EJLOBEOJGJG<T1, T2, T3>> AGOOACLCPCI<T1, T2, T3>(IEnumerable<T1> LEOEMBMBFBC, IEnumerable<T2> GHDGKPNPOBN, IEnumerable<T3> EKIHFBHEKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA91C90", Offset = "0xA90A90", VA = "0x180A91C90")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA91C80", Offset = "0xA90A80", VA = "0x180A91C80")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA91C60", Offset = "0xA90A60", VA = "0x180A91C60")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8F90", Offset = "0x5DA7D90", VA = "0x185DA8F90")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9010", Offset = "0x5DA7E10", VA = "0x185DA9010")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM, int KMLLAKNOBHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8FE0", Offset = "0x5DA7DE0", VA = "0x185DA8FE0")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM, int KMLLAKNOBHL, int BMFAKOGKLJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8FB0", Offset = "0x5DA7DB0", VA = "0x185DA8FB0")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM, int KMLLAKNOBHL, int BMFAKOGKLJO, int MBNHFJPJACK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FGDHGNAGJPF<T1> : IComparable<global::FGDHGNAGJPF<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1F37750", Offset = "0x1F36550", VA = "0x181F37750")]
	public FGDHGNAGJPF(T1 AKLCFJHIHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x287E8C0", Offset = "0x287D6C0", VA = "0x18287E8C0", Slot = "4")]
	public int CompareTo(global::FGDHGNAGJPF<T1> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x287E930", Offset = "0x287D730", VA = "0x18287E930", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7716B0", Offset = "0x7704B0", VA = "0x1807716B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x287E9D0", Offset = "0x287D7D0", VA = "0x18287E9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LJNOPIFCOMG<T1, T2> : IComparable<global::LJNOPIFCOMG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7FD0", Offset = "0x2BC6DD0", VA = "0x182BC7FD0")]
	public LJNOPIFCOMG(T1 AKLCFJHIHNK, T2 OLPHBONPDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5FC0", Offset = "0x2BC4DC0", VA = "0x182BC5FC0", Slot = "4")]
	public int CompareTo(global::LJNOPIFCOMG<T1, T2> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6610", Offset = "0x2BC5410", VA = "0x182BC6610", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC72B0", Offset = "0x2BC60B0", VA = "0x182BC72B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7930", Offset = "0x2BC6730", VA = "0x182BC7930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EJLOBEOJGJG<T1, T2, T3> : IComparable<global::EJLOBEOJGJG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x331DDD0", Offset = "0x331CBD0", VA = "0x18331DDD0")]
	public EJLOBEOJGJG(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x331D6C0", Offset = "0x331C4C0", VA = "0x18331D6C0", Slot = "4")]
	public int CompareTo(global::EJLOBEOJGJG<T1, T2, T3> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x331D7C0", Offset = "0x331C5C0", VA = "0x18331D7C0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x331DAB0", Offset = "0x331C8B0", VA = "0x18331DAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x331DB10", Offset = "0x331C910", VA = "0x18331DB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ONEAHEBEGJL<T1, T2, T3, T4> : IComparable<global::ONEAHEBEGJL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31BAA70", Offset = "0x31B9870", VA = "0x1831BAA70")]
	public ONEAHEBEGJL(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x383E1B0", Offset = "0x383CFB0", VA = "0x18383E1B0", Slot = "4")]
	public int CompareTo(global::ONEAHEBEGJL<T1, T2, T3, T4> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x383E2F0", Offset = "0x383D0F0", VA = "0x18383E2F0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x383E410", Offset = "0x383D210", VA = "0x18383E410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x383E4D0", Offset = "0x383D2D0", VA = "0x18383E4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NEONLNAGOAD<T1, T2, T3, T4, T5> : IComparable<global::NEONLNAGOAD<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3880", Offset = "0x2BD2680", VA = "0x182BD3880")]
	public NEONLNAGOAD(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3370", Offset = "0x2BD2170", VA = "0x182BD3370", Slot = "4")]
	public int CompareTo(global::NEONLNAGOAD<T1, T2, T3, T4, T5> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD34F0", Offset = "0x2BD22F0", VA = "0x182BD34F0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3630", Offset = "0x2BD2430", VA = "0x182BD3630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3730", Offset = "0x2BD2530", VA = "0x182BD3730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GIHHLPNBBLF<T1, T2, T3, T4, T5, T6> : IComparable<global::GIHHLPNBBLF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 OCJOMHPHPGB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x31C0C90", Offset = "0x31BFA90", VA = "0x1831C0C90")]
	public GIHHLPNBBLF(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31C06D0", Offset = "0x31BF4D0", VA = "0x1831C06D0", Slot = "4")]
	public int CompareTo(global::GIHHLPNBBLF<T1, T2, T3, T4, T5, T6> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x31C0890", Offset = "0x31BF690", VA = "0x1831C0890", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x31C0A00", Offset = "0x31BF800", VA = "0x1831C0A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x31C0B20", Offset = "0x31BF920", VA = "0x1831C0B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 OCJOMHPHPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 LLOBDOBJMGO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1650", Offset = "0x3AF0450", VA = "0x183AF1650")]
	public ACKKNBPGNFD(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0FD0", Offset = "0x3AEFDD0", VA = "0x183AF0FD0", Slot = "4")]
	public int CompareTo(global::ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF11D0", Offset = "0x3AEFFD0", VA = "0x183AF11D0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1370", Offset = "0x3AF0170", VA = "0x183AF1370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3AF14C0", Offset = "0x3AF02C0", VA = "0x183AF14C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 OCJOMHPHPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 LLOBDOBJMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 FNBONADOCIL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2877490", Offset = "0x2876290", VA = "0x182877490")]
	public FCCHPDAFJEJ(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ, T8 EMAJAILPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2876D60", Offset = "0x2875B60", VA = "0x182876D60", Slot = "4")]
	public int CompareTo(global::FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2876FB0", Offset = "0x2875DB0", VA = "0x182876FB0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2877170", Offset = "0x2875F70", VA = "0x182877170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x28772E0", Offset = "0x28760E0", VA = "0x1828772E0", Slot = "3")]
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
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9820", Offset = "0x1DC8620", VA = "0x181DC9820")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E4ABE0", Offset = "0x3E499E0", VA = "0x183E4ABE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float BCFDIMBHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x705F90", Offset = "0x704D90", VA = "0x180705F90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AE80", Offset = "0x3E49C80", VA = "0x183E4AE80")]
	public T HNDJMJCNHEL(float NDJEJACDKEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AFE0", Offset = "0x3E49DE0", VA = "0x183E4AFE0")]
	public T OFLBLFPMMGH(float NDJEJACDKEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MOHCGNMJBMF(T MGIINGKDNDK, T GNLBKLBDKBA, float NDJEJACDKEB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x894DB0", Offset = "0x893BB0", VA = "0x180894DB0", Slot = "4")]
	protected override float MOHCGNMJBMF(float MGIINGKDNDK, float GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA380", Offset = "0x5DA9180", VA = "0x185DAA380")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1B77A90", Offset = "0x1B76890", VA = "0x181B77A90", Slot = "4")]
	protected override Vector3 MOHCGNMJBMF(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1EC0", Offset = "0x5DB0CC0", VA = "0x185DB1EC0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA86F0", Offset = "0x5DA74F0", VA = "0x185DA86F0", Slot = "4")]
	protected override Color MOHCGNMJBMF(Color MGIINGKDNDK, Color GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8740", Offset = "0x5DA7540", VA = "0x185DA8740")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DKGJHLLCHDL : global::OFNFJFAMGLI<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8C30", Offset = "0x5DA7A30", VA = "0x185DA8C30")]
	public DKGJHLLCHDL(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8BD0", Offset = "0x5DA79D0", VA = "0x185DA8BD0")]
	public DKGJHLLCHDL(NNOPJMODPBD[] NGBDNOPFIDJ, bool POGPOIGBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8B60", Offset = "0x5DA7960", VA = "0x185DA8B60", Slot = "6")]
	protected override uint GEDFFPAJIBB(uint IAIMPBMLKHB, string GKFICKKHACC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FDLNGMDIBIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public FDLNGMDIBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct OAMOLMBHKGN
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LPAGGOAEGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<OIGDPEFJPLN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LPAGGOAEGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAED60", Offset = "0x5DADB60", VA = "0x185DAED60")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OIGDPEFJPLN>> GLMFPOBMGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int KNEECEJPFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int OKNDEHJOKGG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x900840", Offset = "0x8FF640", VA = "0x180900840")]
	private OAMOLMBHKGN(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OIGDPEFJPLN>> JEEAKIIOILI, int OCDHAMCKHGC, int LJHJJDLEMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF590", Offset = "0x5DAE390", VA = "0x185DAF590")]
	public static OAMOLMBHKGN KCNAIILPDFM()
	{
		return default(OAMOLMBHKGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF1A0", Offset = "0x5DADFA0", VA = "0x185DAF1A0")]
	public (int, int, Task) GHEEGHJCLIA(int KOKPOEFBIML, [Optional] CancellationToken ADCKNELPFOJ)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF0C0", Offset = "0x5DADEC0", VA = "0x185DAF0C0")]
	public void FFGOPJFCEBO(int KOKPOEFBIML, int LJHJJDLEMKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class APBPNHKBAFN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> MCLMIDHFLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> MBKPIGGFJFM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x24F68D0", Offset = "0x24F56D0", VA = "0x1824F68D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GFDLDMBAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D480", Offset = "0x2D0C280", VA = "0x182D0D480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> KMNHDDOCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x30AFDB0", Offset = "0x30AEBB0", VA = "0x1830AFDB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3788D70", Offset = "0x3787B70", VA = "0x183788D70", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x39C34F0", Offset = "0x39C22F0", VA = "0x1839C34F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x39C2C90", Offset = "0x39C1A90", VA = "0x1839C2C90")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x39C2F00", Offset = "0x39C1D00", VA = "0x1839C2F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x39C2940", Offset = "0x39C1740", VA = "0x1839C2940", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x39C3370", Offset = "0x39C2170", VA = "0x1839C3370", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B170", Offset = "0x2F09F70", VA = "0x182F0B170", Slot = "9")]
	public void Add(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x39C2910", Offset = "0x39C1710", VA = "0x1839C2910", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x39C29A0", Offset = "0x39C17A0", VA = "0x1839C29A0", Slot = "8")]
	public bool ContainsKey(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x397B840", Offset = "0x397A640", VA = "0x18397B840", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x39C3340", Offset = "0x39C2140", VA = "0x1839C3340", Slot = "10")]
	public bool Remove(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39C3340", Offset = "0x39C2140", VA = "0x1839C3340", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x381F800", Offset = "0x381E600", VA = "0x18381F800", Slot = "11")]
	public bool TryGetValue(TKey BIMCDHOFDCP, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x39C2E80", Offset = "0x39C1C80", VA = "0x1839C2E80", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39C2A00", Offset = "0x39C1800", VA = "0x1839C2A00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39C2B00", Offset = "0x39C1900", VA = "0x1839C2B00")]
	public void ELGBPIMHCCH(TVal FIHIOAOIPNG, TKey BIMCDHOFDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x39C2B40", Offset = "0x39C1940", VA = "0x1839C2B40")]
	public void ELGBPIMHCCH(KeyValuePair<TVal, TKey> MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39C2FE0", Offset = "0x39C1DE0", VA = "0x1839C2FE0")]
	public bool MMDFCNEELDN(TVal BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x39C2F80", Offset = "0x39C1D80", VA = "0x1839C2F80")]
	public bool KOOJGAMNGBI(KeyValuePair<TVal, TKey> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F44020", Offset = "0x2F42E20", VA = "0x182F44020")]
	public bool DOHHNJJEEIG(TVal BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F44020", Offset = "0x2F42E20", VA = "0x182F44020")]
	public bool DOHHNJJEEIG(KeyValuePair<TVal, TKey> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x39C2DD0", Offset = "0x39C1BD0", VA = "0x1839C2DD0")]
	public bool GINCMLLPDOD(TVal BIMCDHOFDCP, out TKey GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x39C2D50", Offset = "0x39C1B50", VA = "0x1839C2D50")]
	public IEnumerator<KeyValuePair<TVal, TKey>> GGACKCNAKED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x39C2B80", Offset = "0x39C1980", VA = "0x1839C2B80")]
	private void GBAOBEDBANH(TKey BIMCDHOFDCP, TVal FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x39C27D0", Offset = "0x39C15D0", VA = "0x1839C27D0")]
	private void AENHIGPGMKI(TKey BIMCDHOFDCP, TVal FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x39C3190", Offset = "0x39C1F90", VA = "0x1839C3190")]
	private bool NPHFNODOKBI(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x39C3250", Offset = "0x39C2050", VA = "0x1839C3250")]
	private bool NPHFNODOKBI(TVal FIHIOAOIPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x39C3410", Offset = "0x39C2210", VA = "0x1839C3410")]
	public APBPNHKBAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class JJOODFODJOE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::JJOODFODJOE<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3592580", Offset = "0x3591380", VA = "0x183592580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x336C950", Offset = "0x336B750", VA = "0x18336C950")]
		public Enumerator(global::JJOODFODJOE<T> NFMJIELOGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x358F3F0", Offset = "0x358E1F0", VA = "0x18358F3F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3590F70", Offset = "0x358FD70", VA = "0x183590F70", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x358E8D0", Offset = "0x358D6D0", VA = "0x18358E8D0")]
		private void FEGAICJJDPO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] PAACEHPKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int IOGAMBOBGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int EJDDJHJACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int OPAPEIICLLC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F48650", Offset = "0x3F47450", VA = "0x183F48650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F48A60", Offset = "0x3F47860", VA = "0x183F48A60")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F48C80", Offset = "0x3F47A80", VA = "0x183F48C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3F495D0", Offset = "0x3F483D0", VA = "0x183F495D0")]
	public JJOODFODJOE(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3F48830", Offset = "0x3F47630", VA = "0x183F48830")]
	public void ELGBPIMHCCH(T NDJEJACDKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3F47CB0", Offset = "0x3F46AB0", VA = "0x183F47CB0")]
	public void CIOCKIHBBLE(IEnumerable<T> HIPOJJABCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F48BE0", Offset = "0x3F479E0", VA = "0x183F48BE0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3F48E80", Offset = "0x3F47C80", VA = "0x183F48E80")]
	public void KNODKDJMCEN(int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F48DF0", Offset = "0x3F47BF0", VA = "0x183F48DF0")]
	public void IFDLBGGBBLI(int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3F491B0", Offset = "0x3F47FB0", VA = "0x183F491B0")]
	public void NHNMLLALKJF(T[] EJLDCNGHIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3F489E0", Offset = "0x3F477E0", VA = "0x183F489E0")]
	public Enumerator EMHOENNLHOC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F49450", Offset = "0x3F48250", VA = "0x183F49450", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F49450", Offset = "0x3F48250", VA = "0x183F49450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F48290", Offset = "0x3F47090", VA = "0x183F48290")]
	private int DLIGJKGCCJK(int BNNEENLPEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F48690", Offset = "0x3F47490", VA = "0x183F48690")]
	private int EFKCIFJDIBL(int BNNEENLPEFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class JNHGDPHDOEN<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> FGIDPBOLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> LNBMIHEECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77DA20", VA = "0x18077EC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4119A80", Offset = "0x4118880", VA = "0x184119A80", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4119B20", Offset = "0x4118920", VA = "0x184119B20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4119A20", Offset = "0x4118820", VA = "0x184119A20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3345120", Offset = "0x3343F20", VA = "0x183345120")]
	public JNHGDPHDOEN(Func<Internal, External> IEPBJFBIJCM, Func<External, Internal> FGIDPBOLFPN, bool PHLJIIECGMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4119740", Offset = "0x4118540", VA = "0x184119740", Slot = "6")]
	public int IndexOf(External MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x41193C0", Offset = "0x41181C0", VA = "0x1841193C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4119420", Offset = "0x4118220", VA = "0x184119420", Slot = "13")]
	public bool Contains(External MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x41194B0", Offset = "0x41182B0", VA = "0x1841194B0", Slot = "14")]
	public void CopyTo(External[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x41192D0", Offset = "0x41180D0", VA = "0x1841192D0", Slot = "11")]
	public void Add(External MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4119830", Offset = "0x4118630", VA = "0x184119830", Slot = "7")]
	public void Insert(int BNNEENLPEFO, External MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4119990", Offset = "0x4118790", VA = "0x184119990", Slot = "15")]
	public bool Remove(External MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x41198D0", Offset = "0x41186D0", VA = "0x1841198D0", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x41196D0", Offset = "0x41184D0", VA = "0x1841196D0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x28A5CD0", Offset = "0x28A4AD0", VA = "0x1828A5CD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class ACIGMFOPGPF<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> LNBMIHEECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0F30", Offset = "0x3AEFD30", VA = "0x183AF0F30", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0ED0", Offset = "0x3AEFCD0", VA = "0x183AF0ED0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1F37750", Offset = "0x1F36550", VA = "0x181F37750")]
	public ACIGMFOPGPF(Func<Internal, External> IEPBJFBIJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E80", Offset = "0x3AEFC80", VA = "0x183AF0E80")]
	public ACIGMFOPGPF(IReadOnlyList<Internal> LENGKEKMOEB, Func<Internal, External> IEPBJFBIJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0C60", Offset = "0x3AEFA60", VA = "0x183AF0C60")]
	public void NHNMLLALKJF(External[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0BF0", Offset = "0x3AEF9F0", VA = "0x183AF0BF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x25A2D30", Offset = "0x25A1B30", VA = "0x1825A2D30", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MDHCAHMIMOG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> LNBMIHEECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28A5D60", Offset = "0x28A4B60", VA = "0x1828A5D60", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28A5D00", Offset = "0x28A4B00", VA = "0x1828A5D00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1F37750", Offset = "0x1F36550", VA = "0x181F37750")]
	public MDHCAHMIMOG(IReadOnlyList<Internal> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x28A5A00", Offset = "0x28A4800", VA = "0x1828A5A00")]
	public bool KOOJGAMNGBI(External MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x28A5AA0", Offset = "0x28A48A0", VA = "0x1828A5AA0")]
	public void NHNMLLALKJF(External[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x28A5990", Offset = "0x28A4790", VA = "0x1828A5990", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x28A5CD0", Offset = "0x28A4AD0", VA = "0x1828A5CD0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class KGKPPJLLDNK
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BPEKIJOIAJF(object[] MAGEMABOILP);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	protected KGKPPJLLDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class AAJNGDMNEFI<T> : KGKPPJLLDNK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct HKBNCHEIJFA
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum NGIDLNJEKDE
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
		public NGIDLNJEKDE BIEGICDMJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T KDJGJCHCIKK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int OLPELHMNIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool PCFLOCECMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool LPCKLOPBENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> LIEGKDMDMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<HKBNCHEIJFA> BFAGCMLKEFM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JHMCGHJCCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE210", Offset = "0x3AED010", VA = "0x183AEE210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE4A0", Offset = "0x3AED2A0", VA = "0x183AEE4A0")]
	protected AAJNGDMNEFI(bool LPCKLOPBENG, bool PCFLOCECMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE360", Offset = "0x3AED160", VA = "0x183AEE360")]
	protected bool LHAKGNDBACI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE3E0", Offset = "0x3AED1E0", VA = "0x183AEE3E0")]
	protected void OCCGAHLHJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDDC0", Offset = "0x3AECBC0", VA = "0x183AEDDC0")]
	protected void BDGOCPGADCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2E64D70", Offset = "0x2E63B70", VA = "0x182E64D70")]
	private static void EMBFJNGFLON<U>(ref List<U> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE0B0", Offset = "0x3AECEB0", VA = "0x183AEE0B0", Slot = "5")]
	public void ELGBPIMHCCH(T KDJGJCHCIKK, bool BAIIBDCELHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDF70", Offset = "0x3AECD70", VA = "0x183AEDF70", Slot = "6")]
	public void DOHHNJJEEIG(T KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE250", Offset = "0x3AED050", VA = "0x183AEE250")]
	public void GJPIAAEOJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KIEAILPLKCH
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DEFJOCBMFPI : global::AAJNGDMNEFI<Action>, KIEAILPLKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8AC0", Offset = "0x5DA78C0", VA = "0x185DA8AC0")]
	public DEFJOCBMFPI(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DA88B0", Offset = "0x5DA76B0", VA = "0x185DA88B0")]
	public void PHAMCHAEBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8780", Offset = "0x5DA7580", VA = "0x185DA8780", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8850", Offset = "0x5DA7650", VA = "0x185DA8850")]
	public static DEFJOCBMFPI PFCLMAKECFN(DEFJOCBMFPI GEEHLNKCFJK, Action KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DA87F0", Offset = "0x5DA75F0", VA = "0x185DA87F0")]
	public static DEFJOCBMFPI KJPIPKKGFFF(DEFJOCBMFPI GEEHLNKCFJK, Action KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JFOLBFPJAJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class HMJKIFGHEAH<T> : global::AAJNGDMNEFI<Action<T>>, global::JFOLBFPJAJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x259F2E0", Offset = "0x259E0E0", VA = "0x18259F2E0")]
	public HMJKIFGHEAH(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x334B010", Offset = "0x3349E10", VA = "0x18334B010")]
	public void PHAMCHAEBGF(T NDJEJACDKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3348C00", Offset = "0x3347A00", VA = "0x183348C00", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x334A690", Offset = "0x3349490", VA = "0x18334A690")]
	public static global::HMJKIFGHEAH<T> PFCLMAKECFN(global::HMJKIFGHEAH<T> GEEHLNKCFJK, Action<T> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x334A5F0", Offset = "0x33493F0", VA = "0x18334A5F0")]
	public static global::HMJKIFGHEAH<T> KJPIPKKGFFF(global::HMJKIFGHEAH<T> GEEHLNKCFJK, Action<T> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EIDBHKKGKFL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class ADBKFHJLPAO<T, U> : global::AAJNGDMNEFI<Action<T, U>>, global::EIDBHKKGKFL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x259F2E0", Offset = "0x259E0E0", VA = "0x18259F2E0")]
	public ADBKFHJLPAO(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6A40", Offset = "0x3AF5840", VA = "0x183AF6A40")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1A70", Offset = "0x3AF0870", VA = "0x183AF1A70", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4920", Offset = "0x3AF3720", VA = "0x183AF4920")]
	public static global::ADBKFHJLPAO<T, U> PFCLMAKECFN(global::ADBKFHJLPAO<T, U> GEEHLNKCFJK, Action<T, U> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4880", Offset = "0x3AF3680", VA = "0x183AF4880")]
	public static global::ADBKFHJLPAO<T, U> KJPIPKKGFFF(global::ADBKFHJLPAO<T, U> GEEHLNKCFJK, Action<T, U> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MIKCFKEKDPD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PHLHGHHFMBE<T, U, V> : global::AAJNGDMNEFI<Action<T, U, V>>, global::MIKCFKEKDPD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x259F2E0", Offset = "0x259E0E0", VA = "0x18259F2E0")]
	public PHLHGHHFMBE(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x307E210", Offset = "0x307D010", VA = "0x18307E210")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x307B010", Offset = "0x3079E10", VA = "0x18307B010", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x307C800", Offset = "0x307B600", VA = "0x18307C800")]
	public static global::PHLHGHHFMBE<T, U, V> PFCLMAKECFN(global::PHLHGHHFMBE<T, U, V> GEEHLNKCFJK, Action<T, U, V> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x307C760", Offset = "0x307B560", VA = "0x18307C760")]
	public static global::PHLHGHHFMBE<T, U, V> KJPIPKKGFFF(global::PHLHGHHFMBE<T, U, V> GEEHLNKCFJK, Action<T, U, V> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PHGJKOBGFIN<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V, W> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V, W> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BMHJOPLONMF<T, U, V, W> : global::AAJNGDMNEFI<Action<T, U, V, W>>, global::PHGJKOBGFIN<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x259F2E0", Offset = "0x259E0E0", VA = "0x18259F2E0")]
	public BMHJOPLONMF(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2D23F60", Offset = "0x2D22D60", VA = "0x182D23F60")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB, W AEPJHDKHAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2D22250", Offset = "0x2D21050", VA = "0x182D22250", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2D234E0", Offset = "0x2D222E0", VA = "0x182D234E0")]
	public static global::BMHJOPLONMF<T, U, V, W> PFCLMAKECFN(global::BMHJOPLONMF<T, U, V, W> GEEHLNKCFJK, Action<T, U, V, W> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2D23440", Offset = "0x2D22240", VA = "0x182D23440")]
	public static global::BMHJOPLONMF<T, U, V, W> KJPIPKKGFFF(global::BMHJOPLONMF<T, U, V, W> GEEHLNKCFJK, Action<T, U, V, W> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface COJAIEDLHLH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V, W, X> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V, W, X> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BJHHMPLNPPJ<T, U, V, W, X> : global::AAJNGDMNEFI<Action<T, U, V, W, X>>, global::COJAIEDLHLH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x259F2E0", Offset = "0x259E0E0", VA = "0x18259F2E0")]
	public BJHHMPLNPPJ(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2D15CB0", Offset = "0x2D14AB0", VA = "0x182D15CB0")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB, W AEPJHDKHAPL, X IODEOJKDCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2D15560", Offset = "0x2D14360", VA = "0x182D15560", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2D15C10", Offset = "0x2D14A10", VA = "0x182D15C10")]
	public static global::BJHHMPLNPPJ<T, U, V, W, X> PFCLMAKECFN(global::BJHHMPLNPPJ<T, U, V, W, X> GEEHLNKCFJK, Action<T, U, V, W, X> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2D15B70", Offset = "0x2D14970", VA = "0x182D15B70")]
	public static global::BJHHMPLNPPJ<T, U, V, W, X> KJPIPKKGFFF(global::BJHHMPLNPPJ<T, U, V, W, X> GEEHLNKCFJK, Action<T, U, V, W, X> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AGEMOAJAPNH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V, W, X, Y> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V, W, X, Y> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class EOJJMHDEFOG<T, U, V, W, X, Y> : global::AAJNGDMNEFI<Action<T, U, V, W, X, Y>>, global::AGEMOAJAPNH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x259F2E0", Offset = "0x259E0E0", VA = "0x18259F2E0")]
	public EOJJMHDEFOG(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4496C80", Offset = "0x4495A80", VA = "0x184496C80")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB, W AEPJHDKHAPL, X IODEOJKDCNL, Y FNMMGECGLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4495EC0", Offset = "0x4494CC0", VA = "0x184495EC0", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4496610", Offset = "0x4495410", VA = "0x184496610")]
	public static global::EOJJMHDEFOG<T, U, V, W, X, Y> PFCLMAKECFN(global::EOJJMHDEFOG<T, U, V, W, X, Y> GEEHLNKCFJK, Action<T, U, V, W, X, Y> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4496570", Offset = "0x4495370", VA = "0x184496570")]
	public static global::EOJJMHDEFOG<T, U, V, W, X, Y> KJPIPKKGFFF(global::EOJJMHDEFOG<T, U, V, W, X, Y> GEEHLNKCFJK, Action<T, U, V, W, X, Y> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JKODBIAOFNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct MPBBAMMGGJL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::JKODBIAOFNH<T> KCKDNFEHHHG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T AMPEKKPGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x37889D0", Offset = "0x37877D0", VA = "0x1837889D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x37889A0", Offset = "0x37877A0", VA = "0x1837889A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6507B0", Offset = "0x64F5B0", VA = "0x1806507B0")]
		public MPBBAMMGGJL(global::JKODBIAOFNH<T> KCKDNFEHHHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JCLCIJJHKHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<MPBBAMMGGJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::JKODBIAOFNH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3112FF0", Offset = "0x3111DF0", VA = "0x183112FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x24E9460", Offset = "0x24E8260", VA = "0x1824E9460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ACLEOKAPDDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<MPBBAMMGGJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::JKODBIAOFNH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF18C0", Offset = "0x3AF06C0", VA = "0x183AF18C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x24E9460", Offset = "0x24E8260", VA = "0x1824E9460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim LDECEDOGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T KNKGBNJOHIA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int LENECOBLFOM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3F4E990", Offset = "0x3F4D790", VA = "0x183F4E990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3F4EFD0", Offset = "0x3F4DDD0", VA = "0x183F4EFD0")]
	public JKODBIAOFNH(in T KNKGBNJOHIA, int EJNAOLLIBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F070", Offset = "0x3F4DE70", VA = "0x183F4F070")]
	public JKODBIAOFNH(in T KNKGBNJOHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3F4EF90", Offset = "0x3F4DD90", VA = "0x183F4EF90")]
	public MPBBAMMGGJL PEHHINIJIDF()
	{
		return default(MPBBAMMGGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3F4EF50", Offset = "0x3F4DD50", VA = "0x183F4EF50")]
	public MPBBAMMGGJL PEHHINIJIDF(CancellationToken ADCKNELPFOJ)
	{
		return default(MPBBAMMGGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3F4EDF0", Offset = "0x3F4DBF0", VA = "0x183F4EDF0")]
	[AsyncStateMachine(typeof(global::JKODBIAOFNH<>.JCLCIJJHKHL))]
	public Task<MPBBAMMGGJL> EPNNHKILAAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3F4EB10", Offset = "0x3F4D910", VA = "0x183F4EB10")]
	[AsyncStateMachine(typeof(global::JKODBIAOFNH<>.ACLEOKAPDDH))]
	public Task<MPBBAMMGGJL> EPNNHKILAAI(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FJDOEKHBBJO
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA200", Offset = "0x5DA9000", VA = "0x185DAA200")]
	public static global::JKODBIAOFNH<OIGDPEFJPLN> KCNAIILPDFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA260", Offset = "0x5DA9060", VA = "0x185DAA260")]
	public static global::JKODBIAOFNH<OIGDPEFJPLN> KCNAIILPDFM(int EJNAOLLIBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x26FD490", Offset = "0x26FC290", VA = "0x1826FD490")]
	public static global::JKODBIAOFNH<T> KCNAIILPDFM<T>(in T KNKGBNJOHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFD60", Offset = "0x2DAEB60", VA = "0x182DAFD60")]
	public static global::JKODBIAOFNH<T> KCNAIILPDFM<T>(in T KNKGBNJOHIA, int EJNAOLLIBEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IDPLKMIMIEO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> APBPDDDDJFB(TRequest BOBJBDACGIL, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ANNOLJLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class DAAHDICHHED
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float NKLPCEHHKPI = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan PIIOLOFIBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int BPFIGBOCLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ANNOLJLMCLP PINOPIIICFC;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly DAAHDICHHED BLGCIDCPBFE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float HODABNPKEAF
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3143220", Offset = "0x3142020", VA = "0x183143220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan NILMDNNPDDB
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3143290", Offset = "0x3142090", VA = "0x183143290")]
		public DAAHDICHHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct AGPLGNKGGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest BOBJBDACGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken ADCKNELPFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> NFDBDOFNPHG;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3728700", Offset = "0x3727500", VA = "0x183728700")]
		public AGPLGNKGGGN(TRequest BOBJBDACGIL, TaskCompletionSource<TResult> NFDBDOFNPHG, CancellationToken ADCKNELPFOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EOOJKNBBGOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public EOOJKNBBGOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x24F68D0", Offset = "0x24F56D0", VA = "0x1824F68D0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct OPFBAOLAGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::IDPLKMIMIEO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x38424E0", Offset = "0x38412E0", VA = "0x1838424E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ALJGHPLIHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::IDPLKMIMIEO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AGPLGNKGGGN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB7D0", Offset = "0x3FEA5D0", VA = "0x183FEB7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CNHFOIMHBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<AGPLGNKGGGN> AEOGDMLEGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DAAHDICHHED ELAGDDFNKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly APBPDDDDJFB COPKCKLCJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task KLIDLKOBEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HEGMHGNAIAM;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F34910", Offset = "0x1F33710", VA = "0x181F34910")]
	public IDPLKMIMIEO(APBPDDDDJFB COPKCKLCJOJ, [Optional] DAAHDICHHED ELAGDDFNKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1F338E0", Offset = "0x1F326E0", VA = "0x181F338E0")]
	public Task<TResult> LPOANLJOFCG(TRequest BOBJBDACGIL, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1F33D80", Offset = "0x1F32B80", VA = "0x181F33D80")]
	private void NAIOBOAAPKP(AGPLGNKGGGN HNEAAKKCNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1F34050", Offset = "0x1F32E50", VA = "0x181F34050")]
	[AsyncStateMachine(typeof(global::IDPLKMIMIEO<, >.OPFBAOLAGJM))]
	private Task OIBKFEAINMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1F32F30", Offset = "0x1F31D30", VA = "0x181F32F30")]
	private AGPLGNKGGGN DMODAANMPLG()
	{
		return default(AGPLGNKGGGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1F34370", Offset = "0x1F33170", VA = "0x181F34370")]
	[AsyncStateMachine(typeof(global::IDPLKMIMIEO<, >.ALJGHPLIHFA))]
	private Task PNPDEBLMJMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1F32D90", Offset = "0x1F31B90", VA = "0x181F32D90")]
	private void DAGDILFNNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1F33630", Offset = "0x1F32430", VA = "0x181F33630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NGJAKFONHKP<TKey, TVal> : global::HNFMCDMACCI<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int LBIBIHNBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> JOBKLDIACKJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int ICJJKCDFKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAEE0", Offset = "0x2BD9CE0", VA = "0x182BDAEE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int HIJNNAJCMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAF10", Offset = "0x2BD9D10", VA = "0x182BDAF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9A0", Offset = "0x2BD97A0", VA = "0x182BDA9A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAF40", Offset = "0x2BD9D40", VA = "0x182BDAF40")]
	public NGJAKFONHKP(int BPGPHKEJPBF, [Optional] HINNMIKLHLE FAHNKMAOADD, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAE40", Offset = "0x2BD9C40", VA = "0x182BDAE40")]
	public void KNLDNJIAKNN(TKey BIMCDHOFDCP, TVal GKFICKKHACC, bool PPEOOEPAJLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDADC0", Offset = "0x2BD9BC0", VA = "0x182BDADC0")]
	public bool JNFPHJDADNB(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAAA0", Offset = "0x2BD98A0", VA = "0x182BDAAA0", Slot = "6")]
	public override bool GINCMLLPDOD(TKey NDKPGBEDMFK, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDABB0", Offset = "0x2BD99B0", VA = "0x182BDABB0")]
	public bool HMLGCJCHABO(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA890", Offset = "0x2BD9690", VA = "0x182BDA890")]
	public bool BMGIKLKNBCN(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAB40", Offset = "0x2BD9940", VA = "0x182BDAB40", Slot = "7")]
	public override void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAA00", Offset = "0x2BD9800", VA = "0x182BDAA00")]
	private bool FOLKGIMCOJK(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class HNFMCDMACCI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int HINNMIKLHLE(TKey BIMCDHOFDCP, TVal GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CCGFDCNDGKI
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey POMHLJMDJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x694580", Offset = "0x693380", VA = "0x180694580")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal AMPEKKPGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PEPLKIOHEKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x65F390", Offset = "0x65E190", VA = "0x18065F390")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x65F4F0", Offset = "0x65E2F0", VA = "0x18065F4F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime BJGFBGGDIOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xB01660", Offset = "0xB00460", VA = "0x180B01660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x414AFA0", Offset = "0x4149DA0", VA = "0x18414AFA0")]
		public CCGFDCNDGKI(TKey BIMCDHOFDCP, TVal FIHIOAOIPNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int KJOFOKKOPDC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<CCGFDCNDGKI>> NKCNGKBBEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<CCGFDCNDGKI> GHNBGCKBBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly HINNMIKLHLE FAHNKMAOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan JGMEAFDBPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly KOCLMPDDPHJ LGKDHHCPCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int KLBMGCBECHA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x670E40", Offset = "0x66FC40", VA = "0x180670E40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool FPBCJKKJLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x334F210", Offset = "0x334E010", VA = "0x18334F210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int ICJJKCDFKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x657530", Offset = "0x656330", VA = "0x180657530", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int CGKKILDEEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x251AB30", Offset = "0x2519930", VA = "0x18251AB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1F368E0", Offset = "0x1F356E0", VA = "0x181F368E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GFDLDMBAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x334D9C0", Offset = "0x334C7C0", VA = "0x18334D9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x334D390", Offset = "0x334C190", VA = "0x18334D390")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x334DC10", Offset = "0x334CA10", VA = "0x18334DC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3350200", Offset = "0x334F000", VA = "0x183350200")]
	public HNFMCDMACCI(int BPGPHKEJPBF, [Optional] HINNMIKLHLE FAHNKMAOADD, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x334F5C0", Offset = "0x334E3C0", VA = "0x18334F5C0")]
	public HNFMCDMACCI(TimeSpan JGMEAFDBPNA, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA, [Optional] KOCLMPDDPHJ LGKDHHCPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x334FF30", Offset = "0x334ED30", VA = "0x18334FF30")]
	public HNFMCDMACCI(int BPGPHKEJPBF, TimeSpan JGMEAFDBPNA, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA, [Optional] KOCLMPDDPHJ LGKDHHCPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x334F610", Offset = "0x334E410", VA = "0x18334F610")]
	public HNFMCDMACCI(int BPGPHKEJPBF, HINNMIKLHLE FAHNKMAOADD, TimeSpan JGMEAFDBPNA, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA, [Optional] KOCLMPDDPHJ LGKDHHCPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x334EA00", Offset = "0x334D800", VA = "0x18334EA00")]
	public void KFDHJHJCICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x334F360", Offset = "0x334E160", VA = "0x18334F360")]
	public void NMFBOCJEJOB(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x334C620", Offset = "0x334B420", VA = "0x18334C620")]
	public bool DOHHNJJEEIG(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x334DD00", Offset = "0x334CB00", VA = "0x18334DD00")]
	private TVal HMFHOBMDMGG(TKey NDKPGBEDMFK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x334D7E0", Offset = "0x334C5E0", VA = "0x18334D7E0", Slot = "6")]
	public virtual bool GINCMLLPDOD(TKey NDKPGBEDMFK, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x334D950", Offset = "0x334C750", VA = "0x18334D950", Slot = "7")]
	public virtual void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x334C560", Offset = "0x334B360", VA = "0x18334C560")]
	private bool AHBCNDBJCHO(CCGFDCNDGKI AGGFHDNDMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x334D110", Offset = "0x334BF10", VA = "0x18334D110")]
	private void DONJBBMKIAI(LinkedListNode<CCGFDCNDGKI> LDBBPJCJGCC, TVal IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x334E520", Offset = "0x334D320", VA = "0x18334E520")]
	private void KBFHBLDHILI(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x334EB80", Offset = "0x334D980", VA = "0x18334EB80")]
	private void KJNMJELFCIF(CCGFDCNDGKI AGGFHDNDMJM, TVal IOOLGMDKBMN, int JLCKPDBPCEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class MPFBCGKBHBN<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> LENGKEKMOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> NHPLLLGAGMB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x24F68D0", Offset = "0x24F56D0", VA = "0x1824F68D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F324D0", Offset = "0x1F312D0", VA = "0x181F324D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3789410", Offset = "0x3788210", VA = "0x183789410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3348550", Offset = "0x3347350", VA = "0x183348550", Slot = "11")]
	public void Add(T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3788FE0", Offset = "0x3787DE0", VA = "0x183788FE0")]
	public bool NKDBGPNCFBD(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3789220", Offset = "0x3788020", VA = "0x183789220", Slot = "15")]
	public bool Remove(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3788CC0", Offset = "0x3787AC0", VA = "0x183788CC0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x306CDD0", Offset = "0x306BBD0", VA = "0x18306CDD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3788A90", Offset = "0x3787890", VA = "0x183788A90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F39BB0", Offset = "0x1F389B0", VA = "0x181F39BB0", Slot = "13")]
	public bool Contains(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3788AF0", Offset = "0x37878F0", VA = "0x183788AF0", Slot = "14")]
	public void CopyTo(T[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3788D70", Offset = "0x3787B70", VA = "0x183788D70", Slot = "6")]
	public int IndexOf(T MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3788E70", Offset = "0x3787C70", VA = "0x183788E70", Slot = "7")]
	public void Insert(int BNNEENLPEFO, T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3789080", Offset = "0x3787E80", VA = "0x183789080", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3788BF0", Offset = "0x37879F0", VA = "0x183788BF0")]
	public void GFIDMAHEEHM(Predicate<T> AHMJOHFIKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3788D40", Offset = "0x3787B40", VA = "0x183788D40")]
	public void HAACIBKFDHB(Comparison<T> HDKEONKBBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3789330", Offset = "0x3788130", VA = "0x183789330")]
	public MPFBCGKBHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PLFOBMNGGCJ
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF720", Offset = "0x5DAE520", VA = "0x185DAF720")]
	public static Vector3 NPPGHBPBDJM(this GameObject ENOCMPCACJI, float DHMCCHJCPFO)
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
			[Cpp2IlInjected.Address(RVA = "0x8FE630", Offset = "0x8FD430", VA = "0x1808FE630")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB14A0", Offset = "0x5DB02A0", VA = "0x185DB14A0")]
		public SerializedGuid(in Guid LNKDDEDGKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1410", Offset = "0x5DB0210", VA = "0x185DB1410")]
		public static SerializedGuid PLOBEEKPPCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0FF0", Offset = "0x5DAFDF0", VA = "0x185DB0FF0")]
		public static SerializedGuid DJIECFDHDCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB12B0", Offset = "0x5DB00B0", VA = "0x185DB12B0")]
		public bool ONEAKNMADMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB13E0", Offset = "0x5DB01E0", VA = "0x185DB13E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1340", Offset = "0x5DB0140", VA = "0x185DB1340", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1220", Offset = "0x5DB0020", VA = "0x185DB1220")]
		public bool OKMKGFFNCCL(in Guid LNKDDEDGKJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1080", Offset = "0x5DAFE80", VA = "0x185DB1080", Slot = "7")]
		public bool Equals(SerializedGuid MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1130", Offset = "0x5DAFF30", VA = "0x185DB1130", Slot = "0")]
		public override bool Equals(object KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1210", Offset = "0x5DB0010", VA = "0x185DB1210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0FC0", Offset = "0x5DAFDC0", VA = "0x185DB0FC0", Slot = "6")]
		public int CompareTo(SerializedGuid MCLIMJFDMCF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AAEINDPKIFD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type PIBELKLPADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string AMPOMAILCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool NKCCAFCLNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool DDGMFOFAPMH;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8080", Offset = "0x5DA6E80", VA = "0x185DA8080")]
	public AAEINDPKIFD(Type DBBHNONBNID, string OJKGNIIJCNE, bool ONCCHDOCPOO = false, bool OEJEHIOFJBC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EPDEBKCILFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HLPKIAGACKB<T> : EPDEBKCILFH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GCNEFACGJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string BECCPFDHFDD
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
	global::HLPKIAGACKB<T> LCHKPHKBICE(Action<T> APJILEEAIPO);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HLPKIAGACKB<T> AHJLIDIGLME(Action<T> APJILEEAIPO);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HLPKIAGACKB<T> NMOEBBCIDMO(Action<T, T> CGBKJOKFDLA);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HLPKIAGACKB<T> BNAOKHIGPOK(Action<T, T> CGBKJOKFDLA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HLPKIAGACKB<T> KCMGHILJOKI(Action<string> KEONGEFNJKM);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HLPKIAGACKB<T> IAJNBJDAMAG(Action<string> KEONGEFNJKM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NFHJCFBKDMM<T> : global::HLPKIAGACKB<T>, EPDEBKCILFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::ADBKFHJLPAO<T, T> OGMNGABPLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::HMJKIFGHEAH<T> GOFCFCPNJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::HMJKIFGHEAH<string> KDILMHKLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string OMKDGOMBDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BMBFIGGJLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool ONDMGDKDGCN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x259F6C0", Offset = "0x259E4C0", VA = "0x18259F6C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GCNEFACGJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x652C20", Offset = "0x651A20", VA = "0x180652C20", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string BECCPFDHFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x23EFDC0", Offset = "0x23EEBC0", VA = "0x1823EFDC0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9450", Offset = "0x2BD8250", VA = "0x182BD9450")]
	private void EPMCBJFFJMB(T OICHLBNIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9740", Offset = "0x2BD8540", VA = "0x182BD9740")]
	private void MGGBGOADNIO(string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD94F0", Offset = "0x2BD82F0", VA = "0x182BD94F0")]
	public void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD97F0", Offset = "0x2BD85F0", VA = "0x182BD97F0", Slot = "6")]
	public global::HLPKIAGACKB<T> NMOEBBCIDMO(Action<T, T> CGBKJOKFDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9400", Offset = "0x2BD8200", VA = "0x182BD9400", Slot = "7")]
	public global::HLPKIAGACKB<T> BNAOKHIGPOK(Action<T, T> CGBKJOKFDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BD96B0", Offset = "0x2BD84B0", VA = "0x182BD96B0", Slot = "4")]
	public global::HLPKIAGACKB<T> LCHKPHKBICE(Action<T> CGBKJOKFDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD93B0", Offset = "0x2BD81B0", VA = "0x182BD93B0", Slot = "5")]
	public global::HLPKIAGACKB<T> AHJLIDIGLME(Action<T> APJILEEAIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9610", Offset = "0x2BD8410", VA = "0x182BD9610", Slot = "8")]
	public global::HLPKIAGACKB<T> KCMGHILJOKI(Action<string> KEONGEFNJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BD95A0", Offset = "0x2BD83A0", VA = "0x182BD95A0", Slot = "9")]
	public global::HLPKIAGACKB<T> IAJNBJDAMAG(Action<string> KEONGEFNJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9840", Offset = "0x2BD8640", VA = "0x182BD9840")]
	public NFHJCFBKDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MCKAEHMCHLC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class LIGHKAIMJPN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::HLPKIAGACKB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::ENFBMJFPLIK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public LIGHKAIMJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF000", Offset = "0x2BBDE00", VA = "0x182BBF000")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B32CF0", Offset = "0x2B31AF0", VA = "0x182B32CF0")]
	public static global::CGDFFALNLAC<T> DKHIEHMEGIE<T>(this global::HLPKIAGACKB<T> KKFMNOBFKCC, Action<T> PKPGAEOFIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EEKDJEFEHJA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct AFKKOELPLLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long JFMAOBFPHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long DIIAALKMPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int BCNMJCJODAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int KDAIDJDFBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool EMJFEHIDJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string LNICNJEJKPL;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3728560", Offset = "0x3727360", VA = "0x183728560")]
		public AFKKOELPLLE(long JFMAOBFPHPH, int BCNMJCJODAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3728530", Offset = "0x3727330", VA = "0x183728530")]
		public AFKKOELPLLE(long JFMAOBFPHPH, long DIIAALKMPMH, int BCNMJCJODAJ, int KDAIDJDFBLE, bool EMJFEHIDJDO, string LNICNJEJKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x37283E0", Offset = "0x37271E0", VA = "0x1837283E0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FIFPJEAJENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3728450", Offset = "0x3727250", VA = "0x183728450")]
		public int GGLKJLDHAFC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3728350", Offset = "0x3727150", VA = "0x183728350")]
		public int DAIDGLNKPEP(int LEPCMIBLCHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3728370", Offset = "0x3727170", VA = "0x183728370")]
		public double ELJMDHMOHED()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x37284A0", Offset = "0x37272A0", VA = "0x1837284A0")]
		public AFKKOELPLLE PKBCPNGIJDI(long DIIAALKMPMH, int KDAIDJDFBLE)
		{
			return default(AFKKOELPLLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class CEJMOEANPLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey POMHLJMDJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::EEKDJEFEHJA<TKey> BIEDEPNABLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<CEJMOEANPLC> BBEJKGAFJJM;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string EDOMCDCCLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F2E520", Offset = "0x1F2D320", VA = "0x181F2E520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F2E790", Offset = "0x1F2D590", VA = "0x181F2E790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<CEJMOEANPLC> AIMCOHFHBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x33EBAF0", Offset = "0x33EA8F0", VA = "0x1833EBAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public AFKKOELPLLE HOIHHEGBLMK
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x9ABBF0", Offset = "0x9AA9F0", VA = "0x1809ABBF0")]
			[CompilerGenerated]
			get
			{
				return default(AFKKOELPLLE);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x33EBBF0", Offset = "0x33EA9F0", VA = "0x1833EBBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x33EBD30", Offset = "0x33EAB30", VA = "0x1833EBD30")]
		internal CEJMOEANPLC(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, TKey BIMCDHOFDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x33EBC20", Offset = "0x33EAA20", VA = "0x1833EBC20")]
		public CEJMOEANPLC PINCFFKBOGP(TKey BIMCDHOFDCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x33EBB10", Offset = "0x33EA910", VA = "0x1833EBB10")]
		public void HINCMHIALJF(TKey BIMCDHOFDCP, Action<CEJMOEANPLC> KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x38F2300", Offset = "0x38F1100", VA = "0x1838F2300")]
		public T HINCMHIALJF<T>(TKey BIMCDHOFDCP, Func<CEJMOEANPLC, T> FEADACHODCB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x38F2190", Offset = "0x38F0F90", VA = "0x1838F2190")]
		[AsyncStateMachine(typeof(NJFLIINNCNO))]
		public Task<T> BIHJCPJLJKO<T>(TKey BIMCDHOFDCP, Func<CEJMOEANPLC, Task<T>> FEADACHODCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x33EB940", Offset = "0x33EA740", VA = "0x1833EB940", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FLJIJPGBNJF : IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, AFKKOELPLLE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::EEKDJEFEHJA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, AFKKOELPLLE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, AFKKOELPLLE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x31195D0", Offset = "0x31183D0", VA = "0x1831195D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AFKKOELPLLE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x3397760", Offset = "0x3396560", VA = "0x183397760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x31199A0", Offset = "0x31187A0", VA = "0x1831199A0")]
		[DebuggerHidden]
		public FLJIJPGBNJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x28BCD10", Offset = "0x28BBB10", VA = "0x1828BCD10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x33973B0", Offset = "0x33961B0", VA = "0x1833973B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x33977C0", Offset = "0x33965C0", VA = "0x1833977C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3397720", Offset = "0x3396520", VA = "0x183397720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3397660", Offset = "0x3396460", VA = "0x183397660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x251CC50", Offset = "0x251BA50", VA = "0x18251CC50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ADJOBGLNIFE : IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, AFKKOELPLLE timerEntry) <>2__current;

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
		private CEJMOEANPLC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CEJMOEANPLC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::EEKDJEFEHJA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<CEJMOEANPLC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, AFKKOELPLLE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, AFKKOELPLLE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x31195D0", Offset = "0x31183D0", VA = "0x1831195D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AFKKOELPLLE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x37266C0", Offset = "0x37254C0", VA = "0x1837266C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x31199A0", Offset = "0x31187A0", VA = "0x1831199A0")]
		[DebuggerHidden]
		public ADJOBGLNIFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3726720", Offset = "0x3725520", VA = "0x183726720", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3725FD0", Offset = "0x3724DD0", VA = "0x183725FD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x37267C0", Offset = "0x37255C0", VA = "0x1837267C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3726820", Offset = "0x3725620", VA = "0x183726820")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3726680", Offset = "0x3725480", VA = "0x183726680", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3726570", Offset = "0x3725370", VA = "0x183726570", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3726650", Offset = "0x3725450", VA = "0x183726650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, AFKKOELPLLE> LIDNPCOFMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, AFKKOELPLLE> ONOJDKBGJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::EEKDJEFEHJA<TKey>> FJOBJCMMCCC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string BJMBMGKNCAB = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly CEJMOEANPLC HACLDCEMHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool LFPHADEPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int ELGCBOCKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch LGEMGNOLLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int GGLDEPCDCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string ODLAOAEFNCA;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public CEJMOEANPLC DFLIICFHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string EDOMCDCCLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x656280", Offset = "0x655080", VA = "0x180656280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x330F160", Offset = "0x330DF60", VA = "0x18330F160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long NJGAOAMDFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x330F350", Offset = "0x330E150", VA = "0x18330F350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int HDDDBECGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x330F1C0", Offset = "0x330DFC0", VA = "0x18330F1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x330F430", Offset = "0x330E230", VA = "0x18330F430")]
	public EEKDJEFEHJA(TKey LJKEMPANMNC, [Optional] int? BCNMJCJODAJ, [Optional][CanBeNull] Stopwatch LGEMGNOLLDB, [Optional] Action<TKey, AFKKOELPLLE> LIDNPCOFMBE, [Optional] Action<TKey, AFKKOELPLLE> ONOJDKBGJMD, [Optional] Action<global::EEKDJEFEHJA<TKey>> FJOBJCMMCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x330F0D0", Offset = "0x330DED0", VA = "0x18330F0D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x330F3F0", Offset = "0x330E1F0", VA = "0x18330F3F0")]
	public void JJDCNDIGJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x330F410", Offset = "0x330E210", VA = "0x18330F410")]
	public void MIPEJPDCOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x330F2C0", Offset = "0x330E0C0", VA = "0x18330F2C0")]
	[IteratorStateMachine(typeof(global::EEKDJEFEHJA<>.FLJIJPGBNJF))]
	public IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)> HLCIFFBNHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x330F1F0", Offset = "0x330DFF0", VA = "0x18330F1F0")]
	[IteratorStateMachine(typeof(global::EEKDJEFEHJA<>.ADJOBGLNIFE))]
	private IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)> HLCIFFBNHDP(List<TKey> GEMBNOGNCGO, CEJMOEANPLC PKKECFJJEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x330F370", Offset = "0x330E170", VA = "0x18330F370")]
	private (long, int) IJCBKGKDHIN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class MFGMLGIGCMI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	protected MFGMLGIGCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class PJKKKKJBBIC<TKey> : global::MFGMLGIGCMI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string CBCKINHABEP(TKey BIMCDHOFDCP);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3081DA0", Offset = "0x3080BA0", VA = "0x183081DA0")]
	protected string ILPHECKPLNO(double GEMLHHDBOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3081D40", Offset = "0x3080B40", VA = "0x183081D40")]
	protected string IJEPAFPMOMB(int OCBBCADCKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3081D00", Offset = "0x3080B00", VA = "0x183081D00")]
	private static string HHFMNCGGAGG(TKey BIMCDHOFDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3081B20", Offset = "0x3080920", VA = "0x183081B20", Slot = "4")]
	public override string BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3081BD0", Offset = "0x30809D0", VA = "0x183081BD0")]
	public string BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, [NotNull] CBCKINHABEP MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PPDNKOEOMEE(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, [NotNull] CBCKINHABEP MNIJGABINDF);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x28A5CD0", Offset = "0x28A4AD0", VA = "0x1828A5CD0")]
	protected PJKKKKJBBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KEPKKLAJFKM<TKey> : global::MFGMLGIGCMI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string LIKCLBMJCHH(TKey BIMCDHOFDCP);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int LADMIBOGPME = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string BGNEMLBOLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double FAJOBHPNIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool JFKACFMDECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int GLJKOHGOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> GPDHFDDCHON;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x396B9E0", Offset = "0x396A7E0", VA = "0x18396B9E0")]
	private static string HHFMNCGGAGG(TKey BIMCDHOFDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x396BB00", Offset = "0x396A900", VA = "0x18396BB00")]
	public KEPKKLAJFKM(string BGNEMLBOLAB = "F2", double FAJOBHPNIKI = double.MaxValue, bool JFKACFMDECE = false, int GLJKOHGOCHM = int.MaxValue, [Optional] ISet<string> GPDHFDDCHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x396B0C0", Offset = "0x3969EC0", VA = "0x18396B0C0", Slot = "4")]
	public override Dictionary<string, string> BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x396BA20", Offset = "0x396A820", VA = "0x18396BA20")]
	private bool MAGPBAKPDGN(string ACPFEFIPJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x396B170", Offset = "0x3969F70", VA = "0x18396B170")]
	public Dictionary<string, string> BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, LIKCLBMJCHH MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x396B830", Offset = "0x396A630", VA = "0x18396B830")]
	private string GFEBKACMDCP(StringBuilder PBEEKLJOEAC, List<TKey> FJCINEEONFP, LIKCLBMJCHH MNIJGABINDF, bool IHGJOFHBGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x396B6B0", Offset = "0x396A4B0", VA = "0x18396B6B0")]
	private static void DLHPPDPLJBH(StringBuilder HPBJCCBAAHB, string CBOKKIBGDAL, bool MDCIOMFPMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MMJMKLMDFLN<TKey> : global::PJKKKKJBBIC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct HIHOFIMKADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CBCKINHABEP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::MMJMKLMDFLN<TKey> EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int NJODMEFNFPB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] MBAPJMCCEAI;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x37839E0", Offset = "0x37827E0", VA = "0x1837839E0")]
	private MMJMKLMDFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x37829F0", Offset = "0x37817F0", VA = "0x1837829F0", Slot = "5")]
	protected override string PPDNKOEOMEE(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, CBCKINHABEP MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3782900", Offset = "0x3781700", VA = "0x183782900")]
	[CompilerGenerated]
	internal static string JKCOFILFDLL(string OFEIHLGAINA, TKey BIMCDHOFDCP, ref HIHOFIMKADJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AHCFLELADBF<TKey> : global::PJKKKKJBBIC<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class AFCLGCEFNNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CBCKINHABEP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public AFCLGCEFNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x251B160", Offset = "0x2519F60", VA = "0x18251B160")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC310", Offset = "0x3FDB110", VA = "0x183FDC310", Slot = "5")]
	protected override string PPDNKOEOMEE(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, CBCKINHABEP MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x33450F0", Offset = "0x3343EF0", VA = "0x1833450F0")]
	public AHCFLELADBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class CGANNOOEDMA : global::EEKDJEFEHJA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AKNAFFLMDCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<CGANNOOEDMA> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public AKNAFFLMDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA80F0", Offset = "0x5DA6EF0", VA = "0x185DA80F0")]
		internal void <Wrap>b__0(global::EEKDJEFEHJA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5DA85A0", Offset = "0x5DA73A0", VA = "0x185DA85A0")]
	public CGANNOOEDMA([Optional] string AHHMFMOCNMM, [Optional] int? BCNMJCJODAJ, [Optional] Stopwatch LGEMGNOLLDB, [Optional] Action<string, AFKKOELPLLE> LIDNPCOFMBE, [Optional] Action<string, AFKKOELPLLE> ONOJDKBGJMD, [Optional] Action<CGANNOOEDMA> FJOBJCMMCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5DA84C0", Offset = "0x5DA72C0", VA = "0x185DA84C0")]
	private static Action<global::EEKDJEFEHJA<string>> HINCMHIALJF(Action<CGANNOOEDMA> PKPGAEOFIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class KOCLMPDDPHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class IKHDEFINEEK : KOCLMPDDPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static KOCLMPDDPHJ EBMHMHOHCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC3A0", Offset = "0x5DAB1A0", VA = "0x185DAC3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime BGPNAFIIPLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC400", Offset = "0x5DAB200", VA = "0x185DAC400", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float LNGCFOHPNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5DAC390", Offset = "0x5DAB190", VA = "0x185DAC390", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC4F0", Offset = "0x5DAB2F0", VA = "0x185DAC4F0")]
		public IKHDEFINEEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static KOCLMPDDPHJ HKOGDEGDJEF;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static KOCLMPDDPHJ BLGCIDCPBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEBD0", Offset = "0x5DAD9D0", VA = "0x185DAEBD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime BGPNAFIIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float LNGCFOHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	protected KOCLMPDDPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class DIHGOMFMIOP : global::NAKJFFBHKOD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8B20", Offset = "0x5DA7920", VA = "0x185DA8B20")]
	public DIHGOMFMIOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NAKJFFBHKOD<T> : global::BHJADGHBKAP<T>, HIPDNCIOIAA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task FNHEJAHJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1A89F80", Offset = "0x1A88D80", VA = "0x181A89F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private FKDPJJAEIFK FINLACKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x23EFB90", Offset = "0x23EE990", VA = "0x1823EFB90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2AED850", Offset = "0x2AEC650", VA = "0x182AED850")]
	public NAKJFFBHKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EJCGHCAALCG : global::BKJCAMBKCFF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8E00", Offset = "0x5DA7C00", VA = "0x185DA8E00")]
	public EJCGHCAALCG(Exception AENGIJLJHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BKJCAMBKCFF<T> : global::BHJADGHBKAP<T>, HIPDNCIOIAA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task FNHEJAHJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1A89F80", Offset = "0x1A88D80", VA = "0x181A89F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private FKDPJJAEIFK FINLACKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x23EFB90", Offset = "0x23EE990", VA = "0x1823EFB90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A760", Offset = "0x2D19560", VA = "0x182D1A760")]
	public BKJCAMBKCFF(Exception AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HIPDNCIOIAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	FKDPJJAEIFK CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface BHJADGHBKAP<T> : HIPDNCIOIAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class AIFEKKEPJGB<TTask, T> : global::BHJADGHBKAP<T>, HIPDNCIOIAA, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class AHLCPMNJNML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::AIFEKKEPJGB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public AHLCPMNJNML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool NIIEOLOAJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> BCLOPCAMFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource DLBKDDIPECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool LFPHADEPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext CLMFMIPNPDD;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task FNHEJAHJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private FKDPJJAEIFK FINLACKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AB40", Offset = "0x1F39940", VA = "0x181F3AB40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE8F0", Offset = "0x3FDD6F0", VA = "0x183FDE8F0")]
	static AIFEKKEPJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3FDEC30", Offset = "0x3FDDA30", VA = "0x183FDEC30")]
	protected AIFEKKEPJGB(TTask BCLOPCAMFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE3E0", Offset = "0x3FDD1E0", VA = "0x183FDE3E0", Slot = "1")]
	~AIFEKKEPJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE3B0", Offset = "0x3FDD1B0", VA = "0x183FDE3B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE610", Offset = "0x3FDD410", VA = "0x183FDE610")]
	private void OJNONIJIFNF(bool HIKJHPFEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BABPEFFEKOC(TTask OAEANEPNMHM);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FAJJFHANBFD();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE450", Offset = "0x3FDD250", VA = "0x183FDE450")]
	[CompilerGenerated]
	private void IANABKDOPPE(object BHOMHPIPDNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface NLEJNCDHDND
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PJPENJPCMDL HAKGKONOGND;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GHGOLJAPJCC : NLEJNCDHDND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct GIPHLOHNKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float BELAGFODGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float EEPGELFFCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool ILPKKNHIECH;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float PEPLKIOHEKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5DAAF00", Offset = "0x5DA9D00", VA = "0x185DAAF00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB090", Offset = "0x5DA9E90", VA = "0x185DAB090")]
		public GIPHLOHNKNC(float HOKMFDPKLJA, float OCMAALMMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAF10", Offset = "0x5DA9D10", VA = "0x185DAAF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class OAOPANMNLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public GHGOLJAPJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OAOPANMNLFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int BPGPHKEJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int NPADLOOMEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly NLEJNCDHDND[] FIENHBCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PJPENJPCMDL[] KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly GIPHLOHNKNC[] EFPKDFOADBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GIPHLOHNKNC PNDAANGOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly KLJLIGBHMNL FDGGFENFOHE;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GIPHLOHNKNC HIPOHFHALJN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xDA7C60", Offset = "0xDA6A60", VA = "0x180DA7C60")]
		get
		{
			return default(GIPHLOHNKNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5DAACA0", Offset = "0x5DA9AA0", VA = "0x185DAACA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PJPENJPCMDL HAKGKONOGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA4D0", Offset = "0x5DA92D0", VA = "0x185DAA4D0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5DAACC0", Offset = "0x5DA9AC0", VA = "0x185DAACC0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAD80", Offset = "0x5DA9B80", VA = "0x185DAAD80")]
	public GHGOLJAPJCC(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA720", Offset = "0x5DA9520", VA = "0x185DAA720")]
	public KLJLIGBHMNL FNBADDAMBPP(GIPHLOHNKNC HIPOJJABCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA7B0", Offset = "0x5DA95B0", VA = "0x185DAA7B0")]
	public void JJJIJHPALPP(NLEJNCDHDND MAFPLPHJMMP, [Optional] GIPHLOHNKNC OFFGIOHNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAC50", Offset = "0x5DA9A50", VA = "0x185DAAC50")]
	internal int NJHNFHMHPKP(NLEJNCDHDND BKKKBIDKIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAC00", Offset = "0x5DA9A00", VA = "0x185DAAC00")]
	internal GIPHLOHNKNC KNIMJDOFMAG(int BNNEENLPEFO)
	{
		return default(GIPHLOHNKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA590", Offset = "0x5DA9390", VA = "0x185DAA590", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void PJPENJPCMDL(float CKFOGIIACBB);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class AOBCMFIBGDN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float JKEANAJPICO = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class EKIOABIEPHK
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class JGHKDBEGACH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly NLEJNCDHDND BKKKBIDKIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly PJPENJPCMDL PKPGAEOFIGD;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5DADA80", Offset = "0x5DAC880", VA = "0x185DADA80")]
		public JGHKDBEGACH(NLEJNCDHDND BKKKBIDKIIC, PJPENJPCMDL PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5DADA30", Offset = "0x5DAC830", VA = "0x185DADA30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8E50", Offset = "0x5DA7C50", VA = "0x185DA8E50")]
	internal static bool NLKLFCGFFEP(float LEOEMBMBFBC, float GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4A7CE40", Offset = "0x4A7BC40", VA = "0x184A7CE40")]
	internal static float PDKNDEENLKH(float LEOEMBMBFBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8ED0", Offset = "0x5DA7CD0", VA = "0x185DA8ED0")]
	public static IDisposable PLMKLDDPKNC(this NLEJNCDHDND BKKKBIDKIIC, PJPENJPCMDL PKPGAEOFIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KLJLIGBHMNL : NLEJNCDHDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float CKFOGIIACBB;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7E9160", Offset = "0x7E7F60", VA = "0x1807E9160", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEA70", Offset = "0x5DAD870", VA = "0x185DAEA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PJPENJPCMDL HAKGKONOGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE9D0", Offset = "0x5DAD7D0", VA = "0x185DAE9D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEB30", Offset = "0x5DAD930", VA = "0x185DAEB30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KLJLIGBHMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class JOBKHMNLIFN
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE0C0", Offset = "0x5DACEC0", VA = "0x185DAE0C0")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this FLDIIEDDNHD FHALGLDMIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE130", Offset = "0x5DACF30", VA = "0x185DAE130")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this FLDIIEDDNHD FHALGLDMIJN, HashAlgorithmName OKIDPMKAJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5DADD90", Offset = "0x5DACB90", VA = "0x185DADD90")]
	public static bool HIKGJEDMAIG([CanBeNull] this FLDIIEDDNHD FHALGLDMIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5DADF20", Offset = "0x5DACD20", VA = "0x185DADF20")]
	public static bool HIKGJEDMAIG([CanBeNull] this FLDIIEDDNHD FHALGLDMIJN, out string OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DADD20", Offset = "0x5DACB20", VA = "0x185DADD20")]
	private static string CPCBNOFIJNN([CanBeNull] byte[] EHAMCGPFFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DADC00", Offset = "0x5DACA00", VA = "0x185DADC00")]
	private static bool AEKFOMLPJMI([NotNull] FLDIIEDDNHD FHALGLDMIJN, [CanBeNull] out byte[] NIMEMFKCFHI, [CanBeNull] out byte[] AAGFANMHCPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class NFDDCBNBAPP
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEFE0", Offset = "0x5DADDE0", VA = "0x185DAEFE0")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this HEPGAIPANLN CIBEJLEAPBA, byte[] BNOCCIJBADH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEDB0", Offset = "0x5DADBB0", VA = "0x185DAEDB0")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this HEPGAIPANLN CIBEJLEAPBA, HashAlgorithmName OKIDPMKAJIM, byte[] BNOCCIJBADH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface HEPGAIPANLN
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IAIMPBMLKHB);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FLDIIEDDNHD : HEPGAIPANLN
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] OMLOENPLOBC
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
	byte[] FNNCMIJKLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object EOIHMBAJCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class FIJHODFAOIB
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class HCADFCFFKBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC150", Offset = "0x5DAAF50", VA = "0x185DAC150")]
		public HCADFCFFKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC0F0", Offset = "0x5DAAEF0", VA = "0x185DAC0F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte FJLGIMFOOAB = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte LFCNBMHPFPL = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> EOKGPHHNIBC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool LMINAKOJGKG;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x3372BC0", Offset = "0x33719C0", VA = "0x183372BC0")]
	[Conditional("UNITY_EDITOR")]
	private static void BLFPAIOLBJI<T>(params T[] HEDNIEKBOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9320", Offset = "0x5DA8120", VA = "0x185DA9320")]
	public static IDisposable CNEPIOFMLNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA93C0", Offset = "0x5DA81C0", VA = "0x185DA93C0")]
	public static void FABCHMIDPKA(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] GameObject ENOCMPCACJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3372F40", Offset = "0x3371D40", VA = "0x183372F40")]
	public static void FABCHMIDPKA<T>(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] T NMNKGKHKMCB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3372EB0", Offset = "0x3371CB0", VA = "0x183372EB0")]
	public static void EPFOFKAEEFG<T>(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] T CIBEJLEAPBA) where T : HEPGAIPANLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3373010", Offset = "0x3371E10", VA = "0x183373010")]
	public static void IJLIGPJIIIK<T>(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] IList<T> KLPKPOGBAJC) where T : HEPGAIPANLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9750", Offset = "0x5DA8550", VA = "0x185DA9750")]
	private static bool LHMDJKPNGDB([CanBeNull] HEPGAIPANLN CIBEJLEAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9690", Offset = "0x5DA8490", VA = "0x185DA9690")]
	public static void KGANNDNEIGD(this IncrementalHash IAIMPBMLKHB, [CanBeNull] string CPKBGEGPMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9B20", Offset = "0x5DA8920", VA = "0x185DA9B20")]
	public static void MPGPCEKDDAN(this IncrementalHash IAIMPBMLKHB, long KJOFGBHIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9EC0", Offset = "0x5DA8CC0", VA = "0x185DA9EC0")]
	public static void ONFKCNBGBKK(this IncrementalHash IAIMPBMLKHB, int OMAMEIPKPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9CF0", Offset = "0x5DA8AF0", VA = "0x185DA9CF0")]
	public static void NMJMGLNMPBM(this IncrementalHash IAIMPBMLKHB, short FCHMHDBPFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA94B0", Offset = "0x5DA82B0", VA = "0x185DA94B0")]
	public static void IFOMHCFOPAD(this IncrementalHash IAIMPBMLKHB, byte MPCABHMOOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9950", Offset = "0x5DA8750", VA = "0x185DA9950")]
	public static void LOODFFGCIGO(this IncrementalHash IAIMPBMLKHB, bool OAIEOGLNLAA, bool AKNMMCGAGKM = false, bool BFLAMOHBOBN = false, bool EFOFMAIOMPE = false, bool AKIGJAAICOK = false, bool PIJDCOBGMCD = false, bool ANHAOIFMNMG = false, bool KPJOJMDCPJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3373470", Offset = "0x3372270", VA = "0x183373470")]
	public static void MFJIJCFLJDD<T>(this IncrementalHash IAIMPBMLKHB, T CDLELKLFEPM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DA96F0", Offset = "0x5DA84F0", VA = "0x185DA96F0")]
	public static void LCAMLHHAPFN(this IncrementalHash IAIMPBMLKHB, float ADGIBPEEDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA090", Offset = "0x5DA8E90", VA = "0x185DAA090")]
	public static void PCEGKJKKILO(this IncrementalHash IAIMPBMLKHB, double BILJNLGNJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9090", Offset = "0x5DA7E90", VA = "0x185DA9090")]
	public static void CBEOENNKJHD(this IncrementalHash IAIMPBMLKHB, ulong CLMPPKANPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9100", Offset = "0x5DA7F00", VA = "0x185DA9100")]
	public static void CBIHOHEHNLI(this IncrementalHash IAIMPBMLKHB, uint BAMAGIAKCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9620", Offset = "0x5DA8420", VA = "0x185DA9620")]
	public static void IJFFPJDJEJI(this IncrementalHash IAIMPBMLKHB, ushort FEEAAPKIGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA97E0", Offset = "0x5DA85E0", VA = "0x185DA97E0")]
	public static void LKCDKGDJNBM(this IncrementalHash IAIMPBMLKHB, Vector3 FEGKCHOFJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9160", Offset = "0x5DA7F60", VA = "0x185DA9160")]
	public static void CFOCGGGBGAE(this IncrementalHash IAIMPBMLKHB, Quaternion BPGMIOPHJFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class BFJKPHCOOLN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type PIBELKLPADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string AMPOMAILCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool NKCCAFCLNGC;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8460", Offset = "0x5DA7260", VA = "0x185DA8460")]
	public BFJKPHCOOLN(Type DBBHNONBNID, string OJKGNIIJCNE, bool ONCCHDOCPOO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KFKHJPODDLG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE7D0", Offset = "0x5DAD5D0", VA = "0x185DAE7D0")]
	public KFKHJPODDLG(string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE840", Offset = "0x5DAD640", VA = "0x185DAE840")]
	public KFKHJPODDLG(string HDKJDEIGPPL, Exception AMBDHCPDPBL)
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
			[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6C1B90", Offset = "0x6C0990", VA = "0x1806C1B90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int OJFFKHAMPMJ, int BOGIFKEPNOK]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x37658F0", Offset = "0x37646F0", VA = "0x1837658F0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3765990", Offset = "0x3764790", VA = "0x183765990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3765860", Offset = "0x3764660", VA = "0x183765860")]
		public Array2D(uint BDBMIEBKIGN, uint KDPLJDNGPBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x37657E0", Offset = "0x37645E0", VA = "0x1837657E0")]
		public void GJPIAAEOJAL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8180", Offset = "0x5DA6F80", VA = "0x185DA8180")]
		public Array2DVector3(uint BDBMIEBKIGN, uint KDPLJDNGPBM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class EDLELGOOFEO
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int MJKPBCGEEAM = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int GOBJOBFOHAI = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class LDNHPEHKDFI<THandle, TValue> : IDisposable where THandle : struct, MKBPDIMFNJC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> EDNKBFACCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> BLHNHHMKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> MOOFFIGKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> FPCNAOECCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int HALMFDFIIKI;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F44020", Offset = "0x2F42E20", VA = "0x182F44020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F44850", Offset = "0x2F43650", VA = "0x182F44850")]
	public LDNHPEHKDFI(Action<TValue> FPCNAOECCIP, [Optional] Func<TValue> MOOFFIGKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F43E30", Offset = "0x2F42C30", VA = "0x182F43E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F440F0", Offset = "0x2F42EF0", VA = "0x182F440F0")]
	public THandle GLBIKEOEKPG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F43EB0", Offset = "0x2F42CB0", VA = "0x182F43EB0")]
	public THandle ELGBPIMHCCH(TValue GKFICKKHACC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F43D80", Offset = "0x2F42B80", VA = "0x182F43D80")]
	public bool DOHHNJJEEIG(THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F44570", Offset = "0x2F43370", VA = "0x182F44570")]
	public bool KDKECGLKPJA(THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F44050", Offset = "0x2F42E50", VA = "0x182F44050")]
	public bool GIGGJMBFKKD(THandle DKBLPJPHEMF, out TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F442D0", Offset = "0x2F430D0", VA = "0x182F442D0")]
	public TValue HMFHOBMDMGG(THandle DKBLPJPHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F43F70", Offset = "0x2F42D70", VA = "0x182F43F70")]
	public bool FONENOMBNOF(THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F44820", Offset = "0x2F43620", VA = "0x182F44820")]
	private THandle MKPKODHHOGB(int BNNEENLPEFO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F43D50", Offset = "0x2F42B50", VA = "0x182F43D50")]
	private TValue DKHIEHMEGIE(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F44640", Offset = "0x2F43440", VA = "0x182F44640")]
	private void KFHKGADMANN(int BNNEENLPEFO, in THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F43F20", Offset = "0x2F42D20", VA = "0x182F43F20")]
	private void EPMCBJFFJMB(int BNNEENLPEFO, in TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F44710", Offset = "0x2F43510", VA = "0x182F44710")]
	private THandle MHNNAHCKOJC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F43CA0", Offset = "0x2F42AA0", VA = "0x182F43CA0")]
	private void AFDPIJACDBO(THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F43F60", Offset = "0x2F42D60", VA = "0x182F43F60")]
	private int FEMMPEMHNOB(int OPAPEIICLLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F44680", Offset = "0x2F43480", VA = "0x182F44680")]
	private bool LJDMFBJKDBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE650", Offset = "0x7CD450", VA = "0x1807CE650")]
	private void GEFPIMPHHJN(THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F44690", Offset = "0x2F43490", VA = "0x182F44690")]
	private bool MFJOEMEHEOK(out THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F44320", Offset = "0x2F43120", VA = "0x182F44320")]
	private bool HNLPPFMOPPB(out THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F44510", Offset = "0x2F43310", VA = "0x182F44510")]
	private void JJADIMNAHFH(THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F443F0", Offset = "0x2F431F0", VA = "0x182F443F0")]
	private void IEBEPNEPABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface MKBPDIMFNJC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int BDCBCEKMBAK
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
public interface LHEMAHBEHEJ<T> : MKBPDIMFNJC, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class KKLHOMICENG
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x11EE640", Offset = "0x11ED440", VA = "0x1811EE640")]
	public static bool KFLILKNDJOF<T>(this T DKBLPJPHEMF, T MCLIMJFDMCF) where T : struct, MKBPDIMFNJC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1B70", Offset = "0x2DD0970", VA = "0x182DD1B70")]
	public static bool ILPKKNHIECH<T>(this T DKBLPJPHEMF) where T : struct, MKBPDIMFNJC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE8C0", Offset = "0x5DAD6C0", VA = "0x185DAE8C0")]
	public static string MKOCOHPKHNF(this MKBPDIMFNJC DKBLPJPHEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class GMLGGPGGHDA
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum ABGAHOGBJBJ : byte
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
	private int IAIMPBMLKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool BHFMCCNJIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private ABGAHOGBJBJ OPCGPJFHEJB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool PHIHNICJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB9C0", Offset = "0x5DAA7C0", VA = "0x185DAB9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool LNPDEIFKFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB880", Offset = "0x5DAA680", VA = "0x185DAB880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC0C0", Offset = "0x5DAAEC0", VA = "0x185DAC0C0")]
	public GMLGGPGGHDA(bool BHFMCCNJIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DABA40", Offset = "0x5DAA840", VA = "0x185DABA40")]
	public void OMOCPHDJBDE(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB680", Offset = "0x5DAA480", VA = "0x185DAB680")]
	public void FGKDGKFMLKK(int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB970", Offset = "0x5DAA770", VA = "0x185DAB970")]
	public void LDHKPENJNLH(uint ALJGAHKJLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB860", Offset = "0x5DAA660", VA = "0x185DAB860")]
	public void HPEAFIBBEMK(bool EJODOKFKAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB980", Offset = "0x5DAA780", VA = "0x185DAB980")]
	public void LEHBPFPJMCM(long CNDLJBCLDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB5B0", Offset = "0x5DAA3B0", VA = "0x185DAB5B0")]
	public void EAOBHJDJIMH(ulong HDBLPDFJDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB9D0", Offset = "0x5DAA7D0", VA = "0x185DAB9D0")]
	public void OADGLMLJILG(string IBEOABCOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB5F0", Offset = "0x5DAA3F0", VA = "0x185DAB5F0")]
	public void FEIJCOGCEPJ(Enum AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB730", Offset = "0x5DAA530", VA = "0x185DAB730")]
	public void HCLNNILGMAE(IList LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D87B80", Offset = "0x2D86980", VA = "0x182D87B80")]
	public void OBPLNOMPGPH<T, U>(Dictionary<T, U> KOHNDAFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB240", Offset = "0x5DAA040", VA = "0x185DAB240")]
	private void DPBANLNJJNC(IDictionary KOHNDAFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB900", Offset = "0x5DAA700", VA = "0x185DAB900")]
	public int KIOMJKNJADM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB890", Offset = "0x5DAA690", VA = "0x185DAB890")]
	public short JIMNHOOKBOH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB720", Offset = "0x5DAA520", VA = "0x185DAB720")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB1D0", Offset = "0x5DA9FD0", VA = "0x185DAB1D0")]
	private void ALJNMADHMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class IOBEMCEJKJD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class BEFGDHKFLFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode DLIFLKHFBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode GEOFAMNLJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public MEIMBIMJKGJ GHGAIHKFDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<MEIMBIMJKGJ> OOCFAGBONDF;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public BEFGDHKFLFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct MEIMBIMJKGJ : IComparable<MEIMBIMJKGJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int KFNPPICHBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant EEOCCKJAOPO;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x752300", Offset = "0x751100", VA = "0x180752300")]
		public MEIMBIMJKGJ(int KFNPPICHBLJ, TClaimant EEOCCKJAOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x28AC1D0", Offset = "0x28AAFD0", VA = "0x1828AC1D0")]
		public bool CGFCKLPHHNA(in MEIMBIMJKGJ MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x28AC240", Offset = "0x28AB040", VA = "0x1828AC240")]
		public bool GHOCCJFPJIA(in MEIMBIMJKGJ MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x28AC230", Offset = "0x28AB030", VA = "0x1828AC230", Slot = "4")]
		public int CompareTo(MEIMBIMJKGJ MCLIMJFDMCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x28AC250", Offset = "0x28AB050", VA = "0x1828AC250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum JMGBOFIBPHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ONAINMHKHNN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::IOBEMCEJKJD<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1F369E0", Offset = "0x1F357E0", VA = "0x181F369E0")]
		[DebuggerHidden]
		public ONAINMHKHNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3838290", Offset = "0x3837090", VA = "0x183838290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3838450", Offset = "0x3837250", VA = "0x183838450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3838370", Offset = "0x3837170", VA = "0x183838370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x23EE090", Offset = "0x23ECE90", VA = "0x1823EE090", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::CDPICIPLBFE<BEFGDHKFLFP> JHCMGPDOAIN;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::CDPICIPLBFE<List<MEIMBIMJKGJ>> HEJNEKLDLKO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int PJDMFPAJDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> IDBIHHHOKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, BEFGDHKFLFP> LONLONHDNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private JMGBOFIBPHC GGBPGDBFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DJKFCHELMJI(TNode BAIMHJNEKGI);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NGDOLIFKACN(TNode BAIMHJNEKGI, TClaimant PDEGIOPJFHG, TClaimant LEJMENJGNED);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x259AD10", Offset = "0x2599B10", VA = "0x18259AD10")]
	public IOBEMCEJKJD(JMGBOFIBPHC GGBPGDBFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2599A20", Offset = "0x2598820", VA = "0x182599A20")]
	public void CGBAEKKCMNF(TNode BAIMHJNEKGI, TNode JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2599F60", Offset = "0x2598D60", VA = "0x182599F60")]
	public void JHHLOPAHJIG(TClaimant EEOCCKJAOPO, TNode CHJNHBOPNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2599AA0", Offset = "0x25988A0", VA = "0x182599AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2599980", Offset = "0x2598780", VA = "0x182599980")]
	private void CDFFCOHDMOE(TClaimant EEOCCKJAOPO, TNode DHECCPJOONE, TNode CHJNHBOPNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x259A320", Offset = "0x2599120", VA = "0x18259A320")]
	private int KKJKNGODDKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x25995C0", Offset = "0x25983C0", VA = "0x1825995C0")]
	private void BEBJAOLHLFP(TClaimant EEOCCKJAOPO, TNode INEBGLFHPPK, TNode NMJJIOLIMGA, int KCLBKOHAMAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x259A450", Offset = "0x2599250", VA = "0x18259A450")]
	private void LKLBGECCOHG(MEIMBIMJKGJ DHBAEDMEPHM, BEFGDHKFLFP CJPPBPILFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2599D00", Offset = "0x2598B00", VA = "0x182599D00")]
	private void FLNEIHJAHLK(TClaimant EEOCCKJAOPO, TNode INEBGLFHPPK, TNode NMJJIOLIMGA, int KCLBKOHAMAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x259A9E0", Offset = "0x25997E0", VA = "0x18259A9E0")]
	private void PENDHHHEOCD(MEIMBIMJKGJ DHBAEDMEPHM, TNode BAIMHJNEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x259A220", Offset = "0x2599020", VA = "0x18259A220")]
	private void JLOMMNJCKPO(MEIMBIMJKGJ DHBAEDMEPHM, BEFGDHKFLFP CJPPBPILFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2599870", Offset = "0x2598670", VA = "0x182599870")]
	private void BJFIMBADHEO(BEFGDHKFLFP CJPPBPILFFF, bool HOMOLDJOFJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x259A670", Offset = "0x2599470", VA = "0x18259A670")]
	private void OHANADCKCNM(BEFGDHKFLFP CJPPBPILFFF, TNode JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x259A380", Offset = "0x2599180", VA = "0x18259A380")]
	[IteratorStateMachine(typeof(global::IOBEMCEJKJD<, >.ONAINMHKHNN))]
	private IEnumerable<TNode> KPOEHELOKNH(TNode INEBGLFHPPK, TNode NMJJIOLIMGA, bool KNNDDCFNJIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x259AAF0", Offset = "0x25998F0", VA = "0x18259AAF0")]
	private BEFGDHKFLFP PLIEHKHKPGO(TNode BAIMHJNEKGI, TNode GEOFAMNLJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x259A4E0", Offset = "0x25992E0", VA = "0x18259A4E0")]
	private BEFGDHKFLFP NDPAEFBBOFI(TNode BAIMHJNEKGI, TNode GEOFAMNLJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x259A060", Offset = "0x2598E60", VA = "0x18259A060")]
	private void JINLFLNNMGP(BEFGDHKFLFP CJPPBPILFFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class OFNFJFAMGLI<T> : IEnumerable<global::OFNFJFAMGLI<T>.NNOPJMODPBD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct NNOPJMODPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T GKFICKKHACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int BNNEENLPEFO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class IOCELGNLCMI : IEnumerator<NNOPJMODPBD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::OFNFJFAMGLI<T> FAEKHNNILJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int BNNEENLPEFO;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x176B680", Offset = "0x176A480", VA = "0x18176B680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public NNOPJMODPBD FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x259B090", Offset = "0x2599E90", VA = "0x18259B090", Slot = "4")]
			get
			{
				return default(NNOPJMODPBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D60", Offset = "0x6F0B60", VA = "0x1806F1D60")]
		public IOCELGNLCMI(global::OFNFJFAMGLI<T> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x259AF50", Offset = "0x2599D50", VA = "0x18259AF50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D50", Offset = "0x6F0B50", VA = "0x1806F1D50", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAE1C20", Offset = "0xAE0A20", VA = "0x180AE1C20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct MCPKPHPKGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool ENEDPCBFNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T GKFICKKHACC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int FLBIADGCNEO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> IIFBEDDFCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private MCPKPHPKGGD[] DLGFELIHEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int IJPNNNJJAKL;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int MLBAMNKHLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x705FD0", Offset = "0x704DD0", VA = "0x180705FD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x815610", Offset = "0x814410", VA = "0x180815610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x24F68D0", Offset = "0x24F56D0", VA = "0x1824F68D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B560", Offset = "0x2F1A360", VA = "0x182F1B560")]
	public OFNFJFAMGLI(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B640", Offset = "0x2F1A440", VA = "0x182F1B640")]
	public OFNFJFAMGLI(NNOPJMODPBD[] NGBDNOPFIDJ, bool POGPOIGBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B470", Offset = "0x2F1A270", VA = "0x182F1B470")]
	public int PHOGHPMHIFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A300", Offset = "0x2F19100", VA = "0x182F1A300")]
	private int EDGFEOOLLML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A790", Offset = "0x2F19590", VA = "0x182F1A790", Slot = "6")]
	protected virtual uint GEDFFPAJIBB(uint IAIMPBMLKHB, T GKFICKKHACC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A0C0", Offset = "0x2F18EC0", VA = "0x182F1A0C0")]
	public bool CDFGHPMMOEJ(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A6F0", Offset = "0x2F194F0", VA = "0x182F1A6F0")]
	public bool FGAIHHMOIFD(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ACB0", Offset = "0x2F19AB0", VA = "0x182F1ACB0")]
	public bool KOOJGAMNGBI(Func<T, bool> DEKNKGENFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AC50", Offset = "0x2F19A50", VA = "0x182F1AC50")]
	public int KKJPAIFINAF(T GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A130", Offset = "0x2F18F30", VA = "0x182F1A130")]
	public T DKHIEHMEGIE(int BNNEENLPEFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A7E0", Offset = "0x2F195E0", VA = "0x182F1A7E0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B260", Offset = "0x2F1A060", VA = "0x182F1B260")]
	public bool NKDBGPNCFBD(T GKFICKKHACC, bool LOCNBDHDOKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AE30", Offset = "0x2F19C30", VA = "0x182F1AE30")]
	public bool NKDBGPNCFBD(T GKFICKKHACC, int BNNEENLPEFO, bool LOCNBDHDOKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A1F0", Offset = "0x2F18FF0", VA = "0x182F1A1F0")]
	public bool DOHHNJJEEIG(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2F1AB10", Offset = "0x2F19910", VA = "0x182F1AB10")]
	public bool IFFLOFKJNLP(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B2A0", Offset = "0x2F1A0A0", VA = "0x182F1B2A0")]
	private void NPHFNODOKBI(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A860", Offset = "0x2F19660", VA = "0x182F1A860")]
	public NNOPJMODPBD[] HCHCDCPPAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2F1ABB0", Offset = "0x2F199B0", VA = "0x182F1ABB0")]
	private int KFLGAPDFLCK(int IOGAMBOBGAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B4E0", Offset = "0x2F1A2E0", VA = "0x182F1B4E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B4E0", Offset = "0x2F1A2E0", VA = "0x182F1B4E0", Slot = "4")]
	private IEnumerator<NNOPJMODPBD> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct OKBAHLBKAOF<Handle> where Handle : MKBPDIMFNJC, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct HANACJOLAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::OKBAHLBKAOF<Handle> BECLDAPDMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int BNNEENLPEFO;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int AOLCBEFGBJN
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3821D10", Offset = "0x3820B10", VA = "0x183821D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle BKPKGIKLMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3821710", Offset = "0x3820510", VA = "0x183821710")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x38224D0", Offset = "0x38212D0", VA = "0x1838224D0")]
		public HANACJOLAPF(global::OKBAHLBKAOF<Handle> BECLDAPDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3821A70", Offset = "0x3820870", VA = "0x183821A70")]
		public GAJEEOELMJD KCNAIILPDFM(in GAJEEOELMJD KBICBGPAOHG)
		{
			return default(GAJEEOELMJD);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x38219D0", Offset = "0x38207D0", VA = "0x1838219D0")]
		public DDJOPJJJIED KCNAIILPDFM(in DDJOPJJJIED KBICBGPAOHG)
		{
			return default(DDJOPJJJIED);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x38223B0", Offset = "0x38211B0", VA = "0x1838223B0")]
		public bool PEKEHBIABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3821F10", Offset = "0x3820D10", VA = "0x183821F10")]
		private int OMBFBBFADFP(string HDKJDEIGPPL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x3821360", Offset = "0x3820160", VA = "0x183821360")]
		private Handle AENLMFCPFAB(string HDKJDEIGPPL)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct GAJEEOELMJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private HANACJOLAPF CAJJHPFKALI;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x31A7EB0", Offset = "0x31A6CB0", VA = "0x1831A7EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x3157F60", Offset = "0x3156D60", VA = "0x183157F60")]
		public GAJEEOELMJD(global::OKBAHLBKAOF<Handle> BECLDAPDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x3157E60", Offset = "0x3156C60", VA = "0x183157E60")]
		public bool PEKEHBIABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x31A7DF0", Offset = "0x31A6BF0", VA = "0x1831A7DF0")]
		public GAJEEOELMJD EMHOENNLHOC()
		{
			return default(GAJEEOELMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct DDJOPJJJIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private HANACJOLAPF CAJJHPFKALI;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3157DE0", Offset = "0x3156BE0", VA = "0x183157DE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3157F60", Offset = "0x3156D60", VA = "0x183157F60")]
		public DDJOPJJJIED(global::OKBAHLBKAOF<Handle> BECLDAPDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x3157E60", Offset = "0x3156C60", VA = "0x183157E60")]
		public bool PEKEHBIABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x3157CE0", Offset = "0x3156AE0", VA = "0x183157CE0")]
		public DDJOPJJJIED EMHOENNLHOC()
		{
			return default(DDJOPJJJIED);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> INHIOKLHGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> FKDOLFPKFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int JLHJOLIFDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int HJLKDMKALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool OCBDKMNEAFG;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2F23840", Offset = "0x2F22640", VA = "0x182F23840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int CHAJMBNPIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x64F190", Offset = "0x64DF90", VA = "0x18064F190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int PHGCIEGENED
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x64F190", Offset = "0x64DF90", VA = "0x18064F190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GAJEEOELMJD GBIDMFHFNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2F242F0", Offset = "0x2F230F0", VA = "0x182F242F0")]
		get
		{
			return default(GAJEEOELMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DDJOPJJJIED CPBGMPOEDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2F24390", Offset = "0x2F23190", VA = "0x182F24390")]
		get
		{
			return default(DDJOPJJJIED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2F278E0", Offset = "0x2F266E0", VA = "0x182F278E0")]
	public OKBAHLBKAOF(int FLELPJPPFKB, Allocator PBEDBDBGIPF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2F273E0", Offset = "0x2F261E0", VA = "0x182F273E0")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x234AEB0", Offset = "0x2349CB0", VA = "0x18234AEB0")]
	public static int FEMMPEMHNOB(int MINMGIMIPFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2F23620", Offset = "0x2F22420", VA = "0x182F23620")]
	public static bool BNMHFOJIFBI(int MINMGIMIPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2F23D40", Offset = "0x2F22B40", VA = "0x182F23D40")]
	public static bool DBEHPAPBGEH(int MINMGIMIPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2F239E0", Offset = "0x2F227E0", VA = "0x182F239E0")]
	public bool CLAGDKKDHAG(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2F27080", Offset = "0x2F25E80", VA = "0x182F27080")]
	public bool MHKNPKKNMIH(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2F246D0", Offset = "0x2F234D0", VA = "0x182F246D0")]
	public bool INFANEMMJPA(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2F263A0", Offset = "0x2F251A0", VA = "0x182F263A0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void KDLCLEODLOK(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2F26AB0", Offset = "0x2F258B0", VA = "0x182F26AB0")]
	public Handle LMEPPNCNPIJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2F248F0", Offset = "0x2F236F0", VA = "0x182F248F0")]
	public void JENIFGNKCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2F23420", Offset = "0x2F22220", VA = "0x182F23420")]
	public void ALDPJIEJDJP(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2F25B90", Offset = "0x2F24990", VA = "0x182F25B90")]
	public bool KALGAPNFMKB(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0")]
	private bool AIGKMNFLIJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2F23300", Offset = "0x2F22100", VA = "0x182F23300")]
	private bool AGFOJCNPBAP(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2F25520", Offset = "0x2F24320", VA = "0x182F25520")]
	private void JMGKABCCGBE(out int BNNEENLPEFO, out int OPAPEIICLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2F23F50", Offset = "0x2F22D50", VA = "0x182F23F50")]
	private void FFLGIIEIBPF(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2F242A0", Offset = "0x2F230A0", VA = "0x182F242A0")]
	private void FMDNLHFMONK(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2F27600", Offset = "0x2F26400", VA = "0x182F27600")]
	private bool PNNPBFANFOO(out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2F23630", Offset = "0x2F22430", VA = "0x182F23630")]
	private static Handle CDOLJNFCBPB(int BNNEENLPEFO, int OPAPEIICLLC)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct FIGNPHGKAHK<Handle, T> where Handle : MKBPDIMFNJC, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::OKBAHLBKAOF<Handle> DPHBIPDBJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] NCPMIIEIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> FPOKHGDMJOI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2884F80", Offset = "0x2883D80", VA = "0x182884F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2884F40", Offset = "0x2883D40", VA = "0x182884F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2884FB0", Offset = "0x2883DB0", VA = "0x182884FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2885AD0", Offset = "0x28848D0", VA = "0x182885AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2887A30", Offset = "0x2886830", VA = "0x182887A30")]
	public FIGNPHGKAHK(int FLELPJPPFKB, [Optional] Action<T> FPOKHGDMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2887520", Offset = "0x2886320", VA = "0x182887520")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2886980", Offset = "0x2885780", VA = "0x182886980")]
	public bool INFANEMMJPA(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void KDLCLEODLOK(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2886770", Offset = "0x2885570", VA = "0x182886770")]
	public T HMFHOBMDMGG(Handle DKBLPJPHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2886480", Offset = "0x2885280", VA = "0x182886480")]
	public bool GIGGJMBFKKD(Handle DKBLPJPHEMF, out T KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2887140", Offset = "0x2885F40", VA = "0x182887140")]
	public void NMFBOCJEJOB(Handle DKBLPJPHEMF, T EHMHICCFGJB, out T AHEJPDNJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2887330", Offset = "0x2886130", VA = "0x182887330")]
	public void NMFBOCJEJOB(Handle DKBLPJPHEMF, T EHMHICCFGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x28869D0", Offset = "0x28857D0", VA = "0x1828869D0")]
	public bool JKMJNDCPNKA(Handle DKBLPJPHEMF, T EHMHICCFGJB, out T AHEJPDNJEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2887060", Offset = "0x2885E60", VA = "0x182887060")]
	public bool JKMJNDCPNKA(Handle DKBLPJPHEMF, T EHMHICCFGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x28858A0", Offset = "0x28846A0", VA = "0x1828858A0")]
	public Handle ELGBPIMHCCH(T KMFLGGMLFJA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2886250", Offset = "0x2885050", VA = "0x182886250")]
	public void GFIDMAHEEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x28850F0", Offset = "0x2883EF0", VA = "0x1828850F0")]
	public void DOHHNJJEEIG(Handle DKBLPJPHEMF, out T AHEJPDNJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x28851C0", Offset = "0x2883FC0", VA = "0x1828851C0")]
	public void DOHHNJJEEIG(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2884A20", Offset = "0x2883820", VA = "0x182884A20")]
	public bool BMFJIOLJJLM(Handle DKBLPJPHEMF, out T AHEJPDNJEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2884B00", Offset = "0x2883900", VA = "0x182884B00")]
	public bool BMFJIOLJJLM(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2886830", Offset = "0x2885630", VA = "0x182886830")]
	private T IFFLOFKJNLP(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2887760", Offset = "0x2886560", VA = "0x182887760")]
	private void PHCHFJPBPOA(int ALPHMDODPNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class CDPICIPLBFE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> BECLDAPDMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> NIMLILLCOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int HDOBBNLPABL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int JEEBGGHKPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E520", Offset = "0x1F2D320", VA = "0x181F2E520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int FPGEFCKABAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x259ECB0", Offset = "0x259DAB0", VA = "0x18259ECB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x33E8400", Offset = "0x33E7200", VA = "0x1833E8400")]
	public static global::CDPICIPLBFE<T> APMLAIJBDNB(int BPGPHKEJPBF = 0, int HDOBBNLPABL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x33E8B20", Offset = "0x33E7920", VA = "0x1833E8B20")]
	public static global::CDPICIPLBFE<T> MHHFJAEKMEE(int BPGPHKEJPBF = 0, int HDOBBNLPABL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x33E8D80", Offset = "0x33E7B80", VA = "0x1833E8D80")]
	public CDPICIPLBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x33E8BF0", Offset = "0x33E79F0", VA = "0x1833E8BF0")]
	public CDPICIPLBFE(int BPGPHKEJPBF, int HDOBBNLPABL = int.MaxValue, bool DDAPCHIGGBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x33E8A10", Offset = "0x33E7810", VA = "0x1833E8A10")]
	public T KEJBKBEBENC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x33E84D0", Offset = "0x33E72D0", VA = "0x1833E84D0")]
	public void CGILPHFOCHO(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x33E8940", Offset = "0x33E7740", VA = "0x1833E8940")]
	private void KCCFADECGJJ(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x33E8890", Offset = "0x33E7690", VA = "0x1833E8890")]
	private void ECIIMHKFHLI(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x33E8580", Offset = "0x33E7380", VA = "0x1833E8580")]
	[Conditional("DEBUG_BUILD")]
	private void CHGPNKBPNLF(T JDIEBGBFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x33E88B0", Offset = "0x33E76B0", VA = "0x1833E88B0")]
	[Conditional("DEBUG_BUILD")]
	private void JOPEBMAANIF(T JDIEBGBFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x33E87A0", Offset = "0x33E75A0", VA = "0x1833E87A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x33E8600", Offset = "0x33E7400", VA = "0x1833E8600")]
	private void DCMNHFKNOGM(IEnumerable<T> BLHNHHMKNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GFMKOPEAAJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> AJHGDECFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T NPNPEFMILOC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T KFFBHGPIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool EECCOPMALHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x31BCDB0", Offset = "0x31BBBB0", VA = "0x1831BCDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x31BCDF0", Offset = "0x31BBBF0", VA = "0x1831BCDF0")]
	public bool KBFHBLDHILI(T GKFICKKHACC, int KFNPPICHBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x31BCCC0", Offset = "0x31BBAC0", VA = "0x1831BCCC0")]
	public bool GBACKLPKCJF(int KFNPPICHBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x31BCEB0", Offset = "0x31BBCB0", VA = "0x1831BCEB0")]
	public T OHPPGJGLHII(int ODMDLJHJIEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x31BCD50", Offset = "0x31BBB50", VA = "0x1831BCD50")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x31BCB20", Offset = "0x31BB920", VA = "0x1831BCB20")]
	private bool BLHFPJABNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x31BCD20", Offset = "0x31BBB20", VA = "0x1831BCD20")]
	public bool GINCMLLPDOD(int KFNPPICHBLJ, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x31BD2A0", Offset = "0x31BC0A0", VA = "0x1831BD2A0")]
	public GFMKOPEAAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class HLDPKMBNLHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct OAAKFOHIOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T AMPEKKPGHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int EGHNEAEEKBF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<OAAKFOHIOFE> PAACEHPKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T GIHJHGMKCAA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x24F68D0", Offset = "0x24F56D0", VA = "0x1824F68D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3345780", Offset = "0x3344580", VA = "0x183345780")]
	public bool KOOJGAMNGBI(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3345450", Offset = "0x3344250", VA = "0x183345450")]
	public void ELGBPIMHCCH(T GKFICKKHACC, int KFNPPICHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3345330", Offset = "0x3344130", VA = "0x183345330")]
	public bool DOHHNJJEEIG(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3345560", Offset = "0x3344360", VA = "0x183345560")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x33454F0", Offset = "0x33442F0", VA = "0x1833454F0")]
	public T ENELLOKJHEM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x33452C0", Offset = "0x33440C0", VA = "0x1833452C0")]
	public T DMODAANMPLG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x33455C0", Offset = "0x33443C0", VA = "0x1833455C0")]
	private void HHNGFNAFBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3345990", Offset = "0x3344790", VA = "0x183345990")]
	public HLDPKMBNLHF()
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
		[CKCNFJDLOHN(ALDDFIJCEMJ.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5DAFB20", Offset = "0x5DAE920", VA = "0x185DAFB20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5DAFEB0", Offset = "0x5DAECB0", VA = "0x185DAFEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5DAFD30", Offset = "0x5DAEB30", VA = "0x185DAFD30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5DB0010", Offset = "0x5DAEE10", VA = "0x185DB0010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5DAFA40", Offset = "0x5DAE840", VA = "0x185DAFA40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5DAFDD0", Offset = "0x5DAEBD0", VA = "0x185DAFDD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5DAFC50", Offset = "0x5DAEA50", VA = "0x185DAFC50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF9F0", Offset = "0x5DAE7F0", VA = "0x185DAF9F0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface AGLJDBGPKDB
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : AGLJDBGPKDB where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x3286610", Offset = "0x3285410", VA = "0x183286610", Slot = "4")]
		public virtual T JOJAOALDBJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class JACGLMMOHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, JGFNKHMNKMP> FLEDBEDAPDP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JGFNKHMNKMP KOOAFCAJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 HGBLIKAMFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x9A6100", Offset = "0x9A4F00", VA = "0x1809A6100")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x794690", Offset = "0x793490", VA = "0x180794690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 KGIGPFNKIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xC83730", Offset = "0xC82530", VA = "0x180C83730")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EB0", Offset = "0x7F4CB0", VA = "0x1807F5EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 DLOOLBKDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DACB50", Offset = "0x5DAB950", VA = "0x185DACB50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x772720", Offset = "0x771520", VA = "0x180772720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int EBKFGAKJDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEA0", Offset = "0x6ECCA0", VA = "0x1806EDEA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CE650", Offset = "0x7CD450", VA = "0x1807CE650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD150", Offset = "0x5DABF50", VA = "0x185DAD150")]
	public JACGLMMOHGH(Bounds DCCFOLANGLD, Vector2[] BGDPCEPNNII, int FNPFDNFFKPK, byte IOGAMBOBGAL, float IGJOFBAIEMC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DACB70", Offset = "0x5DAB970", VA = "0x185DACB70")]
	public JGFNKHMNKMP GECDMJHBIDM(byte BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA50", Offset = "0x5DAB850", VA = "0x185DACA50")]
	public void AHINOACJPJK(Vector3 DKGAADMNOOM, float BHHKNALNFCA, float PBMGFJJBJBF, ref List<byte> JEPPJNGKBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD130", Offset = "0x5DABF30", VA = "0x185DAD130")]
	public void OBPABGNEJPG(JGFNKHMNKMP.DJPLOIHNNIJ AMPFPJBJFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DACFD0", Offset = "0x5DABDD0", VA = "0x185DACFD0")]
	private JGFNKHMNKMP LFANGECEJGC(byte BNNEENLPEFO, JGFNKHMNKMP.NHCMKDJGCBI MIMKDMNPKAF, JGFNKHMNKMP GEOFAMNLJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DACBD0", Offset = "0x5DAB9D0", VA = "0x185DACBD0")]
	private void ICCAJJBBFHM(JGFNKHMNKMP GEOFAMNLJNK, Vector2[] BGDPCEPNNII, int HLBIBEOOLIF, int AGMNPKJPHNM, int NPONBKMMMGC, int EDGOHKKDCPA, float IGJOFBAIEMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class JGFNKHMNKMP
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum NHCMKDJGCBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum DJPLOIHNNIJ
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
	public byte KNHOMHPCCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 GDBDBLCPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 PEPLKIOHEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 CJEJLMCHEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 PNDIONKDMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NHCMKDJGCBI LFDKNDJGOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public JGFNKHMNKMP MJECJCHPAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<JGFNKHMNKMP> LEIDDLPHAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool LKNBGMABGMB;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD9B0", Offset = "0x5DAC7B0", VA = "0x185DAD9B0")]
	public JGFNKHMNKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD9D0", Offset = "0x5DAC7D0", VA = "0x185DAD9D0")]
	public JGFNKHMNKMP(byte GLGEGPNMJGF, NHCMKDJGCBI MIMKDMNPKAF, JGFNKHMNKMP GEOFAMNLJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD860", Offset = "0x5DAC660", VA = "0x185DAD860")]
	public void JDFBMCLFMDD(JGFNKHMNKMP DBNJJKLOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public void OBPABGNEJPG(int HLMHGDMGFOJ, DJPLOIHNNIJ AMPFPJBJFDB, int LNDLJLEHLKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD5B0", Offset = "0x5DAC3B0", VA = "0x185DAD5B0")]
	public void AHINOACJPJK(List<byte> JEPPJNGKBEF, Vector3 DKGAADMNOOM, float BHHKNALNFCA, float PBMGFJJBJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD960", Offset = "0x5DAC760", VA = "0x185DAD960")]
	public bool MDILIEJNDDG(Vector3 DEDMBANHEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD920", Offset = "0x5DAC720", VA = "0x185DAD920")]
	public bool KFNMECIBEGB(Vector3 DEDMBANHEDJ, float EPCFDGHEGAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class NBMJBDIHEEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> KPCEMGJGILM;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x251B160", Offset = "0x2519F60", VA = "0x18251B160")]
	public bool LNELCNECDOP(T MADNKELMDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE8B0", Offset = "0x2AED6B0", VA = "0x182AEE8B0")]
	public bool LNELCNECDOP(T MADNKELMDPN, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE8F0", Offset = "0x2AED6F0", VA = "0x182AEE8F0")]
	public bool LNELCNECDOP(T MADNKELMDPN, object JJFHDFJGCDG, out object MDMJMGPIBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE7B0", Offset = "0x2AED5B0", VA = "0x182AEE7B0")]
	public bool EGFGPOINFCO(T MADNKELMDPN, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE770", Offset = "0x2AED570", VA = "0x182AEE770")]
	public bool BMEDLPDOFIK(T MADNKELMDPN, object JJFHDFJGCDG, out object MDMJMGPIBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE7F0", Offset = "0x2AED5F0", VA = "0x182AEE7F0")]
	public bool EGFGPOINFCO(T MADNKELMDPN, object JJFHDFJGCDG, out object MDMJMGPIBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE880", Offset = "0x2AED680", VA = "0x182AEE880")]
	public void LDCJNFGHLJL(T MADNKELMDPN, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE950", Offset = "0x2AED750", VA = "0x182AEE950")]
	public void MFCMHPAGLPA(T MADNKELMDPN, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE9F0", Offset = "0x2AED7F0", VA = "0x182AEE9F0")]
	public NBMJBDIHEEN()
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
		public struct HMFLOEJNGMD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool KLPLMOPDDFM;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xB7A1E0", Offset = "0xB78FE0", VA = "0x180B7A1E0")]
			public HMFLOEJNGMD(List<Component> LENGKEKMOEB, bool KLPLMOPDDFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x33486B0", Offset = "0x33474B0", VA = "0x1833486B0")]
			public NDEMIAICFID<T> EMHOENNLHOC()
			{
				return default(NDEMIAICFID<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x3348720", Offset = "0x3347520", VA = "0x183348720", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x3348720", Offset = "0x3347520", VA = "0x183348720", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct NDEMIAICFID<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool KLPLMOPDDFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int BNNEENLPEFO;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T FPPIFCEMCLH
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC730", Offset = "0x2BCB530", VA = "0x182BCC730", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x2BCC6C0", Offset = "0x2BCB4C0", VA = "0x182BCC6C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC700", Offset = "0x2BCB500", VA = "0x182BCC700")]
			public NDEMIAICFID(List<Component> LENGKEKMOEB, bool KLPLMOPDDFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC5F0", Offset = "0x2BCB3F0", VA = "0x182BCC5F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC600", Offset = "0x2BCB400", VA = "0x182BCC600", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BCC6B0", Offset = "0x2BCB4B0", VA = "0x182BCC6B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB1D60", Offset = "0x5DB0B60", VA = "0x185DB1D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1D20", Offset = "0x5DB0B20", VA = "0x185DB1D20")]
		public ToolHierarchyCache(GameObject HCKEHDIEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB16B0", Offset = "0x5DB04B0", VA = "0x185DB16B0")]
		private void FNJOFAEFPIL(GameObject HCKEHDIEAIK, bool JOGFOOOHGFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1620", Offset = "0x5DB0420", VA = "0x185DB1620")]
		public static void FNJOFAEFPIL(GameObject HCKEHDIEAIK, ref ToolHierarchyCache MJPGKNPOLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1810", Offset = "0x5DB0610", VA = "0x185DB1810")]
		public void GPEKBHCJHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1C50", Offset = "0x5DB0A50", VA = "0x185DB1C50")]
		public void KMMNMEDFOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x360D9B0", Offset = "0x360C7B0", VA = "0x18360D9B0")]
		public void ABELFGODJOI<T>(Action<T> KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB14D0", Offset = "0x5DB02D0", VA = "0x185DB14D0")]
		public Component BNEIEOPFJAC(Type BIEGICDMJCM, bool KLPLMOPDDFM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x360DC40", Offset = "0x360CA40", VA = "0x18360DC40")]
		public T BNEIEOPFJAC<T>(bool KLPLMOPDDFM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1BD0", Offset = "0x5DB09D0", VA = "0x185DB1BD0")]
		public HMFLOEJNGMD<Component> KMGDJNJLPDE(Type BIEGICDMJCM, bool KLPLMOPDDFM = false)
		{
			return default(HMFLOEJNGMD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x360DCC0", Offset = "0x360CAC0", VA = "0x18360DCC0")]
		public HMFLOEJNGMD<T> KMGDJNJLPDE<T>(bool KLPLMOPDDFM = false) where T : class
		{
			return default(HMFLOEJNGMD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB18A0", Offset = "0x5DB06A0", VA = "0x185DB18A0")]
		public List<Component> HHOFMFMGOHB(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DB15A0", Offset = "0x5DB03A0", VA = "0x185DB15A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache IODEOJKDCNL, ToolHierarchyCache FNMMGECGLAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1820", Offset = "0x5DB0620", VA = "0x185DB1820", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KMFLGGMLFJA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class BCHIBBAKHAD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int BPGPHKEJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int OKGNJAMMHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> CKIGFGIEPDP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E520", Offset = "0x1F2D320", VA = "0x181F2E520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T BIAGFGAGMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D84DA0", Offset = "0x3D83BA0", VA = "0x183D84DA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T OIKFEMOBNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D84C30", Offset = "0x3D83A30", VA = "0x183D84C30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T GDKMPKAOFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D850D0", Offset = "0x3D83ED0", VA = "0x183D850D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D85180", Offset = "0x3D83F80", VA = "0x183D85180")]
	public BCHIBBAKHAD(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3D84F00", Offset = "0x3D83D00", VA = "0x183D84F00")]
	public void ELGBPIMHCCH(T PNKHOKKGIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3D84FE0", Offset = "0x3D83DE0", VA = "0x183D84FE0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D85030", Offset = "0x3D83E30", VA = "0x183D85030")]
	public void KLOGDENDLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D84CD0", Offset = "0x3D83AD0", VA = "0x183D84CD0")]
	public void AEKICGFADDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D85020", Offset = "0x3D83E20", VA = "0x183D85020")]
	public void IGIGGBPOLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class NOAIEIOEOML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool OGEFKLPIOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static NOAIEIOEOML NKPGLBOKJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF040", Offset = "0x5DADE40", VA = "0x185DAF040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LBEMKJJMHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x6CC600", Offset = "0x6CB400", VA = "0x1806CC600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x72A130", Offset = "0x728F30", VA = "0x18072A130")]
	public NOAIEIOEOML(Action KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF020", Offset = "0x5DADE20", VA = "0x185DAF020")]
	public void DNAKJMIBDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF020", Offset = "0x5DADE20", VA = "0x185DAF020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class DPMKPHIADEM
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8C80", Offset = "0x5DA7A80", VA = "0x185DA8C80")]
	public static void KFGBHPFBMEK(IKNDPBBFNFG CNKPBJAPJCK, string GGBECJHHNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	public static void KFGBHPFBMEK(IEnumerable<object> MPPBBBHMGNE, string GGBECJHHNEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BNCNMNBCFPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct IPPKLMFLGDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int EGHNEAEEKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T AMPEKKPGHLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, IPPKLMFLGDE> AJHGDECFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> MOKACFGFHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T NPNPEFMILOC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T KFFBHGPIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C17C0", Offset = "0x6C05C0", VA = "0x1806C17C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C19C0", Offset = "0x6C07C0", VA = "0x1806C19C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EECCOPMALHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B123F0", Offset = "0x2B111F0", VA = "0x182B123F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object AOLAIDPNCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B12820", Offset = "0x2B11620", VA = "0x182B12820")]
	public bool KBFHBLDHILI(T GKFICKKHACC, object JJFHDFJGCDG, int KFNPPICHBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B11CF0", Offset = "0x2B10AF0", VA = "0x182B11CF0")]
	public bool GBACKLPKCJF(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B120B0", Offset = "0x2B10EB0", VA = "0x182B120B0")]
	public bool GINCMLLPDOD(object JJFHDFJGCDG, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x259BB50", Offset = "0x259A950", VA = "0x18259BB50")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2D26760", Offset = "0x2D25560", VA = "0x182D26760")]
	private bool BLHFPJABNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2B12C90", Offset = "0x2B11A90", VA = "0x182B12C90")]
	public BNCNMNBCFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class BBCILEFDEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> AJHGDECFBDJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float POLBONMDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7E9160", Offset = "0x7E7F60", VA = "0x1807E9160")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7E9170", Offset = "0x7E7F70", VA = "0x1807E9170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8370", Offset = "0x5DA7170", VA = "0x185DA8370")]
	public void KBFHBLDHILI(float GKFICKKHACC, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8300", Offset = "0x5DA7100", VA = "0x185DA8300")]
	public void GBACKLPKCJF(object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5DA81E0", Offset = "0x5DA6FE0", VA = "0x185DA81E0")]
	private void ECAENPNAFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5DA83E0", Offset = "0x5DA71E0", VA = "0x185DA83E0")]
	public BBCILEFDEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class GHFMFMDNJJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string NKLJPCMLPBB;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	public GHFMFMDNJJE(string GMMJLPGEKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA410", Offset = "0x5DA9210", VA = "0x185DAA410")]
	public GHFMFMDNJJE(UnityEngine.Object NNPKBOLAHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA3C0", Offset = "0x5DA91C0", VA = "0x185DAA3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class IKNDPBBFNFG
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class FODEKPBKMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FODEKPBKMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA2D0", Offset = "0x5DA90D0", VA = "0x185DAA2D0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> MPPBBBHMGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int ECPGKBHIMEB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> IGNFIMPCACH
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC5F0", Offset = "0x5DAB3F0", VA = "0x185DAC5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool NEPGOCILDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC820", Offset = "0x5DAB620", VA = "0x185DAC820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC6C0", Offset = "0x5DAB4C0", VA = "0x185DAC6C0")]
	public bool ELGBPIMHCCH(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC550", Offset = "0x5DAB350", VA = "0x185DAC550")]
	public bool DOHHNJJEEIG(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC830", Offset = "0x5DAB630", VA = "0x185DAC830")]
	public bool KOOJGAMNGBI(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC7B0", Offset = "0x5DAB5B0", VA = "0x185DAC7B0")]
	public void FBPAFOLJDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC890", Offset = "0x5DAB690", VA = "0x185DAC890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public IKNDPBBFNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class EAKOBEGKCJB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct DHCCMCMANPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float FCLPAKFBGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T AMPEKKPGHLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, DHCCMCMANPN> AJHGDECFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T NOPJMGEANPN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T PCCKJHEFJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1802D90", Offset = "0x1801B90", VA = "0x181802D90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FD90", Offset = "0x1C2EB90", VA = "0x181C2FD90", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object ENBICPKHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool EECCOPMALHC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x37E39C0", Offset = "0x37E27C0", VA = "0x1837E39C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x37E3CE0", Offset = "0x37E2AE0", VA = "0x1837E3CE0")]
	public bool KBFHBLDHILI(T GKFICKKHACC, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x37E36F0", Offset = "0x37E24F0", VA = "0x1837E36F0")]
	public bool GBACKLPKCJF(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x259BB50", Offset = "0x259A950", VA = "0x18259BB50")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x37E3880", Offset = "0x37E2680", VA = "0x1837E3880")]
	public bool GINCMLLPDOD(object JJFHDFJGCDG, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x37E2740", Offset = "0x37E1540", VA = "0x1837E2740")]
	private bool BLHFPJABNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x37E3FD0", Offset = "0x37E2DD0", VA = "0x1837E3FD0")]
	public EAKOBEGKCJB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE1A0", Offset = "0x5DACFA0", VA = "0x185DAE1A0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE2B0", Offset = "0x5DAD0B0", VA = "0x185DAE2B0")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
