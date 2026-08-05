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
public class GKNGGJPCFFP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public GKNGGJPCFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, BFIOLPAACED, KHOHKGBAGLD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash KKHNLPKBFJI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84D6E0", Offset = "0x84CAE0", VA = "0x18084D6E0")]
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
	[CIOEHDDPDLK]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[CIOEHDDPDLK]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C54310", Offset = "0x5C53710", VA = "0x185C54310")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C542D0", Offset = "0x5C536D0", VA = "0x185C542D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C54350", Offset = "0x5C53750", VA = "0x185C54350")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C54500", Offset = "0x5C53900", VA = "0x185C54500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C54470", Offset = "0x5C53870", VA = "0x185C54470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EAC90", Offset = "0x7EA090", VA = "0x1807EAC90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8891C0", Offset = "0x8885C0", VA = "0x1808891C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C54290", Offset = "0x5C53690", VA = "0x185C54290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C543E0", Offset = "0x5C537E0", VA = "0x185C543E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C53D00", Offset = "0x5C53100", VA = "0x185C53D00")]
	public void CopyBounds(SavedExtents LJIBJAOOGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C541E0", Offset = "0x5C535E0", VA = "0x185C541E0")]
	public void SetLocalSpaceBounds(Bounds MEPCKKMLJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8A72B0", Offset = "0x8A66B0", VA = "0x1808A72B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C541D0", Offset = "0x5C535D0", VA = "0x185C541D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C53D30", Offset = "0x5C53130", VA = "0x185C53D30")]
	private void KGEJOFKEPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C53FB0", Offset = "0x5C533B0", VA = "0x185C53FB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C53690", Offset = "0x5C52A90", VA = "0x185C53690")]
	public static void CalculateLocalBoundsFor(GameObject IPAGFDLNMDK, [Out] Bounds MEPCKKMLJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C53EF0", Offset = "0x5C532F0", VA = "0x185C53EF0")]
	private static void ODHEEBKHLKD(Bounds DNPBOPMFFFF, Color AGEAOGKCCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C54200", Offset = "0x5C53600", VA = "0x185C54200")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x766EA0", Offset = "0x7662A0", VA = "0x180766EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCCB110", Offset = "0xCCA510", VA = "0x180CCB110")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCA30", Offset = "0x3FDBE30", VA = "0x183FDCA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
	public virtual void PNFJMFGLCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
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
	[GKNGGJPCFFP]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC610", Offset = "0x3FDBA10", VA = "0x183FDC610", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB2B0", Offset = "0x3FDA6B0", VA = "0x183FDB2B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC960", Offset = "0x3FDBD60", VA = "0x183FDC960")]
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
	private sealed class MCIHILGDEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public MCIHILGDEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E1E0", Offset = "0x3B5D5E0", VA = "0x183B5E1E0")]
		internal int CDNLPBAHAAK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[GKNGGJPCFFP]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3098580", Offset = "0x3097980", VA = "0x183098580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30985D0", Offset = "0x30979D0", VA = "0x1830985D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3098480", Offset = "0x3097880", VA = "0x183098480", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey DGCJCBHPPBD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3098520", Offset = "0x3097920", VA = "0x183098520", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3098360", Offset = "0x3097760", VA = "0x183098360", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3098080", Offset = "0x3097480", VA = "0x183098080", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3097520", Offset = "0x3096920", VA = "0x183097520", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3097420", Offset = "0x3096820", VA = "0x183097420", Slot = "14")]
	protected virtual string FLGOHFCHBAF(TKeyVal KIBLFGPNOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x30973A0", Offset = "0x30967A0", VA = "0x1830973A0", Slot = "4")]
	public bool ContainsKey(TKey DGCJCBHPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3098220", Offset = "0x3097620", VA = "0x183098220", Slot = "5")]
	public bool TryGetValue(TKey DGCJCBHPPBD, [Out] TVal EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3097480", Offset = "0x3096880", VA = "0x183097480", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3097480", Offset = "0x3096880", VA = "0x183097480", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3098270", Offset = "0x3097670", VA = "0x183098270")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IKNDMELGEPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ABNAGHKHLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public ABNAGHKHLEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3451D80", Offset = "0x3451180", VA = "0x183451D80")]
		internal bool KFJBFLKHMPI(OMEOFJONLFO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float NFFIHIIOJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float BNHMPOAAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<OMEOFJONLFO<float, T>> IOODJFLGIBI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int ONEHAIDGPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x363F340", Offset = "0x363E740", VA = "0x18363F340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x363F420", Offset = "0x363E820", VA = "0x18363F420")]
	public IKNDMELGEPB(float BFCPDFIGMCB, float LFANDHBNMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x363F1B0", Offset = "0x363E5B0", VA = "0x18363F1B0")]
	public bool MHFPEIHDICH(float EGHBFNCPCGI, T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x363E920", Offset = "0x363DD20", VA = "0x18363E920")]
	public IEnumerable<T> HJBHIGELMEO(float EGHBFNCPCGI, [Optional] float? APPFIFIPGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x363E8F0", Offset = "0x363DCF0", VA = "0x18363E8F0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x363EF40", Offset = "0x363E340", VA = "0x18363EF40")]
	private void MCCPOHGDOPL(float EGHBFNCPCGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PPOKJLBACLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CBMOAFONIGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T DFNAILAPHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float ECKFLHJCLHA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float EAPJBGGKJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> HPKAOEEEDNJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LEHADJFKKAK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CBMOAFONIGK[] FFAHMFOPGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int ABNJAADLDFB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float HNPDFDJLPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA955B0", Offset = "0xA949B0", VA = "0x180A955B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA95590", Offset = "0xA94990", VA = "0x180A95590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E149C0", Offset = "0x3E13DC0", VA = "0x183E149C0")]
	public PPOKJLBACLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3E148D0", Offset = "0x3E13CD0", VA = "0x183E148D0")]
	public PPOKJLBACLE(int DAIAAPJIJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E141F0", Offset = "0x3E135F0", VA = "0x183E141F0")]
	public void INMJBKGEACO(float EGHBFNCPCGI, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E139F0", Offset = "0x3E12DF0", VA = "0x183E139F0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E145F0", Offset = "0x3E139F0", VA = "0x183E145F0")]
	public bool MOGEFAFEJEJ(float FPJMEBILACK, float EFDDLDFCCKP, [Out] T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E13DC0", Offset = "0x3E131C0", VA = "0x183E13DC0")]
	public bool FBHGOEIBGOL(float FPJMEBILACK, float EFDDLDFCCKP, [Out] T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E140B0", Offset = "0x3E134B0", VA = "0x183E140B0")]
	public void IMFGDECPFCP(float FPJMEBILACK, float EFDDLDFCCKP, List<T> FNCIFBBDALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E14840", Offset = "0x3E13C40", VA = "0x183E14840")]
	private int PDOIKGMGJOM(int NEMDBCOJLNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E147F0", Offset = "0x3E13BF0", VA = "0x183E147F0")]
	private void NJFANKMEAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HLMKDIJEFDH();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T DGNEJMALDNI(T EOHMJBFGDPD, float PDOICOFDEIB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LELGBOEJCGO(T IBOMHLKOLJB, T FFDHLLBEMJM);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CLAOKCJCALN(T IBOMHLKOLJB, T FFDHLLBEMJM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PAGFDGNPJPG : PPOKJLBACLE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x76D990", Offset = "0x76CD90", VA = "0x18076D990", Slot = "4")]
	protected override Vector3 HLMKDIJEFDH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C53060", Offset = "0x5C52460", VA = "0x185C53060", Slot = "5")]
	protected override Vector3 DGNEJMALDNI(Vector3 EOHMJBFGDPD, float PDOICOFDEIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C530A0", Offset = "0x5C524A0", VA = "0x185C530A0", Slot = "6")]
	protected override Vector3 LELGBOEJCGO(Vector3 IBOMHLKOLJB, Vector3 FFDHLLBEMJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C52FE0", Offset = "0x5C523E0", VA = "0x185C52FE0", Slot = "7")]
	protected override Vector3 CLAOKCJCALN(Vector3 IBOMHLKOLJB, Vector3 FFDHLLBEMJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C530F0", Offset = "0x5C524F0", VA = "0x185C530F0")]
	public PAGFDGNPJPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BNBOLIIJIIH
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x21A4410", Offset = "0x21A3810", VA = "0x1821A4410")]
	public static OMEOFJONLFO<T1, T2> EECJKDKEFDC<T1, T2>(T1 DBOMBLGDHNH, T2 LGMOLMIMIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x21A4490", Offset = "0x21A3890", VA = "0x1821A4490")]
	public static DGKOADFKFFB<T1, T2, T3> EECJKDKEFDC<T1, T2, T3>(T1 DBOMBLGDHNH, T2 LGMOLMIMIIC, T3 MMDMOIKPNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5BD0", Offset = "0x3BE4FD0", VA = "0x183BE5BD0")]
	internal static int NBEBOMOPEKA(int INOAJPOOOEE, int OJBCKCLACKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5131BB0", Offset = "0x5130FB0", VA = "0x185131BB0")]
	internal static int NBEBOMOPEKA(int INOAJPOOOEE, int OJBCKCLACKM, int GJECCICNNDE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OMEOFJONLFO<T1, T2> : IComparable<OMEOFJONLFO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 BFAGJMLPBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 OLEKFMMNMBO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA680", Offset = "0x3CF9A80", VA = "0x183CFA680")]
	public OMEOFJONLFO(T1 DBOMBLGDHNH, T2 LGMOLMIMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8740", Offset = "0x3CF7B40", VA = "0x183CF8740", Slot = "4")]
	public int CompareTo(OMEOFJONLFO<T1, T2> LJIBJAOOGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8B00", Offset = "0x3CF7F00", VA = "0x183CF8B00", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9930", Offset = "0x3CF8D30", VA = "0x183CF9930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA070", Offset = "0x3CF9470", VA = "0x183CFA070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DGKOADFKFFB<T1, T2, T3> : IComparable<DGKOADFKFFB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 BFAGJMLPBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 OLEKFMMNMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 IIJICNNADHB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EB70", Offset = "0x4C8DF70", VA = "0x184C8EB70")]
	public DGKOADFKFFB(T1 DBOMBLGDHNH, T2 LGMOLMIMIIC, T3 MMDMOIKPNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E230", Offset = "0x4C8D630", VA = "0x184C8E230", Slot = "4")]
	public int CompareTo(DGKOADFKFFB<T1, T2, T3> LJIBJAOOGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E5C0", Offset = "0x4C8D9C0", VA = "0x184C8E5C0", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E800", Offset = "0x4C8DC00", VA = "0x184C8E800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E8A0", Offset = "0x4C8DCA0", VA = "0x184C8E8A0", Slot = "3")]
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
	public T DFNAILAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F850", Offset = "0x1E8EC50", VA = "0x181E8F850")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F900", Offset = "0x1E8ED00", VA = "0x181E8F900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float JHALLDBJOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DCE0", Offset = "0xA3D0E0", VA = "0x180A3DCE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41E3270", Offset = "0x41E2670", VA = "0x1841E3270")]
	public T BEMJMHAOHHL(float PDOICOFDEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41E3580", Offset = "0x41E2980", VA = "0x1841E3580")]
	public T JBGKALHOIOJ(float PDOICOFDEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FJBIGAOFEBF(T IBOMHLKOLJB, T FFDHLLBEMJM, float PDOICOFDEIB);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C507F0", Offset = "0x5C4FBF0", VA = "0x185C507F0", Slot = "4")]
	protected override float FJBIGAOFEBF(float IBOMHLKOLJB, float FFDHLLBEMJM, float PDOICOFDEIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C50830", Offset = "0x5C4FC30", VA = "0x185C50830")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB818E0", Offset = "0xB80CE0", VA = "0x180B818E0", Slot = "4")]
	protected override Vector3 FJBIGAOFEBF(Vector3 IBOMHLKOLJB, Vector3 FFDHLLBEMJM, float PDOICOFDEIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C55320", Offset = "0x5C54720", VA = "0x185C55320")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FFB0", Offset = "0x5C4F3B0", VA = "0x185C4FFB0", Slot = "4")]
	protected override Color FJBIGAOFEBF(Color IBOMHLKOLJB, Color FFDHLLBEMJM, float PDOICOFDEIB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C50070", Offset = "0x5C4F470", VA = "0x185C50070")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AKCKILFAGNL : DEDJOEIICFO<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FC10", Offset = "0x5C4F010", VA = "0x185C4FC10")]
	public AKCKILFAGNL(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FBA0", Offset = "0x5C4EFA0", VA = "0x185C4FBA0", Slot = "6")]
	protected override uint DINNNCCOFNK(uint KKHNLPKBFJI, string EOHMJBFGDPD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CAENODHFLKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CAENODHFLKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GKMCAILBNGB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DAFGFPGBMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int LCCHPJEDMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int APJBKIACPIE;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x34CBBF0", Offset = "0x34CAFF0", VA = "0x1834CBBF0")]
	private GKMCAILBNGB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EICMFDDECBO, int OIHBGCHMDAI, int IJDIEEMOCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x34CBAF0", Offset = "0x34CAEF0", VA = "0x1834CBAF0")]
	public static GKMCAILBNGB<T> LJCGEPFBFCG()
	{
		return default(GKMCAILBNGB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x34CADB0", Offset = "0x34CA1B0", VA = "0x1834CADB0")]
	public (int, int, Task<T>) GOMEJILDBDK(int FAFPKHBLDBG, [Optional] CancellationToken ELGJALILGJE, double DBEHEFMCFDE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x34CA370", Offset = "0x34C9770", VA = "0x1834CA370")]
	public void BAOKBKFOJMG(int FAFPKHBLDBG, int IJDIEEMOCHO, [In] T KNLODAPAGGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LOOFKKPKOEH
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5C51210", Offset = "0x5C50610", VA = "0x185C51210")]
	public static GKMCAILBNGB<OGKMPBOGKAG> LJCGEPFBFCG()
	{
		return default(GKMCAILBNGB<OGKMPBOGKAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5C51190", Offset = "0x5C50590", VA = "0x185C51190")]
	public static void BAOKBKFOJMG([In] this GKMCAILBNGB<OGKMPBOGKAG> LDMHFMNLDHG, int FAFPKHBLDBG, int IJDIEEMOCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class APBMLGKIIHB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> HLINGDDPCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> PJKJNKNAJCE;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC5430", VA = "0x182EC6030", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LIGHAHNLJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> OHLHHBBJJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x34C1AD0", Offset = "0x34C0ED0", VA = "0x1834C1AD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> NFCDJGDFNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x37DA390", Offset = "0x37D9790", VA = "0x1837DA390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x37DA330", Offset = "0x37D9730", VA = "0x1837DA330", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x37DA3D0", Offset = "0x37D97D0", VA = "0x1837DA3D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x37D9C00", Offset = "0x37D9000", VA = "0x1837D9C00")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37D9810", Offset = "0x37D8C10", VA = "0x1837D9810", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37DA0C0", Offset = "0x37D94C0", VA = "0x1837DA0C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x37D9620", Offset = "0x37D8A20", VA = "0x1837D9620", Slot = "9")]
	public void Add(TKey DGCJCBHPPBD, TVal EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37D95F0", Offset = "0x37D89F0", VA = "0x1837D95F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3071580", Offset = "0x3070980", VA = "0x183071580", Slot = "8")]
	public bool ContainsKey(TKey DGCJCBHPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37D98D0", Offset = "0x37D8CD0", VA = "0x1837D98D0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37DA030", Offset = "0x37D9430", VA = "0x1837DA030", Slot = "10")]
	public bool Remove(TKey DGCJCBHPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37DA090", Offset = "0x37D9490", VA = "0x1837DA090", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37DA1B0", Offset = "0x37D95B0", VA = "0x1837DA1B0", Slot = "11")]
	public bool TryGetValue(TKey DGCJCBHPPBD, [Out] TVal EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37D9CA0", Offset = "0x37D90A0", VA = "0x1837D9CA0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37D9900", Offset = "0x37D8D00", VA = "0x1837D9900", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FFAHMFOPGLA, int FJCKEJMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x37D9E20", Offset = "0x37D9220", VA = "0x1837D9E20")]
	public bool IEDNKFHOGLK(TVal DGCJCBHPPBD, [Out] TKey EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37D9E70", Offset = "0x37D9270", VA = "0x1837D9E70")]
	private void OHOPOHNOPNB(TKey DGCJCBHPPBD, TVal PGHIMEILAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x37D9650", Offset = "0x37D8A50", VA = "0x1837D9650")]
	private void BPACKANKGGJ(TKey DGCJCBHPPBD, TVal PGHIMEILAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37D9B20", Offset = "0x37D8F20", VA = "0x1837D9B20")]
	private bool EKGMEFNEPHH(TKey DGCJCBHPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x37DA1F0", Offset = "0x37D95F0", VA = "0x1837DA1F0")]
	public APBMLGKIIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class AEAJLFJHHPH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AEAJLFJHHPH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x30F47A0", Offset = "0x30F3BA0", VA = "0x1830F47A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x30F5560", Offset = "0x30F4960", VA = "0x1830F5560")]
		public Enumerator(AEAJLFJHHPH<T> FNCIFBBDALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x30F30E0", Offset = "0x30F24E0", VA = "0x1830F30E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x30F3800", Offset = "0x30F2C00", VA = "0x1830F3800", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30F3360", Offset = "0x30F2760", VA = "0x1830F3360")]
		private void PBKAIJBOIOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] GMPPMJJPOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int IDGHKCPGHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OEPLDCNFDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FOIKACEEEGH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x346A0D0", Offset = "0x34694D0", VA = "0x18346A0D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x346A110", Offset = "0x3469510", VA = "0x18346A110")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x346A860", Offset = "0x3469C60", VA = "0x18346A860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x346B480", Offset = "0x346A880", VA = "0x18346B480")]
	public AEAJLFJHHPH(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x346A400", Offset = "0x3469800", VA = "0x18346A400")]
	public void INMJBKGEACO(T PDOICOFDEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x346A0B0", Offset = "0x34694B0", VA = "0x18346A0B0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x346A290", Offset = "0x3469690", VA = "0x18346A290")]
	public void ICCIJLKDBFA(int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x346ABB0", Offset = "0x3469FB0", VA = "0x18346ABB0")]
	public void NBCFLKJPNCB(T[] FFAHMFOPGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x346A670", Offset = "0x3469A70", VA = "0x18346A670")]
	public Enumerator JBKAHEPNGNA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x346B380", Offset = "0x346A780", VA = "0x18346B380", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x346B380", Offset = "0x346A780", VA = "0x18346B380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x346B0E0", Offset = "0x346A4E0", VA = "0x18346B0E0")]
	private int NGHPCMENGCG(int APOENOPNHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x346AE90", Offset = "0x346A290", VA = "0x18346AE90")]
	private int NCJMGCOJLOK(int APOENOPNHBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class MJIJJNNFLHN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> CCHLMEBMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> KEKPLKHNJAG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1040", Offset = "0x3BB0440", VA = "0x183BB1040", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0F80", Offset = "0x3BB0380", VA = "0x183BB0F80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	public MJIJJNNFLHN(Func<Internal, External> CCHLMEBMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0F30", Offset = "0x3BB0330", VA = "0x183BB0F30")]
	public MJIJJNNFLHN(IReadOnlyList<Internal> KEKPLKHNJAG, Func<Internal, External> CCHLMEBMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0EB0", Offset = "0x3BB02B0", VA = "0x183BB0EB0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x303DF90", Offset = "0x303D390", VA = "0x18303DF90", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EOGEMKHKGBM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> NCMBKPNFPJM(TRequest PLGCCHMKBMF, CancellationToken ELGJALILGJE);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum FEPNNALOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class BIMANPEGIAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float LCIAANLBOPM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan NDHMKKCKNOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int JABNNOAGDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FEPNNALOPNI JOJHENBEKEL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly BIMANPEGIAF BDJLOIHNJNG;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float MPEKILNJPIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x4846CA0", Offset = "0x48460A0", VA = "0x184846CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan EHAGCOIMGOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4846DF0", Offset = "0x48461F0", VA = "0x184846DF0")]
		public BIMANPEGIAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct JMEEJHHOFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest PLGCCHMKBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken ELGJALILGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> EGFDEDAHBLI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x385E110", Offset = "0x385D510", VA = "0x18385E110")]
		public JMEEJHHOFIJ(TRequest PLGCCHMKBMF, TaskCompletionSource<TResult> EGFDEDAHBLI, CancellationToken ELGJALILGJE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct IEPACKPPPEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EOGEMKHKGBM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3633FC0", Offset = "0x36333C0", VA = "0x183633FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3634400", Offset = "0x3633800", VA = "0x183634400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct GCAPPJKGCEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EOGEMKHKGBM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private JMEEJHHOFIJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x34ABBA0", Offset = "0x34AAFA0", VA = "0x1834ABBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x34ACDD0", Offset = "0x34AC1D0", VA = "0x1834ACDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource EHDHNHDCGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<JMEEJHHOFIJ> IGBOEDOLAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly BIMANPEGIAF LFPMLHKANLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NCMBKPNFPJM DMDMAHMHFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task JJFGGPPEMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int DLHEBFGAPBD;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x308E6A0", Offset = "0x308DAA0", VA = "0x18308E6A0")]
	public EOGEMKHKGBM(NCMBKPNFPJM DMDMAHMHFAJ, [Optional] BIMANPEGIAF LFPMLHKANLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x308DFF0", Offset = "0x308D3F0", VA = "0x18308DFF0")]
	public Task<TResult> NOHJPKGDKOB(TRequest PLGCCHMKBMF, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x308DBD0", Offset = "0x308CFD0", VA = "0x18308DBD0")]
	private void LJFEAJLEKGL(JMEEJHHOFIJ LLCLLOEPBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x308D820", Offset = "0x308CC20", VA = "0x18308D820")]
	[AsyncStateMachine(typeof(EOGEMKHKGBM<, >.IEPACKPPPEM))]
	private Task JKOPEONJEGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x308CE50", Offset = "0x308C250", VA = "0x18308CE50")]
	private JMEEJHHOFIJ DNGCIBGFBAM()
	{
		return default(JMEEJHHOFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x308D8F0", Offset = "0x308CCF0", VA = "0x18308D8F0")]
	[AsyncStateMachine(typeof(EOGEMKHKGBM<, >.GCAPPJKGCEB))]
	private Task LJCAIAJMOGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x308D3B0", Offset = "0x308C7B0", VA = "0x18308D3B0")]
	private void EIJPEOOKLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x308D370", Offset = "0x308C770", VA = "0x18308D370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class BJCLLKFLFEE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> KEKPLKHNJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> KDNHBHKNBGD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC5430", VA = "0x182EC6030", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LIGHAHNLJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DE90", Offset = "0x3D9D290", VA = "0x183D9DE90", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4849040", Offset = "0x4848440", VA = "0x184849040", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x33DD250", Offset = "0x33DC650", VA = "0x1833DD250", Slot = "11")]
	public void Add(T JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x48488D0", Offset = "0x4847CD0", VA = "0x1848488D0")]
	public bool AHLOGHJFIBI(T JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4848E10", Offset = "0x4848210", VA = "0x184848E10", Slot = "15")]
	public bool Remove(T JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x34BE0C0", Offset = "0x34BD4C0", VA = "0x1834BE0C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3400820", Offset = "0x33FFC20", VA = "0x183400820", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4848990", Offset = "0x4847D90", VA = "0x184848990", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x48489F0", Offset = "0x4847DF0", VA = "0x1848489F0", Slot = "13")]
	public bool Contains(T JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4848A30", Offset = "0x4847E30", VA = "0x184848A30", Slot = "14")]
	public void CopyTo(T[] FFAHMFOPGLA, int FJCKEJMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x391BDE0", Offset = "0x391B1E0", VA = "0x18391BDE0", Slot = "6")]
	public int IndexOf(T JJEIFGHOKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4848A60", Offset = "0x4847E60", VA = "0x184848A60", Slot = "7")]
	public void Insert(int APOENOPNHBG, T JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4848C20", Offset = "0x4848020", VA = "0x184848C20", Slot = "8")]
	public void RemoveAt(int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4848F50", Offset = "0x4848350", VA = "0x184848F50")]
	public BJCLLKFLFEE()
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
			[Cpp2IlInjected.Address(RVA = "0x1F780F0", Offset = "0x1F774F0", VA = "0x181F780F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C548A0", Offset = "0x5C53CA0", VA = "0x185C548A0")]
		public SerializedGuid([In] Guid OGGNLGCIGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5C54620", Offset = "0x5C53A20", VA = "0x185C54620")]
		public static SerializedGuid EGOLIEKAEEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C54780", Offset = "0x5C53B80", VA = "0x185C54780")]
		public static SerializedGuid IGCFLOFLFHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C545C0", Offset = "0x5C539C0", VA = "0x185C545C0")]
		public bool DDHCPHLKOFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5C54870", Offset = "0x5C53C70", VA = "0x185C54870", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C547F0", Offset = "0x5C53BF0", VA = "0x185C547F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C546A0", Offset = "0x5C53AA0", VA = "0x185C546A0", Slot = "7")]
		public bool Equals(SerializedGuid LJIBJAOOGGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C546E0", Offset = "0x5C53AE0", VA = "0x185C546E0", Slot = "0")]
		public override bool Equals(object BAFDGKKJJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C54770", Offset = "0x5C53B70", VA = "0x185C54770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C54590", Offset = "0x5C53990", VA = "0x185C54590", Slot = "6")]
		public int CompareTo(SerializedGuid LJIBJAOOGGF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ENKLJHPDKKM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type PLFLPDGOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string POMIACNPADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool DGKCEJDPJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool LJJEPNCEFDC;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5C500B0", Offset = "0x5C4F4B0", VA = "0x185C500B0")]
	public ENKLJHPDKKM(Type NBEDBFIGPMG, string EDDIAIPABNF, bool AKCBLCCJJIL = false, bool COIHHEKGJGH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CBIPFMDCEHJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct CIMHAADDOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long CLKHCGCBJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long CPENMBOOOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int BMEHKCECIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int NHGGNECJEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool GPBBFCEEIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string NPPAINEDAPN;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCC40", Offset = "0x4ADC040", VA = "0x184ADCC40")]
		public CIMHAADDOFH(long CLKHCGCBJNK, int BMEHKCECIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCCB0", Offset = "0x4ADC0B0", VA = "0x184ADCCB0")]
		public CIMHAADDOFH(long CLKHCGCBJNK, long CPENMBOOOAB, int BMEHKCECIKK, int NHGGNECJEKA, bool GPBBFCEEIJK, string NPPAINEDAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCB50", Offset = "0x4ADBF50", VA = "0x184ADCB50")]
		public int NAABKICBJIP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCAD0", Offset = "0x4ADBED0", VA = "0x184ADCAD0")]
		public int HODGONFEAHH(int PPNKAJEMKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCAF0", Offset = "0x4ADBEF0", VA = "0x184ADCAF0")]
		public double KMKEKNJHHOD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCBA0", Offset = "0x4ADBFA0", VA = "0x184ADCBA0")]
		public CIMHAADDOFH PBDAOFENPIJ(long CPENMBOOOAB, int NHGGNECJEKA)
		{
			return default(CIMHAADDOFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class OLALGCKMEOA : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct LEMPHPLHFPI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public OLALGCKMEOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<OLALGCKMEOA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private OLALGCKMEOA <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3976720", Offset = "0x3975B20", VA = "0x183976720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x38E7900", Offset = "0x38E6D00", VA = "0x1838E7900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey KHCAJFNIBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly CBIPFMDCEHJ<TKey> GJEJDECMIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly FBKCBHAMJJJ AMAPEJENOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<OLALGCKMEOA> HOFICJNFENJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ENOELBBBODJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3CF64C0", Offset = "0x3CF58C0", VA = "0x183CF64C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<OLALGCKMEOA> APDMNNGBLFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3CF6520", Offset = "0x3CF5920", VA = "0x183CF6520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public CIMHAADDOFH JDIPHEKIKAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3CF62A0", Offset = "0x3CF56A0", VA = "0x183CF62A0")]
			[CompilerGenerated]
			get
			{
				return default(CIMHAADDOFH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3CF64F0", Offset = "0x3CF58F0", VA = "0x183CF64F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6560", Offset = "0x3CF5960", VA = "0x183CF6560")]
		internal OLALGCKMEOA(CBIPFMDCEHJ<TKey> GJEJDECMIMK, TKey DGCJCBHPPBD, FBKCBHAMJJJ AMAPEJENOPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6140", Offset = "0x3CF5540", VA = "0x183CF6140")]
		public OLALGCKMEOA BCNHCCLALIL(TKey DGCJCBHPPBD, [Optional] FBKCBHAMJJJ? CDMBHGPOEOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x22D7EF0", Offset = "0x22D72F0", VA = "0x1822D7EF0")]
		[AsyncStateMachine(typeof(LEMPHPLHFPI<>))]
		public Task<T> IMCAGMBJJPE<T>(TKey DGCJCBHPPBD, Func<OLALGCKMEOA, Task<T>> KFFHOADAOLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CF62C0", Offset = "0x3CF56C0", VA = "0x183CF62C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class AILHMBOMIFO : IEnumerable<(TKey, List<TKey>, CIMHAADDOFH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CIMHAADDOFH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, CIMHAADDOFH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CBIPFMDCEHJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, CIMHAADDOFH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CIMHAADDOFH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x34A92C0", Offset = "0x34A86C0", VA = "0x1834A92C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CIMHAADDOFH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x34A9340", Offset = "0x34A8740", VA = "0x1834A9340", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x34A93A0", Offset = "0x34A87A0", VA = "0x1834A93A0")]
		[DebuggerHidden]
		public AILHMBOMIFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x303E010", Offset = "0x303D410", VA = "0x18303E010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x34A8E60", Offset = "0x34A8260", VA = "0x1834A8E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x34A8E10", Offset = "0x34A8210", VA = "0x1834A8E10")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x34A92F0", Offset = "0x34A86F0", VA = "0x1834A92F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x34A9200", Offset = "0x34A8600", VA = "0x1834A9200", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CIMHAADDOFH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x32CE540", Offset = "0x32CD940", VA = "0x1832CE540", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GBPJAGIGCOD : IEnumerable<(TKey, List<TKey>, CIMHAADDOFH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CIMHAADDOFH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, CIMHAADDOFH timerEntry) <>2__current;

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
		private OLALGCKMEOA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OLALGCKMEOA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CBIPFMDCEHJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<OLALGCKMEOA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, CIMHAADDOFH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, CIMHAADDOFH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x34A92C0", Offset = "0x34A86C0", VA = "0x1834A92C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CIMHAADDOFH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x34AB9E0", Offset = "0x34AADE0", VA = "0x1834AB9E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x34A93A0", Offset = "0x34A87A0", VA = "0x1834A93A0")]
		[DebuggerHidden]
		public GBPJAGIGCOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x34ABA40", Offset = "0x34AAE40", VA = "0x1834ABA40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x34AB0D0", Offset = "0x34AA4D0", VA = "0x1834AB0D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x34AB070", Offset = "0x34AA470", VA = "0x1834AB070")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x34AB010", Offset = "0x34AA410", VA = "0x1834AB010")]
		private void CLLKEDEGMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x34AB990", Offset = "0x34AAD90", VA = "0x1834AB990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x34AB880", Offset = "0x34AAC80", VA = "0x1834AB880", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CIMHAADDOFH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x34AB960", Offset = "0x34AAD60", VA = "0x1834AB960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, CIMHAADDOFH, FBKCBHAMJJJ> CLOKKGKDMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, CIMHAADDOFH, FBKCBHAMJJJ> AFKBBBLGPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<CBIPFMDCEHJ<TKey>, FBKCBHAMJJJ> ANGAHHCPMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OLALGCKMEOA CJHFEAKAADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool GIAGFMCPJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int BIFPJGOJOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch PJKOODCNLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int ONFIGGNJIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string KOOGBGMOCNB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OLALGCKMEOA ENDKALNNLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string ENOELBBBODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7610E0", Offset = "0x7604E0", VA = "0x1807610E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4AADFA0", Offset = "0x4AAD3A0", VA = "0x184AADFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE160", Offset = "0x4AAD560", VA = "0x184AAE160")]
	public CBIPFMDCEHJ(TKey DCGAIPJHGDG, FBKCBHAMJJJ AMAPEJENOPH, [Optional] int? BMEHKCECIKK, [Optional][CanBeNull] Stopwatch PJKOODCNLAH, [Optional] Action<TKey, CIMHAADDOFH, FBKCBHAMJJJ> CLOKKGKDMHP, [Optional] Action<TKey, CIMHAADDOFH, FBKCBHAMJJJ> AFKBBBLGPEB, [Optional] Action<CBIPFMDCEHJ<TKey>, FBKCBHAMJJJ> ANGAHHCPMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4AADF10", Offset = "0x4AAD310", VA = "0x184AADF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE000", Offset = "0x4AAD400", VA = "0x184AAE000")]
	[IteratorStateMachine(typeof(CBIPFMDCEHJ<>.AILHMBOMIFO))]
	public IEnumerable<(TKey, List<TKey>, CIMHAADDOFH)> PGDNMLHHKCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE090", Offset = "0x4AAD490", VA = "0x184AAE090")]
	[IteratorStateMachine(typeof(CBIPFMDCEHJ<>.GBPJAGIGCOD))]
	private IEnumerable<(TKey, List<TKey>, CIMHAADDOFH)> PGDNMLHHKCF(List<TKey> MLDHHBJPPMF, OLALGCKMEOA IHCPIIIFHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4AADE90", Offset = "0x4AAD290", VA = "0x184AADE90")]
	private (long, int) AFLPCLGAGGD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class HNEGLOLBIPM<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JAGGCGLLFDH(CBIPFMDCEHJ<TKey> GJEJDECMIMK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected HNEGLOLBIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class ICLBGICNKKH<TKey> : HNEGLOLBIPM<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string DNKLGPFPEPG(TKey DGCJCBHPPBD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3615FC0", Offset = "0x36153C0", VA = "0x183615FC0")]
	private static string MOIEAMALHBO(TKey DGCJCBHPPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3615DB0", Offset = "0x36151B0", VA = "0x183615DB0", Slot = "4")]
	public override string JAGGCGLLFDH(CBIPFMDCEHJ<TKey> GJEJDECMIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3615E70", Offset = "0x3615270", VA = "0x183615E70")]
	public string JAGGCGLLFDH(CBIPFMDCEHJ<TKey> GJEJDECMIMK, [NotNull] DNKLGPFPEPG APCHMKFPHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KJJCLCFCKOP(CBIPFMDCEHJ<TKey> GJEJDECMIMK, [NotNull] DNKLGPFPEPG APCHMKFPHEE);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3459D50", Offset = "0x3459150", VA = "0x183459D50")]
	protected ICLBGICNKKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class EKEBFOCHABH<TKey> : HNEGLOLBIPM<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string ICKDOGMOFBN(TKey DGCJCBHPPBD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string DALCAGECBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double LEOMFCNCFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool KALNDNPMJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int JOIEBBNGEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> JLHPHPELBGM;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3077190", Offset = "0x3076590", VA = "0x183077190")]
	private static string MOIEAMALHBO(TKey DGCJCBHPPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x30771D0", Offset = "0x30765D0", VA = "0x1830771D0")]
	public EKEBFOCHABH(string DALCAGECBBO = "F2", double LEOMFCNCFJI = double.MaxValue, bool KALNDNPMJPD = false, int JOIEBBNGEDG = int.MaxValue, [Optional] ISet<string> JLHPHPELBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3076C50", Offset = "0x3076050", VA = "0x183076C50", Slot = "4")]
	public override Dictionary<string, string> JAGGCGLLFDH(CBIPFMDCEHJ<TKey> GJEJDECMIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3076D10", Offset = "0x3076110", VA = "0x183076D10")]
	private bool KIPAJEBKGAC(string GODABLIHFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3076660", Offset = "0x3075A60", VA = "0x183076660")]
	public Dictionary<string, string> JAGGCGLLFDH(CBIPFMDCEHJ<TKey> GJEJDECMIMK, ICKDOGMOFBN APCHMKFPHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3076F50", Offset = "0x3076350", VA = "0x183076F50")]
	private string MABBFOJPJFC(StringBuilder BNKKCHNMBGC, List<TKey> LODDEGFPLIM, ICKDOGMOFBN APCHMKFPHEE, bool GGONBKCDEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3076DF0", Offset = "0x30761F0", VA = "0x183076DF0")]
	private static void LHMFMKNPDFE(StringBuilder NCEKDJPDDMO, string CCLKECMAANO, bool POABBBNMFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KODNPEMPBPJ<TKey> : ICLBGICNKKH<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HDELJDIFCMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DNKLGPFPEPG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static KODNPEMPBPJ<TKey> PFONNHJIIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] NIAMOJCOBGH;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x38FD2A0", Offset = "0x38FC6A0", VA = "0x1838FD2A0")]
	private KODNPEMPBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x38FC330", Offset = "0x38FB730", VA = "0x1838FC330", Slot = "5")]
	protected override string KJJCLCFCKOP(CBIPFMDCEHJ<TKey> GJEJDECMIMK, DNKLGPFPEPG APCHMKFPHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x38FC240", Offset = "0x38FB640", VA = "0x1838FC240")]
	[CompilerGenerated]
	internal static string JBFKNBOMPJC(string IMAOPBDIBNK, TKey DGCJCBHPPBD, HDELJDIFCMF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KJHKPCNAFOM : CBIPFMDCEHJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class HAABKFFDGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<KJHKPCNAFOM, FBKCBHAMJJJ> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public HAABKFFDGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5C50DA0", Offset = "0x5C501A0", VA = "0x185C50DA0")]
		internal void AIMEFNDNJOD(CBIPFMDCEHJ<string> timer, FBKCBHAMJJJ log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5C51040", Offset = "0x5C50440", VA = "0x185C51040")]
	public KJHKPCNAFOM(FBKCBHAMJJJ AMAPEJENOPH, [Optional] string DJJEDKNPFDD, [Optional] int? BMEHKCECIKK, [Optional] Stopwatch PJKOODCNLAH, [Optional] Action<string, CIMHAADDOFH, FBKCBHAMJJJ> CLOKKGKDMHP, [Optional] Action<string, CIMHAADDOFH, FBKCBHAMJJJ> AFKBBBLGPEB, [Optional] Action<KJHKPCNAFOM, FBKCBHAMJJJ> ANGAHHCPMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5C50F80", Offset = "0x5C50380", VA = "0x185C50F80")]
	private static Action<CBIPFMDCEHJ<string>, FBKCBHAMJJJ> GIJDCODADPL(Action<KJHKPCNAFOM, FBKCBHAMJJJ> IOKENELNCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class BIDCCFCPOCC
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class IEDCMCIOJDB : BIDCCFCPOCC
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static BIDCCFCPOCC PFONNHJIIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5C50E30", Offset = "0x5C50230", VA = "0x185C50E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float AHGPHICPFEO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C385A0", Offset = "0x1C379A0", VA = "0x181C385A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5C50F30", Offset = "0x5C50330", VA = "0x185C50F30")]
		public IEDCMCIOJDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static BIDCCFCPOCC DPAJIKGPKAC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static BIDCCFCPOCC BDJLOIHNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5C4FDC0", Offset = "0x5C4F1C0", VA = "0x185C4FDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float AHGPHICPFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected BIDCCFCPOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MCKAGAHGCJH : FCEIGPEFNCA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5C51260", Offset = "0x5C50660", VA = "0x185C51260")]
	public MCKAGAHGCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FCEIGPEFNCA<T> : EJOGLAHGLBK<T>, EFEAIAAGJLL, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> FBKGLFOMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OCKEEDNGMLO<T> GAPDMCCKMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x33BF220", Offset = "0x33BE620", VA = "0x1833BF220")]
	public FCEIGPEFNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CBIGABJAIKN<T> : EJOGLAHGLBK<T>, EFEAIAAGJLL, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> FBKGLFOMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public OCKEEDNGMLO<T> GAPDMCCKMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4AADD70", Offset = "0x4AAD170", VA = "0x184AADD70")]
	public CBIGABJAIKN(Exception LCLIHGHPJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EFEAIAAGJLL : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EJOGLAHGLBK<T> : EFEAIAAGJLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> FBKGLFOMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	OCKEEDNGMLO<T> GAPDMCCKMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class BCOEGDOMJOB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool CGEEMNNPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5C4FCC0", Offset = "0x5C4F0C0", VA = "0x185C4FCC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5C4FC60", Offset = "0x5C4F060", VA = "0x185C4FC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FD10", Offset = "0x5C4F110", VA = "0x185C4FD10")]
	static BCOEGDOMJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected BCOEGDOMJOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class KIKNGLJGNGH<TTask, T> : BCOEGDOMJOB, EJOGLAHGLBK<T>, EFEAIAAGJLL, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NIPJAIJDMEL
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
			public NIPJAIJDMEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6330", Offset = "0x2EB5730", VA = "0x182EB6330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2EB68A0", Offset = "0x2EB5CA0", VA = "0x182EB68A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public KIKNGLJGNGH<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NIPJAIJDMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F900", Offset = "0x3C0ED00", VA = "0x183C0F900")]
		[AsyncStateMachine(typeof(KIKNGLJGNGH<, >.NIPJAIJDMEL.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> EEJHEMAPEIM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> FODAKAIIBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource HGNKABNPMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool GIAGFMCPJPC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> FBKGLFOMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OCKEEDNGMLO<T> GAPDMCCKMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x38E7370", Offset = "0x38E6770", VA = "0x1838E7370")]
	protected KIKNGLJGNGH(TTask FODAKAIIBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x38E7130", Offset = "0x38E6530", VA = "0x1838E7130", Slot = "1")]
	~KIKNGLJGNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x38E7110", Offset = "0x38E6510", VA = "0x1838E7110", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x38E6FA0", Offset = "0x38E63A0", VA = "0x1838E6FA0")]
	private void DGELADFNLFA(bool CFMAKAMOIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OPJJOAIBEHF(TTask NLGNNFENANM);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HNBCNNKPMBD();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GDFKGDJMLJC
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5C50CC0", Offset = "0x5C500C0", VA = "0x185C50CC0")]
	[NotNull]
	public static byte[] LEMCLMINPEE(this BFIOLPAACED CHFLBHLDMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5C50D30", Offset = "0x5C50130", VA = "0x185C50D30")]
	[NotNull]
	public static byte[] LEMCLMINPEE(this BFIOLPAACED CHFLBHLDMPP, HashAlgorithmName EEJPJELDACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5C50B30", Offset = "0x5C4FF30", VA = "0x185C50B30")]
	public static bool LCIEHNKBGCM([CanBeNull] this BFIOLPAACED CHFLBHLDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5C50990", Offset = "0x5C4FD90", VA = "0x185C50990")]
	public static bool LCIEHNKBGCM([CanBeNull] this BFIOLPAACED CHFLBHLDMPP, [Out] string GHNPOMJGELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5C50870", Offset = "0x5C4FC70", VA = "0x185C50870")]
	private static bool AJNHGBFPCCL([NotNull] BFIOLPAACED CHFLBHLDMPP, [Out][CanBeNull] byte[] JPLBEBBFDIP, [Out][CanBeNull] byte[] INMCHJEMBAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FEKAKIDBCLB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5C505B0", Offset = "0x5C4F9B0", VA = "0x185C505B0")]
	[NotNull]
	public static byte[] LEMCLMINPEE(this KHOHKGBAGLD EPHBBMEMFCD, HashAlgorithmName EEJPJELDACG, byte[] ECCPKACLDMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KHOHKGBAGLD
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash KKHNLPKBFJI);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BFIOLPAACED : KHOHKGBAGLD
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] JHIPGBGEBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] HAPMNIFJIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ONMLGFAMOBM
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> JABCNJJOCDH;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool JHABJBPAJMO;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5C52DF0", Offset = "0x5C521F0", VA = "0x185C52DF0")]
	public static void NIGPAOOKNHL(this IncrementalHash BMHEDOIGNGD, [CanBeNull] GameObject IPAGFDLNMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2506690", Offset = "0x2505A90", VA = "0x182506690")]
	public static void NIGPAOOKNHL<T>(this IncrementalHash BMHEDOIGNGD, [CanBeNull] T NCKHGGMLODI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2505AB0", Offset = "0x2504EB0", VA = "0x182505AB0")]
	public static void DACMJLOIFHN<T>(this IncrementalHash BMHEDOIGNGD, [CanBeNull] T EPHBBMEMFCD) where T : KHOHKGBAGLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2506170", Offset = "0x2505570", VA = "0x182506170")]
	public static void MBBKLMMEHCF<T>(this IncrementalHash BMHEDOIGNGD, [CanBeNull] IList<T> FFNGLJCOEHJ) where T : KHOHKGBAGLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5C52890", Offset = "0x5C51C90", VA = "0x185C52890")]
	private static bool HAFJEPOADAE([CanBeNull] KHOHKGBAGLD EPHBBMEMFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5C52920", Offset = "0x5C51D20", VA = "0x185C52920")]
	public static void IOFCMALIIBI(this IncrementalHash KKHNLPKBFJI, [CanBeNull] string KIMFBIOGAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5C526C0", Offset = "0x5C51AC0", VA = "0x185C526C0")]
	public static void GKKCCMPJOOB(this IncrementalHash KKHNLPKBFJI, long DCKJEKAIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5C52490", Offset = "0x5C51890", VA = "0x185C52490")]
	public static void ENCKBMONLMG(this IncrementalHash KKHNLPKBFJI, int EIEDKPANMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5C52260", Offset = "0x5C51660", VA = "0x185C52260")]
	public static void AHOIMHOIGHJ(this IncrementalHash KKHNLPKBFJI, short IMIDPKAKMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5C529E0", Offset = "0x5C51DE0", VA = "0x185C529E0")]
	public static void JJNCOMPNNOG(this IncrementalHash KKHNLPKBFJI, byte BPDFADADKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5C52B50", Offset = "0x5C51F50", VA = "0x185C52B50")]
	public static void KMEHDMNEMNC(this IncrementalHash KKHNLPKBFJI, bool JIAJGCEJJGJ, bool FBPOHGKPIJN = false, bool FDABGMECKGK = false, bool DCJMEAMAEDI = false, bool AIDAILLJIOJ = false, bool OBBKFJNHDOJ = false, bool CGMCCPIMNFF = false, bool NGLPGEIACCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2505B40", Offset = "0x2504F40", VA = "0x182505B40")]
	public static void LMDEJANIIEP<T>(this IncrementalHash KKHNLPKBFJI, T EMGLDFIGDIG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5C52AF0", Offset = "0x5C51EF0", VA = "0x185C52AF0")]
	public static void JKOEMEINCFG(this IncrementalHash KKHNLPKBFJI, float BOCLCOMIDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5C52430", Offset = "0x5C51830", VA = "0x185C52430")]
	public static void CPMKCIDMEKJ(this IncrementalHash KKHNLPKBFJI, ulong FLCBEOKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5C52980", Offset = "0x5C51D80", VA = "0x185C52980")]
	public static void JFEKAADJNJB(this IncrementalHash KKHNLPKBFJI, uint OFEDHDBIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5C52660", Offset = "0x5C51A60", VA = "0x185C52660")]
	public static void EPMEDGJBEEL(this IncrementalHash KKHNLPKBFJI, ushort PGOHJCJNFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5C52CC0", Offset = "0x5C520C0", VA = "0x185C52CC0")]
	public static void NGKKLGDOFDM(this IncrementalHash KKHNLPKBFJI, Vector3 EOJGOAIIOHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MDMADKAFINC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5C512A0", Offset = "0x5C506A0", VA = "0x185C512A0")]
	public MDMADKAFINC(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class KKKHGOAJHHD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class KDMLFIHGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode LDMHFMNLDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode EBFCMPBKGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public OKLGGLIMIDN FODBLBFAJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<OKLGGLIMIDN> EJGBNDHOFBA;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public KDMLFIHGFON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct OKLGGLIMIDN : IComparable<OKLGGLIMIDN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int AAEOMDCOKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant BOEGLLFOBCI;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAE29E0", Offset = "0xAE1DE0", VA = "0x180AE29E0")]
		public OKLGGLIMIDN(int AAEOMDCOKDH, TClaimant BOEGLLFOBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5FE0", Offset = "0x3CF53E0", VA = "0x183CF5FE0")]
		public bool FELNMEKNEKB([In] OKLGGLIMIDN LJIBJAOOGGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6040", Offset = "0x3CF5440", VA = "0x183CF6040")]
		public bool OHDFKFCMIGK([In] OKLGGLIMIDN LJIBJAOOGGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5FD0", Offset = "0x3CF53D0", VA = "0x183CF5FD0", Slot = "4")]
		public int CompareTo(OKLGGLIMIDN LJIBJAOOGGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6050", Offset = "0x3CF5450", VA = "0x183CF6050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum NIECMGAAMIK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LPOBJKHMKDN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public KKKHGOAJHHD<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
		[DebuggerHidden]
		public LPOBJKHMKDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3996FB0", Offset = "0x39963B0", VA = "0x183996FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3997170", Offset = "0x3996570", VA = "0x183997170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3997090", Offset = "0x3996490", VA = "0x183997090", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x32C6FE0", Offset = "0x32C63E0", VA = "0x1832C6FE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly CDDHGBHMLIB<KDMLFIHGFON> DCKFPECAFAP;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly CDDHGBHMLIB<List<OKLGGLIMIDN>> JMDBIFICBBI;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int KELJLCFLADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> CHNICCLPDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, KDMLFIHGFON> KFLNCJPJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NIECMGAAMIK DGDIMEGBJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OBHLIPJDBGF(TNode OMFNHGCDBFM);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void PJIKMNPIAIJ(TNode OMFNHGCDBFM, TClaimant AHMIJKDNLEI, TClaimant JFBLCONHBEC);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x38F94C0", Offset = "0x38F88C0", VA = "0x1838F94C0")]
	public KKKHGOAJHHD(NIECMGAAMIK DGDIMEGBJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x38F8520", Offset = "0x38F7920", VA = "0x1838F8520")]
	public void EDBHLNDEMMB(TNode OMFNHGCDBFM, TNode JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x38F8BD0", Offset = "0x38F7FD0", VA = "0x1838F8BD0")]
	public void MFFEIFPIBEC(TClaimant BOEGLLFOBCI, TNode KLMAMNOPKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38F8010", Offset = "0x38F7410", VA = "0x1838F8010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x38F8CF0", Offset = "0x38F80F0", VA = "0x1838F8CF0")]
	private void MFHJFGJIPDE(TClaimant BOEGLLFOBCI, TNode FHMGGAOBPAO, TNode KLMAMNOPKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x38F8EC0", Offset = "0x38F82C0", VA = "0x1838F8EC0")]
	private int NEOCCHBJBPB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x38F81E0", Offset = "0x38F75E0", VA = "0x1838F81E0")]
	private void ECOPNMBLIGH(TClaimant BOEGLLFOBCI, TNode NJFGDIGOAJH, TNode MGPFGPKIGND, int HNGOMHGEAKK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38F7EA0", Offset = "0x38F72A0", VA = "0x1838F7EA0")]
	private void CLCCKBCCHMJ(OKLGGLIMIDN AIIBNJNPKNP, KDMLFIHGFON KPELGHNGAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x38F9020", Offset = "0x38F8420", VA = "0x1838F9020")]
	private void OOINPEGMIBO(TClaimant BOEGLLFOBCI, TNode NJFGDIGOAJH, TNode MGPFGPKIGND, int HNGOMHGEAKK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38F7CA0", Offset = "0x38F70A0", VA = "0x1838F7CA0")]
	private void AIJPLMCOHPG(OKLGGLIMIDN AIIBNJNPKNP, TNode OMFNHGCDBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38F7DB0", Offset = "0x38F71B0", VA = "0x1838F7DB0")]
	private void CCDAMHFIDMJ(OKLGGLIMIDN AIIBNJNPKNP, KDMLFIHGFON KPELGHNGAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x38F8D90", Offset = "0x38F8190", VA = "0x1838F8D90")]
	private void MOAOIBKGPKN(KDMLFIHGFON KPELGHNGAAC, bool GDJGPBIFALD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x38F85B0", Offset = "0x38F79B0", VA = "0x1838F85B0")]
	private void HIKOPHFKFPL(KDMLFIHGFON KPELGHNGAAC, TNode JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x38F7F30", Offset = "0x38F7330", VA = "0x1838F7F30")]
	[IteratorStateMachine(typeof(KKKHGOAJHHD<, >.LPOBJKHMKDN))]
	private IEnumerable<TNode> DLCNLCFJEAG(TNode NJFGDIGOAJH, TNode MGPFGPKIGND, bool FEDMONJGNMG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x38F8F30", Offset = "0x38F8330", VA = "0x1838F8F30")]
	private KDMLFIHGFON NFOLNLGIHLB(TNode OMFNHGCDBFM, TNode EBFCMPBKGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x38F88F0", Offset = "0x38F7CF0", VA = "0x1838F88F0")]
	private KDMLFIHGFON IPMFLKNCPCM(TNode OMFNHGCDBFM, TNode EBFCMPBKGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x38F8A60", Offset = "0x38F7E60", VA = "0x1838F8A60")]
	private void KCDGNKBLEDA(KDMLFIHGFON KPELGHNGAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DEDJOEIICFO<T> : IEnumerable<DEDJOEIICFO<T>.KDDNJMCPDNB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct KDDNJMCPDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T EOHMJBFGDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int APOENOPNHBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GKKOCKLNOHI : IEnumerator<KDDNJMCPDNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private DEDJOEIICFO<T> DGBALLFIAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int APOENOPNHBG;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3098ED0", Offset = "0x30982D0", VA = "0x183098ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public KDDNJMCPDNB PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x34CA070", Offset = "0x34C9470", VA = "0x1834CA070", Slot = "4")]
			get
			{
				return default(KDDNJMCPDNB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x34CA030", Offset = "0x34C9430", VA = "0x1834CA030")]
		public GKKOCKLNOHI(DEDJOEIICFO<T> DGBALLFIAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x34C9F30", Offset = "0x34C9330", VA = "0x1834C9F30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30E9640", Offset = "0x30E8A40", VA = "0x1830E9640", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1A4A7F0", Offset = "0x1A49BF0", VA = "0x181A4A7F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct FHGBMNHJNCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool ADJKFCKJCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T EOHMJBFGDPD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int MDGFFGMCAPH = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> ICGFFGOKPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private FHGBMNHJNCL[] GHFNKIGFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int GDDIBCHMNPL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KIFDEFCEGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x79E250", Offset = "0x79D650", VA = "0x18079E250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x79DE80", Offset = "0x79D280", VA = "0x18079DE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC5430", VA = "0x182EC6030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4C83270", Offset = "0x4C82670", VA = "0x184C83270")]
	public DEDJOEIICFO(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4C83350", Offset = "0x4C82750", VA = "0x184C83350")]
	public DEDJOEIICFO(KDDNJMCPDNB[] EDKBJECENNI, bool OENJMIKAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4C82F30", Offset = "0x4C82330", VA = "0x184C82F30")]
	public int HCBJMCHLKML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4C82A50", Offset = "0x4C81E50", VA = "0x184C82A50")]
	private int BJKAKNDEDGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4C82E60", Offset = "0x4C82260", VA = "0x184C82E60", Slot = "6")]
	protected virtual uint DINNNCCOFNK(uint KKHNLPKBFJI, T EOHMJBFGDPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4C83010", Offset = "0x4C82410", VA = "0x184C83010")]
	public bool MANMFMMONAK(T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4C83120", Offset = "0x4C82520", VA = "0x184C83120")]
	public int PPEJMPNGEON(T EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4C830B0", Offset = "0x4C824B0", VA = "0x184C830B0")]
	public T OGKFNGNICOC(int APOENOPNHBG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4C827A0", Offset = "0x4C81BA0", VA = "0x184C827A0")]
	public bool AHLOGHJFIBI(T EOHMJBFGDPD, bool JMJKAGDCIJG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4C82540", Offset = "0x4C81940", VA = "0x184C82540")]
	public bool AHLOGHJFIBI(T EOHMJBFGDPD, int APOENOPNHBG, bool JMJKAGDCIJG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4C82E90", Offset = "0x4C82290", VA = "0x184C82E90")]
	private int EMAEKEOMDKG(int IDGHKCPGHHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4C831F0", Offset = "0x4C825F0", VA = "0x184C831F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4C831F0", Offset = "0x4C825F0", VA = "0x184C831F0", Slot = "4")]
	private IEnumerator<KDDNJMCPDNB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CDDHGBHMLIB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> ENDDFGMOCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> MPFFFPHJCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int OMJCIGIADJC;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4AB86D0", Offset = "0x4AB7AD0", VA = "0x184AB86D0")]
	public static CDDHGBHMLIB<T> FMGIBHBFOKA(int OOIJDECJBIB = 0, int OMJCIGIADJC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8C20", Offset = "0x4AB8020", VA = "0x184AB8C20")]
	public CDDHGBHMLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8A80", Offset = "0x4AB7E80", VA = "0x184AB8A80")]
	public CDDHGBHMLIB(int OOIJDECJBIB, int OMJCIGIADJC = int.MaxValue, bool FAHPBBKOMJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8530", Offset = "0x4AB7930", VA = "0x184AB8530")]
	public T EGIAKDPNIKC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4AB87B0", Offset = "0x4AB7BB0", VA = "0x184AB87B0")]
	public void NPAMHCDPFNF(T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8310", Offset = "0x4AB7710", VA = "0x184AB8310")]
	private void CKIPDBJBJPC(T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4AB86B0", Offset = "0x4AB7AB0", VA = "0x184AB86B0")]
	private void FKCDGIONFAN(T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4AB83F0", Offset = "0x4AB77F0", VA = "0x184AB83F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8880", Offset = "0x4AB7C80", VA = "0x184AB8880")]
	private void OAHIINOFCGD(IEnumerable<T> PKDIDJEMOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EPNMAKCJKFD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> FBGCPGFLOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T FDHKHHMMJJI;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T LGGKBCENJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3092A70", Offset = "0x3091E70", VA = "0x183092A70")]
	public bool PEDOEOJDAHD(T EOHMJBFGDPD, int AAEOMDCOKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3092800", Offset = "0x3091C00", VA = "0x183092800")]
	public bool CIGINBBBHMP(int AAEOMDCOKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3092B60", Offset = "0x3091F60", VA = "0x183092B60")]
	public T PGBMOLOMBIJ(int MMDACHAJDKI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3092870", Offset = "0x3091C70", VA = "0x183092870")]
	private bool HJAOICKGKNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3092A20", Offset = "0x3091E20", VA = "0x183092A20")]
	public bool IEDNKFHOGLK(int AAEOMDCOKDH, [Out] T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3092F40", Offset = "0x3092340", VA = "0x183092F40")]
	public EPNMAKCJKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LAJMABMAEFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct MNJNLOMLKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T DFNAILAPHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int EHANHPKKDIJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<MNJNLOMLKIJ> GMPPMJJPOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T GFKOFCILIHC;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC5430", VA = "0x182EC6030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x396D320", Offset = "0x396C720", VA = "0x18396D320")]
	public bool GPJELEPHCCH(T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x396D4A0", Offset = "0x396C8A0", VA = "0x18396D4A0")]
	public void INMJBKGEACO(T EOHMJBFGDPD, int AAEOMDCOKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x396D170", Offset = "0x396C570", VA = "0x18396D170")]
	public bool BLFHNKIOGCM(T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x396D2C0", Offset = "0x396C6C0", VA = "0x18396D2C0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x396D6A0", Offset = "0x396CAA0", VA = "0x18396D6A0")]
	public T MLDLMPNMGKK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x396D540", Offset = "0x396C940", VA = "0x18396D540")]
	private void MELPJDHBMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x396D720", Offset = "0x396CB20", VA = "0x18396D720")]
	public LAJMABMAEFF()
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
		[BCMNMDCFIOE(DGGKPPHNIIC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5C53290", Offset = "0x5C52690", VA = "0x185C53290")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5C53560", Offset = "0x5C52960", VA = "0x185C53560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C53470", Offset = "0x5C52870", VA = "0x185C53470")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C531E0", Offset = "0x5C525E0", VA = "0x185C531E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5C534B0", Offset = "0x5C528B0", VA = "0x185C534B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5C533C0", Offset = "0x5C527C0", VA = "0x185C533C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C53150", Offset = "0x5C52550", VA = "0x185C53150")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FA4ED0", Offset = "0x3FA42D0", VA = "0x183FA4ED0", Slot = "4")]
		public virtual T GEFHMDIMGIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class ONHNMECAFOH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, EPJODBLPJHK> KJLAAACNJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly CDDHGBHMLIB<EPJODBLPJHK> CKPLEEAGMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool KPDCDKCMILP;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public EPJODBLPJHK ACJIEGPFLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 AJEHFIBFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA333D0", Offset = "0xA327D0", VA = "0x180A333D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD2B4E0", Offset = "0xD2A8E0", VA = "0x180D2B4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 IKPECPJFAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xD76A80", Offset = "0xD75E80", VA = "0x180D76A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 GNFCPOHPEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C51300", Offset = "0x5C50700", VA = "0x185C51300")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x75C590", Offset = "0x75B990", VA = "0x18075C590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int LOHEICEHPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x764F00", Offset = "0x764300", VA = "0x180764F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x764B60", Offset = "0x763F60", VA = "0x180764B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C51DD0", Offset = "0x5C511D0", VA = "0x185C51DD0")]
	public ONHNMECAFOH(Bounds DMPFJEDBPMP, Vector2[] ILBNEKNBNIF, int EPCKAENAOGN, byte IDGHKCPGHHK, float HHKCFHHHLKE = 0f, [Optional] CDDHGBHMLIB<EPJODBLPJHK> CKPLEEAGMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5C51A60", Offset = "0x5C50E60", VA = "0x185C51A60")]
	public EPJODBLPJHK JIFMOBIDLBK(byte APOENOPNHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5C51320", Offset = "0x5C50720", VA = "0x185C51320")]
	public void DCGLMJGNCKJ(Vector3 LPAPEIIOLFG, float BBLBAKNGGKC, float HLLIGIFBBKH, List<byte> FAHEKBFGBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A3F150", Offset = "0x1A3E550", VA = "0x181A3F150")]
	public void IAGMFNPLIIA(EPJODBLPJHK.IGHDPIPHBOL BPDOBOFGHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C51AC0", Offset = "0x5C50EC0", VA = "0x185C51AC0")]
	public static int MEFMAENECGD(Vector2[] ILBNEKNBNIF, int EPCKAENAOGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C51860", Offset = "0x5C50C60", VA = "0x185C51860")]
	private EPJODBLPJHK IBKFIFIIJGK(byte APOENOPNHBG, EPJODBLPJHK.CGNLFHOMBBO CCJPNFKEIEI, EPJODBLPJHK EBFCMPBKGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5C513F0", Offset = "0x5C507F0", VA = "0x185C513F0")]
	private void DOHFHILPPGE(EPJODBLPJHK EBFCMPBKGBM, Vector2[] ILBNEKNBNIF, int INDKFLGKAKB, int FEMMADOFDOH, int CLOHLGDGKFH, int CMEKFNAHEKI, float HHKCFHHHLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C51BB0", Offset = "0x5C50FB0", VA = "0x185C51BB0")]
	private void NDAAJOJCPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5C517A0", Offset = "0x5C50BA0", VA = "0x185C517A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5C51800", Offset = "0x5C50C00", VA = "0x185C51800", Slot = "1")]
	~ONHNMECAFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EPJODBLPJHK
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum CGNLFHOMBBO
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum IGHDPIPHBOL
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
	public byte FPOLJBGEJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 PMDAKMBFFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 LMJBHMFNAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 FPIGIBMKMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 IJJACMEHMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public CGNLFHOMBBO DDGFJDFCNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EPJODBLPJHK NCEKKJFNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<EPJODBLPJHK> MAPMPJKHNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool NNNIJEICBGC;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C50590", Offset = "0x5C4F990", VA = "0x185C50590")]
	public EPJODBLPJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C503E0", Offset = "0x5C4F7E0", VA = "0x185C503E0")]
	public void FFDAFIGKKAE(EPJODBLPJHK JHAODPLJNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	public void IAGMFNPLIIA(int JJHCDEKHJPJ, IGHDPIPHBOL BPDOBOFGHML, int CDDCFIPCBGB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5C50150", Offset = "0x5C4F550", VA = "0x185C50150")]
	public void DCGLMJGNCKJ(List<byte> FAHEKBFGBIM, Vector3 LPAPEIIOLFG, float BBLBAKNGGKC, float HLLIGIFBBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5C50120", Offset = "0x5C4F520", VA = "0x185C50120")]
	public bool BLDDKKAJDGO(Vector3 GKDNLKGKKGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5C503B0", Offset = "0x5C4F7B0", VA = "0x185C503B0")]
	public bool DEPOOFADDFF(Vector3 GKDNLKGKKGN, float EGMGHEEKMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5C50500", Offset = "0x5C4F900", VA = "0x185C50500")]
	public void FGBNJEBGKMH()
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
		public struct OGCGKOCENGK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> KEKPLKHNJAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool MLCEJPHDOLE;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x395D010", Offset = "0x395C410", VA = "0x18395D010")]
			public OGCGKOCENGK(List<Component> KEKPLKHNJAG, bool MLCEJPHDOLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3CE6780", Offset = "0x3CE5B80", VA = "0x183CE6780")]
			public JGJLEABLBAJ<T> JBKAHEPNGNA()
			{
				return default(JGJLEABLBAJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3CE67F0", Offset = "0x3CE5BF0", VA = "0x183CE67F0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3CE67F0", Offset = "0x3CE5BF0", VA = "0x183CE67F0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct JGJLEABLBAJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> KEKPLKHNJAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool MLCEJPHDOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int APOENOPNHBG;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T PNJHIMNMKKP
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3838F90", Offset = "0x3838390", VA = "0x183838F90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3838F20", Offset = "0x3838320", VA = "0x183838F20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3838F60", Offset = "0x3838360", VA = "0x183838F60")]
			public JGJLEABLBAJ(List<Component> KEKPLKHNJAG, bool MLCEJPHDOLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3838E60", Offset = "0x3838260", VA = "0x183838E60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3838E70", Offset = "0x3838270", VA = "0x183838E70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x30DA3B0", Offset = "0x30D97B0", VA = "0x1830DA3B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C54950", Offset = "0x5C53D50", VA = "0x185C54950")]
		private void FGBNJEBGKMH(GameObject OCEAKGFKBEH, bool EFLODOEECNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C54AC0", Offset = "0x5C53EC0", VA = "0x185C54AC0")]
		public static void FGBNJEBGKMH(GameObject OCEAKGFKBEH, ToolHierarchyCache MKOBKFKDLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x265EF40", Offset = "0x265E340", VA = "0x18265EF40")]
		public void GANNPALKMBC<T>(Action<T> GMCEKENFDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x265F220", Offset = "0x265E620", VA = "0x18265F220")]
		public T NCPLAIDBIDN<T>(bool MLCEJPHDOLE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x265F160", Offset = "0x265E560", VA = "0x18265F160")]
		public OGCGKOCENGK<T> JAOBKLNFHCC<T>(bool MLCEJPHDOLE = false) where T : class
		{
			return default(OGCGKOCENGK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C54CF0", Offset = "0x5C540F0", VA = "0x185C54CF0")]
		public List<Component> LOFKDIEBNNG(Type IJFAMCPOKBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C548D0", Offset = "0x5C53CD0", VA = "0x185C548D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache MHJJOHHKIPH, ToolHierarchyCache DFACBIDGKFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C54C80", Offset = "0x5C54080", VA = "0x185C54C80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BAFDGKKJJJD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GDMIINBDHFM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int OOIJDECJBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int IHLABHLLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> DLBJPBJAFGL;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x303DB10", Offset = "0x303CF10", VA = "0x18303DB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T IMBJMHKHAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x34AFAC0", Offset = "0x34AEEC0", VA = "0x1834AFAC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T PDCHAHHDNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x34AFC90", Offset = "0x34AF090", VA = "0x1834AFC90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T DBIPKHAIFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x34AFEF0", Offset = "0x34AF2F0", VA = "0x1834AFEF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x34B0030", Offset = "0x34AF430", VA = "0x1834B0030")]
	public GDMIINBDHFM(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x34AFDF0", Offset = "0x34AF1F0", VA = "0x1834AFDF0")]
	public void INMJBKGEACO(T EOKLAENCFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x34AFA70", Offset = "0x34AEE70", VA = "0x1834AFA70")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x34AF9A0", Offset = "0x34AEDA0", VA = "0x1834AF9A0")]
	public void BDKIBLCJOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x34AFFD0", Offset = "0x34AF3D0", VA = "0x1834AFFD0")]
	public void NHEAGAGPCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x34AFAB0", Offset = "0x34AEEB0", VA = "0x1834AFAB0")]
	public void FCFFEJMFJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AMFIFBBMHNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct OJKLHMLBKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int EHANHPKKDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T DFNAILAPHHN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, OJKLHMLBKBB> FBGCPGFLOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> BPNCLDOMHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T FDHKHHMMJJI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T LGGKBCENJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD62290", Offset = "0xD61690", VA = "0x180D62290", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x36F8D40", Offset = "0x36F8140", VA = "0x1836F8D40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool HIDMKGNLJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x36F8EA0", Offset = "0x36F82A0", VA = "0x1836F8EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object LKHMDAJBNIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x36FC720", Offset = "0x36FBB20", VA = "0x1836FC720")]
	public bool PEDOEOJDAHD(T EOHMJBFGDPD, object KJAGMGIFCEM, int AAEOMDCOKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x36F8E10", Offset = "0x36F8210", VA = "0x1836F8E10")]
	public bool CIGINBBBHMP(object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x36FB8A0", Offset = "0x36FACA0", VA = "0x1836FB8A0")]
	public bool IEDNKFHOGLK(object KJAGMGIFCEM, [Out] T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x36F8DE0", Offset = "0x36F81E0", VA = "0x1836F8DE0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x36FAD20", Offset = "0x36FA120", VA = "0x1836FAD20")]
	private bool HJAOICKGKNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x36FCB00", Offset = "0x36FBF00", VA = "0x1836FCB00")]
	public AMFIFBBMHNN()
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
