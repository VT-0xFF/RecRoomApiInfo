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
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0BB0", Offset = "0x6FBFFB0", VA = "0x186FC0BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IIFGNFBHGOF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A29C90", Offset = "0x1A29090", VA = "0x181A29C90")]
	public IIFGNFBHGOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, EKCAKJNJLFK, ECADCDIFJOE, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash GKJBBOELMJG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x962010", Offset = "0x961410", VA = "0x180962010")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3020", Offset = "0x6FC2420", VA = "0x186FC3020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2FE0", Offset = "0x6FC23E0", VA = "0x186FC2FE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3060", Offset = "0x6FC2460", VA = "0x186FC3060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3210", Offset = "0x6FC2610", VA = "0x186FC3210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3180", Offset = "0x6FC2580", VA = "0x186FC3180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB05EB0", Offset = "0xB052B0", VA = "0x180B05EB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x97B440", Offset = "0x97A840", VA = "0x18097B440")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2FA0", Offset = "0x6FC23A0", VA = "0x186FC2FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FC30F0", Offset = "0x6FC24F0", VA = "0x186FC30F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2A40", Offset = "0x6FC1E40", VA = "0x186FC2A40")]
	public void CopyBounds(SavedExtents BMKPAKCEMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2EF0", Offset = "0x6FC22F0", VA = "0x186FC2EF0")]
	public void SetLocalSpaceBounds(Bounds FJLNPDDIPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xF82B30", Offset = "0xF81F30", VA = "0x180F82B30")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2EE0", Offset = "0x6FC22E0", VA = "0x186FC2EE0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2A70", Offset = "0x6FC1E70", VA = "0x186FC2A70")]
	private void FMMIEDBECEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2CE0", Offset = "0x6FC20E0", VA = "0x186FC2CE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2400", Offset = "0x6FC1800", VA = "0x186FC2400")]
	public static void CalculateLocalBoundsFor(GameObject MCCIFMIMANN, [Out] Bounds FJLNPDDIPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2C20", Offset = "0x6FC2020", VA = "0x186FC2C20")]
	private static void OLHJKLEDNPC(Bounds BCCGANGEINF, Color DGDCPDOCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2F10", Offset = "0x6FC2310", VA = "0x186FC2F10")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x13BE760", Offset = "0x13BDB60", VA = "0x1813BE760")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4EACCD0", Offset = "0x4EAC0D0", VA = "0x184EACCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public virtual void PNOPCJAFCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	[IIFGNFBHGOF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC7E0", Offset = "0x4EABBE0", VA = "0x184EAC7E0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAAE00", Offset = "0x4EAA200", VA = "0x184EAAE00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4EACBC0", Offset = "0x4EABFC0", VA = "0x184EACBC0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GKMKIIGHFEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GKMKIIGHFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x41A1D20", Offset = "0x41A1120", VA = "0x1841A1D20")]
		internal int JMEDCGGLFIJ(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[IIFGNFBHGOF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC060", Offset = "0x3CEB460", VA = "0x183CEC060", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC0C0", Offset = "0x3CEB4C0", VA = "0x183CEC0C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBF30", Offset = "0x3CEB330", VA = "0x183CEBF30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LDCKBFKFIKC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBFF0", Offset = "0x3CEB3F0", VA = "0x183CEBFF0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBDD0", Offset = "0x3CEB1D0", VA = "0x183CEBDD0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEBA50", Offset = "0x3CEAE50", VA = "0x183CEBA50", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CEADC0", Offset = "0x3CEA1C0", VA = "0x183CEADC0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAD90", Offset = "0x3CEA190", VA = "0x183CEAD90", Slot = "14")]
	protected virtual string KENGNCNIMHG(TKeyVal NHPNFMBOIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAC20", Offset = "0x3CEA020", VA = "0x183CEAC20", Slot = "4")]
	public bool ContainsKey(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CEBC40", Offset = "0x3CEB040", VA = "0x183CEBC40", Slot = "5")]
	public bool TryGetValue(TKey LDCKBFKFIKC, [Out] TVal HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAC80", Offset = "0x3CEA080", VA = "0x183CEAC80", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAC80", Offset = "0x3CEA080", VA = "0x183CEAC80", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CEBCA0", Offset = "0x3CEB0A0", VA = "0x183CEBCA0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x40529C0", Offset = "0x4051DC0", VA = "0x1840529C0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[IIFGNFBHGOF]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE780", Offset = "0x4EADB80", VA = "0x184EAE780")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4EADF70", Offset = "0x4EAD370", VA = "0x184EADF70", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD4B0", Offset = "0x4EAC8B0", VA = "0x184EAD4B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GNONLDKCEBC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class DBGJNIJDGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float LANPKEHMLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T GFHLLJBPNAP;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DBGJNIJDGJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BAFHBAFHMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BAFHBAFHMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x53A7480", Offset = "0x53A6880", VA = "0x1853A7480")]
		internal bool FNCIALKPILE(DBGJNIJDGJP sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float OPBOAMPBDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float DDMLKNCJOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<DBGJNIJDGJP> PEMDACAALJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private EDMMGCJIHED<DBGJNIJDGJP> EHHCNKPMACH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BJFHGBLEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41AE6B0", Offset = "0x41ADAB0", VA = "0x1841AE6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x41AF460", Offset = "0x41AE860", VA = "0x1841AF460")]
	public GNONLDKCEBC(float DOFLEBAMBGB, float ABGDEEHKDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x41AE950", Offset = "0x41ADD50", VA = "0x1841AE950")]
	public bool GKANIHNCLLP(float HCHBEBADBKN, T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41AED20", Offset = "0x41AE120", VA = "0x1841AED20")]
	public IEnumerable<T> NADNNBAIMLK(float HCHBEBADBKN, [Optional] float? CAODCPHOOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41AE5F0", Offset = "0x41AD9F0", VA = "0x1841AE5F0")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41AE790", Offset = "0x41ADB90", VA = "0x1841AE790")]
	private void DNIMDNJAMIK(float HCHBEBADBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BKBCMPGNBEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct KMFPIHFLLGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T GFHLLJBPNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float OLEJIJODNHB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float OKHJEMMECHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> NNOPFJBHKBF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int PDGEEKOFENB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KMFPIHFLLGI[] CHDCMIMONFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int IKLAFBMLHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float CKLNNEBNACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD72C20", Offset = "0xD72020", VA = "0x180D72C20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD874C0", Offset = "0xD868C0", VA = "0x180D874C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x53D9BC0", Offset = "0x53D8FC0", VA = "0x1853D9BC0")]
	public BKBCMPGNBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53D9C00", Offset = "0x53D9000", VA = "0x1853D9C00")]
	public BKBCMPGNBEA(int BGDDCGNLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53D9100", Offset = "0x53D8500", VA = "0x1853D9100")]
	public void EBDKDKCDLND(float HCHBEBADBKN, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x53D8A90", Offset = "0x53D7E90", VA = "0x1853D8A90")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x53D9910", Offset = "0x53D8D10", VA = "0x1853D9910")]
	public bool MAAPJGDKMHM(float IEEMNOBMLEO, float BMHHIINGJLA, [Out] T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x53D9440", Offset = "0x53D8840", VA = "0x1853D9440")]
	public bool FNBBNIBBOPC(float IEEMNOBMLEO, float BMHHIINGJLA, [Out] T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x53D8E20", Offset = "0x53D8220", VA = "0x1853D8E20")]
	public void DBCCDJANLDC(float IEEMNOBMLEO, float BMHHIINGJLA, List<T> CELIBNPACII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x53D9610", Offset = "0x53D8A10", VA = "0x1853D9610")]
	private int GHJAHFKNGCC(int DAAINLHLKIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x53D8FA0", Offset = "0x53D83A0", VA = "0x1853D8FA0")]
	private void DHIDCCGMGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GGFLOJBLIJL();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T DPCBCCMILLG(T HCPAOILCJCB, float OPGNNMINDKO);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CFIHMLLMPFB(T FGFJFGGJOII, T CABLGFIBABJ);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T INKDMGBLEDI(T FGFJFGGJOII, T CABLGFIBABJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IFEGLCNHNOI : BKBCMPGNBEA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8D6850", Offset = "0x8D5C50", VA = "0x1808D6850", Slot = "4")]
	protected override Vector3 GGFLOJBLIJL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE340", Offset = "0x6FBD740", VA = "0x186FBE340", Slot = "5")]
	protected override Vector3 DPCBCCMILLG(Vector3 HCPAOILCJCB, float OPGNNMINDKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE2F0", Offset = "0x6FBD6F0", VA = "0x186FBE2F0", Slot = "6")]
	protected override Vector3 CFIHMLLMPFB(Vector3 FGFJFGGJOII, Vector3 CABLGFIBABJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE380", Offset = "0x6FBD780", VA = "0x186FBE380", Slot = "7")]
	protected override Vector3 INKDMGBLEDI(Vector3 FGFJFGGJOII, Vector3 CABLGFIBABJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE400", Offset = "0x6FBD800", VA = "0x186FBE400")]
	public IFEGLCNHNOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GIPFBLICOEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x306A180", Offset = "0x3069580", VA = "0x18306A180")]
	public static LHJFFEAKJBK<T1, T2> KOPOAAAOIOD<T1, T2>(T1 EALDGOBHPCG, T2 LEPPEIHFGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x306A210", Offset = "0x3069610", VA = "0x18306A210")]
	public static AHEPBNAFEBP<T1, T2, T3> KOPOAAAOIOD<T1, T2, T3>(T1 EALDGOBHPCG, T2 LEPPEIHFGCH, T3 INAHFPPEDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AF20", Offset = "0x4A4A320", VA = "0x184A4AF20")]
	internal static int KGGOAHPIDDB(int IKNKGBOCANE, int MLFJJNHEDCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62FDBC0", Offset = "0x62FCFC0", VA = "0x1862FDBC0")]
	internal static int KGGOAHPIDDB(int IKNKGBOCANE, int MLFJJNHEDCO, int EEHPPAMHELG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LHJFFEAKJBK<T1, T2> : IComparable<LHJFFEAKJBK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 CBPHEKFKGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 CMHMGGHKDPE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x47CFC30", Offset = "0x47CF030", VA = "0x1847CFC30")]
	public LHJFFEAKJBK(T1 EALDGOBHPCG, T2 LEPPEIHFGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x47CE0E0", Offset = "0x47CD4E0", VA = "0x1847CE0E0", Slot = "4")]
	public int CompareTo(LHJFFEAKJBK<T1, T2> BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x47CE940", Offset = "0x47CDD40", VA = "0x1847CE940", Slot = "0")]
	public override bool Equals(object BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x47CF230", Offset = "0x47CE630", VA = "0x1847CF230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x47CF700", Offset = "0x47CEB00", VA = "0x1847CF700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AHEPBNAFEBP<T1, T2, T3> : IComparable<AHEPBNAFEBP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 CBPHEKFKGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 CMHMGGHKDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 BCPKHMHHKCC;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x41D6970", Offset = "0x41D5D70", VA = "0x1841D6970")]
	public AHEPBNAFEBP(T1 EALDGOBHPCG, T2 LEPPEIHFGCH, T3 INAHFPPEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x41D6130", Offset = "0x41D5530", VA = "0x1841D6130", Slot = "4")]
	public int CompareTo(AHEPBNAFEBP<T1, T2, T3> BMKPAKCEMFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x41D6290", Offset = "0x41D5690", VA = "0x1841D6290", Slot = "0")]
	public override bool Equals(object BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x41D6570", Offset = "0x41D5970", VA = "0x1841D6570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x41D66A0", Offset = "0x41D5AA0", VA = "0x1841D66A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve FBJOAMPAPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T FHKAAOJPGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x100D810", Offset = "0x100CC10", VA = "0x18100D810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T NIBIGECGCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26AEB20", Offset = "0x26ADF20", VA = "0x1826AEB20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26AEB10", Offset = "0x26ADF10", VA = "0x1826AEB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float IODMGDMLIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x933D00", Offset = "0x933100", VA = "0x180933D00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5104140", Offset = "0x5103540", VA = "0x185104140")]
	public T FDOBKLGINMC(float OPGNNMINDKO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5104660", Offset = "0x5103A60", VA = "0x185104660")]
	public T NOCCCOJCNME(float OPGNNMINDKO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BMNAODMOPBJ(T FGFJFGGJOII, T CABLGFIBABJ, float OPGNNMINDKO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE180", Offset = "0x6FBD580", VA = "0x186FBE180", Slot = "4")]
	protected override float BMNAODMOPBJ(float FGFJFGGJOII, float CABLGFIBABJ, float OPGNNMINDKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE1C0", Offset = "0x6FBD5C0", VA = "0x186FBE1C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x12526A0", Offset = "0x1251AA0", VA = "0x1812526A0", Slot = "4")]
	protected override Vector3 BMNAODMOPBJ(Vector3 FGFJFGGJOII, Vector3 CABLGFIBABJ, float OPGNNMINDKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3FE0", Offset = "0x6FC33E0", VA = "0x186FC3FE0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDE80", Offset = "0x6FBD280", VA = "0x186FBDE80", Slot = "4")]
	protected override Color BMNAODMOPBJ(Color FGFJFGGJOII, Color CABLGFIBABJ, float OPGNNMINDKO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDF40", Offset = "0x6FBD340", VA = "0x186FBDF40")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MHMFOMKLMJA : CPAFEOCNOJG<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0910", Offset = "0x6FBFD10", VA = "0x186FC0910")]
	public MHMFOMKLMJA(int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6FC08A0", Offset = "0x6FBFCA0", VA = "0x186FC08A0", Slot = "6")]
	protected override uint KKHHHHEOMBH(uint GKJBBOELMJG, string HCPAOILCJCB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EMGKCNGPLPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EMGKCNGPLPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LKBKKHPLOFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BMMFBNDHDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int LKDPAIJKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int PFNPBIIPBMJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41AE350", Offset = "0x41AD750", VA = "0x1841AE350")]
	private LKBKKHPLOFJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GCBNMHKNCLI, int LGJJEMFPICL, int FIBHIHHMBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x47DDF30", Offset = "0x47DD330", VA = "0x1847DDF30")]
	public static LKBKKHPLOFJ<T> ODOFIFAGLAJ()
	{
		return default(LKBKKHPLOFJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x47DC890", Offset = "0x47DBC90", VA = "0x1847DC890")]
	public (int, int, Task<T>) CHDPKOCNBKP(int EOMBDLJNDJM, [Optional] CancellationToken FHGIOBPPFHG, double CHFBMMDLDCL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47DD750", Offset = "0x47DCB50", VA = "0x1847DD750")]
	public void DGCLDABJAIG(int EOMBDLJNDJM, int FIBHIHHMBFF, [In] T CEDDFJCBLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FNONEFKHEJF
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE130", Offset = "0x6FBD530", VA = "0x186FBE130")]
	public static LKBKKHPLOFJ<ALHKDJHEAFJ> ODOFIFAGLAJ()
	{
		return default(LKBKKHPLOFJ<ALHKDJHEAFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE0B0", Offset = "0x6FBD4B0", VA = "0x186FBE0B0")]
	public static void DGCLDABJAIG([In] this LKBKKHPLOFJ<ALHKDJHEAFJ> MPLBPEBNKFP, int EOMBDLJNDJM, int FIBHIHHMBFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class IKDIJMPJGNI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> BHPEIGAFHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> FALPPJNLICE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x39C69D0", Offset = "0x39C5DD0", VA = "0x1839C69D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DNNGBKHPAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> CNNBDHKBDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4353770", Offset = "0x4352B70", VA = "0x184353770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HHBEAJGHAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x43537D0", Offset = "0x4352BD0", VA = "0x1843537D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4353700", Offset = "0x4352B00", VA = "0x184353700", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4353830", Offset = "0x4352C30", VA = "0x184353830", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4352E00", Offset = "0x4352200", VA = "0x184352E00")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4352B40", Offset = "0x4351F40", VA = "0x184352B40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x43534C0", Offset = "0x43528C0", VA = "0x1843534C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x43528C0", Offset = "0x4351CC0", VA = "0x1843528C0", Slot = "9")]
	public void Add(TKey LDCKBFKFIKC, TVal HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351D10", VA = "0x184352910", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4352BF0", Offset = "0x4351FF0", VA = "0x184352BF0", Slot = "8")]
	public bool ContainsKey(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4352C50", Offset = "0x4352050", VA = "0x184352C50", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4353430", Offset = "0x4352830", VA = "0x184353430", Slot = "10")]
	public bool Remove(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x43533F0", Offset = "0x43527F0", VA = "0x1843533F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4353510", Offset = "0x4352910", VA = "0x184353510", Slot = "11")]
	public bool TryGetValue(TKey LDCKBFKFIKC, [Out] TVal HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4352D60", Offset = "0x4352160", VA = "0x184352D60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4352CD0", Offset = "0x43520D0", VA = "0x184352CD0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CHDCMIMONFN, int ECPOGOHOPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x43532F0", Offset = "0x43526F0", VA = "0x1843532F0")]
	public bool LINPJOCPLAE(TVal LDCKBFKFIKC, [Out] TKey HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4352FA0", Offset = "0x43523A0", VA = "0x184352FA0")]
	private void KDODHHNDJNE(TKey LDCKBFKFIKC, TVal BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4352A40", Offset = "0x4351E40", VA = "0x184352A40")]
	private void CHMFIPNOKJO(TKey LDCKBFKFIKC, TVal BBFFJMPBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x43531C0", Offset = "0x43525C0", VA = "0x1843531C0")]
	private bool KKMAENCFFBP(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4353570", Offset = "0x4352970", VA = "0x184353570")]
	public IKDIJMPJGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class JKHNPNGLOFO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JKHNPNGLOFO<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3D3ABC0", Offset = "0x3D39FC0", VA = "0x183D3ABC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3D46080", Offset = "0x3D45480", VA = "0x183D46080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D46AF0", Offset = "0x3D45EF0", VA = "0x183D46AF0")]
		public Enumerator(JKHNPNGLOFO<T> CELIBNPACII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D44890", Offset = "0x3D43C90", VA = "0x183D44890", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D44BA0", Offset = "0x3D43FA0", VA = "0x183D44BA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D431D0", Offset = "0x3D425D0", VA = "0x183D431D0")]
		private void HNMNCKAIEIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] LBOKCPIBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int GDCLLKFPEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int ECEMMDOHBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int GKEHKEEIHAE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x458CC20", Offset = "0x458C020", VA = "0x18458CC20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x458C0E0", Offset = "0x458B4E0", VA = "0x18458C0E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x458B3B0", Offset = "0x458A7B0", VA = "0x18458B3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x458CF50", Offset = "0x458C350", VA = "0x18458CF50")]
	public JKHNPNGLOFO(int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x458AC60", Offset = "0x458A060", VA = "0x18458AC60")]
	public void EBDKDKCDLND(T OPGNNMINDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x458AC40", Offset = "0x458A040", VA = "0x18458AC40")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x458C3C0", Offset = "0x458B7C0", VA = "0x18458C3C0")]
	public void KCCKLIELIHF(int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x458BC70", Offset = "0x458B070", VA = "0x18458BC70")]
	public void HEFLPBLBPMP(T[] CHDCMIMONFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x458C380", Offset = "0x458B780", VA = "0x18458C380")]
	public Enumerator JDJKPBEKJIJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x458CC60", Offset = "0x458C060", VA = "0x18458CC60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x458CC60", Offset = "0x458C060", VA = "0x18458CC60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x458C860", Offset = "0x458BC60", VA = "0x18458C860")]
	private int NBJLNCOIGMD(int IIACLAMOIEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x458B640", Offset = "0x458AA40", VA = "0x18458B640")]
	private int HCMAAHBNFHD(int IIACLAMOIEE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HIBACLKOFDE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> BFEGCJFOFJL(TRequest BLIDGDGMCAP, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum NJPFMONDDPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class LIIBKCCDNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float BILCBHBHOFE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan JDMEGDBCNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int AAEHNOIDHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NJPFMONDDPD JNIGIDOFFIF;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly LIIBKCCDNFJ LNPPLFIHDAJ;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float IIJIKHJNAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x47CFD70", Offset = "0x47CF170", VA = "0x1847CFD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan HCDOIGIILKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x47CFE50", Offset = "0x47CF250", VA = "0x1847CFE50")]
		public LIIBKCCDNFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct NLFFJPMHMFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest BLIDGDGMCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken FHGIOBPPFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> LAMCFMALIOO;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4A9AF60", Offset = "0x4A9A360", VA = "0x184A9AF60")]
		public NLFFJPMHMFE(TRequest BLIDGDGMCAP, TaskCompletionSource<TResult> LAMCFMALIOO, CancellationToken FHGIOBPPFHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct LMBJCOCOHAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public HIBACLKOFDE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x47E31D0", Offset = "0x47E25D0", VA = "0x1847E31D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x47E36A0", Offset = "0x47E2AA0", VA = "0x1847E36A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct EMBFLNEAELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public HIBACLKOFDE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private NLFFJPMHMFE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAE70", Offset = "0x3CDA270", VA = "0x183CDAE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC1F0", Offset = "0x3CDB5F0", VA = "0x183CDC1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource KLJJPCILKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<NLFFJPMHMFE> KIMOOLHEDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LIIBKCCDNFJ PGDLJOEAOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BFEGCJFOFJL JGGELCFHMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task FLHGGAJNBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int LDDKDBEMFOI;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x42558C0", Offset = "0x4254CC0", VA = "0x1842558C0")]
	public HIBACLKOFDE(BFEGCJFOFJL JGGELCFHMBI, [Optional] LIIBKCCDNFJ PGDLJOEAOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x42540A0", Offset = "0x42534A0", VA = "0x1842540A0")]
	public Task<TResult> CAOADHONPIE(TRequest BLIDGDGMCAP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x42553F0", Offset = "0x42547F0", VA = "0x1842553F0")]
	private void OHMOADFOJMF(NLFFJPMHMFE FOFGHPPLHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4255660", Offset = "0x4254A60", VA = "0x184255660")]
	[AsyncStateMachine(typeof(HIBACLKOFDE<, >.LMBJCOCOHAE))]
	private Task PFCHDLNMEKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x42548F0", Offset = "0x4253CF0", VA = "0x1842548F0")]
	private NLFFJPMHMFE CCAPNKKDJDG()
	{
		return default(NLFFJPMHMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4254BE0", Offset = "0x4253FE0", VA = "0x184254BE0")]
	[AsyncStateMachine(typeof(HIBACLKOFDE<, >.EMBFLNEAELB))]
	private Task CIGGBGHHDII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4255120", Offset = "0x4254520", VA = "0x184255120")]
	private void INDFIEABPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4254EC0", Offset = "0x42542C0", VA = "0x184254EC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EADHJDGFMAF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> CECMFLAILAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> BNLELFHEHOK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x39C69D0", Offset = "0x39C5DD0", VA = "0x1839C69D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DNNGBKHPAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2F66840", Offset = "0x2F65C40", VA = "0x182F66840", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A2E0", Offset = "0x3C796E0", VA = "0x183C7A2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3C795B0", Offset = "0x3C789B0", VA = "0x183C795B0", Slot = "11")]
	public void Add(T FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3C79760", Offset = "0x3C78B60", VA = "0x183C79760")]
	public bool FNNADCNGDHB(T FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3C79FD0", Offset = "0x3C793D0", VA = "0x183C79FD0", Slot = "15")]
	public bool Remove(T FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3C79980", Offset = "0x3C78D80", VA = "0x183C79980", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A170", Offset = "0x3C79570", VA = "0x183C7A170", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3C795F0", Offset = "0x3C789F0", VA = "0x183C795F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3C796A0", Offset = "0x3C78AA0", VA = "0x183C796A0", Slot = "13")]
	public bool Contains(T FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3C79700", Offset = "0x3C78B00", VA = "0x183C79700", Slot = "14")]
	public void CopyTo(T[] CHDCMIMONFN, int ECPOGOHOPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3C79A10", Offset = "0x3C78E10", VA = "0x183C79A10", Slot = "6")]
	public int IndexOf(T FKIFNEPLBJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3C79BC0", Offset = "0x3C78FC0", VA = "0x183C79BC0", Slot = "7")]
	public void Insert(int IIACLAMOIEE, T FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3C79D10", Offset = "0x3C79110", VA = "0x183C79D10", Slot = "8")]
	public void RemoveAt(int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A1B0", Offset = "0x3C795B0", VA = "0x183C7A1B0")]
	public EADHJDGFMAF()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x252AC90", Offset = "0x252A090", VA = "0x18252AC90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC35B0", Offset = "0x6FC29B0", VA = "0x186FC35B0")]
		public SerializedGuid([In] Guid FNECNONNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC32D0", Offset = "0x6FC26D0", VA = "0x186FC32D0")]
		public static SerializedGuid ELAODOEGILL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3430", Offset = "0x6FC2830", VA = "0x186FC3430")]
		public static SerializedGuid OCMMLMIGEPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3550", Offset = "0x6FC2950", VA = "0x186FC3550")]
		public bool PJCKOFPFAIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3520", Offset = "0x6FC2920", VA = "0x186FC3520", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FC34A0", Offset = "0x6FC28A0", VA = "0x186FC34A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3350", Offset = "0x6FC2750", VA = "0x186FC3350", Slot = "7")]
		public bool Equals(SerializedGuid BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3390", Offset = "0x6FC2790", VA = "0x186FC3390", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3420", Offset = "0x6FC2820", VA = "0x186FC3420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC32A0", Offset = "0x6FC26A0", VA = "0x186FC32A0", Slot = "6")]
		public int CompareTo(SerializedGuid BMKPAKCEMFK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class KFMFONBHDHG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type HOJJNNKMDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string AMDFPDMMJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool LMFMJLMBFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool BPPOBLAOOBF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0270", Offset = "0x6FBF670", VA = "0x186FC0270")]
	public KFMFONBHDHG(Type JJFDEHNDJGP, string GIJONJFLHAF, bool FINMPBBBAPC = false, bool JCKKNOFJNEL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LOALKKNJJLG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct BIBINIMPBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long MPIOPHIEJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long NNKELKLIGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int JJFNICENFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int BDMBDBNNDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool LDOHNFOLCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string HHOPFEANIBA;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53D7A50", Offset = "0x53D6E50", VA = "0x1853D7A50")]
		public BIBINIMPBNB(long MPIOPHIEJON, int JJFNICENFGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53D7A20", Offset = "0x53D6E20", VA = "0x1853D7A20")]
		public BIBINIMPBNB(long MPIOPHIEJON, long NNKELKLIGAM, int JJFNICENFGO, int BDMBDBNNDMB, bool LDOHNFOLCPP, string HHOPFEANIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x53D7950", Offset = "0x53D6D50", VA = "0x1853D7950")]
		public int FKJPAMMGHFM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x53D79A0", Offset = "0x53D6DA0", VA = "0x1853D79A0")]
		public int NHKCHFMAHJB(int ILCMAKKGNEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x53D79C0", Offset = "0x53D6DC0", VA = "0x1853D79C0")]
		public double PHCFOIJNCLJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x53D78B0", Offset = "0x53D6CB0", VA = "0x1853D78B0")]
		public BIBINIMPBNB BOMMHKABNJF(long NNKELKLIGAM, int BDMBDBNNDMB)
		{
			return default(BIBINIMPBNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class HAPJMIAELKE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct OFDCCFMOAHJ<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public HAPJMIAELKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<HAPJMIAELKE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private HAPJMIAELKE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4B806D0", Offset = "0x4B7FAD0", VA = "0x184B806D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x4357D30", Offset = "0x4357130", VA = "0x184357D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey ECHGIIKNGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly LOALKKNJJLG<TKey> HIKLLEDALJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly GKOKEEMOOFG GGCNADGKGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<HAPJMIAELKE> ODJJCBLDHLN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string DDBCAACLPCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x42082B0", Offset = "0x42076B0", VA = "0x1842082B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEnumerable<HAPJMIAELKE> GKKJFBEKOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x42080B0", Offset = "0x42074B0", VA = "0x1842080B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public BIBINIMPBNB FINOPGEPOHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4208310", Offset = "0x4207710", VA = "0x184208310")]
			[CompilerGenerated]
			get
			{
				return default(BIBINIMPBNB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x4208330", Offset = "0x4207730", VA = "0x184208330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4208360", Offset = "0x4207760", VA = "0x184208360")]
		internal HAPJMIAELKE(LOALKKNJJLG<TKey> HIKLLEDALJM, TKey LDCKBFKFIKC, GKOKEEMOOFG GGCNADGKGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x42080F0", Offset = "0x42074F0", VA = "0x1842080F0")]
		public HAPJMIAELKE HAJKHENPJBI(TKey LDCKBFKFIKC, [Optional] GKOKEEMOOFG? LDGKNGHCIJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3185EF0", Offset = "0x31852F0", VA = "0x183185EF0")]
		[AsyncStateMachine(typeof(OFDCCFMOAHJ<>))]
		public Task<T> KCPKFAGGGOE<T>(TKey LDCKBFKFIKC, Func<HAPJMIAELKE, Task<T>> BDEDHGPGIGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4207E50", Offset = "0x4207250", VA = "0x184207E50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MAOPILACHJG : IEnumerable<(TKey, List<TKey>, BIBINIMPBNB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BIBINIMPBNB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, BIBINIMPBNB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LOALKKNJJLG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, BIBINIMPBNB timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private (TKey, List<TKey>, BIBINIMPBNB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2556CD0", Offset = "0x25560D0", VA = "0x182556CD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BIBINIMPBNB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x49CD9C0", Offset = "0x49CCDC0", VA = "0x1849CD9C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2556DC0", Offset = "0x25561C0", VA = "0x182556DC0")]
		[DebuggerHidden]
		public MAOPILACHJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3FC22B0", Offset = "0x3FC16B0", VA = "0x183FC22B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x49CD490", Offset = "0x49CC890", VA = "0x1849CD490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x49CD840", Offset = "0x49CCC40", VA = "0x1849CD840")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x49CD970", Offset = "0x49CCD70", VA = "0x1849CD970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x49CD890", Offset = "0x49CCC90", VA = "0x1849CD890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BIBINIMPBNB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x40EC1A0", Offset = "0x40EB5A0", VA = "0x1840EC1A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class NFMPABGJCJJ : IEnumerable<(TKey, List<TKey>, BIBINIMPBNB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BIBINIMPBNB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, BIBINIMPBNB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private HAPJMIAELKE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HAPJMIAELKE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public LOALKKNJJLG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<HAPJMIAELKE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, BIBINIMPBNB timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private (TKey, List<TKey>, BIBINIMPBNB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2556CD0", Offset = "0x25560D0", VA = "0x182556CD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BIBINIMPBNB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4A80F80", Offset = "0x4A80380", VA = "0x184A80F80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2556DC0", Offset = "0x25561C0", VA = "0x182556DC0")]
		[DebuggerHidden]
		public NFMPABGJCJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4A80FE0", Offset = "0x4A803E0", VA = "0x184A80FE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4A805B0", Offset = "0x4A7F9B0", VA = "0x184A805B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4A80D90", Offset = "0x4A80190", VA = "0x184A80D90")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4A80550", Offset = "0x4A7F950", VA = "0x184A80550")]
		private void GFPCIOJGMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4A80F30", Offset = "0x4A80330", VA = "0x184A80F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4A80DF0", Offset = "0x4A801F0", VA = "0x184A80DF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BIBINIMPBNB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4A80EF0", Offset = "0x4A802F0", VA = "0x184A80EF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, BIBINIMPBNB, GKOKEEMOOFG> ANFFGNMBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, BIBINIMPBNB, GKOKEEMOOFG> FAOCIOLAPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<LOALKKNJJLG<TKey>, GKOKEEMOOFG> DPJHKCDEABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HAPJMIAELKE OLFAAFBJJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool NDHHFMKHGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int MMGGCIGGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch JLEAIKJEMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int CHOIKAPGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string OJAMCLDJFGH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HAPJMIAELKE KMFOHPNCAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	[NotNull]
	public string DDBCAACLPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x47ED700", Offset = "0x47ECB00", VA = "0x1847ED700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x47ED900", Offset = "0x47ECD00", VA = "0x1847ED900")]
	public LOALKKNJJLG(TKey BCHPECNBAIH, GKOKEEMOOFG GGCNADGKGHO, [Optional] int? JJFNICENFGO, [Optional][CanBeNull] Stopwatch JLEAIKJEMMG, [Optional] Action<TKey, BIBINIMPBNB, GKOKEEMOOFG> ANFFGNMBKIH, [Optional] Action<TKey, BIBINIMPBNB, GKOKEEMOOFG> FAOCIOLAPDP, [Optional] Action<LOALKKNJJLG<TKey>, GKOKEEMOOFG> DPJHKCDEABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x47ED5A0", Offset = "0x47EC9A0", VA = "0x1847ED5A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x47ED760", Offset = "0x47ECB60", VA = "0x1847ED760")]
	[IteratorStateMachine(typeof(LOALKKNJJLG<>.MAOPILACHJG))]
	public IEnumerable<(TKey, List<TKey>, BIBINIMPBNB)> LGAFFCKCKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x47ED810", Offset = "0x47ECC10", VA = "0x1847ED810")]
	[IteratorStateMachine(typeof(LOALKKNJJLG<>.NFMPABGJCJJ))]
	private IEnumerable<(TKey, List<TKey>, BIBINIMPBNB)> LGAFFCKCKFA(List<TKey> DFDAPFPPOMG, HAPJMIAELKE MKFIMMFPBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x47ED680", Offset = "0x47ECA80", VA = "0x1847ED680")]
	private (long, int) ELAFGIPGLIE()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class JPANEJIAKOE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut AJNNPOLAAHD(LOALKKNJJLG<TKey> HIKLLEDALJM);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected JPANEJIAKOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class KMKPCOPCADF<TKey> : JPANEJIAKOE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string AJKJGGBEPJF(TKey LDCKBFKFIKC);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x46A2DB0", Offset = "0x46A21B0", VA = "0x1846A2DB0")]
	private static string FMHFNEOAHGJ(TKey LDCKBFKFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x46A2B60", Offset = "0x46A1F60", VA = "0x1846A2B60", Slot = "4")]
	public override string AJNNPOLAAHD(LOALKKNJJLG<TKey> HIKLLEDALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x46A2C50", Offset = "0x46A2050", VA = "0x1846A2C50")]
	public string AJNNPOLAAHD(LOALKKNJJLG<TKey> HIKLLEDALJM, [NotNull] AJKJGGBEPJF EDELEELIKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PFKCNDGEADL(LOALKKNJJLG<TKey> HIKLLEDALJM, [NotNull] AJKJGGBEPJF EDELEELIKOM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x43D82F0", Offset = "0x43D76F0", VA = "0x1843D82F0")]
	protected KMKPCOPCADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MLLDGAENEME<TKey> : JPANEJIAKOE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string BHIMNPDCLIA(TKey LDCKBFKFIKC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string OHHOIKFNMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double OCDPNHIKGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool OHDIABPPJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int OLHEHLMFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> ILPBOBPLHBF;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4A07AD0", Offset = "0x4A06ED0", VA = "0x184A07AD0")]
	private static string FMHFNEOAHGJ(TKey LDCKBFKFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4A07BE0", Offset = "0x4A06FE0", VA = "0x184A07BE0")]
	public MLLDGAENEME(string OHHOIKFNMGK = "F2", double OCDPNHIKGMB = double.MaxValue, bool OHDIABPPJOH = false, int OLHEHLMFBFA = int.MaxValue, [Optional] ISet<string> ILPBOBPLHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4A06FB0", Offset = "0x4A063B0", VA = "0x184A06FB0", Slot = "4")]
	public override Dictionary<string, string> AJNNPOLAAHD(LOALKKNJJLG<TKey> HIKLLEDALJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4A07B10", Offset = "0x4A06F10", VA = "0x184A07B10")]
	private bool OADGLMGJFAI(string MEDCMINBEHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4A070A0", Offset = "0x4A064A0", VA = "0x184A070A0")]
	public Dictionary<string, string> AJNNPOLAAHD(LOALKKNJJLG<TKey> HIKLLEDALJM, BHIMNPDCLIA EDELEELIKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4A07850", Offset = "0x4A06C50", VA = "0x184A07850")]
	private string DCFHJAIBDGN(StringBuilder COLIKCLOFLI, List<TKey> CAOEGDFEHDC, BHIMNPDCLIA EDELEELIKOM, bool OINMCIMGNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4A076F0", Offset = "0x4A06AF0", VA = "0x184A076F0")]
	private static void BOAGGJKPIKB(StringBuilder MLDBDEEBMHP, string NEPJFEFKLBI, bool MMJECJJEBPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MMBKOJBCJKA<TKey> : KMKPCOPCADF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LJGFPNEAPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AJKJGGBEPJF keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static MMBKOJBCJKA<TKey> ELEBKANKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] IFDABNGHJNH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BBF0", Offset = "0x4A0AFF0", VA = "0x184A0BBF0")]
	private MMBKOJBCJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4A0AC70", Offset = "0x4A0A070", VA = "0x184A0AC70", Slot = "5")]
	protected override string PFKCNDGEADL(LOALKKNJJLG<TKey> HIKLLEDALJM, AJKJGGBEPJF EDELEELIKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0AB60", Offset = "0x4A09F60", VA = "0x184A0AB60")]
	[CompilerGenerated]
	internal static string KFDPCPHLHPC(string PLHONOLIEOO, TKey LDCKBFKFIKC, LJGFPNEAPOF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MBLPEHGFLOD : LOALKKNJJLG<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PBDFPAHCELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<MBLPEHGFLOD, GKOKEEMOOFG> callback;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PBDFPAHCELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0C90", Offset = "0x6FC0090", VA = "0x186FC0C90")]
		internal void CECLPLEJGHN(LOALKKNJJLG<string> timer, GKOKEEMOOFG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0750", Offset = "0x6FBFB50", VA = "0x186FC0750")]
	public MBLPEHGFLOD(GKOKEEMOOFG GGCNADGKGHO, [Optional] string CEPLLPEMOPH, [Optional] int? JJFNICENFGO, [Optional] Stopwatch JLEAIKJEMMG, [Optional] Action<string, BIBINIMPBNB, GKOKEEMOOFG> ANFFGNMBKIH, [Optional] Action<string, BIBINIMPBNB, GKOKEEMOOFG> FAOCIOLAPDP, [Optional] Action<MBLPEHGFLOD, GKOKEEMOOFG> DPJHKCDEABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0690", Offset = "0x6FBFA90", VA = "0x186FC0690")]
	private static Action<LOALKKNJJLG<string>, GKOKEEMOOFG> MHFNDHCECNK(Action<MBLPEHGFLOD, GKOKEEMOOFG> CPIKECCHPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class MILKDKIHPJC
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class AIGCICHMOJB : MILKDKIHPJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static MILKDKIHPJC ELEBKANKHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6FBDAF0", Offset = "0x6FBCEF0", VA = "0x186FBDAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override float MIHEGMEDMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xD734E0", Offset = "0xD728E0", VA = "0x180D734E0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDBE0", Offset = "0x6FBCFE0", VA = "0x186FBDBE0")]
		public AIGCICHMOJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static MILKDKIHPJC HBACAAMJKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static MILKDKIHPJC LNPPLFIHDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0960", Offset = "0x6FBFD60", VA = "0x186FC0960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract float MIHEGMEDMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected MILKDKIHPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KMJKLFGFJJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PLBFKJMGACI<T> : KMJKLFGFJJB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> JONNKIJMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	AMMGOODCICE<T> JIGLPKCOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KAIHJFDILCH
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x30FCE60", Offset = "0x30FC260", VA = "0x1830FCE60")]
	public static PLBFKJMGACI<TResource> BFBJPMMPLHG<TResource, TId>(this ICLEEDLMCMC<TId, TResource> JDENFLNKFLO, TId LPMIIFILJPI, [Optional] Func<TId, CancellationToken, Task<TResource>>? DFLAHMIBANG) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CJBACAIGMEH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class DMLJOLEBCCK<T> : EFHIOEOEBAA<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override Task<T?> JONNKIJMLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override AMMGOODCICE<T?> JIGLPKCOBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5E83840", Offset = "0x5E82C40", VA = "0x185E83840")]
		public DMLJOLEBCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "10")]
		protected override void OEKDJLADKFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class PFNFFLDCIBK<T> : EFHIOEOEBAA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T CBIGEDIFABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? IEHHIJBNBHO;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override Task<T> JONNKIJMLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override AMMGOODCICE<T> JIGLPKCOBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4C60250", Offset = "0x4C5F650", VA = "0x184C60250")]
		public PFNFFLDCIBK(T JEHHJPJCBHP, Action<T>? EHPPLAMIOHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4C601F0", Offset = "0x4C5F5F0", VA = "0x184C601F0", Slot = "10")]
		protected override void OEKDJLADKFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class IPMPJDLJNEA<T> : EFHIOEOEBAA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override Task<T> JONNKIJMLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override AMMGOODCICE<T> JIGLPKCOBEO
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x43D1700", Offset = "0x43D0B00", VA = "0x1843D1700")]
		public IPMPJDLJNEA(Exception EAIPGJCIAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "10")]
		protected override void OEKDJLADKFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class BGMIKNHDEIJ<T> : EFHIOEOEBAA<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct FCHMADKBDLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<PLBFKJMGACI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<PLBFKJMGACI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4053A80", Offset = "0x4052E80", VA = "0x184053A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x40544D0", Offset = "0x40538D0", VA = "0x1840544D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct OIDDNCGNLLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<PLBFKJMGACI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<PLBFKJMGACI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4B84090", Offset = "0x4B83490", VA = "0x184B84090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x4B84330", Offset = "0x4B83730", VA = "0x184B84330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<PLBFKJMGACI<T>> PCEIIFFGOJD;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override Task<T> JONNKIJMLMI
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override AMMGOODCICE<T> JIGLPKCOBEO
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x53D2410", Offset = "0x53D1810", VA = "0x1853D2410")]
		public BGMIKNHDEIJ(Task<PLBFKJMGACI<T>> LCFJPCOMAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x53D2380", Offset = "0x53D1780", VA = "0x1853D2380", Slot = "10")]
		protected override void OEKDJLADKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x53D1F90", Offset = "0x53D1390", VA = "0x1853D1F90")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(BGMIKNHDEIJ<>.FCHMADKBDLF))]
		internal static Task<T> DONLPDCEPDD(Task<PLBFKJMGACI<T>> LCFJPCOMAFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x53D2110", Offset = "0x53D1510", VA = "0x1853D2110")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(BGMIKNHDEIJ<>.OIDDNCGNLLM))]
		internal static Task KJPGDOLAKKH(Task<PLBFKJMGACI<T>> LCFJPCOMAFL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class POHPHBIKCEM<TIn, TOut> : EFHIOEOEBAA<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct IHGIMPAAFEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x434F020", Offset = "0x434E420", VA = "0x18434F020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x434F6E0", Offset = "0x434EAE0", VA = "0x18434F6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly PLBFKJMGACI<TIn> KPJPEBHPHKO;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override Task<TOut> JONNKIJMLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override AMMGOODCICE<TOut> JIGLPKCOBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1DF0", Offset = "0x4CB11F0", VA = "0x184CB1DF0")]
		public POHPHBIKCEM(PLBFKJMGACI<TIn> GJJIMJCBODN, Func<TIn, TOut> BCDMKOBLCMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1DA0", Offset = "0x4CB11A0", VA = "0x184CB1DA0", Slot = "10")]
		protected override void OEKDJLADKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1BC0", Offset = "0x4CB0FC0", VA = "0x184CB1BC0")]
		[AsyncStateMachine(typeof(POHPHBIKCEM<, >.IHGIMPAAFEN))]
		[CompilerGenerated]
		internal static Task<TOut> BEBPMOFALAE(Task<TIn> EPPAELGIDII, Func<TIn, TOut> BCDMKOBLCMB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2E46DE0", Offset = "0x2E461E0", VA = "0x182E46DE0")]
	public static PLBFKJMGACI<T> MGEHKGIFIKI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2E46E50", Offset = "0x2E46250", VA = "0x182E46E50")]
	public static PLBFKJMGACI<T> OBNIMALECOE<T>(T CEDDFJCBLGM, [Optional] Action<T>? EHPPLAMIOHC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0")]
	public static PLBFKJMGACI<T> IGBKOAAJCAM<T>(Exception EAIPGJCIAMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0")]
	public static PLBFKJMGACI<T> CKMHMLINPFL<T>(Task<PLBFKJMGACI<T>> LCFJPCOMAFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2E46D50", Offset = "0x2E46150", VA = "0x182E46D50")]
	public static PLBFKJMGACI<TOut> DCIPDEOFAEP<TOut, TIn>(PLBFKJMGACI<TIn> KADPKBIGPFN, Func<TIn, TOut> BCDMKOBLCMB) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class EFHIOEOEBAA<T> : PLBFKJMGACI<T>, KMJKLFGFJJB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string HGNIJLMMDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HKIIKADHLEC EMPGPFIFFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool NDHHFMKHGIO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xF5E030", Offset = "0xF5D430", VA = "0x180F5E030", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Task<T> JONNKIJMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract AMMGOODCICE<T> JIGLPKCOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEF70", Offset = "0x3CBE370", VA = "0x183CBEF70")]
	public EFHIOEOEBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3CBEBB0", Offset = "0x3CBDFB0", VA = "0x183CBEBB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OEKDJLADKFB();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class FILEOLKLPCE<TTask, T> : EFHIOEOEBAA<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CCHJHDNHCAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CCHJHDNHCAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x39B4E50", Offset = "0x39B4250", VA = "0x1839B4E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x39B53C0", Offset = "0x39B47C0", VA = "0x1839B53C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public FILEOLKLPCE<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CCHJHDNHCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5609A70", Offset = "0x5608E70", VA = "0x185609A70")]
		[AsyncStateMachine(typeof(FILEOLKLPCE<, >.CCHJHDNHCAL.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> AAMOMGHLAFH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> LCFJPCOMAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource BPPNMIHDBGI;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override Task<T> JONNKIJMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public override AMMGOODCICE<T> JIGLPKCOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4081790", Offset = "0x4080B90", VA = "0x184081790")]
	protected FILEOLKLPCE(TTask LCFJPCOMAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4081740", Offset = "0x4080B40", VA = "0x184081740", Slot = "10")]
	protected override void OEKDJLADKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DJNCEBAIGDD(TTask CBHNDEPAMOL);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void EAPJADGDHFK();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FEHBKCNBANE<T> : EFHIOEOEBAA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PMAODDEEHAH<Task<T>> ILGDJGEIOGB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public override Task<T> JONNKIJMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x404EB40", Offset = "0x404DF40", VA = "0x18404EB40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public override AMMGOODCICE<T> JIGLPKCOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4064CD0", Offset = "0x40640D0", VA = "0x184064CD0")]
	public FEHBKCNBANE(PMAODDEEHAH<Task<T>> NLADEDIFDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4064CB0", Offset = "0x40640B0", VA = "0x184064CB0", Slot = "10")]
	protected override void OEKDJLADKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KANOLHPMLDL
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName PNNILBNEBBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> AJLCAOEOJNB;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF4D0", Offset = "0x6FBE8D0", VA = "0x186FBF4D0")]
	public static int LMHACEAFPAB(this EKCAKJNJLFK ICMCDMIAFJH, IncrementalHash GKJBBOELMJG, byte[] EPLLLIMNHJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF860", Offset = "0x6FBEC60", VA = "0x186FBF860")]
	public static bool MMEKFKPNCLJ([CanBeNull] this EKCAKJNJLFK ICMCDMIAFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF550", Offset = "0x6FBE950", VA = "0x186FBF550")]
	public static bool MMEKFKPNCLJ([CanBeNull] this EKCAKJNJLFK ICMCDMIAFJH, [Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF8C0", Offset = "0x6FBECC0", VA = "0x186FBF8C0")]
	public static bool MMEKFKPNCLJ([CanBeNull] this EKCAKJNJLFK ICMCDMIAFJH, IncrementalHash GKJBBOELMJG, byte[] EPLLLIMNHJD, [Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFBF0", Offset = "0x6FBEFF0", VA = "0x186FBFBF0")]
	private static bool PLKOKGBLCEP(byte[] OAJJIPONENC, Span<byte> BJPKJAOPNDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LOJFPMDGBKI
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0540", Offset = "0x6FBF940", VA = "0x186FC0540")]
	public static int PHFKBPEAMAI(HashAlgorithmName GLNBJPNPLOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC02E0", Offset = "0x6FBF6E0", VA = "0x186FC02E0")]
	public static int LMHACEAFPAB(this ECADCDIFJOE ILLIKLLPNFO, byte[] JFCOJFNAMPG, IncrementalHash GKJBBOELMJG, byte[] JPGAHNHPJCC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface ECADCDIFJOE
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash GKJBBOELMJG);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface EKCAKJNJLFK : ECADCDIFJOE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[CanBeNull]
	byte[] LGGAPOGLFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[CanBeNull]
	byte[] HAOFABBHPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PNGCJELKIED
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool HOLEHJFIMAD;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> PJPALELIEJE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> BNLEOKJPGJH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding FOCDGKLAHHB;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> NFFANMPNGHK;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x322DB60", Offset = "0x322CF60", VA = "0x18322DB60")]
	public static void OBCOLFCCOEN<T>(this IncrementalHash AKELPHCBDNF, [CanBeNull] T HFEBDCHJGBG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x322D5D0", Offset = "0x322C9D0", VA = "0x18322D5D0")]
	public static void MKCKCBDEEFF<T>(this IncrementalHash AKELPHCBDNF, [CanBeNull] T ILLIKLLPNFO) where T : ECADCDIFJOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x322D660", Offset = "0x322CA60", VA = "0x18322D660")]
	public static void MLDLMABHNAD<T>(this IncrementalHash AKELPHCBDNF, [CanBeNull] IList<T> PBHDIJCINDH) where T : ECADCDIFJOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0D20", Offset = "0x6FC0120", VA = "0x186FC0D20")]
	private static bool AGBEFLHOKFN([CanBeNull] ECADCDIFJOE ILLIKLLPNFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6FC14B0", Offset = "0x6FC08B0", VA = "0x186FC14B0")]
	public static void JNFNMFGLNJF(this IncrementalHash GKJBBOELMJG, string? NKIEILPDBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6FC12E0", Offset = "0x6FC06E0", VA = "0x186FC12E0")]
	public static void HDOBNINAPLL(this IncrementalHash GKJBBOELMJG, long NDDPBNLFKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1110", Offset = "0x6FC0510", VA = "0x186FC1110")]
	public static void GMLHPLEDNIB(this IncrementalHash GKJBBOELMJG, int CFBMOHPJLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6FC18B0", Offset = "0x6FC0CB0", VA = "0x186FC18B0")]
	public static void MGCPNHMMNPK(this IncrementalHash GKJBBOELMJG, short JLODKDLAHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1AE0", Offset = "0x6FC0EE0", VA = "0x186FC1AE0")]
	public static void OLLAEHJJOHH(this IncrementalHash GKJBBOELMJG, byte BFMGHHMMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0E70", Offset = "0x6FC0270", VA = "0x186FC0E70")]
	public static void EFAJIDDAAKP(this IncrementalHash GKJBBOELMJG, bool MHDJIAAJMPL, bool IEKIHIOALBL = false, bool AJCDBACELBE = false, bool OLKIICLNGBD = false, bool FJABJFPDBAP = false, bool CMCPAHIPKEA = false, bool NLFGJMDBEAL = false, bool PHGJEBFFGAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x322CFB0", Offset = "0x322C3B0", VA = "0x18322CFB0")]
	public static void MFFPLNMEENC<T>(this IncrementalHash GKJBBOELMJG, T GAADACALPOM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0E10", Offset = "0x6FC0210", VA = "0x186FC0E10")]
	public static void CIDLDMJOGIJ(this IncrementalHash GKJBBOELMJG, float FEDKIENCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1A80", Offset = "0x6FC0E80", VA = "0x186FC1A80")]
	public static void NILBOOMNPGN(this IncrementalHash GKJBBOELMJG, ulong CMNPJKEIHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1BF0", Offset = "0x6FC0FF0", VA = "0x186FC1BF0")]
	public static void ONJLAHAJLGM(this IncrementalHash GKJBBOELMJG, uint AOMPKBCIPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0DB0", Offset = "0x6FC01B0", VA = "0x186FC0DB0")]
	public static void BDLHGLAAANP(this IncrementalHash GKJBBOELMJG, ushort AKEFFDPKLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0FE0", Offset = "0x6FC03E0", VA = "0x186FC0FE0")]
	public static void GDCFGAAIEEM(this IncrementalHash GKJBBOELMJG, Vector3 DBPJEEBDNMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class OBNKBCFBOOK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0C30", Offset = "0x6FC0030", VA = "0x186FC0C30")]
	public OBNKBCFBOOK(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class HBJFKKEINDA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void GFCGIGGJMDO(ushort EAMNDCPCFAF, ushort OLIIAIOPONB, ushort GOPKDGJDEAA, ushort MCCFFPMNNLM);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void NEFHFLEIGLO(ushort EICNBFLMOFF, ushort FGMBCGEGAHF);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void KCMBGAOFGFE();

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const ushort LEMAKAPFNEJ = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected HBJFKKEINDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class MEPGJFIJOID<T> : HBJFKKEINDA where T : MEPGJFIJOID<T>.FFGKICJEOAP
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface FFGKICJEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		NEFHFLEIGLO IIPMOIAKHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		NEFHFLEIGLO BOACDCNBNBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		KCMBGAOFGFE LNPAGAKLEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<uint, T> IOMNKLEHBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private KCMBGAOFGFE MMGOKPBBHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private KCMBGAOFGFE EEGFAOEBIKK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool HMFKKLAHLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE810", Offset = "0x8CDC10", VA = "0x1808CE810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public ushort OGCOGDAPLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x49E69B0", Offset = "0x49E5DB0", VA = "0x1849E69B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x49E6B00", Offset = "0x49E5F00", VA = "0x1849E6B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public ushort BHLNBLIDIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x49E69A0", Offset = "0x49E5DA0", VA = "0x1849E69A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x49E6AF0", Offset = "0x49E5EF0", VA = "0x1849E6AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public ushort FDLAIMKEJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9EBC20", Offset = "0x9EB020", VA = "0x1809EBC20")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBDB0", Offset = "0x9EB1B0", VA = "0x1809EBDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public ushort GPLLADFACKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x49E6D30", Offset = "0x49E6130", VA = "0x1849E6D30")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x49E6D40", Offset = "0x49E6140", VA = "0x1849E6D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected bool OEHOKGBFLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x12E05C0", Offset = "0x12DF9C0", VA = "0x1812E05C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected bool KOCGKBNONFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BB20", Offset = "0xE1AF20", VA = "0x180E1BB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GFCGIGGJMDO MJLIAFOGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x49E6C90", Offset = "0x49E6090", VA = "0x1849E6C90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x49E6BF0", Offset = "0x49E5FF0", VA = "0x1849E6BF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x49E6880", Offset = "0x49E5C80", VA = "0x1849E6880")]
	private T CECBIGNGFOE(ushort IAOOEHHFLEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x49E6B20", Offset = "0x49E5F20", VA = "0x1849E6B20")]
	private T JNNLGIBGHLO(ushort IAOOEHHFLEL, ushort GEBKFMJKLEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x49E6A70", Offset = "0x49E5E70", VA = "0x1849E6A70")]
	protected T HAKNPBCGFDI(uint IPIMMBCKKEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x49E7880", Offset = "0x49E6C80", VA = "0x1849E7880")]
	protected MEPGJFIJOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x49E67E0", Offset = "0x49E5BE0", VA = "0x1849E67E0")]
	public void BFEFLFEGABI(ushort GLIMEMAEODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x49E6820", Offset = "0x49E5C20", VA = "0x1849E6820")]
	public void BFEFLFEGABI(ushort GLIMEMAEODA, ushort MFHPKBAOBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x49E66C0", Offset = "0x49E5AC0", VA = "0x1849E66C0", Slot = "4")]
	protected virtual void BFEFLFEGABI(uint NCHAIFHFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x49E6FE0", Offset = "0x49E63E0", VA = "0x1849E6FE0")]
	protected void PHDLFCLDFGB(uint NCHAIFHFJLP, uint FHEINPABBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x49E69C0", Offset = "0x49E5DC0", VA = "0x1849E69C0")]
	protected void GCBEFKKPNKN(ushort IAOOEHHFLEL, ushort GEBKFMJKLEB, T MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x49E6940", Offset = "0x49E5D40", VA = "0x1849E6940")]
	private void EGIMIMOHLGF(uint IPIMMBCKKEM, T MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x49E6D50", Offset = "0x49E6150", VA = "0x1849E6D50")]
	protected void NMGDCFMGBAP(float GNOIEGLKNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x49E6AE0", Offset = "0x49E5EE0", VA = "0x1849E6AE0")]
	protected uint IADFNEGNLDF(ushort IAOOEHHFLEL, ushort GEBKFMJKLEB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x49E6B10", Offset = "0x49E5F10", VA = "0x1849E6B10")]
	protected ushort JFNCMAGHNJG(uint BKJEOMBLLPO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x49E6AD0", Offset = "0x49E5ED0", VA = "0x1849E6AD0")]
	protected ushort HFKDNJFGBCD(uint BKJEOMBLLPO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class CBFPHKPAMME : MEPGJFIJOID<CBFPHKPAMME.LEAMKPAKALM>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class LEAMKPAKALM : FFGKICJEOAP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public NEFHFLEIGLO IIPMOIAKHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public NEFHFLEIGLO BOACDCNBNBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public KCMBGAOFGFE LNPAGAKLEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LEAMKPAKALM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDC80", Offset = "0x6FBD080", VA = "0x186FBDC80")]
	public void MKKCOGGIEFF(ushort AIIBOCNLNOA, NEFHFLEIGLO OFCBNPILMAA, NEFHFLEIGLO APJBHKMBMLC, KCMBGAOFGFE PINFEMJDLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDD60", Offset = "0x6FBD160", VA = "0x186FBDD60")]
	public void MKKCOGGIEFF(ushort IAOOEHHFLEL, ushort GEBKFMJKLEB, NEFHFLEIGLO OFCBNPILMAA, NEFHFLEIGLO APJBHKMBMLC, KCMBGAOFGFE PINFEMJDLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDC30", Offset = "0x6FBD030", VA = "0x186FBDC30")]
	public void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDE40", Offset = "0x6FBD240", VA = "0x186FBDE40")]
	protected CBFPHKPAMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class EBGMDAPFGGA : CBFPHKPAMME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool AIJNEPHAKLO;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x942EF0", Offset = "0x9422F0", VA = "0x180942EF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x942390", Offset = "0x941790", VA = "0x180942390")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDF80", Offset = "0x6FBD380", VA = "0x186FBDF80")]
	public void OOJJEJPOBFE(ushort PNJBKNNLLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDFE0", Offset = "0x6FBD3E0", VA = "0x186FBDFE0")]
	public void OOJJEJPOBFE(ushort PNJBKNNLLKP, ushort GGEAMEHIAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDE40", Offset = "0x6FBD240", VA = "0x186FBDE40")]
	public EBGMDAPFGGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class IJPGBIJGADH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class GJHEEPDHJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TNode MPLBPEBNKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TNode AMMKPAGCALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PEENILPBCCD JIIJJAKJBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<PEENILPBCCD> LDEAMIKKNKA;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GJHEEPDHJML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal struct PEENILPBCCD : IComparable<PEENILPBCCD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int HPFPPNDKBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public TClaimant NPGPNEFDEHN;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x11A7440", Offset = "0x11A6840", VA = "0x1811A7440")]
		public PEENILPBCCD(int HPFPPNDKBPG, TClaimant NPGPNEFDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C1E0", Offset = "0x4C5B5E0", VA = "0x184C5C1E0")]
		public bool IHOCKFEPADA([In] PEENILPBCCD BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C1D0", Offset = "0x4C5B5D0", VA = "0x184C5C1D0")]
		public bool HJDGIFAGNCI([In] PEENILPBCCD BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C1C0", Offset = "0x4C5B5C0", VA = "0x184C5C1C0", Slot = "4")]
		public int CompareTo(PEENILPBCCD BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C240", Offset = "0x4C5B640", VA = "0x184C5C240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum LJKOJDDJECD
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JFEHKGOLIGM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public IJPGBIJGADH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public JFEHKGOLIGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4581060", Offset = "0x4580460", VA = "0x184581060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4581240", Offset = "0x4580640", VA = "0x184581240", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4581140", Offset = "0x4580540", VA = "0x184581140", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x40E4D40", Offset = "0x40E4140", VA = "0x1840E4D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly EDMMGCJIHED<GJHEEPDHJML> FEDDPNKDCMM;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly EDMMGCJIHED<List<PEENILPBCCD>> DBBNAJACIHI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static int DCPNIMMKCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal readonly Dictionary<TClaimant, TNode> CEHPMJIMABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly Dictionary<TNode, GJHEEPDHJML> PKCHLHLPONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private LJKOJDDJECD BGFBLNEGPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GIBBFBNMFJB(TNode AJLPJFOPFCG);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MCIGJDNHHIC(TNode AJLPJFOPFCG, TClaimant CKGAIIADJDF, TClaimant ENIHCLPEPHA);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4352670", Offset = "0x4351A70", VA = "0x184352670")]
	public IJPGBIJGADH(LJKOJDDJECD BGFBLNEGPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4351C30", Offset = "0x4351030", VA = "0x184351C30")]
	public void GOGFBBGPAHM(TNode AJLPJFOPFCG, TNode NBJNONHAKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4350F30", Offset = "0x4350330", VA = "0x184350F30")]
	public void DDJJKBCCCOH(TClaimant NPGPNEFDEHN, TNode OIIBNBHNFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4351140", Offset = "0x4350540", VA = "0x184351140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4351E20", Offset = "0x4351220", VA = "0x184351E20")]
	private void IIDEBFPDFOA(TClaimant NPGPNEFDEHN, TNode DJEGDALBFGG, TNode OIIBNBHNFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x43510D0", Offset = "0x43504D0", VA = "0x1843510D0")]
	private int DIELPFHFKBK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4351EF0", Offset = "0x43512F0", VA = "0x184351EF0")]
	private void KGPEAHDOJJE(TClaimant NPGPNEFDEHN, TNode LKAJCEPFLCC, TNode IFFJEHOBPPL, int AFNKLGNEFMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4351B50", Offset = "0x4350F50", VA = "0x184351B50")]
	private void GFLMHMPIBBJ(PEENILPBCCD BACNKCIBHOL, GJHEEPDHJML AIGKLGGBPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4351360", Offset = "0x4350760", VA = "0x184351360")]
	private void EINMEFJAMFL(TClaimant NPGPNEFDEHN, TNode LKAJCEPFLCC, TNode IFFJEHOBPPL, int AFNKLGNEFMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4352350", Offset = "0x4351750", VA = "0x184352350")]
	private void NOAIMJBJBOF(PEENILPBCCD BACNKCIBHOL, TNode AJLPJFOPFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4350C30", Offset = "0x4350030", VA = "0x184350C30")]
	private void BKIEHDBPDOA(PEENILPBCCD BACNKCIBHOL, GJHEEPDHJML AIGKLGGBPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4351660", Offset = "0x4350A60", VA = "0x184351660")]
	private void FLOEEHNLOPM(GJHEEPDHJML AIGKLGGBPNP, bool MEJLCJPMCGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x43517C0", Offset = "0x4350BC0", VA = "0x1843517C0")]
	private void FNNHAFGCHOD(GJHEEPDHJML AIGKLGGBPNP, TNode NBJNONHAKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4352250", Offset = "0x4351650", VA = "0x184352250")]
	[IteratorStateMachine(typeof(IJPGBIJGADH<, >.JFEHKGOLIGM))]
	private IEnumerable<TNode> NHIGLANFHCH(TNode LKAJCEPFLCC, TNode IFFJEHOBPPL, bool ODDIIGMBDJA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4351D00", Offset = "0x4351100", VA = "0x184351D00")]
	private GJHEEPDHJML HBJAJGNNDOP(TNode AJLPJFOPFCG, TNode AMMKPAGCALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4350DA0", Offset = "0x43501A0", VA = "0x184350DA0")]
	private GJHEEPDHJML CIMKFKILPKN(TNode AJLPJFOPFCG, TNode AMMKPAGCALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4350A60", Offset = "0x434FE60", VA = "0x184350A60")]
	private void APCPFGIIOBG(GJHEEPDHJML AIGKLGGBPNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class CPAFEOCNOJG<T> : IEnumerable<CPAFEOCNOJG<T>.GHIEGOLJEDE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct GHIEGOLJEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public T HCPAOILCJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int IIACLAMOIEE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class APFBGMKIKAE : IEnumerator<GHIEGOLJEDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private CPAFEOCNOJG<T> EMGPAFNJJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int IIACLAMOIEE;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x3CEC880", Offset = "0x3CEBC80", VA = "0x183CEC880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GHIEGOLJEDE DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x42FE340", Offset = "0x42FD740", VA = "0x1842FE340", Slot = "4")]
			get
			{
				return default(GHIEGOLJEDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x42FE250", Offset = "0x42FD650", VA = "0x1842FE250")]
		public APFBGMKIKAE(CPAFEOCNOJG<T> EMGPAFNJJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x42FE150", Offset = "0x42FD550", VA = "0x1842FE150", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3D44A10", Offset = "0x3D43E10", VA = "0x183D44A10", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xD13730", Offset = "0xD12B30", VA = "0x180D13730", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct DKBGHDOPBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool MCJGAINKIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public T HCPAOILCJCB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private const int CIFAAHFFGPI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly Dictionary<T, int> FOHPNMACKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private DKBGHDOPBEF[] BFIAOOGDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int FNGCEAFDNJI;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int JEHDENDLBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x906930", Offset = "0x905D30", VA = "0x180906930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x905F30", Offset = "0x905330", VA = "0x180905F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x39C69D0", Offset = "0x39C5DD0", VA = "0x1839C69D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x59FA4A0", Offset = "0x59F98A0", VA = "0x1859FA4A0")]
	public CPAFEOCNOJG(int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x59FA590", Offset = "0x59F9990", VA = "0x1859FA590")]
	public CPAFEOCNOJG(GHIEGOLJEDE[] CADOEACMGHN, bool EGNBIGOFIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x59F96E0", Offset = "0x59F8AE0", VA = "0x1859F96E0")]
	public int GCFBHIBMNFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x59F9AA0", Offset = "0x59F8EA0", VA = "0x1859F9AA0")]
	private int KMCEBMJOMMM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x59F9A70", Offset = "0x59F8E70", VA = "0x1859F9A70", Slot = "6")]
	protected virtual uint KKHHHHEOMBH(uint GKJBBOELMJG, T HCPAOILCJCB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x59F9920", Offset = "0x59F8D20", VA = "0x1859F9920")]
	public bool HAKPEAPDBLH(T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x59F97B0", Offset = "0x59F8BB0", VA = "0x1859F97B0")]
	public int GMAAEMJEINI(T HCPAOILCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x59F9980", Offset = "0x59F8D80", VA = "0x1859F9980")]
	public T KHCJMBBCFNJ(int IIACLAMOIEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x59F90F0", Offset = "0x59F84F0", VA = "0x1859F90F0")]
	public bool FNNADCNGDHB(T HCPAOILCJCB, bool KKEPKFFBHFB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x59F9160", Offset = "0x59F8560", VA = "0x1859F9160")]
	public bool FNNADCNGDHB(T HCPAOILCJCB, int IIACLAMOIEE, bool KKEPKFFBHFB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x59F9F60", Offset = "0x59F9360", VA = "0x1859F9F60")]
	private int LGFBAKCDNJH(int GDCLLKFPEAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x59F9FB0", Offset = "0x59F93B0", VA = "0x1859F9FB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x59F9FB0", Offset = "0x59F93B0", VA = "0x1859F9FB0", Slot = "4")]
	private IEnumerator<GHIEGOLJEDE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EDMMGCJIHED<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly Stack<T> NJHPHKJIADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly List<T> DCKHFNIGBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly int IHGNBOEBHIN;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCFD0", Offset = "0x3CBC3D0", VA = "0x183CBCFD0")]
	public static EDMMGCJIHED<T> IDHKPBPGEIM(int GNOHMAFCFKD = 0, int IHGNBOEBHIN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD0D0", Offset = "0x3CBC4D0", VA = "0x183CBD0D0")]
	public static EDMMGCJIHED<T> LLBOPDKJCJL(int GNOHMAFCFKD = 0, int IHGNBOEBHIN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD310", Offset = "0x3CBC710", VA = "0x183CBD310")]
	public EDMMGCJIHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD360", Offset = "0x3CBC760", VA = "0x183CBD360")]
	public EDMMGCJIHED(int GNOHMAFCFKD, int IHGNBOEBHIN = int.MaxValue, bool DOLPMEJBHCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCBF0", Offset = "0x3CBBFF0", VA = "0x183CBCBF0")]
	public T ECCEODIIMHH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD220", Offset = "0x3CBC620", VA = "0x183CBD220")]
	public void OLENLPMJDLF(T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC960", Offset = "0x3CBBD60", VA = "0x183CBC960")]
	private void BPPNAPEOLLH(T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD1D0", Offset = "0x3CBC5D0", VA = "0x183CBD1D0")]
	private void MDJJMKIFNED(T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCA60", Offset = "0x3CBBE60", VA = "0x183CBCA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCDD0", Offset = "0x3CBC1D0", VA = "0x183CBCDD0")]
	private void FILLJPLFOND(IEnumerable<T> KLODBELJCDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CIIGGFOKHPP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Dictionary<int, T> INNPOFPBAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T GJDHPJDCFLL;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T PNCCFOJNIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x58FCE60", Offset = "0x58FC260", VA = "0x1858FCE60")]
	public bool OAIFNLOOELA(T HCPAOILCJCB, int HPFPPNDKBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4195360", Offset = "0x4194760", VA = "0x184195360")]
	public bool ODEANAEKGHL(int HPFPPNDKBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x58FC990", Offset = "0x58FBD90", VA = "0x1858FC990")]
	public T BAOJJBEADOG(int CLAPOLELOHE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x58FCBB0", Offset = "0x58FBFB0", VA = "0x1858FCBB0")]
	private bool GEIKDNDIKPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x58FCD50", Offset = "0x58FC150", VA = "0x1858FCD50")]
	public bool LINPJOCPLAE(int HPFPPNDKBPG, [Out] T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4195410", Offset = "0x4194810", VA = "0x184195410")]
	public CIIGGFOKHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class POCFPGOLAHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	protected struct KDFCBOEJOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T GFHLLJBPNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int HAKPHKPNEMN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	protected readonly List<KDFCBOEJOFL> LBOKCPIBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private T PIFMBNJEJJH;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x39C69D0", Offset = "0x39C5DD0", VA = "0x1839C69D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1720", Offset = "0x4CB0B20", VA = "0x184CB1720")]
	public bool PLOBJDDHBDK(T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0F80", Offset = "0x4CB0380", VA = "0x184CB0F80")]
	public void EBDKDKCDLND(T HCPAOILCJCB, int HPFPPNDKBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0CC0", Offset = "0x4CB00C0", VA = "0x184CB0CC0")]
	public bool BDKJEBALGLD(T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4CB0ED0", Offset = "0x4CB02D0", VA = "0x184CB0ED0")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4CB14D0", Offset = "0x4CB08D0", VA = "0x184CB14D0")]
	public T LPBDJOLNBGO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB12B0", Offset = "0x4CB06B0", VA = "0x184CB12B0")]
	protected void KGGACBBAJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB1980", Offset = "0x4CB0D80", VA = "0x184CB1980")]
	public POCFPGOLAHA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2000", Offset = "0x6FC1400", VA = "0x186FC2000")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC22D0", Offset = "0x6FC16D0", VA = "0x186FC22D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x6FC21E0", Offset = "0x6FC15E0", VA = "0x186FC21E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x6FC1F50", Offset = "0x6FC1350", VA = "0x186FC1F50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2220", Offset = "0x6FC1620", VA = "0x186FC2220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2130", Offset = "0x6FC1530", VA = "0x186FC2130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1ED0", Offset = "0x6FC12D0", VA = "0x186FC1ED0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FF60", Offset = "0x4E6F360", VA = "0x184E6FF60", Slot = "4")]
		public virtual T ODCBNLCNIOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JMIJMPCAHJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Dictionary<byte, KCMHGHBBEHL> DOIGMFBEILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly EDMMGCJIHED<KCMHGHBBEHL> KBOPJCAHHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly bool PCMKKINMHIO;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public KCMHGHBBEHL CMDOGOBIFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector2 IAPGLMIDCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x110C5D0", Offset = "0x110B9D0", VA = "0x18110C5D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x13F9DC0", Offset = "0x13F91C0", VA = "0x1813F9DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private Vector2 GMDHIEGNPCB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA8BDC0", Offset = "0xA8B1C0", VA = "0x180A8BDC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Vector2 IFGLHEDLKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE6A0", Offset = "0x6FBDAA0", VA = "0x186FBE6A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8D0CE0", Offset = "0x8D00E0", VA = "0x1808D0CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int ABOOKHMKPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B70", Offset = "0x8C6F70", VA = "0x1808C7B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D80", Offset = "0x8C7180", VA = "0x1808C7D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF410", Offset = "0x6FBE810", VA = "0x186FBF410")]
	public JMIJMPCAHJG(Bounds BGAIADJGELD, Vector2[] FPMEMMDNPAP, int GGPNGFCNLGJ, byte GDCLLKFPEAF, float AEKBPDAOHPJ = 0f, [Optional] EDMMGCJIHED<KCMHGHBBEHL> KBOPJCAHHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE860", Offset = "0x6FBDC60", VA = "0x186FBE860")]
	public void HCPEFICKHBJ(Bounds BGAIADJGELD, Vector2[] FPMEMMDNPAP, int GGPNGFCNLGJ, byte GDCLLKFPEAF, float AEKBPDAOHPJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6FBECF0", Offset = "0x6FBE0F0", VA = "0x186FBECF0")]
	public KCMHGHBBEHL HNDGBGNFOOO(byte IIACLAMOIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF340", Offset = "0x6FBE740", VA = "0x186FBF340")]
	public void KPFEIIPCIMN(Vector3 CPGMOBFHDAC, float BFEMEHELEAK, float KHGPBKMFMCJ, List<byte> OGNJKCEPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE460", Offset = "0x6FBD860", VA = "0x186FBE460")]
	public void AJECOCBODOF(KCMHGHBBEHL.MMBPKEKHMGM HJHMFFBJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE780", Offset = "0x6FBDB80", VA = "0x186FBE780")]
	public static int GLLCOJJFCGP(Vector2[] FPMEMMDNPAP, int GGPNGFCNLGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF110", Offset = "0x6FBE510", VA = "0x186FBF110")]
	private KCMHGHBBEHL KCBGEAGBIJB(byte IIACLAMOIEE, KCMHGHBBEHL.ACNLCGJNGAA HPKOKJKBBAK, KCMHGHBBEHL AMMKPAGCALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6FBED50", Offset = "0x6FBE150", VA = "0x186FBED50")]
	private void JDJKLDLPADM(KCMHGHBBEHL AMMKPAGCALK, Vector2[] FPMEMMDNPAP, int AOIKNGEOPEP, int JGDALIPHFMM, int GJHBHFHONDI, int IOFMFMCJCFP, float AEKBPDAOHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE480", Offset = "0x6FBD880", VA = "0x186FBE480")]
	private void BPBIHKMJJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE6C0", Offset = "0x6FBDAC0", VA = "0x186FBE6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE720", Offset = "0x6FBDB20", VA = "0x186FBE720", Slot = "1")]
	~JMIJMPCAHJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KCMHGHBBEHL
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum ACNLCGJNGAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum MMBPKEKHMGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte ODDAFMAOMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3 NPBGNPJNJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 EMINOKGEAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 AAHIGGHMHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 HOJBNDIKPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ACNLCGJNGAA IMBOKLNEMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public KCMHGHBBEHL HOBMCFDJPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public List<KCMHGHBBEHL> ODLDGPJODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool INJNMACFGLK;

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0250", Offset = "0x6FBF650", VA = "0x186FC0250")]
	public KCMHGHBBEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFDF0", Offset = "0x6FBF1F0", VA = "0x186FBFDF0")]
	public void JJNGPMHDKCP(KCMHGHBBEHL FKLPGABAEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	public void AJECOCBODOF(int MCNAAIOPCGD, MMBPKEKHMGM HJHMFFBJGAN, int AFOMFDJIHAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFF60", Offset = "0x6FBF360", VA = "0x186FBFF60")]
	public void KPFEIIPCIMN(List<byte> OGNJKCEPIIL, Vector3 CPGMOBFHDAC, float BFEMEHELEAK, float KHGPBKMFMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFDC0", Offset = "0x6FBF1C0", VA = "0x186FBFDC0")]
	public bool FGNILICPNEN(Vector3 PEOHBJGLDBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFF30", Offset = "0x6FBF330", VA = "0x186FBFF30")]
	public bool KGAALCGPLEH(Vector3 PEOHBJGLDBB, float HGCBLCNCCKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6FC01C0", Offset = "0x6FBF5C0", VA = "0x186FC01C0")]
	public void OOJJEJPOBFE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public struct PJIMGMGEBGO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private readonly List<Component> CECMFLAILAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private readonly bool MKKMIKAGDPB;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x12D9330", Offset = "0x12D8730", VA = "0x1812D9330")]
			public PJIMGMGEBGO(List<Component> CECMFLAILAL, bool MKKMIKAGDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x4C6FA30", Offset = "0x4C6EE30", VA = "0x184C6FA30")]
			public BEDPPFJILNP<T> JDJKPBEKJIJ()
			{
				return default(BEDPPFJILNP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x4C6FAA0", Offset = "0x4C6EEA0", VA = "0x184C6FAA0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x4C6FAA0", Offset = "0x4C6EEA0", VA = "0x184C6FAA0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct BEDPPFJILNP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private readonly List<Component> CECMFLAILAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private readonly bool MKKMIKAGDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private int IIACLAMOIEE;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T DLFFLJHEEDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x53C8C00", Offset = "0x53C8000", VA = "0x1853C8C00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x53C8B90", Offset = "0x53C7F90", VA = "0x1853C8B90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x53C8BD0", Offset = "0x53C7FD0", VA = "0x1853C8BD0")]
			public BEDPPFJILNP(List<Component> CECMFLAILAL, bool MKKMIKAGDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x53C8AD0", Offset = "0x53C7ED0", VA = "0x1853C8AD0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x53C8AE0", Offset = "0x53C7EE0", VA = "0x1853C8AE0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x3D34A80", Offset = "0x3D33E80", VA = "0x183D34A80", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6FC3CC0", Offset = "0x6FC30C0", VA = "0x186FC3CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3AC0", Offset = "0x6FC2EC0", VA = "0x186FC3AC0")]
		private void OOJJEJPOBFE(GameObject HHPGFBGKJGL, bool MKNFMGNFODH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3A30", Offset = "0x6FC2E30", VA = "0x186FC3A30")]
		public static void OOJJEJPOBFE(GameObject HHPGFBGKJGL, ToolHierarchyCache JDENFLNKFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3A20", Offset = "0x6FC2E20", VA = "0x186FC3A20")]
		public void NKJEKPHJAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3386550", Offset = "0x3385950", VA = "0x183386550")]
		public void EBOGAPENIPK<T>(Action<T> OLHFOBIBHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3386780", Offset = "0x3385B80", VA = "0x183386780")]
		public T OGFBFHGKDFG<T>(bool MKKMIKAGDPB = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x33864A0", Offset = "0x33858A0", VA = "0x1833864A0")]
		public PJIMGMGEBGO<T> DEJKAJDCPCJ<T>(bool MKKMIKAGDPB = false) where T : class
		{
			return default(PJIMGMGEBGO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC36D0", Offset = "0x6FC2AD0", VA = "0x186FC36D0")]
		public List<Component> HOHCLCOCOPG(Type IFBDJLKPHIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC35E0", Offset = "0x6FC29E0", VA = "0x186FC35E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KENGFOGLPKI, ToolHierarchyCache IFGPABAHODO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3660", Offset = "0x6FC2A60", VA = "0x186FC3660", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NCHBKHMIMGJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class ICGHFIHNFBL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int GNOHMAFCFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int FFIFIFAINPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<T> MFECDBFEDPJ;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x404EB40", Offset = "0x404DF40", VA = "0x18404EB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public T MGJENIPPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x432AEA0", Offset = "0x432A2A0", VA = "0x18432AEA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T ONACFGAKOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x432B1B0", Offset = "0x432A5B0", VA = "0x18432B1B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T LPOAHPFDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x432B0C0", Offset = "0x432A4C0", VA = "0x18432B0C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x432B230", Offset = "0x432A630", VA = "0x18432B230")]
	public ICGHFIHNFBL(int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x432AA20", Offset = "0x4329E20", VA = "0x18432AA20")]
	public void EBDKDKCDLND(T LKNOLBIMPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x432A940", Offset = "0x4329D40", VA = "0x18432A940")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x432AD00", Offset = "0x432A100", VA = "0x18432AD00")]
	public void GOIHKBKJNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x432A9A0", Offset = "0x4329DA0", VA = "0x18432A9A0")]
	public void CPKDDCNDDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x432AA10", Offset = "0x4329E10", VA = "0x18432AA10")]
	public void DMIIPGDDOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x432AE00", Offset = "0x432A200", VA = "0x18432AE00")]
	public List<T> HBJAIHNENIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class PMGDGCHNEPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct ALKELPGADND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int HAKPHKPNEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public T GFHLLJBPNAP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly Dictionary<object, ALKELPGADND> INNPOFPBAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly EqualityComparer<T> CDKMLLGACFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private T GJDHPJDCFLL;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public virtual T PNCCFOJNIKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96E320", VA = "0x18096EF20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4CA90E0", Offset = "0x4CA84E0", VA = "0x184CA90E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool AGJOLDIKCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9050", Offset = "0x4CA8450", VA = "0x184CA9050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public object OBKJCAKBCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C80", Offset = "0x8C8080", VA = "0x1808C8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD170", Offset = "0x4CAC570", VA = "0x184CAD170")]
	public bool OAIFNLOOELA(T HCPAOILCJCB, object CMNJCPJBHGE, int HPFPPNDKBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD710", Offset = "0x4CACB10", VA = "0x184CAD710")]
	public bool ODEANAEKGHL(object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4CAC000", Offset = "0x4CAB400", VA = "0x184CAC000")]
	public bool LINPJOCPLAE(object CMNJCPJBHGE, [Out] T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x43537D0", Offset = "0x4352BD0", VA = "0x1843537D0")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4CAAED0", Offset = "0x4CAA2D0", VA = "0x184CAAED0")]
	private bool GEIKDNDIKPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD7D0", Offset = "0x4CACBD0", VA = "0x184CAD7D0")]
	public PMGDGCHNEPM()
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
