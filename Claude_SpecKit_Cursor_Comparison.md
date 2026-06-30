# Claude Code vs GitHub Spec Kit vs Cursor  
### Full Engineering Comparison (SDD, Architecture, Cloud, Team Workflow)

---

## ⭐ Executive Summary

Claude Code → Deep reasoning, multi-step execution, best for complex features  
GitHub Spec Kit → Enterprise-grade SDD, durable specs, architecture governance  
Cursor → Fast iteration, developer productivity, lightweight SDD

Best combined workflow: **Spec Kit (specs) + Claude Code (execution) + Cursor (iteration)**

---

# 1. Spec-Driven Development Capabilities

| Capability | Claude Code | GitHub Spec Kit | Cursor |
|-----------|-------------|------------------|--------|
| Structured spec ingestion | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ |
| Spec → Plan → Tasks → Code | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ |
| Spec-as-source (regenerate entire module) | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| Durable specs (long-term) | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| Multi-file consistency | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ |
| Best use case | Feature-level SDD | Enterprise SDD | Fast iteration |

---

# 2. Architecture Alignment (Clean Architecture + DDD)

| Area | Claude Code | Spec Kit | Cursor |
|------|-------------|----------|--------|
| Clean Architecture enforcement | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ |
| Domain modeling | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ |
| Layer boundaries (Domain/App/Infra) | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| Microservice consistency | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| Cloud architecture alignment | ⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐ |

---

# 3. Cloud-Native Development (AWS + Kubernetes)

| Area | Claude Code | Spec Kit | Cursor |
|------|-------------|----------|--------|
| AWS reasoning (SQS, S3, EKS) | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐ |
| Kubernetes manifests | ⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐ |
| Resilience patterns (retry, DLQ, backoff) | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐ |
| IaC (Terraform/CDK) | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ |

---

# 4. Multi-Agent / Multi-Step Reasoning

| Area | Claude Code | Spec Kit | Cursor |
|------|-------------|----------|--------|
| Multi-agent research | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Multi-step task execution | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐⭐ |
| Complex refactors | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐ |
| Architecture exploration | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐ |

---

# 5. Team Workflow + Leadership

| Area | Claude Code | Spec Kit | Cursor |
|------|-------------|----------|--------|
| Onboarding juniors | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐⭐ |
| Cross-team governance | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| Spec durability | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |
| PR-sized task generation | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ |
| Enterprise alignment | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐ |

---

# 6. Developer Productivity

| Area | Claude Code | Spec Kit | Cursor |
|------|-------------|----------|--------|
| Speed | ⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐⭐⭐ |
| Refactor velocity | ⭐⭐⭐⭐ | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ |
| IDE integration | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ |
| “Fix this file” workflows | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐⭐⭐ |

---

# ⭐ Best Tool Cheat Sheet (Option E)

## If you're designing a new microservice (Clean Architecture + AWS)
➡️ **Claude Code**

## If you're enforcing architecture consistency across 10+ services
➡️ **Spec Kit**

## If you're doing a quick refactor or spike
➡️ **Cursor**

## If you're migrating a legacy system (e.g., .NET Framework → .NET 8)
➡️ **Claude Code**

## If you're building a long-lived feature with evolving requirements
➡️ **Spec Kit + Claude Code**

## If you're doing cloud architecture exploration (EKS, SQS, S3)
➡️ **Claude Code**

## If you're onboarding junior developers
➡️ **Claude Code**

## If you want enterprise-level governance
➡️ **Spec Kit**

## If you want rapid prototyping
➡️ **Cursor**

---

# 🎯 Recommended Combined Workflow

1. **Spec Kit** → Write durable specs + architecture rules  
2. **Claude Code** → Execute tasks, generate code, handle complexity  
3. **Cursor** → Fast iteration, refactors, developer productivity  

This gives you rigor + intelligence + speed.

---

# 📌 End of Markdown File
